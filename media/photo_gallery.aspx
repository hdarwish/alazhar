<%@ Page Language="C#" MasterPageFile="~/masterpage/MasterPage.master" AutoEventWireup="true" CodeFile="~/media/photo_gallery.aspx.cs" Inherits="Photo_Gallery" Title="Photo Gallary" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  	<link rel="stylesheet" href="../galleriffic/css/basic.css" type="text/css" />
		<link rel="stylesheet" href="../galleriffic/css/galleriffic-5.css" type="text/css" />
		
		<!-- <link rel="stylesheet" href="css/white.css" type="text/css" /> -->
		<link rel="stylesheet" href="../galleriffic/css/white.css"type="text/css" />
		
		<script type="text/javascript" src="../galleriffic/js/jquery-1.3.2.js"></script>
		<script type="text/javascript" src="../galleriffic/js/jquery.history.js"></script>
		<script type="text/javascript" src="../galleriffic/js/jquery.galleriffic.js"></script>
		<script type="text/javascript" src="../galleriffic/js/jquery.opacityrollover.js"></script>
  <script type="text/javascript">
			document.write('<style>.noscript { display: none; }</style>'); 
//		function Category()
//        {
//            this.title;
//            this.describtion;
//            this.photographer;
//            this.source;
//        }
//        var Images = new Array();
//        
//        function LoadArray()
//        {
//            
////              
////                
////            
//        }
//       
//        
//        this.onload = LoadArray;
//        
//        function ShowElements()
//        {
//            for(var i=0;i<Images.length;i++)
//                alert(Images[i].title + "\n" + Images[i].describtion);
//            return false;
//        }
		</script>
	
	<table runat="server" align="center" style="width: 580px;" border="0">
	<tr><td>
	
		<div id="page">
			<div id="container" style="width: 100%" align="left"  >
				<h1 align="center" 
                    style="color: #6A6A6A; font-size: 14px; font-weight: bold; font-family: 'tahoma';">
				    
				       معرض الصور
				   
				</h1>

				<!-- Start Advanced Gallery Html Containers -->				
				<div class="navigation-container" align="center" dir="rtl" style="border:0px">
					<div id="thumbs" class="navigation" align="left" dir="ltr" style="width: 100%" >
						<%--<a class="pageLink prev" style="visibility: visible;" href="#" title="Previous Page"></a>--%>
					
						<ul class="thumbs noscript">
							<asp:Repeater ID="Repeater1" runat="server"  >
							    <ItemTemplate>
							        <li>
								<a class="thumb" name="leaf" href="<%#"../images/" + Eval("large_image") %>" title="Title #0"  >
									<img  src="<%#"../images/" + Eval("large_image") %>" alt="Title #0" style="border:0;"  width="35" height="35" border="0"/>
									</a>
								
							    </li>  
							    
							    </ItemTemplate>
							   
							</asp:Repeater>
							
						
						 <%--   <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                                SelectCommand="SELECT [file_name], [extension] FROM [content_media]"></asp:SqlDataSource>
							--%>
	
						</ul>
						<%--<a class="pageLink next" style="visibility: visible;" href="#" title="Next Page"></a>--%>
					</div>
				</div>
				<div class="content">
					<div class="slideshow-container" >
						<div id="controls" class="controls"></div>
						<div id="loading" class="loader"></div>
						<div id="slideshow" class="slideshow"></div>
					</div>
					
					<div id="caption" class="caption-container" style="border-style: none">
					<br />
						<div class="photo-index" style="vertical-align: bottom; text-align: right; width: 560px"></div>
					
					</div>
						
				</div>
				<!-- End Gallery Html Containers -->
				<div style="clear: both;"></div>
			</div>
			<%--<div id="details" style="width:100%" align="center">
			    
			</div>--%>
		</div>
		</td></tr>
		</table>
		<table align="center" style="width: 580px; height: 400px; border-width:0px" ><tr><td><script type="text/javascript">
			jQuery(document).ready(function($) {
				// We only want these styles applied when javascript is enabled
				$('div.content').css('display', 'block');

				
				 
				 //show title with image
//				 this.find('div.photo_discribtion')
//						.html('العنوان : '+ photosArray[nextIndex+1][1] );
				
                 
                 // Initially set opacity on thumbs and add
				// additional styling for hover effect on thumbs
                 
				var onMouseOutOpacity = 0.67;
				$('#thumbs ul.thumbs li, div.navigation a.pageLink').opacityrollover({
					mouseOutOpacity:   onMouseOutOpacity,
					mouseOverOpacity:  1.0,
					fadeSpeed:         'fast',
					exemptionSelector: '.selected'
				});
				
				// Initialize Advanced Galleriffic Gallery
				var gallery = $('#thumbs').galleriffic({
					delay:                     5000,
					numThumbs:                 10,
					preloadAhead:              10,
					enableTopPager:            false,
					enableBottomPager:         false,
					imageContainerSel:         '#slideshow',
					controlsContainerSel:      '#controls',
					captionContainerSel:       '#caption',
					loadingContainerSel:       '#loading',
					renderSSControls:          true,
					renderNavControls:         true,
					playLinkText:              'تشغيل العرض مستمر',
					pauseLinkText:             'إيقاف العرض المستمر',
					prevLinkText:              ' الصورة السابقة',
					nextLinkText:              'الصورة التالية ',
					nextPageLinkText:          'التالى &rsaquo;',
					prevPageLinkText:          '&lsaquo; السابق',
					enableHistory:             true,
					autoStart:                 false,
					syncTransitions:           true,
					defaultTransitionDuration: 900,
					onSlideChange:             function(prevIndex, nextIndex) {
						// 'this' refers to the gallery, which is an extension of $('#thumbs')
						this.find('ul.thumbs').children()
							.eq(prevIndex).fadeTo('fast', onMouseOutOpacity).end()
							.eq(nextIndex).fadeTo('fast', 1.0);

						// Update the photo index display
						this.$captionContainer.find('div.photo-index')
						.html('<br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><ul dir="rtl"><li><b>العنوان : </b>'+ photosArray[nextIndex][3] +'</li><li><b>الوصف : </b> '+ photosArray[nextIndex][4]+'</li><li><b>المصور : </b> '+ photosArray[nextIndex][12]+'</li><li><b>المصدر : </b> '+ photosArray[nextIndex][13]+'</li></ul>    الصورة '+ (nextIndex+1) +' من '+ this.data.length);
						
                       
                     
                        
					},
					onPageTransitionOut:       function(callback) {
						this.fadeTo('fast', 0.0, callback);
					},
					onPageTransitionIn:        function() {
						var prevPageLink = this.find('a.prev').css('visibility', 'hidden');
						var nextPageLink = this.find('a.next').css('visibility', 'hidden');
						
						// Show appropriate next / prev page links
						if (this.displayedPage > 0)
							prevPageLink.css('visibility', 'visible');

						var lastPage = this.getNumPages() - 1;
						if (this.displayedPage < lastPage)
							nextPageLink.css('visibility', 'visible');

						this.fadeTo('fast', 1.0);
					}
				});

				/**************** Event handlers for custom next / prev page links **********************/

				gallery.find('a.prev').click(function(e) {
					gallery.previousPage();
					e.preventDefault();
				});

				gallery.find('a.next').click(function(e) {
					gallery.nextPage();
					e.preventDefault();
				});

				/****************************************************************************************/

				/**** Functions to support integration of galleriffic with the jquery.history plugin ****/

				// PageLoad function
				// This function is called when:
				// 1. after calling $.historyInit();
				// 2. after calling $.historyLoad();
				// 3. after pushing "Go Back" button of a browser
				function pageload(hash) {
					// alert("pageload: " + hash);
					// hash doesn't contain the first # character.
					if(hash) {
						$.galleriffic.gotoImage(hash);
					} else {
						gallery.gotoIndex(0);
					}
				}

				// Initialize history plugin.
				// The callback is called at once by present location.hash. 
				$.historyInit(pageload, "advanced.html");

				// set onlick event for buttons using the jQuery 1.3 live method
				$("a[rel='history']").live('click', function(e) {
					if (e.button != 0) return true;

					var hash = this.href;
					hash = hash.replace(/^.*#/, '');

					// moves to a new page. 
					// pageload is called at once. 
					// hash don't contain "#", "?"
					$.historyLoad(hash);

					return false;
				});

				/****************************************************************************************/
			});
		</script></td></tr></table>
		
  </asp:Content>
