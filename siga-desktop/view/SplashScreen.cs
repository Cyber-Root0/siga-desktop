using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace siga_desktop.view
{
    public partial class SplashScreen : Form
    {
        Thread t1;
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void open(object obj)
        {
            Application.Run(new view.aluno.Main());
        }

        private void timer_Tick_1(object sender, EventArgs e)
        {
            if (panel_list.Width >= 599)
            {
                timer.Enabled = false;
                this.Close();
                t1 = new Thread(open);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            }
            else
            {
                panel_list.Width += 6;

            }
        }
    }
}
