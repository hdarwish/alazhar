using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Threading;
using System.Globalization;

/// <summary>
/// Summary description for BasePageClass
/// </summary>
public class BasePageClass : System.Web.UI.Page 
{
	public BasePageClass()
	{
		//
		// TODO: Add constructor logic here
		//

	}
    protected override void InitializeCulture()
    {
        HttpCookie cultureCookie = Request.Cookies["Culture"];
        string cultureCode = (cultureCookie != null) ? cultureCookie.Value : null;
        if (!string.IsNullOrEmpty(cultureCode))
        {
            this.UICulture = "ar-EG";
            this.Culture = cultureCode;
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CreateSpecificCulture(cultureCode);
            System.Globalization.CultureInfo culture_ar = System.Globalization.CultureInfo.CreateSpecificCulture("ar-EG");
            System.Threading.Thread.CurrentThread.CurrentCulture = culture_ar;
            System.Threading.Thread.CurrentThread.CurrentUICulture =culture ;
        }
        base.InitializeCulture();

 }
}
