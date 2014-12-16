using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class contactus : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Image mahamer = (Image)Master.FindControl("mahamer");
        mahamer.ImageUrl = "../images/menu/5_o.gif";


        LinkButton5.CssClass = "out_links4_sel";
    }

   
}
