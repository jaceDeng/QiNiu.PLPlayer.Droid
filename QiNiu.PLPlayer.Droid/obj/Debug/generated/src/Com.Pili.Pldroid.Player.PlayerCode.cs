using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Pili.Pldroid.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PlayerCode']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/pili/pldroid/player/PlayerCode", DoNotGenerateAcw=true)]
	public partial class PlayerCode : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PlayerCode']/field[@name='EXTRA_CODE_404_NOT_FOUND']"
		[Register ("EXTRA_CODE_404_NOT_FOUND")]
		public const int ExtraCode404NotFound = (int) -875574520;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PlayerCode']/field[@name='EXTRA_CODE_CONNECTION_REFUSED']"
		[Register ("EXTRA_CODE_CONNECTION_REFUSED")]
		public const int ExtraCodeConnectionRefused = (int) -111;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PlayerCode']/field[@name='EXTRA_CODE_CONNECTION_TIMEOUT']"
		[Register ("EXTRA_CODE_CONNECTION_TIMEOUT")]
		public const int ExtraCodeConnectionTimeout = (int) -110;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PlayerCode']/field[@name='EXTRA_CODE_EMPTY_PLAYLIST']"
		[Register ("EXTRA_CODE_EMPTY_PLAYLIST")]
		public const int ExtraCodeEmptyPlaylist = (int) -541478725;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PlayerCode']/field[@name='EXTRA_CODE_EOF']"
		[Register ("EXTRA_CODE_EOF")]
		public const int ExtraCodeEof = (int) -541478725;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PlayerCode']/field[@name='EXTRA_CODE_INVALID_URI']"
		[Register ("EXTRA_CODE_INVALID_URI")]
		public const int ExtraCodeInvalidUri = (int) -2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PlayerCode']/field[@name='EXTRA_CODE_IO_ERROR']"
		[Register ("EXTRA_CODE_IO_ERROR")]
		public const int ExtraCodeIoError = (int) -5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PlayerCode']/field[@name='EXTRA_CODE_STREAM_DISCONNECTED']"
		[Register ("EXTRA_CODE_STREAM_DISCONNECTED")]
		public const int ExtraCodeStreamDisconnected = (int) -11;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/pili/pldroid/player/PlayerCode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PlayerCode); }
		}

		protected PlayerCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PlayerCode']/constructor[@name='PlayerCode' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PlayerCode ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PlayerCode)) {
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
