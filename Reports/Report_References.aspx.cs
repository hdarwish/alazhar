using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Reporting.WebForms;

public partial class Reports_Report_References : System.Web.UI.Page
{

    public void fill_data()
    {



        //DataTable objectsDT = content_types_DB.SelectAll();
        //object_type.DataSource = content_types_DB.SelectAll();
        //object_type.DataBind();

        //int counter = objectsDT.Rows.Count;

        //SqlParameter[] newSqlParams = new SqlParameter[] { };
        //DataTable newDT = DatabaseFunctions.SelectData(newSqlParams, "get_final_entryform_report");
        //int counterS = newDT.Rows.Count;
        //if (newDT.Rows.Count > 0)
        //{
        //    for (int count = 0; count < counter; count++)
        //    {
        //        DataRow[] foundRows;
        //        foundRows = newDT.Select("ctype = '" + object_type.Items[count].Value + "'");
        //        if (foundRows.Length == 0 && object_type.Items[count].Value != "0")
        //            objectsDT.Rows[count].Delete();
        //    }
        //}

        //object_type.DataSource = objectsDT;
        //object_type.DataBind();
        //ListItem litem = new ListItem("-- اختر نوع الاستمارة --", "0");
        //litem.Selected = true;
        //object_type.Items.Insert(0, litem);
       

    }

    protected void Page_Load(object sender, EventArgs e)
    {
        //fill_data();
    }
    protected void object_type_SelectedIndexChanged(object sender, EventArgs e)
    {



        ReportViewer1.ShowCredentialPrompts = false;
        ReportViewer1.ServerReport.ReportServerUrl = new Uri("http://amrafifi-pc/ReportServer");
        List<ReportParameter> parameters = new List<ReportParameter>();
        string reportPath = "/Reports_Ashzr/Report_References";

        parameters.Add(new ReportParameter("id_content_type", object_type.SelectedValue));

        ReportViewer1.ServerReport.ReportPath = reportPath;
        ReportViewer1.ServerReport.SetParameters(parameters);
        ReportViewer1.ProcessingMode = ProcessingMode.Remote;

        ReportViewer1.ServerReport.Refresh();
        ReportViewer1.ShowParameterPrompts = false;
        

    
    }
}