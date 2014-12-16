using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;


/// <summary>
/// Summary description for Class1
/// </summary>

public class Get_subpath
{
    public Get_subpath()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public bool URLIsExist(string subURL)
    {
        subURL = subURL.ToLower();
        bool x = false;

     
        string fullURL = HttpContext.Current.Request.Url.AbsoluteUri.ToLower();
        if (fullURL != "" || fullURL != null)
        {
            if (subURL != "")
            {
                int IndexOfSub = fullURL.IndexOf(subURL);

                if (IndexOfSub > 0)
                {
                    x = true;

                }

            }
        }
        return x;



    }

}
