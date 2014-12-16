<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TimeLineShow.ascx.cs" Inherits="user_controls_TimeLineShow" %>
<style type="text/css">
    .style1
    {
        width: 100%;
    }
</style>
<?xml version="1.0"?>
<table class="style1" width="100%">
    <tr>
        <td>

    
      
      
<%--       <object type="application/x-shockwave-flash" data="~/user_controls/timeLine/Timeline.swf" width="632" height="120">
        <!--<![endif]-->
        <param name="quality" value="high" />
        <param name="wmode" value="opaque" />
        <param name="swfversion" value="6.0.65.0" />
        <param name="expressinstall" value="Scripts/expressInstall.swf" />
        <!-- The browser displays the following alternative content for users with Flash Player 6.0 and older. -->
        <div>
          <h4>Content on this page requires a newer version of Adobe Flash Player.</h4>
          <p><a href="http://www.adobe.com/go/getflashplayer"><img src="http://www.adobe.com/images/shared/download_buttons/get_flash_player.gif" alt="Get Adobe Flash player" width="112" height="33" /></a></p>
        </div>
        <!--[if !IE]>-->
      </object>--%>
      

<p>
    
 <object id="object1" classid="clsid:d27cdb6e-ae6d-11cf-96b8-444553540000" width="1000px" height="300px">
      <param name="movie" value="timeline.swf" />
      <param name="quality" value="high" />
      <param name="wmode" value="opaque" />
      <param name="swfversion" value="6.0.65.0" />
        <param name="flashvars" value="file=timelinedata.xml"/>  
      <!-- this param tag prompts users with flash player 6.0 r65 and
       higher to download the latest version of flash player. delete it if you don’t want users to see the prompt. -->
      <param name="expressinstall" value="scripts/expressinstall.swf" />
      <!-- next object tag is for non-ie browsers. so hide it from ie using iecc. -->
      <!--[if !ie]>-->
      <object type="application/x-shockwave-flash" data="timeline.swf" width="1000px" height="300px">
        <!--<![endif]-->
        <param name="quality" value="high" />
        <param name="wmode" value="opaque" />
        <param name="swfversion" value="6.0.65.0" />
        <param name="expressinstall" value="scripts/expressinstall.swf" />
         <param name="flashvars" value="file=timelinedata.xml"/>  
        <!-- the browser displays the following alternative content for users with flash player 6.0 and older. -->
        <div>
          <h4>content on this page requires a newer version of adobe flash player.</h4>
          <p><a href="http://www.adobe.com/go/getflashplayer"><img src="http://www.adobe.com/images/shared/download_buttons/get_flash_player.gif" alt="get adobe flash player" width="112" height="33" /></a></p>
        </div>
        <!--[if !ie]>-->
      </object>
      <!--<![endif]-->
    </object>
    
   <%--  <object width="425" height="344">
  <embed src="../user_controls/timeline/timeline.swf" type="application/x-shockwave-flash" width="425" height="344"></embed>
</object>--%>
    
    
  <%-- <div id="flashContent">

            <object classid="clsid:d27cdb6e-ae6d-11cf-96b8-444553540000" width="350" height="150" id="FlashPlayer" align="middle">
                <param name="movie" value="../user_controls/timeline/timeline.swf" />
                <param name="quality" value="high" />
                <param name="bgcolor" value="#ffffff" />
                <param name="play" value="true" />
                <param name="loop" value="true" />
                <param name="wmode" value="window" />
                <param name="scale" value="showall" />
                <param name="menu" value="true" />

                <param name="devicefont" value="false" />
                <param name="salign" value="" />
                <param name="allowScriptAccess" value="sameDomain" />
                <!--[if !IE]>-->
                <object type="application/x-shockwave-flash" data="../user_controls/timeline/timeline.swf" width="473" height="269">
                    <param name="movie" value="../user_controls/timeline/timeline.swf" />
                    <param name="quality" value="high" />
                    <param name="bgcolor" value="#ffffff" />
                    <param name="play" value="true" />

                    <param name="loop" value="true" />
                    <param name="wmode" value="window" />
                    <param name="scale" value="showall" />
                    <param name="menu" value="true" />
                    <param name="devicefont" value="false" />
                    <param name="salign" value="" />
                    <param name="allowScriptAccess" value="sameDomain" />
                <!--<![endif]-->
                    <a href="http://www.adobe.com/go/getflash">

                        <img src="http://www.adobe.com/images/shared/download_buttons/get_flash_player.gif" alt="Get Adobe Flash player" />
                    </a>
                <!--[if !IE]>-->
                </object>
                <!--<![endif]-->
            </object>
        </div>--%>

   
  </p>
     

     </td>
    </tr>
</table>
