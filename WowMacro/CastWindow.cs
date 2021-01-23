using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WowMacro
{
    class WowWindow
    {
        public Process process;
        public String name;
        public WowWindow(Process process, String name)
        {
            this.name = name;
            this.process = process;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
