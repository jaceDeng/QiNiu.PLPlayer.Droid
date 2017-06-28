using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Pili.Pldroid.Player.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']"
	[global::Android.Runtime.Register ("com/pili/pldroid/player/widget/PLVideoTextureView", DoNotGenerateAcw=true)]
	public partial class PLVideoTextureView : global::Android.Widget.FrameLayout {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/pili/pldroid/player/widget/PLVideoTextureView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PLVideoTextureView); }
		}

		protected PLVideoTextureView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/constructor[@name='PLVideoTextureView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe PLVideoTextureView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (PLVideoTextureView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/constructor[@name='PLVideoTextureView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe PLVideoTextureView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (PLVideoTextureView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/constructor[@name='PLVideoTextureView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe PLVideoTextureView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (PLVideoTextureView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/constructor[@name='PLVideoTextureView' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", "")]
		public unsafe PLVideoTextureView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2, int p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (PLVideoTextureView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II, __args);
			} finally {
			}
		}

		static Delegate cb_getBufferPercentage;
#pragma warning disable 0169
		static Delegate GetGetBufferPercentageHandler ()
		{
			if (cb_getBufferPercentage == null)
				cb_getBufferPercentage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBufferPercentage);
			return cb_getBufferPercentage;
		}

		static int n_GetBufferPercentage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BufferPercentage;
		}
#pragma warning restore 0169

		static IntPtr id_getBufferPercentage;
		public virtual unsafe int BufferPercentage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='getBufferPercentage' and count(parameter)=0]"
			[Register ("getBufferPercentage", "()I", "GetGetBufferPercentageHandler")]
			get {
				if (id_getBufferPercentage == IntPtr.Zero)
					id_getBufferPercentage = JNIEnv.GetMethodID (class_ref, "getBufferPercentage", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBufferPercentage);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBufferPercentage", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getCurrentPosition;
#pragma warning disable 0169
		static Delegate GetGetCurrentPositionHandler ()
		{
			if (cb_getCurrentPosition == null)
				cb_getCurrentPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetCurrentPosition);
			return cb_getCurrentPosition;
		}

		static long n_GetCurrentPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentPosition;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentPosition;
		public virtual unsafe long CurrentPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='getCurrentPosition' and count(parameter)=0]"
			[Register ("getCurrentPosition", "()J", "GetGetCurrentPositionHandler")]
			get {
				if (id_getCurrentPosition == IntPtr.Zero)
					id_getCurrentPosition = JNIEnv.GetMethodID (class_ref, "getCurrentPosition", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentPosition);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentPosition", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getDisplayAspectRatio;
#pragma warning disable 0169
		static Delegate GetGetDisplayAspectRatioHandler ()
		{
			if (cb_getDisplayAspectRatio == null)
				cb_getDisplayAspectRatio = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDisplayAspectRatio);
			return cb_getDisplayAspectRatio;
		}

		static int n_GetDisplayAspectRatio (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisplayAspectRatio;
		}
#pragma warning restore 0169

		static Delegate cb_setDisplayAspectRatio_I;
#pragma warning disable 0169
		static Delegate GetSetDisplayAspectRatio_IHandler ()
		{
			if (cb_setDisplayAspectRatio_I == null)
				cb_setDisplayAspectRatio_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDisplayAspectRatio_I);
			return cb_setDisplayAspectRatio_I;
		}

		static void n_SetDisplayAspectRatio_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisplayAspectRatio = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDisplayAspectRatio;
		static IntPtr id_setDisplayAspectRatio_I;
		public virtual unsafe int DisplayAspectRatio {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='getDisplayAspectRatio' and count(parameter)=0]"
			[Register ("getDisplayAspectRatio", "()I", "GetGetDisplayAspectRatioHandler")]
			get {
				if (id_getDisplayAspectRatio == IntPtr.Zero)
					id_getDisplayAspectRatio = JNIEnv.GetMethodID (class_ref, "getDisplayAspectRatio", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDisplayAspectRatio);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplayAspectRatio", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='setDisplayAspectRatio' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDisplayAspectRatio", "(I)V", "GetSetDisplayAspectRatio_IHandler")]
			set {
				if (id_setDisplayAspectRatio_I == IntPtr.Zero)
					id_setDisplayAspectRatio_I = JNIEnv.GetMethodID (class_ref, "setDisplayAspectRatio", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDisplayAspectRatio_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisplayAspectRatio", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDisplayOrientation;
#pragma warning disable 0169
		static Delegate GetGetDisplayOrientationHandler ()
		{
			if (cb_getDisplayOrientation == null)
				cb_getDisplayOrientation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDisplayOrientation);
			return cb_getDisplayOrientation;
		}

		static int n_GetDisplayOrientation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisplayOrientation;
		}
#pragma warning restore 0169

		static IntPtr id_getDisplayOrientation;
		public virtual unsafe int DisplayOrientation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='getDisplayOrientation' and count(parameter)=0]"
			[Register ("getDisplayOrientation", "()I", "GetGetDisplayOrientationHandler")]
			get {
				if (id_getDisplayOrientation == IntPtr.Zero)
					id_getDisplayOrientation = JNIEnv.GetMethodID (class_ref, "getDisplayOrientation", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDisplayOrientation);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplayOrientation", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getDuration;
#pragma warning disable 0169
		static Delegate GetGetDurationHandler ()
		{
			if (cb_getDuration == null)
				cb_getDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDuration);
			return cb_getDuration;
		}

		static long n_GetDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Duration;
		}
#pragma warning restore 0169

		static IntPtr id_getDuration;
		public virtual unsafe long Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()J", "GetGetDurationHandler")]
			get {
				if (id_getDuration == IntPtr.Zero)
					id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDuration);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDuration", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_isPlaying;
#pragma warning disable 0169
		static Delegate GetIsPlayingHandler ()
		{
			if (cb_isPlaying == null)
				cb_isPlaying = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPlaying);
			return cb_isPlaying;
		}

		static bool n_IsPlaying (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPlaying;
		}
#pragma warning restore 0169

		static IntPtr id_isPlaying;
		public virtual unsafe bool IsPlaying {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='isPlaying' and count(parameter)=0]"
			[Register ("isPlaying", "()Z", "GetIsPlayingHandler")]
			get {
				if (id_isPlaying == IntPtr.Zero)
					id_isPlaying = JNIEnv.GetMethodID (class_ref, "isPlaying", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPlaying);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPlaying", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isLooping;
#pragma warning disable 0169
		static Delegate GetIsLoopingHandler ()
		{
			if (cb_isLooping == null)
				cb_isLooping = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLooping);
			return cb_isLooping;
		}

		static bool n_IsLooping (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Looping;
		}
#pragma warning restore 0169

		static Delegate cb_setLooping_Z;
#pragma warning disable 0169
		static Delegate GetSetLooping_ZHandler ()
		{
			if (cb_setLooping_Z == null)
				cb_setLooping_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetLooping_Z);
			return cb_setLooping_Z;
		}

		static void n_SetLooping_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Looping = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isLooping;
		static IntPtr id_setLooping_Z;
		public virtual unsafe bool Looping {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='isLooping' and count(parameter)=0]"
			[Register ("isLooping", "()Z", "GetIsLoopingHandler")]
			get {
				if (id_isLooping == IntPtr.Zero)
					id_isLooping = JNIEnv.GetMethodID (class_ref, "isLooping", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLooping);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isLooping", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='setLooping' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setLooping", "(Z)V", "GetSetLooping_ZHandler")]
			set {
				if (id_setLooping_Z == IntPtr.Zero)
					id_setLooping_Z = JNIEnv.GetMethodID (class_ref, "setLooping", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLooping_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLooping", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMetadata;
#pragma warning disable 0169
		static Delegate GetGetMetadataHandler ()
		{
			if (cb_getMetadata == null)
				cb_getMetadata = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMetadata);
			return cb_getMetadata;
		}

		static IntPtr n_GetMetadata (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary.ToLocalJniHandle (__this.Metadata);
		}
#pragma warning restore 0169

		static IntPtr id_getMetadata;
		public virtual unsafe global::System.Collections.IDictionary Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='getMetadata' and count(parameter)=0]"
			[Register ("getMetadata", "()Ljava/util/HashMap;", "GetGetMetadataHandler")]
			get {
				if (id_getMetadata == IntPtr.Zero)
					id_getMetadata = JNIEnv.GetMethodID (class_ref, "getMetadata", "()Ljava/util/HashMap;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMetadata), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMetadata", "()Ljava/util/HashMap;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPlayerState;
#pragma warning disable 0169
		static Delegate GetGetPlayerStateHandler ()
		{
			if (cb_getPlayerState == null)
				cb_getPlayerState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlayerState);
			return cb_getPlayerState;
		}

		static IntPtr n_GetPlayerState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PlayerState);
		}
#pragma warning restore 0169

		static IntPtr id_getPlayerState;
		public virtual unsafe global::Com.Pili.Pldroid.Player.PlayerState PlayerState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='getPlayerState' and count(parameter)=0]"
			[Register ("getPlayerState", "()Lcom/pili/pldroid/player/PlayerState;", "GetGetPlayerStateHandler")]
			get {
				if (id_getPlayerState == IntPtr.Zero)
					id_getPlayerState = JNIEnv.GetMethodID (class_ref, "getPlayerState", "()Lcom/pili/pldroid/player/PlayerState;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PlayerState> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPlayerState), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PlayerState> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPlayerState", "()Lcom/pili/pldroid/player/PlayerState;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getResolutionInline;
#pragma warning disable 0169
		static Delegate GetGetResolutionInlineHandler ()
		{
			if (cb_getResolutionInline == null)
				cb_getResolutionInline = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResolutionInline);
			return cb_getResolutionInline;
		}

		static IntPtr n_GetResolutionInline (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResolutionInline);
		}
#pragma warning restore 0169

		static IntPtr id_getResolutionInline;
		public virtual unsafe string ResolutionInline {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='getResolutionInline' and count(parameter)=0]"
			[Register ("getResolutionInline", "()Ljava/lang/String;", "GetGetResolutionInlineHandler")]
			get {
				if (id_getResolutionInline == IntPtr.Zero)
					id_getResolutionInline = JNIEnv.GetMethodID (class_ref, "getResolutionInline", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResolutionInline), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResolutionInline", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextureView;
#pragma warning disable 0169
		static Delegate GetGetTextureViewHandler ()
		{
			if (cb_getTextureView == null)
				cb_getTextureView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextureView);
			return cb_getTextureView;
		}

		static IntPtr n_GetTextureView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextureView);
		}
#pragma warning restore 0169

		static IntPtr id_getTextureView;
		public virtual unsafe global::Android.Views.TextureView TextureView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='getTextureView' and count(parameter)=0]"
			[Register ("getTextureView", "()Landroid/view/TextureView;", "GetGetTextureViewHandler")]
			get {
				if (id_getTextureView == IntPtr.Zero)
					id_getTextureView = JNIEnv.GetMethodID (class_ref, "getTextureView", "()Landroid/view/TextureView;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.TextureView> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTextureView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.TextureView> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTextureView", "()Landroid/view/TextureView;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVideoBitrate;
#pragma warning disable 0169
		static Delegate GetGetVideoBitrateHandler ()
		{
			if (cb_getVideoBitrate == null)
				cb_getVideoBitrate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetVideoBitrate);
			return cb_getVideoBitrate;
		}

		static long n_GetVideoBitrate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoBitrate;
		}
#pragma warning restore 0169

		static IntPtr id_getVideoBitrate;
		public virtual unsafe long VideoBitrate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='getVideoBitrate' and count(parameter)=0]"
			[Register ("getVideoBitrate", "()J", "GetGetVideoBitrateHandler")]
			get {
				if (id_getVideoBitrate == IntPtr.Zero)
					id_getVideoBitrate = JNIEnv.GetMethodID (class_ref, "getVideoBitrate", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getVideoBitrate);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideoBitrate", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getVideoFps;
#pragma warning disable 0169
		static Delegate GetGetVideoFpsHandler ()
		{
			if (cb_getVideoFps == null)
				cb_getVideoFps = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVideoFps);
			return cb_getVideoFps;
		}

		static int n_GetVideoFps (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoFps;
		}
#pragma warning restore 0169

		static IntPtr id_getVideoFps;
		public virtual unsafe int VideoFps {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='getVideoFps' and count(parameter)=0]"
			[Register ("getVideoFps", "()I", "GetGetVideoFpsHandler")]
			get {
				if (id_getVideoFps == IntPtr.Zero)
					id_getVideoFps = JNIEnv.GetMethodID (class_ref, "getVideoFps", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getVideoFps);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideoFps", "()I"));
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
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.A ();
		}
#pragma warning restore 0169

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()V", "GetAHandler")]
		protected virtual unsafe void A ()
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

		static Delegate cb_a_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetA_Landroid_content_Context_Handler ()
		{
			if (cb_a_Landroid_content_Context_ == null)
				cb_a_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Landroid_content_Context_);
			return cb_a_Landroid_content_Context_;
		}

		static void n_A_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		static IntPtr id_a_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("a", "(Landroid/content/Context;)V", "GetA_Landroid_content_Context_Handler")]
		protected virtual unsafe void A (global::Android.Content.Context p0)
		{
			if (id_a_Landroid_content_Context_ == IntPtr.Zero)
				id_a_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_a_Lcom_pili_pldroid_player_PLMediaPlayer_Landroid_view_Surface_;
#pragma warning disable 0169
		static Delegate GetA_Lcom_pili_pldroid_player_PLMediaPlayer_Landroid_view_Surface_Handler ()
		{
			if (cb_a_Lcom_pili_pldroid_player_PLMediaPlayer_Landroid_view_Surface_ == null)
				cb_a_Lcom_pili_pldroid_player_PLMediaPlayer_Landroid_view_Surface_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Lcom_pili_pldroid_player_PLMediaPlayer_Landroid_view_Surface_);
			return cb_a_Lcom_pili_pldroid_player_PLMediaPlayer_Landroid_view_Surface_;
		}

		static void n_A_Lcom_pili_pldroid_player_PLMediaPlayer_Landroid_view_Surface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Pili.Pldroid.Player.PLMediaPlayer p0 = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Surface p1 = global::Java.Lang.Object.GetObject<global::Android.Views.Surface> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.A (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_a_Lcom_pili_pldroid_player_PLMediaPlayer_Landroid_view_Surface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='a' and count(parameter)=2 and parameter[1][@type='com.pili.pldroid.player.PLMediaPlayer'] and parameter[2][@type='android.view.Surface']]"
		[Register ("a", "(Lcom/pili/pldroid/player/PLMediaPlayer;Landroid/view/Surface;)V", "GetA_Lcom_pili_pldroid_player_PLMediaPlayer_Landroid_view_Surface_Handler")]
		protected virtual unsafe void A (global::Com.Pili.Pldroid.Player.PLMediaPlayer p0, global::Android.Views.Surface p1)
		{
			if (id_a_Lcom_pili_pldroid_player_PLMediaPlayer_Landroid_view_Surface_ == IntPtr.Zero)
				id_a_Lcom_pili_pldroid_player_PLMediaPlayer_Landroid_view_Surface_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/pili/pldroid/player/PLMediaPlayer;Landroid/view/Surface;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_Lcom_pili_pldroid_player_PLMediaPlayer_Landroid_view_Surface_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Lcom/pili/pldroid/player/PLMediaPlayer;Landroid/view/Surface;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_canPause;
#pragma warning disable 0169
		static Delegate GetCanPauseHandler ()
		{
			if (cb_canPause == null)
				cb_canPause = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CanPause);
			return cb_canPause;
		}

		static bool n_CanPause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanPause ();
		}
#pragma warning restore 0169

		static IntPtr id_canPause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='canPause' and count(parameter)=0]"
		[Register ("canPause", "()Z", "GetCanPauseHandler")]
		public virtual unsafe bool CanPause ()
		{
			if (id_canPause == IntPtr.Zero)
				id_canPause = JNIEnv.GetMethodID (class_ref, "canPause", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_canPause);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "canPause", "()Z"));
			} finally {
			}
		}

		static Delegate cb_canSeekBackward;
#pragma warning disable 0169
		static Delegate GetCanSeekBackwardHandler ()
		{
			if (cb_canSeekBackward == null)
				cb_canSeekBackward = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CanSeekBackward);
			return cb_canSeekBackward;
		}

		static bool n_CanSeekBackward (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanSeekBackward ();
		}
#pragma warning restore 0169

		static IntPtr id_canSeekBackward;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='canSeekBackward' and count(parameter)=0]"
		[Register ("canSeekBackward", "()Z", "GetCanSeekBackwardHandler")]
		public virtual unsafe bool CanSeekBackward ()
		{
			if (id_canSeekBackward == IntPtr.Zero)
				id_canSeekBackward = JNIEnv.GetMethodID (class_ref, "canSeekBackward", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_canSeekBackward);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "canSeekBackward", "()Z"));
			} finally {
			}
		}

		static Delegate cb_canSeekForward;
#pragma warning disable 0169
		static Delegate GetCanSeekForwardHandler ()
		{
			if (cb_canSeekForward == null)
				cb_canSeekForward = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CanSeekForward);
			return cb_canSeekForward;
		}

		static bool n_CanSeekForward (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanSeekForward ();
		}
#pragma warning restore 0169

		static IntPtr id_canSeekForward;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='canSeekForward' and count(parameter)=0]"
		[Register ("canSeekForward", "()Z", "GetCanSeekForwardHandler")]
		public virtual unsafe bool CanSeekForward ()
		{
			if (id_canSeekForward == IntPtr.Zero)
				id_canSeekForward = JNIEnv.GetMethodID (class_ref, "canSeekForward", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_canSeekForward);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "canSeekForward", "()Z"));
			} finally {
			}
		}

		static Delegate cb_onKeyDown_ILandroid_view_KeyEvent_;
#pragma warning disable 0169
		static Delegate GetOnKeyDown_ILandroid_view_KeyEvent_Handler ()
		{
			if (cb_onKeyDown_ILandroid_view_KeyEvent_ == null)
				cb_onKeyDown_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_OnKeyDown_ILandroid_view_KeyEvent_);
			return cb_onKeyDown_ILandroid_view_KeyEvent_;
		}

		static bool n_OnKeyDown_ILandroid_view_KeyEvent_ (IntPtr jnienv, IntPtr native__this, int native_p0, IntPtr native_p1)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Keycode p0 = (global::Android.Views.Keycode) native_p0;
			global::Android.Views.KeyEvent p1 = global::Java.Lang.Object.GetObject<global::Android.Views.KeyEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnKeyDown (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onKeyDown_ILandroid_view_KeyEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='onKeyDown' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.KeyEvent']]"
		[Register ("onKeyDown", "(ILandroid/view/KeyEvent;)Z", "GetOnKeyDown_ILandroid_view_KeyEvent_Handler")]
		public override unsafe bool OnKeyDown ([global::Android.Runtime.GeneratedEnum] global::Android.Views.Keycode p0, global::Android.Views.KeyEvent p1)
		{
			if (id_onKeyDown_ILandroid_view_KeyEvent_ == IntPtr.Zero)
				id_onKeyDown_ILandroid_view_KeyEvent_ = JNIEnv.GetMethodID (class_ref, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((int) p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onKeyDown_ILandroid_view_KeyEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onTouchEvent_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnTouchEvent_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onTouchEvent_Landroid_view_MotionEvent_ == null)
				cb_onTouchEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnTouchEvent_Landroid_view_MotionEvent_);
			return cb_onTouchEvent_Landroid_view_MotionEvent_;
		}

		static bool n_OnTouchEvent_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouchEvent (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTouchEvent_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='onTouchEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onTouchEvent", "(Landroid/view/MotionEvent;)Z", "GetOnTouchEvent_Landroid_view_MotionEvent_Handler")]
		public override unsafe bool OnTouchEvent (global::Android.Views.MotionEvent p0)
		{
			if (id_onTouchEvent_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onTouchEvent_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onTouchEvent_Landroid_view_MotionEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onTrackballEvent_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnTrackballEvent_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onTrackballEvent_Landroid_view_MotionEvent_ == null)
				cb_onTrackballEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnTrackballEvent_Landroid_view_MotionEvent_);
			return cb_onTrackballEvent_Landroid_view_MotionEvent_;
		}

		static bool n_OnTrackballEvent_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTrackballEvent (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTrackballEvent_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='onTrackballEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onTrackballEvent", "(Landroid/view/MotionEvent;)Z", "GetOnTrackballEvent_Landroid_view_MotionEvent_Handler")]
		public override unsafe bool OnTrackballEvent (global::Android.Views.MotionEvent p0)
		{
			if (id_onTrackballEvent_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onTrackballEvent_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onTrackballEvent_Landroid_view_MotionEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_pause;
#pragma warning disable 0169
		static Delegate GetPauseHandler ()
		{
			if (cb_pause == null)
				cb_pause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Pause);
			return cb_pause;
		}

		static void n_Pause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		static IntPtr id_pause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler")]
		public virtual unsafe void Pause ()
		{
			if (id_pause == IntPtr.Zero)
				id_pause = JNIEnv.GetMethodID (class_ref, "pause", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pause);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pause", "()V"));
			} finally {
			}
		}

		static Delegate cb_releaseSurfactexture;
#pragma warning disable 0169
		static Delegate GetReleaseSurfactextureHandler ()
		{
			if (cb_releaseSurfactexture == null)
				cb_releaseSurfactexture = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReleaseSurfactexture);
			return cb_releaseSurfactexture;
		}

		static void n_ReleaseSurfactexture (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseSurfactexture ();
		}
#pragma warning restore 0169

		static IntPtr id_releaseSurfactexture;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='releaseSurfactexture' and count(parameter)=0]"
		[Register ("releaseSurfactexture", "()V", "GetReleaseSurfactextureHandler")]
		public virtual unsafe void ReleaseSurfactexture ()
		{
			if (id_releaseSurfactexture == IntPtr.Zero)
				id_releaseSurfactexture = JNIEnv.GetMethodID (class_ref, "releaseSurfactexture", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_releaseSurfactexture);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "releaseSurfactexture", "()V"));
			} finally {
			}
		}

		static Delegate cb_seekTo_J;
#pragma warning disable 0169
		static Delegate GetSeekTo_JHandler ()
		{
			if (cb_seekTo_J == null)
				cb_seekTo_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SeekTo_J);
			return cb_seekTo_J;
		}

		static void n_SeekTo_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SeekTo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_seekTo_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='seekTo' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("seekTo", "(J)V", "GetSeekTo_JHandler")]
		public virtual unsafe void SeekTo (long p0)
		{
			if (id_seekTo_J == IntPtr.Zero)
				id_seekTo_J = JNIEnv.GetMethodID (class_ref, "seekTo", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_seekTo_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "seekTo", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setAVOptions_Lcom_pili_pldroid_player_AVOptions_;
#pragma warning disable 0169
		static Delegate GetSetAVOptions_Lcom_pili_pldroid_player_AVOptions_Handler ()
		{
			if (cb_setAVOptions_Lcom_pili_pldroid_player_AVOptions_ == null)
				cb_setAVOptions_Lcom_pili_pldroid_player_AVOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAVOptions_Lcom_pili_pldroid_player_AVOptions_);
			return cb_setAVOptions_Lcom_pili_pldroid_player_AVOptions_;
		}

		static void n_SetAVOptions_Lcom_pili_pldroid_player_AVOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Pili.Pldroid.Player.AVOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.AVOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAVOptions (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAVOptions_Lcom_pili_pldroid_player_AVOptions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='setAVOptions' and count(parameter)=1 and parameter[1][@type='com.pili.pldroid.player.AVOptions']]"
		[Register ("setAVOptions", "(Lcom/pili/pldroid/player/AVOptions;)V", "GetSetAVOptions_Lcom_pili_pldroid_player_AVOptions_Handler")]
		public virtual unsafe void SetAVOptions (global::Com.Pili.Pldroid.Player.AVOptions p0)
		{
			if (id_setAVOptions_Lcom_pili_pldroid_player_AVOptions_ == IntPtr.Zero)
				id_setAVOptions_Lcom_pili_pldroid_player_AVOptions_ = JNIEnv.GetMethodID (class_ref, "setAVOptions", "(Lcom/pili/pldroid/player/AVOptions;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAVOptions_Lcom_pili_pldroid_player_AVOptions_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAVOptions", "(Lcom/pili/pldroid/player/AVOptions;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setBufferingIndicator_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetBufferingIndicator_Landroid_view_View_Handler ()
		{
			if (cb_setBufferingIndicator_Landroid_view_View_ == null)
				cb_setBufferingIndicator_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBufferingIndicator_Landroid_view_View_);
			return cb_setBufferingIndicator_Landroid_view_View_;
		}

		static void n_SetBufferingIndicator_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetBufferingIndicator (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setBufferingIndicator_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='setBufferingIndicator' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("setBufferingIndicator", "(Landroid/view/View;)V", "GetSetBufferingIndicator_Landroid_view_View_Handler")]
		public virtual unsafe void SetBufferingIndicator (global::Android.Views.View p0)
		{
			if (id_setBufferingIndicator_Landroid_view_View_ == IntPtr.Zero)
				id_setBufferingIndicator_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setBufferingIndicator", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBufferingIndicator_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBufferingIndicator", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setCoverView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetCoverView_Landroid_view_View_Handler ()
		{
			if (cb_setCoverView_Landroid_view_View_ == null)
				cb_setCoverView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCoverView_Landroid_view_View_);
			return cb_setCoverView_Landroid_view_View_;
		}

		static void n_SetCoverView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCoverView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCoverView_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='setCoverView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("setCoverView", "(Landroid/view/View;)V", "GetSetCoverView_Landroid_view_View_Handler")]
		public virtual unsafe void SetCoverView (global::Android.Views.View p0)
		{
			if (id_setCoverView_Landroid_view_View_ == IntPtr.Zero)
				id_setCoverView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setCoverView", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCoverView_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCoverView", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDebugLoggingEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetDebugLoggingEnabled_ZHandler ()
		{
			if (cb_setDebugLoggingEnabled_Z == null)
				cb_setDebugLoggingEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDebugLoggingEnabled_Z);
			return cb_setDebugLoggingEnabled_Z;
		}

		static void n_SetDebugLoggingEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDebugLoggingEnabled (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDebugLoggingEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='setDebugLoggingEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDebugLoggingEnabled", "(Z)V", "GetSetDebugLoggingEnabled_ZHandler")]
		public virtual unsafe void SetDebugLoggingEnabled (bool p0)
		{
			if (id_setDebugLoggingEnabled_Z == IntPtr.Zero)
				id_setDebugLoggingEnabled_Z = JNIEnv.GetMethodID (class_ref, "setDebugLoggingEnabled", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDebugLoggingEnabled_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDebugLoggingEnabled", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDisplayOrientation_I;
#pragma warning disable 0169
		static Delegate GetSetDisplayOrientation_IHandler ()
		{
			if (cb_setDisplayOrientation_I == null)
				cb_setDisplayOrientation_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_SetDisplayOrientation_I);
			return cb_setDisplayOrientation_I;
		}

		static bool n_SetDisplayOrientation_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetDisplayOrientation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDisplayOrientation_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='setDisplayOrientation' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDisplayOrientation", "(I)Z", "GetSetDisplayOrientation_IHandler")]
		public virtual unsafe bool SetDisplayOrientation (int p0)
		{
			if (id_setDisplayOrientation_I == IntPtr.Zero)
				id_setDisplayOrientation_I = JNIEnv.GetMethodID (class_ref, "setDisplayOrientation", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setDisplayOrientation_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisplayOrientation", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_setMediaController_Lcom_pili_pldroid_player_IMediaController_;
#pragma warning disable 0169
		static Delegate GetSetMediaController_Lcom_pili_pldroid_player_IMediaController_Handler ()
		{
			if (cb_setMediaController_Lcom_pili_pldroid_player_IMediaController_ == null)
				cb_setMediaController_Lcom_pili_pldroid_player_IMediaController_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMediaController_Lcom_pili_pldroid_player_IMediaController_);
			return cb_setMediaController_Lcom_pili_pldroid_player_IMediaController_;
		}

		static void n_SetMediaController_Lcom_pili_pldroid_player_IMediaController_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Pili.Pldroid.Player.IMediaController p0 = (global::Com.Pili.Pldroid.Player.IMediaController)global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.IMediaController> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMediaController (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMediaController_Lcom_pili_pldroid_player_IMediaController_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='setMediaController' and count(parameter)=1 and parameter[1][@type='com.pili.pldroid.player.IMediaController']]"
		[Register ("setMediaController", "(Lcom/pili/pldroid/player/IMediaController;)V", "GetSetMediaController_Lcom_pili_pldroid_player_IMediaController_Handler")]
		public virtual unsafe void SetMediaController (global::Com.Pili.Pldroid.Player.IMediaController p0)
		{
			if (id_setMediaController_Lcom_pili_pldroid_player_IMediaController_ == IntPtr.Zero)
				id_setMediaController_Lcom_pili_pldroid_player_IMediaController_ = JNIEnv.GetMethodID (class_ref, "setMediaController", "(Lcom/pili/pldroid/player/IMediaController;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMediaController_Lcom_pili_pldroid_player_IMediaController_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMediaController", "(Lcom/pili/pldroid/player/IMediaController;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setMirror_Z;
#pragma warning disable 0169
		static Delegate GetSetMirror_ZHandler ()
		{
			if (cb_setMirror_Z == null)
				cb_setMirror_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetMirror_Z);
			return cb_setMirror_Z;
		}

		static void n_SetMirror_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMirror (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMirror_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='setMirror' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setMirror", "(Z)V", "GetSetMirror_ZHandler")]
		public virtual unsafe void SetMirror (bool p0)
		{
			if (id_setMirror_Z == IntPtr.Zero)
				id_setMirror_Z = JNIEnv.GetMethodID (class_ref, "setMirror", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMirror_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMirror", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnBufferingUpdateListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnBufferingUpdateListener_;
#pragma warning disable 0169
		static Delegate GetSetOnBufferingUpdateListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnBufferingUpdateListener_Handler ()
		{
			if (cb_setOnBufferingUpdateListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnBufferingUpdateListener_ == null)
				cb_setOnBufferingUpdateListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnBufferingUpdateListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnBufferingUpdateListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnBufferingUpdateListener_);
			return cb_setOnBufferingUpdateListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnBufferingUpdateListener_;
		}

		static void n_SetOnBufferingUpdateListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnBufferingUpdateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnBufferingUpdateListener p0 = (global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnBufferingUpdateListener)global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnBufferingUpdateListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnBufferingUpdateListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnBufferingUpdateListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnBufferingUpdateListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='setOnBufferingUpdateListener' and count(parameter)=1 and parameter[1][@type='com.pili.pldroid.player.PLMediaPlayer.OnBufferingUpdateListener']]"
		[Register ("setOnBufferingUpdateListener", "(Lcom/pili/pldroid/player/PLMediaPlayer$OnBufferingUpdateListener;)V", "GetSetOnBufferingUpdateListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnBufferingUpdateListener_Handler")]
		public virtual unsafe void SetOnBufferingUpdateListener (global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnBufferingUpdateListener p0)
		{
			if (id_setOnBufferingUpdateListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnBufferingUpdateListener_ == IntPtr.Zero)
				id_setOnBufferingUpdateListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnBufferingUpdateListener_ = JNIEnv.GetMethodID (class_ref, "setOnBufferingUpdateListener", "(Lcom/pili/pldroid/player/PLMediaPlayer$OnBufferingUpdateListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnBufferingUpdateListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnBufferingUpdateListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnBufferingUpdateListener", "(Lcom/pili/pldroid/player/PLMediaPlayer$OnBufferingUpdateListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnCompletionListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnCompletionListener_;
#pragma warning disable 0169
		static Delegate GetSetOnCompletionListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnCompletionListener_Handler ()
		{
			if (cb_setOnCompletionListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnCompletionListener_ == null)
				cb_setOnCompletionListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnCompletionListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnCompletionListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnCompletionListener_);
			return cb_setOnCompletionListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnCompletionListener_;
		}

		static void n_SetOnCompletionListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnCompletionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnCompletionListener p0 = (global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnCompletionListener)global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnCompletionListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnCompletionListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnCompletionListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnCompletionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='setOnCompletionListener' and count(parameter)=1 and parameter[1][@type='com.pili.pldroid.player.PLMediaPlayer.OnCompletionListener']]"
		[Register ("setOnCompletionListener", "(Lcom/pili/pldroid/player/PLMediaPlayer$OnCompletionListener;)V", "GetSetOnCompletionListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnCompletionListener_Handler")]
		public virtual unsafe void SetOnCompletionListener (global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnCompletionListener p0)
		{
			if (id_setOnCompletionListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnCompletionListener_ == IntPtr.Zero)
				id_setOnCompletionListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnCompletionListener_ = JNIEnv.GetMethodID (class_ref, "setOnCompletionListener", "(Lcom/pili/pldroid/player/PLMediaPlayer$OnCompletionListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnCompletionListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnCompletionListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnCompletionListener", "(Lcom/pili/pldroid/player/PLMediaPlayer$OnCompletionListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnErrorListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnErrorListener_;
#pragma warning disable 0169
		static Delegate GetSetOnErrorListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnErrorListener_Handler ()
		{
			if (cb_setOnErrorListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnErrorListener_ == null)
				cb_setOnErrorListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnErrorListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnErrorListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnErrorListener_);
			return cb_setOnErrorListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnErrorListener_;
		}

		static void n_SetOnErrorListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnErrorListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnErrorListener p0 = (global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnErrorListener)global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnErrorListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnErrorListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnErrorListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnErrorListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='setOnErrorListener' and count(parameter)=1 and parameter[1][@type='com.pili.pldroid.player.PLMediaPlayer.OnErrorListener']]"
		[Register ("setOnErrorListener", "(Lcom/pili/pldroid/player/PLMediaPlayer$OnErrorListener;)V", "GetSetOnErrorListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnErrorListener_Handler")]
		public virtual unsafe void SetOnErrorListener (global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnErrorListener p0)
		{
			if (id_setOnErrorListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnErrorListener_ == IntPtr.Zero)
				id_setOnErrorListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnErrorListener_ = JNIEnv.GetMethodID (class_ref, "setOnErrorListener", "(Lcom/pili/pldroid/player/PLMediaPlayer$OnErrorListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnErrorListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnErrorListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnErrorListener", "(Lcom/pili/pldroid/player/PLMediaPlayer$OnErrorListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnInfoListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnInfoListener_;
#pragma warning disable 0169
		static Delegate GetSetOnInfoListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnInfoListener_Handler ()
		{
			if (cb_setOnInfoListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnInfoListener_ == null)
				cb_setOnInfoListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnInfoListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnInfoListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnInfoListener_);
			return cb_setOnInfoListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnInfoListener_;
		}

		static void n_SetOnInfoListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnInfoListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnInfoListener p0 = (global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnInfoListener)global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnInfoListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnInfoListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnInfoListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnInfoListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='setOnInfoListener' and count(parameter)=1 and parameter[1][@type='com.pili.pldroid.player.PLMediaPlayer.OnInfoListener']]"
		[Register ("setOnInfoListener", "(Lcom/pili/pldroid/player/PLMediaPlayer$OnInfoListener;)V", "GetSetOnInfoListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnInfoListener_Handler")]
		public virtual unsafe void SetOnInfoListener (global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnInfoListener p0)
		{
			if (id_setOnInfoListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnInfoListener_ == IntPtr.Zero)
				id_setOnInfoListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnInfoListener_ = JNIEnv.GetMethodID (class_ref, "setOnInfoListener", "(Lcom/pili/pldroid/player/PLMediaPlayer$OnInfoListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnInfoListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnInfoListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnInfoListener", "(Lcom/pili/pldroid/player/PLMediaPlayer$OnInfoListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnPreparedListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnPreparedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnPreparedListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnPreparedListener_Handler ()
		{
			if (cb_setOnPreparedListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnPreparedListener_ == null)
				cb_setOnPreparedListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnPreparedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnPreparedListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnPreparedListener_);
			return cb_setOnPreparedListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnPreparedListener_;
		}

		static void n_SetOnPreparedListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnPreparedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnPreparedListener p0 = (global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnPreparedListener)global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnPreparedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnPreparedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnPreparedListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnPreparedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='setOnPreparedListener' and count(parameter)=1 and parameter[1][@type='com.pili.pldroid.player.PLMediaPlayer.OnPreparedListener']]"
		[Register ("setOnPreparedListener", "(Lcom/pili/pldroid/player/PLMediaPlayer$OnPreparedListener;)V", "GetSetOnPreparedListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnPreparedListener_Handler")]
		public virtual unsafe void SetOnPreparedListener (global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnPreparedListener p0)
		{
			if (id_setOnPreparedListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnPreparedListener_ == IntPtr.Zero)
				id_setOnPreparedListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnPreparedListener_ = JNIEnv.GetMethodID (class_ref, "setOnPreparedListener", "(Lcom/pili/pldroid/player/PLMediaPlayer$OnPreparedListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnPreparedListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnPreparedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnPreparedListener", "(Lcom/pili/pldroid/player/PLMediaPlayer$OnPreparedListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnSeekCompleteListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnSeekCompleteListener_;
#pragma warning disable 0169
		static Delegate GetSetOnSeekCompleteListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnSeekCompleteListener_Handler ()
		{
			if (cb_setOnSeekCompleteListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnSeekCompleteListener_ == null)
				cb_setOnSeekCompleteListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnSeekCompleteListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnSeekCompleteListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnSeekCompleteListener_);
			return cb_setOnSeekCompleteListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnSeekCompleteListener_;
		}

		static void n_SetOnSeekCompleteListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnSeekCompleteListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnSeekCompleteListener p0 = (global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnSeekCompleteListener)global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnSeekCompleteListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnSeekCompleteListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnSeekCompleteListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnSeekCompleteListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='setOnSeekCompleteListener' and count(parameter)=1 and parameter[1][@type='com.pili.pldroid.player.PLMediaPlayer.OnSeekCompleteListener']]"
		[Register ("setOnSeekCompleteListener", "(Lcom/pili/pldroid/player/PLMediaPlayer$OnSeekCompleteListener;)V", "GetSetOnSeekCompleteListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnSeekCompleteListener_Handler")]
		public virtual unsafe void SetOnSeekCompleteListener (global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnSeekCompleteListener p0)
		{
			if (id_setOnSeekCompleteListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnSeekCompleteListener_ == IntPtr.Zero)
				id_setOnSeekCompleteListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnSeekCompleteListener_ = JNIEnv.GetMethodID (class_ref, "setOnSeekCompleteListener", "(Lcom/pili/pldroid/player/PLMediaPlayer$OnSeekCompleteListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnSeekCompleteListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnSeekCompleteListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnSeekCompleteListener", "(Lcom/pili/pldroid/player/PLMediaPlayer$OnSeekCompleteListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnVideoSizeChangedListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnVideoSizeChangedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnVideoSizeChangedListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnVideoSizeChangedListener_Handler ()
		{
			if (cb_setOnVideoSizeChangedListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnVideoSizeChangedListener_ == null)
				cb_setOnVideoSizeChangedListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnVideoSizeChangedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnVideoSizeChangedListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnVideoSizeChangedListener_);
			return cb_setOnVideoSizeChangedListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnVideoSizeChangedListener_;
		}

		static void n_SetOnVideoSizeChangedListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnVideoSizeChangedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnVideoSizeChangedListener p0 = (global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnVideoSizeChangedListener)global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnVideoSizeChangedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnVideoSizeChangedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnVideoSizeChangedListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnVideoSizeChangedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='setOnVideoSizeChangedListener' and count(parameter)=1 and parameter[1][@type='com.pili.pldroid.player.PLMediaPlayer.OnVideoSizeChangedListener']]"
		[Register ("setOnVideoSizeChangedListener", "(Lcom/pili/pldroid/player/PLMediaPlayer$OnVideoSizeChangedListener;)V", "GetSetOnVideoSizeChangedListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnVideoSizeChangedListener_Handler")]
		public virtual unsafe void SetOnVideoSizeChangedListener (global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnVideoSizeChangedListener p0)
		{
			if (id_setOnVideoSizeChangedListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnVideoSizeChangedListener_ == IntPtr.Zero)
				id_setOnVideoSizeChangedListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnVideoSizeChangedListener_ = JNIEnv.GetMethodID (class_ref, "setOnVideoSizeChangedListener", "(Lcom/pili/pldroid/player/PLMediaPlayer$OnVideoSizeChangedListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnVideoSizeChangedListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnVideoSizeChangedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnVideoSizeChangedListener", "(Lcom/pili/pldroid/player/PLMediaPlayer$OnVideoSizeChangedListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setScreenOnWhilePlaying_Z;
#pragma warning disable 0169
		static Delegate GetSetScreenOnWhilePlaying_ZHandler ()
		{
			if (cb_setScreenOnWhilePlaying_Z == null)
				cb_setScreenOnWhilePlaying_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetScreenOnWhilePlaying_Z);
			return cb_setScreenOnWhilePlaying_Z;
		}

		static void n_SetScreenOnWhilePlaying_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScreenOnWhilePlaying (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScreenOnWhilePlaying_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='setScreenOnWhilePlaying' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setScreenOnWhilePlaying", "(Z)V", "GetSetScreenOnWhilePlaying_ZHandler")]
		public virtual unsafe void SetScreenOnWhilePlaying (bool p0)
		{
			if (id_setScreenOnWhilePlaying_Z == IntPtr.Zero)
				id_setScreenOnWhilePlaying_Z = JNIEnv.GetMethodID (class_ref, "setScreenOnWhilePlaying", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setScreenOnWhilePlaying_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScreenOnWhilePlaying", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setVideoPath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetVideoPath_Ljava_lang_String_Handler ()
		{
			if (cb_setVideoPath_Ljava_lang_String_ == null)
				cb_setVideoPath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVideoPath_Ljava_lang_String_);
			return cb_setVideoPath_Ljava_lang_String_;
		}

		static void n_SetVideoPath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetVideoPath (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setVideoPath_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='setVideoPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setVideoPath", "(Ljava/lang/String;)V", "GetSetVideoPath_Ljava_lang_String_Handler")]
		public virtual unsafe void SetVideoPath (string p0)
		{
			if (id_setVideoPath_Ljava_lang_String_ == IntPtr.Zero)
				id_setVideoPath_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setVideoPath", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVideoPath_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVideoPath", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setVideoPath_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetVideoPath_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_setVideoPath_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_setVideoPath_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetVideoPath_Ljava_lang_String_Ljava_util_Map_);
			return cb_setVideoPath_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_SetVideoPath_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetVideoPath (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setVideoPath_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='setVideoPath' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map']]"
		[Register ("setVideoPath", "(Ljava/lang/String;Ljava/util/Map;)V", "GetSetVideoPath_Ljava_lang_String_Ljava_util_Map_Handler")]
		public virtual unsafe void SetVideoPath (string p0, global::System.Collections.IDictionary p1)
		{
			if (id_setVideoPath_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_setVideoPath_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setVideoPath", "(Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVideoPath_Ljava_lang_String_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVideoPath", "(Ljava/lang/String;Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setVideoURI_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetSetVideoURI_Landroid_net_Uri_Handler ()
		{
			if (cb_setVideoURI_Landroid_net_Uri_ == null)
				cb_setVideoURI_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVideoURI_Landroid_net_Uri_);
			return cb_setVideoURI_Landroid_net_Uri_;
		}

		static void n_SetVideoURI_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetVideoURI (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setVideoURI_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='setVideoURI' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("setVideoURI", "(Landroid/net/Uri;)V", "GetSetVideoURI_Landroid_net_Uri_Handler")]
		public virtual unsafe void SetVideoURI (global::Android.Net.Uri p0)
		{
			if (id_setVideoURI_Landroid_net_Uri_ == IntPtr.Zero)
				id_setVideoURI_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "setVideoURI", "(Landroid/net/Uri;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVideoURI_Landroid_net_Uri_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVideoURI", "(Landroid/net/Uri;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setVideoURI_Landroid_net_Uri_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetVideoURI_Landroid_net_Uri_Ljava_util_Map_Handler ()
		{
			if (cb_setVideoURI_Landroid_net_Uri_Ljava_util_Map_ == null)
				cb_setVideoURI_Landroid_net_Uri_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetVideoURI_Landroid_net_Uri_Ljava_util_Map_);
			return cb_setVideoURI_Landroid_net_Uri_Ljava_util_Map_;
		}

		static void n_SetVideoURI_Landroid_net_Uri_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetVideoURI (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setVideoURI_Landroid_net_Uri_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='setVideoURI' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='java.util.Map']]"
		[Register ("setVideoURI", "(Landroid/net/Uri;Ljava/util/Map;)V", "GetSetVideoURI_Landroid_net_Uri_Ljava_util_Map_Handler")]
		public virtual unsafe void SetVideoURI (global::Android.Net.Uri p0, global::System.Collections.IDictionary p1)
		{
			if (id_setVideoURI_Landroid_net_Uri_Ljava_util_Map_ == IntPtr.Zero)
				id_setVideoURI_Landroid_net_Uri_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setVideoURI", "(Landroid/net/Uri;Ljava/util/Map;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVideoURI_Landroid_net_Uri_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVideoURI", "(Landroid/net/Uri;Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setVolume_FF;
#pragma warning disable 0169
		static Delegate GetSetVolume_FFHandler ()
		{
			if (cb_setVolume_FF == null)
				cb_setVolume_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_SetVolume_FF);
			return cb_setVolume_FF;
		}

		static void n_SetVolume_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetVolume (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setVolume_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='setVolume' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setVolume", "(FF)V", "GetSetVolume_FFHandler")]
		public virtual unsafe void SetVolume (float p0, float p1)
		{
			if (id_setVolume_FF == IntPtr.Zero)
				id_setVolume_FF = JNIEnv.GetMethodID (class_ref, "setVolume", "(FF)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVolume_FF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVolume", "(FF)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setWakeMode_Landroid_content_Context_I;
#pragma warning disable 0169
		static Delegate GetSetWakeMode_Landroid_content_Context_IHandler ()
		{
			if (cb_setWakeMode_Landroid_content_Context_I == null)
				cb_setWakeMode_Landroid_content_Context_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetWakeMode_Landroid_content_Context_I);
			return cb_setWakeMode_Landroid_content_Context_I;
		}

		static void n_SetWakeMode_Landroid_content_Context_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetWakeMode (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setWakeMode_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='setWakeMode' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("setWakeMode", "(Landroid/content/Context;I)V", "GetSetWakeMode_Landroid_content_Context_IHandler")]
		public virtual unsafe void SetWakeMode (global::Android.Content.Context p0, int p1)
		{
			if (id_setWakeMode_Landroid_content_Context_I == IntPtr.Zero)
				id_setWakeMode_Landroid_content_Context_I = JNIEnv.GetMethodID (class_ref, "setWakeMode", "(Landroid/content/Context;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setWakeMode_Landroid_content_Context_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWakeMode", "(Landroid/content/Context;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "()V"));
			} finally {
			}
		}

		static Delegate cb_stopPlayback;
#pragma warning disable 0169
		static Delegate GetStopPlaybackHandler ()
		{
			if (cb_stopPlayback == null)
				cb_stopPlayback = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopPlayback);
			return cb_stopPlayback;
		}

		static void n_StopPlayback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.Widget.PLVideoTextureView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopPlayback ();
		}
#pragma warning restore 0169

		static IntPtr id_stopPlayback;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player.widget']/class[@name='PLVideoTextureView']/method[@name='stopPlayback' and count(parameter)=0]"
		[Register ("stopPlayback", "()V", "GetStopPlaybackHandler")]
		public virtual unsafe void StopPlayback ()
		{
			if (id_stopPlayback == IntPtr.Zero)
				id_stopPlayback = JNIEnv.GetMethodID (class_ref, "stopPlayback", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopPlayback);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopPlayback", "()V"));
			} finally {
			}
		}

#region "Event implementation for Com.Pili.Pldroid.Player.PLMediaPlayer.IOnBufferingUpdateListener"
		public event EventHandler<global::Com.Pili.Pldroid.Player.PLMediaPlayer.BufferingUpdateEventArgs> BufferingUpdate {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnBufferingUpdateListener, global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnBufferingUpdateListenerImplementor>(
						ref weak_implementor_SetOnBufferingUpdateListener,
						__CreateIOnBufferingUpdateListenerImplementor,
						SetOnBufferingUpdateListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnBufferingUpdateListener, global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnBufferingUpdateListenerImplementor>(
						ref weak_implementor_SetOnBufferingUpdateListener,
						global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnBufferingUpdateListenerImplementor.__IsEmpty,
						__v => SetOnBufferingUpdateListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnBufferingUpdateListener;

		global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnBufferingUpdateListenerImplementor __CreateIOnBufferingUpdateListenerImplementor ()
		{
			return new global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnBufferingUpdateListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Pili.Pldroid.Player.PLMediaPlayer.IOnCompletionListener"
		public event EventHandler<global::Com.Pili.Pldroid.Player.PLMediaPlayer.CompletionEventArgs> Completion {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnCompletionListener, global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnCompletionListenerImplementor>(
						ref weak_implementor_SetOnCompletionListener,
						__CreateIOnCompletionListenerImplementor,
						SetOnCompletionListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnCompletionListener, global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnCompletionListenerImplementor>(
						ref weak_implementor_SetOnCompletionListener,
						global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnCompletionListenerImplementor.__IsEmpty,
						__v => SetOnCompletionListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnCompletionListener;

		global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnCompletionListenerImplementor __CreateIOnCompletionListenerImplementor ()
		{
			return new global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnCompletionListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Pili.Pldroid.Player.PLMediaPlayer.IOnErrorListener"
		public event EventHandler<global::Com.Pili.Pldroid.Player.PLMediaPlayer.ErrorEventArgs> Error {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnErrorListener, global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnErrorListenerImplementor>(
						ref weak_implementor_SetOnErrorListener,
						__CreateIOnErrorListenerImplementor,
						SetOnErrorListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnErrorListener, global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnErrorListenerImplementor>(
						ref weak_implementor_SetOnErrorListener,
						global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnErrorListenerImplementor.__IsEmpty,
						__v => SetOnErrorListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnErrorListener;

		global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnErrorListenerImplementor __CreateIOnErrorListenerImplementor ()
		{
			return new global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnErrorListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Pili.Pldroid.Player.PLMediaPlayer.IOnInfoListener"
		public event EventHandler<global::Com.Pili.Pldroid.Player.PLMediaPlayer.InfoEventArgs> Info {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnInfoListener, global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnInfoListenerImplementor>(
						ref weak_implementor_SetOnInfoListener,
						__CreateIOnInfoListenerImplementor,
						SetOnInfoListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnInfoListener, global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnInfoListenerImplementor>(
						ref weak_implementor_SetOnInfoListener,
						global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnInfoListenerImplementor.__IsEmpty,
						__v => SetOnInfoListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnInfoListener;

		global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnInfoListenerImplementor __CreateIOnInfoListenerImplementor ()
		{
			return new global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnInfoListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Pili.Pldroid.Player.PLMediaPlayer.IOnPreparedListener"
		public event EventHandler<global::Com.Pili.Pldroid.Player.PLMediaPlayer.PreparedEventArgs> Prepared {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnPreparedListener, global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnPreparedListenerImplementor>(
						ref weak_implementor_SetOnPreparedListener,
						__CreateIOnPreparedListenerImplementor,
						SetOnPreparedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnPreparedListener, global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnPreparedListenerImplementor>(
						ref weak_implementor_SetOnPreparedListener,
						global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnPreparedListenerImplementor.__IsEmpty,
						__v => SetOnPreparedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnPreparedListener;

		global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnPreparedListenerImplementor __CreateIOnPreparedListenerImplementor ()
		{
			return new global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnPreparedListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Pili.Pldroid.Player.PLMediaPlayer.IOnSeekCompleteListener"
		public event EventHandler<global::Com.Pili.Pldroid.Player.PLMediaPlayer.SeekCompleteEventArgs> SeekComplete {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnSeekCompleteListener, global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnSeekCompleteListenerImplementor>(
						ref weak_implementor_SetOnSeekCompleteListener,
						__CreateIOnSeekCompleteListenerImplementor,
						SetOnSeekCompleteListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnSeekCompleteListener, global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnSeekCompleteListenerImplementor>(
						ref weak_implementor_SetOnSeekCompleteListener,
						global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnSeekCompleteListenerImplementor.__IsEmpty,
						__v => SetOnSeekCompleteListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnSeekCompleteListener;

		global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnSeekCompleteListenerImplementor __CreateIOnSeekCompleteListenerImplementor ()
		{
			return new global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnSeekCompleteListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Pili.Pldroid.Player.PLMediaPlayer.IOnVideoSizeChangedListener"
		public event EventHandler<global::Com.Pili.Pldroid.Player.PLMediaPlayer.VideoSizeChangedEventArgs> VideoSizeChanged {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnVideoSizeChangedListener, global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnVideoSizeChangedListenerImplementor>(
						ref weak_implementor_SetOnVideoSizeChangedListener,
						__CreateIOnVideoSizeChangedListenerImplementor,
						SetOnVideoSizeChangedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnVideoSizeChangedListener, global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnVideoSizeChangedListenerImplementor>(
						ref weak_implementor_SetOnVideoSizeChangedListener,
						global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnVideoSizeChangedListenerImplementor.__IsEmpty,
						__v => SetOnVideoSizeChangedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnVideoSizeChangedListener;

		global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnVideoSizeChangedListenerImplementor __CreateIOnVideoSizeChangedListenerImplementor ()
		{
			return new global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnVideoSizeChangedListenerImplementor (this);
		}
#endregion
	}
}
