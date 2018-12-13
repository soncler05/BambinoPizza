using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BambinoPizza
{
    class Proceso
    {
        //Indica la posicion de la pizza en el menu
        private int numPizza;

        //Indican el porcentaje de tiempo que ocupa cada etapa en el proceso
        private const double etapaPedido = 0.1;
        private const double etapaArmado = 0.2;
        private const double etapaHorno = 0.3;
        private const double etapaEmpacado = 0.1;
        private const double etapaEntrega = 0.3;

        //Representa la pizza que se deesea producir
        private Pizzas Pizza;

        public  Proceso(int num)
        {
            numPizza = num;
            Pizza = Menu.ListaMenu.ElementAt(num - 1);           
        }

        int tiempo; //Tiempo que lleva cada paso para realizarse
        public void Etapas()
        {
            Console.WriteLine("En Pedido...");
            tiempo = Convert.ToInt16( etapaPedido * Pizza.tiempo * 1000);
            Thread.Sleep(tiempo); //Detener el programa(o el hilo prinipal) mientras se realiza el paso

            Console.WriteLine("En Armado...");
            tiempo = Convert.ToInt16(etapaArmado * Pizza.tiempo * 1000);
            Menu MenuPizzaElegida = new Menu();
            MenuPizzaElegida.MostrarIngredientes(Convert.ToInt16(Program.entrada)-1); //Le pasamos el numero escogida por el cliente en el menu
            Thread.Sleep(tiempo);

            Console.WriteLine("En Horno...");
            tiempo = Convert.ToInt16(etapaHorno * Pizza.tiempo * 1000);
            Thread.Sleep(tiempo);

            Console.WriteLine("En Empacado...");
            tiempo = Convert.ToInt16(etapaEmpacado * Pizza.tiempo * 1000);
            Thread.Sleep(tiempo);

            Console.WriteLine("En Entrega...");
            tiempo = Convert.ToInt16(etapaEntrega * Pizza.tiempo * 1000);
            Thread.Sleep(tiempo);
        }
    }
}
