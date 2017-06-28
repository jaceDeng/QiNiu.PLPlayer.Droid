using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Pili.Pldroid.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='AVOptions']"
	[global::Android.Runtime.Register ("com/pili/pldroid/player/AVOptions", DoNotGenerateAcw=true)]
	public partial class AVOptions : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='AVOptions']/field[@name='KEY_AUDIO_DATA_CB_ENABLE']"
		[Register ("KEY_AUDIO_DATA_CB_ENABLE")]
		public const string KeyAudioDataCbEnable = (string) "audio-data-cb-enable";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='AVOptions']/field[@name='KEY_AUDIO_RENDER_MSG']"
		[Register ("KEY_AUDIO_RENDER_MSG")]
		public const string KeyAudioRenderMsg = (string) "audio-render-msg-cb";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='AVOptions']/field[@name='KEY_BUFFER_TIME']"
		[Register ("KEY_BUFFER_TIME")]
		public const string KeyBufferTime = (string) "rtmp_buffer";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='AVOptions']/field[@name='KEY_CACHE_BUFFER_DURATION']"
		[Register ("KEY_CACHE_BUFFER_DURATION")]
		public const string KeyCacheBufferDuration = (string) "cache-buffer-duration";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='AVOptions']/field[@name='KEY_DELAY_OPTIMIZATION']"
		[Register ("KEY_DELAY_OPTIMIZATION")]
		public const string KeyDelayOptimization = (string) "delay-optimization";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='AVOptions']/field[@name='KEY_FFLAGS']"
		[Register ("KEY_FFLAGS")]
		[Obsolete ("deprecated")]
		public const string KeyFflags = (string) "fflags";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='AVOptions']/field[@name='KEY_GET_AV_FRAME_TIMEOUT']"
		[Register ("KEY_GET_AV_FRAME_TIMEOUT")]
		public const string KeyGetAvFrameTimeout = (string) "get-av-frame-timeout";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='AVOptions']/field[@name='KEY_LIVE_STREAMING']"
		[Register ("KEY_LIVE_STREAMING")]
		public const string KeyLiveStreaming = (string) "live-streaming";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='AVOptions']/field[@name='KEY_MAX_CACHE_BUFFER_DURATION']"
		[Register ("KEY_MAX_CACHE_BUFFER_DURATION")]
		public const string KeyMaxCacheBufferDuration = (string) "max-cache-buffer-duration";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='AVOptions']/field[@name='KEY_MEDIACODEC']"
		[Register ("KEY_MEDIACODEC")]
		public const string KeyMediacodec = (string) "mediacodec";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='AVOptions']/field[@name='KEY_PREPARE_TIMEOUT']"
		[Register ("KEY_PREPARE_TIMEOUT")]
		public const string KeyPrepareTimeout = (string) "timeout";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='AVOptions']/field[@name='KEY_PROBESIZE']"
		[Register ("KEY_PROBESIZE")]
		public const string KeyProbesize = (string) "probesize";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='AVOptions']/field[@name='KEY_RECONNECT']"
		[Register ("KEY_RECONNECT")]
		public const string KeyReconnect = (string) "reconnect";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='AVOptions']/field[@name='KEY_RTMP_LIVE']"
		[Register ("KEY_RTMP_LIVE")]
		public const string KeyRtmpLive = (string) "rtmp_live";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='AVOptions']/field[@name='KEY_START_ON_PREPARED']"
		[Register ("KEY_START_ON_PREPARED")]
		public const string KeyStartOnPrepared = (string) "start-on-prepared";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='AVOptions']/field[@name='KEY_VIDEO_DATA_CB_ENABLE']"
		[Register ("KEY_VIDEO_DATA_CB_ENABLE")]
		public const string KeyVideoDataCbEnable = (string) "video-data-cb-enable";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='AVOptions']/field[@name='KEY_VIDEO_DISPLAY_DISABLE']"
		[Register ("KEY_VIDEO_DISPLAY_DISABLE")]
		public const string KeyVideoDisplayDisable = (string) "nodisp";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='AVOptions']/field[@name='KEY_VIDEO_RENDER_MSG']"
		[Register ("KEY_VIDEO_RENDER_MSG")]
		public const string KeyVideoRenderMsg = (string) "video-render-msg-cb";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='AVOptions']/field[@name='MEDIA_CODEC_AUTO']"
		[Register ("MEDIA_CODEC_AUTO")]
		public const int MediaCodecAuto = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='AVOptions']/field[@name='MEDIA_CODEC_HW_DECODE']"
		[Register ("MEDIA_CODEC_HW_DECODE")]
		public const int MediaCodecHwDecode = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='AVOptions']/field[@name='MEDIA_CODEC_SW_DECODE']"
		[Register ("MEDIA_CODEC_SW_DECODE")]
		public const int MediaCodecSwDecode = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='AVOptions']/field[@name='VALUE_FFLAGS_NOBUFFER']"
		[Register ("VALUE_FFLAGS_NOBUFFER")]
		[Obsolete ("deprecated")]
		public const string ValueFflagsNobuffer = (string) "nobuffer";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/pili/pldroid/player/AVOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AVOptions); }
		}

		protected AVOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='AVOptions']/constructor[@name='AVOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AVOptions ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AVOptions)) {
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

		static Delegate cb_getMap;
#pragma warning disable 0169
		static Delegate GetGetMapHandler ()
		{
			if (cb_getMap == null)
				cb_getMap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMap);
			return cb_getMap;
		}

		static IntPtr n_GetMap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Pili.Pldroid.Player.AVOptions __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.AVOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.Map);
		}
#pragma warning restore 0169

		static IntPtr id_getMap;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> Map {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='AVOptions']/method[@name='getMap' and count(parameter)=0]"
			[Register ("getMap", "()Ljava/util/Map;", "GetGetMapHandler")]
			get {
				if (id_getMap == IntPtr.Zero)
					id_getMap = JNIEnv.GetMethodID (class_ref, "getMap", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMap), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMap", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_containsKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='AVOptions']/method[@name='containsKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("containsKey", "(Ljava/lang/String;)Z", "")]
		public unsafe bool ContainsKey (string p0)
		{
			if (id_containsKey_Ljava_lang_String_ == IntPtr.Zero)
				id_containsKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "containsKey", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_containsKey_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getFloat_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='AVOptions']/method[@name='getFloat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFloat", "(Ljava/lang/String;)F", "")]
		public unsafe float GetFloat (string p0)
		{
			if (id_getFloat_Ljava_lang_String_ == IntPtr.Zero)
				id_getFloat_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getFloat", "(Ljava/lang/String;)F");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				float __ret = JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getFloat_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getInteger_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='AVOptions']/method[@name='getInteger' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getInteger", "(Ljava/lang/String;)I", "")]
		public unsafe int GetInteger (string p0)
		{
			if (id_getInteger_Ljava_lang_String_ == IntPtr.Zero)
				id_getInteger_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getInteger", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getInteger_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getInteger_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='AVOptions']/method[@name='getInteger' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getInteger", "(Ljava/lang/String;I)I", "")]
		public unsafe int GetInteger (string p0, int p1)
		{
			if (id_getInteger_Ljava_lang_String_I == IntPtr.Zero)
				id_getInteger_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "getInteger", "(Ljava/lang/String;I)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getInteger_Ljava_lang_String_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getLong_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='AVOptions']/method[@name='getLong' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLong", "(Ljava/lang/String;)J", "")]
		public unsafe long GetLong (string p0)
		{
			if (id_getLong_Ljava_lang_String_ == IntPtr.Zero)
				id_getLong_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLong", "(Ljava/lang/String;)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				long __ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getLong_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='AVOptions']/method[@name='getString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getString", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string GetString (string p0)
		{
			if (id_getString_Ljava_lang_String_ == IntPtr.Zero)
				id_getString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setFloat_Ljava_lang_String_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='AVOptions']/method[@name='setFloat' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float']]"
		[Register ("setFloat", "(Ljava/lang/String;F)V", "")]
		public unsafe void SetFloat (string p0, float p1)
		{
			if (id_setFloat_Ljava_lang_String_F == IntPtr.Zero)
				id_setFloat_Ljava_lang_String_F = JNIEnv.GetMethodID (class_ref, "setFloat", "(Ljava/lang/String;F)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFloat_Ljava_lang_String_F, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setInteger_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='AVOptions']/method[@name='setInteger' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("setInteger", "(Ljava/lang/String;I)V", "")]
		public unsafe void SetInteger (string p0, int p1)
		{
			if (id_setInteger_Ljava_lang_String_I == IntPtr.Zero)
				id_setInteger_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "setInteger", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInteger_Ljava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setLong_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='AVOptions']/method[@name='setLong' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("setLong", "(Ljava/lang/String;J)V", "")]
		public unsafe void SetLong (string p0, long p1)
		{
			if (id_setLong_Ljava_lang_String_J == IntPtr.Zero)
				id_setLong_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "setLong", "(Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLong_Ljava_lang_String_J, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setString_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='AVOptions']/method[@name='setString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setString", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void SetString (string p0, string p1)
		{
			if (id_setString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setString", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setString_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
