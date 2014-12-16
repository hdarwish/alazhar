using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Security;
using System.Data.SqlClient;
using System.Xml;
//<Autor Name: Zainab Asaad>
//<Date 19/03/2013>
public partial class user_controls_TimeLineShow : System.Web.UI.UserControl
{
    #region Members
    int count = 1;
    int lastindex = 0;
    int myear = 0;
    int newcycle = 0;
    XmlDocument doc = new XmlDocument();
    DataTable Timelinedt = new DataTable();
    DataTable Detailsdt = new DataTable();
    #endregion
    #region Events
 protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
         SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@char_id",Convert.ToInt16 (1)) ,
         new SqlParameter("@lang_id",Convert.ToInt16(1))};
         Timelinedt = DatabaseFunctions.SelectData(sqlParams, "timeline_select");
                  
          // XML declaration
            XmlNode declaration = doc.CreateNode(XmlNodeType.XmlDeclaration, null, null);
            doc.AppendChild(declaration);
           
            // Root element: article
            XmlElement root = doc.CreateElement("models");
            doc.AppendChild(root);
            if (Timelinedt != null)
            {
                if (Timelinedt.Rows.Count != 0)
              {
                  for (int i = 0; i < Timelinedt.Rows.Count; i++)
                  {
                    
                       // Sub-element: year
                      XmlElement year = doc.CreateElement("years_" + i);
                      root.AppendChild(year);
                      // Attribute: meladiyear
                      XmlAttribute meladiyear = doc.CreateAttribute("meladiyear");
                      meladiyear.Value = Timelinedt.Rows[i]["meladiyear"].ToString();
                      year.Attributes.Append(meladiyear);

                      // Attribute: hejriyear
                      XmlAttribute hejriyear = doc.CreateAttribute("hejriyear");
                      hejriyear.Value = Timelinedt.Rows[i]["hejriyear"].ToString();
                      year.Attributes.Append(hejriyear);
                     // if (i != 0 && newcycle !=0) 
                     // {
                     //     i = lastindex;
                     // }
                     //myear = Convert.ToInt32(dt.Rows[i]["meladiyear"].ToString());

                     //if (myear == Convert.ToInt32(dt.Rows[i + 1]["meladiyear"].ToString()))
                     //{
                     //    count += 1;
                     //    newcycle = 0;
                     //}
                     //else
                     //{
                     //    newcycle = 1;
                     //    count = 1;
                     //    lastindex = i;
                     //}

                      SqlParameter[] sqlParams2 = new SqlParameter[] { new SqlParameter("@char_id",Convert.ToInt16 (1)) ,
                      new SqlParameter("@lang_id",Convert.ToInt16(1)), new SqlParameter("@myear",Convert.ToInt16(Timelinedt.Rows[i]["meladiyear"].ToString()))};
                      Detailsdt = DatabaseFunctions.SelectData(sqlParams2, "timeline_select_details");
                    if (Detailsdt!=null)
                      {
                           if (Detailsdt.Rows.Count!=0)
                     {
                         for (int y = 0; y < Detailsdt.Rows.Count; y++)
                         {
                             // Sub-element: title
                             XmlElement item = doc.CreateElement("item_" + y);
                             //title.InnerText = "Sample XML Document";
                             year.AppendChild(item);

                             // Attribute: id
                             XmlAttribute id = doc.CreateAttribute("id");
                             id.Value = Detailsdt.Rows[y]["id"].ToString();
                             item.Attributes.Append(id);
                             // Attribute: type
                             XmlAttribute type = doc.CreateAttribute("type");
                             type.Value = Detailsdt.Rows[y]["type"].ToString();
                             item.Attributes.Append(type);
                             // Attribute: type
                             XmlAttribute title = doc.CreateAttribute("title");
                             title.Value = Detailsdt.Rows[y]["title"].ToString();
                             item.Attributes.Append(title);
                             // Attribute: Dummy
                             XmlAttribute Dummy = doc.CreateAttribute("Dummy");
                             Dummy.Value = Detailsdt.Rows[y]["Dummy"].ToString();
                             item.Attributes.Append(Dummy);

                         }
                     }
                      }
                     }
              }
            }

            doc.Save(Server.MapPath(@"~/sheikhs/timelinedata.xml"));
                    
        }
        catch (InvalidCastException ex)
        {
           // Response.Write(ex.Message);
            throw (ex);   
        }
    }
    #endregion
  
}
