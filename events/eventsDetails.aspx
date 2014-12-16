<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/InnerMaster.master"
    AutoEventWireup="true" CodeFile="eventsDetails.aspx.cs" Inherits="events_eventsDetails" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
<script language="javascript">

    function toggle(image_name) {
        var images = new Array();
//        images[0] = "img1";
//        images[1] = "img2";
//        images[2] = "img3";
        images[0] = "img4";
        images[1] = "img5";
        images[2] = "img6";
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
            id="tblchar" dir="<%$ Resources:Master, dir%>">
            <tr>
                <td colspan="4">
                
                    
                        <div class="accordion_title" id="trname" runat="server" onclick="on_click_event">
                            <a href="" class="text_Brown_10pt_bold">
                            <%--<img id="img1"  src="../img/plus.jpg" onclick="toggle('img1')" alt="">--%>
                                <asp:Label ID="txt_title" runat="server" class="text_Brown_10pt_bold"></asp:Label>
                            </a>
                        </div>
                        <div class="accordion_body_empty">
                            <span class="text_Dark_Brown_10pt"></span>
                        </div>
                        
                        <div   id="trstarteventdate" runat="server" onclick="on_click_event">
                            <a href=""  runat="server" class="text_Brown_10pt_bold" style="text-decoration: none;">
                           <%-- <img id="img2"  src="../img/plus.jpg" onclick="toggle('img2')" alt="">--%>
                                <asp:Label ID="Label9" runat="server" Text="<%$ Resources:Master,Start_Date %>" class="text_Brown_10pt_bold"></asp:Label>
                                <asp:Label ID="txt_hstart_date" runat="server" class="text_Dark_Brown_10pt"></asp:Label>
                                <asp:Label ID="Label11" runat="server" Text="<%$ Resources:Master, Date_kind2 %>" class="text_Brown_10pt_bold"></asp:Label>
                                &nbsp - &nbsp
                                <asp:Label ID="txt_start_date" runat="server" class="text_Dark_Brown_10pt"></asp:Label>
                                <asp:Label ID="Label12" runat="server" Text="<%$ Resources:Master, Date_kind1 %> " class="text_Brown_10pt_bold"></asp:Label>
                            </a>
                        </div>
                        <div class="accordion_body_empty">
                            <span class="text_Dark_Brown_10pt"></span>
                        </div>

                        <div   id="trendeventdate" runat="server" onclick="on_click_event">
                            <a href="" class="text_Brown_10pt_bold" style="text-decoration: none;">
                           <%-- <img id="img3"  src="../img/plus.jpg" onclick="toggle('img3')" alt="">--%>
                                <asp:Label ID="Label10" runat="server" Text="<%$ Resources:Master, End_Date %>" class="text_Brown_10pt_bold"></asp:Label>
                                <asp:Label ID="txt_hend_date" runat="server" class="text_Dark_Brown_10pt"></asp:Label>
                                <asp:Label ID="Label1" runat="server" Text="<%$ Resources:Master, Date_kind2 %>" class="text_Brown_10pt_bold"></asp:Label>
                                &nbsp - &nbsp
                                <asp:Label ID="txt_end_date" runat="server" class="text_Dark_Brown_10pt"></asp:Label>
                                <asp:Label ID="Label13" runat="server" Text="<%$ Resources:Master, Date_kind1 %>" class="text_Brown_10pt_bold"></asp:Label>
                            </a>
                        </div>
                        <div class="accordion_body_empty">
                            <span class="text_Dark_Brown_10pt"></span>
                        </div>

                        <div id="accordion">
                        <div   runat="server" id="trnabtha">
                            <a href="" class="text_Brown_10pt_bold" style="text-decoration: none;">
                            <img id="img4"  src="../img/minus.jpg" onclick="toggle('img4')" alt="">
                                <asp:Label ID="Label14" runat="server" Text="<%$ Resources:Master,  Topics_Labels_Brief_Descrip  %>"
                                    class="text_Brown_10pt_bold"></asp:Label>
                            </a>
                        </div>
                        <div class="accordion_body" id="trdetails" runat="server">
                            <span class="text_Dark_Brown_10pt">
                                <asp:Label ID="txtDesc" runat="server" class="text_Dark_Brown_10pt">
                                </asp:Label></span>
                        </div>

                        <div   runat="server" id="trtafsil">
                            <a href="" class="text_Brown_10pt_bold" style="text-decoration: none;">
                            <img id="img5"  src="../img/plus.jpg" onclick="toggle('img5')" alt="">
                                <asp:Label ID="Label15" runat="server" Text="<%$ Resources:Master, Topics_labels_detail_descrip %>"
                                    class="text_Brown_10pt_bold"></asp:Label>
                            </a>
                        </div>
                        <div class="accordion_body" runat="server" id="trbdetails">
                            <span class="text_Dark_Brown_10pt">
                                <asp:Label ID="txtDetailedDesc" runat="server" class="text_Dark_Brown_10pt">
                                </asp:Label></span>
                        </div>

                        <div   runat="server" id="trn">
                            <a href="" class="text_Brown_10pt_bold" style="text-decoration: none;">
                            <img id="img6"  src="../img/plus.jpg" onclick="toggle('img6')" alt="">
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
