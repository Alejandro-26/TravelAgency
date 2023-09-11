using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency.Formularios
{
    public partial class TarjetaCredito : Form
    {
        public TarjetaCredito()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            String name = txtCardName.Text;
            lblNameTarjeta.Text = name;

            string numeroTarjeta  = txtCardNumber.Text;
            lblNumber.Text = numeroTarjeta;

            string fecha = dateTimeTarjeta.Text;
            lblFecha.Text = fecha.ToString();

            string cvv = txtCVV.Text;
            lblCVV.Text = cvv.ToString();

            if (name == txtCardName.Text)
            {
                MessageBox.Show("Tu pago fue registrado exitosamente", "Exit");
                this.Hide();
            }
        }
    }
}
