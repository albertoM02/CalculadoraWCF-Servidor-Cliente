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
        public int RestaValores(int v1, int v2)
        {
            return v1 - v2;
        }

        public int SumaValores(int v1, int v2)
        {
            return v1 + v2;
        }
    }
}
