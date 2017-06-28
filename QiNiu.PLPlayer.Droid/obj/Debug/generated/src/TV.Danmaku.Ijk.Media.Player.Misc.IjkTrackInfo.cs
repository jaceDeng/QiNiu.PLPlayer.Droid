using System;
using System.Collections.Generic;
using Android.Runtime;

namespace TV.Danmaku.Ijk.Media.Player.Misc {

	// Metadata.xml XPath class reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/class[@name='IjkTrackInfo']"
	[global::Android.Runtime.Register ("tv/danmaku/ijk/media/player/misc/IjkTrackInfo", DoNotGenerateAcw=true)]
	public partial class IjkTrackInfo : global::Java.Lang.Object, global::TV.Danmaku.Ijk.Media.Player.Misc.ITrackInfo {


		public static class InterfaceConsts {

			// The following are fields from: tv.danmaku.ijk.media.player.misc.ITrackInfo

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/interface[@name='ITrackInfo']/field[@name='MEDIA_TRACK_TYPE_AUDIO']"
			[Register ("MEDIA_TRACK_TYPE_AUDIO")]
			public const int MediaTrackTypeAudio = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/interface[@name='ITrackInfo']/field[@name='MEDIA_TRACK_TYPE_METADATA']"
			[Register ("MEDIA_TRACK_TYPE_METADATA")]
			public const int MediaTrackTypeMetadata = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/interface[@name='ITrackInfo']/field[@name='MEDIA_TRACK_TYPE_SUBTITLE']"
			[Register ("MEDIA_TRACK_TYPE_SUBTITLE")]
			public const int MediaTrackTypeSubtitle = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/interface[@name='ITrackInfo']/field[@name='MEDIA_TRACK_TYPE_TIMEDTEXT']"
			[Register ("MEDIA_TRACK_TYPE_TIMEDTEXT")]
			public const int MediaTrackTypeTimedtext = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/interface[@name='ITrackInfo']/field[@name='MEDIA_TRACK_TYPE_UNKNOWN']"
			[Register ("MEDIA_TRACK_TYPE_UNKNOWN")]
			public const int MediaTrackTypeUnknown = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/interface[@name='ITrackInfo']/field[@name='MEDIA_TRACK_TYPE_VIDEO']"
			[Register ("MEDIA_TRACK_TYPE_VIDEO")]
			public const int MediaTrackTypeVideo = (int) 1;
		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("tv/danmaku/ijk/media/player/misc/IjkTrackInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IjkTrackInfo); }
		}

		protected IjkTrackInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ltv_danmaku_ijk_media_player_IjkMediaMeta_IjkStreamMeta_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/class[@name='IjkTrackInfo']/constructor[@name='IjkTrackInfo' and count(parameter)=1 and parameter[1][@type='tv.danmaku.ijk.media.player.IjkMediaMeta.IjkStreamMeta']]"
		[Register (".ctor", "(Ltv/danmaku/ijk/media/player/IjkMediaMeta$IjkStreamMeta;)V", "")]
		public unsafe IjkTrackInfo (global::TV.Danmaku.Ijk.Media.Player.IjkMediaMeta.IjkStreamMeta p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (IjkTrackInfo)) {
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

		static Delegate cb_getFormat;
#pragma warning disable 0169
		static Delegate GetGetFormatHandler ()
		{
			if (cb_getFormat == null)
				cb_getFormat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFormat);
			return cb_getFormat;
		}

		static IntPtr n_GetFormat (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.Misc.IjkTrackInfo __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.Misc.IjkTrackInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Format);
		}
#pragma warning restore 0169

		static IntPtr id_getFormat;
		public virtual unsafe global::TV.Danmaku.Ijk.Media.Player.Misc.IMediaFormat Format {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/class[@name='IjkTrackInfo']/method[@name='getFormat' and count(parameter)=0]"
			[Register ("getFormat", "()Ltv/danmaku/ijk/media/player/misc/IMediaFormat;", "GetGetFormatHandler")]
			get {
				if (id_getFormat == IntPtr.Zero)
					id_getFormat = JNIEnv.GetMethodID (class_ref, "getFormat", "()Ltv/danmaku/ijk/media/player/misc/IMediaFormat;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.Misc.IMediaFormat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFormat), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.Misc.IMediaFormat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFormat", "()Ltv/danmaku/ijk/media/player/misc/IMediaFormat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getInfoInline;
#pragma warning disable 0169
		static Delegate GetGetInfoInlineHandler ()
		{
			if (cb_getInfoInline == null)
				cb_getInfoInline = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInfoInline);
			return cb_getInfoInline;
		}

		static IntPtr n_GetInfoInline (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.Misc.IjkTrackInfo __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.Misc.IjkTrackInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.InfoInline);
		}
#pragma warning restore 0169

		static IntPtr id_getInfoInline;
		public virtual unsafe string InfoInline {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/class[@name='IjkTrackInfo']/method[@name='getInfoInline' and count(parameter)=0]"
			[Register ("getInfoInline", "()Ljava/lang/String;", "GetGetInfoInlineHandler")]
			get {
				if (id_getInfoInline == IntPtr.Zero)
					id_getInfoInline = JNIEnv.GetMethodID (class_ref, "getInfoInline", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInfoInline), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInfoInline", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLanguage;
#pragma warning disable 0169
		static Delegate GetGetLanguageHandler ()
		{
			if (cb_getLanguage == null)
				cb_getLanguage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLanguage);
			return cb_getLanguage;
		}

		static IntPtr n_GetLanguage (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.Misc.IjkTrackInfo __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.Misc.IjkTrackInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Language);
		}
#pragma warning restore 0169

		static IntPtr id_getLanguage;
		public virtual unsafe string Language {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/class[@name='IjkTrackInfo']/method[@name='getLanguage' and count(parameter)=0]"
			[Register ("getLanguage", "()Ljava/lang/String;", "GetGetLanguageHandler")]
			get {
				if (id_getLanguage == IntPtr.Zero)
					id_getLanguage = JNIEnv.GetMethodID (class_ref, "getLanguage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLanguage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLanguage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTrackType;
#pragma warning disable 0169
		static Delegate GetGetTrackTypeHandler ()
		{
			if (cb_getTrackType == null)
				cb_getTrackType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTrackType);
			return cb_getTrackType;
		}

		static int n_GetTrackType (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.Misc.IjkTrackInfo __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.Misc.IjkTrackInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TrackType;
		}
#pragma warning restore 0169

		static Delegate cb_setTrackType_I;
#pragma warning disable 0169
		static Delegate GetSetTrackType_IHandler ()
		{
			if (cb_setTrackType_I == null)
				cb_setTrackType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTrackType_I);
			return cb_setTrackType_I;
		}

		static void n_SetTrackType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.Misc.IjkTrackInfo __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.Misc.IjkTrackInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TrackType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTrackType;
		static IntPtr id_setTrackType_I;
		public virtual unsafe int TrackType {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/class[@name='IjkTrackInfo']/method[@name='getTrackType' and count(parameter)=0]"
			[Register ("getTrackType", "()I", "GetGetTrackTypeHandler")]
			get {
				if (id_getTrackType == IntPtr.Zero)
					id_getTrackType = JNIEnv.GetMethodID (class_ref, "getTrackType", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTrackType);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrackType", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/class[@name='IjkTrackInfo']/method[@name='setTrackType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTrackType", "(I)V", "GetSetTrackType_IHandler")]
			set {
				if (id_setTrackType_I == IntPtr.Zero)
					id_setTrackType_I = JNIEnv.GetMethodID (class_ref, "setTrackType", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTrackType_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTrackType", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_setMediaMeta_Ltv_danmaku_ijk_media_player_IjkMediaMeta_IjkStreamMeta_;
#pragma warning disable 0169
		static Delegate GetSetMediaMeta_Ltv_danmaku_ijk_media_player_IjkMediaMeta_IjkStreamMeta_Handler ()
		{
			if (cb_setMediaMeta_Ltv_danmaku_ijk_media_player_IjkMediaMeta_IjkStreamMeta_ == null)
				cb_setMediaMeta_Ltv_danmaku_ijk_media_player_IjkMediaMeta_IjkStreamMeta_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMediaMeta_Ltv_danmaku_ijk_media_player_IjkMediaMeta_IjkStreamMeta_);
			return cb_setMediaMeta_Ltv_danmaku_ijk_media_player_IjkMediaMeta_IjkStreamMeta_;
		}

		static void n_SetMediaMeta_Ltv_danmaku_ijk_media_player_IjkMediaMeta_IjkStreamMeta_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.Misc.IjkTrackInfo __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.Misc.IjkTrackInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::TV.Danmaku.Ijk.Media.Player.IjkMediaMeta.IjkStreamMeta p0 = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IjkMediaMeta.IjkStreamMeta> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMediaMeta (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMediaMeta_Ltv_danmaku_ijk_media_player_IjkMediaMeta_IjkStreamMeta_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/class[@name='IjkTrackInfo']/method[@name='setMediaMeta' and count(parameter)=1 and parameter[1][@type='tv.danmaku.ijk.media.player.IjkMediaMeta.IjkStreamMeta']]"
		[Register ("setMediaMeta", "(Ltv/danmaku/ijk/media/player/IjkMediaMeta$IjkStreamMeta;)V", "GetSetMediaMeta_Ltv_danmaku_ijk_media_player_IjkMediaMeta_IjkStreamMeta_Handler")]
		public virtual unsafe void SetMediaMeta (global::TV.Danmaku.Ijk.Media.Player.IjkMediaMeta.IjkStreamMeta p0)
		{
			if (id_setMediaMeta_Ltv_danmaku_ijk_media_player_IjkMediaMeta_IjkStreamMeta_ == IntPtr.Zero)
				id_setMediaMeta_Ltv_danmaku_ijk_media_player_IjkMediaMeta_IjkStreamMeta_ = JNIEnv.GetMethodID (class_ref, "setMediaMeta", "(Ltv/danmaku/ijk/media/player/IjkMediaMeta$IjkStreamMeta;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMediaMeta_Ltv_danmaku_ijk_media_player_IjkMediaMeta_IjkStreamMeta_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMediaMeta", "(Ltv/danmaku/ijk/media/player/IjkMediaMeta$IjkStreamMeta;)V"), __args);
			} finally {
			}
		}

	}
}
