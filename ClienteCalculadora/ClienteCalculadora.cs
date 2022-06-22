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

            int resultadoResta = cliente.RestaValoresAsync(8, 5).Result;
            Console.WriteLine(resultadoResta);
        }
    }
}
