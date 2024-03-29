﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WowMacro
{
    class MacroUtils
    {
            public static MacroCast getInstruction(String line)
        {
            if (line.Contains(",")) {
                var lineSplit = line.Split(',');
                return new MacroCast(stringToKeyCode(lineSplit[0]), int.Parse(lineSplit[1]), int.Parse(lineSplit[2]), bool.Parse(lineSplit[3]));
             }
            else
            {
                return null;
            }
        }


        public static int stringToKeyCode(String key)
        {
            switch (key.ToLower())
            {
                case "0":
                    return 0x30;
                case "1":
                    return 0x31;
                case "2":
                    return 0x32;
                case "3":
                    return 0x33;
                case "4":
                    return 0x34;
                case "5":
                    return 0x35;
                case "6":
                    return 0x36;
                case "7":
                    return 0x37;
                case "8":
                    return 0x38;
                case "9":
                    return 0x39;
                case "a":
                    return 0x41;
                case "b":
                    return 0x42;
                case "c":
                    return 0x43;
                case "d":
                    return 0x44;
                case "e":
                    return 0x45;
                case "f":
                    return 0x46;
                case "g":
                    return 0x47;
                case "h":
                    return 0x48;
                case "i":
                    return 0x49;
                case "j":
                    return 0x4A;
                case "k":
                    return 0x4B;
                case "l":
                    return 0x4C;
                case "m":
                    return 0x4D;
                case "n":
                    return 0x4E;
                case "o":
                    return 0x4F;
                case "p":
                    return 0x50;
                case "q":
                    return 0x51;
                case "r":
                    return 0x52;
                case "s":
                    return 0x53;
                case "t":
                    return 0x54;
                case "u":
                    return 0x55;
                case "v":
                    return 0x56;
                case "w":
                    return 0x57;
                case "x":
                    return 0x58;
                case "y":
                    return 0x59;
                case "z":
                    return 0x5A;
                case "f1":
                    return 0x70;
                case "f2":
                    return 0x71;
                case "f3":
                    return 0x72;
                case "f4":
                    return 0x73;
                case "f5":
                    return 0x74;
                case "f6":
                    return 0x75;
                case "f7":
                    return 0x76;
                case "f8":
                    return 0x77;
                case "f9":
                    return 0x78;
                case "f10":
                    return 0x79;
                case "f11":
                    return 0x7A;
                case "f12":
                    return 0x7B;
                case "[":
                    return 0xDB;
                case "]":
                    return 0xDD;
                case "ss":
                    return -1001;

            }

            return -1;
        }

    }

}
