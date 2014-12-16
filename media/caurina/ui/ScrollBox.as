package caurina.ui{
	import flash.display.*;
	import flash.events.*;
	import caurina.transitions.*;

	public class ScrollBox extends MovieClip {

		public function ScrollBox():void {
			sb.addEventListener(ScrollBarEvent.VALUE_CHANGED, sbChange);
		}
		
		private function sbChange(e:ScrollBarEvent):void {
			Tweener.addTween(content, {x:(-e.scrollPercent*(content.width-masker.width)), time:1});
		}
	}
}