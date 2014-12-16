var menuids=new Array("verticalmenu") //Enter id(s) of UL menus, separated by commas
var submenuoffset=-2 //Offset of submenus from main menu. Default is -2 pixels.

function createcssmenu()
{
    for (var i=0; i<menuids.length; i++)
    {
        var ultags=document.getElementById(menuids[i]).getElementsByTagName("ul")
        for (var t=0; t<ultags.length; t++)
        {
            var spanref=document.createElement("span")
            spanref.className="arrowdiv"
            spanref.innerHTML="&nbsp;&nbsp;"
            ultags[t].parentNode.getElementsByTagName("a")[0].appendChild(spanref)
            
            if(ultags[t].className == "newclass")
            {
           
                ultags[t].parentNode.onmouseover=function()
                {
                    var lft = this.parentNode.offsetWidth
                    if(navigator.appName.toLowerCase().indexOf("microsoft") >= 0)
                    {
                        this.getElementsByTagName("ul")[0].style.right=(lft+228)+submenuoffset+"px"
                    }
                    else
                    this.getElementsByTagName("ul")[0].style.right=(lft+227)+submenuoffset+"px"
                    this.getElementsByTagName("ul")[0].style.display="block"
                }
            }
            else
            {
                ultags[t].parentNode.onmouseover=function()
                {
                    if(navigator.appName.toLowerCase().indexOf("microsoft") >= 0)
                    this.getElementsByTagName("ul")[0].style.right=(this.parentNode.offsetWidth)+submenuoffset+"px"
                    else
                    this.getElementsByTagName("ul")[0].style.right=(this.parentNode.offsetWidth-0)+submenuoffset+"px"
                    this.getElementsByTagName("ul")[0].style.display="block"
                }
            }
            ultags[t].parentNode.onmouseout=function()
            {
                this.getElementsByTagName("ul")[0].style.display="none"
            }
            
        }
        
    }
}


if (window.addEventListener)
window.addEventListener("load", createcssmenu, false)
else if (window.attachEvent)
window.attachEvent("onload", createcssmenu)