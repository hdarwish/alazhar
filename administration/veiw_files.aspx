<%@ Page Language="C#" AutoEventWireup="true" CodeFile="veiw_files.aspx.cs" Inherits="administration_veiw_files" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="divImages" runat="server">
    <asp:Image ID="imgToVeiw" runat="server" />
    
    
    </div>
    <br />
    <div id="divVid" runat="server" style="display:none">
   
      
        <object width="425px" height="344px" 
        type="video/x-ms-asf" url='<%= Get_vid_Path() %>' data='<%= Get_vid_Path() %>'
        classid="CLSID:6BF52A52-394A-11d3-B153-00C04F79FAA6">
        <param name="url" value='<%= Get_vid_Path() %>'>
        <param name="filename" value='<%= Get_vid_Path() %>'>
        <param name="autostart" value="1">
        <param name="uiMode" value="full" />
        <param name="autosize" value="1">
        <param name="playcount" value="1">                              
        <embed type="application/x-mplayer2" src='<%= Get_vid_Path() %>' width="425px" height="344px" autostart="true" showcontrols="true" pluginspage="http://www.microsoft.com/Windows/MediaPlayer/"></embed>
        </object>

        </div>
        <div id="divAudio" runat="server" style="display:none">
         <object width="425px" height="344px" 
        type="video/x-ms-asf" url='<%= Get_aud_Path() %>' data='<%= Get_aud_Path() %>'
        classid="CLSID:6BF52A52-394A-11d3-B153-00C04F79FAA6">
        <param name="url" value='<%= Get_aud_Path() %>'>
        <param name="filename" value='<%= Get_aud_Path() %>'>
        <param name="autostart" value="1">
        <param name="uiMode" value="full" />
        <param name="autosize" value="1">
        <param name="playcount" value="1">                              
        <embed type="application/x-mplayer2" src='<%= Get_aud_Path() %>' width="425px" height="344px" autostart="true" showcontrols="true" pluginspage="http://www.microsoft.com/Windows/MediaPlayer/"></embed>
        </object>
       
        </div>
        <div id="divPDF" runat="server" style="display:none">
         <a href="" target="_blank" runat="server" id="link_pdf" class="books_title">
                                
                            </a>
        </div>
    </form>
</body>
</html>
