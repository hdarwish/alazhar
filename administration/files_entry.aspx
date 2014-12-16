<%@ Page Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true" CodeFile="files_entry.aspx.cs" Inherits="administration_files_entry" Title="إدخال الملفات" MaintainScrollPositionOnPostback="true"%>
<%@ Register Src="../user_controls/Smart_Search.ascx" TagName="Smart_Search" TagPrefix="uc7" %>
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
 <table align="right" dir="rtl" width="750px">
 <tr>
    <td align="center" dir="rtl" height="60px" colspan="2">
        <asp:Label ID="lblpage" runat="server" Font-Names="Arial" Font-Size="15px"
                             Text="إدخال الملفات" Font-Bold="true"></asp:Label>
    </td>
 </tr>
  <tr>
    <td align="center" dir="rtl" height="60px" colspan="2">
        <asp:Label ID="lblpageMsg" runat="server" Font-Names="Arial" Font-Size="15px" ForeColor="Red"
                             Text="" Font-Bold="true" Visible="false"></asp:Label>
    </td>
 </tr>
 <tr>
        <td height="60px" width="600px" valign="middle" align="right" dir="rtl" colspan="2">
             <asp:Label ID="label2" runat="server" Text="نوع الملف : " Height="26px" 
                 Width="65px"></asp:Label>
               
             <asp:DropDownList ID="ddlElementType" runat="server" Height="25px" 
                 Width="200px"  AutoPostBack="true" DataTextField="title" DataValueField="id"
                 onselectedindexchanged="ddlElementType_SelectedIndexChanged" >
                
             </asp:DropDownList>
             <%--<uc7:Smart_Search ID="Smart_Search_type" runat="server" />--%>
             
             <br />
         <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ErrorMessage="* عفوا يجب إختيار عنصر" ControlToValidate="ddlElementType" 
                Font-Size="14px" InitialValue=".. اختر عنصر .." ValidationGroup="file" ></asp:RequiredFieldValidator>
        </td>
        </tr>
        <tr>
       
            <td align="right" dir="rtl" valign="middle" class="style1" colspan="2">
             <asp:Label ID="label4" runat="server" Text="استخدام الملف : " Height="26px" 
                 Width="85px"></asp:Label>
              
                <asp:DropDownList ID="ddlFileUsage" runat="server" Height="26px" 
                 Width="150px" AutoPostBack="True" 
                    onselectedindexchanged="ddlFileUsage_SelectedIndexChanged"  >
               
             </asp:DropDownList>
            
             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ErrorMessage="* عفوا يجب إختيار إستخدام" ControlToValidate="ddlFileUsage" 
                Font-Size="14px" InitialValue=".. اختر إستخدام .." ValidationGroup="file"></asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
        <td width="600px" valign="middle" align="right" dir="rtl" class="style1" colspan="2">
             <asp:Label ID="label3" runat="server" Text="الإسم : " Height="26px" 
                 Width="40px"></asp:Label>
                &nbsp;&nbsp; &nbsp; &nbsp;<asp:Label ID="Label23" runat="server" ForeColor="Black"></asp:Label>
             <%--<asp:DropDownList ID="ddlElementName" runat="server" Height="26px" 
                 Width="500px"  AutoPostBack="true" 
                 onselectedindexchanged="ddlElementName_SelectedIndexChanged" >
               
             </asp:DropDownList>--%>
             <uc7:Smart_Search ID="Smrt_Srch_object"  runat="server"  />
                
              <br />
            <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
            ErrorMessage="* عفوا يجب إختيار اسم" ControlToValidate="Smrt_Srch_object" 
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
        
        <tr id="trUpload" runat="server" visible="false">
       
            <td align="right" dir="rtl" height="60px" valign="middle">
             <asp:Label ID="label1" runat="server" Text="تحميل الملف : " Height="26px" Visible="false"
                 Width="75px"></asp:Label>
                 </td>
                 <td align="right" dir="ltr" >
                   &nbsp;&nbsp;&nbsp;&nbsp;
               <asp:Label ID="Label5" runat="server" ForeColor="red"  Visible="false"></asp:Label>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ErrorMessage="* عفوا يجب إضافة ملف" ControlToValidate="fucontentFile" 
                Font-Size="14px"  ValidationGroup="file"> </asp:RequiredFieldValidator>
                <asp:FileUpload ID="fucontentFile" runat="server" Width="350px" />
             
            </td>
                 </tr>
                
        <tr align="center">
        <td height="60px" colspan="2">
            <asp:Button ID="btnsave" runat="server" Text="حـــفظ" ValidationGroup="file" 
                onclick="btnsave_Click" Visible="false" />
        </td>
    </tr>
        <tr>
        <td colspan="3" dir="rtl">
            <asp:GridView ID="gvContentFiles" runat="server" AutoGenerateColumns="false"
             EmptyDataText=".. عفوا لاتوجد بيانات .." Width="100%"  BorderColor="Black" 
                BorderStyle="Solid" BorderWidth="1px"  OnRowDataBound="gvContentFiles_RowDataBound" Visible="false" >
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
                              <asp:linkbutton id="title" runat="server" Text='<%# Eval("title").ToString() %>' 
                            
                                 
                                    CommandName= '<%#Container.DataItemIndex %>'  CausesValidation="false" CssClass="linkdir">
                                    </asp:linkbutton>
                                  <%-- <a href="#" runat="server" onclick="title_Click" target="_blank" ><%# Eval("title") %></a>--%>
                               <%-- <asp:ImageButton ID="ImgBtnEdit" runat="server" ImageUrl="../Images/Edit.jpg" 
                                CommandArgument='<%# Eval("id") %>'
                                    CommandName= '<%#Container.DataItemIndex %>' OnClick="ImgBtnEdit_Click" CausesValidation="false" />--%>
                              </ItemTemplate>
<HeaderStyle HorizontalAlign="Center"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"></HeaderStyle>

<ItemStyle HorizontalAlign="Center" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"></ItemStyle>

                        </asp:TemplateField>
                      <asp:BoundField HeaderText="استخدام الملف" DataField="usage"  HeaderStyle-Width="100px" 
                      ItemStyle-HorizontalAlign="Center" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" 
                      ItemStyle-BorderWidth="1px" HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid"
                       HeaderStyle-BorderWidth="1px" HeaderStyle-HorizontalAlign="Center" />
                     
                       
                     
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
    
    <tr id="trErrors" runat="server" visible="false">
        <td colspan="3">
            <asp:GridView ID="gvErrors" runat="server" AutoGenerateColumns="false"
             EmptyDataText=".. عفوا لاتوجد بيانات .." Width="100%"   BorderColor="Black" 
                BorderStyle="Solid" BorderWidth="1px"  >
                <HeaderStyle BackColor="#D9C69E" Font-Bold="True" ForeColor="White" />
                <Columns>
                    <asp:TemplateField HeaderStyle-HorizontalAlign="Center" HeaderStyle-Width="3px" HeaderText="م"
                        ItemStyle-HorizontalAlign="Center" ItemStyle-Width="3px" >
                        <ItemTemplate>
                            <%#Container.DataItemIndex + 1%>
                        </ItemTemplate>

<HeaderStyle HorizontalAlign="Center" Width="3px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"></HeaderStyle>

<ItemStyle HorizontalAlign="Center" Width="3px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"></ItemStyle>
                    </asp:TemplateField>
                    
                    <%-- <asp:BoundField HeaderText="اسم الملف" DataField="title" ItemStyle-HorizontalAlign="Center" />--%>
                     
                      <asp:BoundField HeaderText="استخدام الملف" DataField="usage"  HeaderStyle-Width="85px" ItemStyle-HorizontalAlign="Center" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1px"
                     HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" HeaderStyle-HorizontalAlign="Center" />
                      <asp:BoundField HeaderText="نوع الخطأ" DataField="error_name"  HeaderStyle-Width="75px" ItemStyle-HorizontalAlign="Center" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1px"
                     HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" HeaderStyle-HorizontalAlign="Center" />
                       <asp:BoundField HeaderText=" ملاحظات" DataField="observer_note"  ItemStyle-HorizontalAlign="Center" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1px"
                     HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" HeaderStyle-HorizontalAlign="Center" />
                        <asp:BoundField HeaderText="مكان الخطأ" DataField="error_place"   ItemStyle-HorizontalAlign="Center" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1px"
                     HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" HeaderStyle-HorizontalAlign="Center" />
                       
                    
                           
                     
                           
                          
                </Columns>
             </asp:GridView>
        </td>
    </tr>
    <tr>
        <td height="60px" align="right" dir="rtl" colspan="2">
            <asp:CheckBox ID="chkDone" runat="server" 
                Text="تم الإنتهاء من تحميل كل الملفات" 
                 Visible="false" AutoPostBack="True" 
                oncheckedchanged="chkDone_CheckedChanged" />
        </td>
    </tr>
    
     <tr align="center">
        <td height="60px" colspan="2">
            <asp:Button ID="btnSavePage" runat="server" Text="حـــفظ" 
                onclick="btnsavePage_Click" Visible="false" Enabled="False" />
        </td>
    </tr>
        </table>
</asp:Content>

