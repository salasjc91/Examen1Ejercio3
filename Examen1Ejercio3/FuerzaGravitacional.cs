using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1Ejercio3
{
    class FuerzaGravitacional
    {
         double masa1;
         double masa2;
         double distancia;
         const double G = 6.673E-11; // Constante de gravitación 


        //constructores
        public double Masa1
        {
            get { return masa1; }
            set { masa1 = value; }
        }

        public double Masa2
        {
            get { return masa2; }
            set { masa2 = value; }
        }

        public double Distancia
        {
            get { return distancia; }
            set { distancia = value; }
        }

        // este metodo realiza la operacion, simulando la formula
        public double CalcularFuerza()
        {
            return (G * Masa1 * Masa2) / (Distancia * Distancia);
        }

    }
}
