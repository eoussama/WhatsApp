using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whatsapp
{
    public partial class ucClock : UserControl
    {
        public Label date;
        public Label time;

        public ucClock()
        {
            InitializeComponent();

            date = label_date;
            time = label_time;

            date.Text = DateTime.Now.ToShortDateString();
            time.Text = DateTime.Now.ToLongTimeString();
            timer_clock.Start();
        }

        private void timer_clock_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToShortDateString();
            time.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
