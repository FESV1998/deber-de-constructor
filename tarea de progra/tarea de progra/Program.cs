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
            cajas nuevaCaja = new cajas(10,12,109);         
            nuevaCaja.mostrarDatos1();

            cajas caja2 = new cajas(4,5,3,"verde");
            caja2.mostrarDatos2();

            cajas caja3 = new cajas(4, 12, 4, "cafez", "arriba", "con tapa", "los cuates", "arriba");
            caja3.mostrarDatos3();

            cajas caja4 = new cajas(12,23,22,"rojo","arriba","con tapa", "LOs cuates","arriba");
            caja4.mostrarDatos4();
            Console.ReadKey();
  }
        /// <summary>
        /// Esta clase es en representacion a una serie de cajas
        /// </summary>

        public class cajas
        {
            public cajas() { }

            public cajas(int altura, int ancho, int profundidad)
            {
                this.altura = altura;
                this.ancho = ancho;
                this.profundidad = profundidad;

            }
            public cajas(int altura, int ancho, int profundidad,string color)
            {
                this.altura = altura;
                this.ancho = ancho;
                this.profundidad = profundidad;
                this.color = color; 
            }

            public cajas(int altura, int ancho, int profundidad, string color, string Apertura, string estructuras, string Nombreempresa, string apertura)
            {
                this.altura = altura;
                this.ancho = ancho;
                this.profundidad = profundidad;
                this.color = color;
                this.estructuras = estructuras;
                this.Nombreempresa = Nombreempresa;
                this.apertura = apertura;
                
                 if (color == "rojo")
                {
                    TMaterial = "metal";
                } else if (color == "cafez")
                {
                    TMaterial = "carton";
                }
            }
            public cajas(int altura, int ancho, int profundidad, string color, string Apertura, string estructuras, string Nombreempresa,string apertura,string nadeshion)
            {
                this.altura = altura;
                this.ancho = ancho;
                this.profundidad = profundidad;
                this.color = color;
                this.estructuras = estructuras;
                this.Nombreempresa = Nombreempresa;
                this.apertura = apertura;

                if (color == "rojo")
                {
                    TMaterial = "metal";
                }
                else if (color == "cafez")
                {
                    TMaterial = "carton";
                }
            }

            public string TMaterial;
           
            public string color { get; set; }
            public int altura { get; set; }
            public int ancho { get; set; }
            public int profundidad { get; set; }
            public string Tmaterial { get { return TMaterial; } }
            public string estructuras { get; set; }
            public string Nombreempresa { get; set; }
            public string apertura { get; set; }


            public void mostrarDatos1()
            {
                Console.WriteLine();
                Console.WriteLine( "caja1 \n" +   "altura: " + altura +  "    " +   "Ancho: "+ ancho + "    "+ "Profundidad: " + profundidad);      Console.WriteLine("_____________________________________________________");
                Console.WriteLine();
            }
            public void mostrarDatos2()
            {
                Console.WriteLine();
                Console.WriteLine( "caja2 \n "  + "altura: " + altura + "    " + "Ancho: " + ancho + "    " + "Profundidad: " +  profundidad + "    " + "color: " + color + "" ); Console.WriteLine("_________________________________________________________________");
                Console.WriteLine();
            }
            public void mostrarDatos3()
            {
                Console.WriteLine();
                Console.WriteLine( "caja3 \n "+"altura: " + altura + "    " + "Ancho: " + ancho + "    " + "Profundidad: " + profundidad  );
                Console.WriteLine("color:  " + color + "    " + "Tipo de material: " + Tmaterial + "    " + "Estructuras: " + estructuras + "    " + "nombre de la empresa: " + Nombreempresa + "    " + "Donde se abre la caja: " + apertura); Console.WriteLine("________________________________________________________________________________________________________________________________________________");
            }
            public void mostrarDatos4()
            {
                Console.WriteLine();
                Console.WriteLine("caja4 \n"+"altura: " + altura + "    " + "Ancho: " + ancho + "    " + "Profundidad: " + profundidad + "    ");
                Console.WriteLine("color:  " + color + "    " + "Tipo de material: " + Tmaterial + "    " + "Estructuras: " + estructuras + "    " + "nombre de la empresa: " + Nombreempresa + "    " + "Donde se abre la caja: " + apertura); Console.WriteLine("__________________________________________________________________________________________________________________________________________________");
            }


        }
    }
}
