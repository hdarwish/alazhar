using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

/// <summary>
/// Summary description for hits_count
/// </summary>
public class hits_count
{
    public hits_count()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public int  hit_count_save(int id, int type)
    {
        try
        {
           // hits_DT sav_dt = new hits_DT();
           hits_DT  sav_dt = hits_DB.SelectByID(id, type);
           if (sav_dt.id != 0)
           {

               sav_dt.id = sav_dt.id;
           }
           else { sav_dt.id = 0; }
            sav_dt.cont_id = id;
            sav_dt.cont_type = type;
            sav_dt.hit_count  = sav_dt.hit_count + 1;
            int res = hits_DB.Save(sav_dt);
            return 1;
        }
        catch 
        {

          return -1;
        }


    }
}
