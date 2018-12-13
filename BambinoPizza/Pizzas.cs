using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambinoPizza
{
    //Esta clase servira para representar los tipos de pizza
    class Pizzas
    {
        public string nombre { get; set; }
        public List<string> ingredientes = new List<string>();
        public int precio { get; set; }
        public int tiempo { get; set; }

       public Pizzas(string[] listaIngredientes)
        {
            foreach (string ingrediente in listaIngredientes)
            {
                ingredientes.Add(ingrediente);
            }
        }
    }
}
