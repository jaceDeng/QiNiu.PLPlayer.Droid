using System;
using System.Collections.Generic;
using Android.Runtime;

namespace TV.Danmaku.Ijk.Media.Player {

	// Metadata.xml XPath interface reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer.OnBufferingUpdateListener']"
	[Register ("tv/danmaku/ijk/media/player/IMediaPlayer$OnBufferingUpdateListener", "", "TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnBufferingUpdateListenerInvoker")]
	public partial interface IMediaPlayerOnBufferingUpdateListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer.OnBufferingUpdateListener']/method[@name='onBufferingUpdate' and count(parameter)=2 and parameter[1][@type='tv.danmaku.ijk.media.player.IMediaPlayer'] and parameter[2][@type='int']]"
		[Register ("onBufferingUpdate", "(Ltv/danmaku/ijk/media/player/IMediaPlayer;I)V", "GetOnBufferingUpdate_Ltv_danmaku_ijk_media_player_IMediaPlayer_IHandler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnBufferingUpdateListenerInvoker, QiNiu.PLPlayer.Droid")]
		void OnBufferingUpdate (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0, int p1);

	}

	[global::Android.Runtime.Register ("tv/danmaku/ijk/media/player/IMediaPlayer$OnBufferingUpdateListener", DoNotGenerateAcw=true)]
	internal class IMediaPlayerOnBufferingUpdateListenerInvoker : global::Java.Lang.Object, IMediaPlayerOnBufferingUpdateListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("tv/danmaku/ijk/media/player/IMediaPlayer$OnBufferingUpdateListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMediaPlayerOnBufferingUpdateListenerInvoker); }
		}

		IntPtr class_ref;

		public static IMediaPlayerOnBufferingUpdateListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMediaPlayerOnBufferingUpdateListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "tv.danmaku.ijk.media.player.IMediaPlayer.OnBufferingUpdateListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMediaPlayerOnBufferingUpdateListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onBufferingUpdate_Ltv_danmaku_ijk_media_player_IMediaPlayer_I;
#pragma warning disable 0169
		static Delegate GetOnBufferingUpdate_Ltv_danmaku_ijk_media_player_IMediaPlayer_IHandler ()
		{
			if (cb_onBufferingUpdate_Ltv_danmaku_ijk_media_player_IMediaPlayer_I == null)
				cb_onBufferingUpdate_Ltv_danmaku_ijk_media_player_IMediaPlayer_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnBufferingUpdate_Ltv_danmaku_ijk_media_player_IMediaPlayer_I);
			return cb_onBufferingUpdate_Ltv_danmaku_ijk_media_player_IMediaPlayer_I;
		}

		static void n_OnBufferingUpdate_Ltv_danmaku_ijk_media_player_IMediaPlayer_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnBufferingUpdateListener __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnBufferingUpdateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0 = (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer)global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBufferingUpdate (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onBufferingUpdate_Ltv_danmaku_ijk_media_player_IMediaPlayer_I;
		public unsafe void OnBufferingUpdate (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0, int p1)
		{
			if (id_onBufferingUpdate_Ltv_danmaku_ijk_media_player_IMediaPlayer_I == IntPtr.Zero)
				id_onBufferingUpdate_Ltv_danmaku_ijk_media_player_IMediaPlayer_I = JNIEnv.GetMethodID (class_ref, "onBufferingUpdate", "(Ltv/danmaku/ijk/media/player/IMediaPlayer;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBufferingUpdate_Ltv_danmaku_ijk_media_player_IMediaPlayer_I, __args);
		}

	}

	public partial class MediaPlayerOnBufferingUpdateEventArgs : global::System.EventArgs {

		public MediaPlayerOnBufferingUpdateEventArgs (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0, int p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0;
		public global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/tv/danmaku/ijk/media/player/IMediaPlayer_OnBufferingUpdateListenerImplementor")]
	internal sealed partial class IMediaPlayerOnBufferingUpdateListenerImplementor : global::Java.Lang.Object, IMediaPlayerOnBufferingUpdateListener {

		object sender;

		public IMediaPlayerOnBufferingUpdateListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/tv/danmaku/ijk/media/player/IMediaPlayer_OnBufferingUpdateListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<MediaPlayerOnBufferingUpdateEventArgs> Handler;
#pragma warning restore 0649

		public void OnBufferingUpdate (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0, int p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new MediaPlayerOnBufferingUpdateEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IMediaPlayerOnBufferingUpdateListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer.OnCompletionListener']"
	[Register ("tv/danmaku/ijk/media/player/IMediaPlayer$OnCompletionListener", "", "TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnCompletionListenerInvoker")]
	public partial interface IMediaPlayerOnCompletionListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer.OnCompletionListener']/method[@name='onCompletion' and count(parameter)=1 and parameter[1][@type='tv.danmaku.ijk.media.player.IMediaPlayer']]"
		[Register ("onCompletion", "(Ltv/danmaku/ijk/media/player/IMediaPlayer;)V", "GetOnCompletion_Ltv_danmaku_ijk_media_player_IMediaPlayer_Handler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnCompletionListenerInvoker, QiNiu.PLPlayer.Droid")]
		void OnCompletion (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0);

	}

	[global::Android.Runtime.Register ("tv/danmaku/ijk/media/player/IMediaPlayer$OnCompletionListener", DoNotGenerateAcw=true)]
	internal class IMediaPlayerOnCompletionListenerInvoker : global::Java.Lang.Object, IMediaPlayerOnCompletionListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("tv/danmaku/ijk/media/player/IMediaPlayer$OnCompletionListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMediaPlayerOnCompletionListenerInvoker); }
		}

		IntPtr class_ref;

		public static IMediaPlayerOnCompletionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMediaPlayerOnCompletionListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "tv.danmaku.ijk.media.player.IMediaPlayer.OnCompletionListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMediaPlayerOnCompletionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCompletion_Ltv_danmaku_ijk_media_player_IMediaPlayer_;
#pragma warning disable 0169
		static Delegate GetOnCompletion_Ltv_danmaku_ijk_media_player_IMediaPlayer_Handler ()
		{
			if (cb_onCompletion_Ltv_danmaku_ijk_media_player_IMediaPlayer_ == null)
				cb_onCompletion_Ltv_danmaku_ijk_media_player_IMediaPlayer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCompletion_Ltv_danmaku_ijk_media_player_IMediaPlayer_);
			return cb_onCompletion_Ltv_danmaku_ijk_media_player_IMediaPlayer_;
		}

		static void n_OnCompletion_Ltv_danmaku_ijk_media_player_IMediaPlayer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnCompletionListener __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnCompletionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0 = (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer)global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCompletion (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCompletion_Ltv_danmaku_ijk_media_player_IMediaPlayer_;
		public unsafe void OnCompletion (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0)
		{
			if (id_onCompletion_Ltv_danmaku_ijk_media_player_IMediaPlayer_ == IntPtr.Zero)
				id_onCompletion_Ltv_danmaku_ijk_media_player_IMediaPlayer_ = JNIEnv.GetMethodID (class_ref, "onCompletion", "(Ltv/danmaku/ijk/media/player/IMediaPlayer;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCompletion_Ltv_danmaku_ijk_media_player_IMediaPlayer_, __args);
		}

	}

	public partial class MediaPlayerOnCompletionEventArgs : global::System.EventArgs {

		public MediaPlayerOnCompletionEventArgs (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0)
		{
			this.p0 = p0;
		}

		global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0;
		public global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/tv/danmaku/ijk/media/player/IMediaPlayer_OnCompletionListenerImplementor")]
	internal sealed partial class IMediaPlayerOnCompletionListenerImplementor : global::Java.Lang.Object, IMediaPlayerOnCompletionListener {

		object sender;

		public IMediaPlayerOnCompletionListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/tv/danmaku/ijk/media/player/IMediaPlayer_OnCompletionListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<MediaPlayerOnCompletionEventArgs> Handler;
#pragma warning restore 0649

		public void OnCompletion (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new MediaPlayerOnCompletionEventArgs (p0));
		}

		internal static bool __IsEmpty (IMediaPlayerOnCompletionListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer.OnErrorListener']"
	[Register ("tv/danmaku/ijk/media/player/IMediaPlayer$OnErrorListener", "", "TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnErrorListenerInvoker")]
	public partial interface IMediaPlayerOnErrorListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer.OnErrorListener']/method[@name='onError' and count(parameter)=3 and parameter[1][@type='tv.danmaku.ijk.media.player.IMediaPlayer'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onError", "(Ltv/danmaku/ijk/media/player/IMediaPlayer;II)Z", "GetOnError_Ltv_danmaku_ijk_media_player_IMediaPlayer_IIHandler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnErrorListenerInvoker, QiNiu.PLPlayer.Droid")]
		bool OnError (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0, int p1, int p2);

	}

	[global::Android.Runtime.Register ("tv/danmaku/ijk/media/player/IMediaPlayer$OnErrorListener", DoNotGenerateAcw=true)]
	internal class IMediaPlayerOnErrorListenerInvoker : global::Java.Lang.Object, IMediaPlayerOnErrorListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("tv/danmaku/ijk/media/player/IMediaPlayer$OnErrorListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMediaPlayerOnErrorListenerInvoker); }
		}

		IntPtr class_ref;

		public static IMediaPlayerOnErrorListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMediaPlayerOnErrorListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "tv.danmaku.ijk.media.player.IMediaPlayer.OnErrorListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMediaPlayerOnErrorListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onError_Ltv_danmaku_ijk_media_player_IMediaPlayer_II;
#pragma warning disable 0169
		static Delegate GetOnError_Ltv_danmaku_ijk_media_player_IMediaPlayer_IIHandler ()
		{
			if (cb_onError_Ltv_danmaku_ijk_media_player_IMediaPlayer_II == null)
				cb_onError_Ltv_danmaku_ijk_media_player_IMediaPlayer_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, bool>) n_OnError_Ltv_danmaku_ijk_media_player_IMediaPlayer_II);
			return cb_onError_Ltv_danmaku_ijk_media_player_IMediaPlayer_II;
		}

		static bool n_OnError_Ltv_danmaku_ijk_media_player_IMediaPlayer_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnErrorListener __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnErrorListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0 = (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer)global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnError (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onError_Ltv_danmaku_ijk_media_player_IMediaPlayer_II;
		public unsafe bool OnError (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0, int p1, int p2)
		{
			if (id_onError_Ltv_danmaku_ijk_media_player_IMediaPlayer_II == IntPtr.Zero)
				id_onError_Ltv_danmaku_ijk_media_player_IMediaPlayer_II = JNIEnv.GetMethodID (class_ref, "onError", "(Ltv/danmaku/ijk/media/player/IMediaPlayer;II)Z");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ltv_danmaku_ijk_media_player_IMediaPlayer_II, __args);
			return __ret;
		}

	}

	public partial class MediaPlayerOnErrorEventArgs : global::System.EventArgs {

		public MediaPlayerOnErrorEventArgs (bool handled, global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0, int p1, int p2)
		{
			this.handled = handled;
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		bool handled;
		public bool Handled {
			get { return handled; }
			set { handled = value; }
		}

		global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0;
		public global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}

		int p2;
		public int P2 {
			get { return p2; }
		}
	}

	[global::Android.Runtime.Register ("mono/tv/danmaku/ijk/media/player/IMediaPlayer_OnErrorListenerImplementor")]
	internal sealed partial class IMediaPlayerOnErrorListenerImplementor : global::Java.Lang.Object, IMediaPlayerOnErrorListener {

		object sender;

		public IMediaPlayerOnErrorListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/tv/danmaku/ijk/media/player/IMediaPlayer_OnErrorListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<MediaPlayerOnErrorEventArgs> Handler;
#pragma warning restore 0649

		public bool OnError (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0, int p1, int p2)
		{
			var __h = Handler;
			if (__h == null)
				return false;
			var __e = new MediaPlayerOnErrorEventArgs (true, p0, p1, p2);
			__h (sender, __e);
			return __e.Handled;
		}

		internal static bool __IsEmpty (IMediaPlayerOnErrorListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer.OnInfoListener']"
	[Register ("tv/danmaku/ijk/media/player/IMediaPlayer$OnInfoListener", "", "TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnInfoListenerInvoker")]
	public partial interface IMediaPlayerOnInfoListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer.OnInfoListener']/method[@name='onInfo' and count(parameter)=3 and parameter[1][@type='tv.danmaku.ijk.media.player.IMediaPlayer'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onInfo", "(Ltv/danmaku/ijk/media/player/IMediaPlayer;II)Z", "GetOnInfo_Ltv_danmaku_ijk_media_player_IMediaPlayer_IIHandler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnInfoListenerInvoker, QiNiu.PLPlayer.Droid")]
		bool OnInfo (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0, int p1, int p2);

	}

	[global::Android.Runtime.Register ("tv/danmaku/ijk/media/player/IMediaPlayer$OnInfoListener", DoNotGenerateAcw=true)]
	internal class IMediaPlayerOnInfoListenerInvoker : global::Java.Lang.Object, IMediaPlayerOnInfoListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("tv/danmaku/ijk/media/player/IMediaPlayer$OnInfoListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMediaPlayerOnInfoListenerInvoker); }
		}

		IntPtr class_ref;

		public static IMediaPlayerOnInfoListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMediaPlayerOnInfoListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "tv.danmaku.ijk.media.player.IMediaPlayer.OnInfoListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMediaPlayerOnInfoListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onInfo_Ltv_danmaku_ijk_media_player_IMediaPlayer_II;
#pragma warning disable 0169
		static Delegate GetOnInfo_Ltv_danmaku_ijk_media_player_IMediaPlayer_IIHandler ()
		{
			if (cb_onInfo_Ltv_danmaku_ijk_media_player_IMediaPlayer_II == null)
				cb_onInfo_Ltv_danmaku_ijk_media_player_IMediaPlayer_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, bool>) n_OnInfo_Ltv_danmaku_ijk_media_player_IMediaPlayer_II);
			return cb_onInfo_Ltv_danmaku_ijk_media_player_IMediaPlayer_II;
		}

		static bool n_OnInfo_Ltv_danmaku_ijk_media_player_IMediaPlayer_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnInfoListener __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnInfoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0 = (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer)global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnInfo (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onInfo_Ltv_danmaku_ijk_media_player_IMediaPlayer_II;
		public unsafe bool OnInfo (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0, int p1, int p2)
		{
			if (id_onInfo_Ltv_danmaku_ijk_media_player_IMediaPlayer_II == IntPtr.Zero)
				id_onInfo_Ltv_danmaku_ijk_media_player_IMediaPlayer_II = JNIEnv.GetMethodID (class_ref, "onInfo", "(Ltv/danmaku/ijk/media/player/IMediaPlayer;II)Z");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onInfo_Ltv_danmaku_ijk_media_player_IMediaPlayer_II, __args);
			return __ret;
		}

	}

	public partial class MediaPlayerOnInfoEventArgs : global::System.EventArgs {

		public MediaPlayerOnInfoEventArgs (bool handled, global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0, int p1, int p2)
		{
			this.handled = handled;
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		bool handled;
		public bool Handled {
			get { return handled; }
			set { handled = value; }
		}

		global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0;
		public global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}

		int p2;
		public int P2 {
			get { return p2; }
		}
	}

	[global::Android.Runtime.Register ("mono/tv/danmaku/ijk/media/player/IMediaPlayer_OnInfoListenerImplementor")]
	internal sealed partial class IMediaPlayerOnInfoListenerImplementor : global::Java.Lang.Object, IMediaPlayerOnInfoListener {

		object sender;

		public IMediaPlayerOnInfoListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/tv/danmaku/ijk/media/player/IMediaPlayer_OnInfoListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<MediaPlayerOnInfoEventArgs> Handler;
#pragma warning restore 0649

		public bool OnInfo (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0, int p1, int p2)
		{
			var __h = Handler;
			if (__h == null)
				return false;
			var __e = new MediaPlayerOnInfoEventArgs (true, p0, p1, p2);
			__h (sender, __e);
			return __e.Handled;
		}

		internal static bool __IsEmpty (IMediaPlayerOnInfoListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer.OnPreparedListener']"
	[Register ("tv/danmaku/ijk/media/player/IMediaPlayer$OnPreparedListener", "", "TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnPreparedListenerInvoker")]
	public partial interface IMediaPlayerOnPreparedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer.OnPreparedListener']/method[@name='onPrepared' and count(parameter)=1 and parameter[1][@type='tv.danmaku.ijk.media.player.IMediaPlayer']]"
		[Register ("onPrepared", "(Ltv/danmaku/ijk/media/player/IMediaPlayer;)V", "GetOnPrepared_Ltv_danmaku_ijk_media_player_IMediaPlayer_Handler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnPreparedListenerInvoker, QiNiu.PLPlayer.Droid")]
		void OnPrepared (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0);

	}

	[global::Android.Runtime.Register ("tv/danmaku/ijk/media/player/IMediaPlayer$OnPreparedListener", DoNotGenerateAcw=true)]
	internal class IMediaPlayerOnPreparedListenerInvoker : global::Java.Lang.Object, IMediaPlayerOnPreparedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("tv/danmaku/ijk/media/player/IMediaPlayer$OnPreparedListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMediaPlayerOnPreparedListenerInvoker); }
		}

		IntPtr class_ref;

		public static IMediaPlayerOnPreparedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMediaPlayerOnPreparedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "tv.danmaku.ijk.media.player.IMediaPlayer.OnPreparedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMediaPlayerOnPreparedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onPrepared_Ltv_danmaku_ijk_media_player_IMediaPlayer_;
#pragma warning disable 0169
		static Delegate GetOnPrepared_Ltv_danmaku_ijk_media_player_IMediaPlayer_Handler ()
		{
			if (cb_onPrepared_Ltv_danmaku_ijk_media_player_IMediaPlayer_ == null)
				cb_onPrepared_Ltv_danmaku_ijk_media_player_IMediaPlayer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPrepared_Ltv_danmaku_ijk_media_player_IMediaPlayer_);
			return cb_onPrepared_Ltv_danmaku_ijk_media_player_IMediaPlayer_;
		}

		static void n_OnPrepared_Ltv_danmaku_ijk_media_player_IMediaPlayer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnPreparedListener __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnPreparedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0 = (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer)global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPrepared (p0);
		}
#pragma warning restore 0169

		IntPtr id_onPrepared_Ltv_danmaku_ijk_media_player_IMediaPlayer_;
		public unsafe void OnPrepared (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0)
		{
			if (id_onPrepared_Ltv_danmaku_ijk_media_player_IMediaPlayer_ == IntPtr.Zero)
				id_onPrepared_Ltv_danmaku_ijk_media_player_IMediaPlayer_ = JNIEnv.GetMethodID (class_ref, "onPrepared", "(Ltv/danmaku/ijk/media/player/IMediaPlayer;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPrepared_Ltv_danmaku_ijk_media_player_IMediaPlayer_, __args);
		}

	}

	public partial class MediaPlayerOnPreparedEventArgs : global::System.EventArgs {

		public MediaPlayerOnPreparedEventArgs (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0)
		{
			this.p0 = p0;
		}

		global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0;
		public global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/tv/danmaku/ijk/media/player/IMediaPlayer_OnPreparedListenerImplementor")]
	internal sealed partial class IMediaPlayerOnPreparedListenerImplementor : global::Java.Lang.Object, IMediaPlayerOnPreparedListener {

		object sender;

		public IMediaPlayerOnPreparedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/tv/danmaku/ijk/media/player/IMediaPlayer_OnPreparedListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<MediaPlayerOnPreparedEventArgs> Handler;
#pragma warning restore 0649

		public void OnPrepared (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new MediaPlayerOnPreparedEventArgs (p0));
		}

		internal static bool __IsEmpty (IMediaPlayerOnPreparedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer.OnSeekCompleteListener']"
	[Register ("tv/danmaku/ijk/media/player/IMediaPlayer$OnSeekCompleteListener", "", "TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnSeekCompleteListenerInvoker")]
	public partial interface IMediaPlayerOnSeekCompleteListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer.OnSeekCompleteListener']/method[@name='onSeekComplete' and count(parameter)=1 and parameter[1][@type='tv.danmaku.ijk.media.player.IMediaPlayer']]"
		[Register ("onSeekComplete", "(Ltv/danmaku/ijk/media/player/IMediaPlayer;)V", "GetOnSeekComplete_Ltv_danmaku_ijk_media_player_IMediaPlayer_Handler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnSeekCompleteListenerInvoker, QiNiu.PLPlayer.Droid")]
		void OnSeekComplete (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0);

	}

	[global::Android.Runtime.Register ("tv/danmaku/ijk/media/player/IMediaPlayer$OnSeekCompleteListener", DoNotGenerateAcw=true)]
	internal class IMediaPlayerOnSeekCompleteListenerInvoker : global::Java.Lang.Object, IMediaPlayerOnSeekCompleteListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("tv/danmaku/ijk/media/player/IMediaPlayer$OnSeekCompleteListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMediaPlayerOnSeekCompleteListenerInvoker); }
		}

		IntPtr class_ref;

		public static IMediaPlayerOnSeekCompleteListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMediaPlayerOnSeekCompleteListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "tv.danmaku.ijk.media.player.IMediaPlayer.OnSeekCompleteListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMediaPlayerOnSeekCompleteListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onSeekComplete_Ltv_danmaku_ijk_media_player_IMediaPlayer_;
#pragma warning disable 0169
		static Delegate GetOnSeekComplete_Ltv_danmaku_ijk_media_player_IMediaPlayer_Handler ()
		{
			if (cb_onSeekComplete_Ltv_danmaku_ijk_media_player_IMediaPlayer_ == null)
				cb_onSeekComplete_Ltv_danmaku_ijk_media_player_IMediaPlayer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSeekComplete_Ltv_danmaku_ijk_media_player_IMediaPlayer_);
			return cb_onSeekComplete_Ltv_danmaku_ijk_media_player_IMediaPlayer_;
		}

		static void n_OnSeekComplete_Ltv_danmaku_ijk_media_player_IMediaPlayer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnSeekCompleteListener __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnSeekCompleteListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0 = (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer)global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSeekComplete (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSeekComplete_Ltv_danmaku_ijk_media_player_IMediaPlayer_;
		public unsafe void OnSeekComplete (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0)
		{
			if (id_onSeekComplete_Ltv_danmaku_ijk_media_player_IMediaPlayer_ == IntPtr.Zero)
				id_onSeekComplete_Ltv_danmaku_ijk_media_player_IMediaPlayer_ = JNIEnv.GetMethodID (class_ref, "onSeekComplete", "(Ltv/danmaku/ijk/media/player/IMediaPlayer;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSeekComplete_Ltv_danmaku_ijk_media_player_IMediaPlayer_, __args);
		}

	}

	public partial class MediaPlayerOnSeekCompleteEventArgs : global::System.EventArgs {

		public MediaPlayerOnSeekCompleteEventArgs (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0)
		{
			this.p0 = p0;
		}

		global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0;
		public global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/tv/danmaku/ijk/media/player/IMediaPlayer_OnSeekCompleteListenerImplementor")]
	internal sealed partial class IMediaPlayerOnSeekCompleteListenerImplementor : global::Java.Lang.Object, IMediaPlayerOnSeekCompleteListener {

		object sender;

		public IMediaPlayerOnSeekCompleteListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/tv/danmaku/ijk/media/player/IMediaPlayer_OnSeekCompleteListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<MediaPlayerOnSeekCompleteEventArgs> Handler;
#pragma warning restore 0649

		public void OnSeekComplete (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new MediaPlayerOnSeekCompleteEventArgs (p0));
		}

		internal static bool __IsEmpty (IMediaPlayerOnSeekCompleteListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer.OnVideoSizeChangedListener']"
	[Register ("tv/danmaku/ijk/media/player/IMediaPlayer$OnVideoSizeChangedListener", "", "TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnVideoSizeChangedListenerInvoker")]
	public partial interface IMediaPlayerOnVideoSizeChangedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer.OnVideoSizeChangedListener']/method[@name='onVideoSizeChanged' and count(parameter)=5 and parameter[1][@type='tv.danmaku.ijk.media.player.IMediaPlayer'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onVideoSizeChanged", "(Ltv/danmaku/ijk/media/player/IMediaPlayer;IIII)V", "GetOnVideoSizeChanged_Ltv_danmaku_ijk_media_player_IMediaPlayer_IIIIHandler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnVideoSizeChangedListenerInvoker, QiNiu.PLPlayer.Droid")]
		void OnVideoSizeChanged (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0, int p1, int p2, int p3, int p4);

	}

	[global::Android.Runtime.Register ("tv/danmaku/ijk/media/player/IMediaPlayer$OnVideoSizeChangedListener", DoNotGenerateAcw=true)]
	internal class IMediaPlayerOnVideoSizeChangedListenerInvoker : global::Java.Lang.Object, IMediaPlayerOnVideoSizeChangedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("tv/danmaku/ijk/media/player/IMediaPlayer$OnVideoSizeChangedListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMediaPlayerOnVideoSizeChangedListenerInvoker); }
		}

		IntPtr class_ref;

		public static IMediaPlayerOnVideoSizeChangedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMediaPlayerOnVideoSizeChangedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "tv.danmaku.ijk.media.player.IMediaPlayer.OnVideoSizeChangedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMediaPlayerOnVideoSizeChangedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onVideoSizeChanged_Ltv_danmaku_ijk_media_player_IMediaPlayer_IIII;
#pragma warning disable 0169
		static Delegate GetOnVideoSizeChanged_Ltv_danmaku_ijk_media_player_IMediaPlayer_IIIIHandler ()
		{
			if (cb_onVideoSizeChanged_Ltv_danmaku_ijk_media_player_IMediaPlayer_IIII == null)
				cb_onVideoSizeChanged_Ltv_danmaku_ijk_media_player_IMediaPlayer_IIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int, int>) n_OnVideoSizeChanged_Ltv_danmaku_ijk_media_player_IMediaPlayer_IIII);
			return cb_onVideoSizeChanged_Ltv_danmaku_ijk_media_player_IMediaPlayer_IIII;
		}

		static void n_OnVideoSizeChanged_Ltv_danmaku_ijk_media_player_IMediaPlayer_IIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnVideoSizeChangedListener __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnVideoSizeChangedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0 = (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer)global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnVideoSizeChanged (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_onVideoSizeChanged_Ltv_danmaku_ijk_media_player_IMediaPlayer_IIII;
		public unsafe void OnVideoSizeChanged (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0, int p1, int p2, int p3, int p4)
		{
			if (id_onVideoSizeChanged_Ltv_danmaku_ijk_media_player_IMediaPlayer_IIII == IntPtr.Zero)
				id_onVideoSizeChanged_Ltv_danmaku_ijk_media_player_IMediaPlayer_IIII = JNIEnv.GetMethodID (class_ref, "onVideoSizeChanged", "(Ltv/danmaku/ijk/media/player/IMediaPlayer;IIII)V");
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onVideoSizeChanged_Ltv_danmaku_ijk_media_player_IMediaPlayer_IIII, __args);
		}

	}

	public partial class MediaPlayerOnVideoSizeChangedEventArgs : global::System.EventArgs {

		public MediaPlayerOnVideoSizeChangedEventArgs (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0, int p1, int p2, int p3, int p4)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
			this.p4 = p4;
		}

		global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0;
		public global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}

		int p2;
		public int P2 {
			get { return p2; }
		}

		int p3;
		public int P3 {
			get { return p3; }
		}

		int p4;
		public int P4 {
			get { return p4; }
		}
	}

	[global::Android.Runtime.Register ("mono/tv/danmaku/ijk/media/player/IMediaPlayer_OnVideoSizeChangedListenerImplementor")]
	internal sealed partial class IMediaPlayerOnVideoSizeChangedListenerImplementor : global::Java.Lang.Object, IMediaPlayerOnVideoSizeChangedListener {

		object sender;

		public IMediaPlayerOnVideoSizeChangedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/tv/danmaku/ijk/media/player/IMediaPlayer_OnVideoSizeChangedListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<MediaPlayerOnVideoSizeChangedEventArgs> Handler;
#pragma warning restore 0649

		public void OnVideoSizeChanged (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0, int p1, int p2, int p3, int p4)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new MediaPlayerOnVideoSizeChangedEventArgs (p0, p1, p2, p3, p4));
		}

		internal static bool __IsEmpty (IMediaPlayerOnVideoSizeChangedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	[Register ("tv/danmaku/ijk/media/player/IMediaPlayer", DoNotGenerateAcw=true)]
	public abstract class MediaPlayer : Java.Lang.Object {

		internal MediaPlayer ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_ERROR_IO']"
		[Register ("MEDIA_ERROR_IO")]
		public const int MediaErrorIo = (int) -1004;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_ERROR_MALFORMED']"
		[Register ("MEDIA_ERROR_MALFORMED")]
		public const int MediaErrorMalformed = (int) -1007;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_ERROR_NOT_VALID_FOR_PROGRESSIVE_PLAYBACK']"
		[Register ("MEDIA_ERROR_NOT_VALID_FOR_PROGRESSIVE_PLAYBACK")]
		public const int MediaErrorNotValidForProgressivePlayback = (int) 200;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_ERROR_SERVER_DIED']"
		[Register ("MEDIA_ERROR_SERVER_DIED")]
		public const int MediaErrorServerDied = (int) 100;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_ERROR_TIMED_OUT']"
		[Register ("MEDIA_ERROR_TIMED_OUT")]
		public const int MediaErrorTimedOut = (int) -110;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_ERROR_UNKNOWN']"
		[Register ("MEDIA_ERROR_UNKNOWN")]
		public const int MediaErrorUnknown = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_ERROR_UNSUPPORTED']"
		[Register ("MEDIA_ERROR_UNSUPPORTED")]
		public const int MediaErrorUnsupported = (int) -1010;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_AUDIO_FRAME_RENDERING']"
		[Register ("MEDIA_INFO_AUDIO_FRAME_RENDERING")]
		public const int MediaInfoAudioFrameRendering = (int) 10005;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_AUDIO_RENDERING_START']"
		[Register ("MEDIA_INFO_AUDIO_RENDERING_START")]
		public const int MediaInfoAudioRenderingStart = (int) 10002;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_BAD_INTERLEAVING']"
		[Register ("MEDIA_INFO_BAD_INTERLEAVING")]
		public const int MediaInfoBadInterleaving = (int) 800;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_BUFFERING_END']"
		[Register ("MEDIA_INFO_BUFFERING_END")]
		public const int MediaInfoBufferingEnd = (int) 702;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_BUFFERING_START']"
		[Register ("MEDIA_INFO_BUFFERING_START")]
		public const int MediaInfoBufferingStart = (int) 701;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_METADATA_UPDATE']"
		[Register ("MEDIA_INFO_METADATA_UPDATE")]
		public const int MediaInfoMetadataUpdate = (int) 802;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_NETWORK_BANDWIDTH']"
		[Register ("MEDIA_INFO_NETWORK_BANDWIDTH")]
		public const int MediaInfoNetworkBandwidth = (int) 703;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_NOT_SEEKABLE']"
		[Register ("MEDIA_INFO_NOT_SEEKABLE")]
		public const int MediaInfoNotSeekable = (int) 801;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_STARTED_AS_NEXT']"
		[Register ("MEDIA_INFO_STARTED_AS_NEXT")]
		public const int MediaInfoStartedAsNext = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_SUBTITLE_TIMED_OUT']"
		[Register ("MEDIA_INFO_SUBTITLE_TIMED_OUT")]
		public const int MediaInfoSubtitleTimedOut = (int) 902;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_TIMED_TEXT_ERROR']"
		[Register ("MEDIA_INFO_TIMED_TEXT_ERROR")]
		public const int MediaInfoTimedTextError = (int) 900;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_UNKNOWN']"
		[Register ("MEDIA_INFO_UNKNOWN")]
		public const int MediaInfoUnknown = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_UNSUPPORTED_SUBTITLE']"
		[Register ("MEDIA_INFO_UNSUPPORTED_SUBTITLE")]
		public const int MediaInfoUnsupportedSubtitle = (int) 901;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_VIDEO_FRAME_RENDERING']"
		[Register ("MEDIA_INFO_VIDEO_FRAME_RENDERING")]
		public const int MediaInfoVideoFrameRendering = (int) 10004;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_VIDEO_GOP_TIME']"
		[Register ("MEDIA_INFO_VIDEO_GOP_TIME")]
		public const int MediaInfoVideoGopTime = (int) 10003;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_VIDEO_RENDERING_START']"
		[Register ("MEDIA_INFO_VIDEO_RENDERING_START")]
		public const int MediaInfoVideoRenderingStart = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_VIDEO_ROTATION_CHANGED']"
		[Register ("MEDIA_INFO_VIDEO_ROTATION_CHANGED")]
		public const int MediaInfoVideoRotationChanged = (int) 10001;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_VIDEO_TRACK_LAGGING']"
		[Register ("MEDIA_INFO_VIDEO_TRACK_LAGGING")]
		public const int MediaInfoVideoTrackLagging = (int) 700;
	}

	[Register ("tv/danmaku/ijk/media/player/IMediaPlayer", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'MediaPlayer' type. This type will be removed in a future release.")]
	public abstract class MediaPlayerConsts : MediaPlayer {

		private MediaPlayerConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']"
	[Register ("tv/danmaku/ijk/media/player/IMediaPlayer", "", "TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker")]
	public partial interface IMediaPlayer : IJavaObject {

		int AudioSessionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='getAudioSessionId' and count(parameter)=0]"
			[Register ("getAudioSessionId", "()I", "GetGetAudioSessionIdHandler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")] get;
		}

		long CurrentPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='getCurrentPosition' and count(parameter)=0]"
			[Register ("getCurrentPosition", "()J", "GetGetCurrentPositionHandler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")] get;
		}

		string DataSource {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='getDataSource' and count(parameter)=0]"
			[Register ("getDataSource", "()Ljava/lang/String;", "GetGetDataSourceHandler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='setDataSource' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDataSource", "(Ljava/lang/String;)V", "GetSetDataSource_Ljava_lang_String_Handler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")] set;
		}

		long Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()J", "GetGetDurationHandler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")] get;
		}

		bool IsPlayable {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='isPlayable' and count(parameter)=0]"
			[Register ("isPlayable", "()Z", "GetIsPlayableHandler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")] get;
		}

		bool IsPlaying {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='isPlaying' and count(parameter)=0]"
			[Register ("isPlaying", "()Z", "GetIsPlayingHandler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")] get;
		}

		bool Looping {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='isLooping' and count(parameter)=0]"
			[Register ("isLooping", "()Z", "GetIsLoopingHandler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='setLooping' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setLooping", "(Z)V", "GetSetLooping_ZHandler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")] set;
		}

		global::TV.Danmaku.Ijk.Media.Player.MediaInfo MediaInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='getMediaInfo' and count(parameter)=0]"
			[Register ("getMediaInfo", "()Ltv/danmaku/ijk/media/player/MediaInfo;", "GetGetMediaInfoHandler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")] get;
		}

		int VideoHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='getVideoHeight' and count(parameter)=0]"
			[Register ("getVideoHeight", "()I", "GetGetVideoHeightHandler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")] get;
		}

		int VideoSarDen {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='getVideoSarDen' and count(parameter)=0]"
			[Register ("getVideoSarDen", "()I", "GetGetVideoSarDenHandler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")] get;
		}

		int VideoSarNum {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='getVideoSarNum' and count(parameter)=0]"
			[Register ("getVideoSarNum", "()I", "GetGetVideoSarNumHandler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")] get;
		}

		int VideoWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='getVideoWidth' and count(parameter)=0]"
			[Register ("getVideoWidth", "()I", "GetGetVideoWidthHandler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='getTrackInfo' and count(parameter)=0]"
		[Register ("getTrackInfo", "()[Ltv/danmaku/ijk/media/player/misc/ITrackInfo;", "GetGetTrackInfoHandler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")]
		global::TV.Danmaku.Ijk.Media.Player.Misc.ITrackInfo[] GetTrackInfo ();

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")]
		void Pause ();

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='prepareAsync' and count(parameter)=0]"
		[Register ("prepareAsync", "()V", "GetPrepareAsyncHandler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")]
		void PrepareAsync ();

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")]
		void Release ();

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")]
		void Reset ();

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='seekTo' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("seekTo", "(J)V", "GetSeekTo_JHandler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")]
		void SeekTo (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='setAudioStreamType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAudioStreamType", "(I)V", "GetSetAudioStreamType_IHandler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")]
		void SetAudioStreamType (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='setDataSource' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
		[Register ("setDataSource", "(Landroid/content/Context;Landroid/net/Uri;)V", "GetSetDataSource_Landroid_content_Context_Landroid_net_Uri_Handler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")]
		void SetDataSource (global::Android.Content.Context p0, global::Android.Net.Uri p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='setDataSource' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("setDataSource", "(Landroid/content/Context;Landroid/net/Uri;Ljava/util/Map;)V", "GetSetDataSource_Landroid_content_Context_Landroid_net_Uri_Ljava_util_Map_Handler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")]
		void SetDataSource (global::Android.Content.Context p0, global::Android.Net.Uri p1, global::System.Collections.Generic.IDictionary<string, string> p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='setDataSource' and count(parameter)=1 and parameter[1][@type='java.io.FileDescriptor']]"
		[Register ("setDataSource", "(Ljava/io/FileDescriptor;)V", "GetSetDataSource_Ljava_io_FileDescriptor_Handler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")]
		void SetDataSource (global::Java.IO.FileDescriptor p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='setDataSource' and count(parameter)=1 and parameter[1][@type='tv.danmaku.ijk.media.player.misc.IMediaDataSource']]"
		[Register ("setDataSource", "(Ltv/danmaku/ijk/media/player/misc/IMediaDataSource;)V", "GetSetDataSource_Ltv_danmaku_ijk_media_player_misc_IMediaDataSource_Handler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")]
		void SetDataSource (global::TV.Danmaku.Ijk.Media.Player.Misc.IMediaDataSource p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='setDisplay' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
		[Register ("setDisplay", "(Landroid/view/SurfaceHolder;)V", "GetSetDisplay_Landroid_view_SurfaceHolder_Handler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")]
		void SetDisplay (global::Android.Views.ISurfaceHolder p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='setKeepInBackground' and count(parameter)=1 and parameter[1][@type='boolean']]"
[Obsolete (@"deprecated")]
		[Register ("setKeepInBackground", "(Z)V", "GetSetKeepInBackground_ZHandler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")]
		void SetKeepInBackground (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='setLogEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
[Obsolete (@"deprecated")]
		[Register ("setLogEnabled", "(Z)V", "GetSetLogEnabled_ZHandler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")]
		void SetLogEnabled (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='setOnBufferingUpdateListener' and count(parameter)=1 and parameter[1][@type='tv.danmaku.ijk.media.player.IMediaPlayer.OnBufferingUpdateListener']]"
		[Register ("setOnBufferingUpdateListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnBufferingUpdateListener;)V", "GetSetOnBufferingUpdateListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnBufferingUpdateListener_Handler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")]
		void SetOnBufferingUpdateListener (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnBufferingUpdateListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='setOnCompletionListener' and count(parameter)=1 and parameter[1][@type='tv.danmaku.ijk.media.player.IMediaPlayer.OnCompletionListener']]"
		[Register ("setOnCompletionListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnCompletionListener;)V", "GetSetOnCompletionListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnCompletionListener_Handler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")]
		void SetOnCompletionListener (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnCompletionListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='setOnErrorListener' and count(parameter)=1 and parameter[1][@type='tv.danmaku.ijk.media.player.IMediaPlayer.OnErrorListener']]"
		[Register ("setOnErrorListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnErrorListener;)V", "GetSetOnErrorListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnErrorListener_Handler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")]
		void SetOnErrorListener (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnErrorListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='setOnInfoListener' and count(parameter)=1 and parameter[1][@type='tv.danmaku.ijk.media.player.IMediaPlayer.OnInfoListener']]"
		[Register ("setOnInfoListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnInfoListener;)V", "GetSetOnInfoListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnInfoListener_Handler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")]
		void SetOnInfoListener (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnInfoListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='setOnPreparedListener' and count(parameter)=1 and parameter[1][@type='tv.danmaku.ijk.media.player.IMediaPlayer.OnPreparedListener']]"
		[Register ("setOnPreparedListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnPreparedListener;)V", "GetSetOnPreparedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnPreparedListener_Handler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")]
		void SetOnPreparedListener (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnPreparedListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='setOnSeekCompleteListener' and count(parameter)=1 and parameter[1][@type='tv.danmaku.ijk.media.player.IMediaPlayer.OnSeekCompleteListener']]"
		[Register ("setOnSeekCompleteListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnSeekCompleteListener;)V", "GetSetOnSeekCompleteListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnSeekCompleteListener_Handler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")]
		void SetOnSeekCompleteListener (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnSeekCompleteListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='setOnVideoSizeChangedListener' and count(parameter)=1 and parameter[1][@type='tv.danmaku.ijk.media.player.IMediaPlayer.OnVideoSizeChangedListener']]"
		[Register ("setOnVideoSizeChangedListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnVideoSizeChangedListener;)V", "GetSetOnVideoSizeChangedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnVideoSizeChangedListener_Handler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")]
		void SetOnVideoSizeChangedListener (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnVideoSizeChangedListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='setScreenOnWhilePlaying' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setScreenOnWhilePlaying", "(Z)V", "GetSetScreenOnWhilePlaying_ZHandler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")]
		void SetScreenOnWhilePlaying (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='setSurface' and count(parameter)=1 and parameter[1][@type='android.view.Surface']]"
		[Register ("setSurface", "(Landroid/view/Surface;)V", "GetSetSurface_Landroid_view_Surface_Handler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")]
		void SetSurface (global::Android.Views.Surface p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='setVolume' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setVolume", "(FF)V", "GetSetVolume_FFHandler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")]
		void SetVolume (float p0, float p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='setWakeMode' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
[Obsolete (@"deprecated")]
		[Register ("setWakeMode", "(Landroid/content/Context;I)V", "GetSetWakeMode_Landroid_content_Context_IHandler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")]
		void SetWakeMode (global::Android.Content.Context p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")]
		void Start ();

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler:TV.Danmaku.Ijk.Media.Player.IMediaPlayerInvoker, QiNiu.PLPlayer.Droid")]
		void Stop ();

	}

	[global::Android.Runtime.Register ("tv/danmaku/ijk/media/player/IMediaPlayer", DoNotGenerateAcw=true)]
	internal class IMediaPlayerInvoker : global::Java.Lang.Object, IMediaPlayer {

		static IntPtr java_class_ref = JNIEnv.FindClass ("tv/danmaku/ijk/media/player/IMediaPlayer");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMediaPlayerInvoker); }
		}

		IntPtr class_ref;

		public static IMediaPlayer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMediaPlayer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "tv.danmaku.ijk.media.player.IMediaPlayer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMediaPlayerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAudioSessionId;
#pragma warning disable 0169
		static Delegate GetGetAudioSessionIdHandler ()
		{
			if (cb_getAudioSessionId == null)
				cb_getAudioSessionId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAudioSessionId);
			return cb_getAudioSessionId;
		}

		static int n_GetAudioSessionId (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AudioSessionId;
		}
#pragma warning restore 0169

		IntPtr id_getAudioSessionId;
		public unsafe int AudioSessionId {
			get {
				if (id_getAudioSessionId == IntPtr.Zero)
					id_getAudioSessionId = JNIEnv.GetMethodID (class_ref, "getAudioSessionId", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAudioSessionId);
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
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getDataSource;
#pragma warning disable 0169
		static Delegate GetGetDataSourceHandler ()
		{
			if (cb_getDataSource == null)
				cb_getDataSource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDataSource);
			return cb_getDataSource;
		}

		static IntPtr n_GetDataSource (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DataSource);
		}
#pragma warning restore 0169

		static Delegate cb_setDataSource_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDataSource_Ljava_lang_String_Handler ()
		{
			if (cb_setDataSource_Ljava_lang_String_ == null)
				cb_setDataSource_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDataSource_Ljava_lang_String_);
			return cb_setDataSource_Ljava_lang_String_;
		}

		static void n_SetDataSource_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DataSource = p0;
		}
#pragma warning restore 0169

		IntPtr id_getDataSource;
		IntPtr id_setDataSource_Ljava_lang_String_;
		public unsafe string DataSource {
			get {
				if (id_getDataSource == IntPtr.Zero)
					id_getDataSource = JNIEnv.GetMethodID (class_ref, "getDataSource", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDataSource), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setDataSource_Ljava_lang_String_ == IntPtr.Zero)
					id_setDataSource_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDataSource", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDataSource_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
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
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_isPlayable;
#pragma warning disable 0169
		static Delegate GetIsPlayableHandler ()
		{
			if (cb_isPlayable == null)
				cb_isPlayable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPlayable);
			return cb_isPlayable;
		}

		static bool n_IsPlayable (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPlayable;
		}
#pragma warning restore 0169

		IntPtr id_isPlayable;
		public unsafe bool IsPlayable {
			get {
				if (id_isPlayable == IntPtr.Zero)
					id_isPlayable = JNIEnv.GetMethodID (class_ref, "isPlayable", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPlayable);
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
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Looping = p0;
		}
#pragma warning restore 0169

		IntPtr id_isLooping;
		IntPtr id_setLooping_Z;
		public unsafe bool Looping {
			get {
				if (id_isLooping == IntPtr.Zero)
					id_isLooping = JNIEnv.GetMethodID (class_ref, "isLooping", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLooping);
			}
			set {
				if (id_setLooping_Z == IntPtr.Zero)
					id_setLooping_Z = JNIEnv.GetMethodID (class_ref, "setLooping", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLooping_Z, __args);
			}
		}

		static Delegate cb_getMediaInfo;
#pragma warning disable 0169
		static Delegate GetGetMediaInfoHandler ()
		{
			if (cb_getMediaInfo == null)
				cb_getMediaInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMediaInfo);
			return cb_getMediaInfo;
		}

		static IntPtr n_GetMediaInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MediaInfo);
		}
#pragma warning restore 0169

		IntPtr id_getMediaInfo;
		public unsafe global::TV.Danmaku.Ijk.Media.Player.MediaInfo MediaInfo {
			get {
				if (id_getMediaInfo == IntPtr.Zero)
					id_getMediaInfo = JNIEnv.GetMethodID (class_ref, "getMediaInfo", "()Ltv/danmaku/ijk/media/player/MediaInfo;");
				return global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMediaInfo), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getVideoHeight;
#pragma warning disable 0169
		static Delegate GetGetVideoHeightHandler ()
		{
			if (cb_getVideoHeight == null)
				cb_getVideoHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVideoHeight);
			return cb_getVideoHeight;
		}

		static int n_GetVideoHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoHeight;
		}
#pragma warning restore 0169

		IntPtr id_getVideoHeight;
		public unsafe int VideoHeight {
			get {
				if (id_getVideoHeight == IntPtr.Zero)
					id_getVideoHeight = JNIEnv.GetMethodID (class_ref, "getVideoHeight", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getVideoHeight);
			}
		}

		static Delegate cb_getVideoSarDen;
#pragma warning disable 0169
		static Delegate GetGetVideoSarDenHandler ()
		{
			if (cb_getVideoSarDen == null)
				cb_getVideoSarDen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVideoSarDen);
			return cb_getVideoSarDen;
		}

		static int n_GetVideoSarDen (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoSarDen;
		}
#pragma warning restore 0169

		IntPtr id_getVideoSarDen;
		public unsafe int VideoSarDen {
			get {
				if (id_getVideoSarDen == IntPtr.Zero)
					id_getVideoSarDen = JNIEnv.GetMethodID (class_ref, "getVideoSarDen", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getVideoSarDen);
			}
		}

		static Delegate cb_getVideoSarNum;
#pragma warning disable 0169
		static Delegate GetGetVideoSarNumHandler ()
		{
			if (cb_getVideoSarNum == null)
				cb_getVideoSarNum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVideoSarNum);
			return cb_getVideoSarNum;
		}

		static int n_GetVideoSarNum (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoSarNum;
		}
#pragma warning restore 0169

		IntPtr id_getVideoSarNum;
		public unsafe int VideoSarNum {
			get {
				if (id_getVideoSarNum == IntPtr.Zero)
					id_getVideoSarNum = JNIEnv.GetMethodID (class_ref, "getVideoSarNum", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getVideoSarNum);
			}
		}

		static Delegate cb_getVideoWidth;
#pragma warning disable 0169
		static Delegate GetGetVideoWidthHandler ()
		{
			if (cb_getVideoWidth == null)
				cb_getVideoWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVideoWidth);
			return cb_getVideoWidth;
		}

		static int n_GetVideoWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoWidth;
		}
#pragma warning restore 0169

		IntPtr id_getVideoWidth;
		public unsafe int VideoWidth {
			get {
				if (id_getVideoWidth == IntPtr.Zero)
					id_getVideoWidth = JNIEnv.GetMethodID (class_ref, "getVideoWidth", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getVideoWidth);
			}
		}

		static Delegate cb_getTrackInfo;
#pragma warning disable 0169
		static Delegate GetGetTrackInfoHandler ()
		{
			if (cb_getTrackInfo == null)
				cb_getTrackInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrackInfo);
			return cb_getTrackInfo;
		}

		static IntPtr n_GetTrackInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTrackInfo ());
		}
#pragma warning restore 0169

		IntPtr id_getTrackInfo;
		public unsafe global::TV.Danmaku.Ijk.Media.Player.Misc.ITrackInfo[] GetTrackInfo ()
		{
			if (id_getTrackInfo == IntPtr.Zero)
				id_getTrackInfo = JNIEnv.GetMethodID (class_ref, "getTrackInfo", "()[Ltv/danmaku/ijk/media/player/misc/ITrackInfo;");
			return (global::TV.Danmaku.Ijk.Media.Player.Misc.ITrackInfo[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrackInfo), JniHandleOwnership.TransferLocalRef, typeof (global::TV.Danmaku.Ijk.Media.Player.Misc.ITrackInfo));
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
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_prepareAsync;
#pragma warning disable 0169
		static Delegate GetPrepareAsyncHandler ()
		{
			if (cb_prepareAsync == null)
				cb_prepareAsync = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PrepareAsync);
			return cb_prepareAsync;
		}

		static void n_PrepareAsync (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PrepareAsync ();
		}
#pragma warning restore 0169

		IntPtr id_prepareAsync;
		public unsafe void PrepareAsync ()
		{
			if (id_prepareAsync == IntPtr.Zero)
				id_prepareAsync = JNIEnv.GetMethodID (class_ref, "prepareAsync", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_prepareAsync);
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		IntPtr id_release;
		public unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		IntPtr id_reset;
		public unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset);
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
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_setAudioStreamType_I;
#pragma warning disable 0169
		static Delegate GetSetAudioStreamType_IHandler ()
		{
			if (cb_setAudioStreamType_I == null)
				cb_setAudioStreamType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAudioStreamType_I);
			return cb_setAudioStreamType_I;
		}

		static void n_SetAudioStreamType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAudioStreamType (p0);
		}
#pragma warning restore 0169

		IntPtr id_setAudioStreamType_I;
		public unsafe void SetAudioStreamType (int p0)
		{
			if (id_setAudioStreamType_I == IntPtr.Zero)
				id_setAudioStreamType_I = JNIEnv.GetMethodID (class_ref, "setAudioStreamType", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAudioStreamType_I, __args);
		}

		static Delegate cb_setDataSource_Landroid_content_Context_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetSetDataSource_Landroid_content_Context_Landroid_net_Uri_Handler ()
		{
			if (cb_setDataSource_Landroid_content_Context_Landroid_net_Uri_ == null)
				cb_setDataSource_Landroid_content_Context_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDataSource_Landroid_content_Context_Landroid_net_Uri_);
			return cb_setDataSource_Landroid_content_Context_Landroid_net_Uri_;
		}

		static void n_SetDataSource_Landroid_content_Context_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetDataSource (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setDataSource_Landroid_content_Context_Landroid_net_Uri_;
		public unsafe void SetDataSource (global::Android.Content.Context p0, global::Android.Net.Uri p1)
		{
			if (id_setDataSource_Landroid_content_Context_Landroid_net_Uri_ == IntPtr.Zero)
				id_setDataSource_Landroid_content_Context_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "setDataSource", "(Landroid/content/Context;Landroid/net/Uri;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDataSource_Landroid_content_Context_Landroid_net_Uri_, __args);
		}

		static Delegate cb_setDataSource_Landroid_content_Context_Landroid_net_Uri_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetDataSource_Landroid_content_Context_Landroid_net_Uri_Ljava_util_Map_Handler ()
		{
			if (cb_setDataSource_Landroid_content_Context_Landroid_net_Uri_Ljava_util_Map_ == null)
				cb_setDataSource_Landroid_content_Context_Landroid_net_Uri_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDataSource_Landroid_content_Context_Landroid_net_Uri_Ljava_util_Map_);
			return cb_setDataSource_Landroid_content_Context_Landroid_net_Uri_Ljava_util_Map_;
		}

		static void n_SetDataSource_Landroid_content_Context_Landroid_net_Uri_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetDataSource (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_setDataSource_Landroid_content_Context_Landroid_net_Uri_Ljava_util_Map_;
		public unsafe void SetDataSource (global::Android.Content.Context p0, global::Android.Net.Uri p1, global::System.Collections.Generic.IDictionary<string, string> p2)
		{
			if (id_setDataSource_Landroid_content_Context_Landroid_net_Uri_Ljava_util_Map_ == IntPtr.Zero)
				id_setDataSource_Landroid_content_Context_Landroid_net_Uri_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setDataSource", "(Landroid/content/Context;Landroid/net/Uri;Ljava/util/Map;)V");
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDataSource_Landroid_content_Context_Landroid_net_Uri_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_setDataSource_Ljava_io_FileDescriptor_;
#pragma warning disable 0169
		static Delegate GetSetDataSource_Ljava_io_FileDescriptor_Handler ()
		{
			if (cb_setDataSource_Ljava_io_FileDescriptor_ == null)
				cb_setDataSource_Ljava_io_FileDescriptor_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDataSource_Ljava_io_FileDescriptor_);
			return cb_setDataSource_Ljava_io_FileDescriptor_;
		}

		static void n_SetDataSource_Ljava_io_FileDescriptor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.FileDescriptor p0 = global::Java.Lang.Object.GetObject<global::Java.IO.FileDescriptor> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDataSource (p0);
		}
#pragma warning restore 0169

		IntPtr id_setDataSource_Ljava_io_FileDescriptor_;
		public unsafe void SetDataSource (global::Java.IO.FileDescriptor p0)
		{
			if (id_setDataSource_Ljava_io_FileDescriptor_ == IntPtr.Zero)
				id_setDataSource_Ljava_io_FileDescriptor_ = JNIEnv.GetMethodID (class_ref, "setDataSource", "(Ljava/io/FileDescriptor;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDataSource_Ljava_io_FileDescriptor_, __args);
		}

		static Delegate cb_setDataSource_Ltv_danmaku_ijk_media_player_misc_IMediaDataSource_;
#pragma warning disable 0169
		static Delegate GetSetDataSource_Ltv_danmaku_ijk_media_player_misc_IMediaDataSource_Handler ()
		{
			if (cb_setDataSource_Ltv_danmaku_ijk_media_player_misc_IMediaDataSource_ == null)
				cb_setDataSource_Ltv_danmaku_ijk_media_player_misc_IMediaDataSource_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDataSource_Ltv_danmaku_ijk_media_player_misc_IMediaDataSource_);
			return cb_setDataSource_Ltv_danmaku_ijk_media_player_misc_IMediaDataSource_;
		}

		static void n_SetDataSource_Ltv_danmaku_ijk_media_player_misc_IMediaDataSource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::TV.Danmaku.Ijk.Media.Player.Misc.IMediaDataSource p0 = (global::TV.Danmaku.Ijk.Media.Player.Misc.IMediaDataSource)global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.Misc.IMediaDataSource> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDataSource (p0);
		}
#pragma warning restore 0169

		IntPtr id_setDataSource_Ltv_danmaku_ijk_media_player_misc_IMediaDataSource_;
		public unsafe void SetDataSource (global::TV.Danmaku.Ijk.Media.Player.Misc.IMediaDataSource p0)
		{
			if (id_setDataSource_Ltv_danmaku_ijk_media_player_misc_IMediaDataSource_ == IntPtr.Zero)
				id_setDataSource_Ltv_danmaku_ijk_media_player_misc_IMediaDataSource_ = JNIEnv.GetMethodID (class_ref, "setDataSource", "(Ltv/danmaku/ijk/media/player/misc/IMediaDataSource;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDataSource_Ltv_danmaku_ijk_media_player_misc_IMediaDataSource_, __args);
		}

		static Delegate cb_setDisplay_Landroid_view_SurfaceHolder_;
#pragma warning disable 0169
		static Delegate GetSetDisplay_Landroid_view_SurfaceHolder_Handler ()
		{
			if (cb_setDisplay_Landroid_view_SurfaceHolder_ == null)
				cb_setDisplay_Landroid_view_SurfaceHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDisplay_Landroid_view_SurfaceHolder_);
			return cb_setDisplay_Landroid_view_SurfaceHolder_;
		}

		static void n_SetDisplay_Landroid_view_SurfaceHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder p0 = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDisplay (p0);
		}
#pragma warning restore 0169

		IntPtr id_setDisplay_Landroid_view_SurfaceHolder_;
		public unsafe void SetDisplay (global::Android.Views.ISurfaceHolder p0)
		{
			if (id_setDisplay_Landroid_view_SurfaceHolder_ == IntPtr.Zero)
				id_setDisplay_Landroid_view_SurfaceHolder_ = JNIEnv.GetMethodID (class_ref, "setDisplay", "(Landroid/view/SurfaceHolder;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDisplay_Landroid_view_SurfaceHolder_, __args);
		}

		static Delegate cb_setKeepInBackground_Z;
#pragma warning disable 0169
		static Delegate GetSetKeepInBackground_ZHandler ()
		{
			if (cb_setKeepInBackground_Z == null)
				cb_setKeepInBackground_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetKeepInBackground_Z);
			return cb_setKeepInBackground_Z;
		}

		static void n_SetKeepInBackground_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetKeepInBackground (p0);
		}
#pragma warning restore 0169

		IntPtr id_setKeepInBackground_Z;
		public unsafe void SetKeepInBackground (bool p0)
		{
			if (id_setKeepInBackground_Z == IntPtr.Zero)
				id_setKeepInBackground_Z = JNIEnv.GetMethodID (class_ref, "setKeepInBackground", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setKeepInBackground_Z, __args);
		}

		static Delegate cb_setLogEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetLogEnabled_ZHandler ()
		{
			if (cb_setLogEnabled_Z == null)
				cb_setLogEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetLogEnabled_Z);
			return cb_setLogEnabled_Z;
		}

		static void n_SetLogEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLogEnabled (p0);
		}
#pragma warning restore 0169

		IntPtr id_setLogEnabled_Z;
		public unsafe void SetLogEnabled (bool p0)
		{
			if (id_setLogEnabled_Z == IntPtr.Zero)
				id_setLogEnabled_Z = JNIEnv.GetMethodID (class_ref, "setLogEnabled", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLogEnabled_Z, __args);
		}

		static Delegate cb_setOnBufferingUpdateListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnBufferingUpdateListener_;
#pragma warning disable 0169
		static Delegate GetSetOnBufferingUpdateListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnBufferingUpdateListener_Handler ()
		{
			if (cb_setOnBufferingUpdateListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnBufferingUpdateListener_ == null)
				cb_setOnBufferingUpdateListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnBufferingUpdateListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnBufferingUpdateListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnBufferingUpdateListener_);
			return cb_setOnBufferingUpdateListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnBufferingUpdateListener_;
		}

		static void n_SetOnBufferingUpdateListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnBufferingUpdateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnBufferingUpdateListener p0 = (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnBufferingUpdateListener)global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnBufferingUpdateListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnBufferingUpdateListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setOnBufferingUpdateListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnBufferingUpdateListener_;
		public unsafe void SetOnBufferingUpdateListener (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnBufferingUpdateListener p0)
		{
			if (id_setOnBufferingUpdateListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnBufferingUpdateListener_ == IntPtr.Zero)
				id_setOnBufferingUpdateListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnBufferingUpdateListener_ = JNIEnv.GetMethodID (class_ref, "setOnBufferingUpdateListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnBufferingUpdateListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnBufferingUpdateListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnBufferingUpdateListener_, __args);
		}

		static Delegate cb_setOnCompletionListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnCompletionListener_;
#pragma warning disable 0169
		static Delegate GetSetOnCompletionListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnCompletionListener_Handler ()
		{
			if (cb_setOnCompletionListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnCompletionListener_ == null)
				cb_setOnCompletionListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnCompletionListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnCompletionListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnCompletionListener_);
			return cb_setOnCompletionListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnCompletionListener_;
		}

		static void n_SetOnCompletionListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnCompletionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnCompletionListener p0 = (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnCompletionListener)global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnCompletionListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnCompletionListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setOnCompletionListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnCompletionListener_;
		public unsafe void SetOnCompletionListener (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnCompletionListener p0)
		{
			if (id_setOnCompletionListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnCompletionListener_ == IntPtr.Zero)
				id_setOnCompletionListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnCompletionListener_ = JNIEnv.GetMethodID (class_ref, "setOnCompletionListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnCompletionListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnCompletionListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnCompletionListener_, __args);
		}

		static Delegate cb_setOnErrorListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnErrorListener_;
#pragma warning disable 0169
		static Delegate GetSetOnErrorListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnErrorListener_Handler ()
		{
			if (cb_setOnErrorListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnErrorListener_ == null)
				cb_setOnErrorListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnErrorListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnErrorListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnErrorListener_);
			return cb_setOnErrorListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnErrorListener_;
		}

		static void n_SetOnErrorListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnErrorListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnErrorListener p0 = (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnErrorListener)global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnErrorListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnErrorListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setOnErrorListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnErrorListener_;
		public unsafe void SetOnErrorListener (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnErrorListener p0)
		{
			if (id_setOnErrorListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnErrorListener_ == IntPtr.Zero)
				id_setOnErrorListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnErrorListener_ = JNIEnv.GetMethodID (class_ref, "setOnErrorListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnErrorListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnErrorListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnErrorListener_, __args);
		}

		static Delegate cb_setOnInfoListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnInfoListener_;
#pragma warning disable 0169
		static Delegate GetSetOnInfoListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnInfoListener_Handler ()
		{
			if (cb_setOnInfoListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnInfoListener_ == null)
				cb_setOnInfoListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnInfoListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnInfoListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnInfoListener_);
			return cb_setOnInfoListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnInfoListener_;
		}

		static void n_SetOnInfoListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnInfoListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnInfoListener p0 = (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnInfoListener)global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnInfoListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnInfoListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setOnInfoListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnInfoListener_;
		public unsafe void SetOnInfoListener (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnInfoListener p0)
		{
			if (id_setOnInfoListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnInfoListener_ == IntPtr.Zero)
				id_setOnInfoListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnInfoListener_ = JNIEnv.GetMethodID (class_ref, "setOnInfoListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnInfoListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnInfoListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnInfoListener_, __args);
		}

		static Delegate cb_setOnPreparedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnPreparedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnPreparedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnPreparedListener_Handler ()
		{
			if (cb_setOnPreparedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnPreparedListener_ == null)
				cb_setOnPreparedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnPreparedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnPreparedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnPreparedListener_);
			return cb_setOnPreparedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnPreparedListener_;
		}

		static void n_SetOnPreparedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnPreparedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnPreparedListener p0 = (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnPreparedListener)global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnPreparedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnPreparedListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setOnPreparedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnPreparedListener_;
		public unsafe void SetOnPreparedListener (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnPreparedListener p0)
		{
			if (id_setOnPreparedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnPreparedListener_ == IntPtr.Zero)
				id_setOnPreparedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnPreparedListener_ = JNIEnv.GetMethodID (class_ref, "setOnPreparedListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnPreparedListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnPreparedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnPreparedListener_, __args);
		}

		static Delegate cb_setOnSeekCompleteListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnSeekCompleteListener_;
#pragma warning disable 0169
		static Delegate GetSetOnSeekCompleteListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnSeekCompleteListener_Handler ()
		{
			if (cb_setOnSeekCompleteListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnSeekCompleteListener_ == null)
				cb_setOnSeekCompleteListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnSeekCompleteListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnSeekCompleteListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnSeekCompleteListener_);
			return cb_setOnSeekCompleteListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnSeekCompleteListener_;
		}

		static void n_SetOnSeekCompleteListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnSeekCompleteListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnSeekCompleteListener p0 = (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnSeekCompleteListener)global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnSeekCompleteListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnSeekCompleteListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setOnSeekCompleteListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnSeekCompleteListener_;
		public unsafe void SetOnSeekCompleteListener (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnSeekCompleteListener p0)
		{
			if (id_setOnSeekCompleteListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnSeekCompleteListener_ == IntPtr.Zero)
				id_setOnSeekCompleteListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnSeekCompleteListener_ = JNIEnv.GetMethodID (class_ref, "setOnSeekCompleteListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnSeekCompleteListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnSeekCompleteListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnSeekCompleteListener_, __args);
		}

		static Delegate cb_setOnVideoSizeChangedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnVideoSizeChangedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnVideoSizeChangedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnVideoSizeChangedListener_Handler ()
		{
			if (cb_setOnVideoSizeChangedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnVideoSizeChangedListener_ == null)
				cb_setOnVideoSizeChangedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnVideoSizeChangedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnVideoSizeChangedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnVideoSizeChangedListener_);
			return cb_setOnVideoSizeChangedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnVideoSizeChangedListener_;
		}

		static void n_SetOnVideoSizeChangedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnVideoSizeChangedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnVideoSizeChangedListener p0 = (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnVideoSizeChangedListener)global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnVideoSizeChangedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnVideoSizeChangedListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setOnVideoSizeChangedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnVideoSizeChangedListener_;
		public unsafe void SetOnVideoSizeChangedListener (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnVideoSizeChangedListener p0)
		{
			if (id_setOnVideoSizeChangedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnVideoSizeChangedListener_ == IntPtr.Zero)
				id_setOnVideoSizeChangedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnVideoSizeChangedListener_ = JNIEnv.GetMethodID (class_ref, "setOnVideoSizeChangedListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnVideoSizeChangedListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnVideoSizeChangedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnVideoSizeChangedListener_, __args);
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
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScreenOnWhilePlaying (p0);
		}
#pragma warning restore 0169

		IntPtr id_setScreenOnWhilePlaying_Z;
		public unsafe void SetScreenOnWhilePlaying (bool p0)
		{
			if (id_setScreenOnWhilePlaying_Z == IntPtr.Zero)
				id_setScreenOnWhilePlaying_Z = JNIEnv.GetMethodID (class_ref, "setScreenOnWhilePlaying", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setScreenOnWhilePlaying_Z, __args);
		}

		static Delegate cb_setSurface_Landroid_view_Surface_;
#pragma warning disable 0169
		static Delegate GetSetSurface_Landroid_view_Surface_Handler ()
		{
			if (cb_setSurface_Landroid_view_Surface_ == null)
				cb_setSurface_Landroid_view_Surface_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSurface_Landroid_view_Surface_);
			return cb_setSurface_Landroid_view_Surface_;
		}

		static void n_SetSurface_Landroid_view_Surface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Surface p0 = global::Java.Lang.Object.GetObject<global::Android.Views.Surface> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSurface (p0);
		}
#pragma warning restore 0169

		IntPtr id_setSurface_Landroid_view_Surface_;
		public unsafe void SetSurface (global::Android.Views.Surface p0)
		{
			if (id_setSurface_Landroid_view_Surface_ == IntPtr.Zero)
				id_setSurface_Landroid_view_Surface_ = JNIEnv.GetMethodID (class_ref, "setSurface", "(Landroid/view/Surface;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSurface_Landroid_view_Surface_, __args);
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
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetVolume (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setVolume_FF;
		public unsafe void SetVolume (float p0, float p1)
		{
			if (id_setVolume_FF == IntPtr.Zero)
				id_setVolume_FF = JNIEnv.GetMethodID (class_ref, "setVolume", "(FF)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVolume_FF, __args);
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
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetWakeMode (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setWakeMode_Landroid_content_Context_I;
		public unsafe void SetWakeMode (global::Android.Content.Context p0, int p1)
		{
			if (id_setWakeMode_Landroid_content_Context_I == IntPtr.Zero)
				id_setWakeMode_Landroid_content_Context_I = JNIEnv.GetMethodID (class_ref, "setWakeMode", "(Landroid/content/Context;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setWakeMode_Landroid_content_Context_I, __args);
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
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		IntPtr id_stop;
		public unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
		}

	}

}
