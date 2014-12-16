<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true" CodeFile="FeaturesHonor.aspx.cs" Inherits="Reports_FeaturesHonor" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<%@ Register Src="../user_controls/Smart_Search.ascx" TagName="Smart_Search" TagPrefix="uc7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .style1 {
            width: 100%;
        }

        .style3 {
            font-size: xx-large;
            height: 46px;
        }

        .style4 {
            font-size: xx-large;
            height: 37px;
            text-align: right;
            direction: rtl;
        }
    </style>
</asp:Content>
<asp:content id="Content2" contentplaceholderid="ContentPlaceHolder1" runat="Server">
    <center><br />
                 <asp:Label ID="Label5"  runat="server" Text="تقرير ملامح تكريم الشخصية" ForeColor="#996633" Font-Bold="True"></asp:Label>
                <br />
               
                 </center>
    <center>
     <table border="0" width ="100%">
    
    <tr>
        
     <td nowrap align="right" dir="rtl">
                <asp:Label ID="Label3" runat="server" Text="الإســـــم" ForeColor="#996633" Font-Bold="True"></asp:Label>
                &nbsp;&nbsp; &nbsp; &nbsp;<asp:Label ID="Label23" runat="server" ForeColor="Black"></asp:Label>
                <%-- <asp:DropDownList ID="Smrt_Srch_object" Width="400px" runat="server" DataTextField="newcode"
                    DataValueField="id" AutoPostBack="True" OnSelectedIndexChanged="Smrt_Srch_object_SelectedIndexChanged">
                    <asp:ListItem Text=" -- اختر العنصر -- " Value="0"></asp:ListItem>
                </asp:DropDownList>--%>
                <%--'<%=Div1.ClientID%>'--%>
                <uc7:Smart_Search ID="Smrt_Srch_object" runat="server" Visible="true" />
            </td>
      </tr>
<tr>
        <td align="center">
     <asp:Button ID="Button1" runat="server" Text="مشاهدة" OnClick="Button1_Click" />

</td>   
    <tr>
        <td colspan="2">
              


                <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%" 
                    ProcessingMode="Remote" style="margin-top: 55px" 
                    InternalBorderStyle="Double">
                   
                </rsweb:ReportViewer>
                
              
            </td>
    </tr>
           
</table>

    </center>

</asp:content>

