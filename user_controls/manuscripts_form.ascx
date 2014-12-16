<%@ Control Language="C#" AutoEventWireup="true" CodeFile="manuscripts_form.ascx.cs"
    Inherits="masterpage_manuscripts_form" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<%@ Register Src="add_reference.ascx" TagName="add_reference" TagPrefix="uc1" %>
<style type="text/css">
    .style1
    {
        width: 10%;
    }
    .style2
    {
        width: 11%;
    }
    .style3
    {
        width: 12%;
    }
    .style4
    {
        width: 13%;
    }
    .style5
    {
        width: 14%;
    }
    .style6
    {
        width: 15%;
    }
    .style7
    {
        width: 16%;
    }
    .style8
    {
        width: 17%;
    }
    .style9
    {
        width: 18%;
    }
    .style10
    {
        width: 150px;
    }
</style>
<table style="width: 700px" border="0" cellspacing="5" runat="server" dir="<%$Resources:Master, dir%>"
    id="tblmanus">
    <tr align="<%$Resources:Master, align%>" runat="server" dir="<%$Resources:Master, dir%>">
        <td colspan="3" align="center" height="60px">
            <asp:HiddenField ID="content_id" runat="server" />
            <asp:HiddenField ID="content_type" runat="server" />
            <asp:Label ID="Label25" runat="server" Text=" إستمارة المخطوطات" ForeColor="Black"
                Font-Bold="True" Font-Size="16px"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp; <a href runat="server"
                    id="form_file" visible="false" target="_blank">عرض الاستمارة </a>
        </td>
    </tr>
    <tr align="<%$Resources:Master, align%>" runat="server" dir="<%$Resources:Master, dir%>">
        <td colspan="3" align="center" height="40px">
            <asp:Label ID="lblpage" runat="server" Text="تم حفظ بيانات الإستمارة بنجاح " ForeColor="Green"
                Visible="False" Font-Size="16px"></asp:Label>
        </td>
    </tr>
    <tr runat="server" id="tr2">
        <td width="150px" valign="top" nowrap align="right">
            <asp:Label ID="Label24" runat="server" Text="عنصر مميز : " ForeColor="#996633"></asp:Label>
        </td>
        <td>
            <asp:CheckBox ID="highlight" runat="server" Text="علي الموقع" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="highlight_panorama" runat="server" Text="علي بانوراما التراث" />
        </td>
        <td valign="top">
            &nbsp;
        </td>
    </tr>
    <tr runat="server" id="tr_id_1">
        <td width="150px" valign="top" nowrap dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
            <asp:Label ID="lbl2" runat="server" Text="العنوان : " ForeColor="#996633"></asp:Label>
        </td>
        <td dir="<%$Resources:Master, dir%>" valign="top" colspan="2">
            <table width="100%" id="tbltitle" runat="server">  
                <tr>
                    <td class="style10">
                        <asp:Label ID="Label1" runat="server" Text="<%$Resources:Master, lbl_manuscript_Title%>"></asp:Label>
                    </td>
                    <td colspan="1">
                        <asp:Label ID="title" runat="server" Font-Bold="True" Font-Size="14px"></asp:Label>
                    </td>
                </tr>
                <tr runat="server" id="tr_title">
                    <td class="style10">
                        <asp:Label ID="Label7" runat="server" Text="العنوان من صفحة العنوان : "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txt_fromtitle" runat="server" Width="100%"></asp:TextBox>
                    </td>
                </tr>
                 <tr runat="server" id="tr1">
                    <td class="style10">
                        <asp:Label ID="Label3" runat="server" Text="عنوان موثق : "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txt_title_documented" runat="server" Width="100%"></asp:TextBox>
                    </td>
                </tr>
                <tr runat="server" id="tr_title2">
                    <td class="style10">
                        <asp:Label ID="Label71" runat="server" Text="العنوان من المقدمة : "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txt_title_intro" runat="server" Width="100%"></asp:TextBox>
                    </td>
                </tr>
                </table>
        </td>
    </tr>
    
    <tr runat="server" id="tr3">
        <td width="150px" valign="top" nowrap dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
            <asp:Label ID="Label4" runat="server" Text="<%$Resources:Master, lbl_manuscript_Authorn%>"
                ForeColor="#996633"></asp:Label>
        </td>
        <td id="Td1" dir="<%$Resources:Master, dir%>" runat="server" valign="top" colspan="2">
            <table width="100%" id="tblauthor" runat="server">
                <tr id="Tr24" runat="server" dir="<%$Resources:Master, dir%>">
                    <td class="style10">
                        <asp:Label ID="Label10" runat="server" 
                            Text="المؤلف : "></asp:Label>
                    </td>
                    <td >
                        <asp:TextBox ID="txt_author" runat="server" Width="100%"></asp:TextBox>
                    </td>
                </tr>
                <tr id="Tr112" runat="server" dir="<%$Resources:Master, dir%>">
                    <td class="style10">
                        <asp:Label ID="Label6" runat="server" 
                            Text="المؤلف من صفحة العنوان : "></asp:Label>
                    </td>
                    <td >
                        <asp:TextBox ID="txt_author_fromtitle" runat="server" Width="100%"></asp:TextBox>
                    </td>
                </tr>
                 <tr id="Tr22" runat="server" dir="<%$Resources:Master, dir%>">
                    <td class="style10">
                        <asp:Label ID="Label23" runat="server" Text="المؤلف من المقدمة : "></asp:Label>
                    </td>
                    <td >
                        <asp:TextBox ID="txt_author_mokdma" runat="server" Width="100%"></asp:TextBox>
                    </td>
                </tr>
                <tr id="Tr23" runat="server" dir="<%$Resources:Master, dir%>">
                    <td class="style10">
                        <asp:Label ID="Label39" runat="server" 
                            Text="مؤلف موثق : "></asp:Label>
                    </td>
                    <td >
                        <asp:TextBox ID="txt_author_moska" runat="server" Width="100%"></asp:TextBox>
                    </td>
                </tr>
               <%-- <tr id="tr_moalf" runat="server">
                    <td class="style10" nowrap="nowrap">
                        <asp:Label ID="Label8" runat="server" Text="نوع/مصدر المؤلف : "></asp:Label>
                    </td>
                    <td >
                        <asp:RadioButtonList ID="author_src" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="1">العنوان من صفحة العنوان</asp:ListItem>
                            <asp:ListItem Value="2">العنوان من المقدمة</asp:ListItem>
                            <asp:ListItem Value="3">عنوان موثق</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>--%>
            </table>
        </td>
       
    </tr>
    <tr runat="server" id="tr4">
        <td width="150px" valign="top" nowrap align="right" class="style7">
            <asp:Label ID="Label9" runat="server" Text="لغة المخطوطة : " ForeColor="#996633"></asp:Label>
        </td>
        <td align="right" dir="rtl" valign="top" class="style7">
            <asp:RadioButtonList ID="man_lang" runat="server" RepeatDirection="Horizontal" DataTextField="title_ar"
                DataValueField="id">
            </asp:RadioButtonList>
            &nbsp;&nbsp;&nbsp;
        </td>
        <td width="150px" align="right" valign="top" nowrap class="style7">
            &nbsp;
        </td>
    </tr>
    <tr runat="server" id="tr5" dir="<%$Resources:Master, dir%>">
        <td width="150px" valign="top" nowrap runat="server" dir="<%$Resources:Master, dir%>"
            align="<%$Resources:Master, align%>">
            <asp:Label ID="Label11" runat="server" Text="<%$Resources:Master, lbl_manuscript_Transcribing %> "
                ForeColor="#996633"></asp:Label>
        </td>
        <td runat="server" dir="<%$Resources:Master, dir%>" valign="top">
            <table width="100%" runat="server" dir="<%$Resources:Master, dir%>" id="tblcopy"> 
                <tr id="tr_place" runat="server" dir="<%$Resources:Master, dir%>">
                    <td style="width: 10%" nowrap="nowrap" dir="<%$Resources:Master, dir%>" runat="server">
                        <asp:Label ID="Label12" runat="server" Text="<%$Resources:Master, lbl_manuscript_Transcribing_place %>"></asp:Label>
                    </td>
                    <td style="width: 90%" runat="server" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
                        <asp:TextBox ID="copy_place" runat="server" Width="450px"></asp:TextBox>
                    </td>
                </tr>
                <tr id="tr_copier" runat="server" align="<%$Resources:Master, align%>">
                    <td style="width: 10%">
                        <asp:Label ID="Label14" runat="server" Text="<%$Resources:Master, lbl_manuscript_Transcriber %>"></asp:Label>
                    </td>
                    <td style="width: 90%">
                        <asp:TextBox ID="copier" runat="server" Width="450px"></asp:TextBox>
                    </td>
                </tr>
                <tr runat="server" id="tr_date" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, align%>">
                    <td style="width: 10%" nowrap="nowrap">
                        <asp:Label ID="Label13" runat="server" Text="<%$Resources:Master, lbl_manuscript_Transcribing_date %>"></asp:Label>
                    </td>
                    <td style="width: 90%" align="<%$Resources:Master, align%>" runat="server" dir="<%$Resources:Master, align%>">
                        <asp:TextBox ID="copy_date" runat="server" Width="120px"></asp:TextBox>
                        &nbsp;&nbsp;
                        <asp:RadioButtonList ID="copy_date_type" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="h" Text="<%$Resources:Master, timeline_h %>"></asp:ListItem>
                            <asp:ListItem Value="m" Text="<%$Resources:Master, timeline_m %>"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
            </table>
        </td>
        <td width="150px" align="right" valign="top" nowrap>
            &nbsp;
        </td>
    </tr>
    <tr runat="server" id="tr6">
        <td width="150px" valign="top" nowrap align="right" class="style8">
            <asp:Label ID="Label5" runat="server" Text="حالة النسخ : " ForeColor="#996633"></asp:Label>
        </td>
        <td align="right" dir="rtl" valign="top" class="style8">
            <asp:RadioButtonList ID="copy_state" runat="server" RepeatDirection="Horizontal"
                RepeatColumns="3" DataTextField="title_ar" DataValueField="id">
            </asp:RadioButtonList>
            &nbsp;&nbsp;&nbsp;
        </td>
        <td width="150px" align="right" valign="top" nowrap class="style8">
            &nbsp;
        </td>
    </tr>
    <tr runat="server" id="tr7">
        <td width="150px" valign="top" nowrap align="right">
            <asp:Label ID="Label26" runat="server" Text="المخطوط ضمن مجموع ؟" ForeColor="#996633"></asp:Label>
        </td>
        <td align="right" dir="rtl" valign="top">
            <asp:Label ID="Label27" runat="server" Text="رقمه في المجموع"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="collection_no" runat="server"></asp:TextBox>
        </td>
        <td width="150px" align="right" valign="top" nowrap>
            &nbsp;
        </td>
    </tr>
    <tr runat="server" id="tr8">
        <td width="150px" valign="top" nowrap align="right">
            <asp:Label ID="Label28" runat="server" Text="الأوراق" ForeColor="#996633"></asp:Label>
        </td>
        <td align="right" dir="rtl" valign="top">
            <table width="100%">
                <tr>
                    <td nowrap="nowrap" class="style5">
                        <asp:Label ID="Label29" runat="server" Text="من :"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="papers_from" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                            ControlToValidate="papers_from" Font-Size="14px" ValidationGroup="page"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td nowrap="nowrap" class="style5">
                        <asp:Label ID="Label30" runat="server" Text="إلى :"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="papers_to" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                            ControlToValidate="papers_to" Font-Size="14px" ValidationGroup="page"></asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
        </td>
        <td width="150px" align="right" valign="top" nowrap>
            &nbsp;
        </td>
    </tr>
    <tr runat="server" id="tr9">
        <td dir="rtl" width="150px" rowspan="1" valign="top" align="right">
            <asp:Label ID="Label31" runat="server" Text="عدد الأجزاء : " ForeColor="#996633"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="parts_no" runat="server"></asp:TextBox>
        </td>
        <td valign="top">
            &nbsp;
        </td>
    </tr>
    <tr runat="server" id="tr10">
        <td dir="rtl" width="150px" rowspan="1" valign="top" align="right">
            <asp:Label ID="Label32" runat="server" Text="عدد المجلدات : " ForeColor="#996633"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="folders_no" runat="server"></asp:TextBox>
        </td>
        <td valign="top">
            &nbsp;
        </td>
    </tr>
    <tr runat="server" id="tr11">
        <td width="150px" valign="top" nowrap align="right">
            <asp:Label ID="Label33" runat="server" Text="مقاس المخطوط" ForeColor="#996633"></asp:Label>
        </td>
        <td align="right" dir="rtl" valign="top">
            <table width="100%">
                <tr>
                    <td nowrap="nowrap" class="style4">
                        <asp:Label ID="Label34" runat="server" Text="الطول :"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="length" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                            ControlToValidate="length" Font-Size="14px" ValidationGroup="page"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td nowrap="nowrap" class="style4">
                        <asp:Label ID="Label35" runat="server" Text="العرض :"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="width" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                            ControlToValidate="width" Font-Size="14px" ValidationGroup="page"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td nowrap="nowrap" class="style4">
                        <asp:Label ID="Label36" runat="server" Text="الُسْمك :"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="height" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                            ControlToValidate="height" Font-Size="14px" ValidationGroup="page"></asp:RequiredFieldValidator>--%>
                    </td>
                </tr>
            </table>
        </td>
        <td width="150px" align="right" valign="top" nowrap>
            &nbsp;
        </td>
    </tr>
    <tr runat="server" id="tr12">
        <td dir="rtl" width="150px" rowspan="1" valign="top" align="right">
            <asp:Label ID="Label37" runat="server" Text="المسطرة : " ForeColor="#996633"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="ruler" runat="server"></asp:TextBox>
        </td>
        <td valign="top">
            &nbsp;
        </td>
    </tr>
    <tr runat="server" id="tr13">
        <td width="150px" valign="top" nowrap align="right" class="style9">
            <asp:Label ID="Label38" runat="server" Text="النسخة تحتوي على : " ForeColor="#996633"></asp:Label>
        </td>
        <td align="right" dir="rtl" valign="top" class="style9">
            <asp:CheckBoxList ID="copy_contains" runat="server" RepeatDirection="Horizontal"
                RepeatColumns="5" DataTextField="title_ar" DataValueField="id">
            </asp:CheckBoxList>
            &nbsp;&nbsp;&nbsp;
        </td>
        <td width="150px" align="right" valign="top" nowrap class="style9">
            &nbsp;
        </td>
    </tr>
    <tr runat="server" id="tr14">
        <td width="150px" valign="top" nowrap align="right">
            <asp:Label ID="Label40" runat="server" Text="نوع الخط : " ForeColor="#996633"></asp:Label>
        </td>
        <td align="right" dir="rtl" valign="top">
            <asp:RadioButtonList ID="font_type" runat="server" RepeatDirection="Horizontal" RepeatColumns="5">
                <asp:ListItem Value="1">معتاد</asp:ListItem>
                <asp:ListItem Value="2">رقعة</asp:ListItem>
                <asp:ListItem Value="3">نسخ</asp:ListItem>
                <asp:ListItem Value="4">تعليق</asp:ListItem>
                <asp:ListItem Value="5">مغربي</asp:ListItem>
                <asp:ListItem Value="6">ديواني</asp:ListItem>
                <asp:ListItem Value="7">كوفي</asp:ListItem>
                <asp:ListItem Value="8">ثلث</asp:ListItem>
                <asp:ListItem Value="9">فارسي</asp:ListItem>
            </asp:RadioButtonList>
            &nbsp;&nbsp;&nbsp;
        </td>
        <td width="150px" align="right" valign="top" nowrap>
            &nbsp;
        </td>
    </tr>
    <tr runat="server" id="tr15">
        <td width="150px" valign="top" nowrap align="right">
            <asp:Label ID="Label42" runat="server" Text="النسخة بها : " ForeColor="#996633"></asp:Label>
        </td>
        <td align="right" dir="rtl" valign="top">
            <asp:CheckBoxList ID="copy_has" runat="server" RepeatDirection="Horizontal" DataTextField="title_ar"
                DataValueField="id">
            </asp:CheckBoxList>
            &nbsp;&nbsp;&nbsp;
        </td>
        <td width="150px" align="right" valign="top" nowrap>
            &nbsp;
        </td>
    </tr>
    <tr runat="server" id="tr16" dir="<%$Resources:Master, dir %>" align="<%$Resources:Master, align%>">
        <td runat="server" dir="<%$Resources:Master, dir %>" width="150px" rowspan="1" valign="top"
            align="<%$Resources:Master, align%>">
            <asp:Label ID="Label15" runat="server" Text="<%$Resources:Master, lbl_manuscript_Preface %> "
                ForeColor="#996633"></asp:Label>
        </td>
        <td runat="server" dir="<%$Resources:Master, dir %>">
            <asp:TextBox ID="introduction" runat="server" Width="450px" TextMode="MultiLine"
                Height="60px"></asp:TextBox>
        </td>
        <td valign="top" runat="server" dir="<%$Resources:Master, dir %>">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="introduction" Font-Size="14px" ValidationGroup="page"></asp:RequiredFieldValidator><br />
        </td>
    </tr>
    <tr runat="server" id="tr17" align="<%$Resources:Master, align%>">
        <td dir="<%$Resources:Master, dir%>" width="150px" rowspan="1" valign="top" align="<%$Resources:Master, align%>">
            <asp:Label ID="Label44" runat="server" Text="<%$Resources:Master, lbl_manuscript_Conclusion %>"
                ForeColor="#996633"></asp:Label>
        </td>
        <td runat="server" dir="<%$Resources:Master, dir %>">
            <asp:TextBox ID="conclusion" runat="server" Width="450px" TextMode="MultiLine" Height="60px"></asp:TextBox>
        </td>
        <td valign="top" runat="server" dir="<%$Resources:Master, dir %>">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="conclusion" Font-Size="14px" ValidationGroup="page"></asp:RequiredFieldValidator><br />
        </td>
    </tr>
    <tr runat="server" id="tr18" align="<%$Resources:Master, align%>">
        <td width="150px" valign="top" align="<%$Resources:Master, align%>" runat="server">
            <asp:Label ID="Label45" runat="server" Text="<%$Resources:Master, lbl_manuscript_Place_preservation %>"
                ForeColor="#996633"></asp:Label>
        </td>
        <td valign="top" colspan="2" runat="server" dir="<%$Resources:Master, dir %>">
            <table width="100%" id="tblsaveplace" runat="server">
                <tr id="Tr31" align="<%$Resources:Master, align%>" runat="server">
                    <td class="style3" nowrap="nowrap">
                        <asp:Label ID="Label8" runat="server" Text="اسم جهة المصدر : "></asp:Label>
                    </td>
                    <td id="Td2" align="<%$Resources:Master, align%>" runat="server" colspan="3">
                        <asp:TextBox ID="txt_source_place" runat="server" Width="300px" ></asp:TextBox>
                    </td>
                    <td id="Td3" align="<%$Resources:Master, align%>" runat="server">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                            ControlToValidate="txt_source_place" Font-Size="14px" ValidationGroup="page"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr align="<%$Resources:Master, align%>" runat="server">
                    <td class="style3" nowrap="nowrap">
                        <asp:Label ID="Label46" runat="server" Text="<%$Resources:Master, lbl_manuscript_Place_preservation_country %>"></asp:Label>
                    </td>
                    <td align="<%$Resources:Master, align%>" runat="server" colspan="3">
                        <asp:TextBox ID="country" runat="server" Width="300px" ></asp:TextBox>
                    </td>
                    <td align="<%$Resources:Master, align%>" runat="server">
                      <%--  <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                            ControlToValidate="country" Font-Size="14px" ValidationGroup="page"></asp:RequiredFieldValidator>--%>
                    </td>
                </tr>
                <tr align="<%$Resources:Master, align%>" runat="server">
                    <td class="style3" nowrap="nowrap">
                        <asp:Label ID="Label47" runat="server" Text="<%$Resources:Master, lbl_manuscript_Place_preservation_City %>"></asp:Label>
                    </td>
                    <td align="<%$Resources:Master, align%>" runat="server" colspan="3">
                        <asp:TextBox ID="town" runat="server" Width="300px" ></asp:TextBox>
                    </td>
                    <td align="<%$Resources:Master, align%>" runat="server">
                        <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                            ControlToValidate="town" Font-Size="14px" ValidationGroup="page"></asp:RequiredFieldValidator>--%>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr runat="server" id="tr19">
        <td width="150px" valign="top" nowrap align="right">
            <asp:Label ID="Label48" runat="server" Text="رقم الحفظ داخل جهة الحفظ" ForeColor="#996633"></asp:Label>
        </td>
        <td align="right" dir="rtl" valign="top">
            <table width="100%">
                <tr>
                    <td class="style2" nowrap="nowrap">
                        <asp:Label ID="Label49" runat="server" Text="رقم عام :"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="general_no" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                            ControlToValidate="general_no" Font-Size="14px" ValidationGroup="page"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style2" nowrap="nowrap">
                        <asp:Label ID="Label50" runat="server" Text="رقم خاص :"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="special_no" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                            ControlToValidate="special_no" Font-Size="14px" ValidationGroup="page"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style2" nowrap="nowrap">
                        <asp:Label ID="Label51" runat="server" Text="الفن :"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="the_art" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator22" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                            ControlToValidate="the_art" Font-Size="14px" ValidationGroup="page"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style2" nowrap="nowrap">
                        <asp:Label ID="Label52" runat="server" Text="المكتبة الخاصة :"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="special_lib" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator23" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                            ControlToValidate="special_lib" Font-Size="14px" ValidationGroup="page"></asp:RequiredFieldValidator>--%>
                    </td>
                </tr>
            </table>
        </td>
        <td width="150px" align="right" valign="top" nowrap>
            &nbsp;
        </td>
    </tr>
    <tr runat="server" id="tr20" align="<%$Resources:Master, align%>">
        <td align="<%$Resources:Master, align%>" runat="server" width="150px" rowspan="1"
            valign="top">
            <asp:Label ID="Label53" runat="server" Text="<%$Resources:Master, lbl_manuscript_notes %>"
                ForeColor="#996633"></asp:Label>
        </td>
        <td align="<%$Resources:Master, align%>" runat="server">
            <asp:TextBox ID="notes" runat="server" Width="335px" TextMode="MultiLine" Height="60px"></asp:TextBox>
        </td>
        <td align="<%$Resources:Master, align%>" runat="server" valign="top">
            <br />
        </td>
    </tr>
    <tr runat="server" id="tr21">
        <td colspan="3">
            <fieldset>
                <legend>
                    <asp:Label ID="Label70" runat="server" Text="الإجازات والسماعات" Font-Bold="true"></asp:Label>
                </legend>
                <table width="100%">
                    <tr>
                        <td width="250px" valign="top" nowrap="nowrap" align="right">
                            <asp:Label ID="Label54" runat="server" Text="نوع الإجازة : " ForeColor="#996633"></asp:Label>
                        </td>
                        <td align="right" dir="rtl" valign="top" colspan="2">
                            <asp:RadioButtonList ID="license_type" runat="server" RepeatDirection="Horizontal"
                                DataTextField="title_ar" DataValueField="id">
                            </asp:RadioButtonList>
                            <asp:Label ID="Label55" runat="server" Text="أخرى"></asp:Label>
                            &nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="other_license_type" runat="server"></asp:TextBox>
                        </td>
                        <td width="150px" align="right" valign="top" nowrap>
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td width="100px" valign="top" nowrap align="right">
                            <asp:Label ID="Label56" runat="server" Text="تاربخ أقدم  الإجازات  الموجودة : " ForeColor="#996633"></asp:Label>
                        </td>
                        <td align="right" dir="rtl" valign="top" colspan="2">
                            <asp:TextBox ID="oldest_license_date_m" runat="server"></asp:TextBox>
                            &nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label57" runat="server" Text="م"></asp:Label><br />
                            <asp:TextBox ID="oldest_license_date_h" runat="server"></asp:TextBox>
                            &nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label58" runat="server" Text="هـ"></asp:Label>
                        </td>
                        <td width="150px" align="right" valign="top" nowrap>
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td width="20px" valign="top" nowrap align="right">
                            <asp:Label ID="Label59" runat="server" Text="السماعات : " ForeColor="#996633"></asp:Label>
                        </td>
                        <td align="right" dir="rtl" valign="top" colspan="2">
                            <asp:RadioButtonList ID="listinging" runat="server" RepeatDirection="Horizontal">
                                <asp:ListItem Value="1">نعم</asp:ListItem>
                                <asp:ListItem Value="2">لا</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td width="150px" align="right" valign="top" nowrap>
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td width="20px" valign="top" nowrap align="right">
                            <asp:Label ID="Label62" runat="server" Text="تاريخ أقدم السماعات : " ForeColor="#996633"></asp:Label>
                        </td>
                        <td align="right" dir="rtl" valign="top" class="style6">
                            <asp:TextBox ID="listinging_date_m" runat="server"></asp:TextBox>
                            &nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label63" runat="server" Text="م"></asp:Label><br />
                            <asp:TextBox ID="listinging_date_h" runat="server"></asp:TextBox>
                            &nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label64" runat="server" Text="هـ"></asp:Label>
                        </td>
                        <td align="right" dir="rtl" valign="middle">
                            &nbsp;
                        </td>
                        <td width="150px" align="right" valign="top" nowrap>
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td valign="top" nowrap colspan="4" align="right">
                            &nbsp;
                        </td>
                    </tr>
                </table>
            </fieldset>
        </td>
    </tr>
    <%-- <tr runat="server" id="tr24">
        <td colspan="3">
            <fieldset>
                <legend>
                    <asp:Label ID="Label65" runat="server" Text="المراجع" Font-Bold="true"></asp:Label>
                </legend>
                <table width="100%">
                    <tr>
                        <td colspan="2">
                            <uc1:add_reference ID="add_reference1" runat="server" />
                            &nbsp;&nbsp;
                        </td>
                    </tr>
                </table>
            </fieldset>
       </td>
    </tr>--%>
    <tr runat="server" id="tr25">
        <td width="150px" rowspan="1" valign="top" align="<%$Resources:Master, align%>">
            <asp:Label ID="Label16" runat="server" Text="<%$Resources:Master, lbl_Recording_keyword %>"
                ForeColor="#996633"></asp:Label>
        </td>
        <td align="<%$Resources:Master, align%>" runat="server">
            <asp:TextBox ID="keywords" runat="server" Width="384px" TextMode="MultiLine" Height="55px"></asp:TextBox>
        </td>
        <td align="right" dir="rtl" valign="top">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="keywords" Font-Size="14px" ValidationGroup="page"></asp:RequiredFieldValidator><br />
            <asp:Label ID="lblDeclaration" runat="server" Text="* يرجى إدخال الكلمات الدالة مفصولة برمز (#) فيما بينها كما بالمثال التالى كلمة دالة 1 # كلمة دالة 2"
                Font-Size="12px" ForeColor="Red" Width="100px"></asp:Label>
        </td>
    </tr>
    <tr runat="server" id="tr26">
        <td dir="rtl" width="150px" rowspan="1" valign="top" align="right">
            <asp:Label ID="Label17" runat="server" Text="العصر الذي ينتمي إليه المخطوط  : " ForeColor="#996633"></asp:Label>
        </td>
        <td>
            <asp:CheckBoxList ID="chk_periods" runat="server" RepeatColumns="4" RepeatDirection="Horizontal"
                Width="100%" DataTextField="title" DataValueField="id">
                
            </asp:CheckBoxList>
            <br />
        </td>
        <td valign="top">
            &nbsp;
        </td>
    </tr>
   <%-- <tr runat="server" id="tr27" align="<%$Resources:Master, align%>">
        <td dir="<%$Resources:Master, dir%>" width="150px" rowspan="1" valign="top" align="<%$Resources:Master, align%>">
            <asp:Label ID="Label18" runat="server" Text="<%$Resources:Master, c_notes%>" Height="50px"
                ForeColor="#996633"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="period_notes" runat="server" Height="55px" Width="390px" TextMode="MultiLine" />
        </td>
        <td>
            &nbsp;
        </td>
    </tr>--%>
    <tr runat="server" id="tr28">
        <td dir="rtl" width="150px" rowspan="1" valign="top" align="right">
            <asp:Label ID="Label19" runat="server" Text="الصورة المرفقة مع الاستمارة  : " ForeColor="#996633"></asp:Label>
        </td>
        <td>
            <asp:RadioButtonList ID="rblFormImage" runat="server" RepeatColumns="1" Width="100%">
                <asp:ListItem Text="مرفقة (ورقية / إلكترونية)" Value="1" Selected="True"></asp:ListItem>
                <asp:ListItem Text="غير متاحة (سيتم توفيرها لاحقا)" Value="2"></asp:ListItem>
                <asp:ListItem Text="غير متاحة (استخدم الصورة الرمزية)" Value="3"></asp:ListItem>
            </asp:RadioButtonList>
        </td>
        <td>
            &nbsp;
        </td>
    </tr>
    <tr runat="server" id="tr29">
        <td dir="rtl" rowspan="1" valign="top" align="right" width="150px">
            <asp:Label ID="Label20" runat="server" Text="اسم جامع بيانات الاستمارة  : " Width="150px"
                ForeColor="#996633"></asp:Label>
        </td>
        <td dir="rtl" class="style1" rowspan="1" valign="top">
            <asp:TextBox ID="data_collector_name" runat="server" Width="270px" />
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="data_collector_name" Font-Size="14px" ValidationGroup="page"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr runat="server" id="tr30">
        <td dir="rtl" rowspan="1" valign="top" align="right">
            <asp:Label ID="Label21" runat="server" Text="اسم مراجع بيانات الاستمارة  : " Width="155px"
                ForeColor="#996633"></asp:Label>
        </td>
        <td dir="rtl" class="style1" rowspan="1" valign="top">
            <asp:TextBox ID="data_revision_name" runat="server" Width="270px" />
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="data_revision_name" Font-Size="14px" ValidationGroup="page"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <%--<tr runat="server" id="tr31">
        <td dir="rtl" rowspan="1" valign="top" align="right">
            <asp:Label ID="Label22" runat="server" 
                Text="اسم مدخل بيانات الاستمارة على الحاسب الآلي  : " ForeColor="#996633"></asp:Label>
        </td>
        <td dir="rtl" class="style1" rowspan="1" valign="top">
            <asp:TextBox ID="data_entry_name" runat="server" Width="270px" />
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="data_entry_name" Font-Size="14px" 
                ValidationGroup="page"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr runat="server" id="tr32">
        <td dir="rtl" rowspan="1" valign="top" align="right">
            <asp:Label ID="Label23" runat="server" 
                Text="اسم مراجع إدخال بيانات الاستمارة على الحاسب الآلي  : " 
                ForeColor="#996633"></asp:Label>
        </td>
        <td dir="rtl" class="style1" rowspan="1" valign="top">
            <asp:TextBox ID="data_entry_revision_name" runat="server" Width="270px" />
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="data_entry_revision_name" Font-Size="14px" 
                ValidationGroup="page"></asp:RequiredFieldValidator>
        </td>
    </tr>--%>
    <tr runat="server" id="file_tr" dir="<%$Resources:Master, dir%>">
        <td rowspan="1" valign="top" runat="server" align="<%$Resources:Master, align%>"
            dir="<%$Resources:Master, dir%>">
            <asp:Label ID="Label2" runat="server" Text="<%$Resources:Master, Topics_upload%>"
                ForeColor="#996633"></asp:Label>
        </td>
        <td dir="ltr" rowspan="1" valign="top" align="left">
            <%--<asp:Label ID="Label555" runat="server" Font-Size="14px" ForeColor="Red" 
                Width="40%"></asp:Label>--%>
            <asp:FileUpload ID="fucontentFile" runat="server" Width="100%" />
            &nbsp;
        </td>
        <td>
            <asp:Label ID="labfile" runat="server" Text="Label" Visible="False" Font-Size="14px"
                ForeColor="Red"></asp:Label>
        </td>
    </tr>
    <tr runat="server" dir="<%$Resources:Master, dir%>">
        <td align="center" colspan="2" height="60px" valign="middle">
            <asp:Button ID="btnsave" runat="server" Text="حفظ تفاصيل الاستمارة" OnClick="btnsave_Click"
                Style="height: 26px" ValidationGroup="page" />
        </td>
    </tr>
</table>
