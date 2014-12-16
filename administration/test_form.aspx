<%@ Page Language="C#" AutoEventWireup="true" CodeFile="test_form.aspx.cs" Inherits="administration_test_form" MaintainScrollPositionOnPostback="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
    <%@ Register src="~/user_controls/video_form.ascx" tagname="video_form" tagprefix="uc1" %>
     <%@ Register src="~/user_controls/audio_form.ascx" tagname="audio_form" tagprefix="uc4" %>
      <%@ Register src="~/user_controls/photo_form.ascx" tagname="photo_form" tagprefix="uc5" %>
<%@ Register src="~/user_controls/main_elements.ascx" tagname="main_elements_form" tagprefix="uc2" %>
<%@ Register src="~/user_controls/support_elements.ascx" tagname="support_elements_form" tagprefix="uc3" %>
<%@ Register src="~/user_controls/timeline.ascx" tagname="timelineform" tagprefix="uc6" %>
<%@ Register src="~/user_controls/places_form.ascx" tagname="places_form" tagprefix="uc7" %>
<%@ Register Src="~/user_controls/Smart_Search.ascx" TagName="Smart_Search" TagPrefix="sm1" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    
 <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
     <div id="div1" runat="server" dir="rtl" align="center">
<uc7:places_form ID="places_form1" runat="server" /> 

</div>  

<br />
<div id="divMain" runat="server" dir="rtl" align="center">
<sm1:Smart_Search ID="Smart_Search_main_elements" runat="server" />

</div>
<br />
<div id="divSupport" runat="server" dir="rtl" align="center">
<sm1:Smart_Search ID="Smart_Search_support_elements" runat="server" />
   </div>
   
   <div id="divForm" runat="server">

     <uc6:timelineform ID="timelineform1" runat="server" />
                         
 </div>
    </form>
</body>
</html>
