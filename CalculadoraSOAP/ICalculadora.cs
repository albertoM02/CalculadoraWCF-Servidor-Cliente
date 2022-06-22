using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CalculadoraSOAP
{
    [ServiceContract]
    public interface ICalculadora
    {
  
        [OperationContract]
        int SumaValores (int v1, int v2);

        [OperationContract]
        int RestaValores(int v1, int v2);
    }
}
