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
using Microsoft.Reporting.WebForms;
using System.Collections.Generic;


public partial class administration_entry_form : BasePage
{
    public static string id = "";
    private string sql_Connection = Database.ConnectionString;
    General_Helping Obj_General_Helping = new General_Helping();
    // static int smartvalue = 0;
    protected override void OnInit(EventArgs e)
    {

        this.Smrt_Srch_object.Value_Handler += new Smart_Search.Delegate_Selected_Value(MOnMember_Data);

    }

    private void MOnMember_Data(string Value)
    {
        id = Smrt_Srch_object.SelectedValue;
        if (Smrt_Srch_object.SelectedValue != "")
        {
            //id = Smrt_Srch_object.SelectedValue;


            //tr_lock.Visible = false;
            //if (Request["operation"].ToString() == "wrong")
            //{

            //    fillgrid();

            //}

            string obj_table = "";
            
                    obj_table = "characters";
            
            ViewReport.Visible = true;


        }
    }


    private void Fill_smart(string Value)
    { //public void fill_objects_titles()
        //{
        string setvalue = "50";
        DataTable dt = new DataTable();

       
                SqlParameter[] sqlParams1 = new SqlParameter[] { new SqlParameter("@char_name", ""), new SqlParameter("@selview", setvalue), 
                                                                new SqlParameter("@user_id","1"),
                                                                new SqlParameter("@lang_id","1")};
                Smrt_Srch_object.stored = "get_characters_titles";
                Smrt_Srch_object.stored_parameters = sqlParams1;
        Smrt_Srch_object.Value_Field = "id";
        Smrt_Srch_object.Text_Field = "title";
        Smrt_Srch_object.DataBind();


    }

    protected void Page_Load(object sender, EventArgs e)
    {
        // meeting comment 22-10-2012

        if (!IsPostBack)
        {

            Fill_smart("1");
            //ViewReport.Visible = false;

        }

    }

    public void fill_data()
    {

      
       


    }



    ////////////////////////////////////////////////////////////////////////////////////



    protected void Smrt_Srch_object_SelectedIndexChanged(object sender, EventArgs e)
    {


    }
  

    protected void ViewReport_Click(object sender, EventArgs e)
    {
        //   ReportViewer1.ShowCredentialPrompts = false;

        //   ReportViewer1.ServerReport.ReportServerCredentials = new ReportCredentials("Administrator", "P@ssw0rd", "hhi");

        ReportViewer1.ServerReport.ReportServerUrl = new Uri(ConfigurationManager.AppSettings["reportserveruri"].ToString());
       
        List<ReportParameter> parameters = new List<ReportParameter>();
        string reportPath = "";

         reportPath = "/Azhar_report/type_personality_live";
                    ReportViewer1.ServerReport.ReportPath = reportPath;
                    string selectedVal = Smrt_Srch_object.SelectedValue;
                    if (selectedVal.Trim() == "" || Convert.ToInt32(selectedVal) <= 0)
                    { selectedVal = "0"; }
                    ReportParameter param = (new ReportParameter("id", selectedVal));
                   
                    parameters.Add(param);
                    ReportViewer1.ServerReport.SetParameters(parameters);
               
                   
                    ReportViewer1.ProcessingMode = ProcessingMode.Remote;
                    //ReportViewer1.ProcessingMode = ProcessingMode.Local;
                    ReportViewer1.ShowParameterPrompts = false;
                    ReportViewer1.ShowPromptAreaButton = false;
                    ReportViewer1.ServerReport.Refresh();
                   

        ReportViewer1.ServerReport.ReportPath = reportPath;
        // ReportViewer1.ServerReport.SetParameters(parameters);

        ReportViewer1.ProcessingMode = ProcessingMode.Remote;
        //ReportViewer1.ProcessingMode = ProcessingMode.Local;

        ReportViewer1.ShowParameterPrompts = false;

        ReportViewer1.ShowPromptAreaButton = false;

        ReportViewer1.ServerReport.Refresh();
    }
}