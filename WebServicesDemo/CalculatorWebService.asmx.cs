using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesDemo
{
    /// <summary>
    /// Summary description for CalculatorWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculatorWebService : System.Web.Services.WebService
    {

        [WebMethod(EnableSession =true)]
        public int Add(int firstNumber,int secondNumber)
        {
            List<string> calculations ;
            if (Session["Calculation"] == null)
            {
                calculations = new List<string>();
            }
            else
            {
                calculations =(List<string>)Session["Calculation"];
            }
            string str = firstNumber.ToString() + " + " + secondNumber.ToString() + " = " + (firstNumber + secondNumber).ToString();
            calculations.Add(str);
            Session["Calculation"]=calculations;

            return firstNumber + secondNumber;
        }

        [WebMethod(EnableSession =true)]
        public List<string> GetCalculations()
        {
            List<string> calculations;
            if (Session["Calculation"] == null)
            {
                calculations = new List<string>();
                calculations.Add("no calculations");
                return calculations;
            }
            else
            {
                return (List<string>)Session["Calculation"] ;
            }

            return calculations;
        }
    }
}
