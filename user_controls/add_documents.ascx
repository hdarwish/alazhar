<%@ Control Language="C#" AutoEventWireup="true" CodeFile="add_documents.ascx.cs"
    Inherits="masterpage_add_documents" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<style type="text/css">
    .style1
    {
        width: 6px;
    }
</style>
<script type="text/javascript">
  function ShowPopup() {
      alert(" لم يتم حفظ تفاصيل الاستمارة هناك حقول لم يتم ادخالها ");
  }

  function ValidateAndShowPopup() {
      if (Page_ClientValidate('d') == false) {
        ShowPopup();
    }
  }
</script>
<input id="doc_id" type="hidden" value="0" runat="server" />
<asp:HiddenField ID="content_id" runat="server" />
<asp:HiddenField ID="content_type" runat="server" />
<table style="width: 700px" cellspacing="0" runat="server" dir="<%$Resources:Master, dir%>"
    id="tbldoc">
    <tr align="<%$Resources:Master, align%>" id="trpagetitle" runat="server">
        <td colspan="3" align="<%$Resources:Master, align%>" runat="server">
            <asp:Label ID="lblpagetitle" runat="server" Text="بيانات الوثائق" Visible="False"></asp:Label>
        </td>
        <td colspan="1" align="<%$Resources:Master, align%>" runat="server" 
            class="style1">
            <a href runat="server" id="id_href" visible="false" target="_blank">عرض الاستمارة
            </a>
        </td>
    </tr>
    <tr align="<%$Resources:Master, align%>" runat="server">
        <td colspan="3" align="<%$Resources:Master, align%>" runat="server">
            <asp:Label ID="lblerror" runat="server" Text="Label" Visible="false"></asp:Label>
        </td>
    </tr>
    <tr align="<%$Resources:Master, align%>" id="trtitle" runat="server">
        <td align="<%$Resources:Master, align%>" runat="server" nowrap="">
            <asp:Label ID="Label2" runat="server" Text="<%$ Resources:Master, Lbl_document_Title %>"></asp:Label>
        </td>
        <td align="<%$Resources:Master, align%>" colspan="2" runat="server">
            <asp:TextBox ID="txt_art_title" runat="server" TextMode="MultiLine" Font-Size="14px" Font-Bold="True" Height="60px" Width="600px"></asp:TextBox>
             <asp:RequiredFieldValidator ControlToValidate="txt_art_title" ValidationGroup="d" runat="server" ErrorMessage="هذا الحقل يجب إدخاله" ID="rfv1"></asp:RequiredFieldValidator>
	
        </td>
    </tr>
    <tr align="<%$Resources:Master, align%>" id="trtitle2" runat="server">
        <td align="<%$Resources:Master, align%>" runat="server" nowrap="">
            <asp:Label ID="Label32" runat="server" 
                Text="عنوان وثيقة أخر"></asp:Label>
        </td>
        <td align="<%$Resources:Master, align%>" colspan="2" runat="server">
            <asp:TextBox ID="txt_othertitle" runat="server" Width="294px"></asp:TextBox>
        </td>
    </tr>
    <tr id="trspecial" runat="server" dir="<%$Resources:Master, dir%>">
        <td align="<%$Resources:Master, align%>" runat="server">
            <asp:Label ID="Label1" runat="server" Text="<%$Resources:Master, Labspecial%>"></asp:Label>
        </td>
        <td colspan="2" align="<%$Resources:Master, align%>" runat="server">
            <asp:CheckBox ID="chk_pan" runat="server" Text="علي البانوراما" />
            <asp:CheckBox ID="chk_site" runat="server" Text="علي الموقع" />
            &nbsp;
        </td>
    </tr>
    <tr align="right" id="trpublish" runat="server">
        <td dir="rtl">
            <asp:Label ID="Label16" runat="server" Text="حالة النشر:"></asp:Label>
        </td>
        <td align="right" dir="rtl">
            <asp:RadioButtonList runat="server" ID="rad_publish" RepeatDirection="Horizontal">
                <asp:ListItem Text="وثيقة منشورة" Value="0"></asp:ListItem>
                <asp:ListItem Text="وثيقة غير منشورة" Value="1" Selected="True"></asp:ListItem>
            </asp:RadioButtonList>
        </td>
        <td align="right" colspan="1" dir="rtl">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="rad_publish" Font-Size="14px" ValidationGroup="d"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr align="<%$Resources:Master, align%>" id="trcreater" runat="server">
        <td align="<%$Resources:Master, align%>" nowrap="">
            <asp:Label ID="Label3" runat="server" Text="<%$Resources:Master, Lbl_document_Source%>"></asp:Label>
        </td>
        <td colspan="2" align="<%$Resources:Master, align%>">
            <asp:TextBox ID="txt_creater" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr id="trcreaterno" runat="server" align="<%$Resources:Master, align%>">
        <td align="<%$Resources:Master, align%>" nowrap="">
            <asp:Label ID="Label4" runat="server" Text="<%$Resources:Master, Lbl_document_Source_no%>"></asp:Label>
        </td>
        <td colspan="2" align="<%$Resources:Master, align%>">
            <asp:TextBox ID="txt_creater_no" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr runat="server" id="trdate">
        <td dir="rtl" align="right">
            <asp:Label ID="Label17" runat="server" Text="تاريخ الإنشاء"></asp:Label>
        </td>
        <td align="right" colspan="2">
            <table>
                <tr align="right">
                    <td colspan="1" dir="rtl" align="right">
                        <asp:TextBox ID="txt_hdate" runat="server"></asp:TextBox>
                        <asp:Label ID="Label18" runat="server" Text="هـ"></asp:Label>
                        <asp:Label ID="lblError2" runat="server" Text="سنة -(يوم/ شهر / سنة)" ForeColor="Red"
                            Font-Size="12px"></asp:Label>
                    </td>
                    <td>
                    </td>
                    <td colspan="1" dir="rtl" align="right">
                        <asp:TextBox ID="txt_date" runat="server"></asp:TextBox>
                        <asp:Label ID="Label19" runat="server" Text="م"></asp:Label>
                        <asp:Label ID="lblError3" runat="server" Text="سنة-(يوم/ شهر /سنة)" ForeColor="Red"
                            Font-Size="12px"></asp:Label>
                    </td>
                    <td>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr runat="server" id="trsaveorg" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
        <td rowspan="4" align="<%$Resources:Master, align%>" valign="top" runat="server"
            nowrap="">
            <asp:Label ID="Label20" runat="server" Text="<%$Resources:Master, Lbl_document_Place_reservation%>"
                Font-Bold="False"></asp:Label>
        </td>
    </tr>
    <tr align="<%$Resources:Master, align%>" runat="server" dir="<%$Resources:Master, dir%>">
        <td align="<%$Resources:Master, align%>" runat="server" dir="<%$Resources:Master, dir%>">
            <asp:Label ID="Label21" runat="server" Text="<%$Resources:Master, Lbl_document_Place_reservation_name%>"></asp:Label>
            &nbsp;<asp:TextBox ID="txt_org" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txt_org" Font-Size="14px" ValidationGroup="d"></asp:RequiredFieldValidator>
        </td>
        <td align="<%$Resources:Master, align%>" runat="server" dir="<%$Resources:Master, dir%>">
            <asp:Label ID="Label22" runat="server" Text="<%$Resources:Master, Lbl_document_Place_reservation_country%>"></asp:Label>
            <asp:TextBox ID="txt_country" runat="server"></asp:TextBox>
        </td>
        <td align="<%$Resources:Master, align%>" runat="server" 
            dir="<%$Resources:Master, dir%>" class="style1">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txt_country" Font-Size="14px" ValidationGroup="d"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr align="<%$Resources:Master, align%>" runat="server" dir="<%$Resources:Master, dir%>">
        <td align="<%$Resources:Master, align%>" runat="server" dir="<%$Resources:Master, dir%>">
            <asp:Label ID="Label23" runat="server" Text="<%$Resources:Master, Lbl_document_Place_reservation_City%>"></asp:Label>
            &nbsp;<asp:TextBox ID="txt_city" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txt_city" Font-Size="14px" ValidationGroup="d"></asp:RequiredFieldValidator>
        </td>
        <td align="<%$Resources:Master, align%>" runat="server" class="style4">
            <asp:Label ID="Label24" runat="server" Text="<%$Resources:Master, Lbl_document_Place_reservation_Bookshelving_no %>"></asp:Label>
            <asp:TextBox ID="txt_save_no" runat="server"></asp:TextBox>
        </td>
        <td align="<%$Resources:Master, align%>" runat="server" class="style1">
          
        </td>
    </tr>
    <tr align="<%$Resources:Master, align%>" runat="server" dir="<%$Resources:Master, dir%>">
        <td align="<%$Resources:Master, align%>" colspan="1" valign="top" 
            runat="server">
            <asp:Label ID="Label25" runat="server" Text="<%$Resources:Master, Lbl_document_Place_reservation_notes %>"></asp:Label>
            <asp:TextBox ID="txt_org_notes" runat="server" TextMode="MultiLine" 
                Width="450px"  colspan="4"
                Height="55px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
    </tr>
    <tr align="right" runat="server" id="trmaterial">
        <td dir="rtl" colspan="1" align="right">
            <asp:Label ID="Label26" runat="server" Text=" الشكل المادي:"></asp:Label>
        </td>
        <td colspan="2" align="right">
            <table cellpadding="1" cellspacing="2" dir="rtl">
                <tr align="right">
                    <td align="right" dir="rtl">
                        <asp:DropDownList ID="drop_material" runat="server" DataTextField="title_ar" DataValueField="id"
                            Height="21px" Width="136px" 
                            OnSelectedIndexChanged="drop_material_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td colspan="2" dir="rtl" align="right">
                        &nbsp;
                    </td>
                    <td>
                        <asp:Label ID="lblError4" runat="server" ForeColor="Red" Font-Size="13px" Visible="False"></asp:Label>
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr align="right" runat="server" id="trdocstype">
        <td align="right" dir="rtl">
            <asp:Label ID="Label27" runat="server" Text=" مضمون الوثيقة:"></asp:Label>
        </td>
        <td align="right" colspan="2">
            <table cellpadding="1" cellspacing="2" dir="rtl">
                <tr>
                    <td align="right" dir="rtl">
                        <asp:DropDownList ID="drop_docstype" runat="server" DataTextField="title_ar" DataValueField="id"
                            Height="20px" Width="136px" 
                            OnSelectedIndexChanged="drop_docstype_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td colspan="2" dir="rtl">
                        &nbsp;</td>
                    <td>
                        <asp:Label ID="lblError5" runat="server" ForeColor="Red" Font-Size="13px" Visible="False"></asp:Label>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr align="right" runat="server" id="trlang">
        <td align="right" dir="rtl">
            <asp:Label ID="Label6" runat="server" Text="لغة الوثيقة:"></asp:Label>
        </td>
        <td>
            <table cellpadding="1" cellspacing="2" dir="rtl">
                <tr>
                    <td align="right" dir="rtl">
                        <asp:DropDownList ID="drop_lang" runat="server" DataValueField="id"
                            DataTextField="title_ar" Height="20px" Width="136px" 
                            OnSelectedIndexChanged="drop_lang_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td colspan="2" align="right" dir="rtl">
                        &nbsp;</td>
                    <td dir="rtl" colspan="1">
                        <asp:Label ID="lblError6" runat="server" ForeColor="Red" Font-Size="13px" Visible="False"></asp:Label>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr runat="server" id="trsum">
        <td align="right" dir="rtl" colspan="1">
            <asp:Label ID="Label28" runat="server" Text="الوثيقة ضمن مجموع:"></asp:Label>
        </td>
        <td align="right" colspan="1" dir="rtl">
            <asp:CheckBox ID="CheckBox1" runat="server" />
        </td>
    </tr>
    <tr align="right" runat="server" id="trpageno">
        <td align="right" dir="rtl">
            <asp:Label ID="Label5" runat="server" Text=" أرقام الصفحات التي تشغلها "></asp:Label>
        </td>
        <td>
            <table>
                <tr>
                    <td align="right" dir="rtl">
                        <asp:TextBox ID="txt_no" runat="server" Width="21px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                            ControlToValidate="txt_no" Font-Size="14px" ValidationGroup="d"></asp:RequiredFieldValidator>
                        <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender2" runat="server" FilterType="Custom"
                            TargetControlID="txt_no" ValidChars="0123456789/\">
                        </cc1:FilteredTextBoxExtender>
                    </td>
                    <td align="right" dir="rtl">
                        من&nbsp;<asp:TextBox ID="txt_from" runat="server" Width="23px"></asp:TextBox>
                    </td>
                    <td align="right" dir="rtl">
                        &nbsp;<asp:Label ID="Label31" runat="server" Text="إلي"></asp:Label>
                        &nbsp;<asp:TextBox ID="txt_to" runat="server" Width="21px"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr runat="server" id="trnotes" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
        <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" runat="server">
            <asp:Label ID="Label12" runat="server" Text="<%$Resources:Master, lbl_Recording_notes %>"></asp:Label>
        </td>
        <td colspan="1" align="<%$Resources:Master, align%>" runat="server" dir="<%$Resources:Master, dir%>">
            <asp:TextBox ID="txt_notes" runat="server" TextMode="MultiLine" Width="100%" Height="50px"></asp:TextBox>
        </td>
    </tr>
    <tr align="<%$Resources:Master, align%>" runat="server" id="trtags">
        <td valign="top" align="<%$Resources:Master, align%>">
            <asp:Label ID="Label13" runat="server" Text="<%$Resources:Master, lbl_Recording_keyword %>"></asp:Label>
        </td>
        <td colspan="1" align="<%$Resources:Master, align%>" valign="top">
            <asp:TextBox ID="txt_tags" runat="server" Width="100%" Height="50px" TextMode="MultiLine"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txt_tags" Font-Size="14px" ValidationGroup="d"></asp:RequiredFieldValidator>
        </td>
        <td dir="<%$Resources:Master, dir%>" valign="top" align="<%$Resources:Master, align%>">
         &nbsp;&nbsp;
            <asp:Label ID="lblDeclaration" runat="server" Text="يرجى إدخال الكلمات الدالة مفصولة برمز (-) أو (،) فيما بينها كما بالمثال التالى كلمة دالة 1 - كلمة دالة 2"
                Font-Size="12px" ForeColor="Red" Width="100px"></asp:Label>
        </td>
    </tr>
    <tr align="right" runat="server" id="trperiods">
        <td align="right" colspan="3" dir="rtl">
            <asp:Label ID="Label14" runat="server" 
                Text=" العصر الذي يتناوله/ يرتبط به الوثيقة:"></asp:Label>
        </td>
    </tr>
    <tr runat="server" id="trperiods2">
        <td colspan="3" dir="rtl" align="right">
            <asp:CheckBoxList ID="chk_periods" runat="server" RepeatDirection="Horizontal"
                RepeatColumns="4" DataTextField="title" DataValueField="id" Width="100%">
            </asp:CheckBoxList>
        </td>
        <td class="style1">
           <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator24" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="chk_periods" Font-Size="14px" ValidationGroup="d"></asp:RequiredFieldValidator>--%>
        </td>
    </tr>
    <tr runat="server" id="trpicture">
        <td dir="rtl" rowspan="1" valign="top" align="right" colspan="1">
            <asp:Label ID="Label11" runat="server" Text="الصورة المرفقة مع الاستمارة   " Width="150px"></asp:Label>
        </td>
        <td dir="rtl" align="right" colspan="1">
            <asp:RadioButtonList ID="rblFormImage" runat="server" RepeatColumns="1" RepeatDirection="Horizontal"
                Width="100%">
                <asp:ListItem Text="مرفقة (ورقية / إلكترونية)" Value="1"></asp:ListItem>
                <asp:ListItem Text="غير متاحة (سيتم توفيرها لاحقا)" Value="2" Selected="True"></asp:ListItem>
                <asp:ListItem Text="غير متاحة (استخدم الصورة الرمزية)" Value="3"></asp:ListItem>
            </asp:RadioButtonList>
        </td>
        <td align="right" dir="rtl">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="rblFormImage" Font-Size="14px" ValidationGroup="d"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr runat="server" id="trcolectorname">
        <td dir="rtl" rowspan="1" valign="top" align="right">
            <asp:Label ID="Label15" runat="server" Text="اسم جامع بيانات الاستمارة  " Height="26px"></asp:Label>
        </td>
        <td dir="rtl" rowspan="1" valign="top" align="right">
            <asp:TextBox ID="txtFormDataColectorName" runat="server" Width="100%" />
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txtFormDataColectorName" Font-Size="14px" ValidationGroup="d"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr runat="server" id="trrevisionname">
        <td dir="rtl" rowspan="1" valign="top" align="right">
            <asp:Label ID="Label29" runat="server" Text="اسم مراجع بيانات الاستمارة  " Height="26px"></asp:Label>
        </td>
        <td dir="rtl" rowspan="1" valign="top" align="right">
            <asp:TextBox ID="txtFormDataRevisionName" runat="server" Width="100%" />
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txtFormDataRevisionName" Font-Size="14px" ValidationGroup="d"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr runat="server" id="file_tr" align="<%$Resources:Master, align%>">
        <td dir="<%$Resources:Master, dir%>" rowspan="1" valign="top" align="<%$Resources:Master, align%>">
            <asp:Label ID="Label30" runat="server" Text="<%$Resources:Master,event_upload%>"></asp:Label>
        </td>
        <td  valign="top"  runat="server"  align="<%$Resources:Master, align%>">
        <%--<asp:Label ID="Label55" runat="server" Font-Size="14px" ForeColor="Red"></asp:Label>--%>
            <asp:FileUpload ID="uploadfile" runat="server" Width="100%" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
        </td>
        <td dir="rtl" align="right">
            <asp:Label ID="labfile" runat="server" Text="Label" Visible="False" Font-Size="14px"
                ForeColor="Red"></asp:Label>
        </td>
    </tr>
    <tr runat="server" align="<%$Resources:Master, align%>">
        <td valign="top">
        </td>
        <td dir="ltr" valign="top" align="center">
            <asp:Button ID="Button1" runat="server" Text="حفظ تفاصيل الاستمارة" OnClick="Button1_Click"
                ValidationGroup="d" OnClientClick="ValidateAndShowPopup()" Style="height: 26px" />
        </td>
        <td dir="rtl" align="right">
            &nbsp;
        </td>
    </tr>
    <tr runat="server">
        <td valign="top">
            &nbsp;
        </td>
        <td dir="ltr" valign="top" align="center">
                        <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender3" runat="server" FilterType="Custom"
                            TargetControlID="txt_from" ValidChars="0123456789/\">
                        </cc1:FilteredTextBoxExtender>
           <%-- <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" runat="server" FilterType="Custom"
                TargetControlID="txt_hdate" ValidChars="0123456789/\">
            </cc1:FilteredTextBoxExtender>--%>
        </td>
        <td dir="rtl" align="right">
            &nbsp;<cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender4" runat="server" FilterType="Custom"
                            TargetControlID="txt_to" ValidChars="0123456789/\">
                        </cc1:FilteredTextBoxExtender>
                    &nbsp;</td>
    </tr>
    <tr align="right">
        <td align="center" colspan="3" dir="rtl">
          <%--    <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender5" runat="server" FilterType="Custom"
                TargetControlID="txt_date" ValidChars="0123456789/\">
            </cc1:FilteredTextBoxExtender>--%>
        </td>
    </tr>
</table>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     