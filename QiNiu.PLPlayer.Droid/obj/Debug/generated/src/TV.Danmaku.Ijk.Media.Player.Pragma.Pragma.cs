using System;
using System.Collections.Generic;
using Android.Runtime;

namespace TV.Danmaku.Ijk.Media.Player.Pragma {

	// Metadata.xml XPath class reference: path="/api/package[@name='tv.danmaku.ijk.media.player.pragma']/class[@name='Pragma']"
	[global::Android.Runtime.Register ("tv/danmaku/ijk/media/player/pragma/Pragma", DoNotGenerateAcw=true)]
	public partial class Pragma : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player.pragma']/class[@name='Pragma']/field[@name='ENABLE_VERBOSE']"
		[Register ("ENABLE_VERBOSE")]
		public const bool EnableVerbose = (bool) true;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("tv/danmaku/ijk/media/player/pragma/Pragma", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Pragma); }
		}

		protected Pragma (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='tv.danmaku.ijk.media.player.pragma']/class[@name='Pragma']/constructor[@name='Pragma' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Pragma ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Pragma)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

	}
}
