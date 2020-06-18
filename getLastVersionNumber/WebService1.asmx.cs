using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;

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
        DataTable idVersions = new DataTable();
      
       

        

        [WebMethod]
        public string idVersion()
        {
            idVersions.Columns.Add("id");
            idVersions.Columns.Add("Version");

            idVersions.Rows.Add("1", "v0.1");
            idVersions.Rows.Add("2", "v0.2");
            idVersions.Rows.Add("3", "v0.2.5");
            idVersions.Rows.Add("4", "v1.2");
            idVersions.Rows.Add("5", "v2.5");
            idVersions.Rows.Add("6", "v3");

            return JsonConvert.SerializeObject(idVersions);
        }

    }
}
