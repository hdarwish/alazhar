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

public partial class sheikhs_characters_details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Session["content_id"] = Request["id"];
            int id = Convert.ToInt16(Request.QueryString["id"]);
            HiddenID.Value = id.ToString (); 
            ViewDetails(id);
        }

    }

    public void ViewDetails(int id)
    {

        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@char_id",Convert.ToInt16 (HiddenID.Value)) ,
         new SqlParameter("@lang_id",Convert.ToInt16(1))};

        DataTable charDT = new DataTable();
        charDT = DatabaseFunctions.SelectData(sqlParams, "characters_details_select");
        if (charDT.Rows.Count > 0)
        {
            //Img.ImageUrl = "~/images/sheikhs/" + charDT.Rows[0]["image_name"].ToString();
            LabName.Text = charDT.Rows[0]["name"].ToString();
            LabBrief.Text = charDT.Rows[0]["char_brief"].ToString();
            LabDetails.Text = charDT.Rows[0]["char_details"].ToString();
            LabScientific.Text = charDT.Rows[0]["scientific_life"].ToString();
            LabAzhar.Text = charDT.Rows[0]["mashyakha_azhar"].ToString();
            //LabBirthday.Text = charDT.Rows[0]["birth_date"].ToString();
            LabBirthDetails.Text = charDT.Rows[0]["birth_details"].ToString();
            //if (charDT.Rows[0]["title2"].ToString() != "")
            //    Labtype.Text = charDT.Rows[0]["title2"].ToString();
        }
        ///////////////////////////// ACHIEVEMENTS ///////////////////////////////////////////
        SqlParameter[] sqlParamsAch = new SqlParameter[] { new SqlParameter("@Char_id",Convert.ToInt16 (HiddenID.Value)) ,
          new SqlParameter("@lang",Convert.ToInt16(1))};

        DataTable char_AchvDT = new DataTable();
        char_AchvDT = DatabaseFunctions.SelectData(sqlParamsAch, "achievements_details_Select");
        if (char_AchvDT.Rows.Count > 100)
        {

            DataList1.DataSource = char_AchvDT;
            DataList1.DataBind();
            int counter = 0;
            foreach (DataListItem item in DataList1.Items)
            {
                LinkButton LinkID = (LinkButton)item.FindControl("LinkID");
                LinkID.Text = char_AchvDT.Rows[counter]["title"].ToString();
                counter++;
            }

        }
        else Accordion0.Visible = false;
        ///////////////////////////// AWSEMA ///////////////////////////////////////////
        SqlParameter[] sqlParamsAwsema = new SqlParameter[] 
        { new SqlParameter("@char_id",Convert.ToInt16 (HiddenID.Value)) ,
        new SqlParameter("@lang_id",Convert.ToInt16(1))};

        DataTable char_Awsema = new DataTable();
        char_Awsema = DatabaseFunctions.SelectData(sqlParamsAwsema, "awsema_details_select");
        if (char_Awsema.Rows.Count > 100)
        {
            DataList2.DataSource = char_Awsema;
            DataList2.DataBind();
            int countA = 0;
            foreach (DataListItem ditem in DataList2.Items)
            {
                LinkButton LinkID = (LinkButton)ditem.FindControl("LinkID");
                LinkID.Text = char_Awsema.Rows[countA]["title"].ToString();
                countA++;
            }

        }
        else Accordion1.Visible = false;
        ////////////////////////////////////////////TAKREZAT////////////////////////////////////////////////////////////
        SqlParameter[] sqlParamsTkreza = new SqlParameter[] { new SqlParameter("@char_id",Convert.ToInt16 (HiddenID.Value)) ,
          new SqlParameter("@lang_id",Convert.ToInt16(1))};

        DataTable char_Tkreza = new DataTable();
        char_Tkreza = DatabaseFunctions.SelectData(sqlParamsTkreza, "takreezat_details_Select");
        if (char_Tkreza.Rows.Count > 100)
        {
            DataList3.DataSource = char_Tkreza;
            DataList3.DataBind();
            int count = 0;
            foreach (DataListItem Titem in DataList3.Items)
            {
                LinkButton LinkID = (LinkButton)Titem.FindControl("LinkID");
                LinkID.Text = char_Tkreza.Rows[count]["title"].ToString();
                count++;
            }

        }
        else Accordion2.Visible = false;

        ////////////////////////////////////////////Written////////////////////////////////////////////////////////////

        //SqlParameter[] sqlParamsDocs = new SqlParameter[] { new SqlParameter("@char_id",Convert.ToInt16 (HiddenID.Value)) ,
        //  new SqlParameter("@lang_id",Convert.ToInt16(1))};
        ////[characters_docwrittenabout_select]
        //DataTable char_Docs = new DataTable();
        //char_Docs = DatabaseFunctions.SelectData(sqlParamsDocs, "characters_doc_select");
        //if (char_Docs.Rows.Count > 0)
        //{
        //    DataList4.DataSource = char_Docs;
        //    DataList4.DataBind();
        //    int count = 0;
        //    foreach (DataListItem Titem in DataList4.Items)
        //    {
        //        LinkButton LinkID = (LinkButton)Titem.FindControl("LinkID");
        //        LinkID.Text = char_Docs.Rows[count]["DocTitle"].ToString();
        //        count++;
        //    }

        //}
        //else Accordion3.Visible = false;
        //
        ////////////////wrriten About///////////////////

    //    SqlParameter[] sqlParamsWDocs = new SqlParameter[] { new SqlParameter("@char_id",Convert.ToInt16 (HiddenID.Value)) ,
    //      new SqlParameter("@lang_id",Convert.ToInt16(1))};
    //    //[characters_docwrittenabout_select]
    //    DataTable char_WDocs = new DataTable();
    //    char_WDocs = DatabaseFunctions.SelectData(sqlParamsWDocs, "characters_docwrittenabout_select");
    //    if (char_WDocs.Rows.Count > 0)
    //    {
    //        DataList4.DataSource = char_WDocs;
    //        DataList4.DataBind();
    //        int count = 0;
    //        foreach (DataListItem Titem in DataList4.Items)
    //        {
    //            LinkButton LinkID = (LinkButton)Titem.FindControl("LinkID");
    //            LinkID.Text = char_WDocs.Rows[count]["DocTitle"].ToString();
    //            count++;
    //        }

    //    }
    //    else Accordion4.Visible = false;

    }

    }

