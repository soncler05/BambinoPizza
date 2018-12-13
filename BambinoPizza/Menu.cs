using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambinoPizza
{
    //En está clase se almacenará los tipos de pizza dell menu y tambien se servirá para imprimir el  menú en la pantalla 
    class Menu
    {
        //Lista de los tipos de pizza, cada uno de los tipos es un objeto de la clase Pizza por eso es necesario indicar 
        //en un array la lista de los ingredientes al momento de inicializar la clase.
        public static List<Pizzas> ListaMenu = new List<Pizzas>
        {
            new Pizzas(new string[4] {"Piña natural", "Jamón cocido", "Tomate frito","Mozzarella fresca"})
            {
                nombre="Pizza Hawaiina",
                precio=100,
                tiempo = 10,
            },
            new Pizzas(new string[3] {"Aceite de olivo", "Hojas albahaca fresca", "Cebolla"  })
            {
                nombre="Pizza Italiana",
                precio=120,
                tiempo = 10,
            },
            new Pizzas(new string[3] { "Palmito en lonchas", "Queso mozarella", "Aceite" })
            {
                nombre="Pizza Americana",
                precio=150,
                tiempo = 10,
            },
            new Pizzas(new string[3] {"Harina", "Sal", "Verdura" })
            {
                nombre="Pizza Vegana",
                precio=70,
                tiempo = 2,
            },
            new Pizzas(new string[3] { "Mozzarella fresca", "Chorrizo picante", "Jalapeños" })
            {
                nombre="Pizza Mexicana",
                precio=110,
                tiempo = 2,
            },
        };


        //Este método servirá para imprimir el menu 
        public void MostrarMenu()
        {      
            Console.WriteLine("En seguida le presentamos nuestro menu");
            int numMenu = 1; //Esta variable servira como incremento para asignar un numero a cada elemento de la lista
            foreach (var P in ListaMenu)
            {
                Console.WriteLine("\t||" + numMenu + "- " + P.nombre + "----------> $" + P.precio);
                numMenu = numMenu + 1;
            }
        }
        //Este método servirá para imprimir los ingredientes de la pizza elegida por el cliente
        public void MostrarIngredientes(int PosicionPizza)
        {
            Console.WriteLine("En seguida le presentamos la lista de los ingredientes de su pizza");
            Pizzas PizzaElegida = ListaMenu.ElementAt(PosicionPizza);
            foreach (var P in PizzaElegida.ingredientes)
            {
                Console.WriteLine("\t|-" + P);
            }
        }

    }
}
