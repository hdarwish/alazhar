<%@ Page Language="C#" MasterPageFile="~/masterpage/InnerMaster.master" AutoEventWireup="true"
   CodeFile="theCo_org.aspx.cs" Inherits="general_theCo_org" Title="Untitled Page" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <input id="HiddenID" type="hidden" runat="server" />
    <table id="Table1" align="<%$Resources:Master, align%>" dir="<%$ Resources:Master, dir%>" style="padding-right:20px;padding-left:20px;height:500px" runat="server" width="900px" >
        <tr>
            <td id="Td1" align="<%$Resources:Master, align%>" dir="<%$ Resources:Master, dir%>" style="vertical-align:top" runat="server" colspan="2">
                <div id="accordion">
                    <div  id="tr6" runat="server">
                        <a href="#" class="text_Brown_10pt_bold">
                            <asp:Label ID="Label1" runat="server" Text="<%$ Resources:Master, co_org%>" ></asp:Label>
                        </a>
                    </div>
                    <div  runat="server" id="tr7">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="Labpubtitle" runat="server" Text="<%$ Resources:Master, co_org_details%>"></asp:Label>
                        </span>
                    </div>
                </div>
            </td>

         
        </tr>
    </table>
</asp:Content>

