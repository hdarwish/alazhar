<%@ Control Language="C#" AutoEventWireup="true" CodeFile="topics.ascx.cs" Inherits="user_controls_topics" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<script type="text/javascript">
     function ShowPopup() {
         alert("لم يتم حفظ تفاصيل الاستمارة هناك حقول لم يتم ادخالها ");
     }

     function ValidateAndShowPopup() {
         if (Page_ClientValidate('page') == false) {
             ShowPopup();
         }
     }
</script>
<table style="width: 750px" border="0" dir="<%$Resources:Master, dir%>" id="tblTopics" runat="server">
    <tr>
        <td colspan="2" align="center" height="60px">
             <asp:HiddenField ID="content_id" runat="server" />
            <asp:HiddenField ID="content_type" runat="server" />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label25" runat="server" Text="<%$Resources:Master, Topics_head %>" ForeColor="Black"
                Font-Bold="True" Font-Size="16px"></asp:Label>
        </td>
          <td align="left" visible="true" colspan="2" dir="<%$Resources:Master, dir%>" >
            <a href="#" runat="server" id="id_href" target="_blank" visible="False">عرض الاستمارة  </a>
        </td>
    </tr>
    <tr>
        <td colspan="3" align="center" height="40px">
            <asp:Label ID="lblpage" runat="server" Text="تم حفظ بيانات الإستمارة بنجاح " ForeColor="Green"
                Visible="False" Font-Size="16px"></asp:Label>
        </td>
    </tr>
    <tr runat="server" id="tr_id_1">
        <td width="100px" valign="top" height="30px" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
            <asp:Label ID="lbl2" runat="server" Text="<%$ Resources:Master, Topics_labels_subject_lbl %>" ForeColor="#996633"></asp:Label>
        </td>
        <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" valign="top" colspan="2">
            <asp:label ID="txtTitle" runat="server" Font-Bold="True" Font-Size="14px"></asp:label>
        </td>
       
    </tr>
    <tr runat="server" id="tr_id_2">
        <td width="100px" valign="top">
            <asp:Label ID="Label24" runat="server" Text="عنصر مميز :  " ForeColor="#996633"></asp:Label>
        </td>
        <td width="420px">
            <asp:RadioButtonList ID="rblSpecialElement" runat="server" RepeatDirection="Horizontal"
                RepeatColumns="2" Width="300px">
                 <asp:ListItem Text="على الموقع" Selected="True"></asp:ListItem>
                <asp:ListItem Text="على البانوراما"></asp:ListItem>
            </asp:RadioButtonList>
        </td>
        <td>
        </td>
    </tr>
    <tr runat="server" id="tr_id_3">
        <td width="100px" valign="top" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
            <asp:Label ID="lbl4" runat="server" Text="<%$ Resources:Master, Topics_Labels_Brief_Descrip %>" ForeColor="#996633"></asp:Label>
        </td>
        <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
           
                 <fckeditorv2:fckeditor id="txtDesc" runat="server" basepath="~/fckeditor/"
                height="400px">
            </fckeditorv2:fckeditor>
        </td>
        <td align="right" dir="rtl" valign="top">
           <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txtDesc" Font-Size="14px" ValidationGroup="page"></asp:RequiredFieldValidator>--%>
        </td>
    </tr>
    <tr runat="server" id="tr_id_4">
        <td width="100px" valign="top" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
            <asp:Label ID="Label26" runat="server" Text="<%$ Resources:Master, Topics_labels_detail_descrip %>" 
                ForeColor="#996633"></asp:Label>
        </td>
        <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
            
                <fckeditorv2:fckeditor id="txtDetailedDesc" runat="server" basepath="~/fckeditor/"
                height="400px">
            </fckeditorv2:fckeditor>
        </td>
        <td align="right" dir="rtl" valign="top">
           <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txtDetailedDesc" Font-Size="14px" 
                ValidationGroup="page"></asp:RequiredFieldValidator>--%>
        </td>
    </tr>
    <tr runat="server" id="tr_id_5">
        <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" width="135px"  rowspan="1" valign="top">
            <asp:Label ID="Label15" runat="server" Text="<%$ Resources:Master, Topics_labels_notes %>" 
                ForeColor="#996633"></asp:Label>
        </td>
        <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
            <asp:TextBox ID="txtNotes" runat="server" Width="100%" TextMode="MultiLine" 
                Height="60px"></asp:TextBox>
        </td>
        <td>
        </td>
    </tr>
    <tr runat="server" id="tr_id_6">
        <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" 
            width="120px"  rowspan="1" valign="top">
            <asp:Label ID="Label16" runat="server" Text="<%$ Resources:Master, Topics_labels_KeyWords %>" 
                ForeColor="#996633"></asp:Label>
        </td>
        <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
            <asp:TextBox ID="txtLinkWords" runat="server" Width="100%" TextMode="MultiLine"
                Height="60px"></asp:TextBox>
            <asp:Label ID="lblDeclaration" runat="server" Text="يرجى إدخال الكلمات الدالة مفصولة برمز (-) أو (،) فيما بينها كما بالمثال التالى كلمة دالة 1 - كلمة دالة 2"
                Font-Size="12px" ForeColor="Red"></asp:Label>
        </td>
        <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>"  valign="top">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txtLinkWords" Font-Size="14px" ValidationGroup="page"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr runat="server" id="tr_id_7">
        <td dir="rtl" width="120px" rowspan="1" valign="top">
            <asp:Label ID="Label19" runat="server" Text="الصورة المرفقة مع الاستمارة  : " 
                ForeColor="#996633"></asp:Label>
        </td>
        <td>
            <asp:RadioButtonList ID="rblFormImage" runat="server" RepeatColumns="1" Width="100%">
               
		 <asp:ListItem Text="مرفقة (ورقية / إلكترونية)" Value="1"></asp:ListItem>
                <asp:ListItem Value="2" Text="غير متاحة (سيتم توفيرها لاحقا)" Selected="True"></asp:ListItem>
                <asp:ListItem Value="0" Text="غير متاحة (استخدم الصورة الرمزية)"></asp:ListItem>
            </asp:RadioButtonList>
        </td>
        <td>
        </td>
    </tr>
    <tr runat="server" id="tr_id_8">
        <td dir="rtl"  rowspan="1" valign="top">
            <asp:Label ID="Label20" runat="server" Text="اسم جامع بيانات الاستمارة  : " Width="150px"
                Height="26px" ForeColor="#996633"></asp:Label>
        </td>
        <td dir="rtl" rowspan="1" valign="top">
            <asp:TextBox ID="txtFormDataColectorName" runat="server" Width="270px" Height="26px" />
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txtFormDataColectorName" Font-Size="14px" 
                ValidationGroup="page"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr runat="server" id="tr_id_9">
        <td dir="rtl" rowspan="1" valign="top">
            <asp:Label ID="Label21" runat="server" Text="اسم مراجع بيانات الاستمارة  : " Width="155px"
                Height="26px" ForeColor="#996633"></asp:Label>
        </td>
        <td dir="rtl" rowspan="1" valign="top">
            <asp:TextBox ID="txtFormDataRevisionName" runat="server" Width="270px" Height="26px" />
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txtFormDataRevisionName" Font-Size="14px" 
                ValidationGroup="page"></asp:RequiredFieldValidator>
        </td>
    </tr>
   <%-- <tr runat="server" id="tr_id_10">
        <td dir="rtl" rowspan="1" valign="top">
            <asp:Label ID="Label22" runat="server" Text="??? ???? ?????? ????????? ??? ?????? ?????  : "
                Width="155px" Height="26px" ForeColor="#996633"></asp:Label>
        </td>
        <td dir="rtl"  rowspan="1" valign="top">
            <asp:TextBox ID="txtFormDataEntryName" runat="server" Width="270px" Height="26px" />
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ErrorMessage="??? ????? ??? ??????"
                ControlToValidate="txtFormDataEntryName" Font-Size="14px" 
                ValidationGroup="page"></asp:RequiredFieldValidator>
        </td>
    </tr>--%>
    <%--<tr runat="server" id="tr_id_11">
        <td dir="rtl" rowspan="1" valign="top">
            <asp:Label ID="Label23" runat="server" Text="??? ????? ????? ?????? ????????? ??? ?????? ?????  : "
                Width="155px" Height="26px" ForeColor="#996633"></asp:Label>
        </td>
        <td dir="rtl"  rowspan="1" valign="top">
            <asp:TextBox ID="txtFormDataEntryRevisionName" runat="server" Width="270px" Height="26px" />
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" ErrorMessage="??? ????? ??? ??????"
                ControlToValidate="txtFormDataEntryRevisionName" Font-Size="14px" 
                ValidationGroup="page" Width="100px"></asp:RequiredFieldValidator>
        </td>
    </tr>--%>
    <tr runat="server" id="file_tr">
        <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" rowspan="1" valign="top">
            <asp:Label ID="Label2" runat="server" Text=" " Width="155px"
                Height="26px" ForeColor="#996633"></asp:Label>
        </td>
      <td dir="ltr" rowspan="1" valign="top" align="left">
         <%--<asp:Label ID="Label55" runat="server" Font-Size="14px" ForeColor="Red" 
                Width="40%"></asp:Label>--%>
            <asp:FileUpload ID="uploadfile" runat="server" Width="100%" />
        </td>
        <td>
            <asp:Label ID="labfile" runat="server" Text="Label" Visible="False" Font-Size="14px"
                ForeColor="Red"></asp:Label>
        </td>
    </tr>
    <tr>
        <td align="center" colspan="3" height="60px" valign="middle">
            <asp:Button ID="btnsave" runat="server" Text="حفظ تفاصيل الاستمارة" 
                OnClick="btnsave_Click" ValidationGroup="page"  OnClientClick="ValidateAndShowPopup()" />
        </td>
    </tr>
</table>
