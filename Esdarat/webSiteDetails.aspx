<%@ Page Language="C#" MasterPageFile="~/masterpage/InnerMaster.master" AutoEventWireup="true"
    CodeFile="webSiteDetails.aspx.cs" Inherits="Esdarat_webSiteDetails" Title="Untitled Page" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
<script language="javascript">

        function toggle(image_name) {
            var images = new Array();
            images[0] = "img0";
            images[1] = "img1";
            images[2] = "img2";
            for (var i = 0; i < images.length; i++) {
                if (document.getElementById(images[i]).id != image_name) {
                    document.getElementById(images[i]).src = "../img/plus.jpg";
                }
                else {
                    document.getElementById(image_name).src = "../img/minus.jpg";
                }
            }
        }
</script>
    <input id="HiddenID" type="hidden" runat="server" />
    <table style="width: 98%" border="0" cellspacing="0" runat="server" id="tblmanus" align="<%$Resources:Master, align%>">
        <tr>
            <td>
                
                    <div class="accordion_title" id="tr_title" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Labtitle" runat="server" class="text_Brown_10pt_bold" Text="<%$Resources:Master, website_title %>"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body_empty">
                            <span class="text_Dark_Brown_10pt"></span>
                        </div>
                    <div class="accordion_title" id="tr_lang" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label6" runat="server" class="text_Brown_10pt_bold" Text=" <%$Resources:Master, Website_Lang%>"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="tr_lang2" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="Lablang" runat="server"></asp:Label></span>
                    </div>
                    <div class="accordion_title" id="Trelectitle" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label1" runat="server" class="text_Brown_10pt_bold" Text="<%$Resources:Master, URL%>"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="Trelectitle2" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="Laburl" runat="server"></asp:Label></span>
                    </div>
                    <div class="accordion_title" id="rerespon" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label4" runat="server" class="text_Brown_10pt_bold" Text="<%$Resources:Master, Responsible_Name%> "></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="rerespon2" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="Labres" runat="server"></asp:Label></span>
                    </div>


                    <div id="accordion">
                    <div class="accordion_title" id="trdesc" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img0"  src="../img/minus.jpg" onclick="toggle('img0')" alt="">
                            <asp:Label ID="Label456" runat="server" class="text_Brown_10pt_bold" Text='<%$ Resources:Master, website_Desc %>'></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trdesc2" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="Labdesc" runat="server"></asp:Label></span>
                    </div>
                    <div class="accordion_title" id="trdate" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img1"  src="../img/plus.jpg" onclick="toggle('img1')" alt="">
                            <asp:Label ID="Label9" runat="server" class="text_Brown_10pt_bold" Text="<%$Resources:Master, login_date %>"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trdate2" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="Labdate" runat="server"></asp:Label></span>
                    </div>
                    <div class="accordion_title" id="trnotes" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img2"  src="../img/plus.jpg" onclick="toggle('img2')" alt="">
                            <asp:Label ID="Label15" runat="server" class="text_Brown_10pt_bold" Text='<%$ Resources:Master, lbl_photo_Notes %>'></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trnotes2" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="Labnotes" runat="server"></asp:Label></span>
                    </div>
                </div>
            </td>
        </tr>
    </table>
</asp:Content>
