using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace   Actividad5evaluable.servicios
{
    /// <summary>
    /// Interfaz encargada de pedir los datos
    /// @author JL - 04112023
    /// </summary>
    internal interface pedidaDeAñoyMesInterfaz
    {
        /// <summary>
        /// Metodo para pedir el mes
        /// @author JL - 04112023
        /// </summary>
        /// <returns>Numero entero</returns>
        public int pedidames();
        /// <summary>
        /// Metodo para pedir el mes
        /// @author JL - 04112023
        /// </summary>
        /// <returns>Numero entero</returns>
        public int pedidaaño();
    }
}