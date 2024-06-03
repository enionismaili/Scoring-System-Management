using System;
using System.Windows.Forms;

namespace TournamentScoringSystem
{
    static class Program
    {
        // Main method, the entry point of the application
        [STAThread]
        static void Main()
        {
            // Enables visual styles for the application
            Application.EnableVisualStyles();
            // Sets the application to use compatible text rendering for older versions of Windows
            Application.SetCompatibleTextRenderingDefault(false);
            // Starts the application and opens the MainForm
            Application.Run(new MainForm());
        }
    }
}
