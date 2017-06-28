using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Pili.Pldroid.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='SharedLibraryNameHelper']"
	[global::Android.Runtime.Register ("com/pili/pldroid/player/SharedLibraryNameHelper", DoNotGenerateAcw=true)]
	public partial class SharedLibraryNameHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/pili/pldroid/player/SharedLibraryNameHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SharedLibraryNameHelper); }
		}

		protected SharedLibraryNameHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Pili.Pldroid.Player.SharedLibraryNameHelper Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='SharedLibraryNameHelper']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/pili/pldroid/player/SharedLibraryNameHelper;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/pili/pldroid/player/SharedLibraryNameHelper;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.SharedLibraryNameHelper> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSharedLibraryName;
#pragma warning disable 0169
		static Delegate GetGetSharedLibraryNameHandler ()
		{
			if (cb_getSharedLibraryName == null)
				cb_getSharedLibraryName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSharedLibraryName);
			return cb_getSharedLibraryName;
		}

		static IntPtr n_GetSharedLibraryName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Pili.Pldroid.Player.SharedLibraryNameHelper __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.SharedLibraryNameHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SharedLibraryName);
		}
#pragma warning restore 0169

		static IntPtr id_getSharedLibraryName;
		public virtual unsafe string SharedLibraryName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='SharedLibraryNameHelper']/method[@name='getSharedLibraryName' and count(parameter)=0]"
			[Register ("getSharedLibraryName", "()Ljava/lang/String;", "GetGetSharedLibraryNameHandler")]
			get {
				if (id_getSharedLibraryName == IntPtr.Zero)
					id_getSharedLibraryName = JNIEnv.GetMethodID (class_ref, "getSharedLibraryName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSharedLibraryName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSharedLibraryName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_A);
			return cb_a;
		}

		static void n_A (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Pili.Pldroid.Player.SharedLibraryNameHelper __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.SharedLibraryNameHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.A ();
		}
#pragma warning restore 0169

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='SharedLibraryNameHelper']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()V", "GetAHandler")]
		public virtual unsafe void A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "()V"));
			} finally {
			}
		}

		static Delegate cb_renameSharedLibrary_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRenameSharedLibrary_Ljava_lang_String_Handler ()
		{
			if (cb_renameSharedLibrary_Ljava_lang_String_ == null)
				cb_renameSharedLibrary_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RenameSharedLibrary_Ljava_lang_String_);
			return cb_renameSharedLibrary_Ljava_lang_String_;
		}

		static void n_RenameSharedLibrary_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Pili.Pldroid.Player.SharedLibraryNameHelper __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.SharedLibraryNameHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RenameSharedLibrary (p0);
		}
#pragma warning restore 0169

		static IntPtr id_renameSharedLibrary_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='SharedLibraryNameHelper']/method[@name='renameSharedLibrary' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("renameSharedLibrary", "(Ljava/lang/String;)V", "GetRenameSharedLibrary_Ljava_lang_String_Handler")]
		public virtual unsafe void RenameSharedLibrary (string p0)
		{
			if (id_renameSharedLibrary_Ljava_lang_String_ == IntPtr.Zero)
				id_renameSharedLibrary_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "renameSharedLibrary", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_renameSharedLibrary_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "renameSharedLibrary", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
