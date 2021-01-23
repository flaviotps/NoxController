using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace WowMacro
{
    class MacroController
    {
        private Task farmTask;
        private WowWindow wowWindow;
        private List<MacroCast> macroCasts;
        private Boolean running = true;

        public WowWindow getWowWindow()
        {
            return wowWindow;
        }

        public void stop()
        {
            running = false;
        }

        public void restart()
        {
            running = true;
            startMacro();
        }

        public MacroController(WowWindow wowWindow)
        {
            this.wowWindow = wowWindow;
        }

        public void startMacro()
        {
            macroCasts = createMacroCastList();
            farmTask = new Task(() => executeFarmMacro());
            farmTask.Start();
        }

        public List<MacroCast> createMacroCastList()
        {
            List<MacroCast> macroCasts = new List<MacroCast>();
            string[] lines = System.IO.File.ReadAllLines(@"macro_farm.txt");

            foreach (string line in lines)
            {
                var macroCast = MacroUtils.getInstruction(line);
                if (macroCast != null)
                {
                    macroCasts.Add(macroCast);
                }
            }
            return macroCasts;
        }

        private void executeFarmMacro()
        {
            while (running)
            {
                foreach (MacroCast macroCast in macroCasts)
                {
                    macroCast.cast(wowWindow, macroCasts);
                }

                Thread.Sleep(15000);
            }
        }
    }

}

   
