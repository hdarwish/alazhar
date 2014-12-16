<%@ Control Language="C#" AutoEventWireup="true" CodeFile="add_books.ascx.cs" Inherits="masterpage_add_books" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<style type="text/css">
    .style1
    {
        height: 28px;
    }
</style>
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
<input id="doc_id" type="hidden" value="0" runat="server" />
<input id="id" type="hidden" runat="server" />
<asp:HiddenField ID="content_type" runat="server" />
<asp:HiddenField ID="content_id" runat="server" />
<table cellspacing="5" runat="server" dir="<%$Resources:Master, dir%>" id="tblbook">
    <tr id="trpagetitle" runat="server" align="<%$Resources:Master, align%>">
    <td runat="server" align="<%$Resources:Master, align%>">ملف الاستمارة</td>
        <td align="<%$Resources:Master, align%>" colspan="3" visible="true" runat="server" dir="<%$Resources:Master, dir%>">
            <a href runat="server" id="id_href" target="_blank">عرض الاستمارة </a>
        </td>
    </tr>
    <tr align="<%$Resources:Master, align%>" id="trtitle" runat="server">
        <td align="<%$Resources:Master, align%>" >
            <asp:Label ID="Label19" runat="server" Text="<%$Resources:Master, Lbl_book_Title %>"></asp:Label>
           
        </td>
	<td align="<%$Resources:Master, align%>" runat="server" colspan="2">
	<asp:TextBox ID="txt_title" runat="server" Font-Size="14px" Font-Bold="true" Height="19px" Width="600px"></asp:TextBox>	
	<asp:RequiredFieldValidator ControlToValidate="txt_title" ValidationGroup="A" runat="server" ErrorMessage="هذا الحقل يجب إدخاله" ID="rfv1"></asp:RequiredFieldValidator>
	</td>
    </tr>
    <tr id="trtitletype" align="<%$Resources:Master, align%>" runat="server">
        <td align="<%$Resources:Master, align%>" runat="server">
            <asp:Label ID="Label2" runat="server" Text="نوع/مصدر العنوان :"></asp:Label>
            &nbsp;&nbsp;
        </td>
        <td align="<%$Resources:Master, align%>" runat="server" colspan="2">
            <%--<asp:DropDownList ID="drop_type" runat="server" DataTextField="author_type" DataValueField="id"
                Width="140px">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="drop_type"
                ErrorMessage="هذا الحقل يجب إدخاله" ValidationGroup="A"></asp:RequiredFieldValidator>--%>
                 <asp:Label ID="Label10" runat="server" Text="من صفحة العنوان : " 
                Width="100px"></asp:Label>
            <asp:TextBox ID="txtFromTitle" runat="server" Height="19px" Width="350px"></asp:TextBox><br />
            <asp:Label ID="Label16" runat="server" Text="من المقدمة : " Width="100px"></asp:Label>
            <asp:TextBox ID="txtFromHeader" runat="server" Height="19px" Width="350px"></asp:TextBox><br />
        </td>
    </tr>
    <tr align="<%$Resources:Master, align%>" runat="server">
        <td colspan="3" dir="<%$Resources:Master, dir%>" runat="server" 
            align="<%$Resources:Master, align%>">
            <asp:Label ID="lblerror" runat="server" Text="Label" Visible="false"></asp:Label>
        </td>
    </tr>
    <tr dir="<%$Resources:Master, dir%>" id="trspecial" runat="server">
        <td align="<%$Resources:Master, align%>" runat="server" class="style1">
            <asp:Label ID="Label1" runat="server" Text="<%$Resources:Master, Labspecial%>"></asp:Label>
        </td>
        <td colspan="2" align="<%$Resources:Master, align%>" runat="server" 
            class="style1">
            
            <asp:CheckBox ID="chk_site" runat="server" Text="علي الموقع" />
            <asp:CheckBox ID="chk_pan" runat="server" Text="علي البانوراما" />
            &nbsp;
        </td>
    </tr>
    <tr id="trlang" runat="server" align="<%$Resources:Master, align%>">
        <td align="<%$Resources:Master, align%>" runat="server">
            <asp:Label ID="Label6" runat="server" Text="لغة الكتاب:" Font-Bold="False"></asp:Label>
        </td>
        <td align="<%$Resources:Master, align%>" runat="server" colspan="2" width="300">
            <asp:DropDownList ID="drop_lang" runat="server" AutoPostBack="false" DataValueField="id"
                DataTextField="title_ar"  Width="130px">
            </asp:DropDownList>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator24" runat="server" ControlToValidate="drop_lang"
                ErrorMessage="هذا الحقل يجب إدخاله" ValidationGroup="A" InitialValue="0" Display="Dynamic"> </asp:RequiredFieldValidator>
    </td>
    </tr>
    <tr align="<%$Resources:Master, align%>" runat="server" id="trpublisher">
        <td rowspan="4" align="<%$Resources:Master, align%>" runat="server" valign="top"
            nowrap="">
            <asp:Label ID="Label3" runat="server" Text="<%$ Resources:Master, Lbl_book_Publication_data %>"
                Font-Bold="False"></asp:Label>
        </td>
        <td align="<%$Resources:Master, align%>" runat="server" colspan="2">
            <asp:Label ID="Label27" runat="server" Text="<%$Resources:Master, Lbl_book_Publication_Place %>"></asp:Label>
            <asp:TextBox ID="txt_plocation" runat="server" Height="19px" Width="131px"></asp:TextBox>
        </td>
    </tr>
    <tr align="<%$Resources:Master, align%>" runat="server" id="trpublisher2">
        <td align="<%$Resources:Master, align%>" runat="server" colspan="2">
            <asp:Label ID="Label4" runat="server" Text="<%$Resources:Master, Lbl_book_Publication_Publisher %>"></asp:Label>
            <asp:TextBox ID="txt_publisher" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr id="trdate" align="<%$Resources:Master, align%>" runat="server">
        <td align="<%$Resources:Master, align%>" runat="server" colspan="2" nowrap="">
            <asp:Label ID="Label17" runat="server" Text="<%$Resources:Master, Lbl_book_Publication_year %>"> </asp:Label>
            <asp:TextBox ID="txt_hdate" runat="server" Height="21px" Width="133px"></asp:TextBox>
            
            <asp:Label ID="Label18" runat="server" Text="<%$Resources:Master, timeline_h%>"></asp:Label>
        </td>
    </tr>
    <tr id="trdate2" align="<%$Resources:Master, align%>" runat="server">
        <td align="<%$Resources:Master, align%>" runat="server" colspan="3" nowrap="">
            <asp:TextBox ID="txt_date" runat="server" Height="20px" Width="164px"></asp:TextBox>
            
            <asp:Label ID="Label24" runat="server" Text="<%$Resources:Master, timeline_m%>"></asp:Label>
        </td>
    </tr>
    <tr align="<%$Resources:Master, align%>" runat="server" id="trseries" dir="<%$Resources:Master, dir %>">
        <td runat="server" rowspan="2" nowrap="">
            <asp:Label ID="Label56" runat="server" Text="<%$ Resources:Master, Lbl_book_Series %>"
                Font-Bold="False"></asp:Label>
        </td>
        <td align="<%$Resources:Master, align%>" runat="server" colspan="2">
            <asp:Label ID="Label26" runat="server" Text="<%$Resources:Master, Lbl_book_Series_name %>"></asp:Label>
            <asp:TextBox ID="txt_series" runat="server" Width="152px"></asp:TextBox>
        </td>
    </tr>
    <tr align="<%$Resources:Master, align%>" runat="server" id="trseries2">
        <td align="<%$Resources:Master, align%>" runat="server" colspan="2">
            <asp:Label ID="Label7" runat="server" Text="<%$Resources:Master, Lbl_book_Its_number_series %>"></asp:Label>
            <asp:TextBox ID="txt_series_no" runat="server" Width="131px" Height="22px"></asp:TextBox>
        </td>
    </tr>
    <tr align="<%$Resources:Master, align%>" runat="server" id="trpublishno">
        <td rowspan="4" align="<%$Resources:Master, align%>" runat="server" valign="top">
            <asp:Label ID="Label8" runat="server" Text="الطبعة والترقيم والأجزاء:" Font-Bold="False"></asp:Label>
        </td>
        <td align="<%$Resources:Master, align%>" runat="server" colspan="2">
            <asp:Label ID="Label28" runat="server" Text="رقم الطبعة:"></asp:Label>
            <asp:TextBox ID="txt_publish_no" runat="server" Height="21px" Width="165px"></asp:TextBox>
        </td>
    </tr>
    <tr align="<%$Resources:Master, align%>" runat="server" id="trpublishno2">
        <td align="<%$Resources:Master, align%>" runat="server" colspan="2">
            <asp:Label ID="Label5" runat="server" Text="الصفحات:"></asp:Label>
            <asp:TextBox ID="txt_from" runat="server" Width="168px" Height="19px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator27" runat="server" ControlToValidate="txt_from"
                ErrorMessage="هذا الحقل يجب إدخاله" ValidationGroup="A"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr id="trfolderno" align="<%$Resources:Master, align%>" runat="server">
        <td align="<%$Resources:Master, align%>" runat="server" colspan="2">
            <asp:Label ID="Label9" runat="server" Text="عدد المجلدات:"></asp:Label>
            <asp:TextBox ID="txt_folder_no" Width="148px" runat="server" Height="22px"></asp:TextBox>
        </td>
    </tr>
    <tr id="trfolderno2" align="<%$Resources:Master, align%>" runat="server">
        <td align="<%$Resources:Master, align%>" runat="server" colspan="1">
            <asp:Label ID="Label11" runat="server" Text="عدد الأجزاء:"></asp:Label>
            <asp:TextBox ID="txt_createrno" runat="server" Width="149px"></asp:TextBox>
        </td>
        <td align="<%$Resources:Master, align%>" runat="server">
            &nbsp;
        </td>
    </tr>
    <tr id="trorg" align="<%$Resources:Master, align%>" runat="server">
        <td rowspan="3" valign="top" align="<%$Resources:Master, align%>" runat="server"
            nowrap="">
            <asp:Label ID="Label29" runat="server" Text="<%$ Resources:Master, Lbl_document_Place_reservation %>"
                Font-Bold="False"></asp:Label>
        </td>
        <td align="<%$Resources:Master, align%>" runat="server" colspan="2" nowrap="">
            <asp:Label ID="Label30" runat="server" Text="<%$Resources:Master, Lbl_document_Place_reservation_name %>"></asp:Label>
            &nbsp;<asp:TextBox ID="txt_org" runat="server" Height="22px" Width="130px"></asp:TextBox>
        </td>
    </tr>
    <tr id="trorg2" align="<%$Resources:Master, align%>" runat="server">
        <td align="<%$Resources:Master, align%>" runat="server" colspan="2">
            <asp:Label ID="Label31" runat="server" Text="<%$Resources:Master, Lbl_document_Place_reservation_country %>"></asp:Label>
            <asp:TextBox ID="txt_country" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr id="trcity" align="<%$Resources:Master, align%>" runat="server">
        <td align="<%$Resources:Master, align%>" runat="server" colspan="2">
            <asp:Label ID="Label12" runat="server" Text="<%$Resources:Master, Lbl_document_Place_reservation_City %>"></asp:Label>
            &nbsp;<asp:TextBox ID="txt_city" runat="server" Height="22px" Width="120px"></asp:TextBox>
        </td>
    </tr>
    <tr id="trno" align="<%$Resources:Master, align%>" runat="server" valign="top">
        <td rowspan="4" align="<%$Resources:Master, align%>" runat="server">
            <asp:Label ID="Label32" runat="server" Text=" رقم الحفظ داخل الجهة:"></asp:Label>
        </td>
        <td align="<%$Resources:Master, align%>" runat="server">
            <asp:Label ID="Label34" runat="server" Text=" رقم عام:"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_genno" runat="server" Height="19px" Width="152px"></asp:TextBox>
        </td>
        <td align="<%$Resources:Master, align%>" runat="server">
            &nbsp;
        </td>
    </tr>
    <tr id="trno2" align="<%$Resources:Master, align%>" runat="server">
        <td align="<%$Resources:Master, align%>" runat="server">
            <asp:Label ID="Label35" runat="server" Text=" رقم خاص:"></asp:Label>
            <asp:TextBox ID="txt_specifno" runat="server" Height="21px" Width="153px"></asp:TextBox>
        </td>
        <td align="<%$Resources:Master, align%>" runat="server">
            &nbsp;
        </td>
    </tr>
    <tr id="trartno" align="<%$Resources:Master, align%>" runat="server">
        <td align="<%$Resources:Master, align%>" runat="server">
            <asp:Label ID="Label36" runat="server" Text="الفن  :"></asp:Label>
            &nbsp;
            <asp:TextBox ID="txt_art" runat="server" Height="18px" Width="172px"></asp:TextBox>
        </td>
        <td align="<%$Resources:Master, align%>" runat="server">
            &nbsp;
        </td>
    </tr>
    <tr id="trartno2" align="<%$Resources:Master, align%>" runat="server">
        <td align="<%$Resources:Master, align%>" runat="server">
            <asp:Label ID="Label37" runat="server" Text="المكتبة الخاصة :"></asp:Label>
            <asp:TextBox ID="txt_library" runat="server" Height="20px" Width="117px"></asp:TextBox>
        </td>
        <td align="<%$Resources:Master, align%>" runat="server">
            &nbsp;
        </td>
    </tr>
    <tr id="trnotes" align="<%$Resources:Master, align%>" runat="server">
        <td align="<%$Resources:Master, align%>" runat="server">
            <asp:Label ID="Label33" runat="server" Text=" <%$Resources:Master, lbl_manuscript_notes %>"></asp:Label>
        </td>
        <td align="<%$Resources:Master, align%>" runat="server" colspan="2">
            <asp:TextBox ID="TextBox3" runat="server" Height="63px" TextMode="MultiLine" Width="496px"></asp:TextBox>
        </td>
    </tr>
    <tr id="trtags" align="<%$Resources:Master, align%>" runat="server">
        <td align="<%$Resources:Master, align%>" runat="server">
            <asp:Label ID="Label13" runat="server" Text=" <%$Resources:Master, lbl_Recording_keyword %>"></asp:Label>
        </td>
        <td colspan="1" align="<%$Resources:Master, align%>" runat="server">
            <asp:TextBox ID="txt_tags" runat="server" Width="100%" Height="50px" TextMode="MultiLine" ></asp:TextBox>
        </td>
        <td align="<%$Resources:Master, align%>" runat="server">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator26" runat="server" ControlToValidate="txt_tags"
                ErrorMessage="هذا الحقل يجب إدخاله" ValidationGroup="A"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lblDeclaration" runat="server" Font-Size="12px" ForeColor="Red" Text="يرجى إدخال الكلمات الدالة مفصولة برمز (-) أو (،) فيما بينها كما بالمثال التالى كلمة دالة 1 - كلمة دالة 2"
                Width="100px"></asp:Label>
        </td>
    </tr>
    <tr id="trperiods" align="<%$Resources:Master, align%>" runat="server">
        <td colspan="3" align="<%$Resources:Master, align%>" runat="server">
            <asp:Label ID="Label14" runat="server" Text=" العصر الذي يتناوله/ يرتبط به الكتاب:"></asp:Label>
        </td>
    </tr>
    <tr id="trperiods2" runat="server" align="<%$Resources:Master, align%>">
        <td colspan="2" align="<%$Resources:Master, align%>" runat="server">
            <asp:CheckBoxList ID="chk_periods" runat="server" DataValueField="id" DataTextField="title"
                RepeatDirection="Horizontal" RepeatColumns="4" Width="100%">
            </asp:CheckBoxList>
        </td>
        <td align="<%$Resources:Master, align%>" runat="server">
           <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator28" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="chk_periods" Font-Size="14px" ValidationGroup="A"></asp:RequiredFieldValidator>--%>
        </td>
    </tr>
    <tr id="trpicture" align="<%$Resources:Master, align%>" runat="server">
        <td rowspan="1" valign="top" align="<%$Resources:Master, align%>" runat="server">
            <asp:Label ID="Label15" runat="server" Text="الصورة المرفقة مع الاستمارة   "></asp:Label>
        </td>
        <td align="<%$Resources:Master, align%>" runat="server">
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
    </tr>
    <tr id="trcolectorname" runat="server">
        <td dir="rtl" rowspan="1" valign="top" align="right">
            <asp:Label ID="Label38" runat="server" Text="اسم جامع بيانات الاستمارة  " Width="150px"
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
    <tr id="trrevisionname" runat="server">
        <td dir="rtl" rowspan="1" valign="top" align="right">
            <asp:Label ID="Label39" runat="server" Text="اسم مراجع بيانات الاستمارة  " Width="155px"
                Height="26px"></asp:Label>
        </td>
        <td align="<%$Resources:Master, align%>" runat="server" rowspan="1" valign="top">
            <asp:TextBox ID="txtFormDataRevisionName" runat="server" />
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txtFormDataRevisionName" Font-Size="14px" ValidationGroup="A"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr runat="server" id="file_tr" align="<%$Resources:Master, align%>">
        <td rowspan="1" valign="top" align="<%$Resources:Master, align%>" runat="server">
            <asp:Label ID="Label40" runat="server" Text="<%$Resources:Master, Topics_upload%> "></asp:Label>
        </td>
        <td rowspan="1" valign="top" align="<%$Resources:Master, align%>" runat="server">
            <asp:FileUpload ID="uploadfile" runat="server" />
        </td>
        <td>
            
            <asp:Label ID="labfile" runat="server" Text="Label" Visible="False" Font-Size="14px"
                ForeColor="Red"></asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="3" dir="rtl" align="center">
            <asp:Button ID="Button1" runat="server" Text="حفظ تفاصيل الاستمارة" OnClick="Button1_Click"
                ValidationGroup="A" OnClientClick="ValidateAndShowPopup()"/>
        </td>
    </tr>
    <tr>
        <td width="30px">
            
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                SelectCommand="select  author_role  ,id from dbo.authors_role order by ltrim(author_role) ">
            </asp:SqlDataSource>
        </td>
        <td width="30px">
           
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                SelectCommand="SELECT [id], [author_type] FROM [author_type]"></asp:SqlDataSource>
        </td>
    </tr>
</table>
