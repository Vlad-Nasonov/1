using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Task_1__2_semestor_
{
    static class Program
    {
       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
