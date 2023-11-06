using Actividad5evaluable.servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5evaluable.servicios
{
    internal class menuContinuarONoImplementacion : menuContinuarONoInterfaz
    {
        /// <summary>
        /// Metodo para pedir al usuario si quiere continuar con la aplicación
        /// @author 04112023 - JL 
        /// </summary>
        /// <returns>String</returns>
        public string menuContinuarONo()
        {
            Console.WriteLine("Si quiere hacer otra peticion pulse la tecla ( S )");
            
            return menuContinuarONo;
        }
    }
}
