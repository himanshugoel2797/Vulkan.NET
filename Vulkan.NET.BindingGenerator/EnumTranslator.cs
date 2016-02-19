using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Vulkan.NET.BindingGenerator
{
    public partial class Translator
    {
        private static string[] SplitCapitalized(string source)
        {
            var parts0 = Regex.Split(source, @"(?<!^)(?=[A-Z])");

            List<string> parts = new List<string>();

            for (int j = 0; j < parts0.Length - 1; j++)
            {
                if (parts0[j].Length == 1 && char.IsUpper(parts0[j][0]) && parts0[j + 1].Length == 1 && char.IsUpper(parts0[j + 1][0]))
                {
                    parts[parts.Count - 1] += parts0[j + 1];
                }
                else parts.Add(parts0[j]);
            }

            for (int j = 0; j < parts.Count; j++)
            {
                parts[j] = parts[j].ToUpperInvariant();
            }
            return parts.ToArray();
        }

        private static string RefactorToCamelCase(string source)
        {
            var parts = source.Split('_').Where(a => !string.IsNullOrEmpty(a)).ToArray();
            string result = "";

            var matchTargets = new string[] { "khr", "srgb", "rgb", "rgba", "ext" };

            for (int i = 0; i < parts.Length; i++)
            {
                parts[i] = parts[i].ToLowerInvariant();
                parts[i] = char.ToUpper(parts[i][0]) + parts[i].Substring(1);

                if (matchTargets.Contains(parts[i].ToLowerInvariant()))
                {
                    if (i < parts.Length - 1 && matchTargets.Contains(parts[i + 1].ToLowerInvariant())) parts[i] = parts[i].ToUpperInvariant() + "_";
                    else parts[i] = parts[i].ToUpperInvariant();
                }
                result += parts[i];
            }

            return result;
        }

        private static string TranslateTypeName(string name)
        {
            name = name.Replace("Vk", "");

            if (name == typeof(uint).Name) name = "uint";
            if (name == typeof(int).Name) name = "int";
            if (name == typeof(ulong).Name) name = "ulong";
            if (name == typeof(long).Name) name = "long";
            if (name == typeof(IntPtr).Name) name = "System.IntPtr";
            if (name == typeof(float).Name) name = "float";
            if (name == typeof(double).Name) name = "double";
            if (name == typeof(string).Name) name = "string";
            if (name == typeof(char).Name) name = "char";
            if (name == typeof(void).Name) name = "void";

            return name;
        }

        private static string TranslateTypeName(Type t)
        {
            string name = TranslateTypeName(t.Name);
            if (t.IsByRef)
            {
                name = "ref " + name;
                name = name.Remove(name.Length - 1);
            }
            return name;
        }

        private static string TranslateTypeName(FieldInfo t)
        {
            string name = t.FieldType.Name;
            if (t.GetCustomAttributes(typeof(FixedBufferAttribute), false).Length != 0)
            {
                name = t.GetCustomAttributes(typeof(FixedBufferAttribute), false)
                .Cast<FixedBufferAttribute>()
                .Single()
                .ElementType.Name;

                return TranslateTypeName(name);
            }
            else return TranslateTypeName(t.FieldType);
        }

        //Clean up the vulkan.cs code by refactoring all the enums
        private static string ProcessEnum(Type enumDat)
        {
            string code = $"public enum {enumDat.Name.Replace("Vk", "")} {{ {Environment.NewLine}";

            var enumVals = enumDat.GetEnumValues();
            var enumNames = enumDat.GetEnumNames();

            for (int i = 0; i < enumVals.Length; i++)
            {
                string enumEntry = enumNames[i];

                string[] parts = SplitCapitalized(enumDat.Name);

                for (int j = 0; j < parts.Length; j++)
                {
                    if (enumEntry.Contains(parts[j] + "_")) enumEntry = enumEntry.Replace(parts[j] + "_", "_");
                }

                enumEntry = RefactorToCamelCase(enumEntry);
                if (!char.IsLetter(enumEntry[0])) enumEntry = "_" + enumEntry;

                code += enumEntry + " = " + Convert.ChangeType(enumVals.GetValue(i), Enum.GetUnderlyingType(enumDat)) + "," + Environment.NewLine;
            }

            code += "}" + Environment.NewLine + Environment.NewLine;
            return code;
        }

        private static string ProcessAttributes(CustomAttributeData[] structAttr)
        {
            string code = "";
            for (int i = 0; i < structAttr.Length; i++)
            {
                if (structAttr[i].AttributeType == typeof(FixedBufferAttribute))
                    continue;

                code += $"[{structAttr[i].AttributeType.FullName}(";

                var ctorArgs = structAttr[i].ConstructorArguments.ToArray();
                for (int j = 0; j < ctorArgs.Length; j++)
                {
                    if (ctorArgs[j].ArgumentType != typeof(string)) code += $"({TranslateTypeName(ctorArgs[j].ArgumentType.FullName)})" + ctorArgs[j].Value;
                    else code += $"\"{ctorArgs[j].Value}\"";

                    if (j < ctorArgs.Length - 1) code += ",";
                }

                var namedArgs = structAttr[i].NamedArguments.ToArray();
                for (int j = 0; j < namedArgs.Length; j++)
                {
                    if (structAttr[i].AttributeType == typeof(MarshalAsAttribute) && namedArgs[j].MemberName == "SizeParamIndex" && namedArgs[j].TypedValue.Value.ToString() == "0") continue;
                    if (structAttr[i].AttributeType == typeof(MarshalAsAttribute) && namedArgs[j].MemberName == "SafeArraySubType" && namedArgs[j].TypedValue.Value.ToString() == "0") continue;
                    if (structAttr[i].AttributeType == typeof(MarshalAsAttribute) && namedArgs[j].MemberName == "ArraySubType" && namedArgs[j].TypedValue.Value.ToString() == "0") continue;
                    code += ",";
                    code += namedArgs[j].MemberName + " = ";
                    if (namedArgs[j].TypedValue.ArgumentType != typeof(string)) code += $"({TranslateTypeName(namedArgs[j].TypedValue.ArgumentType.FullName)})" + namedArgs[j].TypedValue.Value;
                    else code += "\"" + namedArgs[j].TypedValue.Value + "\"";
                }
                code += ")]" + Environment.NewLine;
            }
            return code;
        }

        public static string ProcessStruct(Type structDat)
        {
            string code = "";

            if (structDat.GetCustomAttributes(typeof(System.Runtime.CompilerServices.CompilerGeneratedAttribute), false).Length != 0) return "";   //Skip compiler generated types

            code += ProcessAttributes(structDat.CustomAttributes.ToArray());
            code += $"[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.{structDat.StructLayoutAttribute.Value})]";

            code += "public ";

            if (structDat.GetFields().Any((a) => a.GetCustomAttributes(typeof(FixedBufferAttribute)).Count() != 0))
                code += "unsafe ";

            code += $"struct {structDat.Name.Replace("Vk", "")} {{ {Environment.NewLine}";

            var structVals = structDat.GetFields();

            for (int k = 0; k < structVals.Length; k++)
            {
                code += ProcessAttributes(structVals[k].CustomAttributes.ToArray());
                code += "public ";

                if (structVals[k].GetCustomAttributes(typeof(FixedBufferAttribute)).Count() != 0)
                {
                    code += "fixed ";
                }

                code += TranslateTypeName(structVals[k]) + " " + structVals[k].Name;

                if (structVals[k].GetCustomAttributes(typeof(FixedBufferAttribute)).Count() != 0)
                {
                    code += "[" + structVals[k].CustomAttributes.Single(a => a.AttributeType == typeof(FixedBufferAttribute)).ConstructorArguments[1] + "]";
                }

                code += ";" + Environment.NewLine;
            }

            code += "}" + Environment.NewLine + Environment.NewLine;
            return code;
        }

        public static string ProcessMulticastDelegate(Type mDel)
        {
            string code = "";

            MethodInfo mInfo = mDel.GetMethod("Invoke");

            code += ProcessAttributes(mDel.CustomAttributes.ToArray());
            code += "public delegate ";
            code += TranslateTypeName(mInfo.ReturnType);
            code += " " + mDel.Name + "(";

            //parse the parameter list
            var parameters = mInfo.GetParameters();
            for (int i = 0; i < parameters.Length; i++)
            {
                code += TranslateTypeName(parameters[i].ParameterType) + " ";

                if (new string[] { "event", "object" }.Contains(parameters[i].Name))
                    code += "@" + parameters[i].Name;
                else code += parameters[i].Name;

                if (i < parameters.Length - 1) code += ",";
            }

            code += ");" + Environment.NewLine + Environment.NewLine;
            return code;
        }

        public static string ProcessMethod(MethodInfo mthd)
        {
            if (mthd.Name.StartsWith("_") | (mthd.MethodImplementationFlags & MethodImplAttributes.Native) == 0) return "";
            string code = "";

            MethodInfo mInfo = mthd;

            code += ProcessAttributes(mthd.CustomAttributes.ToArray());
            code += "public static extern ";
            code += TranslateTypeName(mInfo.ReturnType);
            code += " " + mthd.Name.Replace("vk", "") + "(";

            //parse the parameter list
            var parameters = mInfo.GetParameters();
            for (int i = 0; i < parameters.Length; i++)
            {
                code += TranslateTypeName(parameters[i].ParameterType) + " ";

                if (new string[] { "event", "object" }.Contains(parameters[i].Name))
                    code += "@" + parameters[i].Name;
                else code += parameters[i].Name;

                if (i < parameters.Length - 1) code += ",";
            }

            code += ");" + Environment.NewLine + Environment.NewLine;
            return code;
        }

        public static string ProcessMethods(Type classT)
        {
            string code = "";
            var mthds = classT.GetMethods();

            for (int i = 0; i < mthds.Length; i++)
            {
                code += ProcessMethod(mthds[i]);
            }

            return code;
        }

        public static string ProcessLibrary(string file)
        {
            Assembly a = Assembly.LoadFile(file);
            string code = @"
using System;

namespace Vulkan.NET
{
public class Vk
{
";
            var expTypes = a.ExportedTypes.ToArray();

            for (int i = 0; i < expTypes.Length; i++)
            {
                if (expTypes[i].IsEnum) code += ProcessEnum(expTypes[i]);
                else if (expTypes[i].IsValueType) code += ProcessStruct(expTypes[i]);
                else if (expTypes[i].BaseType == typeof(MulticastDelegate)) code += ProcessMulticastDelegate(expTypes[i]);
                else if (expTypes[i].Name == "NativeMethods") code += ProcessMethods(expTypes[i]);
            }

            code += $"}}{Environment.NewLine}}}";
            return code;
        }
    }
}
