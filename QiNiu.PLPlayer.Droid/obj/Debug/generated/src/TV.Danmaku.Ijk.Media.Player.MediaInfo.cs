using System;
using System.Collections.Generic;
using Android.Runtime;

namespace TV.Danmaku.Ijk.Media.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaInfo']"
	[global::Android.Runtime.Register ("tv/danmaku/ijk/media/player/MediaInfo", DoNotGenerateAcw=true)]
	public partial class MediaInfo : global::Java.Lang.Object {


		static IntPtr mAudioDecoder_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaInfo']/field[@name='mAudioDecoder']"
		[Register ("mAudioDecoder")]
		public string MAudioDecoder {
			get {
				if (mAudioDecoder_jfieldId == IntPtr.Zero)
					mAudioDecoder_jfieldId = JNIEnv.GetFieldID (class_ref, "mAudioDecoder", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mAudioDecoder_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mAudioDecoder_jfieldId == IntPtr.Zero)
					mAudioDecoder_jfieldId = JNIEnv.GetFieldID (class_ref, "mAudioDecoder", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mAudioDecoder_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mAudioDecoderImpl_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaInfo']/field[@name='mAudioDecoderImpl']"
		[Register ("mAudioDecoderImpl")]
		public string MAudioDecoderImpl {
			get {
				if (mAudioDecoderImpl_jfieldId == IntPtr.Zero)
					mAudioDecoderImpl_jfieldId = JNIEnv.GetFieldID (class_ref, "mAudioDecoderImpl", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mAudioDecoderImpl_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mAudioDecoderImpl_jfieldId == IntPtr.Zero)
					mAudioDecoderImpl_jfieldId = JNIEnv.GetFieldID (class_ref, "mAudioDecoderImpl", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mAudioDecoderImpl_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mMediaPlayerName_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaInfo']/field[@name='mMediaPlayerName']"
		[Register ("mMediaPlayerName")]
		public string MMediaPlayerName {
			get {
				if (mMediaPlayerName_jfieldId == IntPtr.Zero)
					mMediaPlayerName_jfieldId = JNIEnv.GetFieldID (class_ref, "mMediaPlayerName", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mMediaPlayerName_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMediaPlayerName_jfieldId == IntPtr.Zero)
					mMediaPlayerName_jfieldId = JNIEnv.GetFieldID (class_ref, "mMediaPlayerName", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMediaPlayerName_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mMeta_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaInfo']/field[@name='mMeta']"
		[Register ("mMeta")]
		public global::TV.Danmaku.Ijk.Media.Player.IjkMediaMeta MMeta {
			get {
				if (mMeta_jfieldId == IntPtr.Zero)
					mMeta_jfieldId = JNIEnv.GetFieldID (class_ref, "mMeta", "Ltv/danmaku/ijk/media/player/IjkMediaMeta;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mMeta_jfieldId);
				return global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IjkMediaMeta> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMeta_jfieldId == IntPtr.Zero)
					mMeta_jfieldId = JNIEnv.GetFieldID (class_ref, "mMeta", "Ltv/danmaku/ijk/media/player/IjkMediaMeta;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMeta_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mVideoDecoder_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaInfo']/field[@name='mVideoDecoder']"
		[Register ("mVideoDecoder")]
		public string MVideoDecoder {
			get {
				if (mVideoDecoder_jfieldId == IntPtr.Zero)
					mVideoDecoder_jfieldId = JNIEnv.GetFieldID (class_ref, "mVideoDecoder", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mVideoDecoder_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mVideoDecoder_jfieldId == IntPtr.Zero)
					mVideoDecoder_jfieldId = JNIEnv.GetFieldID (class_ref, "mVideoDecoder", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mVideoDecoder_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mVideoDecoderImpl_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaInfo']/field[@name='mVideoDecoderImpl']"
		[Register ("mVideoDecoderImpl")]
		public string MVideoDecoderImpl {
			get {
				if (mVideoDecoderImpl_jfieldId == IntPtr.Zero)
					mVideoDecoderImpl_jfieldId = JNIEnv.GetFieldID (class_ref, "mVideoDecoderImpl", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mVideoDecoderImpl_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mVideoDecoderImpl_jfieldId == IntPtr.Zero)
					mVideoDecoderImpl_jfieldId = JNIEnv.GetFieldID (class_ref, "mVideoDecoderImpl", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mVideoDecoderImpl_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("tv/danmaku/ijk/media/player/MediaInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MediaInfo); }
		}

		protected MediaInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaInfo']/constructor[@name='MediaInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MediaInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MediaInfo)) {
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
