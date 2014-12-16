<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/InnerMaster.master"
    AutoEventWireup="true" CodeFile="topicsDetails.aspx.cs" Inherits="topics_topicsDetails" %>

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
    <div>
        <table cellpadding="0" style="width: 100%" border="0" cellspacing="0" runat="server"
            id="tblchar" dir="rtl">
            <tr>
                <td>
                    
                        <div class="accordion_title" id="trname" runat="server">
                            <a href="#" class="text_Brown_10pt_bold">
                                <asp:Label ID="txt_title" runat="server" class="text_Brown_10pt_bold"></asp:Label>
                            </a>
                        </div>
                        <div class="accordion_body_empty">
                            <span class="text_Dark_Brown_10pt"></span>
                        </div>

                        <div id="accordion">
                        <div   id="trnabtha" runat="server">
                            <a href="#" class="text_Brown_10pt_bold">
                             <img id="img0"  src="../img/minus.jpg" onclick="toggle('img0')" alt="">
                                <asp:Label ID="Label14" runat="server" Text="<%$ Resources:Master,  Topics_Labels_Brief_Descrip  %>"
                                    class="text_Brown_10pt_bold"></asp:Label>
                            </a>
                        </div>
                        <div class="accordion_body" id="trdetails" runat="server">
                            <span class="text_Dark_Brown_10pt">
                                <asp:Label ID="txtDesc" runat="server" class="text_Dark_Brown_10pt">
                                </asp:Label></span>
                        </div>

                        <div   id="trtafsil" runat="server">
                            <a href="#" class="text_Brown_10pt_bold">
                            <img id="img1"  src="../img/plus.jpg" onclick="toggle('img1')" alt="">
                                <asp:Label ID="Label15" runat="server" Text="<%$ Resources:Master, Topics_labels_detail_descrip %>"
                                    class="text_Brown_10pt_bold"></asp:Label>
                            </a>
                        </div>
                        <div class="accordion_body" id="trbdetails" runat="server">
                            <span class="text_Dark_Brown_10pt">
                                <asp:Label ID="txtDetailedDesc" runat="server" class="text_Dark_Brown_10pt">
                                </asp:Label></span>
                        </div>

                        <div   id="trn" runat="server">
                            <a href="#" class="text_Brown_10pt_bold">
                            <img id="img2"  src="../img/plus.jpg" onclick="toggle('img2')" alt="">
                                <asp:Label ID="Label22" runat="server" Text="<%$ Resources:Master, Lbl_character_Notes  %>"
                                    class="text_Brown_10pt_bold"></asp:Label>
                            </a>
                        </div>
                        <div class="accordion_body" id="trnotes" runat="server">
                            <span class="text_Dark_Brown_10pt">
                                <asp:Label ID="txtNotes" runat="server" class="text_Dark_Brown_10pt"></asp:Label></span>
                        </div>
                    </div>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
