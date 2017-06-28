using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Pili.Pldroid.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PlayerState']"
	[global::Android.Runtime.Register ("com/pili/pldroid/player/PlayerState", DoNotGenerateAcw=true)]
	public sealed partial class PlayerState : global::Java.Lang.Enum {


		static IntPtr BUFFERING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PlayerState']/field[@name='BUFFERING']"
		[Register ("BUFFERING")]
		public static global::Com.Pili.Pldroid.Player.PlayerState Buffering {
			get {
				if (BUFFERING_jfieldId == IntPtr.Zero)
					BUFFERING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BUFFERING", "Lcom/pili/pldroid/player/PlayerState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BUFFERING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PlayerState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr COMPLETED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PlayerState']/field[@name='COMPLETED']"
		[Register ("COMPLETED")]
		public static global::Com.Pili.Pldroid.Player.PlayerState Completed {
			get {
				if (COMPLETED_jfieldId == IntPtr.Zero)
					COMPLETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMPLETED", "Lcom/pili/pldroid/player/PlayerState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMPLETED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PlayerState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PlayerState']/field[@name='ERROR']"
		[Register ("ERROR")]
		public static global::Com.Pili.Pldroid.Player.PlayerState Error {
			get {
				if (ERROR_jfieldId == IntPtr.Zero)
					ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR", "Lcom/pili/pldroid/player/PlayerState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PlayerState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr IDLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PlayerState']/field[@name='IDLE']"
		[Register ("IDLE")]
		public static global::Com.Pili.Pldroid.Player.PlayerState Idle {
			get {
				if (IDLE_jfieldId == IntPtr.Zero)
					IDLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IDLE", "Lcom/pili/pldroid/player/PlayerState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IDLE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PlayerState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PAUSED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PlayerState']/field[@name='PAUSED']"
		[Register ("PAUSED")]
		public static global::Com.Pili.Pldroid.Player.PlayerState Paused {
			get {
				if (PAUSED_jfieldId == IntPtr.Zero)
					PAUSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PAUSED", "Lcom/pili/pldroid/player/PlayerState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PAUSED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PlayerState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PLAYING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PlayerState']/field[@name='PLAYING']"
		[Register ("PLAYING")]
		public static global::Com.Pili.Pldroid.Player.PlayerState Playing {
			get {
				if (PLAYING_jfieldId == IntPtr.Zero)
					PLAYING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLAYING", "Lcom/pili/pldroid/player/PlayerState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PLAYING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PlayerState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PREPARED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PlayerState']/field[@name='PREPARED']"
		[Register ("PREPARED")]
		public static global::Com.Pili.Pldroid.Player.PlayerState Prepared {
			get {
				if (PREPARED_jfieldId == IntPtr.Zero)
					PREPARED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PREPARED", "Lcom/pili/pldroid/player/PlayerState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PREPARED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PlayerState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PREPARING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PlayerState']/field[@name='PREPARING']"
		[Register ("PREPARING")]
		public static global::Com.Pili.Pldroid.Player.PlayerState Preparing {
			get {
				if (PREPARING_jfieldId == IntPtr.Zero)
					PREPARING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PREPARING", "Lcom/pili/pldroid/player/PlayerState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PREPARING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PlayerState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/pili/pldroid/player/PlayerState", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PlayerState); }
		}

		internal PlayerState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PlayerState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/pili/pldroid/player/PlayerState;", "")]
		public static unsafe global::Com.Pili.Pldroid.Player.PlayerState ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/pili/pldroid/player/PlayerState;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Pili.Pldroid.Player.PlayerState __ret = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PlayerState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PlayerState']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/pili/pldroid/player/PlayerState;", "")]
		public static unsafe global::Com.Pili.Pldroid.Player.PlayerState[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/pili/pldroid/player/PlayerState;");
			try {
				return (global::Com.Pili.Pldroid.Player.PlayerState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Pili.Pldroid.Player.PlayerState));
			} finally {
			}
		}

	}
}
