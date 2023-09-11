using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TravelAgency.Datos
{
    //Clase Usuario.
    public class Usuarios
    {
        private string idUsiario;
        private string nameUsiario;
        private string contraseña;
        private string rol;


        //Metodos de acceso.
        public string IdUsuario 
        {
            get { return idUsiario; }
            set { idUsiario = value; }
        }

        public string NameUsuario
        {
            get { return nameUsiario; }
            set { nameUsiario = value; }
        }
        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }
        public string Rol
        {
            get { return rol; }
            set { rol = value; }
        }


        //Contructor
        public  Usuarios()
        {

        }

        //Contructor con parametros
        public Usuarios(string idUsuario, string nameUsuario, string contraseña, string rol)
        {
            this.NameUsuario = nameUsuario;
            this.IdUsuario = idUsuario;
            this.Contraseña = contraseña;
            this.Rol = rol;

        }

      
    }
}
