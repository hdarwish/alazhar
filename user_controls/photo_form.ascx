<%@ Control Language="C#" AutoEventWireup="true" CodeFile="photo_form.ascx.cs" Inherits="user_controls_photo_form" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

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

<style type="text/css">
    .style1
    {
        height: 29px;
    }
    .style2
    {
        height: 46px;
    }
</style>
<asp:HiddenField ID="content_id" Visible="false" runat="server" />
<asp:HiddenField ID="content_type" Visible="false" runat="server" />
<table id="tblPhoto" style="width: 750px" border="0" cellspacing="5" runat="server"
    dir='<%$Resources:Master, dir%>'>
    <%--<tr>
       <td width="100px">
            <asp:Label ID="lbl1" runat="server" Text="نوع التسجيل : "></asp:Label>
       </td>
       <td align="center" dir="rtl">
           <asp:RadioButtonList ID="rblType" runat="server" RepeatDirection="Horizontal" 
               RepeatColumns="2" Width="300px" >
            <asp:ListItem Text="تسجيل سمعي" Value="0"></asp:ListItem>
            <asp:ListItem Text="تسجيل مرئي " Value="1"></asp:ListItem>
           </asp:RadioButtonList> 
       </td>
   </tr>--%>
    <tr>
        <td colspan="2" align="center" height="60px">
            <asp:Label ID="Label25" runat="server" Text=" إستمارة بيانات الصور " ForeColor="Black"
                Font-Bold="True" Font-Size="16px"></asp:Label>
        </td>
        <td>
            <a href="#" runat="server" id="id_href" target="_blank" visible="false">عرض الاستمارة
            </a>
        </td>
    </tr>
    <tr runat="server" id="trTitle">
        <td width="100px" valign="top" dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>'>
            <asp:Label ID="lbl2" runat="server" Text="<%$Resources:Master, lbl_photo_Title_Photo %>"></asp:Label>
        </td>
        <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>' valign="top"
            colspan="2">
            <asp:Label ID="txtTitle" runat="server" Font-Bold="True" Font-Size="14px"></asp:Label>
        </td>
    </tr>
    <tr style="height: 36px" runat="server" id="trHighlight" dir='<%$Resources:Master, dir%>'
        align='<%$Resources:Master, align%>'>
        <td width="100px" valign="top" runat="server" dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>'>
            <asp:Label ID="lblHighlight" runat="server" Text='<%$Resources:Master, lblHighlight%>'
                Font-Bold="True"></asp:Label>
        </td>
        <td valign="top" runat="server" dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>'>
            <asp:CheckBox ID="chk_highlight" runat="server" Text="علي الموقع" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="chk_pano" runat="server" Text="علي بانوراما التراث" />
        </td>
        <td>
        </td>
    </tr>
    <tr runat="server" id="trType">
        <td width="100px" valign="top" dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>'>
            <asp:Label ID="lbl3" runat="server" Text="<%$Resources:Master, lbl_photo_details%>"></asp:Label>
        </td>
        <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>'>
            <asp:RadioButtonList ID="RblMediaType" runat="server" RepeatColumns="4" RepeatDirection="Horizontal"
                Width="100%" DataTextField="title_ar" DataValueField="id">
            </asp:RadioButtonList>
        </td>
        <td>
        </td>
    </tr>
    <tr runat="server" id="trDesc">
        <td width="100px" valign="top" dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>'>
            <asp:Label ID="lbl4" runat="server" Text="وصف الصورة : "></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtDesc" runat="server" Width="100%" TextMode="MultiLine" Height="60px"></asp:TextBox>
        </td>
        <td align="right" dir="rtl" valign="top">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txtDesc" ValidationGroup="page" Font-Size="14px"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr runat="server" id="trName">
        <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>' width="100px"
            class="">
            <asp:Label ID="Label6" runat="server" Text="<%$Resources:Master, lbl_photo_Photographer%>"></asp:Label>
        </td>
        <td class="">
            <asp:TextBox ID="txtCommenterName" runat="server" Width="100%" Height="26px"></asp:TextBox>
        </td>
        <td>
        </td>
    </tr>
    <tr runat="server" id="trDate">
        <td dir="rtl" width="120px" class="">
            <asp:Label ID="Label5" runat="server" Text="تاريخ التصوير/الرسم : "></asp:Label>
        </td>
        <td>
            <asp:Label ID="Label7" runat="server" Text="هجرى :" Width="40px" Height="23px"></asp:Label>
            <asp:TextBox ID="txtHijriDate" runat="server" Height="20px" Width="80px" />
            <br />
            <asp:Label ID="Label8" runat="server" Text="ميلادى :" Width="42px" Height="23px"></asp:Label>
            <asp:TextBox ID="txtGorgDate" runat="server" Height="20px" Width="80px" />
        </td>
        <td>
        </td>
    </tr>
    <tr runat="server" id="trResourceName">
        <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>'>
            <asp:Label ID="Label9" runat="server" Text="<%$Resources:Master, lbl_photo_Source_copyright%>"
                Height="26px"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtresourceName" runat="server" Height="26px" Width="100%" />
        </td>
        <td valign="top">
        </td>
    </tr>
    <tr runat="server" id="trNotes">
        <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>' width="135px"
            class="" rowspan="1" valign="top">
            <asp:Label ID="Label15" runat="server" Text="<%$Resources:Master, lbl_photo_Notes%>"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtNotes" runat="server" Width="100%" TextMode="MultiLine" Height="60px"></asp:TextBox>
        </td>
        <td>
        </td>
    </tr>
    <tr runat="server" id="trLinkWords">
        <td dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>' width="120px"
            class="" rowspan="1" valign="top">
            <asp:Label ID="Label16" runat="server" Text="<%$Resources:Master, lbl_photo_Keywords %>"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtLinkWords" runat="server" Width="100%" TextMode="MultiLine" Height="60px"></asp:TextBox>
            <asp:Label ID="lblDeclaration" runat="server" Text="يرجى إدخال الكلمات الدالة مفصولة برمز (-) أو (،) فيما بينها كما بالمثال التالى كلمة دالة 1 - كلمة دالة 2"
                Font-Size="12px" ForeColor="Red" Width="100%"></asp:Label>
        </td>
        <td align="right" dir="rtl" valign="top">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txtLinkWords" ValidationGroup="page" Font-Size="14px"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr runat="server" id="trTimeLine">
        <td dir="rtl" width="120px" class="" rowspan="1" valign="top">
            <asp:Label ID="Label17" runat="server" Text="العصر الذي تنتمي إليه الصورة  : "></asp:Label>
        </td>
        <td align="right" colspan="1">
            <asp:CheckBoxList ID="chk_periods" runat="server" RepeatColumns="4" RepeatDirection="Horizontal"
                DataTextField="title" DataValueField="id" Width="100%">
            </asp:CheckBoxList>
            <asp:Label ID="Label18" runat="server" Text="ملاحظات  : " Width="100%"></asp:Label>
            <asp:TextBox ID="txtTimelineNotes" runat="server" TextMode="MultiLine" Width="100%" />
        </td>
        <td valign="top">
        </td>
    </tr>
    <tr runat="server" id="trFormImage">
        <td dir="rtl" width="120px" class="" rowspan="1" valign="top">
            <asp:Label ID="Label19" runat="server" Text="الصورة المرفقة مع الاستمارة  : "></asp:Label>
        </td>
        <td align="right">
            <asp:RadioButtonList ID="rblFormImage" runat="server" RepeatColumns="1" Width="100%">
                <asp:ListItem Text="مرفقة (ورقية / إلكترونية)"></asp:ListItem>
                <asp:ListItem Text="غير متاحة (سيتم توفيرها لاحقا)" Selected="True"></asp:ListItem>
                <asp:ListItem Text="غير متاحة (استخدم الصورة الرمزية)"></asp:ListItem>
            </asp:RadioButtonList>
        </td>
        <td>
        </td>
    </tr>
    <tr runat="server" id="trFormDataCollectorName">
        <td dir="rtl" class="" rowspan="1" valign="top">
            <asp:Label ID="Label20" runat="server" Text="اسم جامع بيانات الاستمارة  : "></asp:Label>
        </td>
        <td dir="rtl" rowspan="1" valign="top" colspan="1" align="right">
            <asp:TextBox ID="txtFormDataColectorName" runat="server" Height="26px" Width="100%" />
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ValidationGroup="page" ControlToValidate="txtFormDataColectorName" Font-Size="14px"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr runat="server" id="trFormDataRevisionName">
        <td dir="rtl" class="" rowspan="1" valign="top">
            <asp:Label ID="Label21" runat="server" Text="اسم مراجع بيانات الاستمارة  : "></asp:Label>
        </td>
        <td dir="rtl" rowspan="1" valign="top" colspan="1" align="right">
            <asp:TextBox ID="txtFormDataRevisionName" runat="server" Height="26px" Width="100%" />
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ValidationGroup="page" ControlToValidate="txtFormDataRevisionName" Font-Size="14px"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <%-- <tr runat="server" id="trFormDataEntryName">
         <td dir="rtl"  class="" rowspan="1" valign="top">
                 <asp:Label ID="Label22" runat="server" 
                     Text="اسم مدخل بيانات الاستمارة على الحاسب الآلي  : " Width="155px" 
                 ></asp:Label>
        </td>
         <td dir="rtl" rowspan="1" valign="top" colspan="1" align="right">
          
             <asp:TextBox ID="txtFormDataEntryName" runat="server"  
                    Height="26px" Width="100%"  />
        </td>
        <td>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" 
            ErrorMessage="هذا الحقل يجب إدخاله" ControlToValidate="txtFormDataEntryName" ValidationGroup="page"
                Font-Size="14px"></asp:RequiredFieldValidator>
    </td>
    </tr>
    <tr runat="server" id="trFormDataEntryRevisionName">
          <td dir="rtl"  class="" rowspan="1" valign="top">
                  <asp:Label ID="Label23" runat="server" 
                      Text="اسم مراجع إدخال بيانات الاستمارة على الحاسب الآلي  : " Width="155px" 
                ></asp:Label>
        </td>
         <td dir="rtl" rowspan="1" valign="top" colspan="1" align="right">
           
             <asp:TextBox ID="txtFormDataEntryRevisionName" runat="server" Width="100%"  />
        </td>
        <td>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" 
            ErrorMessage="هذا الحقل يجب إدخاله" ValidationGroup="page"
                ControlToValidate="txtFormDataEntryRevisionName" Font-Size="14px"></asp:RequiredFieldValidator>
    </td>
    </tr>--%>
    <tr runat="server" id="file_tr">
        <td rowspan="1" valign="top" dir='<%$Resources:Master, dir%>' align='<%$Resources:Master, align%>'>
            <asp:Label ID="Label27" runat="server" Text="<%$Resources:Master, Topics_upload %>"></asp:Label>
        </td>
        <td dir="ltr" rowspan="1" valign="top" align="left">
            <%--<asp:Label ID="Label55" runat="server" Font-Size="14px" ForeColor="Red" 
                Width="40%"></asp:Label>--%>
            <asp:FileUpload ID="uploadfile" runat="server" Width="100%" />
            &nbsp;
        </td>
        <td>
            <asp:Label ID="labfile" runat="server" Text="Label" Visible="False" Font-Size="14px"
                ForeColor="Red"></asp:Label>
        </td>
    </tr>
    <tr>
       <%-- <td colspan="3">
            <cc1:FilteredTextBoxExtender ID="FilteredtxtHijriDate" runat="server" FilterType=""
                TargetControlID="txtHijriDate" ValidChars="0123456789/\">
            </cc1:FilteredTextBoxExtender>
            <br />
            <cc1:FilteredTextBoxExtender ID="FilteredtxtGorgDate" runat="server" FilterType="Custom"
                TargetControlID="txtGorgDate" ValidChars="0123456789/\">
            </cc1:FilteredTextBoxExtender>
        </td>--%>
    </tr>
    <tr runat="server" id="trSave">
        <td align="center" colspan="3" height="60px" valign="middle">
            <asp:Button ID="btnsave" runat="server" Text="حفظ تفاصيل الاستمارة" ValidationGroup="page"
                OnClick="btnsave_Click" OnClientClick="ValidateAndShowPopup()" />
        </td>
    </tr>
</table>
