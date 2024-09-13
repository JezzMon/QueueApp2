using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new QueuingForm());
            */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create instances of both forms
            QueuingForm queuingForm = new QueuingForm();
            CashierWindowQueueForm cashierWindowForm = new CashierWindowQueueForm();

            // Show both forms
            queuingForm.Show();
            cashierWindowForm.Show();

            // Run the application using the main form (could be any of the two)
            Application.Run(queuingForm);
        }
    }
}
