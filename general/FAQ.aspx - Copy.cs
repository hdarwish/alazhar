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
using System.Data.SqlClient;

public partial class general_FAQ : BasePage  //System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HtmlAnchor currentMenu = (HtmlAnchor)Page.Master.FindControl("hypSiteMap2");
        currentMenu.HRef = "~/general/FAQ.aspx";
        Literal lbl_veiw = (Literal)Page.Master.FindControl("Literal2");
        currentMenu.Visible = true;

        lbl_veiw.Text = ">> أسئلة و أجوبة";
    }
}