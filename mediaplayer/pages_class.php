<?
/**
 * This class handling page actions
 *
 */


$ar_ch = array();

$ar_ch["a"] = "1";
$ar_ch["b"] = "2";
$ar_ch["c"] = "3";
$ar_ch["d"] = "4";
$ar_ch["e"] = "5";
$ar_ch["f"] = "6";
$ar_ch["g"] = "7";
$ar_ch["h"] = "8";
$ar_ch["i"] = "9";
$ar_ch["j"] = "10";
$ar_ch["k"] = "11";
$ar_ch["l"] = "12";
$ar_ch["m"] = "13";
$ar_ch["n"] = "14";
$ar_ch["o"] = "15";
$ar_ch["p"] = "16";
$ar_ch["q"] = "17";
$ar_ch["r"] = "18";
$ar_ch["s"] = "19";
$ar_ch["t"] = "20";
$ar_ch["u"] = "21";
$ar_ch["v"] = "22";
$ar_ch["w"] = "23";
$ar_ch["x"] = "24";
$ar_ch["y"] = "25";
$ar_ch["z"] = "26";



class page_helper
{
	/**
	 * Variable contains page name
	 *
	 * @return page_helper
	 */
	var $page_name = "";
	
	/**
	 * Class constructor function
	 *
	 */
	function __construct() {}
	
	/**
	 * This function returns body page name to include.
	 *
	 * @param string $page_param
	 * @return string
	 */
	function get_page_name($page_param)
    { 
    	switch ($page_param) {
    		case "services":
    			$this->page_name = "services.php";
    			break;
    		case "contactus":
    			$this->page_name = "contactus.php";
    			break;
    		case "about":
    			$this->page_name = "about.php";
    			break;
    		case "search":
    			$this->page_name = "search.php";
    			break;
    		case "profile":
    			$this->page_name = "profile.php";
    			break;
    		case "events":
    			$this->page_name = "events.php";
    			break;
    		case "tour":
    			$this->page_name = "tours.php";
    			break;
    		case "viewtour":
    			$this->page_name = "viewtour.php";
    			break;
    		case "tourism":
    			$this->page_name = "tourism.php";
    			break;
    		case "viewtourism":
    			$this->page_name = "viewtourism.php";
    			break;
    		case "reservation":
    			$this->page_name = "reserv.php";
    			break;
    		case "hotels":
    			$this->page_name = "hoteltown.php";
    			break;
    		case "townhotels":
    			$this->page_name = "hotels.php";
    			break;
    		case "hoteldet":
    			$this->page_name = "hoteldetails.php";
    			break;
    		case "destination":
    			$this->page_name = "destination.php";
    			break;
    		case "viewdest":
    			$this->page_name = "viewdestination.php";
    			break;
    			
    		default:
    			$this->page_name = "welcome.php";
    			break;
    	}
    	return $this->page_name;
    }
    
    /**
     * This function sets includes paths in application.
     *
     */
    function set_includes_paths()
    {
    	set_include_path(get_include_path() . PATH_SEPARATOR . "business");
		set_include_path(get_include_path() . PATH_SEPARATOR . "classes");
		set_include_path(get_include_path() . PATH_SEPARATOR . "includes");
		set_include_path(get_include_path() . PATH_SEPARATOR . "views");
    }
    
    /**
	 * Function to get file extension
	 *
	 * @param string $fileName
	 * @return string
	 */
	function getFileExtension($fileName)
	{
		$fileExtension = "";
		$extensionPos  = strrpos($fileName,".");
		if ($extensionPos === false)
			$fileExtension = false;
		else {
			$extensionPos++;
		$fileExtension = strtolower(substr($fileName,$extensionPos));
		}
		
		return $fileExtension;
	}
	
	/**
	 * Function to return HTML code required to embed any media and play it in HTML
	 *
	 */
	function getEmbeddedHTMLCode($fileName,$width = 320,$height = 240)
	{
		$fileExtension 	= $this->getFileExtension($fileName);
		$HTMLCode 		= "";
		$lang 			= $this->lang;
		$script 		= substr($_SERVER['SCRIPT_NAME'],0,(strrpos($_SERVER['SCRIPT_NAME'],"/")+1));
		$fileName		= urldecode($fileName);
		
		switch ($fileExtension) 
		{
			case "swf":
				$HTMLCode = "<table border='0' cellpadding='0' align=center>
						        <!-- begin video window... -->
						        <tr><td>
						        <object classid='clsid:D27CDB6E-AE6D-11cf-96B8-444553540000' codebase='http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=7,0,19,0' width='$width' height='285' title='".$lang["view_flash"]."'>
							  <param name='movie' value='$fileName' />
							  <param name='quality' value='high' />
							  <embed src='$fileName' quality='high' pluginspage='http://www.macromedia.com/go/getflashplayer' type='application/x-shockwave-flash' width='$width' height='285'></embed>
							</object></td></tr></table>";
				break;
				
			case "rm":
			case "rmvb":
			case "ra":
				$HTMLCode = " <table border='0' cellpadding='0' align=center>
						        <tr><td>
								<OBJECT id='rvocx' classid='clsid:CFCDAA03-8BE4-11cf-B84B-0020AFBBCCFA'
						        width='$width' height='$height'>
						        <param name='src' value='$fileName'>
						        <param name='autostart' value='false'>
						        <param name='controls' value='imagewindow'>
						        <param name='console' value='video'>
						        <param name='loop' value='true'>
						        <EMBED src='$fileName' width='$width' height='$height' 
						        loop='true' type='audio/x-pn-realaudio-plugin' controls='imagewindow' console='video' autostart='false'>
						        </EMBED>
						        </OBJECT></td></tr>";
				
				$HTMLCode.= "<tr><td></td></tr>
						        <tr><td align='center'>
						        <a href='$fileName' style='font-size: 85%;' target='_blank'>".$lang["launch_ext"]."</a>
						        </td></tr></table>";
				break;
				
			case "avi":
			case "wmv":
			case "wma":
			case "asf":
			case "wvx":
			case "wax":
			case "asx":
			case "wms":
			case "wmz":
			case "wmd":
			case "mpa":
			case "midi":
			case "mid":
			case "aif":
			case "mpg":
			case "mp4":
				$HTMLCode = "<table border='0' cellpadding='0' align='center'>
						      <tr><td>
						      <OBJECT id='mediaPlayer' width='$width' height='285' 
						      classid='CLSID:22d6f312-b0f6-11d0-94ab-0080c74c7e95' 
						      codebase='http://activex.microsoft.com/activex/controls/mplayer/en/nsmp2inf.cab#Version=5,1,52,701'
						      standby='Loading Microsoft Windows Media Player components...' type='application/x-oleobject'>
						      <param name='fileName' value='http://".$_SERVER['SERVER_NAME'].$script."$fileName'>
						      <param name='animationatStart' value='true'>
						      <param name='transparentatStart' value='true'>
						      <param name='autoStart' value='false'>
						      <param name='showControls' value='true'>
						      <param name='loop' value='true'>
						      <EMBED type='application/x-mplayer2'
						        pluginspage='http://microsoft.com/windows/mediaplayer/en/download/'
						        id='mediaPlayer' name='mediaPlayer' displaysize='4' autosize='-1' 
						        bgcolor='darkblue' showcontrols='true' showtracker='-1' 
						        showdisplay='0' showstatusbar='-1' videoborder3d='-1' width='$width' height='285'
						        src='http://".$_SERVER['SERVER_NAME'].$script."$fileName' autostart='false' designtimesp='5311' loop='true'>
						      </EMBED>
						      </OBJECT>
						      </td></tr>";
				
				$HTMLCode.= "<tr><td align='center'>
					        <a href='http://".$_SERVER['SERVER_NAME'].$script."$fileName' style='font-size: 85%;' target='_blank'>Launch in external player</a>
					        </td></tr>
					      </table>";
				break;
				
			case "flv":
			case "mp3":
				$HTMLCode = "<table border='0' cellpadding='0' align='center'>
					      <tr><td>
					      <embed src ='http://".$_SERVER['SERVER_NAME'].$script."mediaplayer/player-viral.swf?file=http://".$_SERVER['SERVER_NAME'].$script."$fileName' width='$width' height='$height' allowfullscreen='true' />
					      </td></tr></table>";
				break;
			case "gif":
			case "jpg":
			case "jpeg":
			case "png":
				$HTMLCode = "<table border='0' cellpadding='0' align='center'>
					      <tr><td>
					      <img src ='$fileName' border='0' />
					      </td></tr></table>";
				break;
				
			default:
				break;
		}
		return $HTMLCode;
	}
	
	/**
	 * Resize images
	 *
	 * @param string $img
	 * @param integer $w
	 * @param integer $h
	 * @param string $new_bath
	 * @param integer $percent
	 * @param string $constrain
	 * @return bool
	 */
	
	function resize_images($img,$w,$h,$new_bath,$percent = 0,$constrain = "")
	{
	//	header ("Content-type: image/jpeg");
		// get image size of img
		$x = @getimagesize($img);
		// image width
		$sw = $x[0];
		// image height
		$sh = $x[1];
		if ($w>$sw)
			$w = $sw;
		if ($h>$sh)
			$h = $sh;
		if ($percent > 0) 
		{
			// calculate resized height and width if percent is defined
			$percent = $percent * 0.01;
			$w = $sw * $percent;
			$h = $sh * $percent;
		} 
		else 
		{
			if (isset ($w) AND !isset ($h)) 
			{
				// autocompute height if only width is set
				$h = (100 / ($sw / $w)) * .01;
				$h = @round ($sh * $h);
			} elseif (isset ($h) AND !isset ($w)) {
				// autocompute width if only height is set
				$w = (100 / ($sh / $h)) * .01;
				$w = @round ($sw * $w);
			} elseif (isset ($h) AND isset ($w) AND isset ($constrain)) {
				// get the smaller resulting image dimension if both height
				// and width are set and $constrain is also set
				$hx = (100 / ($sw / $w)) * .01;
				$hx = @round ($sh * $hx);
		
				$wx = (100 / ($sh / $h)) * .01;
				$wx = @round ($sw * $wx);
		
				if ($hx < $h) {
					$h = (100 / ($sw / $w)) * .01;
					$h = @round ($sh * $h);
				} else {
					$w = (100 / ($sh / $h)) * .01;
					$w = @round ($sw * $w);
				}
			}
		}
		
		$im = @ImageCreateFromJPEG ($img) or // Read JPEG Image
		$im = @ImageCreateFromPNG ($img) or // or PNG Image
		$im = @ImageCreateFromGIF ($img) or // or GIF Image
		$im = false; // If image is not JPEG, PNG, or GIF
		
		if (!$im) {
			
			// We get errors from PHP's ImageCreate functions...
			// So let's echo back the contents of the actual image.
	//		readfile ($img);
		} else {
			// Create the resized image destination
			$thumb = @ImageCreateTrueColor ($w, $h);
			// Copy from image source, resize it, and paste to image destination
			@ImageCopyResampled ($thumb, $im, 0, 0, 0, 0, $w, $h, $sw, $sh);
			// Output resized image
		//	@ImageJPEG ($thumb,);
			imagejpeg($thumb,$new_bath);
		}
		return true;
	}

	
	/**
	 * Class destructor
	 *
	 */
	
    function __destruct() {}
}
?>