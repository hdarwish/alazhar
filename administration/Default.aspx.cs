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

public partial class administration_Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string stype = "";
        if (Session["user_type"] != null)
            stype = Session["user_type"].ToString();
        if (Session["user_type"] != null && Session["user_type"].ToString() == "10")
        {
            admin_tr.Visible = true;
        }

        if (Session["user_type"] != null && Session["user_type"].ToString() == "8")
        {
            lbl_pagetitle.Visible = true;
            lbl_pagetitle.Text = "شاشة المراجعة النهائية";
            SqlParameter[] newSqlParams = new SqlParameter[] {  new SqlParameter("@form_status", "11"), 
                                                                new SqlParameter("@file_status", "11"), 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()) ,
                                                                new SqlParameter("@lang_id",CDataConverter.ConvertToInt(menus_update.get_current_lang())) };
            DataTable newDT = DatabaseFunctions.SelectData(newSqlParams, "get_final_new_count");
            if (newDT.Rows.Count > 0)
            {
                LinkButton10.Visible = true;
                final_new_count.Text = newDT.Rows.Count.ToString();
            }
            final_revision_tr.Visible = true;
        }
        else if (Session["user_type"] != null && Session["user_type"].ToString() == "6")
        {
            lbl_pagetitle.Visible = true;
            lbl_pagetitle.Text = "شاشة مدخل الملفات ";
            SqlParameter[] newSqlParams = new SqlParameter[] { new SqlParameter("@file_status", "6"), new SqlParameter("@user_id", Session["user_id"].ToString()) };
            DataTable newDT = DatabaseFunctions.SelectData(newSqlParams, "get_files_new_count");
            if (newDT.Rows.Count > 0)
            {
                LinkButton4.Visible = true;
                files_new_count.Text = newDT.Rows.Count.ToString();
            }
            SqlParameter[] unfinishedSqlParams = new SqlParameter[] { new SqlParameter("@file_status", "7"), new SqlParameter("@user_id", Session["user_id"].ToString()) };
            DataTable unfinishedDT = DatabaseFunctions.SelectData(unfinishedSqlParams, "get_files_new_count_filtered_unfinushed");
            if (unfinishedDT.Rows.Count > 0)
            {
                LinkButton7.Visible = true;
                files_unfinished_count.Text = unfinishedDT.Rows.Count.ToString();
            }
            //SqlParameter[] processedSqlParams = new SqlParameter[] { new SqlParameter("@file_status", "8") };
            //DataTable processedDT = DatabaseFunctions.SelectData(processedSqlParams, "get_files_new_count");
            //if (processedDT.Rows.Count > 0)
            //{
            //    LinkButton5.Visible = true;
            //    files_processed_count.Text = processedDT.Rows.Count.ToString();
            //}
            SqlParameter[] refusedSqlParams = new SqlParameter[] { new SqlParameter("@file_status", "9"), new SqlParameter("@user_id", Session["user_id"].ToString()) };
            DataTable refusedDT = DatabaseFunctions.SelectData(refusedSqlParams, "get_files_new_count_filtered_err");
            if (refusedDT.Rows.Count > 0)
            {
                LinkButton4.Enabled = false;
                LinkButton7.Enabled = false;
                LinkButton14.Visible = true;
                files_refused_count.Text = refusedDT.Rows.Count.ToString();
            }
            file_entry_tr.Visible = true;
        }
        else if (Session["user_type"] != null && Session["user_type"].ToString() == "7")
        {
            lbl_pagetitle.Visible = true;
            lbl_pagetitle.Text = "شاشة مراقب جودة الملفات";
            SqlParameter[] newSqlParams = new SqlParameter[] { new SqlParameter("@file_status", "8"), new SqlParameter("@user_id", Session["user_id"].ToString()) };
            DataTable newDT = DatabaseFunctions.SelectData(newSqlParams, "get_files_new_count");
            if (newDT.Rows.Count > 0)
            {
                LinkButton6.Visible = true;
                files_revision_new_count.Text = newDT.Rows.Count.ToString();
            }
            SqlParameter[] unfinishedSqlParams = new SqlParameter[] { new SqlParameter("@file_status", "26"), new SqlParameter("@user_id", Session["user_id"].ToString()) };
            DataTable unfinishedDT = DatabaseFunctions.SelectData(unfinishedSqlParams, "get_files_new_count");
            if (unfinishedDT.Rows.Count > 0)
            {
                LinkButton8.Visible = true;
                files_revision_unfinished_count.Text = unfinishedDT.Rows.Count.ToString();
            }

            SqlParameter[] correctedSqlParams = new SqlParameter[] { new SqlParameter("@file_status", "18"), new SqlParameter("@user_id", Session["user_id"].ToString()) };
            DataTable correctedDT = DatabaseFunctions.SelectData(correctedSqlParams, "get_files_new_count");
            if (correctedDT.Rows.Count > 0)
            {
                LinkButton18.Visible = true;
                files_revision_corrected_count.Text = correctedDT.Rows.Count.ToString();
            }
            SqlParameter[] refusedSqlParams = new SqlParameter[] { new SqlParameter("@file_status", "10"), new SqlParameter("@user_id", Session["user_id"].ToString()) };
            DataTable refusedDT = DatabaseFunctions.SelectData(refusedSqlParams, "get_files_new_count");
            if (refusedDT.Rows.Count > 0)
            {
                LinkButton13.Visible = true;
                files_revision_refused_count.Text = refusedDT.Rows.Count.ToString();
            }
            file_revision_tr.Visible = true;
        }
        if (Session["user_type"] != null && Session["user_type"].ToString() == "5")
        {
            lbl_pagetitle.Visible = true;
            lbl_pagetitle.Text = "شاشة مراقب جودة الاستمارات";
            SqlParameter[] newSqlParams = new SqlParameter[] { new SqlParameter("@form_status", "3"), new SqlParameter("@user_id", Session["user_id"].ToString()), new SqlParameter("@lang_id",Convert.ToInt32(menus_update.get_current_lang()))};
            DataTable newDT = DatabaseFunctions.SelectData(newSqlParams, "get_final_entryform_count");
            if (newDT.Rows.Count > 0)
            {
                LinkButton21.Visible = true;
                Label1.Text = newDT.Rows.Count.ToString();
            }
            else Label1.Visible = false;
            SqlParameter[] newSqlParams2 = new SqlParameter[] { new SqlParameter("@form_status", "4"), new SqlParameter("@user_id", Session["user_id"].ToString()), new SqlParameter("@lang_id", Convert.ToInt32(menus_update.get_current_lang())) };
            DataTable porceedDT = DatabaseFunctions.SelectData(newSqlParams2, "get_final_entryform_count_filtered_err");
            if (porceedDT.Rows.Count > 0)
            {
                LinkButton22.Visible = true;
                Label2.Text = porceedDT.Rows.Count.ToString();
            }
            else Label2.Visible = false;


            SqlParameter[] newSqlunfinished = new SqlParameter[] { new SqlParameter("@form_status", "19"), new SqlParameter("@user_id", Session["user_id"].ToString()), new SqlParameter("@lang_id", Convert.ToInt32(menus_update.get_current_lang())) };
            DataTable unfinishedDT = DatabaseFunctions.SelectData(newSqlunfinished, "get_final_entryform_count_filtered_unfinushed");
           if (unfinishedDT.Rows.Count > 0)
           {
               LinkButton23.Visible = true;
               Label3.Text = unfinishedDT.Rows.Count.ToString();
           }
           //else { Label3.Visible = false; }

             tr_quality.Visible = true;
        }

        if (Session["user_type"] != null && Session["user_type"].ToString() == "4")
        {
            lbl_pagetitle.Visible = true;
            lbl_pagetitle.Text = "شاشة مدخل الاستمارات";
            SqlParameter[] newSqlParams4 = new SqlParameter[] { new SqlParameter("@form_status", "1"), new SqlParameter("@user_id", Session["user_id"].ToString()), new SqlParameter("@lang_id", menus_update.get_current_lang()) };
            DataTable entryDT = DatabaseFunctions.SelectData(newSqlParams4, "get_final_entryform_count");
            if (entryDT.Rows.Count > 0)
            {
                Link_New.Visible = true;
                Lab_new.Text = entryDT.Rows.Count.ToString();
            }
            else Link_New.Visible = false;
            SqlParameter[] newSqlParams5 = new SqlParameter[] { new SqlParameter("@form_status", "2"), new SqlParameter("@user_id", Session["user_id"].ToString()), new SqlParameter("@lang_id", menus_update.get_current_lang()) };
            DataTable entry2DT = DatabaseFunctions.SelectData(newSqlParams5, "get_final_entryform_count_filtered_unfinushed");
//Response.Write(menus_update.get_current_lang()+" "+Session["user_id"].ToString());
            if (entry2DT.Rows.Count > 0)
            {
                Link_UN.Visible = true;
                Lab_UN.Text = entry2DT.Rows.Count.ToString();
            }
            else Link_UN.Visible = false;

            SqlParameter[] newSqlParams6 = new SqlParameter[] { new SqlParameter("@form_status", "5"), new SqlParameter("@user_id", Session["user_id"].ToString()), new SqlParameter("@lang_id", menus_update.get_current_lang()) };
            DataTable entry5DT = DatabaseFunctions.SelectData(newSqlParams6, "get_final_entryform_count_filtered_err");
            if (entry5DT.Rows.Count > 0)
            {
                Link_error.Visible = true;
                Link_New.Enabled = false;
                Link_UN.Enabled = false;

                Lab_error.Text = entry5DT.Rows.Count.ToString();
            }
            else { Lab_error.Visible = false; }
            tr_formentry.Visible = true;

        }
        if (Session["sendto"] != null && Session["sendto"].ToString() == "quality")
        {
            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال الاستمارة إلى مراقب جودة الاستمارات ')</script>");
            Session["sendto"] = null;
        }
        
        if (Session["sendto"] != null && Session["sendto"].ToString() == "entry")
        {
            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال الاستمارةإلى مدخل الاستمارات ')</script>");
            Session["sendto"] = null;
        }
        if (Session["sendto"] != null && Session["sendto"].ToString() == "final")
        {
            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى المراجعة النهائية ')</script>");
            Session["sendto"] = null;
        }
        if (Session["sendto"] != null && Session["sendto"].ToString() == "frontend")
        {
            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم الانتهاء من المراجعة النهائية للعنصر ')</script>");
            Session["sendto"] = null;
        }
        if (Session["sendto"] != null && Session["sendto"].ToString() == "qualitylocked")
        {
            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('عفواً تم الاستحواذ علي الاستمارة من مراجع آخر ')</script>");
            Session["sendto"] = null;
        }
        if (Session["sendto"] != null && Session["sendto"].ToString() == "entrylocked")
        {
            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('عفواً تم الاستحواذ علي الاستمارة من مدخل آخر ')</script>");
            Session["sendto"] = null;
        }
        
    }
    
    
    
}
