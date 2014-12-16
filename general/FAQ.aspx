<%@ Page Language="C#" MasterPageFile="~/masterpage/InnerMaster.master" AutoEventWireup="true"
   CodeFile="FAQ.aspx.cs" Inherits="general_FAQ" Title="Untitled Page" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server" >
    <input id="HiddenID" type="hidden" runat="server" />

    <table id="Table1" align="<%$Resources:Master, align%>" dir="<%$ Resources:Master, dir%>" style="padding-right:20px;padding-left:20px;height:500px" runat="server" width="900px"  >
        <tr>
        <%--<td style="width:140px">
        &nbsp
        </td>--%>
            
              <td id="Td1" align="<%$Resources:Master, align%>" dir="<%$ Resources:Master, dir%>" style="vertical-align:top" runat="server" >
                <div >
                    <div  id="tr6" runat="server" align="<%$Resources:Master, align%>" dir="<%$ Resources:Master, dir%>">
                        
                        <span class="text_Brown_10pt_bold">
                            <asp:Label ID="Label2" runat="server" Text="<%$ Resources:Master, Q&A%>"></asp:Label>
                        </span>
                    </div>
                    <div  runat="server" id="tr7" align="<%$Resources:Master, align%>" dir="<%$ Resources:Master, dir%>">
                        <span class="text_Dark_Brown_10pt">
                            <asp:Label ID="Labpubtitle" runat="server" Text="<%$ Resources:Master, Q&A_details%>"></asp:Label>
                        </span>
                    </div>
                </div>
            </td>
            
        <%--<td style="width:140px">
        &nbsp
        </td>--%>
          
        </tr>
    </table>
</asp:Content>

