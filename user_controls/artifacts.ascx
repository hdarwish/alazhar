<%@ Control Language="C#" AutoEventWireup="true" CodeFile="artifacts.ascx.cs" Inherits="masterpage_artifacts" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
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
<style type="text/css">
    .style2
    {
        width: 53px;
    }
    .style3
    {
        width: 100%;
    }
</style>
<input id="doc_id" type="hidden" value="0" runat="server" />
<asp:HiddenField ID="content_id" runat="server" />
<asp:HiddenField ID="content_type" runat="server" />
<table style="width: 700px" cellspacing="0" runat="server" dir="<%$Resources:Master, dir%>"
    id="tblartif">
    <tr align="right" id="trpagetitle" runat="server">
        <td colspan="2" align="right" dir="rtl">
            <asp:Label ID="lblpagetitle" runat="server" Text="بيانات القطعة المتحفية" Visible="true"></asp:Label>
        </td>
        <td align="right" visible="true" colspan="2" dir="rtl">
            <a href="#" runat="server" id="id_href" target="_blank" visible="False">عرض الاستمارة
            </a>
        </td>
    </tr>
    <tr align="right">
        <td colspan="3" align="center" dir="rtl">
            <asp:Label ID="lblerror" runat="server" Text="Label" Visible="false"></asp:Label>
        </td>
    </tr>
    <tr id="trtitle" runat="server" align="<%$Resources:Master, align%>">
        <td id="Td1" align="<%$Resources:Master, align%>" runat="server">
            <asp:Label ID="Label2" runat="server" Text="اسم القطعة:"></asp:Label>
        </td>
        <td id="Td2" align="<%$Resources:Master, align%>" runat="server" colspan="2">
            <asp:Label ID="txt_art_title" runat="server" ReadOnly="True" Font-Bold="True" Font-Size="14px"></asp:Label>
        </td>
    </tr>
    <tr id="trspecial" runat="server" align="<%$Resources:Master, align%>">
        <td align="right" dir="rtl">
            <asp:Label ID="lblelemnt" runat="server" Text="<%$Resources:Master, Labspecial%>"></asp:Label>
        </td>
        <td colspan="2" dir="rtl" align="right">
            <asp:CheckBox ID="chk_pan" runat="server" Text="علي البانوراما" />
            <asp:CheckBox ID="chk_site" runat="server" Text="علي الموقع" />
            &nbsp;
        </td>
    </tr>
    <tr id="trbrief" runat="server" align="<%$Resources:Master, align%>">
        <td align="<%$Resources:Master, align%>" runat="server" >
            <asp:Label ID="Label32" runat="server" Text="<%$Resources:Master, b_desc %>"></asp:Label>
        </td>
        <td runat="server"  colspan="2" align="<%$Resources:Master, align%>">
            <FCKeditorV2:FCKeditor ID="brief_desc" runat="server" BasePath="~/fckeditor/" Height="400px">
            </FCKeditorV2:FCKeditor>
        </td>
    </tr>
    <tr  id="trtdesc" runat="server" align="<%$Resources:Master, align%>"> 
        <td align="<%$Resources:Master, align%>" runat="server" >
            <asp:Label ID="Label33" runat="server" Text="<%$Resources:Master, details_desc %>"></asp:Label>
        </td>
        <td align="<%$Resources:Master, align%>" colspan="2" runat="server">
            <FCKeditorV2:FCKeditor ID="details_desc" runat="server" BasePath="~/fckeditor/" Height="400px">
            </FCKeditorV2:FCKeditor>
        </td>
    </tr>
    <tr id="trmaker" runat="server" align="<%$Resources:Master, align%>">
        <td align="<%$Resources:Master, align%>" runat="server">
            <asp:Label ID="Label34" runat="server" Text="<%$Resources:Master, name_maker %>"></asp:Label>
        </td>
        <td colspan="2" align="<%$Resources:Master, align%>" runat="server">
            <asp:TextBox ID="txt_maker" runat="server" Width="100%"></asp:TextBox>
        </td>
    </tr>
    <tr align="right" id="trtype" runat="server">
        <td dir="rtl" colspan="1" align="right">
            <asp:Label ID="Label26" runat="server" Text="نوع القطعة:"></asp:Label>
        </td>
        <td colspan="2" align="right">
            <table cellpadding="1" cellspacing="2" dir="rtl">
                <tr align="right">
                    <td align="right" dir="rtl">
                        <asp:DropDownList ID="drop_style" runat="server" DataTextField="title_ar" DataValueField="id"
                            Height="21px" Width="136px" OnSelectedIndexChanged="drop_material_SelectedIndexChanged"
                            AutoPostBack="True">
                        </asp:DropDownList>
                    </td>
                    <td colspan="2" dir="rtl" align="right">
                        <asp:Label ID="Label8" runat="server" Text=" أخري:"></asp:Label>
                        <asp:TextBox ID="txt_m_other" runat="server" Enabled="true"></asp:TextBox>
                        &nbsp;
                    </td>
                    <td class="style2">
                        <asp:Label ID="lblError4" runat="server" ForeColor="Red" Font-Size="13px" Visible="False"></asp:Label>
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr align="right" id="trcolor" runat="server">
        <td align="right" dir="rtl">
            <asp:Label ID="Label27" runat="server" Text="اللون:"></asp:Label>
        </td>
        <td align="right" colspan="2">
            <table cellpadding="1" cellspacing="2" dir="rtl">
                <tr>
                    <td align="right" dir="rtl">
                        <asp:DropDownList ID="drop_color" runat="server" DataTextField="title_ar" DataValueField="id"
                            Height="20px" Width="136px" OnSelectedIndexChanged="drop_techinque_SelectedIndexChanged"
                            AutoPostBack="True">
                        </asp:DropDownList>
                    </td>
                    <td colspan="2" dir="rtl">
                        <asp:Label ID="Label9" runat="server" Text=" أخري:"></asp:Label>
                        <asp:TextBox ID="txt_type_other" runat="server" Enabled="true"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="lblError5" runat="server" ForeColor="Red" Font-Size="13px" Visible="False"></asp:Label>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr align="right" id="trtechinque" runat="server">
        <td align="right" dir="rtl">
            <asp:Label ID="Label6" runat="server" Text="الأسلوب الفني:"></asp:Label>
        </td>
        <td colspan="2">
            <table cellpadding="1" cellspacing="2" dir="rtl">
                <tr>
                    <td align="right" dir="rtl">
                        <asp:DropDownList ID="drop_techinque" runat="server" AutoPostBack="true" DataValueField="id"
                            DataTextField="title_ar" Height="20px" Width="136px" OnSelectedIndexChanged="drop_techinque_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td colspan="2" align="right" dir="rtl">
                        <asp:Label ID="Label10" runat="server" Text=" أخري:"></asp:Label>
                        <asp:TextBox ID="other" runat="server" Enabled="true"></asp:TextBox>
                    </td>
                    <td dir="rtl" colspan="1">
                        <asp:Label ID="lblError6" runat="server" ForeColor="Red" Font-Size="13px" Visible="False"></asp:Label>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr id="trraw" runat="server">
        <td align="right" dir="rtl" colspan="1">
            <asp:Label ID="Label28" runat="server" Text="مادة الصنع:"></asp:Label>
        </td>
        <td align="right" colspan="2" dir="rtl">
            <asp:DropDownList ID="drop_raw" runat="server" AutoPostBack="true" DataValueField="id"
                DataTextField="title_ar" Height="20px" Width="136px" OnSelectedIndexChanged="drop_raw_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:Label ID="Label35" runat="server" Text=" أخري:"></asp:Label>
            <asp:TextBox ID="other0" runat="server" Enabled="true"></asp:TextBox>
            <asp:Label ID="lblError7" runat="server" ForeColor="Red" Font-Size="13px" Visible="False"></asp:Label>
        </td>
    </tr>
    <tr runat="server" id="trdimension">
        <td valign="top">
            <asp:Label ID="Label3" runat="server" Text="الأبعاد :"></asp:Label>
        </td>
        <td align="right" dir="rtl" colspan="2">
            <table class="style3">
                <tr>
                    <td align="center">
                        <asp:Label ID="Label36" runat="server" Text="الطول"></asp:Label>
                    </td>
                    <td align="center">
                        <asp:Label ID="Label37" runat="server" Text="العرض"></asp:Label>
                    </td>
                    <td align="center">
                        <asp:Label ID="Label38" runat="server" Text="الارتفاع"></asp:Label>
                    </td>
                     <td align="center">
                        <asp:Label ID="Label39" runat="server" Text="القطر"></asp:Label>
                    </td>
                    <td align="center">
                        <asp:Label ID="Label40" runat="server" Text="المحيط"></asp:Label>
                    </td>
                    <td align="center">
                        <asp:Label ID="Label41" runat="server" Text="الوزن"></asp:Label>
                    </td>
                    
                    
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txt_length" runat="server" Width="97px"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                            ControlToValidate="txt_length" Font-Size="14px" ValidationGroup="d"></asp:RequiredFieldValidator>
                    </td>
                    <td>
                        <asp:TextBox ID="txt_width" runat="server" Width="97px"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator25" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                            ControlToValidate="txt_width" Font-Size="14px" ValidationGroup="d"></asp:RequiredFieldValidator>
                    </td>
                    <td>
                        <asp:TextBox ID="txt_height" runat="server" Width="97px"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator26" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                            ControlToValidate="txt_height" Font-Size="14px" ValidationGroup="d"></asp:RequiredFieldValidator>
                    </td>
                      <td>
                        <asp:TextBox ID="txt_dimater" runat="server" Width="97px"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator27" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                            ControlToValidate="txt_dimater" Font-Size="14px" ValidationGroup="d"></asp:RequiredFieldValidator>
                    </td>
                    <td>
                        <asp:TextBox ID="txt_perimeter" runat="server" Width="97px"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator28" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                            ControlToValidate="txt_perimeter" Font-Size="14px" ValidationGroup="d"></asp:RequiredFieldValidator>
                    </td>
                    <td>
                        <asp:TextBox ID="txt_wight" runat="server" Width="97px"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator29" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                            ControlToValidate="txt_wight" Font-Size="14px" ValidationGroup="d"></asp:RequiredFieldValidator>
                    </td>
                </tr>
               
            </table>
        </td>
    </tr>
    <tr runat="server" id="trdimater">
        <td dir="rtl" align="right">
            <asp:Label ID="Label17" runat="server" Text="تاريخ الصنع/التكوين"></asp:Label>
        </td>
        <td align="right" colspan="2">
            <table>
                <tr align="right">
                    <td colspan="1" dir="rtl" align="right">
                        <asp:TextBox ID="txt_hdate" runat="server"></asp:TextBox>
                        <asp:Label ID="Label18" runat="server" Text="هـ"></asp:Label>
                        <asp:Label ID="lblError2" runat="server" Text="سنة -(يوم/ شهر / سنة)" ForeColor="Red"
                            Font-Size="13px"></asp:Label>
                        &nbsp;
                        <asp:Label ID="lblError8" runat="server" ForeColor="Red" Font-Size="13px" Visible="False"></asp:Label>
                        <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" runat="server" FilterType="Custom"
                            TargetControlID="txt_hdate" ValidChars="0123456789/\">
                        </cc1:FilteredTextBoxExtender>
                    </td>
                    <td>
                    </td>
                    <td colspan="1" dir="rtl" align="right">
                        <asp:TextBox ID="txt_date" runat="server"></asp:TextBox>
                        <asp:Label ID="Label19" runat="server" Text="م"></asp:Label>
                        <asp:Label ID="lblError3" runat="server" Text="سنة-(يوم/ شهر /سنة)" ForeColor="Red"
                            Font-Size="13px"></asp:Label>
                        &nbsp;<asp:Label ID="lblError9" runat="server" ForeColor="Red" Font-Size="13px" Visible="False"></asp:Label>
                        <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender5" runat="server" FilterType="Custom"
                            TargetControlID="txt_date" ValidChars="0123456789/\">
                        </cc1:FilteredTextBoxExtender>
                    </td>
                    <td>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr runat="server" id="trorg" align="<%$Resources:Master, align%>">
        <td rowspan="1" valign="top" align="<%$Resources:Master, align%>">
            <asp:Label ID="Label20" runat="server" Text="<%$Resources:Master, source_side%>"
                Font-Bold="False"></asp:Label>
        </td>
        <td align="<%$Resources:Master, align%>" rowspan="1" colspan="2" runat="server">
            <table align="<%$Resources:Master, align%>" style="width: 621px" runat="server">
                <tr align="<%$Resources:Master, align%>" runat="server">
                    <td align="<%$Resources:Master, align%>" runat="server">
                        <asp:Label ID="Label21" runat="server" Text="<%$Resources:Master, source_side%>"></asp:Label>
                        &nbsp;<asp:TextBox ID="txt_org" runat="server" Width="132px"></asp:TextBox>
                    </td>
                    <td align="<%$Resources:Master, align%>" runat="server">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                            ControlToValidate="txt_org" Font-Size="14px" ValidationGroup="d"></asp:RequiredFieldValidator>
                    </td>
                    <td align="<%$Resources:Master, align%>">
                        <asp:Label ID="Label22" runat="server" Text="<%$Resources:Master, org_country%>"></asp:Label>
                    </td>
                    <td align="<%$Resources:Master, align%>">
                        <asp:TextBox ID="txt_country" runat="server"></asp:TextBox>
                    </td>
                    <td align="<%$Resources:Master, align%>" runat="server">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                            ControlToValidate="txt_country" Font-Size="14px" ValidationGroup="d"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr align="<%$Resources:Master, align%>" runat="server">
                    <td align="<%$Resources:Master, align%>" runat="server">
                        <asp:Label ID="Label23" runat="server" Text="<%$Resources:Master, org_city%>"></asp:Label>
                        &nbsp;<asp:TextBox ID="txt_city" runat="server"></asp:TextBox>
                    </td>
                    <td align="<%$Resources:Master, align%>" runat="server">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                            ControlToValidate="txt_city" Font-Size="14px" ValidationGroup="d"></asp:RequiredFieldValidator>
                    </td>
                    <td align="<%$Resources:Master, align%>" runat="server">
                        <asp:Label ID="Label24" runat="server" Text="<%$Resources:Master, org_no%>"></asp:Label>
                    </td>
                    <td align="<%$Resources:Master, align%>" runat="server">
                        <asp:TextBox ID="txt_save_no" runat="server"></asp:TextBox>
                    </td>
                    <td align="<%$Resources:Master, align%>" runat="server">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                            ControlToValidate="txt_save_no" Font-Size="14px" ValidationGroup="d"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr align="<%$Resources:Master, align%>" runat="server" dir="<%$Resources:Master, dir%>">
                    <td align="<%$Resources:Master, align%>" runat="server" >
                        <asp:Label ID="Label25" runat="server" Text="<%$Resources:Master, org_notes%>"></asp:Label>
                    </td>
                    <td  colspan="5" valign="top" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" runat="server">
                        &nbsp;<asp:TextBox ID="txt_org_notes" runat="server" TextMode="MultiLine" Width="351px"
                            Height="55px"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr runat="server" id="trnotes" align="<%$Resources:Master, align%>">
        <td align="<%$Resources:Master, align%>" runat="server">
            <asp:Label ID="Label12" runat="server" Text="<%$Resources:Master, c_notes %>"></asp:Label>
        </td>
        <td colspan="2" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" runat="server">
            <asp:TextBox ID="txt_notes" runat="server" TextMode="MultiLine" Width="100%" Height="46px"></asp:TextBox>
        </td>
    </tr>
    <tr runat="server" id="trtags" align="<%$Resources:Master, align%>">
        <td runat="server" align="<%$Resources:Master, align%>">
            <asp:Label ID="Label13" runat="server" Text="<%$Resources:Master, c_tags %>"></asp:Label>
        </td>
        <td colspan="1" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" valign="top" runat="server">
            <asp:TextBox ID="txt_tags" runat="server" Width="100%" Height="65px" TextMode="MultiLine"></asp:TextBox>
        </td>
        <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" runat="server" valign="top">
            <asp:Label ID="lblDeclaration" runat="server" Text="يرجى إدخال الكلمات الدالة مفصولة برمز (-) أو (،) فيما بينها كما بالمثال التالى كلمة دالة 1 - كلمة دالة 2"
                Font-Size="12px" ForeColor="Red"></asp:Label><br />
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txt_tags" Font-Size="14px" ValidationGroup="d"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr align="right" runat="server" id="trperiods">
        <td align="right" colspan="3" dir="rtl">
            <asp:Label ID="Label14" runat="server" Text=" العصر الذي تتناوله/ ترتبط به القطعة المتحفية:"></asp:Label>
        </td>
    </tr>
    <tr runat="server" id="trperiods1">
        <td colspan="2" dir="rtl" align="right">
            <asp:CheckBoxList ID="chk_periods" runat="server" RepeatDirection="Horizontal"
                RepeatColumns="4" DataTextField="title"  DataValueField="id">
            </asp:CheckBoxList>
        </td>
        <td>
           <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator24" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="chk_periods" Font-Size="14px" ValidationGroup="d"></asp:RequiredFieldValidator>
        --%></td>
    </tr>
    <tr runat="server" id="trpicture">
        <td dir="rtl" rowspan="1" valign="top" align="right" colspan="1">
            <asp:Label ID="Label11" runat="server" Text="الصورة المرفقة مع الاستمارة   " Width="150px"></asp:Label>
        </td>
        <td dir="rtl" align="right" colspan="1">
            <asp:RadioButtonList ID="rblFormImage" runat="server" RepeatColumns="1" RepeatDirection="Horizontal">
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
            <asp:TextBox ID="txtFormDataColectorName" runat="server" Width="270px" />
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
            <asp:TextBox ID="txtFormDataRevisionName" runat="server" Width="270px" />
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txtFormDataRevisionName" Font-Size="14px" ValidationGroup="d"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr runat="server" id="file_tr" dir="<%$Resources:Master,dir%>">
        <td dir="<%$Resources:Master,dir%>" rowspan="1" valign="top" align="<%$Resources:Master,align%>">
            <asp:Label ID="Label30" runat="server" Text="<%$Resources:Master,Topics_upload%>"></asp:Label>
        </td>
        <td dir="ltr"  rowspan="1" valign="top" align="left">
            <%--<asp:Label ID="Label55" runat="server" Font-Size="14px" ForeColor="Red" 
                Width="40%"></asp:Label>--%>
            <asp:FileUpload ID="uploadfile" runat="server" Width="58%" />
        &nbsp;
        </td>
        <td dir="rtl" align="right">
            <asp:Label ID="labfile" runat="server" Text="Label" Visible="False" Font-Size="14px"
                ForeColor="Red"></asp:Label>
        </td>
    </tr>
    <tr align="right">
        <td align="center" colspan="3" dir="rtl">
            <asp:Button ID="Button1" runat="server" Text="حفظ بيانات الاستمارة" 
                OnClick="Button1_Click" ValidationGroup="d" OnClientClick="ValidateAndShowPopup()"/>
        </td>
    </tr>
</table>
