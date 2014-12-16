<%@ Page Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true" CodeFile="files_revision.aspx.cs" Inherits="administration_files_revision" Title="Untitled Page" MaintainScrollPositionOnPostback="true" %>
<%@ Register Src="../user_controls/Smart_Search.ascx" TagName="Smart_Search" TagPrefix="uc7" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            height: 60px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <script language="javascript" type="text/javascript"> 
       function Openfile(str,type) 
       { 
        var url = 'veiw_files.aspx?fname='+str+'&type='+type
         window.open(url); 
       } 
</script> 
<input id="type_mode" type="hidden" runat="server"/>
<input id="errorID" type="hidden" runat="server"/>
<input id="newErrorCount" type="hidden" runat="server" value="0"/>
<table align="right" dir="rtl" width="100%">
 <tr>
    <td align="center" dir="rtl" height="60px">
        <asp:Label ID="lblpage" runat="server" Font-Names="Arial" Font-Size="15px"
                             Text="مراجعة الملفات" Font-Bold="true"></asp:Label>
    </td>
 </tr>
  <tr>
    <td align="center" dir="rtl" height="60px">
        <asp:Label ID="lblpageMsg" runat="server" Font-Names="Arial" Font-Size="15px" ForeColor="Red"
                             Text="" Font-Bold="true" Visible="false"></asp:Label>
    </td>
 </tr>
 <tr>
        <td height="60px" valign="middle" align="right" dir="rtl">
             <asp:Label ID="label2" runat="server" Text="نوع الملف : " Height="26px" 
                 Width="65px"></asp:Label>
                  
             <asp:DropDownList ID="ddlElementType" runat="server" Height="25px" 
                 Width="200px"  AutoPostBack="true" DataTextField="title" DataValueField="id"
                 onselectedindexchanged="ddlElementType_SelectedIndexChanged" >
                
             </asp:DropDownList>
             
             <br />
             <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ErrorMessage="* عفوا يجب إختيار عنصر" ControlToValidate="ddlElementType" 
                Font-Size="14px" InitialValue=".. اختر عنصر .." ValidationGroup="file" ></asp:RequiredFieldValidator>
        </td>
        </tr>
         <tr>
        <td valign="middle" height="60px" align="right" dir="rtl">
             <asp:Label ID="label3" runat="server" Text="الإسم : " Height="26px" 
                 Width="40px"></asp:Label>
                 
             <%--<asp:DropDownList ID="ddlElementName" runat="server" Height="26px" 
                 Width="500px"  AutoPostBack="true" 
                 onselectedindexchanged="ddlElementName_SelectedIndexChanged" >
               
             </asp:DropDownList>--%>
               <uc7:Smart_Search ID="Smrt_Srch_object"  runat="server"  />
              <br />
             <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
            ErrorMessage="* عفوا يجب إختيار اسم" ControlToValidate="ddlElementName" 
                Font-Size="14px" InitialValue=".. اختر اسم .." ValidationGroup="file"></asp:RequiredFieldValidator>--%>
        </td>
        </tr>
       <tr id="lockTr" runat="server" visible="false"> 
            <td align="right" colspan="2" dir="rtl">
                <asp:CheckBox ID="lockChckBox" Text="البدء في عمل هذه الاستمارة؟" runat="server" 
                    Height="26px" />&nbsp;&nbsp;&nbsp;
                <asp:Button ID="lockBtn" runat="server" Text="البدء" ValidationGroup="vgrup" 
                    onclick="lockBtn_Click" Height="26px" />
            </td>
        </tr>
      <tr>
        <td colspan="3">
            <asp:GridView ID="gvContentFiles" runat="server" AutoGenerateColumns="false"
             EmptyDataText=".. عفوا لاتوجد بيانات .." Width="100%" BorderColor="Black" 
                BorderStyle="Solid" BorderWidth="1px"  OnRowDataBound="gvContentFiles_RowDataBound" >
                <HeaderStyle BackColor="#D9C69E" Font-Bold="True" ForeColor="White" />
                <Columns>
                    <asp:TemplateField HeaderStyle-HorizontalAlign="Center" HeaderStyle-Width="3px" HeaderText="م"
                        ItemStyle-HorizontalAlign="Center" ItemStyle-Width="3px">
                        <ItemTemplate>
                            <%#Container.DataItemIndex + 1%>
                        </ItemTemplate>

<HeaderStyle HorizontalAlign="Center" Width="3px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"></HeaderStyle>

<ItemStyle HorizontalAlign="Center" Width="3px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"></ItemStyle>
                    </asp:TemplateField>
                    
                     <%--<asp:BoundField HeaderText="اسم الملف" DataField="title" ItemStyle-HorizontalAlign="Center" />--%>
                     <asp:TemplateField HeaderText="اسم الملف"  ItemStyle-HorizontalAlign="Center" ItemStyle-CssClass="linkdir" ControlStyle-CssClass="linkdir">
                            <ItemTemplate>
                              <asp:linkbutton id="title" runat="server" Text='<%# Eval("title") %>' 
                            
                                 
                                    CommandName= '<%#Container.DataItemIndex %>'  CausesValidation="false">
                                    </asp:linkbutton>
                                  <%-- <a href="#" runat="server" onclick="title_Click" target="_blank" ><%# Eval("title") %></a>--%>
                               <%-- <asp:ImageButton ID="ImgBtnEdit" runat="server" ImageUrl="../Images/Edit.jpg" 
                                CommandArgument='<%# Eval("id") %>'
                                    CommandName= '<%#Container.DataItemIndex %>' OnClick="ImgBtnEdit_Click" CausesValidation="false" />--%>
                              </ItemTemplate>

<HeaderStyle HorizontalAlign="Center"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"></HeaderStyle>

<ItemStyle HorizontalAlign="Center" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"></ItemStyle>
                        </asp:TemplateField>
                      <asp:BoundField HeaderText="استخدام الملف" DataField="usage"  HeaderStyle-Width="100px" ItemStyle-HorizontalAlign="Center" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1px"
                     HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" HeaderStyle-HorizontalAlign="Center" />
                     
                       
                           
                          
                </Columns>
             </asp:GridView>
        </td>
    </tr>
    <tr id="trfileUsage" visible="False" runat="server">
       
            <td align="right" dir="rtl" height="60px" valign="middle">
             <asp:Label ID="label10" runat="server" Text="استخدام الملف : " Height="26px" 
                 Width="85px"></asp:Label>
                <asp:DropDownList ID="ddlFileUsage" runat="server" Height="26px" 
                 Width="150px"  >
               
             </asp:DropDownList>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ErrorMessage="* عفوا يجب إختيار إستخدام" ControlToValidate="ddlFileUsage" 
                Font-Size="14px" InitialValue=".. اختر إستخدام .." ValidationGroup="file"></asp:RequiredFieldValidator>
            </td>
        </tr>
    <tr id="trErrorType" runat="server" visible="false">
        <td height="60px" valign="middle" align="right" dir="rtl">
             <asp:Label ID="label1" runat="server" Text="نوع الخطأ : " Height="26px" 
                 Width="65px"></asp:Label>
                  
             <asp:DropDownList ID="ddlErrorType" runat="server" Height="25px" 
                 Width="200px" AutoPostBack="True" onselectedindexchanged="ddlErrorType_SelectedIndexChanged"   >
                
             </asp:DropDownList>
            
             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ErrorMessage="* عفوا يجب إختيار نوع الخطأ" ControlToValidate="ddlErrorType" 
                Font-Size="14px" InitialValue=".. اختر نوع الخطأ .." ValidationGroup="file" ></asp:RequiredFieldValidator>
        </td>
    </tr>
     <tr id="trErrorNotes" runat="server" visible="false">
        <td height="60px" valign="top" align="right" dir="rtl">
             <asp:Label ID="label4" runat="server" Text="ملاحظات : "  Height="50px"
                 Width="65px"></asp:Label>
            <asp:TextBox id="txtErrorNote" runat="server" Width="500px" TextMode="MultiLine" Height="50px"></asp:TextBox> 
             <br />
            
        </td>
    </tr>
    <tr id="trAudVidErrors" runat="server" visible="false">
        <td valign="middle" align="right" dir="rtl" class="style1">
             <asp:Label ID="label5" runat="server" Text="مكان الخطأ : " Height="26px" 
                 Width="100px"></asp:Label>
                 <asp:Label ID="lblsecError" runat="server" Height="26px">الثانية </asp:Label>
             &nbsp; 
             <asp:DropDownList ID="ddlSec" runat="server" Height="26px" >
                <asp:ListItem Text="00" ></asp:ListItem><asp:ListItem Text="01" ></asp:ListItem>
                <asp:ListItem Text="02" ></asp:ListItem><asp:ListItem Text="03" ></asp:ListItem>
                <asp:ListItem Text="04" ></asp:ListItem><asp:ListItem Text="05" ></asp:ListItem>
                <asp:ListItem Text="06" ></asp:ListItem><asp:ListItem Text="07" ></asp:ListItem>
                <asp:ListItem Text="08" ></asp:ListItem><asp:ListItem Text="09" ></asp:ListItem>
                <asp:ListItem Text="10" ></asp:ListItem><asp:ListItem Text="11" ></asp:ListItem>
                <asp:ListItem Text="12" ></asp:ListItem><asp:ListItem Text="13" ></asp:ListItem>
                <asp:ListItem Text="14" ></asp:ListItem><asp:ListItem Text="15" ></asp:ListItem>
                <asp:ListItem Text="16" ></asp:ListItem><asp:ListItem Text="17" ></asp:ListItem>
                <asp:ListItem Text="18" ></asp:ListItem><asp:ListItem Text="19" ></asp:ListItem>
                <asp:ListItem Text="20" ></asp:ListItem><asp:ListItem Text="21" ></asp:ListItem>
                <asp:ListItem Text="22" ></asp:ListItem><asp:ListItem Text="23" ></asp:ListItem>
                <asp:ListItem Text="24" ></asp:ListItem><asp:ListItem Text="25" ></asp:ListItem>
                <asp:ListItem Text="26" ></asp:ListItem><asp:ListItem Text="27" ></asp:ListItem>
                <asp:ListItem Text="28" ></asp:ListItem><asp:ListItem Text="29" ></asp:ListItem>
                <asp:ListItem Text="30" ></asp:ListItem><asp:ListItem Text="31" ></asp:ListItem>
                <asp:ListItem Text="32" ></asp:ListItem><asp:ListItem Text="33" ></asp:ListItem>
                <asp:ListItem Text="34" ></asp:ListItem><asp:ListItem Text="35" ></asp:ListItem>
                <asp:ListItem Text="36" ></asp:ListItem><asp:ListItem Text="37" ></asp:ListItem>
                <asp:ListItem Text="38" ></asp:ListItem><asp:ListItem Text="39" ></asp:ListItem>
                <asp:ListItem Text="40" ></asp:ListItem><asp:ListItem Text="41" ></asp:ListItem>
                <asp:ListItem Text="42" ></asp:ListItem><asp:ListItem Text="43" ></asp:ListItem>
                <asp:ListItem Text="44" ></asp:ListItem><asp:ListItem Text="45" ></asp:ListItem>
                <asp:ListItem Text="46" ></asp:ListItem><asp:ListItem Text="47" ></asp:ListItem>
                <asp:ListItem Text="48" ></asp:ListItem><asp:ListItem Text="49" ></asp:ListItem>
                <asp:ListItem Text="50" ></asp:ListItem><asp:ListItem Text="51" ></asp:ListItem>
                <asp:ListItem Text="52" ></asp:ListItem><asp:ListItem Text="53" ></asp:ListItem>
                <asp:ListItem Text="54" ></asp:ListItem><asp:ListItem Text="55" ></asp:ListItem>
                <asp:ListItem Text="56" ></asp:ListItem><asp:ListItem Text="57" ></asp:ListItem>
                <asp:ListItem Text="58" ></asp:ListItem><asp:ListItem Text="59" ></asp:ListItem>
                
            </asp:DropDownList>
            &nbsp; &nbsp;
            <asp:Label ID="Label6" runat="server" Height="26px" Width="20px" 
                 Font-Bold="True"> :</asp:Label>
             <asp:Label ID="lblMinError" runat="server" Height="26px">الدقيقة </asp:Label>
              &nbsp; 
             <asp:DropDownList ID="ddlMin" runat="server" Height="26px" >
                <asp:ListItem Text="00" ></asp:ListItem><asp:ListItem Text="01" ></asp:ListItem>
                <asp:ListItem Text="02" ></asp:ListItem><asp:ListItem Text="03" ></asp:ListItem>
                <asp:ListItem Text="04" ></asp:ListItem><asp:ListItem Text="05" ></asp:ListItem>
                <asp:ListItem Text="06" ></asp:ListItem><asp:ListItem Text="07" ></asp:ListItem>
                <asp:ListItem Text="08" ></asp:ListItem><asp:ListItem Text="09" ></asp:ListItem>
                <asp:ListItem Text="10" ></asp:ListItem><asp:ListItem Text="11" ></asp:ListItem>
                <asp:ListItem Text="12" ></asp:ListItem><asp:ListItem Text="13" ></asp:ListItem>
                <asp:ListItem Text="14" ></asp:ListItem><asp:ListItem Text="15" ></asp:ListItem>
                <asp:ListItem Text="16" ></asp:ListItem><asp:ListItem Text="17" ></asp:ListItem>
                <asp:ListItem Text="18" ></asp:ListItem><asp:ListItem Text="19" ></asp:ListItem>
                <asp:ListItem Text="20" ></asp:ListItem><asp:ListItem Text="21" ></asp:ListItem>
                <asp:ListItem Text="22" ></asp:ListItem><asp:ListItem Text="23" ></asp:ListItem>
                <asp:ListItem Text="24" ></asp:ListItem><asp:ListItem Text="25" ></asp:ListItem>
                <asp:ListItem Text="26" ></asp:ListItem><asp:ListItem Text="27" ></asp:ListItem>
                <asp:ListItem Text="28" ></asp:ListItem><asp:ListItem Text="29" ></asp:ListItem>
                <asp:ListItem Text="30" ></asp:ListItem><asp:ListItem Text="31" ></asp:ListItem>
                <asp:ListItem Text="32" ></asp:ListItem><asp:ListItem Text="33" ></asp:ListItem>
                <asp:ListItem Text="34" ></asp:ListItem><asp:ListItem Text="35" ></asp:ListItem>
                <asp:ListItem Text="36" ></asp:ListItem><asp:ListItem Text="37" ></asp:ListItem>
                <asp:ListItem Text="38" ></asp:ListItem><asp:ListItem Text="39" ></asp:ListItem>
                <asp:ListItem Text="40" ></asp:ListItem><asp:ListItem Text="41" ></asp:ListItem>
                <asp:ListItem Text="42" ></asp:ListItem><asp:ListItem Text="43" ></asp:ListItem>
                <asp:ListItem Text="44" ></asp:ListItem><asp:ListItem Text="45" ></asp:ListItem>
                <asp:ListItem Text="46" ></asp:ListItem><asp:ListItem Text="47" ></asp:ListItem>
                <asp:ListItem Text="48" ></asp:ListItem><asp:ListItem Text="49" ></asp:ListItem>
                <asp:ListItem Text="50" ></asp:ListItem><asp:ListItem Text="51" ></asp:ListItem>
                <asp:ListItem Text="52" ></asp:ListItem><asp:ListItem Text="53" ></asp:ListItem>
                <asp:ListItem Text="54" ></asp:ListItem><asp:ListItem Text="55" ></asp:ListItem>
                <asp:ListItem Text="56" ></asp:ListItem><asp:ListItem Text="57" ></asp:ListItem>
                <asp:ListItem Text="58" ></asp:ListItem><asp:ListItem Text="59" ></asp:ListItem>
                
            </asp:DropDownList>
            
              &nbsp;&nbsp;
            <asp:Label ID="Label7" runat="server" Height="26px" Width="20px" 
                 Font-Bold="True"> :</asp:Label>
             <asp:Label ID="lblHourError" runat="server" Height="26px" >الساعة </asp:Label>
              &nbsp; 
             <asp:TextBox ID="txtHours" runat="server" Width="35px" ></asp:TextBox>
              <cc1:FilteredTextBoxExtender ID="FilteredtxtHours" runat="server" FilterType="Numbers"
                    TargetControlID="txtHours"></cc1:FilteredTextBoxExtender>
             <br />
            
        </td>
    </tr>
     <tr id="trDocErrors" runat="server" visible="false" align="right">
       <td>
       <asp:Label ID="label9" runat="server" Text="مكان الخطأ : " Height="26px" 
                 Width="100px"></asp:Label>
        <asp:Label ID="label8" runat="server" Text="رقم الصفحة : " Height="26px" 
                 Width="70px"></asp:Label>
                 &nbsp;<asp:TextBox ID="txterrorPage" runat="server" Width="75px"></asp:TextBox>
       </td>
       
     </tr>
        <tr align="center">
        <td height="60px">
            <asp:Button ID="btnsave" runat="server" Text="حـــفظ خطأ" ValidationGroup="file" 
               onclick="btnsave_Click" Visible="false" />
             
        </td>
    </tr>
       <tr>
        <td colspan="3">
            <asp:GridView ID="gvErrors" runat="server" AutoGenerateColumns="false"
             EmptyDataText=".. عفوا لاتوجد أخطاء .." Width="100%" BorderColor="Black" 
                BorderStyle="Solid" BorderWidth="1px"  OnRowDataBound="gvErrors_RowDataBound" >
                <HeaderStyle BackColor="#D9C69E" Font-Bold="True" ForeColor="White" />
                <Columns>
                    <asp:TemplateField HeaderStyle-HorizontalAlign="Center" HeaderStyle-Width="3px" HeaderText="م"
                        ItemStyle-HorizontalAlign="Center" ItemStyle-Width="3px" >
                        <ItemTemplate>
                            <%#Container.DataItemIndex + 1%>
                            <asp:TextBox ID="txtfileStatus" runat="server" Visible="false" Text='<%# Eval("error_status") %>'></asp:TextBox>
                        </ItemTemplate>


<HeaderStyle HorizontalAlign="Center" Width="3px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"></HeaderStyle>

<ItemStyle HorizontalAlign="Center" Width="3px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"></ItemStyle>
                    </asp:TemplateField>
                    
                   <%--  <asp:BoundField HeaderText="اسم الملف" DataField="title" ItemStyle-HorizontalAlign="Center" />--%>
                     
                      <asp:BoundField HeaderText="استخدام الملف" DataField="usage"  HeaderStyle-Width="85px" ItemStyle-HorizontalAlign="Center" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1px"
                     HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" HeaderStyle-HorizontalAlign="Center" />
                      <asp:BoundField HeaderText="نوع الخطأ" DataField="error_name"  HeaderStyle-Width="75px" ItemStyle-HorizontalAlign="Center" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1px"
                     HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" HeaderStyle-HorizontalAlign="Center" />
                       <asp:BoundField HeaderText=" ملاحظات" DataField="observer_note"   ItemStyle-HorizontalAlign="Center" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1px"
                     HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" HeaderStyle-HorizontalAlign="Center" />
                        <asp:BoundField HeaderText="مكان الخطأ" DataField="error_place"   ItemStyle-HorizontalAlign="Center" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1px"
                     HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" HeaderStyle-HorizontalAlign="Center" />
                       
                      <asp:TemplateField HeaderText="تعديل" HeaderStyle-Width="25px">
                                <ItemTemplate>
                                    <asp:ImageButton ID="ImgBtnEdit" runat="server" ImageUrl="~/images/Edit.jpg" CommandArgument='<%# Eval("id") %>' CommandName= '<%#Container.DataItemIndex+1%>'
                                        Style="height: 22px" OnClick="ImgBtnEdit_Click"  />
                                </ItemTemplate>

<HeaderStyle Width="25px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"></HeaderStyle>
<ItemStyle HorizontalAlign="Center" Width="25px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"></ItemStyle>
                            </asp:TemplateField>
                             <asp:TemplateField HeaderText="حذف" HeaderStyle-Width="25px">
                                <ItemTemplate>
                                    <asp:ImageButton ID="ImgBtnDelete" runat="server" ImageUrl="../Images/delete.gif" CommandArgument='<%# Eval("id") %>' CommandName= '<%#Container.DataItemIndex+1%>'
                                        Style="height: 22px" OnClick="ImgBtnDelete_Click" OnClientClick="if (confirm('هل تود الحذف نهائياً') == false) return false;" />
                                </ItemTemplate>

<HeaderStyle Width="25px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"></HeaderStyle>
<ItemStyle HorizontalAlign="Center" Width="25px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"></ItemStyle>
                            </asp:TemplateField>
                     
                           
                          
                </Columns>
             </asp:GridView>
        </td>
    </tr> 
    <tr>
        <td height="60px" align="right" dir="rtl">
            <asp:CheckBox ID="chkDone" runat="server" 
                Text="تم الإنتهاء من مراجعة الملفات" Visible="false" 
                />
        </td>
    </tr>
     
    <tr align="center">
        <td height="60px">
            <asp:Button ID="btnSavePage" runat="server" Text="حـــفظ" Visible="false" 
                onclick="btnsavePage_Click" />
        </td>
    </tr>
        </table>
</asp:Content>

