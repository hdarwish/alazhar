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

public partial class administration_veiw_files : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
        {
            switch (Request.QueryString["type"])
            {
                case "1":
                    divImages.Style.Add("display", "block");
                    divVid.Style.Add("display", "none");
                    divAudio.Style.Add("display", "none");
                    divPDF.Style.Add("display", "none");
                    imgToVeiw.ImageUrl = "~/images/sheikhs/"+Request.QueryString["fname"];
                 break;
                case "2":
                 divImages.Style.Add("display", "block");
                 divVid.Style.Add("display", "none");
                 divAudio.Style.Add("display", "none");
                 divPDF.Style.Add("display", "none");
                    imgToVeiw.ImageUrl = "~/images/events/" + Request.QueryString["fname"];
                    
                 break;
                case "3":
                 divImages.Style.Add("display", "block");
                 divVid.Style.Add("display", "none");
                 divAudio.Style.Add("display", "none");
                 divPDF.Style.Add("display", "none");
                 imgToVeiw.ImageUrl = "~/images/topics/" + Request.QueryString["fname"];

                 break;
                case "4":
                 divImages.Style.Add("display", "block");
                 divVid.Style.Add("display", "none");
                 divAudio.Style.Add("display", "none");
                 divPDF.Style.Add("display", "none");
                 imgToVeiw.ImageUrl = "~/upload/forms/" + Request.QueryString["fname"];

                 break;
                case "6":
                 if (Request.QueryString["fname"].Split('.')[1].ToLower().ToString() != "wmv" && Request.QueryString["fname"].Split('.')[1].ToLower().ToString() != "mp4")
                 {

                     divImages.Style.Add("display", "block");
                     divVid.Style.Add("display", "none");
                     divAudio.Style.Add("display", "none");
                     divPDF.Style.Add("display", "none");
                     imgToVeiw.ImageUrl = "~/upload/Videos/" + Request.QueryString["fname"];
                 }
                 else
                 {
                     divImages.Style.Add("display", "none");
                     divVid.Style.Add("display", "block");
                     divAudio.Style.Add("display", "none");
                     divPDF.Style.Add("display", "none");
                 }
                 break;
                case "7":
                     divImages.Style.Add("display", "none");
                     divVid.Style.Add("display", "none");
                     divAudio.Style.Add("display", "block");
                     divPDF.Style.Add("display", "none");
                 break;
                case "8":
                case "9":
                case "10":
case "12":
case "13":
case "14":

                 if (Request.QueryString["fname"].Split('.')[1].ToLower().ToString() != "pdf")
                 {

                     divImages.Style.Add("display", "block");
                     divVid.Style.Add("display", "none");
                     divAudio.Style.Add("display", "none");
                     divPDF.Style.Add("display", "none");
                     imgToVeiw.ImageUrl = "~/images/esdarat/" + Request.QueryString["fname"];
                 }
                 else
                 {
                     divImages.Style.Add("display", "none");
                     divVid.Style.Add("display", "none");
                     divAudio.Style.Add("display", "none");
                     divPDF.Style.Add("display", "block");
                     link_pdf.InnerText = Request.QueryString["fname"];
                     link_pdf.HRef = "~/images/esdarat/" + Request.QueryString["fname"];
                 }
                 break;
                case "11":
                 divImages.Style.Add("display", "block");
                 divVid.Style.Add("display", "none");
                 divAudio.Style.Add("display", "none");
                 divPDF.Style.Add("display", "none");
                 imgToVeiw.ImageUrl = "~/images/uploaded_images/" + Request.QueryString["fname"];
                 break;
                case "15":
                 divImages.Style.Add("display", "block");
                 divVid.Style.Add("display", "none");
                 divAudio.Style.Add("display", "none");
                 divPDF.Style.Add("display", "none");
                 imgToVeiw.ImageUrl = "~/images/esdarat/" + Request.QueryString["fname"];
                 break;
                case "17":
                 divImages.Style.Add("display", "none");
                 divVid.Style.Add("display", "none");
                 divAudio.Style.Add("display", "none");
                 divPDF.Style.Add("display", "block");
                 link_pdf.InnerText = Request.QueryString["fname"];
                 link_pdf.HRef = "~/upload/forms/" + Request.QueryString["fname"];

                 break;


            }
          
        }

    }
    public string Get_vid_Path()
    {
        string path = "";
        path += ResolveUrl("~/upload/Videos/" + Request.QueryString["fname"]);
        
        return path;
    }
    public string Get_aud_Path()
    {
        string path = "";
        path += ResolveUrl("~/upload/audio/" + Request.QueryString["fname"]);

        return path;
    }
    
}
