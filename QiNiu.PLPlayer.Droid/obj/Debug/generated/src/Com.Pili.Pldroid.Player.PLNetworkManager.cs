using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Pili.Pldroid.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLNetworkManager']"
	[global::Android.Runtime.Register ("com/pili/pldroid/player/PLNetworkManager", DoNotGenerateAcw=true)]
	public sealed partial class PLNetworkManager : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/pili/pldroid/player/PLNetworkManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PLNetworkManager); }
		}

		internal PLNetworkManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Pili.Pldroid.Player.PLNetworkManager Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLNetworkManager']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/pili/pldroid/player/PLNetworkManager;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/pili/pldroid/player/PLNetworkManager;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLNetworkManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_setDnsCacheUpdateInterval_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLNetworkManager']/method[@name='setDnsCacheUpdateInterval' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDnsCacheUpdateInterval", "(I)V", "")]
		public unsafe void SetDnsCacheUpdateInterval (int p0)
		{
			if (id_setDnsCacheUpdateInterval_I == IntPtr.Zero)
				id_setDnsCacheUpdateInterval_I = JNIEnv.GetMethodID (class_ref, "setDnsCacheUpdateInterval", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDnsCacheUpdateInterval_I, __args);
			} finally {
			}
		}

		static IntPtr id_setDnsServer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLNetworkManager']/method[@name='setDnsServer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDnsServer", "(Ljava/lang/String;)V", "")]
		public unsafe void SetDnsServer (string p0)
		{
			if (id_setDnsServer_Ljava_lang_String_ == IntPtr.Zero)
				id_setDnsServer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDnsServer", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDnsServer_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_startDnsCacheService_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLNetworkManager']/method[@name='startDnsCacheService' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("startDnsCacheService", "(Landroid/content/Context;)V", "")]
		public unsafe void StartDnsCacheService (global::Android.Content.Context p0)
		{
			if (id_startDnsCacheService_Landroid_content_Context_ == IntPtr.Zero)
				id_startDnsCacheService_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "startDnsCacheService", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startDnsCacheService_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_startDnsCacheService_Landroid_content_Context_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLNetworkManager']/method[@name='startDnsCacheService' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String[]']]"
		[Register ("startDnsCacheService", "(Landroid/content/Context;[Ljava/lang/String;)V", "")]
		public unsafe void StartDnsCacheService (global::Android.Content.Context p0, string[] p1)
		{
			if (id_startDnsCacheService_Landroid_content_Context_arrayLjava_lang_String_ == IntPtr.Zero)
				id_startDnsCacheService_Landroid_content_Context_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "startDnsCacheService", "(Landroid/content/Context;[Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startDnsCacheService_Landroid_content_Context_arrayLjava_lang_String_, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_stopDnsCacheService_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLNetworkManager']/method[@name='stopDnsCacheService' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("stopDnsCacheService", "(Landroid/content/Context;)V", "")]
		public unsafe void StopDnsCacheService (global::Android.Content.Context p0)
		{
			if (id_stopDnsCacheService_Landroid_content_Context_ == IntPtr.Zero)
				id_stopDnsCacheService_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "stopDnsCacheService", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopDnsCacheService_Landroid_content_Context_, __args);
			} finally {
			}
		}

	}
}
