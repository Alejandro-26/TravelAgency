using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency.Logica
{
    public  class Tiquete
    {
        private int numeroTiquete;
        private string ciudad;
        private int diasOspedados;
        private float costoPorPersona;
        private float costoComida;
        private float descuentos;
        private float subTotal;
        private float totalPago;
        private string formaPago;

        public int NumeroTiquete
        {
            get { return numeroTiquete; }
            set { numeroTiquete = value; }
        }

        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }
        public int DiasOspedados
        {
            get { return diasOspedados; }
            set { diasOspedados = value; }
        }
        public float CostoPorPersona
        {
            get {return  costoPorPersona;  }
            set { costoPorPersona = value;}
        }
        public float CostoComida
        {
            get { return costoComida; }
            set { costoComida = value; }
        }
        public float Descuentos
        {
            get { return descuentos; }
            set { descuentos = value; }
        }
        public float SubTotal
        {
            get { return subTotal; }
            set { subTotal = value; }
        }

        public float Total
        {
            get { return totalPago; }
            set { totalPago = value; }
        }

        public string Pago
        {
            get { return formaPago; }
            set { formaPago = value; }
        }

        public Tiquete()
        {

        }


        public Tiquete(int numeroTiquete, string ciudad, int diasOspedados, float costoPorPersona,
                       float costoComida, float descuentos, float subTotal, float total, string pago)
        {
            this.numeroTiquete = NumeroTiquete;
            this.ciudad = Ciudad;
            this.diasOspedados = DiasOspedados;
            this.costoPorPersona = CostoPorPersona;
            this.costoComida = CostoComida;
            this.descuentos = Descuentos;
            this.subTotal = SubTotal;
            this.totalPago = Total;
            this.formaPago = Pago;

        }

        public void Reserva()
        {
            MessageBox.Show("Tiquete reservado exitosamente");
        }

        public void Liquidar( string Ciudad, int diasOspedados, int numPersonas )
        {
            // obtener los valores correspondientes a la ciudad celecionada

           
        }
       
    }
}
