using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchoolProyecto4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient WS = new ServiceReference1.WebService1SoapClient();
            DataSet ds = WS.ListaUsuarios();
            GridView1.DataSource = ds.Tables;
            GridView1.DataBind();
        }
    }
}