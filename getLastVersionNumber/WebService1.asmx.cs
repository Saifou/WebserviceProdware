using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using Newtonsoft.Json;
using System.Text;
using System.IO;
using Newtonsoft.Json.Linq;

namespace getLastVersionNumber
{
    /// <summary>
    /// Description résumée de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        

        [WebMethod]

        public string IDVersion()
        {


            String json = File.ReadAllText(@"C:\Users\sejjilali\source\repos\WebserviceProdware\getLastVersionNumber\idVersions.json");

            var lastVersion = JArray.Parse(json).Last().ToString();

            return lastVersion;
        }
    }

}

