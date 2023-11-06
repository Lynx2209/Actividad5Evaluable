using Actividad5evaluable.servicios;


namespace Actividad5evaluable.servicios
{
    class program
    {
        public static void Main(string[] args)
        {
            pedidaDeAñoyMesInterfaz PAM = new pedidaDeAñoyMesImplementacion();
            operacionInterfaz OI = new operacionImplementacion();
            menuContinuarONoInterfaz MCONI = new menuContinuarONoImplementacion();
            string mesyanyo;
            do
            {
                int mes = PAM.pedidames();
                int anyo = PAM.pedidaaño();
                OI.operacionCalculoONo(mes, anyo);
                mesyanyo = MCONI.menuContinuarONo();
            } while (mesyanyo == "S");
        }
    }
}
