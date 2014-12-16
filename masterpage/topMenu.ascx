<%@ Control Language="C#" AutoEventWireup="true" CodeFile="topMenu.ascx.cs" Inherits="masterpage_topMenu" %>
<%--<script type="text/javascript">
    function main_click() {

        Session("menu_item") = "main"
    }
    function event_click() {

        Session("menu_item") = "event"
    }
    function topic_click() {

        Session("menu_item") = "topic"
    }
    function char_click() {

        Session("menu_item") = "char"

    }
    function place_click() {

        Session("menu_item") = "place"
    }
    function lib_click() {

        Session("menu_item") = "lib"
    }
    function timeline_click() {

        Session("menu_item") = "timeline"
    }
    function media_click() {

        Session("menu_item") = "media"
    }
</script>--%>
<link  runat="server" href="<%$Resources:Master, topmenucss%>" rel="stylesheet" type="text/css" />
<ul id="menutt" style="width: 970px;">
    <li id="lt1" runat="server" style="float:right;width:80px" >
        <asp:LinkButton ID="a_main" OnClick="main_click" class="isActive"  runat="server" >
            <asp:Label ID="Literal1" style="width:80px; height: 32px;vertical-align: middle;display: table-cell;" 
             runat="server" Text="<%$Resources:Master, title_main%>" />
        </asp:LinkButton></li>
    <li id="lt2" runat="server" style="float:right">
        <img id="img_main" runat="server" src="../images/menuImages/side-Op.gif" width="20"
            height="32" class="menuButL" alt="" /></li>
    <li id="lt3" runat="server" style="float:right;width:137px">
        <asp:LinkButton ID="a_event" OnClick="event_click"  runat="server">
            <asp:Label ID="Literal2" style="width:137px;height: 32px;vertical-align: middle;display: table-cell;"  runat="server" Text="<%$Resources:Master, title_event%>" /></asp:LinkButton>
    </li>
    <li id="lt4" runat="server" style="float:right">
        <img id="img_event" runat="server" src="../images/menuImages/side-Op.gif" width="20"
            height="32" class="menuButN" alt="" /></li>
    <li id="lt5" runat="server" style="float:right;">
        <asp:LinkButton ID="a_topic" OnClick="topic_click"  runat="server">
            <asp:Label ID="Literal3" style="width:94px;height: 32px;vertical-align: middle;display: table-cell;"  runat="server" Text="<%$Resources:Master, title_topic%>" /></asp:LinkButton></li>
    <li id="lt6" runat="server" style="float:right">
        <img id="img_topic" runat="server" src="../images/menuImages/side-Op.gif" width="20"
            height="32" class="menuButN" alt="" /></li>
    <li id="lt7" runat="server" style="float:right;width:95px">
        <asp:LinkButton ID="a_char" runat="server" OnClick="char_click" >
            <asp:Label ID="Literal4" style="width:95px;height: 32px;vertical-align: middle;display: table-cell;"  runat="server" Text="<%$Resources:Master, title_char%>" /></asp:LinkButton>
        <ul>
            <li id="lt7_1" runat="server" style="float:right">
                <asp:LinkButton ID="A5" OnClick="char_click" style="width:70px;"  href="../sheikhs/Default.aspx?type=1"
                    runat="server">
                    <asp:Label ID="Literal7" runat="server" style="width:70px;vertical-align: middle;display: table-cell;float:right;padding-right: 3px;" Text="<%$Resources:Master, title_alazhar%>" /></asp:LinkButton></li>
            <li id="lt7_2" runat="server" style="float:right">
                <asp:LinkButton ID="A4" OnClick="char_click" style="width:70px;" href="../sheikhs/Default.aspx?type=2"
                    runat="server">
                    <asp:Label ID="Literal6" runat="server" style="width:70px;vertical-align: middle;display: table-cell;float:right;padding-right: 3px;" Text="<%$Resources:Master, title_mufti%>" /></asp:LinkButton></li>
            <li id="lt7_3" runat="server" style="float:right">
                <asp:LinkButton ID="A3" OnClick="char_click" style="width:70px;" href="../sheikhs/Default.aspx?type=3"
                    runat="server">
                    <asp:Label ID="Literal5" runat="server" style="width:70px;vertical-align: middle;display: table-cell;float:right;padding-right: 3px;" Text="<%$Resources:Master, title_scholar%>" /></asp:LinkButton></li>
             <li id="lt7_4" runat="server" style="float:right">
                <asp:LinkButton ID="A6" OnClick="char_click" style="width:70px;" href="../sheikhs/Default.aspx?type=4"
                    runat="server">
                    <asp:Label ID="Literal9" runat="server" style="width:70px;vertical-align: middle;display: table-cell;float:right;padding-right: 3px;" Text="<%$Resources:Master, title_other%>" /></asp:LinkButton></li>
        </ul>
    </li>
    <li id="lt8" runat="server" style="float:right">
        <img id="img_char" runat="server" src="../images/menuImages/side-Op.gif" width="20"
            height="32" class="menuButN" alt="" /></li>
    <li id="lt9" runat="server" style="float:right;width:133px">
        <asp:LinkButton ID="a_place" runat="server" style="width:133px;height: 32px;vertical-align: middle;display: table-cell;" 
          OnClick="place_click" Text="<%$Resources:Master, title_place%>"></asp:LinkButton></li>
    <li id="lt10" runat="server" style="float:right">
        <img id="img_place" runat="server" src="../images/menuImages/side-Op.gif" width="20"
            height="32" class="menuButN" alt="" /></li>
    <li id="lt11" runat="server" style="float:right;width:71px">
        <asp:LinkButton ID="a_lib" runat="server" style="width:71px;height: 32px;vertical-align: middle;display: table-cell;" 
         OnClick="lib_click"  Text="<%$Resources:Master, title_library%>"></asp:LinkButton>
        <ul>
        <li id="lt11_1" runat="server" style="float:right">
                <asp:LinkButton ID="lnklbl5" runat="server" OnClick="lib_click5" Style="width: 110px">
                    <asp:Label ID="lbl5" runat="server" style="width:110px;vertical-align: middle;display: table-cell;float:right;padding-right: 3px;" 
                    Text="<%$Resources:Master, title_researches%>"></asp:Label>
                    </asp:LinkButton></li>
            <li id="lt11_2" runat="server" style="float:right">
                <asp:LinkButton ID="lbl1" runat="server" OnClick="lib_click3" Style="width: 110px;padding-right: 3px;"
                    Text="<%$Resources:Master, title_book%>">
                    </asp:LinkButton></li>
            <li id="lt11_3" runat="server" style="float:right">
                <asp:LinkButton ID="lbl2" runat="server" OnClick="lib_click2" Style="width: 110px;padding-right: 3px;"
                    Text="<%$Resources:Master, title_articles%>"></asp:LinkButton></li>
            <li id="lt11_4" runat="server" style="float:right">
                <asp:LinkButton ID="lbl3" runat="server" OnClick="lib_click" Style="width: 110px;padding-right: 3px;" 
                Text="<%$Resources:Master, title_docs%>"></asp:LinkButton></li>
            <li id="lt11_5" runat="server" style="float:right">
                <asp:LinkButton ID="lbl4" runat="server" OnClick="lib_click4" Style="width: 110px;padding-right: 3px;"
                    Text="<%$Resources:Master, title_manuscript%>"></asp:LinkButton></li>
            
            <li id="lt11_6" runat="server" style="float:right">
                <asp:LinkButton ID="lbl66" runat="server" OnClick="lib_click6" Style="width: 110px;padding-right: 3px;"
                    Text="<%$Resources:Master, title_theses%>"></asp:LinkButton></li>
            <li id="lt11_7" runat="server" style="float:right">
                <asp:LinkButton ID="lbl77" runat="server" OnClick="lib_click7" Style="width: 110px;padding-right: 3px;"
                    Text="<%$Resources:Master, title_artifacts%>"></asp:LinkButton></li>
                    
                 <li id="lt11_8" runat="server" style="float:right">
            <asp:LinkButton ID="lbl88" runat="server" OnClick="lib_click8" Style="width: 110px;padding-right: 3px;"
                Text="<%$Resources:Master, title_website%>"></asp:LinkButton></li>
                    
        </ul>
    </li>
    <li id="lt12" runat="server" style="float:right">
        <img id="img_library" runat="server" src="../images/menuImages/side-Op.gif" width="20"
            height="32" class="menuButN" alt="" /></li>
    <li id="lt13" runat="server" style="float:right;width:104px">
        <asp:LinkButton ID="a_timeline" runat="server" style="width:104px;height: 32px;vertical-align: middle;display: table-cell;"   Text="<%$Resources:Master, title_timeline%>"
            OnClick="timeline_click" href="../general/ver 25.swf" target="_blank"></asp:LinkButton></li>
    <li id="lt14" runat="server" style="float:right">
        <img id="img_timeline" runat="server" src="../images/menuImages/side-Op.gif" width="20"
            height="32" class="menuButN" alt="" /></li>
    <li id="lt15" runat="server" style="float:right;width:115px">
        <asp:LinkButton ID="a_media" runat="server"  OnClick="media_click">
            <asp:Label ID="Literal8" runat="server" style="width:115px;height: 32px;vertical-align: middle;display: table-cell;"  Text="<%$Resources:Master, title_media%>" /></asp:LinkButton>
        <ul>
            <li id="lt15_1" runat="server" style="float:right">
                <asp:LinkButton ID="l6" runat="server" OnClick=" media_click" Style="width: 130px;padding-right: 3px;"
                    Text="<%$Resources:Master, title_photo%>"></asp:LinkButton></li>
            <li id="lt15_2" runat="server" style="float:right">
                <asp:LinkButton ID="l7" runat="server" OnClick=" media_click1" Style="width: 130px;padding-right: 3px;"
                    Text="<%$Resources:Master, title_audios%>"></asp:LinkButton></li>
            <li id="lt15_3" runat="server" style="float:right">
                <asp:LinkButton ID="l8" runat="server" OnClick=" media_click2" Style="width: 130px;padding-right: 3px;"
                    Text="<%$Resources:Master, title_video%>"></asp:LinkButton></li>
        </ul>
    </li>
</ul>
