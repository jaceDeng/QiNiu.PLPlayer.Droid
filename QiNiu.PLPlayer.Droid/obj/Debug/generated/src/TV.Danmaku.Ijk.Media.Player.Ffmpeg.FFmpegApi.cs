using System;
using System.Collections.Generic;
using Android.Runtime;

namespace TV.Danmaku.Ijk.Media.Player.Ffmpeg {

	// Metadata.xml XPath class reference: path="/api/package[@name='tv.danmaku.ijk.media.player.ffmpeg']/class[@name='FFmpegApi']"
	[global::Android.Runtime.Register ("tv/danmaku/ijk/media/player/ffmpeg/FFmpegApi", DoNotGenerateAcw=true)]
	public partial class FFmpegApi : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("tv/danmaku/ijk/media/player/ffmpeg/FFmpegApi", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FFmpegApi); }
		}

		protected FFmpegApi (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='tv.danmaku.ijk.media.player.ffmpeg']/class[@name='FFmpegApi']/constructor[@name='FFmpegApi' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FFmpegApi ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (FFmpegApi)) {
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

		static IntPtr id_av_base64_encode_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player.ffmpeg']/class[@name='FFmpegApi']/method[@name='av_base64_encode' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("av_base64_encode", "([B)Ljava/lang/String;", "")]
		public static unsafe string Av_base64_encode (byte[] p0)
		{
			if (id_av_base64_encode_arrayB == IntPtr.Zero)
				id_av_base64_encode_arrayB = JNIEnv.GetStaticMethodID (class_ref, "av_base64_encode", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_av_base64_encode_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
