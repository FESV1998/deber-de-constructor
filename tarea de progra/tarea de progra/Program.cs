using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_de_progra
{
    class Program
    {
        static void Main(string[] args)
        {
            cajas nuevaCaja = new cajas();

            nuevaCaja.altura = 2;
            nuevaCaja.ancho = 3;
            nuevaCaja.profundidad = 4;
            nuevaCaja.mostrarDatos();

            cajas caja2 = new cajas();
            caja2.altura = 2;
            caja2.ancho = 2;
            caja2.profundidad = 4;
            caja2.color = "amarillo";
            caja2.mostrarDatos();

            cajas caja3 = new cajas();
            caja3.altura = 4;
            caja3.ancho = 4;
            caja3.profundidad = 8;
            caja3.color = "roja";
            caja3.Tmaterial = "metal";
            caja3.estructuras = "4 tapas";
            caja3.Nombreempresa = "los hermanos";
            caja3.apertura = "arriba ";
            caja3.mostrarDatos();

            cajas caja4 = new cajas();

            caja4.altura = 6;
            caja4.ancho = 6;
            caja4.profundidad = 12;
            caja4.color = "verde";
            caja4.Tmaterial = "carton";
            caja4.estructuras = "1 tapas";
            caja4.Nombreempresa = "los hermanos";
            caja4.apertura = "arriba ";
            caja4.mostrarDatos();


            Console.ReadKey();
  }
        /// <summary>
        /// Esta clase es en representacion a una serie de cajas
        /// </summary>

        public class cajas
        {
            public string color { get; set; }
            public int altura { get; set; }
            public int ancho { get; set; }
            public int profundidad { get; set; }
            public string Tmaterial { get; set; }
            public string estructuras { get; set; }
            public string Nombreempresa { get; set; }
            public string apertura { get; set; }


            public void mostrarDatos()
            {
                Console.WriteLine();
                Console.WriteLine("Color: "+color + "    " +  "altura: " + altura +  "    " +   "Ancho: "+ ancho + "    "+ "Profundidad: " + profundidad+ "    " + "Tipo de Material: " + Tmaterial);
                Console.WriteLine("Estructuras:  " +  estructuras + "    " + "Nombre de la Empresa:  " + Nombreempresa + "    " + "Lado para donde se abre: " + apertura);
                Console.WriteLine();
            }
        }
    }
}
