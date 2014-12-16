<%@ Page Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true" CodeFile="researsher_view.aspx.cs" Inherits="administration_researsher_view" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style15
        {
            width: 90%;
        }
        .style16
        {
            width: 920px;
        }
        .style17
        {
            width: 920px;
            height: 30px;
        }
        .style18
        {
            width: 920px;
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style15">
        <tr>
            <td class="style16">
                &nbsp;<b><asp:Button ID="Button2" runat="server" onclick="Button1_Click" 
                    Text="إضافة مستخدم" />
                </b></td>
            <td class="style18">
                <b>المستخدمين</b></td>
        </tr>
        <tr>
            <td class="style16" align="right" dir="rtl" colspan="2">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    Height="124px" Width="716px" CellPadding="4" ForeColor="#333333" 
                    GridLines="None" AllowPaging="True" DataKeyNames="id"  
                    DataSourceID="SqlDataSource1" onrowcreated="GridView1_RowCreated">
                  <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <RowStyle BackColor="#F6F2E2" />
                    <Columns>
                        <asp:BoundField DataField="name" HeaderText="المستخدم" SortExpression="name" />
                        <asp:BoundField DataField="username" HeaderText="اسم المستخدم" 
                            SortExpression="username" />
                        <asp:BoundField DataField="user_type" HeaderText="نوع المستخدم" 
                            SortExpression="user_type" />
                        <asp:BoundField DataField="E_mail" HeaderText="الايميل" 
                            SortExpression="E_mail" />
                      
                       <asp:TemplateField HeaderText="حذف">
                            <ItemTemplate>
                                <asp:LinkButton ID="LBTDelet" CommandArgument='<%# Eval("ID") %>'  CommandName="Delete" runat="server" OnClientClick="return confirm('هل تريد حذف  بيانات هذا الباحث ؟');">
                             حذف</asp:LinkButton>
                                 </ItemTemplate>
                         </asp:TemplateField>
                        <asp:HyperLinkField DataNavigateUrlFields="id" 
                            
                            DataNavigateUrlFormatString="Add_new_researsher.aspx?id={0}" HeaderText="تعديل" 
                            NavigateUrl="Add_new_researsher.aspx" Text="تعديل" />
                    </Columns>
                       <PagerStyle BackColor="#D9C69E" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#D9C69E" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#2461BF" HorizontalAlign="Right" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                    SelectCommand="selct_users" DeleteCommand="dele_users" 
                    DeleteCommandType="StoredProcedure" SelectCommandType="StoredProcedure" 
                    UpdateCommand="update_resaershname" UpdateCommandType="StoredProcedure">
                    <DeleteParameters>
                        <asp:Parameter Name="id" Type="Int32" />
                    </DeleteParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="id" Type="Int32" />
                        <asp:Parameter Name="researshname" Type="String" />
                        <asp:Parameter Name="username" Type="String" />
                        <asp:Parameter Name="password" Type="String" />
                        <asp:Parameter Name="email" Type="String" />
                        <asp:Parameter Name="mobile" Type="String" />
                        <asp:Parameter Name="usertype" Type="Int32" />
                        
                        <asp:Parameter Name="research_assign_char" Type="Int32" />
                        <asp:Parameter Name="research_assign_event" Type="Int32" />
                        <asp:Parameter Name="research_topics" Type="Int32" />
                        <asp:Parameter Name="research_assign_video" Type="Int32" />
                        <asp:Parameter Name="research_assign_audio" Type="Int32" />
                        <asp:Parameter Name="research_assign_doc" Type="Int32" />
                        <asp:Parameter Name="research_assign_article" Type="Int32" />
                        <asp:Parameter Name="research_assign_book" Type="Int32" />
                        <asp:Parameter Name="research_assign_image" Type="Int32" />
                    </UpdateParameters>
                </asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td class="style17" align="center" colspan="2">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

