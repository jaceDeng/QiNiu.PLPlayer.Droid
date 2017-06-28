using System;
using System.Collections.Generic;
using Android.Runtime;

namespace TV.Danmaku.Ijk.Media.Player.Misc {

	[Register ("tv/danmaku/ijk/media/player/misc/ITrackInfo", DoNotGenerateAcw=true)]
	public abstract class TrackInfo : Java.Lang.Object {

		internal TrackInfo ()
		{
		}

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

	[Register ("tv/danmaku/ijk/media/player/misc/ITrackInfo", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'TrackInfo' type. This type will be removed in a future release.")]
	public abstract class TrackInfoConsts : TrackInfo {

		private TrackInfoConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/interface[@name='ITrackInfo']"
	[Register ("tv/danmaku/ijk/media/player/misc/ITrackInfo", "", "TV.Danmaku.Ijk.Media.Player.Misc.ITrackInfoInvoker")]
	public partial interface ITrackInfo : IJavaObject {

		global::TV.Danmaku.Ijk.Media.Player.Misc.IMediaFormat Format {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/interface[@name='ITrackInfo']/method[@name='getFormat' and count(parameter)=0]"
			[Register ("getFormat", "()Ltv/danmaku/ijk/media/player/misc/IMediaFormat;", "GetGetFormatHandler:TV.Danmaku.Ijk.Media.Player.Misc.ITrackInfoInvoker, QiNiu.PLPlayer.Droid")] get;
		}

		string InfoInline {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/interface[@name='ITrackInfo']/method[@name='getInfoInline' and count(parameter)=0]"
			[Register ("getInfoInline", "()Ljava/lang/String;", "GetGetInfoInlineHandler:TV.Danmaku.Ijk.Media.Player.Misc.ITrackInfoInvoker, QiNiu.PLPlayer.Droid")] get;
		}

		string Language {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/interface[@name='ITrackInfo']/method[@name='getLanguage' and count(parameter)=0]"
			[Register ("getLanguage", "()Ljava/lang/String;", "GetGetLanguageHandler:TV.Danmaku.Ijk.Media.Player.Misc.ITrackInfoInvoker, QiNiu.PLPlayer.Droid")] get;
		}

		int TrackType {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/interface[@name='ITrackInfo']/method[@name='getTrackType' and count(parameter)=0]"
			[Register ("getTrackType", "()I", "GetGetTrackTypeHandler:TV.Danmaku.Ijk.Media.Player.Misc.ITrackInfoInvoker, QiNiu.PLPlayer.Droid")] get;
		}

	}

	[global::Android.Runtime.Register ("tv/danmaku/ijk/media/player/misc/ITrackInfo", DoNotGenerateAcw=true)]
	internal class ITrackInfoInvoker : global::Java.Lang.Object, ITrackInfo {

		static IntPtr java_class_ref = JNIEnv.FindClass ("tv/danmaku/ijk/media/player/misc/ITrackInfo");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ITrackInfoInvoker); }
		}

		IntPtr class_ref;

		public static ITrackInfo GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITrackInfo> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "tv.danmaku.ijk.media.player.misc.ITrackInfo"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITrackInfoInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::TV.Danmaku.Ijk.Media.Player.Misc.ITrackInfo __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.Misc.ITrackInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Format);
		}
#pragma warning restore 0169

		IntPtr id_getFormat;
		public unsafe global::TV.Danmaku.Ijk.Media.Player.Misc.IMediaFormat Format {
			get {
				if (id_getFormat == IntPtr.Zero)
					id_getFormat = JNIEnv.GetMethodID (class_ref, "getFormat", "()Ltv/danmaku/ijk/media/player/misc/IMediaFormat;");
				return global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.Misc.IMediaFormat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFormat), JniHandleOwnership.TransferLocalRef);
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
			global::TV.Danmaku.Ijk.Media.Player.Misc.ITrackInfo __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.Misc.ITrackInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.InfoInline);
		}
#pragma warning restore 0169

		IntPtr id_getInfoInline;
		public unsafe string InfoInline {
			get {
				if (id_getInfoInline == IntPtr.Zero)
					id_getInfoInline = JNIEnv.GetMethodID (class_ref, "getInfoInline", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInfoInline), JniHandleOwnership.TransferLocalRef);
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
			global::TV.Danmaku.Ijk.Media.Player.Misc.ITrackInfo __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.Misc.ITrackInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Language);
		}
#pragma warning restore 0169

		IntPtr id_getLanguage;
		public unsafe string Language {
			get {
				if (id_getLanguage == IntPtr.Zero)
					id_getLanguage = JNIEnv.GetMethodID (class_ref, "getLanguage", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLanguage), JniHandleOwnership.TransferLocalRef);
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
			global::TV.Danmaku.Ijk.Media.Player.Misc.ITrackInfo __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.Misc.ITrackInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TrackType;
		}
#pragma warning restore 0169

		IntPtr id_getTrackType;
		public unsafe int TrackType {
			get {
				if (id_getTrackType == IntPtr.Zero)
					id_getTrackType = JNIEnv.GetMethodID (class_ref, "getTrackType", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTrackType);
			}
		}

	}

}
