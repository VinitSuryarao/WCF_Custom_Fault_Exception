using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CalculatorService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class CalculatorService : ICalculatorService
    {
        public int Add(MyNumber obj)
        {
            return obj.Number1 + obj.Number2;
        }

        public int Sub(MyNumber obj)
        {
            return obj.Number1 - obj.Number2;
        }

        public int Div(MyNumber obj)
        {
            try
            {
                return obj.Number1 / obj.Number2;
            }
            catch(Exception ex)
            {
                var customFault = new CustomFault();
                customFault.Method = "Div()";
                customFault.Reason = "Value of data is zero";
                customFault.Message = ex.Message;
                throw new FaultException<CustomFault>(customFault);
            }
           
        }

        public void DivOneWay(MyNumber obj)
        {
            try
            {
                int result = obj.Number1 / obj.Number2;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
