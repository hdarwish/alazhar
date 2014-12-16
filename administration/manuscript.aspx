<%@ Page Language="C#" MasterPageFile="~/masterpage/AdminMasterPage.master" AutoEventWireup="true" CodeFile="manuscript.aspx.cs" Inherits="administration_manuscript" Title="Untitled Page" %>

<%@ Register src="../user_controls/manuscripts_form.ascx" tagname="manuscripts_form" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<uc1:manuscripts_form ID="manuscripts_form1" runat="server" />
&nbsp;
</asp:Content>

