<%@ Control Language="C#" AutoEventWireup="true" CodeFile="add_glossary.ascx.cs" Inherits="user_controls_add_glossary" %>
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
<table  cellspacing="4" runat="server" dir="<%$Resources:Master, dir%>" id="tblarticle">
    <tr>
        <td id="Td1" colspan="3" dir="<%$Resources:Master, dir%>" runat="server">
        <input id="myRowIndex1" runat="server" type="hidden" />
            <asp:HiddenField ID="content_type" runat="server" />
            <asp:HiddenField ID="content_id" runat="server" />
        </td>
    </tr>
    <tr  id="trpagetile" runat="server" dir="<%$Resources:Master, dir%>">
        <td colspan="3" align="<%$Resources:Master,align%>" 
            dir="<%$Resources:Master, dir%>">
            
            <asp:Label ID="lblpagetitle" runat="server"  Text="<%$Resources:Master, glossary_title%>" Font-Bold="True"></asp:Label>
        </td>
        <td id="Td2"  align="<%$Resources:Master,align%>" visible="true"  runat="server" 
            dir="<%$Resources:Master, dir%>">
            <a href runat="server" id="id_href" target="_blank">عرض الاستمارة </a>
        </td>
    </tr>
    <tr  id="trerror" runat="server">
        <td colspan="3" align="center">
            <asp:Label ID="lblerror" runat="server" ForeColor="Red" ></asp:Label>
        </td>
    </tr>
    
     <tr align="<%$Resources:Master, align%>" id="trtitle" runat="server">
        <td id="Td3" align="<%$Resources:Master, align%>" runat="server" dir="<%$Resources:Master, dir%>">
            <asp:Label ID="Label1" runat="server" Text="<%$Resources:Master, glossary_def%>"></asp:Label>
        </td>
        <td  colspan="3" align="<%$Resources:Master, align%>"  runat="server" 
             dir="<%$Resources:Master, dir%>" >
               <%--<asp:Label ID="lbltitle" runat="server" Font-Bold="true"></asp:Label> --%>
                  <asp:Label ID="lbltitle" runat="server"></asp:Label>    
       </td> 
    </tr>
    
    
    <tr align="<%$Resources:Master, align%>" id="tr1" runat="server">
        <td id="Td5" align="<%$Resources:Master, align%>" runat="server" dir="<%$Resources:Master, dir%>">
            <asp:Label ID="Label2" runat="server" Text="<%$Resources:Master, glossary_title%>"></asp:Label>
        </td>
        <td id="Td6" colspan="3" align="<%$Resources:Master, align%>"  runat="server" 
             dir="<%$Resources:Master, dir%>" >
             <asp:TextBox ID="txt_def" TextMode="MultiLine" runat="server" Width="526px"  Height="114px"></asp:TextBox>
        </td>
       
    </tr>
  <%--  <tr align="<%$Resources:Master, align%>" id="trspecial" runat="server">
        <td id="Td5" dir="<%$Resources:Master, dir%>" runat="server">
            <asp:Label ID="Label1" runat="server" Text="<%$Resources:Master, Labspecial%>"></asp:Label>
        </td>
        <td id="Td6" colspan="2" align="<%$Resources:Master, align%>" runat="server">
            <asp:CheckBox ID="chk_pan" runat="server" Text="علي البانوراما" />
            <asp:CheckBox ID="chk_site" runat="server" Text="علي الموقع" />
        </td>
    </tr>--%>
       
      
 
   
    <tr id="trnotes" runat="server" align="<%$Resources:Master, align%>">
        <td id="Td7" class="style2" runat="server" align="<%$Resources:Master, align%>">
            <asp:Label ID="Label12" runat="server" Text="<%$Resources:Master, c_notes%>"></asp:Label>
        </td>
        <td colspan="2">
            <asp:TextBox ID="txt_notes" runat="server" Height="54px" TextMode="MultiLine" 
                Width="526px"></asp:TextBox>
        </td>
    </tr>
   <%-- <tr id="trtags" runat="server" align="<%$Resources:Master, align%>">
        <td id="Td8" runat="server" align="<%$Resources:Master, align%>">
            <asp:Label ID="Label13" runat="server" Text="<%$Resources:Master, c_tags%>"></asp:Label>
        </td>
        <td colspan="2">
            <asp:TextBox ID="txt_tags" runat="server" TextMode="MultiLine" Width="526px" 
                Height="54px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator26" runat="server" ControlToValidate="txt_tags"
                ErrorMessage="هذا الحقل يجب إدخاله" ValidationGroup="A"></asp:RequiredFieldValidator>
        </td>
        <td>
            <asp:Label ID="lblDeclaration" runat="server" Text="* يرجى إدخال الكلمات الدالة مفصولة برمز (#) فيما بينها كما بالمثال التالى كلمة دالة 1 # كلمة دالة 2"
                Font-Size="12px" ForeColor="Red" Width="100px"></asp:Label>
        </td>
    </tr>--%>
  <%--  <tr id="trperiods" runat="server">
        <td class="style2">
            <asp:Label ID="Label14" runat="server" Text=" العصر الذي تتناوله/ ترتبط به المقالة:"></asp:Label>
        </td>
        <td colspan="2" dir="rtl" valign="top">
            <asp:RadioButtonList ID="chk_periods" DataTextField="title" DataValueField="id" runat="server"
                RepeatDirection="Horizontal" Width="100%">
            </asp:RadioButtonList>
        </td>
    </tr>--%>
    <%--<tr id="trpicture" runat="server">
        <td dir="rtl" rowspan="1" valign="top" align="right">
            <asp:Label ID="Label26" runat="server" Text="الصورة المرفقة مع الاستمارة   "></asp:Label>
        </td>
        <td dir="rtl" align="right" colspan="2">
            <asp:RadioButtonList ID="rblFormImage" runat="server" RepeatColumns="1" RepeatDirection="Horizontal">
                <asp:ListItem Text="مرفقة (ورقية / إلكترونية)" Value="1"></asp:ListItem>
                <asp:ListItem Text="غير متاحة (سيتم توفيرها لاحقا)" Value="2"></asp:ListItem>
                <asp:ListItem Text="غير متاحة (استخدم الصورة الرمزية)" Value="3"></asp:ListItem>
            </asp:RadioButtonList>
        </td>
        <td align="right" dir="rtl">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="rblFormImage" Font-Size="14px" ValidationGroup="A"></asp:RequiredFieldValidator>
        </td>
    </tr>--%>
    <tr id="trcolectorname" runat="server">
        <td dir="rtl" rowspan="1" valign="top" align="right">
            <asp:Label ID="Label3" runat="server" Text="اسم جامع بيانات الاستمارة  " Width="150px"
                Height="26px"></asp:Label>
        </td>
        <td dir="rtl" class="style2" rowspan="1" valign="top" colspan="2">
            <asp:TextBox ID="txtFormDataColectorName" runat="server" Width="100%" />
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txtFormDataColectorName" Font-Size="14px" ValidationGroup="A"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr id="trrevisionname" runat="server">
        <td dir="rtl" rowspan="1" valign="top" align="right">
            <asp:Label ID="Label25" runat="server" Text="اسم مراجع بيانات الاستمارة  " Width="155px"
                Height="26px"></asp:Label>
        </td>
        <td dir="rtl" class="style2" rowspan="1" valign="top" colspan="2">
            <asp:TextBox ID="txtFormDataRevisionName" runat="server" Width="100%" />
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txtFormDataRevisionName" Font-Size="14px" ValidationGroup="A"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr runat="server" id="file_tr" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
        <td rowspan="1" valign="top" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
            <asp:Label ID="Label27" runat="server" Text="<%$Resources:Master,event_upload%>"></asp:Label>
        </td>
        <td id="Td9" runat="server" align="<%$Resources:Master, align%>" rowspan="1" 
            valign="top" colspan="2">
            <asp:FileUpload ID="uploadfile" runat="server" Width="100%" />
            &nbsp;
        </td>
        <td id="Td10" runat="server" align="<%$Resources:Master, align%>">
            <asp:Label ID="labfile" runat="server" Text="Label" Visible="False" Font-Size="14px"
                ForeColor="Red"></asp:Label>
        </td>
    </tr>
    <tr>
        <td align="center" class="style2" dir="rtl" colspan="4">
            <asp:Button ID="Button1" runat="server" Text="حفظ بيانات الاستمارة" 
                OnClick="Button1_Click" ValidationGroup="A" OnClientClick="ValidateAndShowPopup()"/>
        </td>
      
    </tr>
 
</table>