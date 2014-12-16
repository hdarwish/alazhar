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

using System.IO;
/// <summary>
/// Summary description for Functions
/// </summary>
public class Functions
{
	public Functions()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public bool IsValidFileName(string FileName)
    {
        int startOfExt= FileName.LastIndexOf(".");;
        string[] validExt = { ".pdf", ".doc", ".jpg", ".jpeg", ".gif", "wmv","xls" };

        for (int i = 0; i < validExt.Length; i++)
        {
           if (FileName.IndexOf(validExt[i]) > -1) 
               return true; 
        }
        return false; 
    }
    public bool IsValidImage(string ImageName)
    {
        int startOfExt = ImageName.LastIndexOf("."); ;
        string[] validExt = { ".jpg", ".jpeg", ".gif",".png" };

        for (int i = 0; i < validExt.Length; i++)
        {
            if (ImageName.IndexOf(validExt[i]) > -1)
                return true;
        }
        return false;
    }
   
}
