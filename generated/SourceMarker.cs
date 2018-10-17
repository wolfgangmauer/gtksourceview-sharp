// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSourceView {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[SourceMarker]
	public class SourceMarker : Gtk.TextMark {

		[Obsolete]
		protected SourceMarker(GLib.GType gtype) : base(gtype) {}
		public SourceMarker(IntPtr raw) : base(raw) {}

		protected SourceMarker() : base(IntPtr.Zero)
		{
			CreateNativeObject (Array.Empty<IntPtr> (), Array.Empty<GLib.Value> (), 0);
		}

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_source_marker_get_type();

		static GLib.GType _gtype = new GLib.GType (gtk_source_marker_get_type());
		public static new GLib.GType GType { 
			get {
								return _gtype;
			}
		}

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_source_marker_get_line(IntPtr raw);

		public int Line { 
			get {
				int raw_ret = gtk_source_marker_get_line(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_source_marker_prev(IntPtr raw);

		public GtkSourceView.SourceMarker Prev() {
			IntPtr raw_ret = gtk_source_marker_prev(Handle);
			GtkSourceView.SourceMarker ret = GLib.Object.GetObject(raw_ret) as GtkSourceView.SourceMarker;
			return ret;
		}

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_source_marker_next(IntPtr raw);

		public GtkSourceView.SourceMarker Next() {
			IntPtr raw_ret = gtk_source_marker_next(Handle);
			GtkSourceView.SourceMarker ret = GLib.Object.GetObject(raw_ret) as GtkSourceView.SourceMarker;
			return ret;
		}

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_source_marker_get_marker_type(IntPtr raw);

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_source_marker_set_marker_type(IntPtr raw, IntPtr type);

		public string MarkerType { 
			get {
				IntPtr raw_ret = gtk_source_marker_get_marker_type(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_source_marker_set_marker_type(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_source_marker_get_buffer(IntPtr raw);

		public new GtkSourceView.SourceBuffer Buffer { 
			get {
				IntPtr raw_ret = gtk_source_marker_get_buffer(Handle);
				GtkSourceView.SourceBuffer ret = GLib.Object.GetObject(raw_ret) as GtkSourceView.SourceBuffer;
				return ret;
			}
		}


		static SourceMarker ()
		{
			GtkSharp.GtksourceviewSharp.ObjectManager.Initialize ();
		}
#endregion
	}

	internal class SourceMarkerAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_source_marker_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gtk_source_marker_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
