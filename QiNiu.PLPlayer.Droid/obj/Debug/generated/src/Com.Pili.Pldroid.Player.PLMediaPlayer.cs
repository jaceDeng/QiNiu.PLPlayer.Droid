using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Pili.Pldroid.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']"
	[global::Android.Runtime.Register ("com/pili/pldroid/player/PLMediaPlayer", DoNotGenerateAcw=true)]
	public partial class PLMediaPlayer : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/field[@name='ERROR_CODE_404_NOT_FOUND']"
		[Register ("ERROR_CODE_404_NOT_FOUND")]
		public const int ErrorCode404NotFound = (int) -875574520;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/field[@name='ERROR_CODE_CONNECTION_REFUSED']"
		[Register ("ERROR_CODE_CONNECTION_REFUSED")]
		public const int ErrorCodeConnectionRefused = (int) -111;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/field[@name='ERROR_CODE_CONNECTION_TIMEOUT']"
		[Register ("ERROR_CODE_CONNECTION_TIMEOUT")]
		public const int ErrorCodeConnectionTimeout = (int) -110;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/field[@name='ERROR_CODE_EMPTY_PLAYLIST']"
		[Register ("ERROR_CODE_EMPTY_PLAYLIST")]
		public const int ErrorCodeEmptyPlaylist = (int) -541478725;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/field[@name='ERROR_CODE_HW_DECODE_FAILURE']"
		[Register ("ERROR_CODE_HW_DECODE_FAILURE")]
		public const int ErrorCodeHwDecodeFailure = (int) -2003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/field[@name='ERROR_CODE_INVALID_URI']"
		[Register ("ERROR_CODE_INVALID_URI")]
		public const int ErrorCodeInvalidUri = (int) -2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/field[@name='ERROR_CODE_IO_ERROR']"
		[Register ("ERROR_CODE_IO_ERROR")]
		public const int ErrorCodeIoError = (int) -5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/field[@name='ERROR_CODE_PREPARE_TIMEOUT']"
		[Register ("ERROR_CODE_PREPARE_TIMEOUT")]
		public const int ErrorCodePrepareTimeout = (int) -2001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/field[@name='ERROR_CODE_READ_FRAME_TIMEOUT']"
		[Register ("ERROR_CODE_READ_FRAME_TIMEOUT")]
		public const int ErrorCodeReadFrameTimeout = (int) -2002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/field[@name='ERROR_CODE_STREAM_DISCONNECTED']"
		[Register ("ERROR_CODE_STREAM_DISCONNECTED")]
		public const int ErrorCodeStreamDisconnected = (int) -11;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/field[@name='ERROR_CODE_UNAUTHORIZED']"
		[Register ("ERROR_CODE_UNAUTHORIZED")]
		public const int ErrorCodeUnauthorized = (int) -825242872;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/field[@name='MEDIA_ERROR_UNKNOWN']"
		[Register ("MEDIA_ERROR_UNKNOWN")]
		public const int MediaErrorUnknown = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/field[@name='MEDIA_INFO_AUDIO_FRAME_RENDERING']"
		[Register ("MEDIA_INFO_AUDIO_FRAME_RENDERING")]
		public const int MediaInfoAudioFrameRendering = (int) 10005;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/field[@name='MEDIA_INFO_AUDIO_RENDERING_START']"
		[Register ("MEDIA_INFO_AUDIO_RENDERING_START")]
		public const int MediaInfoAudioRenderingStart = (int) 10002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/field[@name='MEDIA_INFO_BUFFERING_BYTES_UPDATE']"
		[Register ("MEDIA_INFO_BUFFERING_BYTES_UPDATE")]
		public const int MediaInfoBufferingBytesUpdate = (int) 503;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/field[@name='MEDIA_INFO_BUFFERING_END']"
		[Register ("MEDIA_INFO_BUFFERING_END")]
		public const int MediaInfoBufferingEnd = (int) 702;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/field[@name='MEDIA_INFO_BUFFERING_START']"
		[Register ("MEDIA_INFO_BUFFERING_START")]
		public const int MediaInfoBufferingStart = (int) 701;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/field[@name='MEDIA_INFO_NOT_SEEKABLE']"
		[Register ("MEDIA_INFO_NOT_SEEKABLE")]
		public const int MediaInfoNotSeekable = (int) 801;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/field[@name='MEDIA_INFO_SWITCHING_SW_DECODE']"
		[Register ("MEDIA_INFO_SWITCHING_SW_DECODE")]
		public const int MediaInfoSwitchingSwDecode = (int) 802;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/field[@name='MEDIA_INFO_UNKNOWN']"
		[Register ("MEDIA_INFO_UNKNOWN")]
		public const int MediaInfoUnknown = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/field[@name='MEDIA_INFO_VIDEO_FRAME_RENDERING']"
		[Register ("MEDIA_INFO_VIDEO_FRAME_RENDERING")]
		public const int MediaInfoVideoFrameRendering = (int) 10004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/field[@name='MEDIA_INFO_VIDEO_GOP_TIME']"
		[Register ("MEDIA_INFO_VIDEO_GOP_TIME")]
		public const int MediaInfoVideoGopTime = (int) 10003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/field[@name='MEDIA_INFO_VIDEO_RENDERING_START']"
		[Register ("MEDIA_INFO_VIDEO_RENDERING_START")]
		public const int MediaInfoVideoRenderingStart = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/field[@name='MEDIA_INFO_VIDEO_ROTATION_CHANGED']"
		[Register ("MEDIA_INFO_VIDEO_ROTATION_CHANGED")]
		public const int MediaInfoVideoRotationChanged = (int) 10001;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.pili.pldroid.player']/interface[@name='PLMediaPlayer.OnBufferingUpdateListener']"
		[Register ("com/pili/pldroid/player/PLMediaPlayer$OnBufferingUpdateListener", "", "Com.Pili.Pldroid.Player.PLMediaPlayer/IOnBufferingUpdateListenerInvoker")]
		public partial interface IOnBufferingUpdateListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/interface[@name='PLMediaPlayer.OnBufferingUpdateListener']/method[@name='onBufferingUpdate' and count(parameter)=2 and parameter[1][@type='com.pili.pldroid.player.PLMediaPlayer'] and parameter[2][@type='int']]"
			[Register ("onBufferingUpdate", "(Lcom/pili/pldroid/player/PLMediaPlayer;I)V", "GetOnBufferingUpdate_Lcom_pili_pldroid_player_PLMediaPlayer_IHandler:Com.Pili.Pldroid.Player.PLMediaPlayer/IOnBufferingUpdateListenerInvoker, QiNiu.PLPlayer.Droid")]
			void OnBufferingUpdate (global::Com.Pili.Pldroid.Player.PLMediaPlayer p0, int p1);

		}

		[global::Android.Runtime.Register ("com/pili/pldroid/player/PLMediaPlayer$OnBufferingUpdateListener", DoNotGenerateAcw=true)]
		internal class IOnBufferingUpdateListenerInvoker : global::Java.Lang.Object, IOnBufferingUpdateListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/pili/pldroid/player/PLMediaPlayer$OnBufferingUpdateListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnBufferingUpdateListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnBufferingUpdateListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnBufferingUpdateListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.pili.pldroid.player.PLMediaPlayer.OnBufferingUpdateListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnBufferingUpdateListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onBufferingUpdate_Lcom_pili_pldroid_player_PLMediaPlayer_I;
#pragma warning disable 0169
			static Delegate GetOnBufferingUpdate_Lcom_pili_pldroid_player_PLMediaPlayer_IHandler ()
			{
				if (cb_onBufferingUpdate_Lcom_pili_pldroid_player_PLMediaPlayer_I == null)
					cb_onBufferingUpdate_Lcom_pili_pldroid_player_PLMediaPlayer_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnBufferingUpdate_Lcom_pili_pldroid_player_PLMediaPlayer_I);
				return cb_onBufferingUpdate_Lcom_pili_pldroid_player_PLMediaPlayer_I;
			}

			static void n_OnBufferingUpdate_Lcom_pili_pldroid_player_PLMediaPlayer_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnBufferingUpdateListener __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnBufferingUpdateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Pili.Pldroid.Player.PLMediaPlayer p0 = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnBufferingUpdate (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onBufferingUpdate_Lcom_pili_pldroid_player_PLMediaPlayer_I;
			public unsafe void OnBufferingUpdate (global::Com.Pili.Pldroid.Player.PLMediaPlayer p0, int p1)
			{
				if (id_onBufferingUpdate_Lcom_pili_pldroid_player_PLMediaPlayer_I == IntPtr.Zero)
					id_onBufferingUpdate_Lcom_pili_pldroid_player_PLMediaPlayer_I = JNIEnv.GetMethodID (class_ref, "onBufferingUpdate", "(Lcom/pili/pldroid/player/PLMediaPlayer;I)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBufferingUpdate_Lcom_pili_pldroid_player_PLMediaPlayer_I, __args);
			}

		}

		public partial class BufferingUpdateEventArgs : global::System.EventArgs {

			public BufferingUpdateEventArgs (global::Com.Pili.Pldroid.Player.PLMediaPlayer p0, int p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Pili.Pldroid.Player.PLMediaPlayer p0;
			public global::Com.Pili.Pldroid.Player.PLMediaPlayer P0 {
				get { return p0; }
			}

			int p1;
			public int P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/pili/pldroid/player/PLMediaPlayer_OnBufferingUpdateListenerImplementor")]
		internal sealed partial class IOnBufferingUpdateListenerImplementor : global::Java.Lang.Object, IOnBufferingUpdateListener {

			object sender;

			public IOnBufferingUpdateListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/pili/pldroid/player/PLMediaPlayer_OnBufferingUpdateListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<BufferingUpdateEventArgs> Handler;
#pragma warning restore 0649

			public void OnBufferingUpdate (global::Com.Pili.Pldroid.Player.PLMediaPlayer p0, int p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new BufferingUpdateEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnBufferingUpdateListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.pili.pldroid.player']/interface[@name='PLMediaPlayer.OnCompletionListener']"
		[Register ("com/pili/pldroid/player/PLMediaPlayer$OnCompletionListener", "", "Com.Pili.Pldroid.Player.PLMediaPlayer/IOnCompletionListenerInvoker")]
		public partial interface IOnCompletionListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/interface[@name='PLMediaPlayer.OnCompletionListener']/method[@name='onCompletion' and count(parameter)=1 and parameter[1][@type='com.pili.pldroid.player.PLMediaPlayer']]"
			[Register ("onCompletion", "(Lcom/pili/pldroid/player/PLMediaPlayer;)V", "GetOnCompletion_Lcom_pili_pldroid_player_PLMediaPlayer_Handler:Com.Pili.Pldroid.Player.PLMediaPlayer/IOnCompletionListenerInvoker, QiNiu.PLPlayer.Droid")]
			void OnCompletion (global::Com.Pili.Pldroid.Player.PLMediaPlayer p0);

		}

		[global::Android.Runtime.Register ("com/pili/pldroid/player/PLMediaPlayer$OnCompletionListener", DoNotGenerateAcw=true)]
		internal class IOnCompletionListenerInvoker : global::Java.Lang.Object, IOnCompletionListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/pili/pldroid/player/PLMediaPlayer$OnCompletionListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnCompletionListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnCompletionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnCompletionListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.pili.pldroid.player.PLMediaPlayer.OnCompletionListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnCompletionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onCompletion_Lcom_pili_pldroid_player_PLMediaPlayer_;
#pragma warning disable 0169
			static Delegate GetOnCompletion_Lcom_pili_pldroid_player_PLMediaPlayer_Handler ()
			{
				if (cb_onCompletion_Lcom_pili_pldroid_player_PLMediaPlayer_ == null)
					cb_onCompletion_Lcom_pili_pldroid_player_PLMediaPlayer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCompletion_Lcom_pili_pldroid_player_PLMediaPlayer_);
				return cb_onCompletion_Lcom_pili_pldroid_player_PLMediaPlayer_;
			}

			static void n_OnCompletion_Lcom_pili_pldroid_player_PLMediaPlayer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnCompletionListener __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnCompletionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Pili.Pldroid.Player.PLMediaPlayer p0 = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnCompletion (p0);
			}
#pragma warning restore 0169

			IntPtr id_onCompletion_Lcom_pili_pldroid_player_PLMediaPlayer_;
			public unsafe void OnCompletion (global::Com.Pili.Pldroid.Player.PLMediaPlayer p0)
			{
				if (id_onCompletion_Lcom_pili_pldroid_player_PLMediaPlayer_ == IntPtr.Zero)
					id_onCompletion_Lcom_pili_pldroid_player_PLMediaPlayer_ = JNIEnv.GetMethodID (class_ref, "onCompletion", "(Lcom/pili/pldroid/player/PLMediaPlayer;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCompletion_Lcom_pili_pldroid_player_PLMediaPlayer_, __args);
			}

		}

		public partial class CompletionEventArgs : global::System.EventArgs {

			public CompletionEventArgs (global::Com.Pili.Pldroid.Player.PLMediaPlayer p0)
			{
				this.p0 = p0;
			}

			global::Com.Pili.Pldroid.Player.PLMediaPlayer p0;
			public global::Com.Pili.Pldroid.Player.PLMediaPlayer P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/pili/pldroid/player/PLMediaPlayer_OnCompletionListenerImplementor")]
		internal sealed partial class IOnCompletionListenerImplementor : global::Java.Lang.Object, IOnCompletionListener {

			object sender;

			public IOnCompletionListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/pili/pldroid/player/PLMediaPlayer_OnCompletionListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<CompletionEventArgs> Handler;
#pragma warning restore 0649

			public void OnCompletion (global::Com.Pili.Pldroid.Player.PLMediaPlayer p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new CompletionEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnCompletionListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.pili.pldroid.player']/interface[@name='PLMediaPlayer.OnErrorListener']"
		[Register ("com/pili/pldroid/player/PLMediaPlayer$OnErrorListener", "", "Com.Pili.Pldroid.Player.PLMediaPlayer/IOnErrorListenerInvoker")]
		public partial interface IOnErrorListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/interface[@name='PLMediaPlayer.OnErrorListener']/method[@name='onError' and count(parameter)=2 and parameter[1][@type='com.pili.pldroid.player.PLMediaPlayer'] and parameter[2][@type='int']]"
			[Register ("onError", "(Lcom/pili/pldroid/player/PLMediaPlayer;I)Z", "GetOnError_Lcom_pili_pldroid_player_PLMediaPlayer_IHandler:Com.Pili.Pldroid.Player.PLMediaPlayer/IOnErrorListenerInvoker, QiNiu.PLPlayer.Droid")]
			bool OnError (global::Com.Pili.Pldroid.Player.PLMediaPlayer p0, int p1);

		}

		[global::Android.Runtime.Register ("com/pili/pldroid/player/PLMediaPlayer$OnErrorListener", DoNotGenerateAcw=true)]
		internal class IOnErrorListenerInvoker : global::Java.Lang.Object, IOnErrorListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/pili/pldroid/player/PLMediaPlayer$OnErrorListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnErrorListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnErrorListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnErrorListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.pili.pldroid.player.PLMediaPlayer.OnErrorListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnErrorListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onError_Lcom_pili_pldroid_player_PLMediaPlayer_I;
#pragma warning disable 0169
			static Delegate GetOnError_Lcom_pili_pldroid_player_PLMediaPlayer_IHandler ()
			{
				if (cb_onError_Lcom_pili_pldroid_player_PLMediaPlayer_I == null)
					cb_onError_Lcom_pili_pldroid_player_PLMediaPlayer_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, bool>) n_OnError_Lcom_pili_pldroid_player_PLMediaPlayer_I);
				return cb_onError_Lcom_pili_pldroid_player_PLMediaPlayer_I;
			}

			static bool n_OnError_Lcom_pili_pldroid_player_PLMediaPlayer_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnErrorListener __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnErrorListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Pili.Pldroid.Player.PLMediaPlayer p0 = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnError (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onError_Lcom_pili_pldroid_player_PLMediaPlayer_I;
			public unsafe bool OnError (global::Com.Pili.Pldroid.Player.PLMediaPlayer p0, int p1)
			{
				if (id_onError_Lcom_pili_pldroid_player_PLMediaPlayer_I == IntPtr.Zero)
					id_onError_Lcom_pili_pldroid_player_PLMediaPlayer_I = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/pili/pldroid/player/PLMediaPlayer;I)Z");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onError_Lcom_pili_pldroid_player_PLMediaPlayer_I, __args);
				return __ret;
			}

		}

		public partial class ErrorEventArgs : global::System.EventArgs {

			public ErrorEventArgs (bool handled, global::Com.Pili.Pldroid.Player.PLMediaPlayer p0, int p1)
			{
				this.handled = handled;
				this.p0 = p0;
				this.p1 = p1;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::Com.Pili.Pldroid.Player.PLMediaPlayer p0;
			public global::Com.Pili.Pldroid.Player.PLMediaPlayer P0 {
				get { return p0; }
			}

			int p1;
			public int P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/pili/pldroid/player/PLMediaPlayer_OnErrorListenerImplementor")]
		internal sealed partial class IOnErrorListenerImplementor : global::Java.Lang.Object, IOnErrorListener {

			object sender;

			public IOnErrorListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/pili/pldroid/player/PLMediaPlayer_OnErrorListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ErrorEventArgs> Handler;
#pragma warning restore 0649

			public bool OnError (global::Com.Pili.Pldroid.Player.PLMediaPlayer p0, int p1)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new ErrorEventArgs (true, p0, p1);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnErrorListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.pili.pldroid.player']/interface[@name='PLMediaPlayer.OnInfoListener']"
		[Register ("com/pili/pldroid/player/PLMediaPlayer$OnInfoListener", "", "Com.Pili.Pldroid.Player.PLMediaPlayer/IOnInfoListenerInvoker")]
		public partial interface IOnInfoListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/interface[@name='PLMediaPlayer.OnInfoListener']/method[@name='onInfo' and count(parameter)=3 and parameter[1][@type='com.pili.pldroid.player.PLMediaPlayer'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onInfo", "(Lcom/pili/pldroid/player/PLMediaPlayer;II)Z", "GetOnInfo_Lcom_pili_pldroid_player_PLMediaPlayer_IIHandler:Com.Pili.Pldroid.Player.PLMediaPlayer/IOnInfoListenerInvoker, QiNiu.PLPlayer.Droid")]
			bool OnInfo (global::Com.Pili.Pldroid.Player.PLMediaPlayer p0, int p1, int p2);

		}

		[global::Android.Runtime.Register ("com/pili/pldroid/player/PLMediaPlayer$OnInfoListener", DoNotGenerateAcw=true)]
		internal class IOnInfoListenerInvoker : global::Java.Lang.Object, IOnInfoListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/pili/pldroid/player/PLMediaPlayer$OnInfoListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnInfoListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnInfoListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnInfoListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.pili.pldroid.player.PLMediaPlayer.OnInfoListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnInfoListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onInfo_Lcom_pili_pldroid_player_PLMediaPlayer_II;
#pragma warning disable 0169
			static Delegate GetOnInfo_Lcom_pili_pldroid_player_PLMediaPlayer_IIHandler ()
			{
				if (cb_onInfo_Lcom_pili_pldroid_player_PLMediaPlayer_II == null)
					cb_onInfo_Lcom_pili_pldroid_player_PLMediaPlayer_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, bool>) n_OnInfo_Lcom_pili_pldroid_player_PLMediaPlayer_II);
				return cb_onInfo_Lcom_pili_pldroid_player_PLMediaPlayer_II;
			}

			static bool n_OnInfo_Lcom_pili_pldroid_player_PLMediaPlayer_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
			{
				global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnInfoListener __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnInfoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Pili.Pldroid.Player.PLMediaPlayer p0 = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnInfo (p0, p1, p2);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onInfo_Lcom_pili_pldroid_player_PLMediaPlayer_II;
			public unsafe bool OnInfo (global::Com.Pili.Pldroid.Player.PLMediaPlayer p0, int p1, int p2)
			{
				if (id_onInfo_Lcom_pili_pldroid_player_PLMediaPlayer_II == IntPtr.Zero)
					id_onInfo_Lcom_pili_pldroid_player_PLMediaPlayer_II = JNIEnv.GetMethodID (class_ref, "onInfo", "(Lcom/pili/pldroid/player/PLMediaPlayer;II)Z");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onInfo_Lcom_pili_pldroid_player_PLMediaPlayer_II, __args);
				return __ret;
			}

		}

		public partial class InfoEventArgs : global::System.EventArgs {

			public InfoEventArgs (bool handled, global::Com.Pili.Pldroid.Player.PLMediaPlayer p0, int p1, int p2)
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

			global::Com.Pili.Pldroid.Player.PLMediaPlayer p0;
			public global::Com.Pili.Pldroid.Player.PLMediaPlayer P0 {
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

		[global::Android.Runtime.Register ("mono/com/pili/pldroid/player/PLMediaPlayer_OnInfoListenerImplementor")]
		internal sealed partial class IOnInfoListenerImplementor : global::Java.Lang.Object, IOnInfoListener {

			object sender;

			public IOnInfoListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/pili/pldroid/player/PLMediaPlayer_OnInfoListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<InfoEventArgs> Handler;
#pragma warning restore 0649

			public bool OnInfo (global::Com.Pili.Pldroid.Player.PLMediaPlayer p0, int p1, int p2)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new InfoEventArgs (true, p0, p1, p2);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnInfoListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.pili.pldroid.player']/interface[@name='PLMediaPlayer.OnPreparedListener']"
		[Register ("com/pili/pldroid/player/PLMediaPlayer$OnPreparedListener", "", "Com.Pili.Pldroid.Player.PLMediaPlayer/IOnPreparedListenerInvoker")]
		public partial interface IOnPreparedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/interface[@name='PLMediaPlayer.OnPreparedListener']/method[@name='onPrepared' and count(parameter)=2 and parameter[1][@type='com.pili.pldroid.player.PLMediaPlayer'] and parameter[2][@type='int']]"
			[Register ("onPrepared", "(Lcom/pili/pldroid/player/PLMediaPlayer;I)V", "GetOnPrepared_Lcom_pili_pldroid_player_PLMediaPlayer_IHandler:Com.Pili.Pldroid.Player.PLMediaPlayer/IOnPreparedListenerInvoker, QiNiu.PLPlayer.Droid")]
			void OnPrepared (global::Com.Pili.Pldroid.Player.PLMediaPlayer p0, int p1);

		}

		[global::Android.Runtime.Register ("com/pili/pldroid/player/PLMediaPlayer$OnPreparedListener", DoNotGenerateAcw=true)]
		internal class IOnPreparedListenerInvoker : global::Java.Lang.Object, IOnPreparedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/pili/pldroid/player/PLMediaPlayer$OnPreparedListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnPreparedListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnPreparedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnPreparedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.pili.pldroid.player.PLMediaPlayer.OnPreparedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnPreparedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onPrepared_Lcom_pili_pldroid_player_PLMediaPlayer_I;
#pragma warning disable 0169
			static Delegate GetOnPrepared_Lcom_pili_pldroid_player_PLMediaPlayer_IHandler ()
			{
				if (cb_onPrepared_Lcom_pili_pldroid_player_PLMediaPlayer_I == null)
					cb_onPrepared_Lcom_pili_pldroid_player_PLMediaPlayer_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnPrepared_Lcom_pili_pldroid_player_PLMediaPlayer_I);
				return cb_onPrepared_Lcom_pili_pldroid_player_PLMediaPlayer_I;
			}

			static void n_OnPrepared_Lcom_pili_pldroid_player_PLMediaPlayer_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnPreparedListener __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnPreparedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Pili.Pldroid.Player.PLMediaPlayer p0 = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnPrepared (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onPrepared_Lcom_pili_pldroid_player_PLMediaPlayer_I;
			public unsafe void OnPrepared (global::Com.Pili.Pldroid.Player.PLMediaPlayer p0, int p1)
			{
				if (id_onPrepared_Lcom_pili_pldroid_player_PLMediaPlayer_I == IntPtr.Zero)
					id_onPrepared_Lcom_pili_pldroid_player_PLMediaPlayer_I = JNIEnv.GetMethodID (class_ref, "onPrepared", "(Lcom/pili/pldroid/player/PLMediaPlayer;I)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPrepared_Lcom_pili_pldroid_player_PLMediaPlayer_I, __args);
			}

		}

		public partial class PreparedEventArgs : global::System.EventArgs {

			public PreparedEventArgs (global::Com.Pili.Pldroid.Player.PLMediaPlayer p0, int p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Pili.Pldroid.Player.PLMediaPlayer p0;
			public global::Com.Pili.Pldroid.Player.PLMediaPlayer P0 {
				get { return p0; }
			}

			int p1;
			public int P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/pili/pldroid/player/PLMediaPlayer_OnPreparedListenerImplementor")]
		internal sealed partial class IOnPreparedListenerImplementor : global::Java.Lang.Object, IOnPreparedListener {

			object sender;

			public IOnPreparedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/pili/pldroid/player/PLMediaPlayer_OnPreparedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<PreparedEventArgs> Handler;
#pragma warning restore 0649

			public void OnPrepared (global::Com.Pili.Pldroid.Player.PLMediaPlayer p0, int p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new PreparedEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnPreparedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.pili.pldroid.player']/interface[@name='PLMediaPlayer.OnSeekCompleteListener']"
		[Register ("com/pili/pldroid/player/PLMediaPlayer$OnSeekCompleteListener", "", "Com.Pili.Pldroid.Player.PLMediaPlayer/IOnSeekCompleteListenerInvoker")]
		public partial interface IOnSeekCompleteListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/interface[@name='PLMediaPlayer.OnSeekCompleteListener']/method[@name='onSeekComplete' and count(parameter)=1 and parameter[1][@type='com.pili.pldroid.player.PLMediaPlayer']]"
			[Register ("onSeekComplete", "(Lcom/pili/pldroid/player/PLMediaPlayer;)V", "GetOnSeekComplete_Lcom_pili_pldroid_player_PLMediaPlayer_Handler:Com.Pili.Pldroid.Player.PLMediaPlayer/IOnSeekCompleteListenerInvoker, QiNiu.PLPlayer.Droid")]
			void OnSeekComplete (global::Com.Pili.Pldroid.Player.PLMediaPlayer p0);

		}

		[global::Android.Runtime.Register ("com/pili/pldroid/player/PLMediaPlayer$OnSeekCompleteListener", DoNotGenerateAcw=true)]
		internal class IOnSeekCompleteListenerInvoker : global::Java.Lang.Object, IOnSeekCompleteListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/pili/pldroid/player/PLMediaPlayer$OnSeekCompleteListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnSeekCompleteListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnSeekCompleteListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnSeekCompleteListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.pili.pldroid.player.PLMediaPlayer.OnSeekCompleteListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnSeekCompleteListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onSeekComplete_Lcom_pili_pldroid_player_PLMediaPlayer_;
#pragma warning disable 0169
			static Delegate GetOnSeekComplete_Lcom_pili_pldroid_player_PLMediaPlayer_Handler ()
			{
				if (cb_onSeekComplete_Lcom_pili_pldroid_player_PLMediaPlayer_ == null)
					cb_onSeekComplete_Lcom_pili_pldroid_player_PLMediaPlayer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSeekComplete_Lcom_pili_pldroid_player_PLMediaPlayer_);
				return cb_onSeekComplete_Lcom_pili_pldroid_player_PLMediaPlayer_;
			}

			static void n_OnSeekComplete_Lcom_pili_pldroid_player_PLMediaPlayer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnSeekCompleteListener __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnSeekCompleteListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Pili.Pldroid.Player.PLMediaPlayer p0 = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSeekComplete (p0);
			}
#pragma warning restore 0169

			IntPtr id_onSeekComplete_Lcom_pili_pldroid_player_PLMediaPlayer_;
			public unsafe void OnSeekComplete (global::Com.Pili.Pldroid.Player.PLMediaPlayer p0)
			{
				if (id_onSeekComplete_Lcom_pili_pldroid_player_PLMediaPlayer_ == IntPtr.Zero)
					id_onSeekComplete_Lcom_pili_pldroid_player_PLMediaPlayer_ = JNIEnv.GetMethodID (class_ref, "onSeekComplete", "(Lcom/pili/pldroid/player/PLMediaPlayer;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSeekComplete_Lcom_pili_pldroid_player_PLMediaPlayer_, __args);
			}

		}

		public partial class SeekCompleteEventArgs : global::System.EventArgs {

			public SeekCompleteEventArgs (global::Com.Pili.Pldroid.Player.PLMediaPlayer p0)
			{
				this.p0 = p0;
			}

			global::Com.Pili.Pldroid.Player.PLMediaPlayer p0;
			public global::Com.Pili.Pldroid.Player.PLMediaPlayer P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/pili/pldroid/player/PLMediaPlayer_OnSeekCompleteListenerImplementor")]
		internal sealed partial class IOnSeekCompleteListenerImplementor : global::Java.Lang.Object, IOnSeekCompleteListener {

			object sender;

			public IOnSeekCompleteListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/pili/pldroid/player/PLMediaPlayer_OnSeekCompleteListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<SeekCompleteEventArgs> Handler;
#pragma warning restore 0649

			public void OnSeekComplete (global::Com.Pili.Pldroid.Player.PLMediaPlayer p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new SeekCompleteEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnSeekCompleteListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.pili.pldroid.player']/interface[@name='PLMediaPlayer.OnVideoSizeChangedListener']"
		[Register ("com/pili/pldroid/player/PLMediaPlayer$OnVideoSizeChangedListener", "", "Com.Pili.Pldroid.Player.PLMediaPlayer/IOnVideoSizeChangedListenerInvoker")]
		public partial interface IOnVideoSizeChangedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/interface[@name='PLMediaPlayer.OnVideoSizeChangedListener']/method[@name='onVideoSizeChanged' and count(parameter)=5 and parameter[1][@type='com.pili.pldroid.player.PLMediaPlayer'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
			[Register ("onVideoSizeChanged", "(Lcom/pili/pldroid/player/PLMediaPlayer;IIII)V", "GetOnVideoSizeChanged_Lcom_pili_pldroid_player_PLMediaPlayer_IIIIHandler:Com.Pili.Pldroid.Player.PLMediaPlayer/IOnVideoSizeChangedListenerInvoker, QiNiu.PLPlayer.Droid")]
			void OnVideoSizeChanged (global::Com.Pili.Pldroid.Player.PLMediaPlayer p0, int p1, int p2, int p3, int p4);

		}

		[global::Android.Runtime.Register ("com/pili/pldroid/player/PLMediaPlayer$OnVideoSizeChangedListener", DoNotGenerateAcw=true)]
		internal class IOnVideoSizeChangedListenerInvoker : global::Java.Lang.Object, IOnVideoSizeChangedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/pili/pldroid/player/PLMediaPlayer$OnVideoSizeChangedListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnVideoSizeChangedListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnVideoSizeChangedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnVideoSizeChangedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.pili.pldroid.player.PLMediaPlayer.OnVideoSizeChangedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnVideoSizeChangedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onVideoSizeChanged_Lcom_pili_pldroid_player_PLMediaPlayer_IIII;
#pragma warning disable 0169
			static Delegate GetOnVideoSizeChanged_Lcom_pili_pldroid_player_PLMediaPlayer_IIIIHandler ()
			{
				if (cb_onVideoSizeChanged_Lcom_pili_pldroid_player_PLMediaPlayer_IIII == null)
					cb_onVideoSizeChanged_Lcom_pili_pldroid_player_PLMediaPlayer_IIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int, int>) n_OnVideoSizeChanged_Lcom_pili_pldroid_player_PLMediaPlayer_IIII);
				return cb_onVideoSizeChanged_Lcom_pili_pldroid_player_PLMediaPlayer_IIII;
			}

			static void n_OnVideoSizeChanged_Lcom_pili_pldroid_player_PLMediaPlayer_IIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4)
			{
				global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnVideoSizeChangedListener __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnVideoSizeChangedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Pili.Pldroid.Player.PLMediaPlayer p0 = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnVideoSizeChanged (p0, p1, p2, p3, p4);
			}
#pragma warning restore 0169

			IntPtr id_onVideoSizeChanged_Lcom_pili_pldroid_player_PLMediaPlayer_IIII;
			public unsafe void OnVideoSizeChanged (global::Com.Pili.Pldroid.Player.PLMediaPlayer p0, int p1, int p2, int p3, int p4)
			{
				if (id_onVideoSizeChanged_Lcom_pili_pldroid_player_PLMediaPlayer_IIII == IntPtr.Zero)
					id_onVideoSizeChanged_Lcom_pili_pldroid_player_PLMediaPlayer_IIII = JNIEnv.GetMethodID (class_ref, "onVideoSizeChanged", "(Lcom/pili/pldroid/player/PLMediaPlayer;IIII)V");
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onVideoSizeChanged_Lcom_pili_pldroid_player_PLMediaPlayer_IIII, __args);
			}

		}

		public partial class VideoSizeChangedEventArgs : global::System.EventArgs {

			public VideoSizeChangedEventArgs (global::Com.Pili.Pldroid.Player.PLMediaPlayer p0, int p1, int p2, int p3, int p4)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
				this.p4 = p4;
			}

			global::Com.Pili.Pldroid.Player.PLMediaPlayer p0;
			public global::Com.Pili.Pldroid.Player.PLMediaPlayer P0 {
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

		[global::Android.Runtime.Register ("mono/com/pili/pldroid/player/PLMediaPlayer_OnVideoSizeChangedListenerImplementor")]
		internal sealed partial class IOnVideoSizeChangedListenerImplementor : global::Java.Lang.Object, IOnVideoSizeChangedListener {

			object sender;

			public IOnVideoSizeChangedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/pili/pldroid/player/PLMediaPlayer_OnVideoSizeChangedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<VideoSizeChangedEventArgs> Handler;
#pragma warning restore 0649

			public void OnVideoSizeChanged (global::Com.Pili.Pldroid.Player.PLMediaPlayer p0, int p1, int p2, int p3, int p4)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new VideoSizeChangedEventArgs (p0, p1, p2, p3, p4));
			}

			internal static bool __IsEmpty (IOnVideoSizeChangedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/pili/pldroid/player/PLMediaPlayer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PLMediaPlayer); }
		}

		protected PLMediaPlayer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/constructor[@name='PLMediaPlayer' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe PLMediaPlayer (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (PLMediaPlayer)) {
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

		static IntPtr id_ctor_Landroid_content_Context_Lcom_pili_pldroid_player_AVOptions_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/constructor[@name='PLMediaPlayer' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.pili.pldroid.player.AVOptions']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/pili/pldroid/player/AVOptions;)V", "")]
		public unsafe PLMediaPlayer (global::Android.Content.Context p0, global::Com.Pili.Pldroid.Player.AVOptions p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (PLMediaPlayer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Lcom/pili/pldroid/player/AVOptions;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Lcom/pili/pldroid/player/AVOptions;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_pili_pldroid_player_AVOptions_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_pili_pldroid_player_AVOptions_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/pili/pldroid/player/AVOptions;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_pili_pldroid_player_AVOptions_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_pili_pldroid_player_AVOptions_, __args);
			} finally {
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentPosition;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentPosition;
		public virtual unsafe long CurrentPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='getCurrentPosition' and count(parameter)=0]"
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DataSource = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDataSource;
		static IntPtr id_setDataSource_Ljava_lang_String_;
		public virtual unsafe string DataSource {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='getDataSource' and count(parameter)=0]"
			[Register ("getDataSource", "()Ljava/lang/String;", "GetGetDataSourceHandler")]
			get {
				if (id_getDataSource == IntPtr.Zero)
					id_getDataSource = JNIEnv.GetMethodID (class_ref, "getDataSource", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDataSource), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDataSource", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='setDataSource' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDataSource", "(Ljava/lang/String;)V", "GetSetDataSource_Ljava_lang_String_Handler")]
			set {
				if (id_setDataSource_Ljava_lang_String_ == IntPtr.Zero)
					id_setDataSource_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDataSource", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDataSource_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDataSource", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Duration;
		}
#pragma warning restore 0169

		static IntPtr id_getDuration;
		public virtual unsafe long Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='getDuration' and count(parameter)=0]"
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPlaying;
		}
#pragma warning restore 0169

		static IntPtr id_isPlaying;
		public virtual unsafe bool IsPlaying {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='isPlaying' and count(parameter)=0]"
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Looping = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isLooping;
		static IntPtr id_setLooping_Z;
		public virtual unsafe bool Looping {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='isLooping' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='setLooping' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.Metadata);
		}
#pragma warning restore 0169

		static IntPtr id_getMetadata;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='getMetadata' and count(parameter)=0]"
			[Register ("getMetadata", "()Ljava/util/HashMap;", "GetGetMetadataHandler")]
			get {
				if (id_getMetadata == IntPtr.Zero)
					id_getMetadata = JNIEnv.GetMethodID (class_ref, "getMetadata", "()Ljava/util/HashMap;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMetadata), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMetadata", "()Ljava/util/HashMap;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PlayerState);
		}
#pragma warning restore 0169

		static IntPtr id_getPlayerState;
		public virtual unsafe global::Com.Pili.Pldroid.Player.PlayerState PlayerState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='getPlayerState' and count(parameter)=0]"
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResolutionInline);
		}
#pragma warning restore 0169

		static IntPtr id_getResolutionInline;
		public virtual unsafe string ResolutionInline {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='getResolutionInline' and count(parameter)=0]"
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoBitrate;
		}
#pragma warning restore 0169

		static IntPtr id_getVideoBitrate;
		public virtual unsafe long VideoBitrate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='getVideoBitrate' and count(parameter)=0]"
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoFps;
		}
#pragma warning restore 0169

		static IntPtr id_getVideoFps;
		public virtual unsafe int VideoFps {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='getVideoFps' and count(parameter)=0]"
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoHeight;
		}
#pragma warning restore 0169

		static IntPtr id_getVideoHeight;
		public virtual unsafe int VideoHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='getVideoHeight' and count(parameter)=0]"
			[Register ("getVideoHeight", "()I", "GetGetVideoHeightHandler")]
			get {
				if (id_getVideoHeight == IntPtr.Zero)
					id_getVideoHeight = JNIEnv.GetMethodID (class_ref, "getVideoHeight", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getVideoHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideoHeight", "()I"));
				} finally {
				}
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoWidth;
		}
#pragma warning restore 0169

		static IntPtr id_getVideoWidth;
		public virtual unsafe int VideoWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='getVideoWidth' and count(parameter)=0]"
			[Register ("getVideoWidth", "()I", "GetGetVideoWidthHandler")]
			get {
				if (id_getVideoWidth == IntPtr.Zero)
					id_getVideoWidth = JNIEnv.GetMethodID (class_ref, "getVideoWidth", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getVideoWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideoWidth", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_A);
			return cb_a;
		}

		static bool n_A (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.A ();
		}
#pragma warning restore 0169

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Z", "GetAHandler")]
		public virtual unsafe bool A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_a);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "()Z"));
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		static IntPtr id_pause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='pause' and count(parameter)=0]"
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PrepareAsync ();
		}
#pragma warning restore 0169

		static IntPtr id_prepareAsync;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='prepareAsync' and count(parameter)=0]"
		[Register ("prepareAsync", "()V", "GetPrepareAsyncHandler")]
		public virtual unsafe void PrepareAsync ()
		{
			if (id_prepareAsync == IntPtr.Zero)
				id_prepareAsync = JNIEnv.GetMethodID (class_ref, "prepareAsync", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_prepareAsync);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "prepareAsync", "()V"));
			} finally {
			}
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		static IntPtr id_release;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "release", "()V"));
			} finally {
			}
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()V"));
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SeekTo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_seekTo_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='seekTo' and count(parameter)=1 and parameter[1][@type='long']]"
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetDataSource (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setDataSource_Landroid_content_Context_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='setDataSource' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
		[Register ("setDataSource", "(Landroid/content/Context;Landroid/net/Uri;)V", "GetSetDataSource_Landroid_content_Context_Landroid_net_Uri_Handler")]
		public virtual unsafe void SetDataSource (global::Android.Content.Context p0, global::Android.Net.Uri p1)
		{
			if (id_setDataSource_Landroid_content_Context_Landroid_net_Uri_ == IntPtr.Zero)
				id_setDataSource_Landroid_content_Context_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "setDataSource", "(Landroid/content/Context;Landroid/net/Uri;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDataSource_Landroid_content_Context_Landroid_net_Uri_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDataSource", "(Landroid/content/Context;Landroid/net/Uri;)V"), __args);
			} finally {
			}
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetDataSource (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setDataSource_Landroid_content_Context_Landroid_net_Uri_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='setDataSource' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("setDataSource", "(Landroid/content/Context;Landroid/net/Uri;Ljava/util/Map;)V", "GetSetDataSource_Landroid_content_Context_Landroid_net_Uri_Ljava_util_Map_Handler")]
		public virtual unsafe void SetDataSource (global::Android.Content.Context p0, global::Android.Net.Uri p1, global::System.Collections.Generic.IDictionary<string, string> p2)
		{
			if (id_setDataSource_Landroid_content_Context_Landroid_net_Uri_Ljava_util_Map_ == IntPtr.Zero)
				id_setDataSource_Landroid_content_Context_Landroid_net_Uri_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setDataSource", "(Landroid/content/Context;Landroid/net/Uri;Ljava/util/Map;)V");
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDataSource_Landroid_content_Context_Landroid_net_Uri_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDataSource", "(Landroid/content/Context;Landroid/net/Uri;Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.FileDescriptor p0 = global::Java.Lang.Object.GetObject<global::Java.IO.FileDescriptor> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDataSource (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDataSource_Ljava_io_FileDescriptor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='setDataSource' and count(parameter)=1 and parameter[1][@type='java.io.FileDescriptor']]"
		[Register ("setDataSource", "(Ljava/io/FileDescriptor;)V", "GetSetDataSource_Ljava_io_FileDescriptor_Handler")]
		public virtual unsafe void SetDataSource (global::Java.IO.FileDescriptor p0)
		{
			if (id_setDataSource_Ljava_io_FileDescriptor_ == IntPtr.Zero)
				id_setDataSource_Ljava_io_FileDescriptor_ = JNIEnv.GetMethodID (class_ref, "setDataSource", "(Ljava/io/FileDescriptor;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDataSource_Ljava_io_FileDescriptor_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDataSource", "(Ljava/io/FileDescriptor;)V"), __args);
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDebugLoggingEnabled (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDebugLoggingEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='setDebugLoggingEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder p0 = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDisplay (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDisplay_Landroid_view_SurfaceHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='setDisplay' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
		[Register ("setDisplay", "(Landroid/view/SurfaceHolder;)V", "GetSetDisplay_Landroid_view_SurfaceHolder_Handler")]
		public virtual unsafe void SetDisplay (global::Android.Views.ISurfaceHolder p0)
		{
			if (id_setDisplay_Landroid_view_SurfaceHolder_ == IntPtr.Zero)
				id_setDisplay_Landroid_view_SurfaceHolder_ = JNIEnv.GetMethodID (class_ref, "setDisplay", "(Landroid/view/SurfaceHolder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDisplay_Landroid_view_SurfaceHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisplay", "(Landroid/view/SurfaceHolder;)V"), __args);
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnBufferingUpdateListener p0 = (global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnBufferingUpdateListener)global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnBufferingUpdateListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnBufferingUpdateListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnBufferingUpdateListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnBufferingUpdateListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='setOnBufferingUpdateListener' and count(parameter)=1 and parameter[1][@type='com.pili.pldroid.player.PLMediaPlayer.OnBufferingUpdateListener']]"
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnCompletionListener p0 = (global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnCompletionListener)global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnCompletionListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnCompletionListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnCompletionListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnCompletionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='setOnCompletionListener' and count(parameter)=1 and parameter[1][@type='com.pili.pldroid.player.PLMediaPlayer.OnCompletionListener']]"
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnErrorListener p0 = (global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnErrorListener)global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnErrorListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnErrorListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnErrorListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnErrorListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='setOnErrorListener' and count(parameter)=1 and parameter[1][@type='com.pili.pldroid.player.PLMediaPlayer.OnErrorListener']]"
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnInfoListener p0 = (global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnInfoListener)global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnInfoListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnInfoListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnInfoListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnInfoListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='setOnInfoListener' and count(parameter)=1 and parameter[1][@type='com.pili.pldroid.player.PLMediaPlayer.OnInfoListener']]"
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnPreparedListener p0 = (global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnPreparedListener)global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnPreparedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnPreparedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnPreparedListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnPreparedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='setOnPreparedListener' and count(parameter)=1 and parameter[1][@type='com.pili.pldroid.player.PLMediaPlayer.OnPreparedListener']]"
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnSeekCompleteListener p0 = (global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnSeekCompleteListener)global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnSeekCompleteListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnSeekCompleteListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnSeekCompleteListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnSeekCompleteListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='setOnSeekCompleteListener' and count(parameter)=1 and parameter[1][@type='com.pili.pldroid.player.PLMediaPlayer.OnSeekCompleteListener']]"
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnVideoSizeChangedListener p0 = (global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnVideoSizeChangedListener)global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer.IOnVideoSizeChangedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnVideoSizeChangedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnVideoSizeChangedListener_Lcom_pili_pldroid_player_PLMediaPlayer_OnVideoSizeChangedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='setOnVideoSizeChangedListener' and count(parameter)=1 and parameter[1][@type='com.pili.pldroid.player.PLMediaPlayer.OnVideoSizeChangedListener']]"
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScreenOnWhilePlaying (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScreenOnWhilePlaying_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='setScreenOnWhilePlaying' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Surface p0 = global::Java.Lang.Object.GetObject<global::Android.Views.Surface> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSurface (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSurface_Landroid_view_Surface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='setSurface' and count(parameter)=1 and parameter[1][@type='android.view.Surface']]"
		[Register ("setSurface", "(Landroid/view/Surface;)V", "GetSetSurface_Landroid_view_Surface_Handler")]
		public virtual unsafe void SetSurface (global::Android.Views.Surface p0)
		{
			if (id_setSurface_Landroid_view_Surface_ == IntPtr.Zero)
				id_setSurface_Landroid_view_Surface_ = JNIEnv.GetMethodID (class_ref, "setSurface", "(Landroid/view/Surface;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSurface_Landroid_view_Surface_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSurface", "(Landroid/view/Surface;)V"), __args);
			} finally {
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetVolume (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setVolume_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='setVolume' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetWakeMode (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setWakeMode_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='setWakeMode' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='start' and count(parameter)=0]"
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
			global::Com.Pili.Pldroid.Player.PLMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Pili.Pldroid.Player.PLMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pili.pldroid.player']/class[@name='PLMediaPlayer']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
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
