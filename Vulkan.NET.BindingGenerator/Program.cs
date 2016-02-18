using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vulkan.NET.BindingGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.File.WriteAllText("../../test.cs", Translator.ProcessLibrary(System.IO.Path.GetFullPath("Vulkan.NET.dll")));
        }
    }
}
