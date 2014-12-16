using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class glossary_WebUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["content_type"] == null || Session["content_id"] == null)
            {
                
                Session["content_type"] = "0";
                Session["content_id"] = "0";
                Session["lang_id"] = menus_update.get_current_lang();
               Session["glosry_list"].ToString();
               get_glossary_order();
               // ViewCharacterList(glosry_list);
            }
            else if (Session["content_type"] != null && Session["content_id"] != null)
            {
                if (Request.QueryString["id"] != null && Request.QueryString["type"] != null)
                {
                    SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", Request.QueryString["type"].ToString()), 
                                                     
                    new SqlParameter("@content_id", Request.QueryString["id"].ToString()), 
                                                             
                    new SqlParameter("@lang", menus_update.get_current_lang()) };

                    DataTable glosry_list = new DataTable();
                    glosry_list = DatabaseFunctions.SelectData(sqlParams, "get_glossary_contents");
                    Session["glosry_list"] = glosry_list;
                    get_glossary_order();
                    //ViewCharacterList(glosry_list);

                }
                else
                {
                    Session["content_type"] = "0";
                    Session["content_id"] = "0";
                    get_glossary_order();
                   // ViewCharacterList(GetDataTableFromDatabase());

                }

            }
            if (menus_update.get_current_lang() != 1)
            {
                //tdlnk27.Visible = false;
                //tdlnk28.Visible = false;
            }
            else
            {
                //tdlnk27.Visible = true;
                //tdlnk28.Visible = true;
            }

        }

    }
    protected DataTable GetDataTableFromDatabase()
    {
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", HttpContext.Current.Session["content_type"].ToString()), 
                                                     
            new SqlParameter("@content_id", HttpContext.Current.Session["content_id"].ToString()), 
                                                     
            new SqlParameter("@lang", menus_update.get_current_lang()) };

        DataTable glosry_list = new DataTable();
        glosry_list = DatabaseFunctions.SelectData(sqlParams, "get_glossary_contents");
        Session["glosry_list"] = glosry_list;
        return glosry_list;
    }
  

    public DataTable GetDataTableFromCacheOrDatabase()
    {
        // DataTable dataTable = HttpContext.Current.Cache["defaultDatatable"] as DataTable;
        // if (dataTable == null)
        // {
        DataTable dataTable = GetDataTableFromDatabase();
        //     HttpContext.Current.Cache.Insert("defaultDatatable", dataTable, null, DateTime.Now.AddHours(1), System.Web.Caching.Cache.NoSlidingExpiration);

        //  }
        return dataTable;
    }
    public void ViewCharacterList(DataTable glosry_list)
    {
     
        if (glosry_list.Rows.Count > 0)
        {
           
             DataPager1.Visible = true;
         
          
            ListView2.DataSource = glosry_list;
            ListView2.DataBind();
            int count=0;
            

          foreach (ListViewDataItem   Titem in ListView2.Items)
            {
                LinkButton Linklist3 = (LinkButton)Titem.FindControl("Linklist3");
                Linklist3.Text = glosry_list.Rows[count]["title"].ToString();// +"  " + char_list.Rows[count]["other_names"].ToString();
                Linklist3.PostBackUrl = "~/glossary/glossary_details.aspx?l=0&gid=" + glosry_list.Rows[count]["id"].ToString();
                //glosry_list.Rows[Titem.DataItemIndex]["id"].ToString();
                count++;
               

            }
            //foreach (DataListItem  Titem in ListView1.Items)
            //{
            //    LinkButton Labtitle = (LinkButton)Titem.FindControl("Labtitle");
            //    Labtitle.Text = glosry_list.Rows[count]["title"].ToString();// +"  " + char_list.Rows[count]["other_names"].ToString();
            //    Labtitle.PostBackUrl = "~/glossary/glossary_details.aspx?l=0&gid=" + glosry_list.Rows[count]["id"].ToString();
            //    //glosry_list.Rows[Titem.DataItemIndex]["id"].ToString();
            //    count++;
               

            //}

            
        }
        else
        {
            //tr_error.Visible = true;
            //ListView1.Visible = false;
            //DataPager1.Visible = false;
        }

    }

    protected void Link_Click(object sender, EventArgs e)
    {
        DataTable glosry_list = GetDataTableFromCacheOrDatabase();

        var result = from record in glosry_list.AsEnumerable()
                     where record.Field<string>("title").Trim().Substring(0, 1) == "أ"
                     orderby ("title").TrimEnd()
                     select record;


        if (result.Count() > 0)
        {
            glosry_list = result.CopyToDataTable();
            Session["glosry_list"] = glosry_list;
            ViewCharacterList((DataTable)Session["glosry_list"]);

        }
       

        var result2 = from record in glosry_list.AsEnumerable()
                      //where record.Field<string>("title").Trim().Substring(0, 1) == lab1.Text
                      select record;


        if (result2.Count() > 0)
        {
            glosry_list = result2.CopyToDataTable();
            //if (result.Count() > 0)
            //{ glosry_list.Rows.Add(result); }
            Session["glosry_list"] = glosry_list;
            ViewCharacterList((DataTable)Session["glosry_list"]);

        }


        else
        {
            glosry_list = new DataTable();

            Session["glosry_list"] = glosry_list;
            ViewCharacterList((DataTable)Session["glosry_list"]);


        }
    }
    protected void get_glossary_order()
    {

        DataTable glosry_list = GetDataTableFromCacheOrDatabase();

        var result = from record in glosry_list.AsEnumerable()
                     //where record.Field<string>("title").Trim().Substring(0, 1) == "أ" 
                     select record;
          
        
        if (result.Count() > 0)
        {
            glosry_list = result.CopyToDataTable();
            Session["glosry_list"] = glosry_list;
            ViewCharacterList((DataTable)Session["glosry_list"]);

        }
        else
        {
            glosry_list = new DataTable();

            Session["glosry_list"] = glosry_list;
            ViewCharacterList((DataTable)Session["glosry_list"]);

           
        }

        //var result2 = from record in glosry_list.AsEnumerable()
        //             where record.Field<string>("title").Trim().Substring(0, 1) == lab2.Text
        //             select record;


        //if (result2.Count() > 0)
        //{
        //    glosry_list = result2.CopyToDataTable();
        //    if (result.Count() > 0)
        //    { glosry_list.Rows.Add(result); }
        //    Session["glosry_list"] = glosry_list;
        //    ViewCharacterList((DataTable)Session["glosry_list"]);

        //}
    }

    protected void ListPager1_PreRender(object sender, EventArgs e)
    {

        ViewCharacterList((DataTable)Session["glosry_list"]);
    }


   

}
