<%@ Control Language="C#" AutoEventWireup="true" CodeFile="conference_proceed.ascx.cs"
    Inherits="masterpage_conference_proceed" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<script type="text/javascript">
  function ShowPopup() {
      alert(" لم يتم حفظ تفاصيل الاستمارة هناك حقول لم يتم ادخالها ");
  }

  function ValidateAndShowPopup() {
      if (Page_ClientValidate('A') == false) {
        ShowPopup();
    }
  }
</script>

<style type="text/css">
    .style1
    {
        width: 219px;
    }
    .style2
    {
        width: 213px;
    }
    </style>
<asp:HiddenField ID="content_type" runat="server" />
<asp:HiddenField ID="content_id" runat="server" />
<asp:HiddenField ID="HiddenField1" runat="server" Value="0" />

<table style="width: 100%" cellspacing="4" id="tbmoatmr" runat="server" dir="<%$Resources:Master, dir%>" >
    <tr align="right">
        <td colspan="4" align="center">
        </td>
    </tr>
    <tr id="trpagetitle" runat="server" dir="<%$Resources:Master, dir%>">
        <td colspan="3" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
            <asp:Label ID="lblpagetitle" runat="server" Text="بيانات بحث المؤتمر" Font-Bold="True"></asp:Label>
        </td>
        <td align="left" visible="true" dir="rtl">
            <a href runat="server" id="id_href" target="_blank">عرض الاستمارة </a>
        </td>
    </tr>
    <tr align="right">
        <td colspan="4" align="center" dir="rtl">
            <asp:Label ID="lblerror" runat="server"></asp:Label>
        </td>
    </tr>
    <tr align="<%$Resources:Master, align%>" runat="server" dir="<%$Resources:Master, dir%>"
        id="trtitle">
        <td align="<%$Resources:Master, align%>" runat="server" dir="<%$Resources:Master, dir%>">
            <asp:Label ID="Label2" runat="server" Text="<%$Resources:Master, conference_title%>"></asp:Label>
        </td>
        <td colspan="3" align="<%$Resources:Master, align%>" runat="server" dir="<%$Resources:Master, dir%>">
            <asp:Label ID="txt_art_title" runat="server" ReadOnly="True" Font-Bold="True" Font-Size="14px"></asp:Label>
        </td>
        <td>
            &nbsp;
        </td>
    </tr>
    <tr id="trspecial" runat="server" align="<%$Resources:Master, dir%>">
        <td>
            <asp:Label ID="Label1" runat="server" Text="<%$Resources:Master, Labspecial%>"></asp:Label>
        </td>
        <td colspan="3" align="<%$Resources:Master, align%>">
            <asp:CheckBox ID="chk_pan" runat="server" Text="علي البانوراما" />
            <asp:CheckBox ID="chk_site" runat="server" Text="علي الموقع" />
        </td>
    </tr>
    
   
    <tr align="right" runat="server" id="trpageno">
        <td align="right" dir="rtl">
            <asp:Label ID="Label5" runat="server" Text=" أرقام الصفحات التي تشغلها من:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txt_from" runat="server" Width="23px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator22" runat="server" ControlToValidate="txt_from"
                ErrorMessage="هذا الحقل يجب إدخاله" ValidationGroup="A"></asp:RequiredFieldValidator>
            <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" runat="server" FilterType="Custom"
                TargetControlID="txt_from" ValidChars="0123456789/\">
            </cc1:FilteredTextBoxExtender>
        </td>
        <td>
            <asp:Label ID="Label7" runat="server" Text="إلي:"></asp:Label>
            <asp:TextBox ID="txt_to" runat="server" Width="21px"></asp:TextBox>
            <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender3" runat="server" FilterType="Custom"
                TargetControlID="txt_to" ValidChars="0123456789/\">
            </cc1:FilteredTextBoxExtender>
        </td>
        <td align="right" colspan="2" dir="rtl">
            &nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator23" runat="server" ControlToValidate="txt_to"
                ErrorMessage="هذا الحقل يجب إدخاله" ValidationGroup="A"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr align="right" runat="server" id="trlang">
        <td>
            <asp:Label ID="Label6" runat="server" Text="لغة البحث:"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="drop_lang" runat="server" AutoPostBack="true" DataValueField="id"
                DataTextField="title_ar" OnSelectedIndexChanged="drop_lang_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator24" runat="server" ControlToValidate="drop_lang"
                ErrorMessage="هذا الحقل يجب إدخاله" ValidationGroup="save"></asp:RequiredFieldValidator>
        </td>
        <td colspan="1" dir="rtl">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr align="right" id="trconference" runat="server">
        <td align="<%$Resources:Master, align%>" runat="server" dir="<%$Resources:Master, dir%>" valign="top">
            <asp:Label ID="Label28" runat="server" Text="<%$Resources:Master ,conference_name %>"></asp:Label>
        </td>
        <td align="<%$Resources:Master, align%>" runat="server"
            dir="<%$Resources:Master, dir%>" valign="top">
            <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator27" runat="server" ControlToValidate="txt_name"
                ErrorMessage="هذا الحقل يجب إدخاله" ValidationGroup="save"></asp:RequiredFieldValidator>
        </td>
        <td class="style1" colspan="1" align="right" runat="server"
            dir="<%$Resources:Master, dir%>" valign="top">
            <asp:Label ID="Label29" runat="server" Text="<%$Resources:Master, conference_no%>"></asp:Label>
        </td>
        <td align="<%$Resources:Master, align%>" runat="server"
            dir="<%$Resources:Master, dir%>" valign="top">
            <asp:TextBox ID="txt_conf_no" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr runat="server" id="trdate">
        <td dir="rtl" align="right" valign="top">
            <asp:Label ID="Label17" runat="server" Text="تاريخ الانعقاد:"></asp:Label>
        </td>
        <td align="right" colspan="2">
            <table>
                <tr align="right">
                    <td dir="rtl" align="right">
                        <asp:TextBox ID="txt_hdate" runat="server"></asp:TextBox>
                        <asp:Label ID="Label18" runat="server" Text="هـ"></asp:Label>
                        <asp:Label ID="lblError2" runat="server" Text="سنة /(يوم- شهر - سنة)" ForeColor="Red"
                            Font-Size="13px"></asp:Label>
                        <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender2" runat="server" FilterType="Custom"
                            TargetControlID="txt_hdate" ValidChars="0123456789/\">
                        </cc1:FilteredTextBoxExtender>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_hdate"
                            ErrorMessage="هذا الحقل يجب إدخاله" ValidationGroup="save"></asp:RequiredFieldValidator>
                    </td>
                    <td>
                    </td>
                    <td dir="rtl" align="right">
                        <asp:TextBox ID="txt_date" runat="server"></asp:TextBox>
                        <asp:Label ID="Label19" runat="server" Text="م"></asp:Label>
                        <asp:Label ID="lblError3" runat="server" Text="سنة/(يوم- شهر -سنة)" ForeColor="Red"
                            Font-Size="13px"></asp:Label>
                        <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender5" runat="server" FilterType="Custom"
                            TargetControlID="txt_date" ValidChars="0123456789/\">
                        </cc1:FilteredTextBoxExtender>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_date"
                            ErrorMessage="هذا الحقل يجب إدخاله" ValidationGroup="save"></asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr runat="server" id="trplace">
        <td rowspan="2" valign="top" align="<%$Resources:Master, align%>" runat="server"
            dir="<%$Resources:Master, dir%>">
            <asp:Label ID="Label4" runat="server" Text="<%$Resources:Master ,conference_holdingplace %>"
                Font-Bold="False"></asp:Label>
        </td>
        <td align="<%$Resources:Master, align%>" runat="server" colspan="1" 
            dir="<%$Resources:Master, dir%>" valign="top">
            <asp:Label ID="Label30" runat="server" Text="<%$Resources:Master ,conference_place %>"></asp:Label>
            <br /><asp:TextBox ID="txt_place" runat="server" Height="22px" Width="134px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator28" runat="server" ControlToValidate="txt_place"
                ErrorMessage="هذا الحقل يجب إدخاله" ValidationGroup="save"></asp:RequiredFieldValidator>
        </td>
        <td align="<%$Resources:Master, align%>" runat="server" 
            dir="<%$Resources:Master, dir%>" valign="top">
            <asp:Label ID="Label8" runat="server" Text="<%$Resources:Master ,conference_city %>"></asp:Label>
            <br /><asp:TextBox ID="txt_city" runat="server" Height="22px" Width="139px"></asp:TextBox>
        </td>
        <td align="<%$Resources:Master, align%>" runat="server">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator30" runat="server" ControlToValidate="txt_city"
                ErrorMessage="هذا الحقل يجب إدخاله" ValidationGroup="save"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr runat="server" id="trcountry" valign="top">
        <td align="<%$Resources:Master, align%>" runat="server" colspan="2" dir="<%$Resources:Master, dir%>"  valign="top">
            <asp:Label ID="Label31" runat="server" Text="<%$Resources:Master ,conference_country %>"></asp:Label>
            <br />
            <asp:TextBox ID="txt_country" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator29" runat="server" ControlToValidate="txt_country"
                ErrorMessage="هذا الحقل يجب إدخاله" ValidationGroup="save"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr runat="server" id="trorg">
        <td align="<%$Resources:Master, align%>" runat="server" dir="<%$Resources:Master, dir%>">
            <asp:Label ID="Label32" runat="server" Text="<%$Resources:Master ,conference_org %>"></asp:Label>
        </td>
        <td colspan="3" align="<%$Resources:Master, align%>" runat="server" dir="<%$Resources:Master, dir%>">
            <asp:TextBox ID="txt_org" runat="server" Height="22px" Width="134px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator31" runat="server" ControlToValidate="txt_org"
                ErrorMessage="هذا الحقل يجب إدخاله" ValidationGroup="save"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr runat="server" id="trnotes">
        <td align="<%$Resources:Master, align%>" runat="server" dir="<%$Resources:Master, dir%>">
            <asp:Label ID="Label12" runat="server" Text="<%$Resources:Master ,c_notes %>"></asp:Label>
        </td>
        <td colspan="2" align="<%$Resources:Master, align%>" runat="server" dir="<%$Resources:Master, dir%>">
            <asp:TextBox ID="txt_notes" runat="server"  Width="100%"  
                 TextMode="MultiLine" Height="60px"></asp:TextBox>
        </td>
    </tr>
    <tr runat="server" id="trtags">
        <td align="<%$Resources:Master, align%>" runat="server" valign="top" dir="<%$Resources:Master, dir%>">
            <asp:Label ID="Label13" runat="server" Text="<%$Resources:Master ,c_tags %>"></asp:Label>
        </td>
        <td colspan="2" valign="top" align="<%$Resources:Master, align%>" runat="server"
            dir="<%$Resources:Master, dir%>">
            
             <asp:TextBox ID="txt_tags" runat="server" Width="100%"  
                 TextMode="MultiLine" Height="60px"></asp:TextBox>
            <asp:Label ID="Label9" runat="server" 
                 Text="يرجى إدخال الكلمات الدالة مفصولة برمز (-) أو (،) فيما بينها كما بالمثال التالى كلمة دالة 1 - كلمة دالة 2" 
                 Font-Size="12px" ForeColor="Red" ></asp:Label>
            
        </td>
        <td dir="<%$Resources:Master, dir%>" runat="server" align="<%$Resources:Master, align%>"
            colspan="1" rowspan="1">
           <asp:RequiredFieldValidator ID="RequiredFieldValidator26" runat="server" ControlToValidate="txt_tags"
                ErrorMessage="هذا الحقل يجب إدخاله" ValidationGroup="A"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr runat="server" id="trperiods">
        <td valign="top">
            <asp:Label ID="Label14" runat="server" Text=" العصر الذي يتناوله/ يرتبط به البحث"></asp:Label>
        </td>
        <td colspan="2" dir="rtl">
            <asp:CheckBoxList ID="chk_periods" DataTextField="title" DataValueField="id" runat="server"
                RepeatDirection="Horizontal"  RepeatColumns="4">
            </asp:CheckBoxList>
          <%--  <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="chk_periods"
                ErrorMessage="هذا الحقل يجب إدخاله" ValidationGroup="A"></asp:RequiredFieldValidator>--%>
        </td>
    </tr>
    <tr runat="server" id="trpicture">
        <td dir="rtl" rowspan="1" valign="top" align="right">
            <asp:Label ID="Label26" runat="server" Text="الصورة المرفقة مع الاستمارة   "></asp:Label>
        </td>
        <td dir="rtl" align="right">
            <asp:RadioButtonList ID="rblFormImage" runat="server" RepeatColumns="1" RepeatDirection="Horizontal">
                <asp:ListItem Text="مرفقة (ورقية / إلكترونية)" Value="1"></asp:ListItem>
                <asp:ListItem Text="غير متاحة (سيتم توفيرها لاحقا)" Value="2" Selected="True"></asp:ListItem>
                <asp:ListItem Text="غير متاحة (استخدم الصورة الرمزية)" Value="3"></asp:ListItem>
            </asp:RadioButtonList>
        </td>
        <td align="right" dir="rtl">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="rblFormImage" Font-Size="14px" ValidationGroup="A"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr runat="server" id="trColectorName">
        <td dir="rtl" rowspan="1" valign="top" align="right">
            <asp:Label ID="Label3" runat="server" Text="اسم جامع بيانات الاستمارة  " Width="150px"
                Height="26px"></asp:Label>
        </td>
        <td dir="rtl" rowspan="1" valign="top">
            <asp:TextBox ID="txtFormDataColectorName" runat="server" Width="270px" />
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txtFormDataColectorName" Font-Size="14px" ValidationGroup="A"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr runat="server" id="trRevisionName">
        <td dir="rtl" rowspan="1" valign="top" align="right">
            <asp:Label ID="Label25" runat="server" Text="اسم مراجع بيانات الاستمارة  " Width="155px"
                Height="26px"></asp:Label>
        </td>
        <td dir="rtl" rowspan="1" valign="top">
            <asp:TextBox ID="txtFormDataRevisionName" runat="server" Width="270px" />
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txtFormDataRevisionName" Font-Size="14px" ValidationGroup="A"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr runat="server" id="file_tr">
        <td align="<%$Resources:Master, align%>" runat="server" rowspan="1" valign="top"
            dir="<%$Resources:Master ,dir%>">
            <asp:Label ID="Label27" runat="server" Text="<%$Resources:Master ,Topics_upload %>"></asp:Label>
        </td>
        <td dir="ltr" colspan="2"  rowspan="1" valign="top" align="left">
             <%--<asp:Label ID="Label55" runat="server" Font-Size="14px" ForeColor="Red" 
                Width="40%"></asp:Label>--%>
            <asp:FileUpload ID="uploadfile" runat="server" Width="100%" />
        &nbsp;
        </td>
        <td>
             <asp:Label ID="labfile" runat="server" Text="Label" Visible="False" Font-Size="14px" ForeColor="Red"></asp:Label>
            
        </td>
    </tr>
    <tr>
        <td align="center" dir="rtl" colspan="3">
            <asp:Button ID="Button1" runat="server" Text="حفظ تفاصيل الاستمارة" OnClick="Button1_Click" OnClientClick="ValidateAndShowPopup()" ValidationGroup="A" />
        </td>
        
    </tr>
    <tr>
        <td align="right" class="style2" dir="rtl">
            &nbsp;
        </td>
        <td>
            &nbsp;
        </td>
    </tr>
</table>
