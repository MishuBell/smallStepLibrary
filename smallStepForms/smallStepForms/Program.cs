using System;
using System.Windows.Forms;
using smallStep;



namespace smallStep
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new STEPSearchForm());

            // Add the Connection string to be added as an argument for the generate mockdata class
        }
    }
}
