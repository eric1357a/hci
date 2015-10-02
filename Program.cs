using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using HCI.Forms;

namespace HCI
{
    static class Program
    {
        public static RootForm Root;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Enforce DPI awareness from user32.dll
            // Answer from Hans Passant, http://stackoverflow.com/a/13228495

            if (Environment.OSVersion.Version.Major >= 6) SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Root = new HCI.Forms.RootForm();
            Application.Run(Root);
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
