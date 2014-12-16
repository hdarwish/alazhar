<%@ Control Language="C#" AutoEventWireup="true" CodeFile="add_characters.ascx.cs"
    Inherits="masterpage_add_characters" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
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
    .style2
    {
        height: 27px;
        width: 390px;
    }
    .style3
    {
        width: 390px;
    }
    .style4
    {
        width: 142px;
    }
    .style8
    {
        height: 434px;
    }
    .style9
    {
        height: 26px;
    }
    .style10
    {
        width: 151px;
    }
</style>
<asp:HiddenField ID="content_type" runat="server" Value="" />
<asp:HiddenField ID="content_id" runat="server" Value="" />
<table cellpadding="0" style="width: 800px" border="0" cellspacing="5" runat="server"
    id="tblchar" dir="<%$Resources:Master, dir%>">
    <tr align="center">
        <td colspan="3" align="center">
            <asp:Label ID="lblerror" Visible="False" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr id="trpagetitle" runat="server" dir="<%$Resources:Master, dir%>">
        <td colspan="1" align="<%$Resources:Master, align%>">
            <asp:Label ID="Label2" runat="server" Text="<%$ Resources:Master, Lbl_character_head %>"
                Font-Bold="True"></asp:Label>
        </td>
        <%--<td align="left" visible="true" colspan="1">
        <asp:LinkButton ID="lnk" runat="server" OnClick ="lnk_Click" Text="عرض الاستمارة"></asp:LinkButton>
        </td>--%>
        <td align="left" visible="true" colspan="2" dir="rtl">
            <a href runat="server" id="id_href" target="_blank">عرض الاستمارة </a>
        </td>
    </tr>
    <tr id="trname" runat="server">
        <td nowrap dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
            <asp:Label ID="Label7" runat="server" Text="<%$ Resources:Master, Lbl_character_full_name %>"
                Font-Size="14px" margin-right="3px"></asp:Label>
        </td>
        <td colspan="2" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
            <asp:Label ID="txt_name" runat="server" ReadOnly="True" Font-Bold="True" Font-Size="14px"></asp:Label>
        </td>
    </tr>
    <tr id="trspecial" runat="server" dir="<%$Resources:Master, dir%>">
        <td dir="rtl" nowrap align="<%$ Resources:Master, align%>" runat="server">
            <asp:Label ID="Label4" runat="server" Text="<%$ Resources:Master, Labspecial %>"
                Font-Size="14px"></asp:Label>
        </td>
        <td colspan="2" align="<%$Resources:Master, align%>">
            <asp:CheckBox ID="chk_highlight" runat="server" Text="علي الموقع" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="chk_pano" runat="server" Text="علي بانوراما التراث" />
        </td>
    </tr>
    <tr id="trchartype" runat="server">
        <td nowrap align="right" dir="rtl">
            <asp:Label ID="Label5" runat="server" Text="نوع الشخصية" Font-Size="14px"></asp:Label>
        </td>
        <td colspan="1" align="right" dir="rtl" valign="top">
            <asp:RadioButtonList ID="rad_char_type" runat="server" RepeatDirection="Horizontal"
                DataTextField="title_ar" DataValueField="id">
            </asp:RadioButtonList>
        </td>
        <td colspan="1">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="rad_char_type" Font-Size="14px" ValidationGroup="A"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr id="trothername" runat="server">
        <td nowrap dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
            <asp:Label ID="Label6" runat="server" Text="<%$ Resources:Master, Lbl_character_nick_name %>"
                Font-Size="14px"></asp:Label>
        </td>
        <td colspan="1" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
            <asp:TextBox ID="txt_other_name" runat="server" Height="20px" Width="370px"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txt_other_name" Font-Size="14px" ValidationGroup="A"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr id="trtitles" runat="server">
        <td runat="server" nowrap dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
            <asp:Label ID="Label8" runat="server" Text=" <%$ Resources:Master, Lbl_character_Titles %>"
                Font-Size="14px"></asp:Label>
        </td>
        <td colspan="2" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
            <asp:TextBox ID="txt_titles" runat="server" Width="370px" Height="20px"></asp:TextBox>
        </td>
    </tr>
    <tr id="trhbirthdate" runat="server">
        <td nowrap align="right" dir="rtl" rowspan="1" valign="top">
            <asp:Label ID="Label9" runat="server" Text="تاريخ المولد" Font-Size="14px"></asp:Label>
        </td>
        <td colspan="1" dir="rtl" valign="top" align="right">
            <asp:TextBox ID="txt_hbirth_date" runat="server" Height="20px"></asp:TextBox>
            <asp:Label ID="Label11" runat="server" Text="هـ"></asp:Label>
            &nbsp;<asp:Label ID="lblError3" runat="server" Text="سنة-(يوم/ شهر /سنة)" ForeColor="Red"
                Font-Size="12px"></asp:Label>
        </td>
        <td align="right">
        </td>
    </tr>
    <tr id="trbirthdate" runat="server">
        <td>
        </td>
        <td nowrap align="right" dir="rtl" rowspan="1" valign="top">
            <asp:TextBox ID="txt_birth_date" runat="server" Height="20px"></asp:TextBox>
            <asp:Label ID="Label12" runat="server" Text="م"></asp:Label>
            &nbsp;<asp:Label ID="lblError4" runat="server" Text="سنة-(يوم/ شهر /سنة)" ForeColor="Red"
                Font-Size="12px"></asp:Label>
        </td>
        <td colspan="1" dir="rtl" align="right">
            &nbsp;
        </td>
    </tr>
    <tr id="trhdeathdate" runat="server">
        <td nowrap align="right" dir="rtl" rowspan="1" valign="top">
            <asp:Label ID="Label10" runat="server" Text="تاريخ الوفاة" Font-Size="14px"></asp:Label>
        </td>
        <td align="right" valign="top" dir="rtl">
            <asp:TextBox ID="txt_hdeath_date" runat="server" Height="20px"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text="هـ"></asp:Label>
            &nbsp;
            <asp:Label ID="lblError5" runat="server" Text="سنة-(يوم/ شهر /سنة)" ForeColor="Red"
                Font-Size="12px"></asp:Label>
        </td>
        <td dir="ltr" valign="top">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txt_hdeath_date" Font-Size="14px" ValidationGroup="A"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr id="trdeathdate" runat="server">
        <td>
        </td>
        <td nowrap align="right" dir="rtl" valign="top">
            <asp:TextBox ID="txt_death_date" runat="server" Height="20px"></asp:TextBox>
            <asp:Label ID="Label13" runat="server" Text="م"></asp:Label>
            &nbsp;
            <asp:Label ID="lblError6" runat="server" Text="سنة-(يوم/ شهر /سنة)" ForeColor="Red"
                Font-Size="12px"></asp:Label>
        </td>
        <td valign="top" dir="ltr">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txt_death_date" Font-Size="14px" ValidationGroup="A"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr align="<%$ Resources:Master, align%>" id="trdetails" runat="server">
        <td align="<%$ Resources:Master, align%>" runat="server" valign="top">
            <asp:Label ID="Label14" runat="server" Text="<%$ Resources:Master, Lbl_character_Abrief_description %>"
                Font-Size="14px"></asp:Label>
        </td>
        <td colspan="2" align="right">
            <FCKeditorV2:FCKeditor ID="txt_char_details" runat="server" BasePath="~/fckeditor/"
                Height="400px">
            </FCKeditorV2:FCKeditor>
        </td>
    </tr>
    <tr align="<%$ Resources:Master, align%>" runat="server" id="trbdetails">
        <td valign="top" align="<%$ Resources:Master, align%>" runat="server">
            <asp:Label ID="Label15" runat="server" Text="<%$ Resources:Master, Lbl_character_Birth_upbringing %>"
                Font-Size="14px"></asp:Label>
        </td>
        <td colspan="2" align="right">
            <FCKeditorV2:FCKeditor ID="txt_birth_details" runat="server" BasePath="~/fckeditor/"
                Height="400px">
            </FCKeditorV2:FCKeditor>
        </td>
    </tr>
    <tr id="trscientific" align="<%$ Resources:Master, align%>" runat="server">
        <td dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>" valign="top">
            <asp:Label ID="Label16" runat="server" Text="<%$ Resources:Master, Lbl_character_Educational_cultural %>"
                Font-Size="14px" Width="150"></asp:Label>
        </td>
        <td colspan="2" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
            <FCKeditorV2:FCKeditor ID="txt_scientific_life" runat="server" BasePath="~/fckeditor/"
                Height="400px">
            </FCKeditorV2:FCKeditor>
        </td>
    </tr>
    <tr id="trworklife" align="<%$ Resources:Master, align%>" runat="server">
        <td nowrap align="<%$ Resources:Master, align%>" runat="server" valign="top">
            <asp:Label ID="Label17" runat="server" Text="<%$ Resources:Master, Lbl_character_Posts_Jobs_occupied %>"
                Font-Size="14px"></asp:Label>
        </td>
        <td colspan="2" dir="rtl" align="right">
            <FCKeditorV2:FCKeditor ID="txt_working_life" runat="server" BasePath="~/fckeditor/"
                Height="400px">
            </FCKeditorV2:FCKeditor>
        </td>
    </tr>
    <tr align="right" id="tractivities" runat="server">
        <td dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>" valign="top">
            <asp:Label ID="Label18" runat="server" Text="<%$ Resources:Master, Lbl_character_social_cultural_activities%>"
                Font-Size="14px" Width="150"></asp:Label>
        </td>
        <td colspan="2" align="right">
            <FCKeditorV2:FCKeditor ID="txt_activities" runat="server" BasePath="~/fckeditor/"
                Height="400px">
            </FCKeditorV2:FCKeditor>
        </td>
    </tr>
    <tr align="<%$ Resources:Master, align%>" id="trawsma" runat="server">
        <td align="<%$ Resources:Master, align%>" runat="server" valign="top">
            <asp:Label ID="Label19" runat="server" Text="<%$ Resources:Master, Lbl_character_Awards%>"
                Width="150" Height="250px" Font-Size="14px"></asp:Label>
        </td>
        <td colspan="2" dir="rtl" align="right">
            <FCKeditorV2:FCKeditor ID="txt_awesma" runat="server" BasePath="~/fckeditor/" Height="400px">
            </FCKeditorV2:FCKeditor>
        </td>
    </tr>
    <tr id="trachieve" align="<%$ Resources:Master, align%>" runat="server">
        <td align="<%$ Resources:Master, align%>" runat="server" valign="top">
            <asp:Label ID="Label20" runat="server" Text="<%$ Resources:Master, Lbl_character_Achievements %>"
                Font-Size="14px"></asp:Label>
        </td>
        <td colspan="2" dir="rtl" align="right">
            <FCKeditorV2:FCKeditor ID="txt_achiev" runat="server" BasePath="~/fckeditor/" Height="400px">
            </FCKeditorV2:FCKeditor>
        </td>
    </tr>
    <tr id="trwhtwritten" align="<%$ Resources:Master, align%>" runat="server">
        <td align="<%$ Resources:Master, align%>" runat="server" nowrap valign="top">
            <asp:Label ID="Label21" runat="server" Text="<%$ Resources:Master, Lbl_character_said_about_him  %>"
                Font-Size="14px"></asp:Label>
        </td>
        <td colspan="2" dir="rtl" align="right">
            <FCKeditorV2:FCKeditor ID="txt_written_about" runat="server" BasePath="~/fckeditor/"
                Height="400px">
            </FCKeditorV2:FCKeditor>
        </td>
    </tr>
    <tr id="trnotes" align="<%$ Resources:Master, align%>" runat="server">
        <td nowrap dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>"
            valign="top">
            <asp:Label ID="Label22" runat="server" Text="<%$ Resources:Master, Lbl_character_Notes  %>"
                Font-Size="14px"></asp:Label>
        </td>
        <td colspan="2" dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>">
            <asp:TextBox ID="txt_notes" runat="server" TextMode="MultiLine" Width="100%" Height="54px"></asp:TextBox>
        </td>
    </tr>
    <tr id="trtags" align="<%$ Resources:Master, align%>" runat="server">
        <td align="<%$ Resources:Master, align%>" runat="server" nowrap valign="top">
            <asp:Label ID="Label23" runat="server" Text="<%$ Resources:Master, Lbl_character_keywords %> "
                Font-Size="14px"></asp:Label>
        </td>
        <td colspan="1" align="right">
            <asp:TextBox ID="txt_keywords" runat="server" Width="100%" TextMode="MultiLine" Height="60px"></asp:TextBox>
            <asp:Label ID="lblDeclaration" runat="server" Text="يرجى إدخال الكلمات الدالة مفصولة برمز (-) أو (،) فيما بينها كما بالمثال التالى كلمة دالة 1 - كلمة دالة 2"
                Font-Size="12px" ForeColor="Red" Width="100%"></asp:Label>
        </td>
        <td>
           
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txt_keywords" Font-Size="14px" ValidationGroup="A"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr align="right" id="trperiods" runat="server">
        <td align="right" nowrap dir="rtl" valign="top">
            <asp:Label ID="Label24" runat="server" Text="العصر الذي تنتمي إليه الشخصية" Height="30px"
                Font-Size="14px"></asp:Label>
        </td>
        <td colspan="1" dir="rtl" valign="top">
            <asp:CheckBoxList ID="chk_periods" runat="server" RepeatDirection="Horizontal"
                RepeatColumns="4" DataTextField="title" DataValueField="id" Height="30px" Width="100%">
            </asp:CheckBoxList>
        </td>
        <td dir="ltr">
          <%--  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="chk_periods" Font-Size="14px" ValidationGroup="A"></asp:RequiredFieldValidator>
      --%>  </td>
    </tr>
    <tr id="trimage" runat="server">
        <td dir="rtl" rowspan="1" valign="top" align="right">
            <asp:Label ID="Label26" runat="server" Text="الصورة المرفقة مع الاستمارة   " Font-Size="14px"></asp:Label>
        </td>
        <td dir="rtl" align="right">
            <asp:RadioButtonList ID="rblFormImage" runat="server" RepeatColumns="1" RepeatDirection="Horizontal"
                Width="100%">
                <asp:ListItem Value="1" Text="مرفقة (ورقية / إلكترونية)"></asp:ListItem>
                <asp:ListItem Value="2" Text="غير متاحة (سيتم توفيرها لاحقا)"></asp:ListItem>
                <asp:ListItem Value="0" Text="غير متاحة (استخدم الصورة الرمزية)"></asp:ListItem>
            </asp:RadioButtonList>
        </td>
        <td dir="ltr">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="rblFormImage" Font-Size="14px" ValidationGroup="A"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr runat="server" id="trcolectorname">
        <td dir="rtl" rowspan="1" valign="top" align="right">
            <asp:Label ID="Label3" runat="server" Text="اسم جامع بيانات الاستمارة  " Width="150px"
                Font-Size="14px"></asp:Label>
        </td>
        <td dir="rtl" rowspan="1" valign="top">
            <asp:TextBox ID="txtFormDataColectorName" runat="server" Width="100%" />
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txtFormDataColectorName" Font-Size="14px" ValidationGroup="A"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr runat="server" id="trrevisionname">
        <td dir="rtl" rowspan="1" valign="top" align="right">
            <asp:Label ID="Label25" runat="server" Text="اسم مراجع بيانات الاستمارة  " Width="155px"
                Font-Size="14px"></asp:Label>
        </td>
        <td dir="rtl" rowspan="1" valign="top">
            <asp:TextBox ID="txtFormDataRevisionName" runat="server" Width="100%" />
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txtFormDataRevisionName" Font-Size="14px" ValidationGroup="A"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr runat="server" id="file_tr">
        <td align="<%$ Resources:Master, align%>" rowspan="1" valign="top" >
            <asp:Label ID="Label27" runat="server" Text="<%$ Resources:Master,event_upload%> "
                Font-Size="14px"></asp:Label>
        </td>
        <td align="<%$ Resources:Master, align%>" rowspan="1" valign="top" >
            <%--<asp:Label ID="Label55" runat="server" Font-Size="14px" ForeColor="Red" Width="40%"></asp:Label>--%>
            <asp:FileUpload ID="uploadfile" runat="server" Width="58%" />
        </td>
        <td>
            <asp:Label ID="labfile" runat="server" Text="Label" Visible="False" Font-Size="14px"
                ForeColor="Red"></asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="3" align="center" dir="rtl">
            <asp:Button ID="Button1" runat="server" Text="حفظ تفاصيل الاستمارة" OnClick="Button1_Click"
                Font-Bold="True" Height="29px" Width="" ValidationGroup="A" OnClientClick="ValidateAndShowPopup()"/>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                SelectCommand="SELECT title_ar, id FROM char_types WHERE title_ar&lt;&gt; ' '">
            </asp:SqlDataSource>
        </td>
    </tr>
   
</table>
