using System;

namespace TV.Danmaku.Ijk.Media.Player.Annotations {

	[global::Android.Runtime.Annotation ("tv.danmaku.ijk.media.player.annotations.CalledByNative")]
	public partial class CalledByNativeAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
