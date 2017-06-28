using System;
using System.Collections.Generic;
using Android.Runtime;

namespace TV.Danmaku.Ijk.Media.Player.Misc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/interface[@name='IMediaDataSource']"
	[Register ("tv/danmaku/ijk/media/player/misc/IMediaDataSource", "", "TV.Danmaku.Ijk.Media.Player.Misc.IMediaDataSourceInvoker")]
	public partial interface IMediaDataSource : IJavaObject {

		long Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/interface[@name='IMediaDataSource']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()J", "GetGetSizeHandler:TV.Danmaku.Ijk.Media.Player.Misc.IMediaDataSourceInvoker, QiNiu.PLPlayer.Droid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/interface[@name='IMediaDataSource']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler:TV.Danmaku.Ijk.Media.Player.Misc.IMediaDataSourceInvoker, QiNiu.PLPlayer.Droid")]
		void Close ();

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/interface[@name='IMediaDataSource']/method[@name='readAt' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("readAt", "(J[BII)I", "GetReadAt_JarrayBIIHandler:TV.Danmaku.Ijk.Media.Player.Misc.IMediaDataSourceInvoker, QiNiu.PLPlayer.Droid")]
		int ReadAt (long p0, byte[] p1, int p2, int p3);

	}

	[global::Android.Runtime.Register ("tv/danmaku/ijk/media/player/misc/IMediaDataSource", DoNotGenerateAcw=true)]
	internal class IMediaDataSourceInvoker : global::Java.Lang.Object, IMediaDataSource {

		static IntPtr java_class_ref = JNIEnv.FindClass ("tv/danmaku/ijk/media/player/misc/IMediaDataSource");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMediaDataSourceInvoker); }
		}

		IntPtr class_ref;

		public static IMediaDataSource GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMediaDataSource> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "tv.danmaku.ijk.media.player.misc.IMediaDataSource"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMediaDataSourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getSize;
#pragma warning disable 0169
		static Delegate GetGetSizeHandler ()
		{
			if (cb_getSize == null)
				cb_getSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetSize);
			return cb_getSize;
		}

		static long n_GetSize (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.Misc.IMediaDataSource __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.Misc.IMediaDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size;
		}
#pragma warning restore 0169

		IntPtr id_getSize;
		public unsafe long Size {
			get {
				if (id_getSize == IntPtr.Zero)
					id_getSize = JNIEnv.GetMethodID (class_ref, "getSize", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getSize);
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.Misc.IMediaDataSource __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.Misc.IMediaDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		IntPtr id_close;
		public unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
		}

		static Delegate cb_readAt_JarrayBII;
#pragma warning disable 0169
		static Delegate GetReadAt_JarrayBIIHandler ()
		{
			if (cb_readAt_JarrayBII == null)
				cb_readAt_JarrayBII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, int, int, int>) n_ReadAt_JarrayBII);
			return cb_readAt_JarrayBII;
		}

		static int n_ReadAt_JarrayBII (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, int p2, int p3)
		{
			global::TV.Danmaku.Ijk.Media.Player.Misc.IMediaDataSource __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.Misc.IMediaDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.ReadAt (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_readAt_JarrayBII;
		public unsafe int ReadAt (long p0, byte[] p1, int p2, int p3)
		{
			if (id_readAt_JarrayBII == IntPtr.Zero)
				id_readAt_JarrayBII = JNIEnv.GetMethodID (class_ref, "readAt", "(J[BII)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readAt_JarrayBII, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

	}

}
