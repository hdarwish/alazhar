﻿
<%@ Page Language="VB" AutoEventWireup="false" CodeFile="test.aspx.vb" Inherits="Elzakera_test" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>

<body>
    <form id="form1" runat="server">
    <div>
    



      <object classid="clsid:6BF52A52-394A-11D3-B153-00C04F79FAA6" id="Player1" width="200" height="100">
 
      <param name="URL" value="../video/1.avi"/>
  
      <param name="http://path_to_the_video">
   
      <param name="AutoStart" value="0">
   
      <param name="ShowControls" value="1">
  
      <param name="ShowStatusBar" value="1">
  
      <param name="ShowDisplay" value="1">
 
      <param name="stretchToFit" value="1">
 
      <embed type="application/x-mplayer2"
 
      pluginspage="http://www.microsoft.com/Windows/Downloads/Contents/MediaPlayer/"
  
      width="200" height="100" src="../video/1.avi"/>



      </embed>
 
      </object>

 </div>
    </form>
</body>
</html>
