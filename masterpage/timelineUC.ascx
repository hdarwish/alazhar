<%@ Control Language="C#" AutoEventWireup="true" CodeFile="timelineUC.ascx.cs" Inherits="masterpage_timelineUC" %>
        <%--<div id="hidepage" style="top: 0px; right: 0px; position: absolute; z-index: 500; background-color: black; opacity: 0.7; display: none; width: 1440px;">
            <table align="center">
                <tbody><tr>
                    <td id="tdAlignment" style="height: 305px; ">
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <img src="../loading.gif" align="middle" />
                    </td>                
                </tr>
            </tbody></table>
        </div>
        <div id="page" style="height:100px">
		    <div id="content">
                <div id="UP_TimeLine">  
                        <div style="display:none">                                 
                            <input name="TB_FromYear" type="text" value="1799" id="TB_FromYear">
                            <input name="TB_ToYear" type="text" value="1981" id="TB_ToYear">
                            <button onclick="document.getElementById('hidepage').style.display = 'block'; __doPostBack('btnApplyTimeLine','')" id="btnApplyTimeLine" type="button"></button>                                                     
                        </div>                              
                    </div>            
                <div style="clear:both;"></div>  
            </div>
            <div class="timeline">--%>
                
 
 <script type="text/javascript">
   
    var Active=false;
    var START_YEAR = 1799;
    var END_YEAR = 1981;
    var STEP = 5; //every 5 pixels = 1 year
    
    //You can change this value for left and right adjustments
    var ADJ_LEFT = 6;//adjustment years from left
    var ADJ_RIGHT = 7;//adjustment years from right
    
    window.onload = function() 
    {   
        positionRightSlider(document.getElementById('TB_FromYear').value);
        positionLeftSlider(document.getElementById('TB_ToYear').value);
        
        if(Active==false)
        {
            document.getElementById("tdRight").style.display = 'none';
            document.getElementById("tdLeft").style.display = 'none';
            document.getElementById("tdMiddle").style.display = 'none';
            return;
        }
        else
        {              
            //document.getElementById("tdLeft").onmousedown = mdownL;
            document.getElementById("DivLeft").onmousedown = mdownL;
           // document.getElementById("tdRight").onmousedown = mdownR;
            document.getElementById("DivRight").onmousedown = mdownR;
            document.getElementById("LeftYear").onmousedown = mdownL;
            document.getElementById("RightYear").onmousedown = mdownR;                    
            document.getElementById("timeline").onmousemove = mmove;  
            
            if(document.getElementById("LeftYear").innerHTML == '')
            {                    
                document.getElementById("tdLeft").style.width = (ADJ_LEFT*STEP) + "px"; //this width to write the current year number inside
                document.getElementById("tdRight").style.width = (ADJ_RIGHT*STEP) + "px";//this width to write the current year number inside                       
                
                document.getElementById("LeftYear").innerHTML = NumToAr(END_YEAR);
                document.getElementById("RightYear").innerHTML = NumToAr(START_YEAR);
            }
        }
        disableSelection(document.getElementById('DivLeft')) ;
        disableSelection(document.getElementById('DivRight')) ;
    }
    
    
     //dragging mode
    var dragging = false;   
    var ds = [];
    var pos = [];  
    var type='';
 
        
    function mdownL(e) {                      
        if (!e) e = window.event; //IE
        ds[0] = e.clientX;
        ds[1] = e.clientY;
        type = 'left';                    
        if(document.getElementById("tdLeft").style.width)
            pos[0] = parseInt(document.getElementById("tdLeft").style.width);               
        else
            pos[0] = 100;// 100 is just a lucky value
        dragging = true;  
        document.onmouseup =  mup; //to stop dragging if mouse up inside or outside the time line                               
     }
     
     function mdownR(e) {                      
        if (!e) e = window.event; //IE
        ds[0] = e.clientX;
        ds[1] = e.clientY;
        type = 'right';
        if(document.getElementById("tdRight").style.width)
            pos[0] = parseInt(document.getElementById("tdRight").style.width);               
        else
            pos[0] = 100;// 100 is just a lucky value
        dragging = true;   
        document.onmouseup =  mup; //to stop dragging if mouse up inside or outside the time line   
     }     
      
     function mmove(e) {
        if (!e) e = window.event; // IE                      
        if(dragging==false) return;
                      
        leftYear =  parseInt(NumToEn(document.getElementById("LeftYear").innerHTML));         
        rightYear = parseInt(NumToEn(document.getElementById("RightYear").innerHTML));
         
        if(type=='left')      
        {       
            wid = pos[0] + (e.clientX - ds[0]);
            newleft = END_YEAR - parseInt((wid)/STEP) + ADJ_LEFT;    
            if((wid> ADJ_LEFT*STEP) && (newleft-rightYear >1) )          
            {                   
                document.getElementById("LeftYear").innerHTML = NumToAr(newleft);
                document.getElementById("tdLeft").style.width =  wid+"px";                                                                                
            }
        }
        else if(type=='right')
        {
            wid = pos[0] - (e.clientX - ds[0]);
            newright = START_YEAR + parseInt((wid)/STEP) - ADJ_RIGHT;   //7 years for adjustments , 5pixels = 1 year and there is 35px extra width in the first               
            if((wid> ADJ_RIGHT*STEP) && (leftYear-newright >1)) 
            {                
               document.getElementById("RightYear").innerHTML = NumToAr(newright);
               document.getElementById("tdRight").style.width =  wid+"px";                                                                                
            }
        }   
     }        
               
     function mup() 
     {
     
        if(dragging == true)
        {       
            document.getElementById('TimeLine1_hiddenFromDate').value = NumToEn(document.getElementById("RightYear").innerHTML);        
            document.getElementById('TimeLine1_hiddenToDate').value = NumToEn(document.getElementById("LeftYear").innerHTML);        
           function getDocHeight() {
                var D = document;
                return Math.max(
                    Math.max(D.body.scrollHeight, D.documentElement.scrollHeight),
                    Math.max(D.body.offsetHeight, D.documentElement.offsetHeight),
                    Math.max(D.body.clientHeight, D.documentElement.clientHeight)
                );
            }
            alert( getDocHeight() );
            document.getElementById('hidepage').style.height = getDocHeight() + "px";
            document.getElementById('hidepage').style.display = 'block';
            document.getElementById('btnApplyTimeLine').click(); 
            //document.getElementById('hidepage').style.display = "none"; 
        }
        dragging = false;              
     }
    
    function positionRightSlider(year)
    {   
        if(year=='')return;
        if(year==1) year = START_YEAR;
        document.getElementById('TimeLine1_hiddenFromDate').value = year;      
        document.getElementById("RightYear").innerHTML = NumToAr(year);
        document.getElementById("tdRight").style.width = STEP *((year - START_YEAR) + ADJ_RIGHT) +"px";   
        Active = true;          
    }
    
    function positionLeftSlider(year)
    {
        if(year=='')return;
        if(year==1) year = END_YEAR;
        document.getElementById('TimeLine1_hiddenToDate').value = year;   
        document.getElementById("LeftYear").innerHTML = NumToAr(year);
        document.getElementById("tdLeft").style.width = STEP *((END_YEAR - year) + ADJ_LEFT) +"px"; 
        Active = true;          
        document.getElementById("tdLeft").style.visibility = "visible";
        document.getElementById("tdMiddle").style.visibility= "visible";
        document.getElementById("tdRight").style.visibility = "visible";
        document.getElementById("LeftYear").style.visibility = "visible";
        document.getElementById("RightYear").style.visibility = "visible";
    }
    
    //Convert English Numbers to Arabic  
   function NumToAr(str)
   {
        var myOldString = str+'';
        var myNewString = myOldString.replace(/0/g, "٠").replace(/1/g, "١").replace(/2/g, "٢").replace(/3/g, "٣").replace(/4/g, "٤").replace(/5/g, "٥").replace(/6/g, "٦").replace(/7/g, "٧").replace(/8/g, "٨").replace(/9/g, "٩");
        return myNewString;
   }
   //Convert Arabic Numbers to English 
   function NumToEn(str)
   {
        var myOldString = str+'';
        var myNewString = myOldString.replace(/٠/g, "0").replace(/١/g, "1").replace(/٢/g, "2").replace(/٣/g, "3").replace(/٤/g, "4").replace(/٥/g, "5").replace(/٦/g, "6").replace(/٧/g, "7").replace(/٨/g, "8").replace(/٩/g, "9");
        return myNewString;
   }

    function disableSelection(target)
    {  
        if (typeof target.onselectstart!="undefined") //IE route
        {
            target.onselectstart=function(){return false;}
        }
        else if (typeof target.style.MozUserSelect!="undefined") //Firefox route
        {
            target.style.MozUserSelect="none";
        }
    }
    
   
 </script>

 
 <style>
     #tdLeft{
         background-color:#5d4e2f; filter:alpha(opacity=30);opacity:0.30; visibility:hidden; 
     }
     #tdRight{
        background-color:#5d4e2f; filter:alpha(opacity=30); opacity:0.30;visibility:hidden;
     }

     #tblTimeLine{
        width: 986px; background-image: url(../TimeLine.gif); background-repeat: no-repeat;  background-position-y:top; 
     }
     #DivLeft{
        background-image: url(../Arrow_left.gif); position:relative; margin:0px 0px 0px -25px;
                                background-repeat: no-repeat; background-position: right center;  cursor:pointer; width:20px;height:30px;
     }
     #DivRight{
        background-image: url(../Arrow_right.gif);position:relative;  margin:0px -25px 0px 0px;
                             background-repeat: no-repeat; background-position: left center;  cursor:pointer; width:20px;height:30px;
     }
     .Tyear{ color:#F7F1DA; background-color:#A85A22; width:30px; visibility:hidden;}
     
 </style>
 <%--<div id="timeline" dir="ltr">
     <table id="tblTimeLine" border="0">
        <tbody><tr style="height:36px"> 
            <td id="tdLeft" align="right" style="width: 30px; visibility: visible; ">
            </td>            
            <td id="tdMiddle" style="visibility: visible; ">
                <table width="100%" border="0">
                    <tbody><tr>
                        <td align="left"><div id="DivLeft" style="z-index:500">
                        <img src="../spacer.gif"></div> 
                        </td>
                        <td align="right"><div id="DivRight" style="z-index:500">
                        <img src="../spacer.gif"></div>
                        </td>
                    </tr>
                </tbody></table>                        
            </td>
             <td id="tdRight" align="left" style="visibility: visible; width: 926px; ">
            </td>
       </tr>
       <tr style="height:33px">
            <td style="color:black; font-size:small; cursor:pointer;" align="right">
                <div class="Tyear" id="LeftYear" style="visibility: visible; ">١٩٨١</div>
            </td>
            <td>
            </td>
             <td style="font-size:small; cursor:pointer;" align="left">
             <div class="Tyear" id="RightYear" style="visibility: visible; ">١٩٧٧</div>
            </td>
        </tr>
     </tbody></table>
 </div>--%>
 <input name="TimeLine1$hiddenFromDate" type="text" id="TimeLine1_hiddenFromDate" style="display: none" value="1799">
 <input name="TimeLine1$hiddenToDate" type="text" id="TimeLine1_hiddenToDate" style="display: none" value="1981">
            </div>     
       
</div>