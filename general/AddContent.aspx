<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/InnerMaster.master" AutoEventWireup="true" CodeFile="AddContent.aspx.cs" Inherits="general_AddContent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table style="width: 900px;padding-right:20px;padding-left:20px;height:500px" id="tableList" runat="server"  align="<%$Resources:Master, align%>" dir="<%$ Resources:Master, dir%>" >
            <tr>
           
            <td style="vertical-align:top">
           <table runat="server" width="100%">
                    <tr id="Tr1" runat="server"  dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>" valign="top">
            <td>
             <div id="Div1"  > 
                <asp:Label ID="Label53" runat="server" Text="<%$Resources:Master, AddContent%>" class="text_Brown_10pt_bold"></asp:Label>
                        
               </div> 
             </td>
        </tr>
        <tr runat="server"  dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>" valign="top">
            <td>
            <div id="Div2">
                        <span class="text_Dark_Brown_10pt">
                        </span>                    
                <asp:Label ID="Label54" runat="server" Text="<%$Resources:Master,lblContent%>"></asp:Label>
            </div>
            </td>
        </tr>
           </table>
                 
            </td>
           
            </tr>
       
       
       
       
       
       
       
       
       
       
       
       

    </table>
</asp:Content>

