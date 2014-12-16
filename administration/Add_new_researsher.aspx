<%@ Page Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true"
    CodeFile="Add_new_researsher.aspx.cs" Inherits="Add_new_researsher" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <script type="text/javascript">
        function check_uncheck(cbControl,state)
        {
            var chkBoxList = document.getElementById(cbControl);
            var chkBoxCount= chkBoxList.getElementsByTagName("input");
            for(var i=0;i<chkBoxCount.length;i++)
            {
                chkBoxCount[i].checked = state;
            }
            return false; 
        }
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table align="right" width="99%" cellpadding="4" cellspacing="4" border="0" id="add_new_researcher"
        runat="server" dir="rtl">
        <tr>
            <td align="center" colspan="3">
                <asp:Label ID="Label4" runat="server" Text="إضافة / تعديل مستخدم" Font-Bold="True"
                    ForeColor="#996633"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="right" class="style18">
                &nbsp;
            </td>
            <td align="right" class="style17" colspan="2">
                <input id="txtid" type="hidden" runat="server" />
                <input id="input_password" type="hidden" runat="server" />
            </td>
        </tr>
        <tr>
            <td align="right" class="style18">
                <asp:Label Font-Bold="true" ID="lblresearsh" runat="server" Text="اسم المستخدم"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtresearsh_name"
                    ErrorMessage="*" SetFocusOnError="True"></asp:RequiredFieldValidator>
            </td>
            <td align="right" class="style17" colspan="2">
                <asp:TextBox ID="txtresearsh_name" runat="server" ValidationGroup="newusergrp" Width="194px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style19">
                <asp:Label Font-Bold="true" ID="lblusername" runat="server" Text="اسم الدخول"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtuser_name"
                    ErrorMessage="*" SetFocusOnError="True"></asp:RequiredFieldValidator>
            </td>
            <td align="right" class="style16" colspan="2">
                <asp:TextBox ID="txtuser_name" runat="server" ValidationGroup="newusergrp" Width="194px"></asp:TextBox>
            </td>
        </tr>
        <tr align="right">
            <td class="style20">
                <asp:Label Font-Bold="true" ID="lblpassword" runat="server" Text="كلمة السر"></asp:Label>
                <asp:RequiredFieldValidator ID="RFV_password" runat="server" ControlToValidate="txtuser_password"
                    ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
            <td class="style21" align="right" colspan="2">
                <asp:TextBox ID="txtuser_password" runat="server" Width="194px" TextMode="Password"
                    Style="margin-left: 1px" ValidationGroup="newusergrp"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style20" align="right">
                <asp:Label Font-Bold="true" ID="lblemail" runat="server" Text="الايميل"></asp:Label>
                <br />
            </td>
            <td align="right" class="style21" colspan="2">
                <asp:TextBox ID="txtuser_email" runat="server" Width="194px" ValidationGroup="newusergrp"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    ErrorMessage="Not a Valid Email Address" ControlToValidate="txtuser_email" SetFocusOnError="True"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style20" align="right">
                <asp:Label Font-Bold="true" ID="Label1" runat="server" Text="الموبايل"></asp:Label>
            </td>
            <td align="right" class="style21" colspan="2">
                <asp:TextBox ID="txtuser_mobile" MaxLength="11" runat="server" Width="194px" ValidationGroup="newusergrp"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtuser_mobile"
                    ErrorMessage="Enter only Numbers" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style25" align="right">
                <asp:Label Font-Bold="true" ID="Label2" runat="server" Text="نوع المستخدم"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ddlusertype"
                    ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
            <td align="right" class="style26" colspan="2">
                <asp:DropDownList ID="ddlusertype" runat="server" Height="22px" Width="144px" DataSourceID="SqlDataSource1"
                    DataTextField="title" DataValueField="id" ValidationGroup="newusergrp">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                    SelectCommand="SELECT [id], [title] FROM [users_types]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr align="right" dir="rtl">
            <td class="style27" align="right">
                <asp:Label Font-Bold="true" ID="Label3" runat="server" Text="التخصص"></asp:Label>
            </td>
            <td class="style24">
                <br />
                &nbsp;
                <input id="Checkbox1"  type="checkbox" onclick="check_uncheck('<%= ChB_item.ClientID %>',this.checked);" title="الكل" />الكل
                <br />
            </td>
            <td class="style23">
                <asp:CheckBoxList ID="ChB_item" runat="server" Height="52px" DataTextField="title"
                    DataValueField="id" RepeatDirection="Horizontal" RepeatLayout="Flow" ValidationGroup="chicklistvalidation"
                    RepeatColumns="4" Style="margin-left: 0px">
                </asp:CheckBoxList>
            </td>
        </tr>
        <tr>
            <td class="style20">
            </td>
            <td align="justify" class="style21" colspan="2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="حفظ" Width="69px"
                    Height="26px" ValidationGroup="newusergrp" />
                <asp:Button ID="Button2" runat="server" ValidationGroup="newusergrp3" OnClick="Button2_Click"
                    Text="مسح" />
                <asp:Button ID="Button3" runat="server" ValidationGroup="newusergrp2" Text="الغاء"
                    OnClick="Button3_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
