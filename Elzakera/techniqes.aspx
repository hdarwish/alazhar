<%@ Page Language="C#" MasterPageFile="~/masterpage/MasterPage.master" AutoEventWireup="true" Title="ِِAdd - Update - Deleet techniqes" %>

<script runat="server">

      protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Add_new_technique.aspx");
    }
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 88%;
            height: 172px;
        }
        .style5
        {
            width: 381px;
        }
        .style15
        {
            width: 90%;
        }
        .style16
        {
            width: 920px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style15">
        <tr>
            <td class="style16">
                Tichniques
            </td>
        </tr>
        <tr>
            <td class="style16">
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                    
                    
                    SelectCommand="SELECT [id], [title_ar], [title_en], [title_fr] FROM [techniques] ORDER BY [id] DESC" DeleteCommand="tech_del" 
                    DeleteCommandType="StoredProcedure" UpdateCommand="tech_update" 
                    UpdateCommandType="StoredProcedure">
                    <DeleteParameters>
                        <asp:Parameter Name="id" Type="Int32" />
                    </DeleteParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="id" Type="Int32" />
                        <asp:Parameter Name="title_ar" Type="String" />
                        <asp:Parameter Name="title_en" Type="String" />
                        <asp:Parameter Name="title_fr" Type="String" />
                    </UpdateParameters>
                </asp:SqlDataSource>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    Height="124px" Width="716px" CellPadding="4" ForeColor="#333333" 
                    GridLines="None" AllowPaging="True" DataKeyNames="id" 
                    DataSourceID="SqlDataSource1" AllowSorting="True">
                    <RowStyle BackColor="#EFF3FB" />
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                            ReadOnly="True" SortExpression="id" />
                        <asp:BoundField DataField="title_ar" HeaderText="اسم التقنية باللغة العربية" 
                            SortExpression="title_ar" />
                        <asp:BoundField DataField="title_en" HeaderText="Techniques Name by English" 
                            SortExpression="title_en" />
                        <asp:BoundField DataField="title_fr" HeaderText="Nom Techniques par francia" 
                            SortExpression="title_fr" />
                        <asp:CommandField ShowDeleteButton="True" HeaderText="Delete" />
                       
                        <asp:HyperLinkField DataNavigateUrlFields="id,title_ar,title_en,title_fr" 
                            DataNavigateUrlFormatString="Add_new_technique.aspx?id={0}&title_ar={1}&title_en={2}&title_fr={3}" HeaderText="Update" 
                            NavigateUrl="Add_new_technique.aspx" Text="Update" />
                       
                    </Columns>
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#2461BF" />
                    <AlternatingRowStyle BackColor="White" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="style16" align="center">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Back" />
            </td>
        </tr>
    </table>
</asp:Content>

