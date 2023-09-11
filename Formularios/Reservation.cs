using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Formularios;

namespace TravelAgency
{
   

    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private void groupDatos_Enter(object sender, EventArgs e)
        {

        }
       

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string sumnames = txtSirnames.Text;
            string identificacion = txtIdentification.Text;
            string telefono = txtPhone.Text;
            string address = txtAddress.Text;
            string email = txtEmail.Text;
            string city = txtCity.Text;

            if (name == "" && sumnames == "" && identificacion == "" && telefono == "" && address == "" && email == "" && city == "")
            {
                MessageBox.Show("Por favor llenar el formulario correctamente");
            }
            else 
            {
                MessageBox.Show("Sus datos se han registrado correctamente");
                txtName.Text = "";
                txtSirnames.Text = "";
                txtIdentification.Text = "";
                txtPhone.Text = "";
                txtAddress.Text = "";
                txtEmail.Text = "";
                txtCity.Text = "";

                groupOpciones.Visible = true;
                groupTarifas.Visible = true;
                groupFormaPaga.Visible = true;
                groupBoxLiquidacionReserva.Visible = true;
                groupBoxTotalPaga.Visible = true;
                btnLiquidar.Visible = true;
                btnNuevo.Visible = true;
                btnReservar.Visible = true;
                btnSalir.Visible = true;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string buscar = Microsoft.VisualBasic.Interaction.InputBox("ID", "Buscar Cedual");

            if (buscar == txtName.Text)
            {
                MessageBox.Show("Registro Encontrado.");
            }
        }

        private void groupOpciones_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            comboBoxCiudad.Text = "";
            comboBoxPersonas.Text = "";
        }

        private void checkBoxTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            //this.Hide();
            TarjetaCredito tarjetaCredito = new TarjetaCredito();   
            tarjetaCredito.ShowDialog();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLiquidar_Click(object sender, EventArgs e)
        {
            string ciudad = comboBoxCiudad.Text;
            int numPersonas = int.Parse(comboBoxPersonas.Text);
            int diasExcursion = int.Parse(txtDiasExcursion.Text);

           

            if (ciudad == "A" && diasExcursion == 5) 
            {
                lblAlojamiento.Text = "15.000";
                lblTiquete.Text = "100.000";
                lblComida.Text = "9.000";

               
            }





            
          

        }
    }
}
