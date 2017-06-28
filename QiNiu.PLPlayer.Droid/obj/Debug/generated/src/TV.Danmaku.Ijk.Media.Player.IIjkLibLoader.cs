using System;
using System.Collections.Generic;
using Android.Runtime;

namespace TV.Danmaku.Ijk.Media.Player {

	// Metadata.xml XPath interface reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IjkLibLoader']"
	[Register ("tv/danmaku/ijk/media/player/IjkLibLoader", "", "TV.Danmaku.Ijk.Media.Player.IIjkLibLoaderInvoker")]
	public partial interface IIjkLibLoader : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IjkLibLoader']/method[@name='loadLibrary' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadLibrary", "(Ljava/lang/String;)V", "GetLoadLibrary_Ljava_lang_String_Handler:TV.Danmaku.Ijk.Media.Player.IIjkLibLoaderInvoker, QiNiu.PLPlayer.Droid")]
		void LoadLibrary (string p0);

	}

	[global::Android.Runtime.Register ("tv/danmaku/ijk/media/player/IjkLibLoader", DoNotGenerateAcw=true)]
	internal class IIjkLibLoaderInvoker : global::Java.Lang.Object, IIjkLibLoader {

		static IntPtr java_class_ref = JNIEnv.FindClass ("tv/danmaku/ijk/media/player/IjkLibLoader");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IIjkLibLoaderInvoker); }
		}

		IntPtr class_ref;

		public static IIjkLibLoader GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIjkLibLoader> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "tv.danmaku.ijk.media.player.IjkLibLoader"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIjkLibLoaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_loadLibrary_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadLibrary_Ljava_lang_String_Handler ()
		{
			if (cb_loadLibrary_Ljava_lang_String_ == null)
				cb_loadLibrary_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadLibrary_Ljava_lang_String_);
			return cb_loadLibrary_Ljava_lang_String_;
		}

		static void n_LoadLibrary_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.IIjkLibLoader __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IIjkLibLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadLibrary (p0);
		}
#pragma warning restore 0169

		IntPtr id_loadLibrary_Ljava_lang_String_;
		public unsafe void LoadLibrary (string p0)
		{
			if (id_loadLibrary_Ljava_lang_String_ == IntPtr.Zero)
				id_loadLibrary_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "loadLibrary", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadLibrary_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
