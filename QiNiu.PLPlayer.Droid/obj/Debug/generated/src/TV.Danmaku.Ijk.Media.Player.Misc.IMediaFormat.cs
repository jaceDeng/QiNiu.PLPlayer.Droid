using System;
using System.Collections.Generic;
using Android.Runtime;

namespace TV.Danmaku.Ijk.Media.Player.Misc {

	[Register ("tv/danmaku/ijk/media/player/misc/IMediaFormat", DoNotGenerateAcw=true)]
	public abstract class MediaFormat : Java.Lang.Object {

		internal MediaFormat ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/interface[@name='IMediaFormat']/field[@name='KEY_HEIGHT']"
		[Register ("KEY_HEIGHT")]
		public const string KeyHeight = (string) "height";

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/interface[@name='IMediaFormat']/field[@name='KEY_MIME']"
		[Register ("KEY_MIME")]
		public const string KeyMime = (string) "mime";

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/interface[@name='IMediaFormat']/field[@name='KEY_WIDTH']"
		[Register ("KEY_WIDTH")]
		public const string KeyWidth = (string) "width";
	}

	[Register ("tv/danmaku/ijk/media/player/misc/IMediaFormat", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'MediaFormat' type. This type will be removed in a future release.")]
	public abstract class MediaFormatConsts : MediaFormat {

		private MediaFormatConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/interface[@name='IMediaFormat']"
	[Register ("tv/danmaku/ijk/media/player/misc/IMediaFormat", "", "TV.Danmaku.Ijk.Media.Player.Misc.IMediaFormatInvoker")]
	public partial interface IMediaFormat : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/interface[@name='IMediaFormat']/method[@name='getInteger' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getInteger", "(Ljava/lang/String;)I", "GetGetInteger_Ljava_lang_String_Handler:TV.Danmaku.Ijk.Media.Player.Misc.IMediaFormatInvoker, QiNiu.PLPlayer.Droid")]
		int GetInteger (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/interface[@name='IMediaFormat']/method[@name='getString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getString", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetString_Ljava_lang_String_Handler:TV.Danmaku.Ijk.Media.Player.Misc.IMediaFormatInvoker, QiNiu.PLPlayer.Droid")]
		string GetString (string p0);

	}

	[global::Android.Runtime.Register ("tv/danmaku/ijk/media/player/misc/IMediaFormat", DoNotGenerateAcw=true)]
	internal class IMediaFormatInvoker : global::Java.Lang.Object, IMediaFormat {

		static IntPtr java_class_ref = JNIEnv.FindClass ("tv/danmaku/ijk/media/player/misc/IMediaFormat");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMediaFormatInvoker); }
		}

		IntPtr class_ref;

		public static IMediaFormat GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMediaFormat> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "tv.danmaku.ijk.media.player.misc.IMediaFormat"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMediaFormatInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getInteger_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetInteger_Ljava_lang_String_Handler ()
		{
			if (cb_getInteger_Ljava_lang_String_ == null)
				cb_getInteger_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetInteger_Ljava_lang_String_);
			return cb_getInteger_Ljava_lang_String_;
		}

		static int n_GetInteger_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.Misc.IMediaFormat __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.Misc.IMediaFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetInteger (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getInteger_Ljava_lang_String_;
		public unsafe int GetInteger (string p0)
		{
			if (id_getInteger_Ljava_lang_String_ == IntPtr.Zero)
				id_getInteger_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getInteger", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getInteger_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetString_Ljava_lang_String_Handler ()
		{
			if (cb_getString_Ljava_lang_String_ == null)
				cb_getString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetString_Ljava_lang_String_);
			return cb_getString_Ljava_lang_String_;
		}

		static IntPtr n_GetString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.Misc.IMediaFormat __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.Misc.IMediaFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetString (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getString_Ljava_lang_String_;
		public unsafe string GetString (string p0)
		{
			if (id_getString_Ljava_lang_String_ == IntPtr.Zero)
				id_getString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
