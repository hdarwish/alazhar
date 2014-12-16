<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TimeLineShow.ascx.cs" Inherits="user_controls_TimeLineShow" %>

<?xml version="1.0"?>
<table  width="100%" style="height:120px">
    <tr>
        <td width="100%" height="120px">


<p style="width: 100%; height: 120px">
   
<object id="object1" classid="clsid:d27cdb6e-ae6d-11cf-96b8-444553540000" width="100%" height="120px">
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
      <object type="application/x-shockwave-flash" data="Timeline.swf" width="100%" height="120px">
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
    
 <%--<embed src="Timeline.swf" width="900px" height="120px" align="left"></embed>--%>

   
  </p>
     

     </td>
    </tr>
</table>
