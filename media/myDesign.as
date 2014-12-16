package {
	import flash.display.*;
	import flash.events.*;
	import flash.net.*;
	import flash.xml.*;
	import flash.text.*;

	public class myDesign extends MovieClip {
		private var thumbFile:Array = new Array();
		private var photoFile:Array = new Array();
		private var photoTitle:Array = new Array();
		private var photoDesc:Array = new Array();
		private var itemA:Array = new Array();
		private var itemB:Array = new Array();
		private var itemC:Array = new Array();
		private var itemD:Array = new Array();
		private var itemE:Array = new Array();
		private var itemF:Array = new Array();
		private var itemG:Array = new Array();
		private var itemH:Array = new Array();
		private var whoIsOn:Number;
		private var imageGallery_xml:XML;
		private var xpos,ypos:Number;
		private var my_loaders_array:Array = new Array();

		private var xmlReq:URLRequest=new URLRequest("myData.xml");
		private var xmlLoader:URLLoader = new URLLoader();

		public function myDesign():void {
			xmlLoader.load(xmlReq);
			xmlLoader.addEventListener(Event.COMPLETE, xmlLoaded);
		}

		private function xmlLoaded(e:Event):void {
			var imageGallery_xml=new XML(xmlLoader.data);
			var numRecs:int=imageGallery_xml.image.length();

			for (var i:int = 0; i < numRecs; i++) {
				thumbFile.push(imageGallery_xml..thumbFile[i]);
				photoFile.push(imageGallery_xml..photoFile[i]);
				photoTitle.push(imageGallery_xml..photoTitle[i]);
				photoDesc.push(imageGallery_xml..photoDesc[i]);
				itemA.push(imageGallery_xml..itemA[i]);
				itemB.push(imageGallery_xml..itemB[i]);
				itemC.push(imageGallery_xml..itemC[i]);
				itemD.push(imageGallery_xml..itemD[i]);
				itemE.push(imageGallery_xml..itemE[i]);
				itemF.push(imageGallery_xml..itemF[i]);
				itemG.push(imageGallery_xml..itemG[i]);
				itemH.push(imageGallery_xml..itemH[i]);
			}
			this.nextBut.addEventListener(MouseEvent.MOUSE_DOWN, onNextClick);
			this.prevBut.addEventListener(MouseEvent.MOUSE_DOWN, onPrevClick);

			this.albumMainTitle_xml.htmlText="<b><u>"+imageGallery_xml.@albumMainTitle+"</u></b>";
			if ( imageGallery_xml.@selectedImage - 1 > 0) {
			whoIsOn = imageGallery_xml.@selectedImage - 1;
			}else{
				whoIsOn = 0;
			}
			drawThumb();
			drawData(whoIsOn);
			

			xmlLoader.removeEventListener(Event.COMPLETE, xmlLoaded);
			xmlLoader=null;
		}

		private function drawThumb():void {
			for (var i:Number=0; i<thumbFile.length; i++) {
				var my_url:String=thumbFile[i];
				var my_loader:Loader=new Loader();
				my_loader.load(new URLRequest(my_url));
				my_loader.contentLoaderInfo.addEventListener(Event.COMPLETE,onComplete);
				my_loaders_array.push(my_loader);
			}
		}

		private function onComplete(e:Event):void {
			for (var i:int = 0; i < thumbFile.length; i++) {
				var my_image:Loader=Loader(my_loaders_array[i]);
				my_image.x=i*100;
				myMC.content.addChild(my_image);
				my_image.name=String(i);
				myMC.content.addEventListener(MouseEvent.MOUSE_DOWN, butSelected);
			}
		}

		private function drawData(n:int):void {
			myHolder.removeChildAt(0);
			
			var myformat:TextFormat = new TextFormat();
			myformat.font = "Tahoma";
			myformat.rightMargin = 20;
			myformat.align = TextFormatAlign.RIGHT;
			
			var req:URLRequest=new URLRequest(photoFile[n]);
			var phLoader:Loader = new Loader();
			phLoader.contentLoaderInfo.addEventListener(Event.INIT, initLoaderImage);

			phLoader.load(req);

			photoTitle_xml.text=photoTitle[n];
			photoDesc_xml.text=photoDesc[n];
			
			itemA_xml.htmlText=itemA[n]+"<b> :"+itemA[n].@idA+"</b>";
			itemB_xml.htmlText=itemB[n]+"<b> :"+itemB[n].@idB+"</b>";
			itemC_xml.htmlText=itemC[n]+"<b> :"+itemC[n].@idC+"</b>";
			itemD_xml.htmlText=itemD[n]+"<b> :"+itemD[n].@idD+"</b>";
			itemE_xml.htmlText=itemE[n]+"<b> :"+itemE[n].@idE+"</b>";
			itemF_xml.htmlText=itemF[n]+"<b> :"+itemF[n].@idF+"</b>";
			itemG_xml.htmlText=itemG[n]+"<b> :"+itemG[n].@idG+"</b>";
			itemH_xml.htmlText=itemH[n]+"<b> :"+itemH[n].@idH+"</b>";
			
			photoTitle_xml.setTextFormat(myformat);
			photoDesc_xml.setTextFormat(myformat);
			itemA_xml.setTextFormat(myformat);
			itemB_xml.setTextFormat(myformat);
			itemC_xml.setTextFormat(myformat);
			itemD_xml.setTextFormat(myformat);
			itemE_xml.setTextFormat(myformat);
			itemF_xml.setTextFormat(myformat);
			itemG_xml.setTextFormat(myformat);
			itemH_xml.setTextFormat(myformat);
			
		}

		private function initLoaderImage(e:Event):void {
			var loader:Loader=Loader(e.target.loader);
			var info:LoaderInfo=LoaderInfo(loader.contentLoaderInfo);
			xpos=info.width;
			ypos=info.height;
			drawImage(loader, xpos, ypos);
		}

		private function drawImage(imageLoader:Loader, xp:Number, yp:Number):void {
			var w:Number=xp/800;
			var h:Number=yp/400;
			var percent:Number;
			if (w>h) {
				percent=w;
				imageLoader.width=xp/percent;
				imageLoader.height=yp/percent;
			}
			if (h>w) {
				percent=h;
				imageLoader.width=xp/percent;
				imageLoader.height=yp/percent;
			}

			if (w>1) {
				imageLoader.width=xp/percent;
				xp=imageLoader.width;
			}
			if (h>1) {
				imageLoader.height=yp/percent;
				yp=imageLoader.height;
			}

			imageLoader.x = (800 - imageLoader.width) / 2;
			imageLoader.y = (400 - imageLoader.height) / 2;
			myHolder.addChild(imageLoader);
		}

		private function onNextClick(event:MouseEvent):void {
			if (whoIsOn<photoFile.length-1) {
				whoIsOn++;
				drawData(whoIsOn);
			}
		}

		private function onPrevClick(event:MouseEvent):void {
			if (whoIsOn>0) {
				whoIsOn--;
				drawData(whoIsOn);
			}
		}

		private function butSelected(event:MouseEvent):void {
			var i:int;
			i=event.target.name;
			drawData(i);
			whoIsOn=i;
		}

	}
}
