<%@ Control Language="C#" AutoEventWireup="true" CodeFile="main_elements.ascx.cs" Inherits="user_controls_main_elements" %>
<%@ Register Src="Smart_Search.ascx" TagName="Smart_Search" TagPrefix="uc7" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<style type="text/css">
    .style1
    {
        width: 252px;
    }
</style>
<input id="control_relation_id" runat="server" type="hidden" />

<input id="myRowIndex1" runat="server" type="hidden" />


<table style="width:700px" border="0" cellspacing="5" dir="rtl"> 
<asp:HiddenField  runat="server" ID="content_id" value="" />
    <asp:HiddenField runat="server" ID="content_type" value=""/>
      <asp:HiddenField runat="server" ID="HiddenField1" value=""/>
   
    <tr>
        <td align="right" dir="rtl">
        <table runat="server" id="tbl_all" style="width:700px" border="0" cellspacing="5" dir="rtl">
        <%--<tr><td>
        <asp:Label ID="Label1" runat="server" Text=" العناصر الأساسية المرتبطة " 
             ForeColor="Black" Font-Bold="True" Font-Size="16px"></asp:Label>
        </td>
    </tr>--%>
     <tr>
    <td colspan="3" align="center" height="40px" dir="rtl">
         <asp:Label ID="lblpage" runat="server" Text="تم الحفظ" 
             ForeColor="Green" Visible="False" Font-Size="16px"></asp:Label>
    </td>
   </tr>
    <tr>
        <td height="60px" width="600px" valign="top">
             <asp:Label ID="label2" runat="server" Text="نوع العنصر : " Height="26px" 
                 Width="75px"></asp:Label>
             <asp:DropDownList ID="ddlMainElementType" runat="server" Height="25px" 
                 Width="250px"  AutoPostBack="true" 
                 onselectedindexchanged="ddlMainElementType_SelectedIndexChanged" >
                
             </asp:DropDownList>
             <br />
             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ErrorMessage="* عفوا يجب إختيار عنصر" ControlToValidate="ddlMainElementType" 
                Font-Size="14px" InitialValue=".. اختر عنصر .." ValidationGroup="main"></asp:RequiredFieldValidator>
        </td>
        </tr>
        <tr>
        <td width="600px" valign="top" height="60px">
             <asp:Label ID="label3" runat="server" Text="الإسم : " Height="26px" 
                 Width="40px"></asp:Label>
             <%--<asp:DropDownList ID="ddlMainElementName" runat="server" Height="25px" 
                 Width="500px" AutoPostBack="true" 
                 onselectedindexchanged="ddlMainElementName_SelectedIndexChanged">
                
             </asp:DropDownList>--%>
            
              <uc7:Smart_Search ID="Smrt_Srch_MainElementName" runat="server" Visible="true" />
              
             <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ErrorMessage="* عفوا يجب إختيار اسم" ControlToValidate="ddlMainElementName" 
                Font-Size="14px" InitialValue=".. اختر اسم .." ValidationGroup="main"></asp:RequiredFieldValidator>--%>
        </td>
        </tr>
        <tr>
         <td width="600px" valign="top" height="60px">
             <asp:Label ID="label4" runat="server" Text="نوع العلاقة : " Height="26px" 
                 Width="70px"></asp:Label>
             <asp:DropDownList ID="ddlMainElementRelationName" runat="server" Height="26px" 
                 Width="470px" AutoPostBack="True" onselectedindexchanged="ddlMainElementRelationName_SelectedIndexChanged">
                
             </asp:DropDownList>
        </td>
    </tr>
    <tr>
         <td width="600px" valign="top" height="60px">
             <asp:Label ID="label5" runat="server" Text="الرابط: " Height="26px" 
                 Width="70px"></asp:Label>
            <asp:TextBox ID="txtlink" runat="server" ReadOnly="true" Text="" Height="26px" 
                 Width="470px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="center" colspan="3" height="60px" valign="middle">
            <asp:Button ID="btnsave" runat="server" Text="إضافة" 
              onclick="btnsave_Click"   ValidationGroup="main"/>
        </td>
   
    </tr>
    </table>
   </td> 
   </tr> 
    <tr>
        <td>
        <table id="tbl_view" runat="server" style="width:700px" border="0" cellspacing="5" dir="rtl">
        <tr><td>
            <asp:GridView ID="gvMainElements" runat="server" AutoGenerateColumns="false"
             EmptyDataText=".. عفوا لاتوجد بيانات .." Width="100%" BorderColor="Black" 
                BorderStyle="Solid" BorderWidth="1px" OnRowDataBound="gvMainElements_RowDataBound">
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
                    <asp:BoundField HeaderText="نوع العنصر" DataField="element_type" HeaderStyle-Width="120px" 
                    ItemStyle-HorizontalAlign="Center" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1px"
                     HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" HeaderStyle-HorizontalAlign="Center" />
                     <asp:BoundField HeaderText="الإسم" DataField="element_type_name" ItemStyle-HorizontalAlign="Center" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1px"
                     HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" HeaderStyle-HorizontalAlign="Center"/>
                      <asp:BoundField HeaderText="نوع العلاقة" DataField="title_ar"  HeaderStyle-Width="100px" ItemStyle-HorizontalAlign="Center" ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1px"
                     HeaderStyle-BorderColor="Black" HeaderStyle-BorderStyle="Solid" HeaderStyle-BorderWidth="1px" HeaderStyle-HorizontalAlign="Center"/>
              
              <asp:TemplateField HeaderStyle-HorizontalAlign="Center"  HeaderText="الرابط"
                        ItemStyle-HorizontalAlign="Center" ItemStyle-Width="3px">
                        <ItemTemplate>
                         <asp:TextBox ID="txtTypeName" runat="server" text='<%# Eval("content_type2")%>' visible="false"></asp:TextBox>
                          <asp:TextBox ID="txtNameId" runat="server" text='<%# Eval("content_id2")%>' visible="false"></asp:TextBox>
                            <asp:TextBox ID="txtlinkgrd" runat="server" ReadOnly="true" Width="200px"></asp:TextBox>
                        </ItemTemplate>

<HeaderStyle HorizontalAlign="Center" Width="200px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"></HeaderStyle>

<ItemStyle HorizontalAlign="Center" Width="200px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"></ItemStyle>
                    </asp:TemplateField>
              
                       <asp:TemplateField HeaderText="تعديل" HeaderStyle-Width="25px" >
                            <ItemTemplate>
                            <asp:TextBox ID="contentId2" runat="server" Visible="false" Text='<%# Eval("content_id2") %>'></asp:TextBox>
                            <asp:TextBox ID="contentType2" runat="server" Visible="false" Text='<%# Eval("content_type2") %>'></asp:TextBox>
                            <asp:TextBox ID="Relation_id" runat="server" Visible="false" Text='<%# Eval("relation_id") %>'></asp:TextBox>
                            
                                <asp:ImageButton ID="ImgBtnEdit" runat="server" ImageUrl="../Images/Edit.jpg" 
                                CommandArgument='<%# Eval("edit_delete_id") %>'
                                    CommandName= '<%#Container.DataItemIndex %>' OnClick="ImgBtnEdit_Click" CausesValidation="false" />
                              </ItemTemplate>

<HeaderStyle Width="25px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"></HeaderStyle>
<ItemStyle HorizontalAlign="Center" Width="25px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"></ItemStyle>
                        </asp:TemplateField>
                     
                           <asp:TemplateField HeaderText="حذف" HeaderStyle-Width="25px">
                                <ItemTemplate>
                                    <asp:ImageButton ID="ImgBtnDelete" runat="server" ImageUrl="../Images/delete.gif" CommandArgument='<%# Eval("edit_delete_id") %>'
                                        Style="height: 22px" OnClick="ImgBtnDelete_Click" OnClientClick="if (confirm('هل تود الحذف نهائياً') == false) return false;" />
                                </ItemTemplate>

<HeaderStyle Width="25px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"></HeaderStyle>
<ItemStyle HorizontalAlign="Center" Width="25px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"></ItemStyle>
                            </asp:TemplateField>
                          
                </Columns>
             </asp:GridView>
             
             </td></tr>
             </table> 
        </td>
    </tr>

</table>