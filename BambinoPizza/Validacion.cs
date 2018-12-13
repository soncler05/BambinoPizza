using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambinoPizza
{
    //Esta clase trata de validar las entradas para disminuir el riesgo que el usuario se equivoque o que salga un error en plena ejecucion del programa
    class Validacion
    {
        public string entrada { get; set; }
        public int[] rangoInclusivo { get; set; }

        public bool ValidarNumero()
        {
            int output;

            if (int.TryParse(entrada, out output))
            {
                //Console.WriteLine("Es un intero");
                if((rangoInclusivo[0] <= Convert.ToInt16(entrada) || Convert.ToInt16(entrada) <= rangoInclusivo[1])==true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            
        }
    }
}
