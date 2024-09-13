using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueApp
{
    public partial class CustomerView : Form
    {
        private Timer timer;

        public CustomerView()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();


        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateNextNumber();
        }

        private void UpdateNextNumber()
        {
            if (CashierClass.CashierQueue.Count > 0)
            {
                string nextNumber = CashierClass.CashierQueue.Peek();
                lblNextNumber.Text = nextNumber;
            }
        }
    }
}
