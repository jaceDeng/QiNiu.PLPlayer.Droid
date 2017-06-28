using System;
using System.Collections.Generic;
using Android.Runtime;

namespace TV.Danmaku.Ijk.Media.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaCodecInfo']"
	[global::Android.Runtime.Register ("tv/danmaku/ijk/media/player/IjkMediaCodecInfo", DoNotGenerateAcw=true)]
	public partial class IjkMediaCodecInfo : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaCodecInfo']/field[@name='RANK_ACCEPTABLE']"
		[Register ("RANK_ACCEPTABLE")]
		public const int RankAcceptable = (int) 700;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaCodecInfo']/field[@name='RANK_LAST_CHANCE']"
		[Register ("RANK_LAST_CHANCE")]
		public const int RankLastChance = (int) 600;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaCodecInfo']/field[@name='RANK_MAX']"
		[Register ("RANK_MAX")]
		public const int RankMax = (int) 1000;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaCodecInfo']/field[@name='RANK_NON_STANDARD']"
		[Register ("RANK_NON_STANDARD")]
		public const int RankNonStandard = (int) 100;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaCodecInfo']/field[@name='RANK_NO_SENSE']"
		[Register ("RANK_NO_SENSE")]
		public const int RankNoSense = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaCodecInfo']/field[@name='RANK_SECURE']"
		[Register ("RANK_SECURE")]
		public const int RankSecure = (int) 300;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaCodecInfo']/field[@name='RANK_SOFTWARE']"
		[Register ("RANK_SOFTWARE")]
		public const int RankSoftware = (int) 200;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaCodecInfo']/field[@name='RANK_TESTED']"
		[Register ("RANK_TESTED")]
		public const int RankTested = (int) 800;

		static IntPtr mCodecInfo_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaCodecInfo']/field[@name='mCodecInfo']"
		[Register ("mCodecInfo")]
		public global::Android.Media.MediaCodecInfo MCodecInfo {
			get {
				if (mCodecInfo_jfieldId == IntPtr.Zero)
					mCodecInfo_jfieldId = JNIEnv.GetFieldID (class_ref, "mCodecInfo", "Landroid/media/MediaCodecInfo;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCodecInfo_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Media.MediaCodecInfo> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCodecInfo_jfieldId == IntPtr.Zero)
					mCodecInfo_jfieldId = JNIEnv.GetFieldID (class_ref, "mCodecInfo", "Landroid/media/MediaCodecInfo;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCodecInfo_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mMimeType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaCodecInfo']/field[@name='mMimeType']"
		[Register ("mMimeType")]
		public string MMimeType {
			get {
				if (mMimeType_jfieldId == IntPtr.Zero)
					mMimeType_jfieldId = JNIEnv.GetFieldID (class_ref, "mMimeType", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mMimeType_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMimeType_jfieldId == IntPtr.Zero)
					mMimeType_jfieldId = JNIEnv.GetFieldID (class_ref, "mMimeType", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMimeType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mRank_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaCodecInfo']/field[@name='mRank']"
		[Register ("mRank")]
		public int MRank {
			get {
				if (mRank_jfieldId == IntPtr.Zero)
					mRank_jfieldId = JNIEnv.GetFieldID (class_ref, "mRank", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mRank_jfieldId);
			}
			set {
				if (mRank_jfieldId == IntPtr.Zero)
					mRank_jfieldId = JNIEnv.GetFieldID (class_ref, "mRank", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mRank_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("tv/danmaku/ijk/media/player/IjkMediaCodecInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IjkMediaCodecInfo); }
		}

		protected IjkMediaCodecInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaCodecInfo']/constructor[@name='IjkMediaCodecInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IjkMediaCodecInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (IjkMediaCodecInfo)) {
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

		static Delegate cb_dumpProfileLevels_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDumpProfileLevels_Ljava_lang_String_Handler ()
		{
			if (cb_dumpProfileLevels_Ljava_lang_String_ == null)
				cb_dumpProfileLevels_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DumpProfileLevels_Ljava_lang_String_);
			return cb_dumpProfileLevels_Ljava_lang_String_;
		}

		static void n_DumpProfileLevels_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.IjkMediaCodecInfo __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IjkMediaCodecInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DumpProfileLevels (p0);
		}
#pragma warning restore 0169

		static IntPtr id_dumpProfileLevels_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaCodecInfo']/method[@name='dumpProfileLevels' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("dumpProfileLevels", "(Ljava/lang/String;)V", "GetDumpProfileLevels_Ljava_lang_String_Handler")]
		public virtual unsafe void DumpProfileLevels (string p0)
		{
			if (id_dumpProfileLevels_Ljava_lang_String_ == IntPtr.Zero)
				id_dumpProfileLevels_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "dumpProfileLevels", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dumpProfileLevels_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dumpProfileLevels", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getLevelName_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaCodecInfo']/method[@name='getLevelName' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getLevelName", "(I)Ljava/lang/String;", "")]
		public static unsafe string GetLevelName (int p0)
		{
			if (id_getLevelName_I == IntPtr.Zero)
				id_getLevelName_I = JNIEnv.GetStaticMethodID (class_ref, "getLevelName", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLevelName_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getProfileLevelName_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaCodecInfo']/method[@name='getProfileLevelName' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getProfileLevelName", "(II)Ljava/lang/String;", "")]
		public static unsafe string GetProfileLevelName (int p0, int p1)
		{
			if (id_getProfileLevelName_II == IntPtr.Zero)
				id_getProfileLevelName_II = JNIEnv.GetStaticMethodID (class_ref, "getProfileLevelName", "(II)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getProfileLevelName_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getProfileName_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaCodecInfo']/method[@name='getProfileName' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getProfileName", "(I)Ljava/lang/String;", "")]
		public static unsafe string GetProfileName (int p0)
		{
			if (id_getProfileName_I == IntPtr.Zero)
				id_getProfileName_I = JNIEnv.GetStaticMethodID (class_ref, "getProfileName", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getProfileName_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_setupCandidate_Landroid_media_MediaCodecInfo_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaCodecInfo']/method[@name='setupCandidate' and count(parameter)=2 and parameter[1][@type='android.media.MediaCodecInfo'] and parameter[2][@type='java.lang.String']]"
		[Register ("setupCandidate", "(Landroid/media/MediaCodecInfo;Ljava/lang/String;)Ltv/danmaku/ijk/media/player/IjkMediaCodecInfo;", "")]
		public static unsafe global::TV.Danmaku.Ijk.Media.Player.IjkMediaCodecInfo SetupCandidate (global::Android.Media.MediaCodecInfo p0, string p1)
		{
			if (id_setupCandidate_Landroid_media_MediaCodecInfo_Ljava_lang_String_ == IntPtr.Zero)
				id_setupCandidate_Landroid_media_MediaCodecInfo_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setupCandidate", "(Landroid/media/MediaCodecInfo;Ljava/lang/String;)Ltv/danmaku/ijk/media/player/IjkMediaCodecInfo;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::TV.Danmaku.Ijk.Media.Player.IjkMediaCodecInfo __ret = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IjkMediaCodecInfo> (JNIEnv.CallStaticObjectMethod  (class_ref, id_setupCandidate_Landroid_media_MediaCodecInfo_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
