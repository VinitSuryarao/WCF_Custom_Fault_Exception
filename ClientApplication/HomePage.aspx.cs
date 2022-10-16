using ClientApplication.CalculatorServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientApplication
{
    public partial class HomePage : System.Web.UI.Page
    {
        // Creatig object of service client reference
        CalculatorServiceReference.CalculatorServiceClient objServiceClient = new CalculatorServiceReference.CalculatorServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            // Create object of Data Contract. The Structure wich communicate service
            CalculatorServiceReference.MyNumber objMyNumber = new CalculatorServiceReference.MyNumber();

            objMyNumber.Number1 = Convert.ToInt32(txtNumber1.Text);
            objMyNumber.Number2 = Convert.ToInt32(txtNumber2.Text);

            // Call Service Method
            int result = objServiceClient.Add(objMyNumber);

            txtResult.Text =  result.ToString();
        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            // Create object of Data Contract. The Structure wich communicate service
            CalculatorServiceReference.MyNumber objMyNumber = new CalculatorServiceReference.MyNumber();

            objMyNumber.Number1 = Convert.ToInt32(txtNumber1.Text);
            objMyNumber.Number2 = Convert.ToInt32(txtNumber2.Text);

            // Call Service Method
            int result = objServiceClient.Sub(objMyNumber);

            txtResult.Text =  result.ToString();
        }

        protected void btnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                // Create object of Data Contract. The Structure wich communicate service
                CalculatorServiceReference.MyNumber objMyNumber = new CalculatorServiceReference.MyNumber();

                objMyNumber.Number1 = Convert.ToInt32(txtNumber1.Text);
                objMyNumber.Number2 = Convert.ToInt32(txtNumber2.Text);

                // Call Service Method
                int result = objServiceClient.Div(objMyNumber);

                txtResult.Text = result.ToString();
            }
            catch(FaultException<CustomFault> ex)
            {
                lblErrMsg.Text = string.Format("Error :- Method = {0} \n  Reason ={1} \n  Msg ={2}", ex.Detail.Method, ex.Detail.Reason, ex.Detail.Message);
            }
        }

        protected void btnDivOneWay_Click(object sender, EventArgs e)
        {
            try
            {
                // Create object of Data Contract. The Structure wich communicate service
                CalculatorServiceReference.MyNumber objMyNumber = new CalculatorServiceReference.MyNumber();

                objMyNumber.Number1 = Convert.ToInt32(txtNumber1.Text);
                objMyNumber.Number2 = Convert.ToInt32(txtNumber2.Text);

                // Call Service Method
                 objServiceClient.DivOneWay(objMyNumber);
            }
            catch (Exception ex)
            {
                lblErrMsg.Text = ex.Message;
            }
        }
    }
}