using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambinoPizza
{
    class Program
    {
        public static string entrada { get; set; }
        public static int[] rangoInclusivo { get; set; }
        static void Main(string[] args)
        {            
            Console.WriteLine("¡Hola, bienvenid@ a El Bambino Pizzería!");

            Siguiente();

            Console.WriteLine("¡Gracias por su compra, hasta luego!");

            Console.ReadKey();
        }

        //Este método mandará el usuario al menu y tomará su pedido
        public static void Siguiente()
        {
            Menu MenuPizza = new Menu();
            MenuPizza.MostrarMenu();
            Console.WriteLine("Por favor teclee un numero del menu para escoger la pizza");

            EscogeMenu: //Una que etiqueta que servirá a volver a ejecutar la instrucción en caso que el usuario se equivoque            

            entrada = Console.ReadLine();
            if (!ValidarNumero())
            {
                Console.WriteLine("Teclee un numero del menu para escoger la pizza");
                goto EscogeMenu;
            }
            int num = Convert.ToInt16(entrada);
            rangoInclusivo = new int[2] { 1, Menu.ListaMenu.Count() };
            if (!ValidarRangoNumero())
            {
                Console.WriteLine("Por favor teclee un numero del menu para escoger la pizza");
                goto EscogeMenu;
            }
            
            Console.WriteLine("Usted escogió: " + Menu.ListaMenu.ElementAt(num-1).nombre);
            Console.WriteLine("Le informamos que su pizza se tardará " + Menu.ListaMenu.ElementAt(num-1).tiempo+ "s para que se le sea entregada.");
            Proceso P = new Proceso(num);
            P.Etapas();

            Console.WriteLine("Se entregó correctamente su pizza!");
            Console.WriteLine("Teclee 1 si usted desea comprar otra pizza, si no teclee 2.");
            EscogerSalidaONo:
            entrada = Console.ReadLine();
            if (!ValidarNumero())
            {
                Console.WriteLine("Por favor teclee 1 si usted desea comprar otra pizza, si no teclee 2.");
                goto EscogerSalidaONo;
            }
            int respuesta = Convert.ToInt16(entrada);
            rangoInclusivo = new int[2] { 1, 2 };
            if (!ValidarRangoNumero())
            {
                Console.WriteLine("Por favor teclee 1 si usted desea comprar otra pizza, si no teclee 2.");
                goto EscogerSalidaONo;
            }

            //En el caso que el usuario quiera seguir comprando pizza
            if(respuesta == 1)
            {
                Console.Clear();
                Siguiente();
            }
        }

        //Los métodos sigientes ayudarán a validar las entradas para disminuir el riesgo que el usuario se equivoque o que le salga un error en plena ejecucion del programa
        public static bool ValidarNumero()
        {
            int output;

            //Checar si la entrada es un entero
            if (int.TryParse(entrada, out output))
            {                
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool ValidarRangoNumero()
        {
            //Ver si el entero se encuetra dentro de las opciones
            if ((rangoInclusivo[0] <= Convert.ToInt16(entrada) && Convert.ToInt16(entrada) <= rangoInclusivo[1]) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
