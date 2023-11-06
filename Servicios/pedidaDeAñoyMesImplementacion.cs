using Actividad5evaluable.servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5evaluable.servicios
{
    internal class pedidaDeAñoyMesImplementacion : pedidaDeAñoyMesInterfaz
    {
        /// <summary>
        /// Metodo de pedida del mes
        /// @author JL - 04112023
        /// </summary>
        /// <returns>Numero entero</returns>
        public int pedidames()
        {
            Console.WriteLine("Escriba un mes");
            int mes = Convert.ToInt32(Console.ReadLine());
            return mes;
        }
        /// <summary>
        /// Metodo de pedida de año
        /// @author JL - 04112023
        /// </summary>
        /// <returns>Numero entero</returns>
        public int pedidaaño()
        {
            Console.WriteLine("Escriba un año");
            int anyo = Convert.ToInt32(Console.ReadLine());
            return anyo;
        }
    }
}
