using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication
{
    /// <summary>
    /// Summary description for MyWebService
    /// </summary>
    [WebService(Namespace = "http://sistemasdistribuidos.com/example/webservice")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MyWebService : System.Web.Services.WebService
    {
        [WebMethod]
        public double Sumar(double data1, double data2)
        {
            return data1 + data2;
        }

        [WebMethod]
        public double Restar(double data1, double data2)
        {
            return data1 - data2;
        }

        [WebMethod]
        public double Dividir(double data1, double data2)
        {
            return data1 / data2;
        }

        [WebMethod]
        public double Multiplicar(double data1, double data2)
        {
            return data1 * data2;
        }
    }
}
