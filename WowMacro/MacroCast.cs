using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace WowMacro
{
    class MacroCast
    {
        private int key = -1;
        private int interval = 100;
        private int cooldown = 0;
        private int keyDelay = 100;
        private bool target = true;
        private DateTime lastCast;
        const UInt32 WM_KEYDOWN = 0x0100;

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        public static extern IntPtr PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        public void sendKeystroke(ushort k, IntPtr hWnd)
        {
            const uint WM_KEYDOWN = 0x100;
            const uint WM_KEYUP = 0x101;

            PostMessage(hWnd, WM_KEYDOWN, ((IntPtr)k), (IntPtr)0);
            PostMessage(hWnd, WM_KEYUP, ((IntPtr)k), (IntPtr)0);
        }

        public MacroCast(int key, int interval, int cooldown, bool target)
        {
            this.key = key;
            this.interval = interval;
            this.cooldown = cooldown;
            this.target = target;
        }

        public void cast(WowWindow wowWindow, List<MacroCast> macroCasts)
        {
            if(validKey())
            {            
                if (readyToCast(macroCasts))
                {
                    if (key == -1001)
                    {
                        var sc = new ScreenCapturer();
                        var bitmap = sc.GetScreenshot(wowWindow.process.MainWindowHandle);
                        sc.WriteBitmapToFile("C:\\Users\\PICHAU\\Nox_share\\ImageShare\\Screenshots\\" + wowWindow.name+".png", bitmap);
                        Thread.Sleep(interval);
                    }
                    else
                    {
                        if (target)
                        {
                            sendKeystroke((ushort)0x30, wowWindow.process.MainWindowHandle);
                            Thread.Sleep(200);
                        }
                        sendKeystroke((ushort)key, wowWindow.process.MainWindowHandle);
                        Thread.Sleep(interval);
                    }
                }

            }
        }

        private bool readyToCast(List<MacroCast> macroCasts)
        {
            foreach(MacroCast macroCast in macroCasts)
            {
                if(macroCast.key == this.key)
                {
                    if (!macroCast.canCast())
                    {
                        return false;
                    }
                }
            }

            return true;
        }     

        private Boolean canCast()
        {
            DateTime now = DateTime.UtcNow;

            if (lastCast == null)
            {
                lastCast = now;
                return true;
            }
            else
            {                
                TimeSpan difference = now.Subtract(lastCast);
                if (difference.TotalSeconds*1000 >= cooldown+keyDelay+interval) {
                    lastCast = now;
                    return true;
                }
                else
                {
                    return false;
                }
            }           
        }

        public Boolean validKey()
        {
            return key != 1;
        }

        public int getInterval() => this.interval;

    }
}
