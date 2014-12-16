<%@ Control Language="C#" AutoEventWireup="true" CodeFile="website_template.ascx.cs"
    Inherits="user_controls_website_template" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<style type="text/css">
    .style3
    {
        height: 36px;
    }
</style>
<script type="text/javascript">
     function ShowPopup() {
         alert(" لم يتم حفظ تفاصيل الاستمارة هناك حقول لم يتم ادخالها ");
     }

     function ValidateAndShowPopup() {
         if (Page_ClientValidate('page') == false) {
             ShowPopup();
         }
     }
</script>
<asp:HiddenField ID="content_id" Visible="false" runat="server" />
<asp:HiddenField ID="content_type" Visible="false" runat="server" />
<table id="tblWebsite" style="width: 750px" border="0" cellspacing="5" runat="server"
    dir='<%$Resources:Master, dir%>'>
    <tr>
        <td colspan="2" align="center" height="60px">
            <asp:Label ID="Label25" runat="server" Text=" استمارة بيانات موقع إلكترونى " ForeColor="Black"
                Font-Bold="true" Font-Size="16px"></asp:Label>
        </td>
        <td width="120px">
            <a href="#" runat="server" id="id_href" target="_blank" visible="false">عرض الاستمارة
            </a>
        </td>
    </tr>
    <tr runat="server" id="trTitle">
        <td width="155px" valign="top" dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>'>
            <asp:Label ID="lbl2" runat="server" Text='<%$Resources:Master, website_title%>'></asp:Label>
        </td>
        <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>' valign="top"
            colspan="2">
            <asp:Label ID="txtTitle" runat="server" Font-Bold="True" Font-Size="14px"></asp:Label>
        </td>
    </tr>
    <tr runat="server" id="trHighlight" dir='<%$Resources:Master, dir%>' visible="false" align='<%$Resources:Master, align%>'>
        <td id="Td1" width="155px" valign="top" runat="server" dir='<%$Resources:Master, dir%>'
            align='<%$Resources:Master, align%>' class="style3">
            <asp:Label ID="lblHighlight" runat="server" Text='<%$Resources:Master, lblHighlight%>'
                Font-Bold="True"></asp:Label>
        </td>
        <td id="Td2" valign="top" runat="server" dir='<%$Resources:Master, dir%>'
            align='<%$Resources:Master, align%>' class="style3">
            <asp:CheckBox ID="chk_highlight" runat="server" Text="علي الموقع" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="chk_pano" runat="server" Text="علي بانوراما التراث" />
        </td>
        <td class="style3">
        </td>
    </tr>
    <tr runat="server" id="trDesc">
        <td width="155px" valign="top" dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>'>
            <asp:Label ID="lbl4" runat="server" Text='<%$Resources:Master, website_Desc%>'></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtDesc" runat="server" Width="100%" TextMode="MultiLine" Height="60px"></asp:TextBox>
        </td>
        <td align="right" dir="rtl" valign="top">
        </td>
    </tr>
    <tr runat="server" id="trName">
        <td dir="rtl" width="155px">
            <asp:Label ID="lbl5" runat="server" Text="اسم المسئول الفكري (مؤلف/هيئة) : "></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtName" runat="server" Width="100%" Height="26px"></asp:TextBox>
        </td>
        <td>
        </td>
    </tr>
    <tr runat="server" id="trSiteLang">
        <td width="155px" valign="top">
            <asp:Label ID="lbl3" runat="server" Text="لغة الموقع : "></asp:Label>
        </td>
        <td align="right">
            <asp:RadioButtonList ID="RblLangType" runat="server" RepeatColumns="4" RepeatDirection="Horizontal"
                Width="100%" DataTextField="title_ar" DataValueField="id">
            </asp:RadioButtonList>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="يجب اختيار لغة الموقع"
                ControlToValidate="RblLangType" ValidationGroup="page" Font-Size="14px"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr runat="server" id="trurl">
        <td dir="rtl" width="155px">
            <asp:Label ID="Label3" runat="server" Text="العنوان الإلكتروني (URL) : "></asp:Label>
        </td>
        <td align="right">
            <asp:TextBox ID="txtUrl" runat="server" Width="100%" Height="26px"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txtUrl" ValidationGroup="page" Font-Size="14px"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr runat="server" id="trDate">
        <td dir="rtl" width="155px">
            <asp:Label ID="Label5" runat="server" Text="تاريخ الدخول على الموقع : "></asp:Label>
        </td>
        <td align="right">
            <asp:TextBox ID="txtDate" runat="server" Height="20px" Width="80px" />
            <cc1:FilteredTextBoxExtender ID="FilteredtxtGorgDate" runat="server" FilterType="Custom"
                TargetControlID="txtDate" ValidChars="0123456789/\">
            </cc1:FilteredTextBoxExtender>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txtDate" ValidationGroup="page" Font-Size="14px"></asp:RequiredFieldValidator>
        </td>
        <td>
        </td>
    </tr>
    <tr runat="server" id="trLinkWords">
        <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>' width="155px"
            rowspan="1" valign="top">
            <asp:Label ID="Label16" runat="server" Text="<%$Resources:Master, lbl_photo_Keywords %>"></asp:Label>
        </td>
        <td align="right">
            <asp:TextBox ID="txtLinkWords" runat="server" Width="100%" TextMode="MultiLine" Height="60px"></asp:TextBox>
            <asp:Label ID="lblDeclaration" runat="server" Text="يرجى إدخال الكلمات الدالة مفصولة برمز (-) أو (،) فيما بينها كما بالمثال التالى كلمة دالة 1 - كلمة دالة 2"
                Font-Size="12px" ForeColor="Red" Width="100%"></asp:Label>
        </td>
        <td align="right" dir="rtl" valign="top">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txtLinkWords" ValidationGroup="page" Font-Size="14px"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr runat="server" id="trNotes">
        <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>' width="155px"
            rowspan="1" valign="top">
            <asp:Label ID="Label15" runat="server" Text="<%$Resources:Master, lbl_photo_Notes%>"></asp:Label>
        </td>
        <td align="right">
            <asp:TextBox ID="txtNotes" runat="server" Width="100%" TextMode="MultiLine" Height="60px"></asp:TextBox>
        </td>
        <td>
        </td>
    </tr>
    <tr runat="server" id="tr28">
        <td dir="rtl" width="150px" rowspan="1" valign="top" align="right">
            <asp:Label ID="Label19" runat="server" Text="الصورة المرفقة مع الاستمارة  : " ForeColor="#996633"></asp:Label>
        </td>
        <td>
            <asp:RadioButtonList ID="rblFormImage" runat="server" RepeatColumns="1" Width="100%">
                <asp:ListItem Text="مرفقة (ورقية / إلكترونية)" Value="1"></asp:ListItem>
                <asp:ListItem Text="غير متاحة (سيتم توفيرها لاحقا)" Value="2" Selected="True"></asp:ListItem>
                <asp:ListItem Text="غير متاحة (استخدم الصورة الرمزية)" Value="3"></asp:ListItem>
            </asp:RadioButtonList>
        </td>
        <td>
            &nbsp;
        </td>
    </tr>
    <tr runat="server" id="trFormDataCollectorName">
        <td dir="rtl" width="155px" rowspan="1" valign="top">
            <asp:Label ID="Label20" runat="server" Text="اسم جامع بيانات الاستمارة  : " Width="150px"
                Height="26px"></asp:Label>
        </td>
        <td dir="rtl" rowspan="1" valign="top" colspan="1" align="right">
            <asp:TextBox ID="txtFormDataColectorName" runat="server" Width="100%" Height="26px" />
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ValidationGroup="page" ControlToValidate="txtFormDataColectorName" Font-Size="14px"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr runat="server" id="trFormDataRevisionName">
        <td dir="rtl" width="155px" rowspan="1" valign="top">
            <asp:Label ID="Label21" runat="server" Text="اسم مراجع بيانات الاستمارة  : " Width="155px"
                Height="26px"></asp:Label>
        </td>
        <td dir="rtl" rowspan="1" valign="top" colspan="1" align="right">
            <asp:TextBox ID="txtFormDataRevisionName" runat="server" Width="100%" Height="26px" />
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ValidationGroup="page" ControlToValidate="txtFormDataRevisionName" Font-Size="14px"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr runat="server" id="file_tr">
        <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>' rowspan="1"
            valign="top">
            <asp:Label ID="Label27" runat="server" Text="<%$Resources:Master, Topics_upload %>"></asp:Label>
        </td>
        <td dir="ltr" rowspan="1" valign="top" align="left">
            <%--<asp:Label ID="Label55" runat="server" Font-Size="14px" ForeColor="Red" Width="40%"></asp:Label>--%>
            <asp:FileUpload ID="uploadfile" runat="server" Width="100%" />
            &nbsp;
        </td>
        <td>
            <asp:Label ID="labfile" runat="server" Text="Label" Visible="False" Font-Size="14px"
                ForeColor="Red"></asp:Label>
        </td>
    </tr>
    <tr runat="server" id="trSave">
        <td align="center" colspan="3" height="60px" valign="middle">
            <asp:Button ID="btnsave" runat="server" Text="حفظ تفاصيل الاستمارة" ValidationGroup="page"
                OnClick="btnsave_Click"  OnClientClick="ValidateAndShowPopup()"  />
        </td>
    </tr>
</table>
