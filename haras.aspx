<%@ Page Language="C#" AutoEventWireup="true" CodeFile="haras.aspx.cs" Inherits="haras" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 105px;
        }
        .style2
        {
        }
        .style3
        {
            width: 136px;
        }
        .style4
        {
            width: 105px;
            height: 23px;
        }
        .style5
        {
            width: 247px;
            height: 23px;
        }
        .style6
        {
            width: 136px;
            height: 23px;
        }
        .style7
        {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 100%;" bgcolor="#EFEBDF">
            <tr>
                <td colspan="4">
                    <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="Large" 
                        ForeColor="Red" Text="Event details"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;
                    <asp:Label ID="Label1" runat="server" Text="Event type"></asp:Label>
                </td>
                <td class="style2">
                    &nbsp;
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="148px">
                        <asp:ListItem>مؤتمرات</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="style3">
                    &nbsp;
                    <asp:Label ID="Label2" runat="server" Text="Event name"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList10" runat="server" Height="16px" 
                        Width="148px">
                        <asp:ListItem>مؤتمر اعمار غزة</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;
                    <asp:Label ID="Label3" runat="server" Text="Language"></asp:Label>
                </td>
                <td class="style2">
                    &nbsp;
                    <asp:DropDownList ID="DropDownList2" runat="server" Height="16px" Width="148px">
                        <asp:ListItem>العربية</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="style3">
                    &nbsp;
                    <asp:Label ID="Label4" runat="server" Text="Conference type"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList3" runat="server" Height="16px" Width="148px">
                        <asp:ListItem>قمة عربية</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    <asp:Label ID="Label6" runat="server" Text="Nationality"></asp:Label>
                </td>
                <td class="style5">
                    <asp:DropDownList ID="DropDownList4" runat="server" Height="16px" Width="148px">
                        <asp:ListItem>جمهورية مصر العربية</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="style6">
                    <asp:Label ID="Label7" runat="server" Text="Position (From)"></asp:Label>
                </td>
                <td class="style7">
                    <asp:DropDownList ID="DropDownList5" runat="server" Height="16px" Width="148px">
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="Label8" runat="server" Text="Position (To)"></asp:Label>
                </td>
                <td class="style2">
                    <asp:DropDownList ID="DropDownList6" runat="server" Height="16px" Width="148px">
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="style3">
                    <asp:Label ID="Label10" runat="server" Text="Treely type"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList8" runat="server" Height="16px" Width="148px">
                        <asp:ListItem>Treely 1</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="Label9" runat="server" Text="Country (To)"></asp:Label>
                </td>
                <td class="style2">
                    <asp:DropDownList ID="DropDownList7" runat="server" Height="16px" Width="148px">
                        <asp:ListItem>جمهورية مصر العربية</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="style3">
                    <asp:Label ID="Label11" runat="server" Text="Period"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList9" runat="server" Height="16px" Width="148px">
                        <asp:ListItem>Period 1</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="Label12" runat="server" Text="Date (From)"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="TextBox2" runat="server" Height="23px" Width="210px">21/10/2014</asp:TextBox>
                </td>
                <td class="style3">
                    <asp:Label ID="Label13" runat="server" Text="Date (To)"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" Height="23px" Width="210px">21/10/2014</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="Label14" runat="server" Text="Place"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="TextBox4" runat="server" Height="23px" Width="210px">قصر القبة - مصر الجديدة</asp:TextBox>
                </td>
                <td class="style3">
                    <asp:Label ID="Label15" runat="server" Text="Occasion"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server" Height="23px" Width="209px">مؤتمر اعمار غزة</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="Label16" runat="server" Font-Bold="True" ForeColor="#33CC33" 
                        Text="Attendees"></asp:Label>
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td class="style2">
                    <asp:TextBox ID="TextBox6" runat="server" Height="23px" Width="210px">21/10/2014</asp:TextBox>
                </td>
                <td class="style3">
                    <asp:Button ID="Button1" runat="server" Text="Save" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td class="style2" colspan="3">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                        BackColor="#E5E5E5" Height="89px" Width="501px">
                        <Columns>
                            <asp:BoundField HeaderText="Attendee name" />
                            <asp:CommandField HeaderText="Edit" ShowEditButton="True" />
                            <asp:CommandField HeaderText="Delete" ShowDeleteButton="True" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    <asp:Label ID="Label17" runat="server" Text="Comments"></asp:Label>
                </td>
                <td class="style7" colspan="3">
                    <asp:TextBox ID="TextBox7" runat="server" Height="92px" Width="496px">Comments</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="Label18" runat="server" Text="Station"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="TextBox8" runat="server" Height="23px" Width="209px">Station</asp:TextBox>
                </td>
                <td class="style2">
                    <asp:Label ID="Label20" runat="server" Text="Corespondent name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox9" runat="server" Height="26px" Width="289px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="Label19" runat="server" Text="Decree number"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="TextBox10" runat="server" Height="23px" Width="209px"></asp:TextBox>
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
