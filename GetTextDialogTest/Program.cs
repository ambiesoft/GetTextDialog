using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ambiesoft;

namespace GetTextDialogTest
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string s = null;
                if (GetTextDialog.DoModalDialog(null, "test", "testlabel", ref s))
                {
                    Console.WriteLine("DoModalDialog returns true.");
                    Console.WriteLine(" s=" + s);
                }
                else
                {
                    Console.WriteLine("DoModalDialog returns false.");
                }
            }

            {

                string s = null;
                bool check = true;
                if (GetTextDialog.DoModalDialogCheck(null, "titlecheck", "labelcheck", "checkme", ref s, ref check))
                {
                    Console.WriteLine("DoModalDialogCheck returns true.");
                    Console.WriteLine(" s=" + s);
                    Console.WriteLine(" check=" + check);
                }
                else
                {
                    Console.WriteLine("DoModalDialogCheck returns false.");
                }
            }
        }
    }
}
