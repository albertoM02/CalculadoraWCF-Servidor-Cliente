using System;

namespace ClienteCalculadora
{
    class ClienteCalculadora
    {
        static void Main(string[] args)
        {
            ReferenciaCalculadora.CalculadoraClient cliente = new ReferenciaCalculadora.CalculadoraClient();
            int resultadoSuma = cliente.SumaValoresAsync(2, 3).Result;
            Console.WriteLine(resultadoSuma);

            int resultadoResta = cliente.RestaValoresAsync(8, 3).Result;
            Console.WriteLine(resultadoResta);

            int resDivG = cliente.DivideValoresGestionaAsync(2, 0).Result;
            Console.WriteLine(resDivG);

            int resDivL = cliente.DivideValoresLanzaAsync(2, 0).Result;
            Console.WriteLine(resDivL);



            cliente.Close();
        }
    }
}
