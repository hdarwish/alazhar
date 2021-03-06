﻿using System;
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

public partial class Audio_Tracks : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            ItemsGet(0);

        }
    }

    private void ItemsGet(int type)
    {
        DataTable AudioDT = new DataTable();

        if (type == 0)
        {
            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", menus_update.get_content_type(Session["page_name"].ToString()).ToString()), 
                                                        new SqlParameter("@content_id", HttpContext.Current.Session["content_id"].ToString()), 
                                                        new SqlParameter("@lang", HttpContext.Current.Session["lang_id"].ToString()) };
            AudioDT = DatabaseFunctions.SelectData(sqlParams, "get_audio_content");
            if (HttpContext.Current.Session["content_id"] != "0")
            {
                divFilter.Style.Add("display", "none");
                divlbl.Style.Add("display", "none");
            }
            else
            {
                divFilter.Style.Add("display", "block");
                divlbl.Style.Add("display", "block");
            }
        }
        else
        {
            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", Convert.ToString(type)), 
                                                        new SqlParameter("@content_id", HttpContext.Current.Session["content_id"].ToString()), 
                                                        new SqlParameter("@lang", HttpContext.Current.Session["lang_id"].ToString()) };
            AudioDT = DatabaseFunctions.SelectData(sqlParams, "get_audio_content");
            if (HttpContext.Current.Session["content_id"] != "0")
            {
                divFilter.Style.Add("display", "none");
                divlbl.Style.Add("display", "none");
            }
            else
            {
                divFilter.Style.Add("display", "block");
                divlbl.Style.Add("display", "block");
            }
        }
        
         //   SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@id", Convert.ToInt16(0)) ,
         //new SqlParameter("@content_type", Convert.ToInt16(type))};
         //   AudioDT = DatabaseFunctions.SelectData(sqlParams, "audio_select");
         //   divFilter.Style.Add("display", "block");
         //   divlbl.Style.Add("display", "block");
       
        // Populate the repeater control with the Items DataSet
        PagedDataSource objPds = new PagedDataSource();
        //objPds.DataSource = Items.Tables[0].DefaultView;

        //DataView dv = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
      
        

        
        objPds.DataSource = AudioDT.DefaultView;
        objPds.AllowPaging = true;
        objPds.PageSize = 9;

        objPds.CurrentPageIndex = CurrentPage;

        lblCurrentPage.Text = "صفحة : " + (CurrentPage + 1).ToString() + " من "
            + objPds.PageCount.ToString();


        ArrayList myTotalPages = new ArrayList();

        for (int a = 1; a <= objPds.PageCount; a++)
        {

            myTotalPages.Add(a);


        }

        //DropDownList1.DataSource = myTotalPages;
        //DropDownList1.DataBind();

        //DropDownList1.SelectedIndex = CurrentPage;




        // Disable Prev or Next buttons if necessary
        cmdPrev.Enabled = !objPds.IsFirstPage;
        cmdNext.Enabled = !objPds.IsLastPage;


        //string sql1 = "SELECT [file_name], [extension] FROM [content_media] where [content_type]=2";
        //DataTable DT1 = new DataTable();
        //DT1 = db.GetDataTable(sql1);
        DLAudio.DataSource = objPds;
        DLAudio.DataBind();
    }

    public int CurrentPage
    {
        get
        {
            // look for current page in ViewState
            object o = this.ViewState["_CurrentPage"];
            if (o == null)
                return 0;       // default to showing the first page
            else
                return (int)o;
        }

        set
        {
            this.ViewState["_CurrentPage"] = value;
        }
    }
    protected void cmdPrev_Click(object sender, System.EventArgs e)
    {
        // Set viewstate variable to the previous page
        CurrentPage -= 1;

        // Reload control
        ItemsGet(Convert.ToInt16(rbl1.SelectedValue));
    }

    protected void cmdNext_Click(object sender, System.EventArgs e)
    {
        // Set viewstate variable to the next page
        CurrentPage += 1;

        // Reload control
        ItemsGet(Convert.ToInt16(rbl1.SelectedValue));
    }

    protected void rbl1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (rbl1.SelectedValue == "0")
        { ItemsGet(0); }
        else if (rbl1.SelectedValue == "1")
        { ItemsGet(1); }
        else if (rbl1.SelectedValue == "2")
        { ItemsGet(2); }
        else if (rbl1.SelectedValue == "3")
        { ItemsGet(3); }
        else if (rbl1.SelectedValue == "4")
        { ItemsGet(4); }
    }
}
