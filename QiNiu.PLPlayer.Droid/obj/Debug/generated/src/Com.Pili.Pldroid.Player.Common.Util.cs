using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Pili.Pldroid.Player.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.pili.pldroid.player.common']/class[@name='Util']"
	[global::Android.Runtime.Register ("com/pili/pldroid/player/common/Util", DoNotGenerateAcw=true)]
	public sealed partial class Util : global::Java.Lang.Object {


		static IntPtr SDK_INT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player.common']/class[@name='Util']/field[@name='SDK_INT']"
		[Register ("SDK_INT")]
		public static int SdkInt {
			get {
				if (SDK_INT_jfieldId == IntPtr.Zero)
					SDK_INT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SDK_INT", "I");
				return JNIEnv.GetStaticIntField (class_ref, SDK_INT_jfieldId);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/pili/pldroid/player/common/Util", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Util); }
		}

		internal Util (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.pili.pldroid.player.common']/class[@name='Util']/constructor[@name='Util' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Util ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Util)) {
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

		static IntPtr id_getDisplayDefaultRotation_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.common']/class[@name='Util']/method[@name='getDisplayDefaultRotation' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDisplayDefaultRotation", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetDisplayDefaultRotation (global::Android.Content.Context p0)
		{
			if (id_getDisplayDefaultRotation_Landroid_content_Context_ == IntPtr.Zero)
				id_getDisplayDefaultRotation_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getDisplayDefaultRotation", "(Landroid/content/Context;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getDisplayDefaultRotation_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getPathScheme_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.common']/class[@name='Util']/method[@name='getPathScheme' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getPathScheme", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetPathScheme (string p0)
		{
			if (id_getPathScheme_Ljava_lang_String_ == IntPtr.Zero)
				id_getPathScheme_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getPathScheme", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPathScheme_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getResolution_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.common']/class[@name='Util']/method[@name='getResolution' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getResolution", "(Landroid/content/Context;)Landroid/util/Pair;", "")]
		public static unsafe global::Android.Util.Pair GetResolution (global::Android.Content.Context p0)
		{
			if (id_getResolution_Landroid_content_Context_ == IntPtr.Zero)
				id_getResolution_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getResolution", "(Landroid/content/Context;)Landroid/util/Pair;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Util.Pair __ret = global::Java.Lang.Object.GetObject<global::Android.Util.Pair> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getResolution_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getUserAgent_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.common']/class[@name='Util']/method[@name='getUserAgent' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getUserAgent", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetUserAgent (global::Android.Content.Context p0, string p1)
		{
			if (id_getUserAgent_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getUserAgent_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getUserAgent", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUserAgent_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_isLiveStreaming_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.common']/class[@name='Util']/method[@name='isLiveStreaming' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("isLiveStreaming", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsLiveStreaming (string p0)
		{
			if (id_isLiveStreaming_Ljava_lang_String_ == IntPtr.Zero)
				id_isLiveStreaming_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isLiveStreaming", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isLiveStreaming_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_isNetworkConnected_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.common']/class[@name='Util']/method[@name='isNetworkConnected' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isNetworkConnected", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsNetworkConnected (global::Android.Content.Context p0)
		{
			if (id_isNetworkConnected_Landroid_content_Context_ == IntPtr.Zero)
				id_isNetworkConnected_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isNetworkConnected", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNetworkConnected_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isUrlLocalFile_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.common']/class[@name='Util']/method[@name='isUrlLocalFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isUrlLocalFile", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsUrlLocalFile (string p0)
		{
			if (id_isUrlLocalFile_Ljava_lang_String_ == IntPtr.Zero)
				id_isUrlLocalFile_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isUrlLocalFile", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isUrlLocalFile_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
