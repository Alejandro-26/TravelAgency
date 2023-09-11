using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureFirma_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            groupRegistro.Visible = true;
        }

        private void comboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txtIdUsuario.Text;
            string nombre = txtName.Text;
            string contra = txtPassword.Text;
           

            if (txtIdUsuario.Text == "")
            {
                errorProvider.SetError(txtIdUsuario,"El campo no puede quedar en blanco");
                return;
            }else if (txtName.Text == "")
            {
                errorProvider.SetError(txtName, "Se requiere de su nombre para compñetar el registro...");
                return;
            }else if (txtPassword.Text == "")
            {
                errorProvider.SetError(txtPassword, "Por favor asigne una contraseña de uso personal.");
                return;
            }
            else
            {
                MessageBox.Show("Su registro es un exito.");
                groupInicioSection.Visible = true;
                groupRegistro.Visible = false;
                
                btnProximo.Visible = false;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string pass = txtPassword.Text;

            if (txtInicioSection.Text != name)
            {
                errorProvider.SetError(txtInicioSection, "El nombre del usuario no es correcto..");
                return;
            }else if (txtInicoPassword.Text != pass) 

            {
                errorProvider.SetError(txtInicoPassword, "La contraseña es incorrecta...");
                return;
            }

            this.Hide();
            FrmularioBienvenida formularip = new FrmularioBienvenida();
            formularip.ShowDialog();

            txtInicioSection.Text = "";
            txtInicoPassword.Text = "";

            Reservation frm = new Reservation();
            frm.Show();
            Hide();
 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
