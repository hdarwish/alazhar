<%@ Control Language="C#" AutoEventWireup="true" CodeFile="theses.ascx.cs" Inherits="masterpage_theses" %>
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
<table style="width: 50%" dir="<%$Resources:Master, dir%>" runat="server" cellspacing="4"
    id="trthese">
    <tr align="right">
        <td colspan="4" align="center">
            <asp:HiddenField ID="content_type" runat="server" />
            <asp:HiddenField ID="content_id" runat="server" />
        </td>
    </tr>
    <tr runat="server" align="<%$Resources:Master, align%>" id="trpagetitle">
        <td colspan="2" runat="server" align="<%$Resources:Master, align%>">
            <asp:Label ID="lblpagetitle" runat="server"  Text="<%$Resources:Master, thesis_main_title%>" Font-Bold="True"></asp:Label>
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
    <tr id="trtitle" runat="server" align="<%$Resources:Master, align%>">
        <td align="<%$Resources:Master, align%>" runat="server">
            <asp:Label ID="Label2" runat="server" Text="<%$Resources:Master, thesis_title%>"></asp:Label>
        </td>
        <td colspan="3" dir="rtl">
            <asp:Label ID="txt_art_title" runat="server" ReadOnly="True" Font-Bold="True" Font-Size="14px"></asp:Label>
        </td>
    </tr>
    <tr id="trspecial" runat="server" align="<%$Resources:Master, align%>">
        <td>
            <asp:Label ID="Label1" runat="server" Text="<%$Resources:Master, Labspecial%>"></asp:Label>
        </td>
        <td colspan="3" align="<%$Resources:Master, align%>">
            
            
            <asp:CheckBox ID="chk_site" runat="server" Text="علي الموقع" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="chk_pan" runat="server" Text="علي بانوراما التراث" />
            
        </td>
    </tr>
    <tr id="trname" runat="server" align="<%$Resources:Master, align%>">
        <td colspan="1" runat="server" align="<%$Resources:Master, align%>">
            <asp:Label ID="Label33" runat="server" Text="<%$Resources:Master, searcher_name%>"></asp:Label>
        </td>
        <td class="style1">
            <asp:TextBox ID="txt_art_title0" runat="server" Width="446px"></asp:TextBox>
        </td>
    </tr>
    <tr id="trsupervisor" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" runat="server">
        <td colspan="1" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" runat="server">
            <asp:Label ID="Label11" runat="server" Text="<%$Resources:Master, supervisior%>"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txt_super" runat="server" Width="446px"></asp:TextBox>
        </td>
    </tr>
    <tr id="trsupervisor1" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" runat="server">
        <td colspan="1" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" runat="server">
            <asp:Label ID="Label34" runat="server" Text="<%$Resources:Master, supermoshark%>"></asp:Label>
        </td>
        <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" runat="server">
            <asp:TextBox ID="txt_supervisor1" runat="server" Width="446px"></asp:TextBox>
        </td>
    </tr>
    <tr id="trsupervisor2" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" runat="server">
        <td colspan="1" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" runat="server">
            <asp:Label ID="Label9" runat="server" Text="<%$Resources:Master, supermoshark%>"></asp:Label>
        </td>
        <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" runat="server">
            <asp:TextBox ID="txt_supervisor2" runat="server" Width="446px"></asp:TextBox>
        </td>
    </tr>
    <tr id="trthesestype" runat="server">
        <td colspan="1" dir="rtl">
            <asp:Label ID="Label35" runat="server" Text="نوع الأطروحة:"></asp:Label>
        </td>
        <td>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" Width="140px" RepeatDirection="Horizontal">
                <asp:ListItem Text="ماجستير" Value="1"></asp:ListItem>
                <asp:ListItem Text="دكتوراه" Value="2"></asp:ListItem>
            </asp:RadioButtonList>
        </td>
    </tr>
    <tr align="right" id="trpageno" runat="server">
        <td align="right" dir="rtl">
            <asp:Label ID="Label5" runat="server" Text="عدد الصفحات:"></asp:Label>
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
            &nbsp;
        </td>
        <td align="right" dir="rtl">
            &nbsp;
        </td>
    </tr>
    <tr align="right" id="trlang" runat="server">
        <td>
            <asp:Label ID="Label6" runat="server" Text="لغة الأطروحة:"></asp:Label>
        </td>
        <td dir="rtl">
            <asp:DropDownList ID="drop_lang" runat="server" AutoPostBack="true" DataValueField="id"
                DataTextField="title_ar" OnSelectedIndexChanged="drop_lang_SelectedIndexChanged"
                 Width="89px">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator24" runat="server" ControlToValidate="drop_lang"
                ErrorMessage="هذا الحقل يجب إدخاله" ValidationGroup="save"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr align="<%$Resources:Master, align%>" id="trunversity" runat="server">
        <td class="style2" align="<%$Resources:Master, align%>">
            <asp:Label ID="Label4" runat="server" Text="<%$Resources:Master, university%>" Font-Bold="False"></asp:Label>
        </td>
        <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
            <asp:TextBox ID="txt_unversity" runat="server" Height="22px" Width="134px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator27" runat="server" ControlToValidate="txt_unversity"
                ErrorMessage="هذا الحقل يجب إدخاله" ValidationGroup="save"></asp:RequiredFieldValidator>
        </td>
        <td class="style1" colspan="1">
            &nbsp;
        </td>
    </tr>
    <tr align="right" id="trsection" runat="server">
        <td class="style2">
            <asp:Label ID="Label8" runat="server" Text="<%$Resources:Master,elkasm%>"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txt_section" runat="server" Height="22px" Width="139px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator30" runat="server" ControlToValidate="txt_section"
                ErrorMessage="هذا الحقل يجب إدخاله" ValidationGroup="save"></asp:RequiredFieldValidator>
        </td>
        <td class="style1" colspan="1">
            &nbsp;
        </td>
        <td>
            &nbsp;
        </td>
    </tr>
    <tr align="right" id="trcollage" runat="server">
        <td class="style2">
            <asp:Label ID="Label36" runat="server" Text="<%$Resources:Master,elkolia%>"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txt_collage" runat="server" Height="22px" Width="139px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator31" runat="server" ControlToValidate="txt_collage"
                ErrorMessage="هذا الحقل يجب إدخاله" ValidationGroup="save"></asp:RequiredFieldValidator>
        </td>
        <td class="style1" colspan="1">
            &nbsp;
        </td>
        <td>
            &nbsp;
        </td>
    </tr>
    <tr id="trdate" runat="server">
        <td dir="rtl" align="right" valign="top">
            <asp:Label ID="Label17" runat="server" Text="تاريخ الإجازة:"></asp:Label>
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
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr id="trnotes" align="<%$Resources:Master, align%>" runat="server">
        <td class="style2" align="<%$Resources:Master, align%>" runat="server">
            <asp:Label ID="Label12" runat="server" Text="<%$Resources:Master, c_notes%>"></asp:Label>
        </td>
        <td align="right" colspan="2">
            <asp:TextBox ID="txt_notes" runat="server" Width="100%"  TextMode="MultiLine" 
                Height="60px"></asp:TextBox>
         </td>
    </tr>
    <tr id="trtags" align="<%$Resources:Master, align%>" runat="server" dir="<%$Resources:Master, dir%>">
        <td align="<%$Resources:Master, align%>" runat="server" dir="<%$Resources:Master, dir%>">
            <asp:Label ID="Label13" runat="server" Text="<%$Resources:Master, tags%>"></asp:Label>
        </td>
           <td align="right" colspan="2" >
            <asp:TextBox ID="txt_tags" runat="server" Width="100%"  
                 TextMode="MultiLine" Height="60px"></asp:TextBox>
            <asp:Label ID="lblDeclaration" runat="server" 
                 Text="يرجى إدخال الكلمات الدالة مفصولة برمز (-) أو (،) فيما بينها كما بالمثال التالى كلمة دالة 1 - كلمة دالة 2" 
                 Font-Size="12px" ForeColor="Red" Width="100%" ></asp:Label>
         </td>
        
        <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" runat="server">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator26" runat="server" ControlToValidate="txt_tags"
                ErrorMessage="هذا الحقل يجب إدخاله" ValidationGroup="A"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr id="trperiods" runat="server">
        <td class="style2">
            <asp:Label ID="Label14" runat="server" Text=" العصر الذي تتناوله/ ترتبط به الأطروحة:"></asp:Label>
        </td>
        <td colspan="3" dir="rtl">
            <asp:CheckBoxList ID="chk_periods" DataTextField="title" DataValueField="id" runat="server"
                RepeatDirection="Horizontal" RepeatColumns="4" Width="100%">
            </asp:CheckBoxList>
        </td>
    </tr>
    <tr id="trpicuter" runat="server">
        <td dir="rtl" rowspan="1" valign="top" align="right">
            <asp:Label ID="Label26" runat="server" Text="الصورة المرفقة مع الاستمارة   "></asp:Label>
        </td>
        <td dir="rtl" align="right">
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
    <tr id="trColectorName" runat="server" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" >
        <td rowspan="1" valign="top" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" runat="server">
            <asp:Label ID="Label3" runat="server" Text="اسم جامع بيانات الاستمارة  " Width="150px"
                Height="26px"></asp:Label>
        </td>
        <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" runat="server" class="style2" rowspan="1" valign="top">
            <asp:TextBox ID="txtFormDataColectorName" runat="server" Width="270px" />
        </td>
        <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" runat="server">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txtFormDataColectorName" Font-Size="14px" ValidationGroup="A"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr id="trRevisionName" runat="server">
        <td dir="rtl" rowspan="1" valign="top" align="right">
            <asp:Label ID="Label25" runat="server" Text="اسم مراجع بيانات الاستمارة  " Width="155px"
                Height="26px"></asp:Label>
        </td>
        <td dir="rtl" class="style2" rowspan="1" valign="top">
            <asp:TextBox ID="txtFormDataRevisionName" runat="server" Width="270px" />
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txtFormDataRevisionName" Font-Size="14px" ValidationGroup="A"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr runat="server" id="file_tr" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
        <td dir="<%$Resources:Master, dir%>" rowspan="1" valign="top" runat="server" align="<%$Resources:Master, align%>">
            <asp:Label ID="Label27" runat="server" Text="<%$Resources:Master, Topics_upload%>"></asp:Label>
        </td>
        <td align="<%$Resources:Master, align%>" rowspan="1" valign="top" runat="server"  dir="<%$Resources:Master, dir%>">
         <asp:FileUpload ID="uploadfile" runat="server" Width="100%" />
           <%--<asp:Label ID="Label55" runat="server" Font-Size="14px" ForeColor="Red" 
                Width="40%"></asp:Label>--%>
            
        </td>
        <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
            <asp:Label ID="labfile" runat="server" Text="Label" Visible="False" Font-Size="14px"
                ForeColor="Red"></asp:Label>
        </td>
    </tr>
    <tr  runat="server">
        <td  align="center" colspan="3" height="60px"  runat="server">
            <asp:Button ID="Button1" runat="server" Text="حفظ تفاصيل الاستمارة" 
                OnClick="Button1_Click" ValidationGroup="A"  OnClientClick="ValidateAndShowPopup()"
                />
        </td>
        <td>
            &nbsp;
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
