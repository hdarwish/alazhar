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
using System.IO;

public partial class masterpage_leftUC : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string page_name = Path.GetFileName(Request.Path);
            Session["page_name"] = page_name;
            if (Session["content_type"].ToString() == "0" && Session["content_id"].ToString() == "0")
            {
                trContent.Visible=false;
            }
            string images_count_str = menus_update.get_images_count(page_name);
            if (images_count_str == "")
            {
                images_link.HRef = "";
                images_link.Attributes.Add("onclick", "javascript : void(0);");
            }
            images_count.Text += menus_update.get_images_count(page_name);
            string docs_count_str = menus_update.get_docs_count(page_name);
            if (docs_count_str == "")
            {
                docs_link.HRef = "";
                docs_link.Attributes.Add("onclick", "javascript : void(0);");
            }
            docs_count.Text += menus_update.get_docs_count(page_name);
            string books_count_str = menus_update.get_books_count(page_name);
            if (books_count_str == "")
            {
                books_link.HRef = "";
                books_link.Attributes.Add("onclick", "javascript : void(0);");
            }
            books_count.Text += menus_update.get_books_count(page_name);
            string articles_count_str = menus_update.get_articles_count(page_name);
            if (articles_count_str == "")
            {
                articles_link.HRef = "";
                articles_link.Attributes.Add("onclick", "javascript : void(0);");
            }
            articles_count.Text += menus_update.get_articles_count(page_name);
            string videos_count_str = menus_update.get_videos_count(page_name);
            if (videos_count_str == "")
            {
                videos_link.HRef = "";
                videos_link.Attributes.Add("onclick", "javascript : void(0);");
            }
            videos_count.Text += menus_update.get_videos_count(page_name);
            string audios_count_str = menus_update.get_audios_count(page_name);
            if (audios_count_str == "")
            {
                audios_link.HRef = "";
                audios_link.Attributes.Add("onclick", "javascript : void(0);");
            }
            audios_count.Text += menus_update.get_audios_count(page_name);
            string artifacts_count_str = menus_update.get_artifacts_count(page_name); 
            if (artifacts_count_str == "")
            {
                artifacts_link.HRef = "";
                artifacts_link.Attributes.Add("onclick", "javascript : void(0);");
            }
            //artifacts_count.Text += menus_update.get_artifacts_count(page_name);
            string manuscripts_count_str = menus_update.get_manuscripts_count(page_name);
            if (manuscripts_count_str == "")
            {
                manuscripts_link.HRef = "";
                manuscripts_link.Attributes.Add("onclick", "javascript : void(0);");
            }
            //manuscripts_count.Text += menus_update.get_manuscripts_count(page_name);
            //string conference_proceedings_count_str = menus_update.get_ConferenceProceedings_count(page_name);
            //if (conference_proceedings_count_str == "")
            //{
            //    .HRef = "";
            //    manuscripts_link.Attributes.Add("onclick", "javascript : void(0);");
            //}
        }
    }
}
