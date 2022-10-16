using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CalculatorService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICalculatorService
    {
        [OperationContract]
        int Add(MyNumber obj);

        [OperationContract]
        int Sub(MyNumber obj);

        [OperationContract]
        [FaultContract(typeof(CustomFault))]
        int Div(MyNumber obj);

        [OperationContract(IsOneWay = true)]
        void DivOneWay(MyNumber obj);

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class MyNumber
    {
        [DataMember]
        public int Number1 { get; set; }
        [DataMember]
        public int Number2 { get; set; }
    }

    [DataContract]
    public class CustomFault
    {
        [DataMember]
        public string Method;

        [DataMember]
        public string Reason;

        [DataMember]
        public string Message;
    }
}
