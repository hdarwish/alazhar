<%@ Control Language="C#" AutoEventWireup="true" CodeFile="add_articles.ascx.cs"
    Inherits="masterpage_add_articles" %>
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

<table  cellspacing="4" runat="server" dir="<%$Resources:Master, dir%>" id="tblarticle">
    <tr>
        <td colspan="3" dir="<%$Resources:Master, dir%>" runat="server">
        <input id="myRowIndex1" runat="server" type="hidden" />
            <asp:HiddenField ID="content_type" runat="server" />
            <asp:HiddenField ID="content_id" runat="server" />
        </td>
    </tr>
    <tr  id="trpagetile" runat="server" dir="<%$Resources:Master, dir%>">
        <td colspan="3" align="<%$Resources:Master,align%>" 
            dir="<%$Resources:Master, dir%>">
            <asp:Label ID="lblpagetitle" runat="server" Text="بيانات المقالات" Font-Bold="True"></asp:Label>
        </td>
        <td  align="<%$Resources:Master,align%>" visible="true"  runat="server" 
            dir="<%$Resources:Master, dir%>">
            <a href runat="server" id="id_href" target="_blank">عرض الاستمارة </a>
        </td>
    </tr>
    <tr align="<%$Resources:Master, align%>" id="trerror" runat="server">
        <td colspan="3" align="<%$Resources:Master, align%>">
            <asp:Label ID="lblerror" runat="server"></asp:Label>
        </td>
    </tr>
     <tr align="<%$Resources:Master, align%>" id="trtitle" runat="server">
        <td align="<%$Resources:Master, align%>" runat="server" dir="<%$Resources:Master, dir%>">
            <asp:Label ID="Label2" runat="server" Text="<%$Resources:Master, main_title%>"></asp:Label>
        </td>
        <td colspan="3" align="<%$Resources:Master, align%>"  runat="server" 
             dir="<%$Resources:Master, dir%>" >
            <asp:TextBox ID="txt_art_title" runat="server" Font-Size="14px" Font-Bold="True" Height="19px" Width="600px"></asp:TextBox>
            <asp:RequiredFieldValidator ControlToValidate="txt_art_title" ValidationGroup="A" runat="server" ErrorMessage="هذا الحقل يجب إدخاله" ID="rfv1"></asp:RequiredFieldValidator>
	
        </td>
       
    </tr>
    <tr align="<%$Resources:Master, align%>" id="trspecial" runat="server">
        <td dir="<%$Resources:Master, dir%>" runat="server">
            <asp:Label ID="Label1" runat="server" Text="<%$Resources:Master, Labspecial%>"></asp:Label>
        </td>
        <td colspan="2" align="<%$Resources:Master, align%>" runat="server">
            
            <asp:CheckBox ID="chk_site" runat="server" Text="علي الموقع" />
            <asp:CheckBox ID="chk_pan" runat="server" Text="علي البانوراما" />
        </td>
    </tr>
<tr align="right" id="trpageno" runat="server" >
        <td align="right" dir="rtl" >
            <asp:Label ID="Label5" runat="server" Text=" أرقام الصفحات التي تشغلها من:"></asp:Label>
        </td>
        <td valign="top" colspan="2">
           <asp:Label ID="Label4" runat="server" Text="من:"></asp:Label>
            <asp:TextBox ID="txt_from" runat="server" Width="100px"></asp:TextBox>
           
            <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" runat="server" FilterType="Custom"
                TargetControlID="txt_from" ValidChars="0123456789/\">
            </cc1:FilteredTextBoxExtender>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator22" runat="server" ControlToValidate="txt_from"
                ErrorMessage="هذا الحقل يجب إدخاله" ValidationGroup="A" ></asp:RequiredFieldValidator>
                <br />
                <br />
                
            <asp:Label ID="Label7" runat="server" Text="إلي:"></asp:Label>
            <asp:TextBox ID="txt_to" runat="server" Width="100px"></asp:TextBox>
            <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender3" runat="server" FilterType="Custom"
                TargetControlID="txt_to" ValidChars="0123456789/\">
            </cc1:FilteredTextBoxExtender>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator23" runat="server" ControlToValidate="txt_to"
                ErrorMessage="هذا الحقل يجب إدخاله" ValidationGroup="A"></asp:RequiredFieldValidator>
       
        </td>
       
      
    </tr>
    <tr align="right" id="trlang" runat="server">
        <td dir="rtl">
            <asp:Label ID="Label6" runat="server" Text="لغة المقالة:"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="drop_lang" runat="server" AutoPostBack="true" DataValueField="id"
                DataTextField="title_ar" 
                OnSelectedIndexChanged="drop_lang_SelectedIndexChanged" Width="150px">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator24" runat="server" ControlToValidate="drop_lang"
                ErrorMessage="هذا الحقل يجب إدخاله" ValidationGroup="A" InitialValue="0" Display="Dynamic"> </asp:RequiredFieldValidator>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr id="trres" runat="server" align="<%$Resources:Master, align%>">
        <td  align="<%$Resources:Master, align%>">
            <asp:Label ID="Label8" runat="server" Text="<%$Resources:Master, periodical_title%>"></asp:Label>
        </td>
        <td colspan="2">
            <asp:TextBox ID="txt_res" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator25" runat="server" ControlToValidate="txt_res"
                ErrorMessage="هذا الحقل يجب إدخاله" ValidationGroup="A"></asp:RequiredFieldValidator>
        </td>
    </tr>
   
    <tr id="trfoldernolbl" runat="server" align="right">
        <td rowspan="2">
            <asp:Label ID="Label9" runat="server" Text=" رقم السنة/المجلد:"></asp:Label>
        </td>
        <td colspan="2">
        
            <asp:Label ID="lbl_folderno" runat="server" Text=""></asp:Label>
        </td>
    </tr>
     <tr id="trfolderno" runat="server"><td> 
        
            <asp:TextBox ID="txt_folderno" runat="server"></asp:TextBox>
             &nbsp;
             <asp:TextBox ID="txt_folderno2" runat="server"></asp:TextBox> 
              &nbsp;
              <asp:TextBox ID="txt_folderno3" runat="server"></asp:TextBox>
         </td></tr>
    
    <tr id="trseriesno" runat="server">
        <td class="style2">
            <asp:Label ID="Label11" runat="server" Text=" رقم العدد/الجزء:"></asp:Label>
        </td>
        <td colspan="2">
            <asp:TextBox ID="txt_seriesno" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr id="trnotes" runat="server" align="<%$Resources:Master, align%>">
        <td class="style2" runat="server" align="<%$Resources:Master, align%>">
            <asp:Label ID="Label12" runat="server" Text="<%$Resources:Master, c_notes%>"></asp:Label>
        </td>
        <td colspan="2">
            <asp:TextBox ID="txt_notes" runat="server" Height="54px" TextMode="MultiLine" 
                Width="526px"></asp:TextBox>
        </td>
    </tr>
    <tr id="trtags" runat="server" align="<%$Resources:Master, align%>">
        <td runat="server" align="<%$Resources:Master, align%>">
            <asp:Label ID="Label13" runat="server" Text="<%$Resources:Master, c_tags%>"></asp:Label>
        </td>
        <td colspan="2">
            <asp:TextBox ID="txt_tags" runat="server" TextMode="MultiLine" Width="526px" 
                Height="54px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator26" runat="server" ControlToValidate="txt_tags"
                ErrorMessage="هذا الحقل يجب إدخاله" ValidationGroup="A"></asp:RequiredFieldValidator>
        </td>
        <td>
            <asp:Label ID="lblDeclaration" runat="server" Text="يرجى إدخال الكلمات الدالة مفصولة برمز (-) أو (،) فيما بينها كما بالمثال التالى كلمة دالة 1 - كلمة دالة 2"
                Font-Size="12px" ForeColor="Red" Width="100px"></asp:Label>
        </td>
    </tr>
    <tr id="trperiods" runat="server">
        <td class="style2">
            <asp:Label ID="Label14" runat="server" Text=" العصر الذي تتناوله/ ترتبط به المقالة:"></asp:Label>
        </td>
        <td colspan="2" dir="rtl" valign="top">
             <asp:CheckBoxList ID="chk_periods" DataTextField="title" DataValueField="id" runat="server"
                RepeatDirection="Horizontal" RepeatColumns="4" Width="100%">
            </asp:CheckBoxList>
        </td>
    </tr>
    <tr id="trpicture" runat="server">
        <td dir="rtl" rowspan="1" valign="top" align="right">
            <asp:Label ID="Label26" runat="server" Text="الصورة المرفقة مع الاستمارة   "></asp:Label>
        </td>
        <td dir="rtl" align="right" colspan="2">
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
        <td runat="server" align="<%$Resources:Master, align%>" rowspan="1" 
            valign="top" colspan="2">
            <asp:FileUpload ID="uploadfile" runat="server" Width="100%" />
        &nbsp;
        </td>
        <td runat="server" align="<%$Resources:Master, align%>">
            <asp:Label ID="labfile" runat="server" Text="Label" Visible="False" Font-Size="14px"
                ForeColor="Red"></asp:Label>
        </td>
    </tr>
    <tr>
        <td align="center" class="style2" dir="rtl" colspan="4">
            <asp:Button ID="Button1" runat="server" Text="حفظ تفاصيل الاستمارة" 
                OnClick="Button1_Click" OnClientClick="ValidateAndShowPopup()" ValidationGroup="A" />
                
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
