using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CalculadoraSOAP
{
    [DataContract]
    public class Error
    {
        [DataMember]
        public string codigo { get; set; }

        [DataMember]
        public string mensaje { get; set; }
    }
}