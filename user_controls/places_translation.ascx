<%@ Control Language="C#" AutoEventWireup="true" CodeFile="places_translation.ascx.cs" Inherits="user_controls_places_translation" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:HiddenField id="content_id" Visible="false" runat="server"/>
<asp:HiddenField id="content_type" Visible="false" runat="server"/>
<asp:TextBox ID="hiddintxtInputDiv11" runat="server"   
            ForeColor="White"   BackColor="White" Height="26px"
            BorderColor="#000CCC" BorderStyle="None" Width="5px" ></asp:TextBox>
 <asp:TextBox ID="hiddintxtInputDiv22" runat="server" 
ForeColor="White"   BackColor="White" Height="26px"
BorderColor="#000CCC" BorderStyle="None" Width="5px" ></asp:TextBox>
 <asp:TextBox ID="hiddintxtInputDiv33" runat="server" 
ForeColor="White"   BackColor="White" Height="26px"
BorderColor="#000CCC" BorderStyle="None" Width="5px" ></asp:TextBox>
 <asp:TextBox ID="hiddintxtInputDiv44" runat="server" 
ForeColor="White"   BackColor="White" Height="26px"
BorderColor="#000CCC" BorderStyle="None" Width="5px" ></asp:TextBox>
 <asp:TextBox ID="hiddintxtInputDiv55" runat="server"   
ForeColor="White"   BackColor="White" Height="26px"
BorderColor="#000CCC" BorderStyle="None" Width="5px" ></asp:TextBox>
 <asp:TextBox ID="hiddintxtInputDiv66" runat="server" 
            ForeColor="White"   BackColor="White" Height="26px"
            BorderColor="#000CCC" BorderStyle="None" Width="5px" ></asp:TextBox>
 <script language="javascript" type="text/javascript"> 
    function show_hide_places(controlID)
        {
             if(controlID=="Div11")
            {
                var param="<%=Div11.ClientID %>";
                var hiddenparam="<%=hiddintxtInputDiv11.ClientID %>";
            }
            else if(controlID=="Div22")
            {
                var param="<%=Div22.ClientID %>"
                var hiddenparam="<%=hiddintxtInputDiv22.ClientID %>";
            }
             
             else if(controlID=="Div44")
            {
                var param="<%=Div44.ClientID %>"
                var hiddenparam="<%=hiddintxtInputDiv44.ClientID %>";
            }
             else if(controlID=="Div55")
            {
                var param="<%=Div55.ClientID %>"
                var hiddenparam="<%=hiddintxtInputDiv55.ClientID %>";
            }
             else if(controlID=="Div66")
            {
                var param="<%=Div66.ClientID %>"
                var hiddenparam="<%=hiddintxtInputDiv66.ClientID %>";
            }
            var ctrID =  document.getElementById(param);
            var hiddinInputCtrID = document.getElementById(hiddenparam);
           
            if(ctrID.style.display == 'none')
               {
                ctrID.style.display = 'block';
                hiddinInputCtrID.value="1";
               } 
                
            else
            {
                ctrID.style.display = 'none';
                hiddinInputCtrID.value="0";
               
             }
             
             if(ctrID.id=='ctl00_ContentPlaceHolder1_ctl06_Div11')
             {
             document.getElementById("ctl00_ContentPlaceHolder1_ctl06_hiddintxtInputDiv11").Text="1";
             }
             else if(ctrID.id=='ctl00_ContentPlaceHolder1_ctl06_Div22')
             {
             document.getElementById("ctl00_ContentPlaceHolder1_ctl06_hiddintxtInputDiv22").Text="1";
             }
            
             else if(ctrID.id=='ctl00_ContentPlaceHolder1_ctl06_Div44')
             {
             document.getElementById("ctl00_ContentPlaceHolder1_ctl06_hiddintxtInputDiv44").Text="1";
             }
             else if(ctrID.id=='ctl00_ContentPlaceHolder1_ctl06_Div55')
             {
             document.getElementById("ctl00_ContentPlaceHolder1_ctl06_hiddintxtInputDiv55").Text="1";
             }
             else if(ctrID.id=='ctl00_ContentPlaceHolder1_ctl06_Div66')
             {
             document.getElementById("ctl00_ContentPlaceHolder1_ctl06_hiddintxtInputDiv66").Text="1";
             }

         }
         function GetRadioButtonListstyleSelectedValue(rbl_architectural_styles_type) {
             var rblselectedval;
             for (var i = 0; i < rbl_architectural_styles_type.rows.length; ++i) {
                 for (var j = 0; j < rbl_architectural_styles_type.rows[i].cells.length; ++j) {
                     if (rbl_architectural_styles_type.rows[i].cells[j].firstChild != null) {
                         if (rbl_architectural_styles_type.rows[i].cells[j].firstChild.checked) {


                             rblselectedval = rbl_architectural_styles_type.rows[i].cells[j].firstChild.value;
                             // alert(rblselectedval);
                         }
                     }
                 }
             }
             var param = "<%=txt_architectural_styles_type_other.ClientID %>"

             var ctrID = document.getElementById(param);
             if (rblselectedval == 12) {
                 ctrID.style.display = 'block';

             }

             else {
                 ctrID.style.display = 'none';


             }

         }
         function GetRadioButtonListarchSelectedValue(rbl_architectural_element) {
             var rblselectedval;
             for (var i = 0; i < rbl_architectural_element.rows.length; ++i) {
                 for (var j = 0; j < rbl_architectural_element.rows[i].cells.length; ++j) {
                     if (rbl_architectural_element.rows[i].cells[j].firstChild != null) {
                         if (rbl_architectural_element.rows[i].cells[j].firstChild.checked) {


                             rblselectedval = rbl_architectural_element.rows[i].cells[j].firstChild.value;
                             // alert(rblselectedval);
                         }
                     }
                 }
             }
             var param = "<%=txt_architectural_element_other.ClientID %>"

             var ctrID = document.getElementById(param);
             if (rblselectedval == 3) {
                 ctrID.style.display = 'block';

             }

             else {
                 ctrID.style.display = 'none';


             }

         }
       
    </script>
  
      
<table id="tblPlaces" style="width:750px" border="0" cellspacing="5" runat="server" dir='<%$Resources:Master, dir%>' > 
  
 <tr runat="server" id="trOtherName">
    <td colspan="3">
   
         <fieldset >
                    <legend ><a id="A2" href="javascript:void(1)" style="text-decoration: none;" runat="server"
                        onclick="show_hide_places('Div11');">
                        <%--'<%=Div1.ClientID%>'--%>
                        <asp:Label ID="Label17" runat="server"  ForeColor="#996633" Text="<%$ Resources:Master, Places_labels_otherNames %>"></asp:Label></a>
                    </legend>
                    <div  id="Div11" runat="server" style="display: none;">
                      <table width="100%" runat="server" id="tblOtherName">
                          <tr >
                            <td align="right" dir="rtl" valign="top" colspan="2">
                               
                                <asp:Label ID="lblages" runat="server" Text="- العصر : " Height="26px"
                                    Width="55px"></asp:Label>
                                    <br />
                                     &nbsp;
                               <asp:DropDownList ID="ddl_name_age" runat="server" Width="90%"
                                    ValidationGroup="name"></asp:DropDownList>
                                <br />
                                <br />
                                <asp:Label ID="Label2" runat="server" 
                                    Text="- الإسم في ذلك العصر : " Height="26px"
                                    Width="125px"></asp:Label>
                                    <br />
                                     &nbsp;
                                <asp:TextBox ID="txt_name_in_age" runat="server" Height="26px" Width="90%"  ValidationGroup="name"></asp:TextBox>
                                <br />
                                <br />
                                <asp:Label ID="Label3" runat="server" Text="- ملاحظة : " Height="26px"
                                    Width="60px"></asp:Label>
                                     <br />
                                     &nbsp;
                                <asp:TextBox ID="txt_name_note" runat="server" Height="26px" Width="90%"  ></asp:TextBox>
                                
                                
                                    
                                 <br />
                                 <br />
                                  <asp:Button ID="btn_save_names" runat="server" Text="أضف إسم"  ValidationGroup="name"
                                    OnClick="btn_save_names_click" style="margin-right: 250px" />
                                  <br />
                                  <asp:Button ID="btn_save_names_translated1" runat="server" Text="ترجم إسم"  
                                    OnClick="btn_save_names_click" style="margin-right: 250px" Visible="false" />
                                  <br />
                                  <asp:GridView runat="server" ID="gv_names" Visible="false" AutoGenerateColumns="False"
                                                        Width="90%" CellPadding="4" ForeColor="#333333" 
                                    GridLines="None" DataKeyNames="id">
                                                        <HeaderStyle BackColor="#D9C69E"  ForeColor="White" HorizontalAlign="Center" />
                                                        <Columns>
                                                            <asp:BoundField DataField="name_in_age" ShowHeader="true" HeaderText="الاسم " ItemStyle-HorizontalAlign="Center"
                                                                ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1px"
                                                                HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px"
                                                                HeaderStyle-HorizontalAlign="Center" >
                        <HeaderStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid"></HeaderStyle>

                        <ItemStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid"></ItemStyle>
                                                            </asp:BoundField>
                                                            <asp:BoundField DataField="name_age_en" ShowHeader="true" HeaderText=" الاسم بالانجليزية" ItemStyle-HorizontalAlign="Center"
                                                                ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1px"
                                                                HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px"
                                                                HeaderStyle-HorizontalAlign="Center" >
                        <HeaderStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid"></HeaderStyle>

                        <ItemStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid"></ItemStyle>
                                                            </asp:BoundField>
                                                            <%--<asp:TemplateField HeaderText=" الاسم بالانجليزية" ItemStyle-HorizontalAlign="Center">
                                                                <ItemTemplate>
                                                                    <asp:TextBox id="txt_name_age_en" Text='<%# Eval("name_age_en") %>' runat="server">
                                                                    </asp:TextBox>
                                                                    <asp:TextBox id="txt_id" Text='<%# Eval("id") %>' runat="server" Visible="false">
                                                                    </asp:TextBox>
                                                                </ItemTemplate>
                                                                <HeaderStyle HorizontalAlign="Center"  BorderColor="Black" BorderStyle="Solid"
                                                                    BorderWidth="1px"></HeaderStyle>
                                                                <ItemStyle HorizontalAlign="Center"  BorderColor="Black" BorderStyle="Solid"
                                                                    BorderWidth="1px"></ItemStyle>
                                                            </asp:TemplateField>--%>
                                                            <asp:BoundField DataField="name_age_fr" ShowHeader="true" HeaderText="الاسم بالفرنسية " ItemStyle-HorizontalAlign="Center"
                                                                ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1px"
                                                                HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px"
                                                                HeaderStyle-HorizontalAlign="Center" >
                        <HeaderStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid"></HeaderStyle>

                        <ItemStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid"></ItemStyle>
                                                            </asp:BoundField>
                                                            <asp:BoundField DataField="title" ShowHeader="true" HeaderText="العصر" ItemStyle-HorizontalAlign="Center"
                                                                ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1px"
                                                                HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px"
                                                                HeaderStyle-HorizontalAlign="Center" >
                        <HeaderStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid"></HeaderStyle>

                        <ItemStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid"></ItemStyle>
                                                            </asp:BoundField>
                                                            <asp:BoundField DataField="name_note" ShowHeader="true" HeaderText="ملاحظة"
                                                                ItemStyle-HorizontalAlign="Center" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid"
                                                                ItemStyle-BorderWidth="1px" HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid"
                                                                HeaderStyle-BorderWidth="1px" HeaderStyle-HorizontalAlign="Center" >
                        <HeaderStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid"></HeaderStyle>

                        <ItemStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid"></ItemStyle>
                                                            </asp:BoundField>
                                                             <asp:TemplateField HeaderText="ترجمة" ItemStyle-HorizontalAlign="Center">
                                                                <ItemTemplate>
                                                                    <asp:ImageButton ID="imgTranslate1" CommandName="names" CommandArgument='<%# Eval("id") %>'
                                                                      OnClick="imgTranslate_Click" runat="server" ImageUrl="~/images/Edit.jpg" >
                                                                    </asp:ImageButton>
                                                                </ItemTemplate>
                                                                <HeaderStyle HorizontalAlign="Center" Width="3px" BorderColor="Black" BorderStyle="Solid"
                                                                    BorderWidth="1px"></HeaderStyle>
                                                                <ItemStyle HorizontalAlign="Center" Width="3px" BorderColor="Black" BorderStyle="Solid"
                                                                    BorderWidth="1px"></ItemStyle>
                                                            </asp:TemplateField>
                                                        
                                                            <asp:TemplateField HeaderText="تعديل" ItemStyle-HorizontalAlign="Center">
                                                                <ItemTemplate>
                                                                    <asp:ImageButton ID="imgEdit" CommandName="names" CommandArgument='<%# Eval("id") %>'
                                                                        OnClick="imgEdit_Click" runat="server" ImageUrl="~/images/Edit.jpg" >
                                                                    </asp:ImageButton>
                                                                </ItemTemplate>
                                                                <HeaderStyle HorizontalAlign="Center" Width="3px" BorderColor="Black" BorderStyle="Solid"
                                                                    BorderWidth="1px"></HeaderStyle>
                                                                <ItemStyle HorizontalAlign="Center" Width="3px" BorderColor="Black" BorderStyle="Solid"
                                                                    BorderWidth="1px"></ItemStyle>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="حذف" ItemStyle-HorizontalAlign="Center">
                                                                <ItemTemplate>
                                                                    <asp:ImageButton ID="imgDelete" CommandName="names" CommandArgument='<%# Eval("id") %>'
                                                                        OnClick="imgDelete_Click" runat="server" ImageUrl="~/images/delete.gif" OnClientClick="if (confirm('هل تود الحذف نهائياً') == false) return false;">
                                                                    </asp:ImageButton>
                                                                </ItemTemplate>
                                                                <HeaderStyle HorizontalAlign="Center" Width="3px" BorderColor="Black" BorderStyle="Solid"
                                                                    BorderWidth="1px"></HeaderStyle>
                                                                <ItemStyle HorizontalAlign="Center" Width="3px" BorderColor="Black" BorderStyle="Solid"
                                                                    BorderWidth="1px"></ItemStyle>
                                                            </asp:TemplateField>
                                                        </Columns>
                                                    </asp:GridView>
                                                     <%--<asp:Button ID="btn_save_names_translated" runat="server" Text="ترجم "  
                                    OnClick="btn_save_names_click" style="margin-right: 250px" Visible="false" />--%>
                                   <asp:TextBox ID="txt_name_id" runat="server" Height="26px"  
                                    ForeColor="White"   BackColor="White" 
                                    BorderColor="#000CCC" BorderStyle="None" Width="300px" ></asp:TextBox>
                                    
                            </td>
                            <td align="right" dir="rtl" valign="top">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"  InitialValue=".. اختر عصر .."
                                    ErrorMessage="هذا الحقل يجب إدخاله" ControlToValidate="ddl_name_age" ValidationGroup="name"
                                     Font-Size="14px" ></asp:RequiredFieldValidator>  
                                    <br />
                                    <br />
                                    <br />
                                     <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" 
                                    ErrorMessage="هذا الحقل يجب إدخاله" ControlToValidate="txt_name_in_age" ValidationGroup="name"
                                     Font-Size="14px"></asp:RequiredFieldValidator>  
                            </td>
                            </tr>
                        </table>
                    </div>
                </fieldset>
               
    </td>
   </tr>
   
   
   <tr runat="server" id="trSubArchitecture">
    <td colspan="3">
         <fieldset>
                    <legend><a id="A1" href="javascript:void(2)" style="text-decoration: none;" runat="server"
                        onclick="show_hide_places('Div22');">
                        <%--'<%=Div1.ClientID%>'--%>
                        <asp:Label ID="Label1" runat="server"  ForeColor="#996633" Text="<%$ Resources:Master, Places_Sub_style %>"></asp:Label></a>
                    </legend>
                    <div style="display: none;" id="Div22" runat="server">
                            <table width="100%"  runat="server" id="tblSubArchitecture">
                        
     <tr>
      
        <td valign="top" align="right" dir="rtl" colspan="2">
        <br />
        &nbsp;
        <asp:Label ID="Label55" runat="server" 
                Text="- الطراز : " Width="90%"></asp:Label>
                <br />&nbsp;&nbsp;
            <asp:RadioButtonList ID="rbl_architectural_styles_type" runat="server" RepeatColumns="3" ValidationGroup="architectural"
            RepeatDirection="Horizontal" Width="90%" onclick="GetRadioButtonListstyleSelectedValue(this);">
           
        </asp:RadioButtonList>
             <br />
        
       <%-- <asp:Label ID="lbl_architectural_styles_type_other" runat="server" Text="اخرى :" Height="26px" 
             Width="90%"></asp:Label>
             <br />&nbsp;--%>
        <asp:TextBox ID="txt_architectural_styles_type_other" runat="server" 
                 Width="90%" style="display:none"></asp:TextBox>
            <br />
                 <br /> 
        &nbsp;
           <asp:Label ID="Label54" runat="server" 
                Text="- العنصر المعماري الخاص بهذا الطراز : " Width="100%"></asp:Label><br />&nbsp;&nbsp;
         <asp:RadioButtonList ID="rbl_architectural_element" runat="server" ValidationGroup="architectural"
            Width="90%" RepeatDirection="Horizontal" onclick="GetRadioButtonListarchSelectedValue(this);">
            
        </asp:RadioButtonList>
          <br />
          
      <%--  <asp:Label ID="lbl_architectural_element_other" runat="server" Text="اخرى :" Height="26px" 
             Width="90%"></asp:Label>
              <br />&nbsp;--%>
        <asp:TextBox ID="txt_architectural_element_other" runat="server" 
                Width="90%" style="display:none"></asp:TextBox>
            <br />
                  <br /> &nbsp;
            <asp:Label ID="Label52" runat="server" Height="26px" 
                Text="<%$ Resources:Master, Places_labels_generalView %> " Width="90%"></asp:Label>
                 <br />&nbsp;
           <asp:TextBox ID="txt_architectural_styles_type_general_feature" runat="server" 
                Height="52px" Width="90%" 
                TextMode="MultiLine" ></asp:TextBox>
            <br /> &nbsp;
            <asp:Label ID="Label53" runat="server" Height="26px" Text="<%$ Resources:Master, Places_labels_generalNotes %>" 
                Width="90%"></asp:Label>
                 <br />&nbsp;
            <asp:TextBox ID="txt_architectural_styles_type_notes" runat="server" 
                Height="26px" Width="90%"></asp:TextBox>
             <br />
         <br />
          <asp:Button ID="btn_save_style" runat="server" Text="أضف طراز" 
            OnClick="btn_save_style_click" style="margin-right: 200px" ValidationGroup="architectural" />
             
          <br />
          <asp:Button ID="btn_save_style_translate" runat="server" Text="ترجم طراز" 
            OnClick="btn_save_style_click" style="margin-right: 200px" Visible="False" />
          <br />
          
          <asp:GridView runat="server" ID="gv_architectural_styles" Visible="false" AutoGenerateColumns="False"
                                Width="90%" CellPadding="4" ForeColor="#333333" 
            GridLines="None" DataKeyNames="id">
           
                                <HeaderStyle BackColor="#D9C69E"  ForeColor="White" HorizontalAlign="Center" />
                                <Columns>
                                    <asp:BoundField DataField="architectural_styles_type_general_feature" ShowHeader="true" HeaderText="وصف الملامح العامة" ItemStyle-HorizontalAlign="Center"
                                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1px"
                                        HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px"
                                        HeaderStyle-HorizontalAlign="Center" >
<HeaderStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid"></HeaderStyle>

<ItemStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="architectural_styles_type_general_feature_en" ShowHeader="true" HeaderText="وصف الملامح العامة بالانجليزية" ItemStyle-HorizontalAlign="Center"
                                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1px"
                                        HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px"
                                        HeaderStyle-HorizontalAlign="Center" >
<HeaderStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid"></HeaderStyle>

<ItemStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="architectural_styles_type_general_feature_fr" ShowHeader="true" HeaderText="وصف الملامح العامة بالفرنسية" ItemStyle-HorizontalAlign="Center"
                                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1px"
                                        HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px"
                                        HeaderStyle-HorizontalAlign="Center" >
<HeaderStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid"></HeaderStyle>

<ItemStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="con_title" ShowHeader="true" HeaderText="الطراز" ItemStyle-HorizontalAlign="Center"
                                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1px"
                                        HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px"
                                        HeaderStyle-HorizontalAlign="Center" >
<HeaderStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid"></HeaderStyle>

<ItemStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="con_elemnt" ShowHeader="true" HeaderText="العنصر المعمارى"
                                        ItemStyle-HorizontalAlign="Center" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid"
                                        ItemStyle-BorderWidth="1px" HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid"
                                        HeaderStyle-BorderWidth="1px" HeaderStyle-HorizontalAlign="Center" >
<HeaderStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid"></HeaderStyle>

<ItemStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="architectural_styles_type_notes" ShowHeader="true" HeaderText="ملاحظة"
                                        ItemStyle-HorizontalAlign="Center" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid"
                                        ItemStyle-BorderWidth="1px" HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid"
                                        HeaderStyle-BorderWidth="1px" HeaderStyle-HorizontalAlign="Center" >
<HeaderStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid"></HeaderStyle>

<ItemStyle HorizontalAlign="Center" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid"></ItemStyle>
                                    </asp:BoundField>
                                     <asp:TemplateField HeaderText="ترجمة" ItemStyle-HorizontalAlign="Center">
                                        <ItemTemplate>
                                            <asp:ImageButton ID="imgTranslate2" CommandName="architectural_styles" CommandArgument='<%# Eval("id") %>'
                                                OnClick="imgTranslate_Click" runat="server" ImageUrl="~/images/Edit.jpg" CausesValidation="false"  >
                                            </asp:ImageButton>
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Center" Width="3px" BorderColor="Black" BorderStyle="Solid"
                                            BorderWidth="1px"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" Width="3px" BorderColor="Black" BorderStyle="Solid"
                                            BorderWidth="1px"></ItemStyle>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="تعديل" ItemStyle-HorizontalAlign="Center">
                                        <ItemTemplate>
                                            <asp:ImageButton ID="imgEdit" CommandName="architectural_styles" CommandArgument='<%# Eval("id") %>'
                                                OnClick="imgEdit_Click" runat="server" ImageUrl="~/images/Edit.jpg" >
                                            </asp:ImageButton>
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Center" Width="3px" BorderColor="Black" BorderStyle="Solid"
                                            BorderWidth="1px"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" Width="3px" BorderColor="Black" BorderStyle="Solid"
                                            BorderWidth="1px"></ItemStyle>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="حذف" ItemStyle-HorizontalAlign="Center">
                                        <ItemTemplate>
                                            <asp:ImageButton ID="imgDelete" CommandName="architectural_styles" CommandArgument='<%# Eval("id") %>'
                                                OnClick="imgDelete_Click" runat="server" ImageUrl="~/images/delete.gif" OnClientClick="if (confirm('هل تود الحذف نهائياً') == false) return false;">
                                            </asp:ImageButton>
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Center" Width="3px" BorderColor="Black" BorderStyle="Solid"
                                            BorderWidth="1px"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" Width="3px" BorderColor="Black" BorderStyle="Solid"
                                            BorderWidth="1px"></ItemStyle>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                             <asp:TextBox ID="txt_architectural_styles_id" runat="server" Height="26px"  
            ForeColor="white"   BackColor="white" 
            BorderColor="#000CCC" BorderStyle="None" Width="300px" ></asp:TextBox>
         </td>
         <td align="right" dir="rtl" valign="top">
          <br />
                                    <br />
         <asp:RequiredFieldValidator ID="RequiredFieldValidator22" runat="server"  
                                    ErrorMessage="هذا الحقل يجب إدخاله" ControlToValidate="rbl_architectural_styles_type" ValidationGroup="architectural"
                                     Font-Size="14px" ></asp:RequiredFieldValidator>  
                                    <br />
                                    <br />
                                    <br /><br />
                                    <br />
                                    <br /><br />
                                    <br />
                                    <br /><br />
                                    <br />
                                    <br />
                                     <asp:RequiredFieldValidator ID="RequiredFieldValidator23" runat="server" 
                                    ErrorMessage="هذا الحقل يجب إدخاله" ControlToValidate="rbl_architectural_element" ValidationGroup="architectural"
                                     Font-Size="14px"></asp:RequiredFieldValidator>  
    </td>
    </tr>
                        </table>
                    </div>
                </fieldset>
    </td>
   </tr>
   <tr runat="server" id="trSubAddress">
    <td colspan="3">
         <fieldset>
                    <legend><a id="A4" href="javascript:void(4)" style="text-decoration: none;" runat="server"
                        onclick="show_hide_places('Div44');">
                        <%--'<%=Div1.ClientID%>'--%>
                        <asp:Label ID="Label48" runat="server"  ForeColor="#996633" Text="<%$ Resources:Master, Places_Site_through_age %>" ></asp:Label></a>
                    </legend>
                    <div style="display: none;" id="Div44" runat="server">
                            <table width="100%" runat="server" id="tblSubAddress">
                        
                     <tr>
      
        <td align="right" dir="rtl" valign="top" colspan="2">
          <asp:Label ID="Label77" runat="server" Text="- العصر : "
            Width="100%" Height="26px"></asp:Label>
        &nbsp;<asp:DropDownList ID="ddl_address_age" runat="server" Width="90%" ValidationGroup="address"></asp:DropDownList>
      
            <br />
            <br />
            <asp:Label ID="Label81" runat="server" Height="26px" 
                Text="<%$ Resources:Master, Places_lab_AgedetailedDesc %> " Width="100%"></asp:Label>
            <br />
            &nbsp; <asp:TextBox ID="txt_address_age_desc" runat="server" Height="75px" TextMode="MultiLine" ValidationGroup="address"
                Width="90%"></asp:TextBox>
            <br />
            <br />
      
              <asp:Label ID="Label80" runat="server" Height="26px" Text="<%$ Resources:Master, Plac_lab_AgeLocNotes %>" 
                Width="100%"></asp:Label>
            &nbsp; <asp:TextBox ID="txt_address_age_note" runat="server" Height="26px" 
                Width="90%"></asp:TextBox>
             <br />
            <br />
            <asp:Button ID="btn_save_address" runat="server" OnClick="btn_save_address_click" 
                style="margin-right: 200px" Text="أضف موقع" ValidationGroup="address"/>
            <br />
             <asp:Button ID="btn_save_address_translate" runat="server" OnClick="btn_save_address_click" 
                style="margin-right: 200px" Text="ترجم" Visible="False" />
            <br />
            <asp:GridView ID="gv_address" runat="server" AutoGenerateColumns="False" 
                CellPadding="4" DataKeyNames="id" ForeColor="#333333" GridLines="None" 
                Visible="false" Width="90%">
                <HeaderStyle BackColor="#D9C69E"  ForeColor="White" 
                    HorizontalAlign="Center" />
                <Columns>
                    <asp:BoundField DataField="address_age_desc" HeaderStyle-BorderColor="Black" 
                        HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" 
                        HeaderStyle-HorizontalAlign="Center" HeaderText="وصف الموقع" 
                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" 
                        ItemStyle-BorderWidth="1px" ItemStyle-HorizontalAlign="Center" 
                        ShowHeader="true">
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                    </asp:BoundField>
                      <asp:BoundField DataField="address_age_desc_en" HeaderStyle-BorderColor="Black" 
                        HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" 
                        HeaderStyle-HorizontalAlign="Center" HeaderText="وصف الموقع بالانجليزية" 
                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" 
                        ItemStyle-BorderWidth="1px" ItemStyle-HorizontalAlign="Center" 
                        ShowHeader="true">
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                    </asp:BoundField>
                      <asp:BoundField DataField="address_age_desc_fr" HeaderStyle-BorderColor="Black" 
                        HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" 
                        HeaderStyle-HorizontalAlign="Center" HeaderText="وصف الموقع بالفرنسية" 
                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" 
                        ItemStyle-BorderWidth="1px" ItemStyle-HorizontalAlign="Center" 
                        ShowHeader="true">
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="period_name" HeaderStyle-BorderColor="Black" 
                        HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" 
                        HeaderStyle-HorizontalAlign="Center" HeaderText="العصر" 
                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" 
                        ItemStyle-BorderWidth="1px" ItemStyle-HorizontalAlign="Center" 
                        ShowHeader="true">
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="address_age_note" HeaderStyle-BorderColor="Black" 
                        HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" 
                        HeaderStyle-HorizontalAlign="Center" HeaderText="ملاحظة" 
                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" 
                        ItemStyle-BorderWidth="1px" ItemStyle-HorizontalAlign="Center" 
                        ShowHeader="true">
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                    </asp:BoundField>
                     <asp:TemplateField HeaderText="ترجمة" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:ImageButton ID="imgTranslate3" CommandName="address" CommandArgument='<%# Eval("id") %>'
                                OnClick="imgTranslate_Click" runat="server" ImageUrl="~/images/Edit.jpg"  CausesValidation="False">
                            </asp:ImageButton>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Center" Width="3px" BorderColor="Black" BorderStyle="Solid"
                            BorderWidth="1px"></HeaderStyle>
                        <ItemStyle HorizontalAlign="Center" Width="3px" BorderColor="Black" BorderStyle="Solid"
                            BorderWidth="1px"></ItemStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="تعديل" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:ImageButton ID="imgEdit0" runat="server" 
                                CommandArgument='<%# Eval("id") %>' CommandName="address"
                                ImageUrl="~/images/Edit.jpg" OnClick="imgEdit_Click" />
                        </ItemTemplate>
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" Width="3px" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" Width="3px" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="حذف" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:ImageButton ID="imgDelete0" runat="server" 
                                CommandArgument='<%# Eval("id") %>' CommandName="address"
                                ImageUrl="~/images/delete.gif" OnClick="imgDelete_Click" 
                                OnClientClick="if (confirm('هل تود الحذف نهائياً') == false) return false;" />
                        </ItemTemplate>
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" Width="3px" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" Width="3px" />
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:TextBox ID="txt_address_id" runat="server" Height="26px"  
            ForeColor="white"   BackColor="white" 
            BorderColor="#000CCC" BorderStyle="None" Width="300px" ></asp:TextBox>
         </td>
         <td align="right" dir="rtl" valign="top">
          <br />
            <br />
           <asp:RequiredFieldValidator ID="RequiredFieldValidator26" runat="server"  InitialValue=".. اختر عصر .."
                                    ErrorMessage="هذا الحقل يجب إدخاله" ControlToValidate="ddl_address_age" ValidationGroup="address"
                                     Font-Size="14px" ></asp:RequiredFieldValidator>  
                                    <br />
                                    <br />
                                    <br /> <br />
                                    <br />
                                    <br />
                                     <asp:RequiredFieldValidator ID="RequiredFieldValidator27" runat="server" 
                                    ErrorMessage="هذا الحقل يجب إدخاله" ControlToValidate="txt_address_age_desc" ValidationGroup="address"
                                     Font-Size="14px"></asp:RequiredFieldValidator>  
    </td>
    </tr>
                        </table>
                    </div>
                </fieldset>
    </td>
   </tr>
   
   <tr runat="server" id="trEvolution">
    <td colspan="3">
         <fieldset>
                    <legend><a id="A5" href="javascript:void(5)" style="text-decoration: none;" runat="server"
                        onclick="show_hide_places('Div55');">
                        <%--'<%=Div1.ClientID%>'--%>
                        <asp:Label ID="Label49" runat="server"  ForeColor="#996633" Text="<%$ Resources:Master, Places_evo_through_age %>" ></asp:Label></a>
                    </legend>
                    <div style="display: none;" id="Div55" runat="server">
                            <table width="100%" runat="server" id="tblEvolution">
                        
                     <tr>
        
        <td align="right" dir="rtl" valign="top" colspan="2">
          <asp:Label ID="Label79" runat="server" Text="- العصر : "
            Width="100%" Height="26px"></asp:Label>&nbsp;
       <asp:DropDownList ID="ddl_architectural_evolution_age" runat="server" Width="90%" ValidationGroup="evolution"></asp:DropDownList>
      
            <br />
            <br />
             <asp:Label ID="Label88" runat="server" Height="26px" 
                Text="- تاريخ العمل : " Width="100%"></asp:Label>
            <br />&nbsp;
            <asp:Label ID="Label84" runat="server" Text="هجرى :" Width="90%" 
                Height="23px"></asp:Label><br />&nbsp;
            <asp:TextBox ID="txt_architectural_evolution_hijri_date" runat="server"  Height="20px"
                   Width="90%" />
                   
                   
           <br />
             &nbsp;
                <asp:Label ID="Label86" runat="server" Text="ميلادى :" Width="90%" 
                Height="23px"></asp:Label><br />&nbsp;
              <asp:TextBox ID="txt_architectural_evolution_georg_date" runat="server"  Height="20px"
                   Width="90%" />
                
                   
             
              
            <br />
            <br />
            
            <asp:Label ID="Label89" runat="server" Height="26px" 
                Text="- الشخصية المعنية بالتطوير : " Width="100%"></asp:Label>
            <br />&nbsp;
            <asp:TextBox ID="txt_architectural_evolution_person" runat="server" 
                Width="90%" Height="26px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label82" runat="server" Height="26px" 
                Text="- وصف العمل : " Width="100%"></asp:Label>
            <br />&nbsp;
            <asp:TextBox ID="txt_architectural_evolution_desc" runat="server" Height="75px" TextMode="MultiLine" 
                Width="90%"></asp:TextBox>
            <br />
            <br />
      
              <asp:Label ID="Label83" runat="server" Height="26px" Text="- ملاحظة : " 
                Width="100%"></asp:Label>  <br />&nbsp;
            <asp:TextBox ID="txt_architectural_evolution_note" runat="server" Height="26px" 
                Width="90%"></asp:TextBox>
             <br />
            <br />
            <asp:Button ID="btn_save_evolution" runat="server" OnClick="btn_save_evolution_click" 
                style="margin-right: 250px" Text="أضف تطور" />
            <br />
            <asp:Button ID="btn_save_evolution_translate" runat="server" OnClick="btn_save_evolution_click" 
                style="margin-right: 250px" Text="ترجم" Visible="False" />
            <br />&nbsp;
            <asp:GridView ID="gv_evolution" runat="server" AutoGenerateColumns="False" 
                CellPadding="4" DataKeyNames="id" ForeColor="#333333" GridLines="None" 
                Visible="false" Width="90%">
                <HeaderStyle BackColor="#D9C69E"  ForeColor="White" 
                    HorizontalAlign="Center" />
                <Columns>
                    <asp:BoundField DataField="period_name" HeaderStyle-BorderColor="Black" 
                        HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" 
                        HeaderStyle-HorizontalAlign="Center" HeaderText="العصر" 
                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" 
                        ItemStyle-BorderWidth="1px" ItemStyle-HorizontalAlign="Center" 
                        ShowHeader="true">
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                    </asp:BoundField>
                     <asp:BoundField DataField="architectural_evolution_hijri_date" HeaderStyle-BorderColor="Black" 
                        HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" 
                        HeaderStyle-HorizontalAlign="Center" HeaderText="هجرى" 
                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" 
                        ItemStyle-BorderWidth="1px" ItemStyle-HorizontalAlign="Center" 
                        ShowHeader="true">
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                    </asp:BoundField>
                     <asp:BoundField DataField="architectural_evolution_georg_date" HeaderStyle-BorderColor="Black" 
                        HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" 
                        HeaderStyle-HorizontalAlign="Center" HeaderText="ميلادى" 
                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" 
                        ItemStyle-BorderWidth="1px" ItemStyle-HorizontalAlign="Center" 
                        ShowHeader="true">
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="architectural_evolution_person" HeaderStyle-BorderColor="Black" 
                        HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" 
                        HeaderStyle-HorizontalAlign="Center" HeaderText="الشخصية المعنية بالتطوير" 
                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" 
                        ItemStyle-BorderWidth="1px" ItemStyle-HorizontalAlign="Center" 
                        ShowHeader="true">
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                    </asp:BoundField>
                     <asp:BoundField DataField="architectural_evolution_person_en" HeaderStyle-BorderColor="Black" 
                        HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" 
                        HeaderStyle-HorizontalAlign="Center" HeaderText="الشخصية المعنية بالتطوير بالانجليزية" 
                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" 
                        ItemStyle-BorderWidth="1px" ItemStyle-HorizontalAlign="Center" 
                        ShowHeader="true">
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                    </asp:BoundField>
                     <asp:BoundField DataField="architectural_evolution_person_fr" HeaderStyle-BorderColor="Black" 
                        HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" 
                        HeaderStyle-HorizontalAlign="Center" HeaderText="الشخصية المعنية بالتطوير بالفرنسية" 
                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" 
                        ItemStyle-BorderWidth="1px" ItemStyle-HorizontalAlign="Center" 
                        ShowHeader="true">
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="architectural_evolution_desc" HeaderStyle-BorderColor="Black" 
                        HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" 
                        HeaderStyle-HorizontalAlign="Center" HeaderText="وصف التطوير" 
                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" 
                        ItemStyle-BorderWidth="1px" ItemStyle-HorizontalAlign="Center" 
                        ShowHeader="true">
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="architectural_evolution_desc_en" HeaderStyle-BorderColor="Black" 
                        HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" 
                        HeaderStyle-HorizontalAlign="Center" HeaderText="وصف التطوير بالانجليزية" 
                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" 
                        ItemStyle-BorderWidth="1px" ItemStyle-HorizontalAlign="Center" 
                        ShowHeader="true">
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="architectural_evolution_desc_fr" HeaderStyle-BorderColor="Black" 
                        HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" 
                        HeaderStyle-HorizontalAlign="Center" HeaderText="وصف التطوير بالفرنسية" 
                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" 
                        ItemStyle-BorderWidth="1px" ItemStyle-HorizontalAlign="Center" 
                        ShowHeader="true">
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                    </asp:BoundField>
                     <asp:BoundField DataField="architectural_evolution_note" HeaderStyle-BorderColor="Black" 
                        HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" 
                        HeaderStyle-HorizontalAlign="Center" HeaderText="ملاحظة" 
                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" 
                        ItemStyle-BorderWidth="1px" ItemStyle-HorizontalAlign="Center" 
                        ShowHeader="true">
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                    </asp:BoundField>
                      <asp:TemplateField HeaderText="ترجمة" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:ImageButton ID="imgTranslate4" CommandName="evolution" CommandArgument='<%# Eval("id") %>'
                                OnClick="imgTranslate_Click" runat="server" ImageUrl="~/images/Edit.jpg" CausesValidation="False" >
                            </asp:ImageButton>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Center" Width="3px" BorderColor="Black" BorderStyle="Solid"
                            BorderWidth="1px"></HeaderStyle>
                        <ItemStyle HorizontalAlign="Center" Width="3px" BorderColor="Black" BorderStyle="Solid"
                            BorderWidth="1px"></ItemStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="تعديل" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:ImageButton ID="imgEdit0" runat="server" 
                                CommandArgument='<%# Eval("id") %>' CommandName="evolution"
                                ImageUrl="~/images/Edit.jpg" OnClick="imgEdit_Click" />
                        </ItemTemplate>
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" Width="3px" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" Width="3px" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="حذف" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:ImageButton ID="imgDelete0" runat="server" 
                                CommandArgument='<%# Eval("id") %>' CommandName="evolution"
                                ImageUrl="~/images/delete.gif" OnClick="imgDelete_Click" 
                                OnClientClick="if (confirm('هل تود الحذف نهائياً') == false) return false;" />
                        </ItemTemplate>
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" Width="3px" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" Width="3px" />
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:TextBox ID="txt_evolution_id" runat="server" Height="26px"  
            ForeColor="white"   BackColor="white" 
            BorderColor="#000CCC" BorderStyle="None" Width="300px" ></asp:TextBox>
         </td>
         <td align="right" dir="rtl" valign="top">
           <br />
            <br />
           <asp:RequiredFieldValidator ID="RequiredFieldValidator28" runat="server"  InitialValue=".. اختر عصر .."
                                    ErrorMessage="هذا الحقل يجب إدخاله" ControlToValidate="ddl_architectural_evolution_age" ValidationGroup="evolution"
                                     Font-Size="14px" ></asp:RequiredFieldValidator>  
    </td>
    </tr>
                        </table>
                    </div>
                </fieldset>
    </td>
   </tr>
      <tr runat="server" id="trSubRestoration">
    <td colspan="3">
         <fieldset>
                    <legend><a id="A6" href="javascript:void(6)" style="text-decoration: none;" runat="server"
                        onclick="show_hide_places('Div66');">
                        <%--'<%=Div1.ClientID%>'--%>
                        <asp:Label ID="Label50" runat="server"  ForeColor="#996633" Text="<%$ Resources:Master, Places_restoration_through_ages %>"></asp:Label></a>
                    </legend>
                    <div style="display: none;" id="Div66" runat="server">
                            <table width="100%"  runat="server" id="tblSubRestoration">
                        
                 <tr>
      
        <td align="right" dir="rtl" valign="top" colspan="2">
          <asp:Label ID="Label97" runat="server" Text="- العصر : "
            Width="12%" Height="26px"></asp:Label>
            <br />
                                     &nbsp;
       <asp:DropDownList ID="ddl_restoration_age" runat="server" Width="90%" ValidationGroup="restoration"></asp:DropDownList>
      
            <br />
            <br />
             <asp:Label ID="Label98" runat="server" Height="26px" 
                Text="- تاريخ الترميم : " Width="100%"></asp:Label>
            <br />
           
                                      &nbsp;&nbsp;
            <asp:Label ID="Label99" runat="server" Text="هجرى :" Width="40px" 
                Height="23px"></asp:Label>
            <asp:TextBox ID="txt_restoration_hijri_date" runat="server"  Height="20px"
                   Width="80px" />
                   
                  
           <br />
           
                                  &nbsp;&nbsp;
                <asp:Label ID="Label101" runat="server" Text="ميلادى :" Width="42px" 
                Height="23px"></asp:Label>
              <asp:TextBox ID="txt_restoration_georg_date" runat="server"  Height="20px"
                   Width="80px" />
                
                  
             
                   
            <br />
            <br />
            
            <asp:Label ID="Label103" runat="server" Height="26px" 
                Text="<%$ Resources:Master, Plac_lab_ageRestorationResp %>" Width="90%"></asp:Label>
            <br />
             &nbsp;&nbsp;
            <asp:TextBox ID="txt_restoration_person" runat="server" 
                Width="90%" Height="26px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label104" runat="server" Text="<%$ Resources:Master, Plac_lab_ageSharedResp %>" 
                Width="100%" Height="26px"></asp:Label>
          <br />
           &nbsp;&nbsp;
            <asp:TextBox ID="txt_restoration_participants" runat="server" Height="75px" 
                Width="90%" TextMode="MultiLine"></asp:TextBox>
              <br />
            <br />
           <asp:Label ID="Label106" runat="server" Text="<%$ Resources:Master, Plac_lab_ageFullProcessDesc %>" 
                Width="100%" Height="26px"></asp:Label>
          <br />
           &nbsp;&nbsp;
            <asp:TextBox ID="txt_restoration_desc" runat="server" Height="75px" 
                Width="90%" TextMode="MultiLine"></asp:TextBox>
              <br />
            <br />
           
              <asp:Label ID="Label105" runat="server" Height="26px" Text="<%$ Resources:Master, Place_lab_ageProcessNotes %>" 
                Width="60px"></asp:Label>
                 <br />
                  &nbsp;&nbsp;
            <asp:TextBox ID="txt_restoration_note" runat="server" Height="26px" 
                 Width="90%"></asp:TextBox>
             <br />
            <br />
            <asp:Button ID="btn_save_restoration" runat="server" OnClick="btn_save_restoration_click" 
                style="margin-right: 300px" Text="أضف ترميم"  ValidationGroup="restoration"/>
            <br />
            <asp:Button ID="btn_save_restoration_translate" runat="server" OnClick="btn_save_restoration_click" 
                style="margin-right: 300px" Text="ترجم"  Visible="false"/>
            <br />
            <asp:GridView ID="gv_restoration" runat="server" AutoGenerateColumns="False" 
                CellPadding="4" DataKeyNames="id" ForeColor="#333333" GridLines="None" 
                Visible="false" Width="90%">
                <HeaderStyle BackColor="#D9C69E"  ForeColor="White" 
                    HorizontalAlign="Center" />
                <Columns>
                    <asp:BoundField DataField="period_name" HeaderStyle-BorderColor="Black" 
                        HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" 
                        HeaderStyle-HorizontalAlign="Center" HeaderText="العصر" 
                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" 
                        ItemStyle-BorderWidth="1px" ItemStyle-HorizontalAlign="Center" 
                        ShowHeader="true">
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="restoration_hijri_date" HeaderStyle-BorderColor="Black" 
                        HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" 
                        HeaderStyle-HorizontalAlign="Center" HeaderText="هجرى" 
                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" 
                        ItemStyle-BorderWidth="1px" ItemStyle-HorizontalAlign="Center" 
                        ShowHeader="true">
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="restoration_georg_date" HeaderStyle-BorderColor="Black" 
                        HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" 
                        HeaderStyle-HorizontalAlign="Center" HeaderText="ميلادى" 
                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" 
                        ItemStyle-BorderWidth="1px" ItemStyle-HorizontalAlign="Center" 
                        ShowHeader="true">
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="restoration_person" HeaderStyle-BorderColor="Black" 
                        HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" 
                        HeaderStyle-HorizontalAlign="Center" HeaderText="المسئول عن الترميم" 
                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" 
                        ItemStyle-BorderWidth="1px" ItemStyle-HorizontalAlign="Center" 
                        ShowHeader="true">
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                    </asp:BoundField>
                      <asp:BoundField DataField="restoration_person_en" HeaderStyle-BorderColor="Black" 
                        HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" 
                        HeaderStyle-HorizontalAlign="Center" HeaderText="المسئول عن الترميم بالانجليزية" 
                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" 
                        ItemStyle-BorderWidth="1px" ItemStyle-HorizontalAlign="Center" 
                        ShowHeader="true">
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                    </asp:BoundField>
                      <asp:BoundField DataField="restoration_person_fr" HeaderStyle-BorderColor="Black" 
                        HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" 
                        HeaderStyle-HorizontalAlign="Center" HeaderText="المسئول عن الترميم بالفرنسية" 
                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" 
                        ItemStyle-BorderWidth="1px" ItemStyle-HorizontalAlign="Center" 
                        ShowHeader="true">
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="restoration_desc" HeaderStyle-BorderColor="Black" 
                        HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" 
                        HeaderStyle-HorizontalAlign="Center" HeaderText="وصف الترميم" 
                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" 
                        ItemStyle-BorderWidth="1px" ItemStyle-HorizontalAlign="Center" 
                        ShowHeader="true">
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                    </asp:BoundField>
                     <asp:BoundField DataField="restoration_desc_en" HeaderStyle-BorderColor="Black" 
                        HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" 
                        HeaderStyle-HorizontalAlign="Center" HeaderText="وصف الترميم بالانجليزية" 
                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" 
                        ItemStyle-BorderWidth="1px" ItemStyle-HorizontalAlign="Center" 
                        ShowHeader="true">
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                    </asp:BoundField>
                     <asp:BoundField DataField="restoration_desc_fr" HeaderStyle-BorderColor="Black" 
                        HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" 
                        HeaderStyle-HorizontalAlign="Center" HeaderText="وصف الترميم بالفرنسية" 
                        ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" 
                        ItemStyle-BorderWidth="1px" ItemStyle-HorizontalAlign="Center" 
                        ShowHeader="true">
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" />
                    </asp:BoundField>
                      <asp:TemplateField HeaderText="ترجمة" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:ImageButton ID="imgTranslate5" CommandName="restoration" CommandArgument='<%# Eval("id") %>'
                                OnClick="imgTranslate_Click" runat="server" ImageUrl="~/images/Edit.jpg" CausesValidation="false"  >
                            </asp:ImageButton>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Center" Width="3px" BorderColor="Black" BorderStyle="Solid"
                            BorderWidth="1px"></HeaderStyle>
                        <ItemStyle HorizontalAlign="Center" Width="3px" BorderColor="Black" BorderStyle="Solid"
                            BorderWidth="1px"></ItemStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="تعديل" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:ImageButton ID="imgEdit0" runat="server" 
                                CommandArgument='<%# Eval("id") %>' CommandName="restoration"
                                ImageUrl="~/images/Edit.jpg" OnClick="imgEdit_Click" />
                        </ItemTemplate>
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" Width="3px" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" Width="3px" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="حذف" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:ImageButton ID="imgDelete0" runat="server" 
                                CommandArgument='<%# Eval("id") %>' CommandName="restoration"
                                ImageUrl="~/images/delete.gif" OnClick="imgDelete_Click" 
                                OnClientClick="if (confirm('هل تود الحذف نهائياً') == false) return false;" />
                        </ItemTemplate>
                        <HeaderStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" Width="3px" />
                        <ItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                            HorizontalAlign="Center" Width="3px" />
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:TextBox ID="txt_restoration_id" runat="server" Height="26px"  
            ForeColor="white"   BackColor="white" 
            BorderColor="#000CCC" BorderStyle="None" Width="300px" ></asp:TextBox>
         </td>
         <td align="right" dir="rtl" valign="top">
         <br /><br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server"  InitialValue=".. اختر عصر .."
                                    ErrorMessage="هذا الحقل يجب إدخاله" ControlToValidate="ddl_restoration_age" ValidationGroup="restoration"
                                     Font-Size="14px" ></asp:RequiredFieldValidator>  
                                   
    </td>
    </tr>
                        </table>
                    </div>
                </fieldset>
    </td>
   </tr>
 </table>