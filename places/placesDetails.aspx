<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/InnerMaster.master"
    AutoEventWireup="true" CodeFile="placesDetails.aspx.cs" Inherits="places_placesDetails" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
<script language="javascript">

    function toggle(image_name) {
        var images = new Array();
        images[0] = "img0";
        images[1] = "img1";
        images[2] = "img2";
        images[3] = "img3";
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

    <table cellpadding="0" style="width: 100%" border="0" cellspacing="0" runat="server" id="Table1" dir="<%$ Resources:Master, dir%>" >
        <tr>
            <td align="right" dir="rtl" colspan="2">
               
                    <div class="accordion_title" id="Tr5" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Labtitle" runat="server" class="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body_empty">
                        <span class="text_Dark_Brown_10pt"></span>
                    </div>

                     <div id="accordion">
                    <div   id="Tr4" runat="server">
                        <a href="" class="text_Brown_10pt_bold" style="text-decoration:none;">
                        <img id="img0"  src="../img/minus.jpg" onclick="toggle('img0')" alt="">
                            <asp:Label ID="Label32" runat="server" class="text_Brown_10pt_bold" Text="<%$ Resources:Master, Places_labels_briefDescription %>"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" runat="server" id="trbrief">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="txt_brief" runat="server" class="text_Dark_Brown_10pt"></asp:Label>
                        </span>
                    </div>

                    <div   id="tr_title" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img1"  src="../img/plus.jpg" onclick="toggle('img1')" alt="">
                            <asp:Label ID="Label33" runat="server" Text="<%$ Resources:Master, key_building_place %>" class="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" runat="server" id="trtdesc">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="lbl_place_type" runat="server" class="text_Dark_Brown_10pt"> </asp:Label>
                            <asp:RadioButtonList ID="rbl_place_type" runat="server" Visible="false">
                            </asp:RadioButtonList>
                        </span>
                    </div>

                    <div   id="tr6" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img2"  src="../img/plus.jpg" onclick="toggle('img2')" alt="">
                            <asp:Label ID="Label34" runat="server" Text="<%$ Resources:Master, key_Creation_Date %> " class="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" runat="server" id="trmaker">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="txt_creation_hijr_date" runat="server" class="text_Dark_Brown_10pt"></asp:Label>
                            &nbsp;

                            <asp:Label ID="Label7" runat="server" Text="<%$ Resources:Master, key_date1 %>" class="text_Dark_Brown_10pt"></asp:Label>
                            <br />
                            <asp:Label ID="txt_creation_georg_date" runat="server" class="text_Dark_Brown_10pt"></asp:Label>
                            &nbsp;
                            <asp:Label ID="Label8" runat="server" Text="<%$ Resources:Master, key_date2 %>" class="text_Dark_Brown_10pt"></asp:Label>
                        </span>
                    </div>

                    <div   id="tr7" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img3"  src="../img/plus.jpg" onclick="toggle('img3')" alt="">
                            <asp:Label ID="Label26" runat="server" Text="<%$ Resources:Master, key_Date_completion %>" class="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" runat="server" id="trtype">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="txt_end_creation_hijr_date" runat="server" class="text_Dark_Brown_10pt"></asp:Label>
                            &nbsp;
                            <asp:Label ID="Label2" runat="server" Text="<%$ Resources:Master, key_date1 %>" class="text_Dark_Brown_10pt"></asp:Label>
                            <br />
                            <asp:Label ID="txt_end_creation_georg_date" runat="server" class="text_Dark_Brown_10pt"></asp:Label>
                            &nbsp;
                            <asp:Label ID="Label4" runat="server" Text="<%$ Resources:Master, key_date2 %>" class="text_Dark_Brown_10pt"></asp:Label>
                        </span>
                    </div>
                </div>
            </td>
        </tr>
        <tr >
            <td align="<%$ Resources:Master, key_alignParg %>" runat="server" >
                <a href="" runat="server" id="hrefdetails" >
                    <img alt="المزيد" src="<%$ Resources:Master, imgbtn %>"  width="60" height="20" runat="server" border="0" />
                </a>
            </td>
        </tr>
    </table>
</asp:Content>
