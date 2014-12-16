using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class general_WebsiteMap : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HtmlAnchor currentMenu = (HtmlAnchor)Page.Master.FindControl("hypSiteMap2");
        currentMenu.HRef = "~/general/WebsiteMap.aspx";
        Literal lbl_veiw = (Literal)Page.Master.FindControl("Literal2");
        currentMenu.Visible = true;

        lbl_veiw.Text = ">> خريطة الموقع ";
    }
}