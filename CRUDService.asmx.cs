using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Project2.Models;
namespace Project2
{
    /// <summary>
    /// Summary description for CRUDService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]

    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [System.Web.Script.Services.ScriptService]
    public class CRUDService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string PostEmployee(Employee emp)
        {
            return "Success";
        }
       [WebMethod]
    public string GetCurrentTime(String name)
        {
            String message = DateTime.Now.ToString();
            return message;
        }
        
    }
}
