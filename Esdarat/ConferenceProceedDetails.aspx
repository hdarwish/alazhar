<%@ Page Language="C#" MasterPageFile="~/masterpage/InnerMaster.master" AutoEventWireup="true"
    CodeFile="ConferenceProceedDetails.aspx.cs" Inherits="Esdarat_ConferenceProceedDetails"
    Title="Untitled Page" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
<script language="javascript">

    function toggle(image_name) {
        var images = new Array();
        images[0] = "img0";
        images[1] = "img1";
        images[2] = "img2";
        images[3] = "img3";
        images[4] = "img4";
        images[5] = "img5";
        images[6] = "img6";
        images[7] = "img7";
        images[8] = "img8";

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
    <table id="Table1" dir="<%$ Resources:Master, dir%>" runat="server" width="95%">
        <tr>
            <td align="<%$Resources:Master, align%>" dir="<%$ Resources:Master, dir%>" colspan="2">
               
                    <div class="accordion_title" id="Div1" runat="server">
                        <a href="" class="text_Brown_10pt_bold">
                            <asp:Label ID="Labtitle" runat="server" class="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>  
                    <div class="accordion_body_empty" id="Div2" runat="server">
                        <span class="text_Dark_Brown_10pt"></span>
                    </div>
                    <!--<div class="accordion_title" id="tr_title" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label9" runat="server" Text="<%$Resources:Master, conference_title%>"
                                class="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trtitfromtit" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="txt_fromtitle" runat="server"></asp:Label></span>
                    </div>-->

                     <div id="accordion">
                    <div class="accordion_title" id="tr_title2" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img0"  src="../img/minus.jpg" onclick="toggle('img0')" alt="">
                            <asp:Label ID="Label71" runat="server" Text=" <%$Resources:Master, Page_number_from%>" CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trtitfromintro" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="lbl_man_lang" runat="server"></asp:Label>
                            <asp:Label ID="txt_title_intro" runat="server"></asp:Label></span>
                    </div>

                    <div class="accordion_title" id="Tr5" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img1"  src="../img/plus.jpg" onclick="toggle('img1')" alt="">
                            <asp:Label ID="Label13" runat="server" Text="<%$Resources:Master ,conference_Language %>" CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trauthfromtit" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="author" runat="server"></asp:Label></span>
                    </div>

                    <div class="accordion_title" id="Tr2" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img2"  src="../img/plus.jpg" onclick="toggle('img2')" alt="">
                            <asp:Label ID="Label23" runat="server" Text="<%$Resources:Master ,conference_name %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trauthfromintro" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="txt_author_mokdma" runat="server"></asp:Label></span>
                    </div>

                    <div class="accordion_title" id="tr4" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img3"  src="../img/plus.jpg" onclick="toggle('img3')" alt="">
                            <asp:Label ID="Label3" runat="server" Text="<%$Resources:Master, conference_no%>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="tr7" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="lbl_man_lang0" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr6" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img4"  src="../img/plus.jpg" onclick="toggle('img4')" alt="">
                            <asp:Label ID="Label15" runat="server" Text="<%$Resources:Master ,conference_Date_of_session %>" CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trlang" runat="server">
                    <a href=""class="text_Dark_Brown_10pt">
                            <asp:Label ID="Labeldateh" runat="server"  ></asp:Label>
                        </a>
                    </div>

                    <div class="accordion_title" id="tr_place" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img5"  src="../img/plus.jpg" onclick="toggle('img5')" alt="">
                            <asp:Label ID="Label11" runat="server" Text="<%$Resources:Master ,conference_holdingplace %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body_empty" id="trplace" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="copy_place" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr_copier" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img6"  src="../img/plus.jpg" onclick="toggle('img6')" alt="">
                            <asp:Label ID="Label14" runat="server" Text="<%$Resources:Master ,conference_org %>"
                                CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trcopier" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="copier" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr_notes" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img7"  src="../img/plus.jpg" onclick="toggle('img7')" alt="">
                            <asp:Label ID="Label24" runat="server" Text="<%$Resources:Master ,c_notes %>" CssClass="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trnotes" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="notes" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr1" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img8"  src="../img/plus.jpg" onclick="toggle('img8')" alt="">
                            <asp:Label ID="Label1" runat="server" Text="<%$Resources:Master,conference_auther%>" class="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trgid1" runat="server" >
                        <span class="text_Dark_Brown_10pt">
                            <asp:GridView runat="server" ID="gview_moalf" Visible="false" AutoGenerateColumns="False"
                                Width="95%" CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="id">
                                <HeaderStyle BackColor="#D9C69E" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
                                <Columns>
                                    <asp:TemplateField HeaderText="<%$Resources:Master,code%>">
                                        <ItemTemplate>
                                            <asp:Label ID="lbl_index" runat="server" Text='<%#((GridViewRow)Container).RowIndex + 1%>'></asp:Label>
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Center" Width="5px" BorderColor="Black" BorderStyle="Solid"
                                            BorderWidth="1px"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" Width="5px" BorderColor="Black" BorderStyle="Solid"
                                            BorderWidth="1px"></ItemStyle>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="name" ShowHeader="true" HeaderText="<%$Resources:Master,conference_auther_name%>" ItemStyle-HorizontalAlign="Center"
                                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1px"
                                        HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px"
                                        HeaderStyle-HorizontalAlign="Center">
                                        <HeaderStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid">
                                        </HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid">
                                        </ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="name_ar" ShowHeader="true" HeaderText="<%$Resources:Master,txt_moalf%>"
                                        ItemStyle-HorizontalAlign="Center" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid"
                                        ItemStyle-BorderWidth="1px" HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid"
                                        HeaderStyle-BorderWidth="1px" HeaderStyle-HorizontalAlign="Center">
                                        <HeaderStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid">
                                        </HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid">
                                        </ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="name_ar" ShowHeader="true" HeaderText="<%$Resources:Master,txt_moalf%>"
                                        ItemStyle-HorizontalAlign="Center" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid"
                                        ItemStyle-BorderWidth="1px" HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid"
                                        HeaderStyle-BorderWidth="1px" HeaderStyle-HorizontalAlign="Center">
                                        <HeaderStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid">
                                        </HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid">
                                        </ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="author_role" ShowHeader="true" HeaderText="<%$Resources:Master,conference_auther_role%>"
                                        ItemStyle-HorizontalAlign="Center" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid"
                                        ItemStyle-BorderWidth="1px" HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid"
                                        HeaderStyle-BorderWidth="1px" HeaderStyle-HorizontalAlign="Center">
                                        <HeaderStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid">
                                        </HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid">
                                        </ItemStyle>
                                    </asp:BoundField>
                                </Columns>
                            </asp:GridView>
                        </span>
                    </div>
                </div>
            </td>
        </tr>
    </table>
</asp:Content>
