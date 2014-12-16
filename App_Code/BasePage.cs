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
using System.Text;


    public class BasePage : System.Web.UI.Page
    {
        public BasePage()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        protected override void InitializeCulture()
        {
            if (Session["Lang"] != null)
            {
                if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar-eg");
                    Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("ar-eg");

                }
                else if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us");
                    Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-us");
                    
                }
                else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-fr");
                    Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("fr-fr");

                }
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar-eg");
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("ar-eg");
                
           }
        }
        public string RemoveBad(string str) { 
       
            StringBuilder strTemp=new StringBuilder(str);
            strTemp = strTemp.Replace("<","");
            strTemp = strTemp.Replace(">", "");
            strTemp = strTemp.Replace("\"" , "");   
            strTemp = strTemp.Replace("\'" , "");   
            strTemp = strTemp.Replace("%" , ""); 
            strTemp = strTemp.Replace(";" , ""); 
            strTemp = strTemp.Replace(")" , ""); 
            strTemp = strTemp.Replace("(" , ""); 
            strTemp = strTemp.Replace("&" , ""); 
            strTemp = strTemp.Replace("+" , "");
            strTemp = strTemp.Replace("-", ""); 
                 
      
        return strTemp.ToString();
        }
    }


