<%@ Control Language="C#" AutoEventWireup="true" CodeFile="events_form.ascx.cs" Inherits="masterpage_Events_Form" %>
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
<table style="width: 700px" border="0" cellspacing="5" runat="server" dir="<%$Resources:Master, dir%>"
    id="tblEvents" >
    <tr>
        <td colspan="2" align="center" height="60px" valign="bottom">
            <asp:HiddenField ID="content_id" runat="server" />
            <asp:HiddenField ID="content_type" runat="server" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label25" runat="server" Text="<%$ Resources:Master, Lbl_event_head %>" ForeColor="Black"
                Font-Bold="True" Font-Size="16px"></asp:Label> 
        </td>
        <td align="left" visible="true" colspan="2" dir="<%$Resources:Master, dir%>" 
            valign="bottom">
           
            <a href runat="server" id="id_href" target="_blank">عرض الاستمارة </a>
        </td>
    </tr>
    <tr>
        <td colspan="3" align="center" height="40px">
            <asp:Label ID="lblpage" runat="server" Text="تم حفظ بيانات الإستمارة بنجاح " ForeColor="Green"
                Visible="False" Font-Size="16px"></asp:Label>
        </td>
    </tr>
    <tr runat="server" id="tr_id_12">
        <td valign="top" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
            <asp:Label ID="lbl2" runat="server" Text="<%$Resources:Master, event_title%>" ForeColor="#996633"></asp:Label>
        </td>
        <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" valign="top">
            <asp:TextBox ID="txtTitle" runat="server" Font-Bold="True" Font-Size="14px"  Height="19px" Width="600px"></asp:TextBox>
             <asp:RequiredFieldValidator ControlToValidate="txtTitle" ValidationGroup="A" runat="server" ErrorMessage="هذا الحقل يجب إدخاله" ID="rfv1"></asp:RequiredFieldValidator>
	
        </td>
        <td align="<%$Resources:Master, align%>" valign="top" nowrap>
        </td>
    </tr>
    <tr runat="server" id="tr_id_1">
        <td valign="top" nowrap>
            <asp:Label ID="Label24" runat="server" Text="عنصر مميز : " ForeColor="#996633"></asp:Label>
        </td>
        <td id="Td1" colspan="2" align="<%$Resources:Master, align%>" runat="server">
         
           <%-- <asp:RadioButtonList ID="rblSpecialElement" runat="server" RepeatDirection="Horizontal"
                RepeatColumns="2" Width="300px">
                <asp:ListItem Text="على الموقع" Selected="True"></asp:ListItem>
                <asp:ListItem Text="على البانوراما"></asp:ListItem>
            </asp:RadioButtonList>--%>
              <asp:CheckBox ID="chk_highlight" runat="server" Text="علي الموقع" />
            <asp:CheckBox ID="chk_pano" runat="server" Text="علي البانوراما" />
        </td>
        <td valign="top">
            &nbsp;
        </td>
    </tr>
    <tr runat="server" id="tr_id_2">
        <td valign="top" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
            <asp:Label ID="lbl4" runat="server" Text="<%$Resources:Master, event_brief%>" ForeColor="#996633"></asp:Label>
        </td>
        <td>
            <FCKeditorV2:FCKeditor ID="txtDesc" runat="server" BasePath="~/fckeditor/" Height="400px">
            </FCKeditorV2:FCKeditor>
        </td>
        <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" valign="top">
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txtDesc" Font-Size="14px"></asp:RequiredFieldValidator>--%>
        </td>
    </tr>
    <tr runat="server" id="tr_id_3">
        <td valign="top" align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
            <asp:Label ID="Label26" runat="server" Text="<%$Resources:Master, event_brief_all%>" ForeColor="#996633"></asp:Label>
        </td>
        <td>
            <FCKeditorV2:FCKeditor ID="txtDetailedDesc" runat="server" BasePath="~/fckeditor/"
                Height="400px">
            </FCKeditorV2:FCKeditor>
        </td>
        <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" valign="top">
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txtDetailedDesc" Font-Size="14px"></asp:RequiredFieldValidator>--%>
        </td>
    </tr>
    <tr runat="server" id="tr_id_4">
        <td dir="<%$Resources:Master ,dir %>" align="<%$Resources:Master ,align %>">
            <asp:Label ID="Label5" runat="server" Text="الفترة الزمنية التي استغرقها الحدث/الموقف :"
                ForeColor="#996633"></asp:Label>
        </td>
        <td>
            <table>
                <tr>
                    <td runat="server" dir="<%$Resources:Master ,dir %>" align="<%$Resources:Master ,align %>" style="width: 10%" nowrap>
                        <asp:Label ID="Label7" runat="server" Text="تاريخ البداية :" Width="" Height="23px"></asp:Label>
                    </td>
                    <td runat="server" dir="<%$Resources:Master ,dir %>" align="<%$Resources:Master ,align %>" style="width: 90%">
                        <asp:TextBox ID="txtStartDate" runat="server" Height="20px" Width="300px" /> م
                        <%--<cc1:FilteredTextBoxExtender ID="FilteredtxtHijriDate" runat="server" FilterType="Custom"
                            TargetControlID="txtStartDate" ValidChars="0123456789/\">
                        </cc1:FilteredTextBoxExtender>
                        <asp:Label ID="lblError" runat="server" Text="(يوم/شهر/سنة)" Height="20px" ForeColor="Red"
                            Width="50px" Font-Size="13px"></asp:Label>--%>
                 <asp:RequiredFieldValidator ControlToValidate="txtStartDate" ValidationGroup="A" runat="server" ErrorMessage="هذا الحقل يجب إدخاله" ID="RequiredFieldValidator1"></asp:RequiredFieldValidator>
	
                    </td>
                </tr>
                <tr>
                    <td runat="server" dir="<%$Resources:Master ,dir %>" align="<%$Resources:Master ,align %>" style="width: 10%" nowrap>
                        <asp:Label ID="Label27" runat="server" Text="تاريخ النهاية :" Width="" Height="23px"></asp:Label>
                    </td>
                    <td runat="server" dir="<%$Resources:Master ,dir %>" align="<%$Resources:Master ,align %>" style="width: 90%">
                        <asp:TextBox ID="txtEndDate" runat="server" Height="20px" Width="300px" /> م
                        <%--<cc1:FilteredTextBoxExtender ID="FilteredtxtGorgDate" runat="server" FilterType="Custom"
                            TargetControlID="txtEndDate" ValidChars="0123456789/\">
                        </cc1:FilteredTextBoxExtender>
                        <asp:Label ID="lblError2" runat="server" Text="(يوم/شهر/سنة)" Height="20px" ForeColor="Red"
                            Font-Size="13px"></asp:Label>--%>
                            <asp:RequiredFieldValidator ControlToValidate="txtEndDate" ValidationGroup="A" runat="server" ErrorMessage="هذا الحقل يجب إدخاله" ID="RequiredFieldValidator2"></asp:RequiredFieldValidator>
	
                    </td>
                    
                    
                    
                    
                </tr>
                
                 <tr>
                    <td runat="server" dir="<%$Resources:Master ,dir %>" align="<%$Resources:Master ,align %>" style="width: 10%" nowrap>
                        <asp:Label ID="Label3" runat="server" Text="تاريخ البداية :" Width="" Height="23px"></asp:Label>
                    </td>
                    <td runat="server" dir="<%$Resources:Master ,dir %>" align="<%$Resources:Master ,align %>" style="width: 90%">
                        <asp:TextBox ID="txtsthegry" runat="server" Height="20px" Width="300px" /> هـ
                       <%-- <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" runat="server" FilterType="Custom"
                            TargetControlID="txtStartDate" ValidChars="0123456789/\">
                        </cc1:FilteredTextBoxExtender>
                        <asp:Label ID="Label4" runat="server" Text="(يوم/شهر/سنة)" Height="20px" ForeColor="Red"
                            Width="50px" Font-Size="13px"></asp:Label>--%>
                    <asp:RequiredFieldValidator ControlToValidate="txtsthegry" ValidationGroup="A" runat="server" ErrorMessage="هذا الحقل يجب إدخاله" ID="RequiredFieldValidator3"></asp:RequiredFieldValidator>
	
                    </td>
                </tr>
                <tr>
                    <td runat="server" dir="<%$Resources:Master ,dir %>" align="<%$Resources:Master ,align %>" style="width: 10%" nowrap>
                        <asp:Label ID="Label6" runat="server" Text="تاريخ النهاية :" Width="" Height="23px"></asp:Label>
                    </td>
                    <td runat="server" dir="<%$Resources:Master ,dir %>" align="<%$Resources:Master ,align %>" style="width: 90%">
                        <asp:TextBox ID="txtendhegry" runat="server" Height="20px" Width="300px" /> هـ
                       <%-- <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender2" runat="server" FilterType="Custom"
                            TargetControlID="txtEndDate" ValidChars="0123456789/\">
                        </cc1:FilteredTextBoxExtender>
                        <asp:Label ID="Label8" runat="server" Text="(يوم/شهر/سنة)" Height="20px" ForeColor="Red"
                            Font-Size="13px"></asp:Label>--%>
                     <asp:RequiredFieldValidator ControlToValidate="txtendhegry" ValidationGroup="A" runat="server" ErrorMessage="هذا الحقل يجب إدخاله" ID="RequiredFieldValidator4"></asp:RequiredFieldValidator>
	
                    </td>
                    
                    
                    
                    
                </tr>
            </table>
        </td>
        <td valign="top">
            &nbsp;
        </td>
    </tr>
    <tr runat="server" id="tr_id_5">
        <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" rowspan="1" valign="top">
            <asp:Label ID="Label15" runat="server" Text="<%$Resources:Master, event_notes%>" ForeColor="#996633"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtNotes" runat="server" Width="450px" TextMode="MultiLine" Height="60px"></asp:TextBox>
        </td>
        <td valign="top">
            &nbsp;
        </td>
    </tr>
    <tr runat="server" id="tr_id_6">
        <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" rowspan="1" valign="top">
            <asp:Label ID="Label16" runat="server" Text="<%$Resources:Master, event_keyword%>" ForeColor="#996633"></asp:Label>
        </td>
        <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>">
            <asp:TextBox ID="txtLinkWords" runat="server" Width="100%" TextMode="MultiLine"
                Height="60px"></asp:TextBox>
                <asp:Label ID="Label1" runat="server" 
                    Text="يرجى إدخال الكلمات الدالة مفصولة برمز (-) أو (،) فيما بينها كما بالمثال التالى كلمة دالة 1 - كلمة دالة 2" 
                 Font-Size="12px" ForeColor="Red" ></asp:Label>
              
        </td>
        <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" valign="top">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ValidationGroup="A" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txtLinkWords" Font-Size="14px" Width="100px"></asp:RequiredFieldValidator><br />
            
        </td>
    </tr>
    <tr runat="server" id="tr_id_7">
        <td dir="<%$Resources:Master, dir%>" rowspan="1" valign="top">
            <asp:Label ID="Label17" runat="server" Text="العصر الذي يتناوله الحدث ويدور حوله  : "
                ForeColor="#996633"></asp:Label>
        </td>
        <td>
            <asp:CheckBoxList ID="chk_periods" runat="server" RepeatColumns="4" RepeatDirection="Horizontal"
                Width="450px" DataTextField="title" DataValueField="id">
               
            </asp:CheckBoxList>
            <br />
        </td>
        <td valign="top">
            &nbsp;
        </td>
    </tr>
    <%--<tr runat="server" id="tr_id_8">
        <td dir="<%$Resources:Master, dir%>" rowspan="1" valign="top">
            <asp:Label ID="Label18" runat="server" Text="ملاحظات  : " Height="50px" ForeColor="#996633"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtTimelineNotes" runat="server" Height="50px" Width="390px" TextMode="MultiLine" />
        </td>
        <td>
            &nbsp;
        </td>
    </tr>--%>
    <tr runat="server" id="tr_id_9">
        <td dir="<%$Resources:Master, dir%>" rowspan="1" valign="top">
            <asp:Label ID="Label19" runat="server" Text="الصورة المرفقة مع الاستمارة  : " ForeColor="#996633"></asp:Label>
        </td>
        <td>
            <asp:RadioButtonList ID="rblFormImage" runat="server" RepeatColumns="1" 
                RepeatDirection="Horizontal" Width="100%">
                <asp:ListItem Value="1" Text="مرفقة (ورقية / إلكترونية)"></asp:ListItem>
                <asp:ListItem Value="2" Text="غير متاحة (سيتم توفيرها لاحقا)" Selected="True"></asp:ListItem>
                <asp:ListItem Value="0" Text="غير متاحة (استخدم الصورة الرمزية)"></asp:ListItem>
            </asp:RadioButtonList>
        </td>
        <td>
            &nbsp;
        </td>
    </tr>
    <tr runat="server" id="tr_id_10">
        <td dir="<%$Resources:Master, dir%>" rowspan="1" valign="top">
            <asp:Label ID="Label20" runat="server" Text="اسم جامع بيانات الاستمارة  : " Width="150px"
                Height="26px" ForeColor="#996633"></asp:Label>
        </td>
        <td dir="<%$Resources:Master, dir%>" rowspan="1" valign="top">
            <asp:TextBox ID="txtFormDataColectorName" runat="server" Width="100%" />
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txtFormDataColectorName" Font-Size="14px" ValidationGroup="A"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr runat="server" id="tr_id_11">
        <td dir="<%$Resources:Master, dir%>" rowspan="1" valign="top">
            <asp:Label ID="Label21" runat="server" Text="اسم مراجع بيانات الاستمارة  : " Width="155px"
                Height="26px" ForeColor="#996633"></asp:Label>
        </td>
        <td dir="<%$Resources:Master, dir%>" rowspan="1" valign="top">
            <asp:TextBox ID="txtFormDataRevisionName" runat="server" Width="100%" />
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ValidationGroup="A" ErrorMessage="هذا الحقل يجب إدخاله"
                ControlToValidate="txtFormDataRevisionName" Font-Size="14px"></asp:RequiredFieldValidator>
        </td>
    </tr>
   
    <tr runat="server" id="file_tr">
        <td align="<%$Resources:Master, align%>" dir="<%$Resources:Master, dir%>" rowspan="1" valign="top">
            <asp:Label ID="Label2" runat="server" 
                Text="<%$ Resources:Master, event_upload %>" Width="200px"
                Height="26px" ForeColor="#996633"></asp:Label>
        </td>
        <td dir="ltr" rowspan="1" valign="top" align="left">
            <asp:Label ID="Label55" runat="server" Font-Size="14px" ForeColor="Red" Width="40%" Visible="False"></asp:Label>
            <asp:FileUpload ID="uploadfile" runat="server" Width="58%" />
        </td>
        <td>
            <asp:Label ID="labfile" runat="server" Text="Label" Visible="False" Font-Size="14px"
                ForeColor="Red"></asp:Label>
        </td>
    </tr>
    <tr>
        <td align="center" colspan="3" height="60px" valign="middle">
            <asp:Button ID="btnsave" runat="server" Text="حفظ بيانات الاستمارة" ValidationGroup="A" OnClick="btnsave_Click"
                Style="height: 26px" OnClientClick="ValidateAndShowPopup()" />
        </td>
    </tr>
</table>
