using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.数据库封装类
{
    public class Module
    {
        public Module() { }
        public int ModuleId { get; set; }
        public string ModuleName { get; set; }

        public Module(int moduleId, string moduleName)
        {
            ModuleId = moduleId;
            ModuleName = moduleName;
        }
    }

}
