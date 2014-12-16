<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/InnerMaster.master" AutoEventWireup="true" CodeFile="Terms_of_use.aspx.cs" Inherits="general_Terms_of_use" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
<table style="width: 900px;padding-right:20px;padding-left:20px;height:500px" id="tableList" runat="server"  align="<%$Resources:Master, align%>" dir="<%$ Resources:Master, dir%>" >
            <tr>           
            <td style="vertical-align:top">
           <table id="Table1" runat="server" width="100%">
                    <tr id="Tr1" runat="server"  dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>" valign="top">
            <td>
             <div id="Div1" dir="<%$Resources:Master, dir%>" runat="server"> 
                <asp:Label ID="Label53" runat="server" Text="<%$Resources:Master, conditions%>" class="text_Brown_10pt_bold"></asp:Label>                        
               </div> 
             </td>
        </tr>
        <tr id="Tr2" runat="server"  dir="<%$Resources:Master, dir%>" align="<%$Resources:Master, align%>" valign="top">
            <td>
            <div id="Div2" dir="<%$Resources:Master, dir%>" runat="server">
                        <span class="text_Dark_Brown_10pt">
                        </span>                    
                <asp:Label ID="Label54" runat="server" Text="<%$Resources:Master,condition1%>"></asp:Label>
            </div>
            </td>
        </tr>
           </table>                 
            </td>           
           </tr>                                                                                 
    </table>
</asp:Content>

