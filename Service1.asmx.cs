using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Project2.Models;

    ///<summary>
    /// Summary description for Service
    ///</summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
    [System.Web.Script.Services.ScriptService]

    public class Service1 : System.Web.Services.WebService
    {

        public Service1()
        {
            //Uncomment the following line if using designed components
            //InitializeComponent();
        }

    [WebMethod]
    public string HelloWorld()
    {
        return "A";
    }
        [WebMethod]
        public string GetCurrentTime(string name)
        {
            string message = "Hello ";
            message += name;
            message += "\nCurrent Time: ";
            message += DateTime.Now.ToString();
            return message;
        }
    }
