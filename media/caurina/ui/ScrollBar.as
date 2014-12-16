package caurina.ui{
	import flash.display.*;
	import flash.events.*;

	public class ScrollBar extends MovieClip {
		private var xOffset:Number;
		private var xMin:Number;
		private var xMax:Number;

		public function ScrollBar():void {
			xMin=0;
			xMax=track.width-thumb.width;
			thumb.addEventListener(MouseEvent.MOUSE_DOWN, thumbDown);
			stage.addEventListener(MouseEvent.MOUSE_UP, thumbUp);
		}

		private function thumbDown(e:MouseEvent):void {
			stage.addEventListener(MouseEvent.MOUSE_MOVE, thumbMove);
			xOffset=mouseX-thumb.x;
		}

		private function thumbUp(e:MouseEvent):void {
			stage.removeEventListener(MouseEvent.MOUSE_MOVE, thumbMove);
		}

		private function thumbMove(e:MouseEvent):void {
			thumb.x=mouseX-xOffset;
			if (thumb.x<=xMin) {
				thumb.x=xMin;
			}
			if (thumb.x>=xMax) {
				thumb.x=xMax;
			}
			dispatchEvent(new ScrollBarEvent(thumb.x/xMax));
			e.updateAfterEvent();
		}

	}
}