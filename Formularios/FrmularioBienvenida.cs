using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class FrmularioBienvenida : Form
    {
        public FrmularioBienvenida()
        {
            InitializeComponent();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ( this.Opacity < 3)
            {
                this.Opacity += 0.05;

               circularProgressBar1.Value ++;
                circularProgressBar1.Text = circularProgressBar1.Value.ToString();
            }
            if (circularProgressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.5;

            if( this.Opacity == 0 ) 
            {
                timer2.Stop();
                this.Close();
            }
        }

        private void FrmularioBienvenida_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;

            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;

            timer1.Start();
        }
    }
}
