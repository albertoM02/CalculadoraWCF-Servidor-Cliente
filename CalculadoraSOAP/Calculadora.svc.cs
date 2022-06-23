using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CalculadoraSOAP
{
    public class Calculadora : ICalculadora
    {
        public int DivideValoresGestiona(int v1, int v2)
        {
            int sol;
            try
            {
                sol = v1 / v2;
            }
            catch (DivideByZeroException e)
            {
                throw new FaultException(
                    new FaultReason(e.Message));
            }
            return sol;
        }

        public int DivideValoresLanza(int v1, int v2)
        {
            if (v2 == 0)
            {
                throw new FaultException<Error>(new Error() { codigo = "2", mensaje = "No se puede dividir entre cero",  }, new FaultReason("No se puede dividir entre cero"));
            }
            else
            {
                return v1 / v2;
            }
        }

        public int RestaValores(int v1, int v2)
        {
            return v1 - v2;
        }

        public int SumaValores(int v1, int v2)
        {
            int res;
            
            res = v1 + v2;

            return res;
        }
    }
}
