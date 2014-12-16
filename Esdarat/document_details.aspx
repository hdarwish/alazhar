<%@ Page Language="C#" MasterPageFile="~/masterpage/InnerMaster.master" AutoEventWireup="true"
    CodeFile="document_details.aspx.cs" Inherits="Esdarat_document_details" Title="Untitled Page" %>

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
    <table id="Table1" dir="<%$ Resources:Master, dir%>" runat="server" width="100%">
        <tr>
            <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" runat="server" colspan="2">
               
                    <div class="accordion_title" id="Div1" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Labtitle" runat="server" class="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body_empty" id="Div2" runat="server">
                        <span class="text_Dark_Brown_10pt"></span>
                    </div>

                    <div class="accordion_title" id="tr_title" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label9" runat="server" Text="<%$Resources:Master, Another_title%>" class="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trothertitle" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="txt_othertitle" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr1" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label1" runat="server" Text="<%$Resources:Master, lbl_7aletelnachr%>"  class="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trpup" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label runat="server" ID="lbl_rad_publish"></asp:Label>
                            <asp:RadioButtonList runat="server" ID="rad_publish" Visible="false">
                                <asp:ListItem Text="<%$Resources:Master, lbl_doc_stat1%>" Value="0"></asp:ListItem>
                                <asp:ListItem Text="<%$Resources:Master, lbl_doc_stat2%>" Value="1" Selected="True"></asp:ListItem>
                            </asp:RadioButtonList>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr5" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label2" runat="server" Text="<%$ Resources:Master, Lbl_document_Source %>"
                                class="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trcreater" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="txt_creater" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr6" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label3" runat="server" Text="<%$ Resources:Master, Lbl_document_Source_no %>"
                                class="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trcreaterno" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="txt_creater_no" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr7" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label4" runat="server" Text="<%$ Resources:Master, Lbl_document_creation_date %>" class="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trdates" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <table>
                                <tr align="<%$Resources:Master, align%>" runat="server">
                                    <td colspan="1" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" runat="server">
                                        <asp:Label ID="txt_hdate" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                    </td>
                                    <td colspan="1" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" runat="server">
                                        <asp:Label ID="txt_date" runat="server"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </span>
                    </div>



                    <div class="accordion_title" id="tr9" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label8" runat="server" Text="<%$Resources:Master, doc_shekl%>" class="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trmaterial" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <table cellpadding="1" cellspacing="2" dir="<%$Resources:Master, dir%>" runat="server" width="100%">
                                <tr align="<%$Resources:Master, align%>" runat="server">
                                    <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" runat="server" valign="top">
                                        <asp:Label ID="lbl_drop_material" runat="server">
                                        </asp:Label>
                                        <asp:DropDownList ID="drop_material" runat="server" DataTextField="title_ar" DataValueField="id"
                                            Visible="false">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                            </table>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr10" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label10" runat="server" Text="<%$Resources:Master, doc_madmon%>" class="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trmadmon" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <table cellpadding="1" cellspacing="0" dir="rtl" width="100%">
                                <tr>
                                    <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" runat="server" valign="top">
                                        <asp:Label ID="lbl_drop_docstype" runat="server">
                                        </asp:Label>
                                        <asp:DropDownList ID="drop_docstype" runat="server" DataTextField="title_ar" DataValueField="id"
                                            Visible="False">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                            </table>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr11" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label11" runat="server" Text="<%$Resources:Master, doc_lang%>" class="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trlang" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <table cellpadding="1" cellspacing="2" dir="<%$Resources:Master, dir%>" runat="server" width="100%">
                                <tr>
                                    <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" runat="server" valign="top">
                                        <asp:Label ID="lbl_drop_lang" runat="server">
                                        </asp:Label>
                                        <asp:DropDownList ID="drop_lang" runat="server" DataValueField="id" DataTextField="title_ar"
                                            Visible="False">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                            </table>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr12" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label6" runat="server" Text="<%$Resources:Master, Doc_w_total%>" class="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="tr112" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="lbl_CheckBox1" runat="server" />
                            <asp:CheckBox ID="CheckBox1" runat="server" Visible="false" />
                        </span>
                    </div>

                     <div id="accordion">
                    <div class="accordion_title" id="tr13" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img0"  src="../img/minus.jpg" onclick="toggle('img0')" alt="">
                            <asp:Label ID="Label13" runat="server" Text="<%$Resources:Master, pagenocon%>" class="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <%--<div class="accordion_body" id="trpages" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="txt_no" runat="server" Width="21px"></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;
                            من&nbsp;
                            <asp:Label ID="txt_from" runat="server"></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label31" runat="server" Text="إلي"></asp:Label>
                            &nbsp;
                            <asp:Label ID="txt_to" runat="server"></asp:Label>
                        </span>
                    </div>
                    --%>
                    <%--    <div class="accordion_body" id="trpages" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="txt_no" runat="server" Text = '<%$ Resources:Master, timeline_hegryfrom%>'></asp:Label>
                            <asp:Label ID="txt_from" runat="server"></asp:Label>    
                            <asp:Label ID="Label31" runat="server" Text= "<%$ Resources:Master, timeline_hegryto%>"></asp:Label>
                            <asp:Label ID="txt_to" runat="server"></asp:Label>
                        </span>
                    </div>
--%>
                    <div class="accordion_body" runat="server" id="trpages">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="txt_no" runat="server" Text = '<%$ Resources:Master, timeline_hegryfrom%>'></asp:Label>
                            <asp:Label ID="txt_from" runat="server"></asp:Label>
                            <asp:Label ID="Label31" runat="server" Text="<%$ Resources:Master, timeline_hegryto%>"></asp:Label>
                            <asp:Label ID="txt_to" runat="server"></asp:Label>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr8" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img1"  src="../img/plus.jpg" onclick="toggle('img1')" alt="">
                            <asp:Label ID="Label7" runat="server" Text="<%$ Resources:Master, Lbl_document_Place_reservation %>"
                                class="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trsaveorg" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <table width="362px">
                                <tr id="Tr2" align="<%$Resources:Master, align%>" runat="server" dir="<%$Resources:Master, dir%>">
                                    <td id="Td12" align="<%$Resources:Master, align%>" runat="server" dir="<%$Resources:Master, dir%>"
                                        valign="top">
                                        <asp:Label ID="Label21" runat="server" Text="<%$Resources:Master, Lbl_document_Place_reservation_name%>"></asp:Label>
                                        &nbsp;<asp:Label ID="txt_org" runat="server"></asp:Label>
                                        <br />
                                        <asp:Label ID="Label22" runat="server" Text="<%$Resources:Master, Lbl_document_Place_reservation_country%>"></asp:Label>
                                        <asp:Label ID="txt_country" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr id="Tr3" align="<%$Resources:Master, align%>" runat="server" dir="<%$Resources:Master, dir%>">
                                    <td id="Td15" align="<%$Resources:Master, align%>" runat="server" dir="<%$Resources:Master, dir%>"
                                        valign="top">
                                        <asp:Label ID="Label23" runat="server" Text="<%$Resources:Master, Lbl_document_Place_reservation_City%>"></asp:Label>
                                        &nbsp;<asp:Label ID="txt_city" runat="server"></asp:Label>
                                        <br />
                                        <asp:Label ID="Label24" runat="server" Text="<%$Resources:Master, Lbl_document_Place_reservation_Bookshelving_no %>"></asp:Label>
                                        <asp:Label ID="txt_save_no" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr id="Tr4" align="<%$Resources:Master, align%>" runat="server" dir="<%$Resources:Master, dir%>">
                                    <td id="Td18" align="<%$Resources:Master, align%>" colspan="1" valign="top" runat="server">
                                        <asp:Label ID="Label25" runat="server" Text="<%$ Resources:Master, Lbl_document_Place_reservation_notes %>"></asp:Label>
                                        <asp:Label ID="txt_org_notes" runat="server"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </span>
                    </div>

                    <div class="accordion_title" id="tr14" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                        <img id="img2"  src="../img/plus.jpg" onclick="toggle('img2')" alt="">
                            <asp:Label ID="Label5" runat="server" Text="<%$ Resources:Master, lbl_Recording_notes %>"
                                class="text_Brown_10pt_bold"></asp:Label>
                        </a>
                    </div>
                    <div class="accordion_body" id="trnotes" runat="server">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="Label14" runat="server"></asp:Label>
                        </span>
                    </div>
                </div>
            </td>
        </tr>
    </table>
</asp:Content>
