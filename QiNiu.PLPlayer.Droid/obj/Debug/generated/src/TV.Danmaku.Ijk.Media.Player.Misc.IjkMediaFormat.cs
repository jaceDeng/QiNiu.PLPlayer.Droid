using System;
using System.Collections.Generic;
using Android.Runtime;

namespace TV.Danmaku.Ijk.Media.Player.Misc {

	// Metadata.xml XPath class reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/class[@name='IjkMediaFormat']"
	[global::Android.Runtime.Register ("tv/danmaku/ijk/media/player/misc/IjkMediaFormat", DoNotGenerateAcw=true)]
	public partial class IjkMediaFormat : global::Java.Lang.Object, global::TV.Danmaku.Ijk.Media.Player.Misc.IMediaFormat {


		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/class[@name='IjkMediaFormat']/field[@name='CODEC_NAME_H264']"
		[Register ("CODEC_NAME_H264")]
		public const string CodecNameH264 = (string) "h264";

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/class[@name='IjkMediaFormat']/field[@name='KEY_IJK_BIT_RATE_UI']"
		[Register ("KEY_IJK_BIT_RATE_UI")]
		public const string KeyIjkBitRateUi = (string) "ijk-bit-rate-ui";

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/class[@name='IjkMediaFormat']/field[@name='KEY_IJK_CHANNEL_UI']"
		[Register ("KEY_IJK_CHANNEL_UI")]
		public const string KeyIjkChannelUi = (string) "ijk-channel-ui";

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/class[@name='IjkMediaFormat']/field[@name='KEY_IJK_CODEC_LONG_NAME_UI']"
		[Register ("KEY_IJK_CODEC_LONG_NAME_UI")]
		public const string KeyIjkCodecLongNameUi = (string) "ijk-codec-long-name-ui";

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/class[@name='IjkMediaFormat']/field[@name='KEY_IJK_CODEC_NAME_UI']"
		[Register ("KEY_IJK_CODEC_NAME_UI")]
		public const string KeyIjkCodecNameUi = (string) "ijk-codec-name-ui";

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/class[@name='IjkMediaFormat']/field[@name='KEY_IJK_CODEC_PIXEL_FORMAT_UI']"
		[Register ("KEY_IJK_CODEC_PIXEL_FORMAT_UI")]
		public const string KeyIjkCodecPixelFormatUi = (string) "ijk-pixel-format-ui";

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/class[@name='IjkMediaFormat']/field[@name='KEY_IJK_CODEC_PROFILE_LEVEL_UI']"
		[Register ("KEY_IJK_CODEC_PROFILE_LEVEL_UI")]
		public const string KeyIjkCodecProfileLevelUi = (string) "ijk-profile-level-ui";

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/class[@name='IjkMediaFormat']/field[@name='KEY_IJK_FRAME_RATE_UI']"
		[Register ("KEY_IJK_FRAME_RATE_UI")]
		public const string KeyIjkFrameRateUi = (string) "ijk-frame-rate-ui";

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/class[@name='IjkMediaFormat']/field[@name='KEY_IJK_RESOLUTION_UI']"
		[Register ("KEY_IJK_RESOLUTION_UI")]
		public const string KeyIjkResolutionUi = (string) "ijk-resolution-ui";

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/class[@name='IjkMediaFormat']/field[@name='KEY_IJK_SAMPLE_RATE_UI']"
		[Register ("KEY_IJK_SAMPLE_RATE_UI")]
		public const string KeyIjkSampleRateUi = (string) "ijk-sample-rate-ui";

		static IntPtr mMediaFormat_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/class[@name='IjkMediaFormat']/field[@name='mMediaFormat']"
		[Register ("mMediaFormat")]
		public global::TV.Danmaku.Ijk.Media.Player.IjkMediaMeta.IjkStreamMeta MMediaFormat {
			get {
				if (mMediaFormat_jfieldId == IntPtr.Zero)
					mMediaFormat_jfieldId = JNIEnv.GetFieldID (class_ref, "mMediaFormat", "Ltv/danmaku/ijk/media/player/IjkMediaMeta$IjkStreamMeta;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mMediaFormat_jfieldId);
				return global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IjkMediaMeta.IjkStreamMeta> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMediaFormat_jfieldId == IntPtr.Zero)
					mMediaFormat_jfieldId = JNIEnv.GetFieldID (class_ref, "mMediaFormat", "Ltv/danmaku/ijk/media/player/IjkMediaMeta$IjkStreamMeta;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMediaFormat_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public static class InterfaceConsts {

			// The following are fields from: tv.danmaku.ijk.media.player.misc.IMediaFormat

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

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("tv/danmaku/ijk/media/player/misc/IjkMediaFormat", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IjkMediaFormat); }
		}

		protected IjkMediaFormat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ltv_danmaku_ijk_media_player_IjkMediaMeta_IjkStreamMeta_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/class[@name='IjkMediaFormat']/constructor[@name='IjkMediaFormat' and count(parameter)=1 and parameter[1][@type='tv.danmaku.ijk.media.player.IjkMediaMeta.IjkStreamMeta']]"
		[Register (".ctor", "(Ltv/danmaku/ijk/media/player/IjkMediaMeta$IjkStreamMeta;)V", "")]
		public unsafe IjkMediaFormat (global::TV.Danmaku.Ijk.Media.Player.IjkMediaMeta.IjkStreamMeta p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (IjkMediaFormat)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ltv/danmaku/ijk/media/player/IjkMediaMeta$IjkStreamMeta;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ltv/danmaku/ijk/media/player/IjkMediaMeta$IjkStreamMeta;)V", __args);
					return;
				}

				if (id_ctor_Ltv_danmaku_ijk_media_player_IjkMediaMeta_IjkStreamMeta_ == IntPtr.Zero)
					id_ctor_Ltv_danmaku_ijk_media_player_IjkMediaMeta_IjkStreamMeta_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ltv/danmaku/ijk/media/player/IjkMediaMeta$IjkStreamMeta;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ltv_danmaku_ijk_media_player_IjkMediaMeta_IjkStreamMeta_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ltv_danmaku_ijk_media_player_IjkMediaMeta_IjkStreamMeta_, __args);
			} finally {
			}
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
			global::TV.Danmaku.Ijk.Media.Player.Misc.IjkMediaFormat __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.Misc.IjkMediaFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetInteger (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getInteger_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/class[@name='IjkMediaFormat']/method[@name='getInteger' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getInteger", "(Ljava/lang/String;)I", "GetGetInteger_Ljava_lang_String_Handler")]
		public virtual unsafe int GetInteger (string p0)
		{
			if (id_getInteger_Ljava_lang_String_ == IntPtr.Zero)
				id_getInteger_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getInteger", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getInteger_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInteger", "(Ljava/lang/String;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
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
			global::TV.Danmaku.Ijk.Media.Player.Misc.IjkMediaFormat __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.Misc.IjkMediaFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetString (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/class[@name='IjkMediaFormat']/method[@name='getString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getString", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetString_Ljava_lang_String_Handler")]
		public virtual unsafe string GetString (string p0)
		{
			if (id_getString_Ljava_lang_String_ == IntPtr.Zero)
				id_getString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getString", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
