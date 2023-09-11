using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TravelAgency.Logica
{
    //Clse Clientes.
    public class Clientes
    {
        private string nombre;
        private string apellidos;
        private string cedula;
        private string telefono;
        private string direccion;
        private string correo;
        private string ciudad;


        //Modificadores GET, SET.
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        //Contructores.
        public Clientes() 
        {
        }
        public Clientes(string nombre, string apellidos, string cedula, string telefono, string direccion, string correo, string ciudad)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Cedula = cedula;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.Correo = correo;
            this.Ciudad = ciudad;
        }

      

    }
}
