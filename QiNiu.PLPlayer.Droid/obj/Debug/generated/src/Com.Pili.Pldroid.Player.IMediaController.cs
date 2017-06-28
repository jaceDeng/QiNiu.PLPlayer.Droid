using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Pili.Pldroid.Player {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.pili.pldroid.player']/interface[@name='IMediaController.MediaPlayerControl']"
	[Register ("com/pili/pldroid/player/IMediaController$MediaPlayerControl", "", "Com.Pili.Pldroid.Player.IMediaControllerMediaPlayerControlInvoker")]
	public partial interface IMediaControllerMediaPlayerControl : IJavaObject {

		int BufferPercentage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/interface[@name='IMediaController.MediaPlayerControl']/method[@name='getBufferPercentage' and count(parameter)=0]"
			[Register ("getBufferPercentage", "()I", "GetGetBufferPercentageHandler:Com.Pili.Pldroid.Player.IMediaControllerMediaPlayerControlInvoker, QiNiu.PLPlayer.Droid")] get;
		}

		long CurrentPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/interface[@name='IMediaController.MediaPlayerControl']/method[@name='getCurrentPosition' and count(parameter)=0]"
			[Register ("getCurrentPosition", "()J", "GetGetCurrentPositionHandler:Com.Pili.Pldroid.Player.IMediaControllerMediaPlayerControlInvoker, QiNiu.PLPlayer.Droid")] get;
		}

		long Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/interface[@name='IMediaController.MediaPlayerControl']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()J", "GetGetDurationHandler:Com.Pili.Pldroid.Player.IMediaControllerMediaPlayerControlInvoker, QiNiu.PLPlayer.Droid")] get;
		}

		bool IsPlaying {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/interface[@name='IMediaController.MediaPlayerControl']/method[@name='isPlaying' and count(parameter)=0]"
			[Register ("isPlaying", "()Z", "GetIsPlayingHandler:Com.Pili.Pldroid.Player.IMediaControllerMediaPlayerControlInvoker, QiNiu.PLPlayer.Droid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/interface[@name='IMediaController.MediaPlayerControl']/method[@name='canPause' and count(parameter)=0]"
		[Register ("canPause", "()Z", "GetCanPauseHandler:Com.Pili.Pldroid.Player.IMediaControllerMediaPlayerControlInvoker, QiNiu.PLPlayer.Droid")]
		bool CanPause ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/interface[@name='IMediaController.MediaPlayerControl']/method[@name='canSeekBackward' and count(parameter)=0]"
		[Register ("canSeekBackward", "()Z", "GetCanSeekBackwardHandler:Com.Pili.Pldroid.Player.IMediaControllerMediaPlayerControlInvoker, QiNiu.PLPlayer.Droid")]
		bool CanSeekBackward ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/interface[@name='IMediaController.MediaPlayerControl']/method[@name='canSeekForward' and count(parameter)=0]"
		[Register ("canSeekForward", "()Z", "GetCanSeekForwardHandler:Com.Pili.Pldroid.Player.IMediaControllerMediaPlayerControlInvoker, QiNiu.PLPlayer.Droid")]
		bool CanSeekForward ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/interface[@name='IMediaController.MediaPlayerControl']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler:Com.Pili.Pldroid.Player.IMediaControllerMediaPlayerControlInvoker, QiNiu.PLPlayer.Droid")]
		void Pause ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/interface[@name='IMediaController.MediaPlayerControl']/method[@name='seekTo' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("seekTo", "(J)V", "GetSeekTo_JHandler:Com.Pili.Pldroid.Player.IMediaControllerMediaPlayerControlInvoker, QiNiu.PLPlayer.Droid")]
		void SeekTo (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/interface[@name='IMediaController.MediaPlayerControl']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler:Com.Pili.Pldroid.Player.IMediaControllerMediaPlayerControlInvoker, QiNiu.PLPlayer.Droid")]
		void Start ();

	}

	[global::Android.Runtime.Register ("com/pili/pldroid/player/IMediaController$MediaPlayerControl", DoNotGenerateAcw=true)]
	internal class IMediaControllerMediaPlayerControlInvoker : global::Java.Lang.Object, IMediaControllerMediaPlayerControl {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/pili/pldroid/player/IMediaController$MediaPlayerControl");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMediaControllerMediaPlayerControlInvoker); }
		}

		IntPtr class_ref;

		public static IMediaControllerMediaPlayerControl GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMediaControllerMediaPlayerControl> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.pili.pldroid.player.IMediaController.MediaPlayerControl"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMediaControllerMediaPlayerControlInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Pili.Pldroid.Player.IMediaControllerMediaPlayerControl __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.IMediaControllerMediaPlayerControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BufferPercentage;
		}
#pragma warning restore 0169

		IntPtr id_getBufferPercentage;
		public unsafe int BufferPercentage {
			get {
				if (id_getBufferPercentage == IntPtr.Zero)
					id_getBufferPercentage = JNIEnv.GetMethodID (class_ref, "getBufferPercentage", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBufferPercentage);
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
			global::Com.Pili.Pldroid.Player.IMediaControllerMediaPlayerControl __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.IMediaControllerMediaPlayerControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentPosition;
		}
#pragma warning restore 0169

		IntPtr id_getCurrentPosition;
		public unsafe long CurrentPosition {
			get {
				if (id_getCurrentPosition == IntPtr.Zero)
					id_getCurrentPosition = JNIEnv.GetMethodID (class_ref, "getCurrentPosition", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentPosition);
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
			global::Com.Pili.Pldroid.Player.IMediaControllerMediaPlayerControl __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.IMediaControllerMediaPlayerControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Duration;
		}
#pragma warning restore 0169

		IntPtr id_getDuration;
		public unsafe long Duration {
			get {
				if (id_getDuration == IntPtr.Zero)
					id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDuration);
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
			global::Com.Pili.Pldroid.Player.IMediaControllerMediaPlayerControl __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.IMediaControllerMediaPlayerControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPlaying;
		}
#pragma warning restore 0169

		IntPtr id_isPlaying;
		public unsafe bool IsPlaying {
			get {
				if (id_isPlaying == IntPtr.Zero)
					id_isPlaying = JNIEnv.GetMethodID (class_ref, "isPlaying", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPlaying);
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
			global::Com.Pili.Pldroid.Player.IMediaControllerMediaPlayerControl __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.IMediaControllerMediaPlayerControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanPause ();
		}
#pragma warning restore 0169

		IntPtr id_canPause;
		public unsafe bool CanPause ()
		{
			if (id_canPause == IntPtr.Zero)
				id_canPause = JNIEnv.GetMethodID (class_ref, "canPause", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_canPause);
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
			global::Com.Pili.Pldroid.Player.IMediaControllerMediaPlayerControl __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.IMediaControllerMediaPlayerControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanSeekBackward ();
		}
#pragma warning restore 0169

		IntPtr id_canSeekBackward;
		public unsafe bool CanSeekBackward ()
		{
			if (id_canSeekBackward == IntPtr.Zero)
				id_canSeekBackward = JNIEnv.GetMethodID (class_ref, "canSeekBackward", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_canSeekBackward);
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
			global::Com.Pili.Pldroid.Player.IMediaControllerMediaPlayerControl __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.IMediaControllerMediaPlayerControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanSeekForward ();
		}
#pragma warning restore 0169

		IntPtr id_canSeekForward;
		public unsafe bool CanSeekForward ()
		{
			if (id_canSeekForward == IntPtr.Zero)
				id_canSeekForward = JNIEnv.GetMethodID (class_ref, "canSeekForward", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_canSeekForward);
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
			global::Com.Pili.Pldroid.Player.IMediaControllerMediaPlayerControl __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.IMediaControllerMediaPlayerControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		IntPtr id_pause;
		public unsafe void Pause ()
		{
			if (id_pause == IntPtr.Zero)
				id_pause = JNIEnv.GetMethodID (class_ref, "pause", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pause);
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
			global::Com.Pili.Pldroid.Player.IMediaControllerMediaPlayerControl __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.IMediaControllerMediaPlayerControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SeekTo (p0);
		}
#pragma warning restore 0169

		IntPtr id_seekTo_J;
		public unsafe void SeekTo (long p0)
		{
			if (id_seekTo_J == IntPtr.Zero)
				id_seekTo_J = JNIEnv.GetMethodID (class_ref, "seekTo", "(J)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_seekTo_J, __args);
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
			global::Com.Pili.Pldroid.Player.IMediaControllerMediaPlayerControl __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.IMediaControllerMediaPlayerControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		IntPtr id_start;
		public unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.pili.pldroid.player']/interface[@name='IMediaController']"
	[Register ("com/pili/pldroid/player/IMediaController", "", "Com.Pili.Pldroid.Player.IMediaControllerInvoker")]
	public partial interface IMediaController : IJavaObject {

		bool IsShowing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/interface[@name='IMediaController']/method[@name='isShowing' and count(parameter)=0]"
			[Register ("isShowing", "()Z", "GetIsShowingHandler:Com.Pili.Pldroid.Player.IMediaControllerInvoker, QiNiu.PLPlayer.Droid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/interface[@name='IMediaController']/method[@name='hide' and count(parameter)=0]"
		[Register ("hide", "()V", "GetHideHandler:Com.Pili.Pldroid.Player.IMediaControllerInvoker, QiNiu.PLPlayer.Droid")]
		void Hide ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/interface[@name='IMediaController']/method[@name='setAnchorView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("setAnchorView", "(Landroid/view/View;)V", "GetSetAnchorView_Landroid_view_View_Handler:Com.Pili.Pldroid.Player.IMediaControllerInvoker, QiNiu.PLPlayer.Droid")]
		void SetAnchorView (global::Android.Views.View p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/interface[@name='IMediaController']/method[@name='setEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnabled", "(Z)V", "GetSetEnabled_ZHandler:Com.Pili.Pldroid.Player.IMediaControllerInvoker, QiNiu.PLPlayer.Droid")]
		void SetEnabled (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/interface[@name='IMediaController']/method[@name='setMediaPlayer' and count(parameter)=1 and parameter[1][@type='com.pili.pldroid.player.IMediaController.MediaPlayerControl']]"
		[Register ("setMediaPlayer", "(Lcom/pili/pldroid/player/IMediaController$MediaPlayerControl;)V", "GetSetMediaPlayer_Lcom_pili_pldroid_player_IMediaController_MediaPlayerControl_Handler:Com.Pili.Pldroid.Player.IMediaControllerInvoker, QiNiu.PLPlayer.Droid")]
		void SetMediaPlayer (global::Com.Pili.Pldroid.Player.IMediaControllerMediaPlayerControl p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/interface[@name='IMediaController']/method[@name='show' and count(parameter)=0]"
		[Register ("show", "()V", "GetShowHandler:Com.Pili.Pldroid.Player.IMediaControllerInvoker, QiNiu.PLPlayer.Droid")]
		void Show ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/interface[@name='IMediaController']/method[@name='show' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("show", "(I)V", "GetShow_IHandler:Com.Pili.Pldroid.Player.IMediaControllerInvoker, QiNiu.PLPlayer.Droid")]
		void Show (int p0);

	}

	[global::Android.Runtime.Register ("com/pili/pldroid/player/IMediaController", DoNotGenerateAcw=true)]
	internal class IMediaControllerInvoker : global::Java.Lang.Object, IMediaController {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/pili/pldroid/player/IMediaController");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMediaControllerInvoker); }
		}

		IntPtr class_ref;

		public static IMediaController GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMediaController> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.pili.pldroid.player.IMediaController"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMediaControllerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isShowing;
#pragma warning disable 0169
		static Delegate GetIsShowingHandler ()
		{
			if (cb_isShowing == null)
				cb_isShowing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsShowing);
			return cb_isShowing;
		}

		static bool n_IsShowing (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Pili.Pldroid.Player.IMediaController __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.IMediaController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsShowing;
		}
#pragma warning restore 0169

		IntPtr id_isShowing;
		public unsafe bool IsShowing {
			get {
				if (id_isShowing == IntPtr.Zero)
					id_isShowing = JNIEnv.GetMethodID (class_ref, "isShowing", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isShowing);
			}
		}

		static Delegate cb_hide;
#pragma warning disable 0169
		static Delegate GetHideHandler ()
		{
			if (cb_hide == null)
				cb_hide = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Hide);
			return cb_hide;
		}

		static void n_Hide (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Pili.Pldroid.Player.IMediaController __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.IMediaController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Hide ();
		}
#pragma warning restore 0169

		IntPtr id_hide;
		public unsafe void Hide ()
		{
			if (id_hide == IntPtr.Zero)
				id_hide = JNIEnv.GetMethodID (class_ref, "hide", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_hide);
		}

		static Delegate cb_setAnchorView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetAnchorView_Landroid_view_View_Handler ()
		{
			if (cb_setAnchorView_Landroid_view_View_ == null)
				cb_setAnchorView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAnchorView_Landroid_view_View_);
			return cb_setAnchorView_Landroid_view_View_;
		}

		static void n_SetAnchorView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Pili.Pldroid.Player.IMediaController __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.IMediaController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAnchorView (p0);
		}
#pragma warning restore 0169

		IntPtr id_setAnchorView_Landroid_view_View_;
		public unsafe void SetAnchorView (global::Android.Views.View p0)
		{
			if (id_setAnchorView_Landroid_view_View_ == IntPtr.Zero)
				id_setAnchorView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setAnchorView", "(Landroid/view/View;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAnchorView_Landroid_view_View_, __args);
		}

		static Delegate cb_setEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetEnabled_ZHandler ()
		{
			if (cb_setEnabled_Z == null)
				cb_setEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetEnabled_Z);
			return cb_setEnabled_Z;
		}

		static void n_SetEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Pili.Pldroid.Player.IMediaController __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.IMediaController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetEnabled (p0);
		}
#pragma warning restore 0169

		IntPtr id_setEnabled_Z;
		public unsafe void SetEnabled (bool p0)
		{
			if (id_setEnabled_Z == IntPtr.Zero)
				id_setEnabled_Z = JNIEnv.GetMethodID (class_ref, "setEnabled", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEnabled_Z, __args);
		}

		static Delegate cb_setMediaPlayer_Lcom_pili_pldroid_player_IMediaController_MediaPlayerControl_;
#pragma warning disable 0169
		static Delegate GetSetMediaPlayer_Lcom_pili_pldroid_player_IMediaController_MediaPlayerControl_Handler ()
		{
			if (cb_setMediaPlayer_Lcom_pili_pldroid_player_IMediaController_MediaPlayerControl_ == null)
				cb_setMediaPlayer_Lcom_pili_pldroid_player_IMediaController_MediaPlayerControl_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMediaPlayer_Lcom_pili_pldroid_player_IMediaController_MediaPlayerControl_);
			return cb_setMediaPlayer_Lcom_pili_pldroid_player_IMediaController_MediaPlayerControl_;
		}

		static void n_SetMediaPlayer_Lcom_pili_pldroid_player_IMediaController_MediaPlayerControl_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Pili.Pldroid.Player.IMediaController __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.IMediaController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Pili.Pldroid.Player.IMediaControllerMediaPlayerControl p0 = (global::Com.Pili.Pldroid.Player.IMediaControllerMediaPlayerControl)global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.IMediaControllerMediaPlayerControl> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMediaPlayer (p0);
		}
#pragma warning restore 0169

		IntPtr id_setMediaPlayer_Lcom_pili_pldroid_player_IMediaController_MediaPlayerControl_;
		public unsafe void SetMediaPlayer (global::Com.Pili.Pldroid.Player.IMediaControllerMediaPlayerControl p0)
		{
			if (id_setMediaPlayer_Lcom_pili_pldroid_player_IMediaController_MediaPlayerControl_ == IntPtr.Zero)
				id_setMediaPlayer_Lcom_pili_pldroid_player_IMediaController_MediaPlayerControl_ = JNIEnv.GetMethodID (class_ref, "setMediaPlayer", "(Lcom/pili/pldroid/player/IMediaController$MediaPlayerControl;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMediaPlayer_Lcom_pili_pldroid_player_IMediaController_MediaPlayerControl_, __args);
		}

		static Delegate cb_show;
#pragma warning disable 0169
		static Delegate GetShowHandler ()
		{
			if (cb_show == null)
				cb_show = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Show);
			return cb_show;
		}

		static void n_Show (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Pili.Pldroid.Player.IMediaController __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.IMediaController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Show ();
		}
#pragma warning restore 0169

		IntPtr id_show;
		public unsafe void Show ()
		{
			if (id_show == IntPtr.Zero)
				id_show = JNIEnv.GetMethodID (class_ref, "show", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_show);
		}

		static Delegate cb_show_I;
#pragma warning disable 0169
		static Delegate GetShow_IHandler ()
		{
			if (cb_show_I == null)
				cb_show_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Show_I);
			return cb_show_I;
		}

		static void n_Show_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Pili.Pldroid.Player.IMediaController __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.IMediaController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Show (p0);
		}
#pragma warning restore 0169

		IntPtr id_show_I;
		public unsafe void Show (int p0)
		{
			if (id_show_I == IntPtr.Zero)
				id_show_I = JNIEnv.GetMethodID (class_ref, "show", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_show_I, __args);
		}

	}

}
