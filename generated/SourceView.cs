// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSourceView {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[SourceView]
	public class SourceView : Gtk.TextView {

		[Obsolete]
		protected SourceView(GLib.GType gtype) : base(gtype) {}
		public SourceView(IntPtr raw) : base(raw) {}

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_source_view_new();

		public SourceView () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (SourceView)) {
				CreateNativeObject (Array.Empty<IntPtr> (), Array.Empty<GLib.Value> (), 0);
				return;
			}
			owned = true;
			Raw = gtk_source_view_new();
		}

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_source_view_new_with_buffer(IntPtr buffer);

		public SourceView (GtkSourceView.SourceBuffer buffer) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (SourceView)) {
				var vals = new GLib.Value[1];
				var names = new IntPtr[1];
				var param_count = 0;
				if (buffer != null) {
					names[param_count] = GLib.Marshaller.StringToPtrGStrdup ("buffer");
					vals[param_count++] = new GLib.Value (buffer);
				}
				CreateNativeObject (names, vals, param_count);
				return;
			}
			owned = true;
			Raw = gtk_source_view_new_with_buffer(buffer == null ? IntPtr.Zero : buffer.Handle);
		}

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_source_view_get_insert_spaces_instead_of_tabs(IntPtr raw);

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_source_view_set_insert_spaces_instead_of_tabs(IntPtr raw, bool enable);

		[GLib.Property ("insert_spaces_instead_of_tabs")]
		public bool InsertSpacesInsteadOfTabs {
			get  {
				bool raw_ret = gtk_source_view_get_insert_spaces_instead_of_tabs(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_source_view_set_insert_spaces_instead_of_tabs(Handle, value);
			}
		}

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gtk_source_view_get_tabs_width(IntPtr raw);

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_source_view_set_tabs_width(IntPtr raw, uint width);

		[GLib.Property ("tabs_width")]
		public uint TabsWidth {
			get  {
				uint raw_ret = gtk_source_view_get_tabs_width(Handle);
				uint ret = raw_ret;
				return ret;
			}
			set  {
				gtk_source_view_set_tabs_width(Handle, value);
			}
		}

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_source_view_get_auto_indent(IntPtr raw);

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_source_view_set_auto_indent(IntPtr raw, bool enable);

		[GLib.Property ("auto_indent")]
		public bool AutoIndent {
			get  {
				bool raw_ret = gtk_source_view_get_auto_indent(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_source_view_set_auto_indent(Handle, value);
			}
		}

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_source_view_get_smart_home_end(IntPtr raw);

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_source_view_set_smart_home_end(IntPtr raw, bool enable);

		[GLib.Property ("smart_home_end")]
		public bool SmartHomeEnd {
			get  {
				bool raw_ret = gtk_source_view_get_smart_home_end(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_source_view_set_smart_home_end(Handle, value);
			}
		}

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_source_view_get_show_line_numbers(IntPtr raw);

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_source_view_set_show_line_numbers(IntPtr raw, bool show);

		[GLib.Property ("show_line_numbers")]
		public bool ShowLineNumbers {
			get  {
				bool raw_ret = gtk_source_view_get_show_line_numbers(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_source_view_set_show_line_numbers(Handle, value);
			}
		}

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_source_view_get_show_margin(IntPtr raw);

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_source_view_set_show_margin(IntPtr raw, bool show);

		[GLib.Property ("show_margin")]
		public bool ShowMargin {
			get  {
				bool raw_ret = gtk_source_view_get_show_margin(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_source_view_set_show_margin(Handle, value);
			}
		}

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gtk_source_view_get_margin(IntPtr raw);

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_source_view_set_margin(IntPtr raw, uint margin);

		[GLib.Property ("margin")]
		public uint Margin {
			get  {
				uint raw_ret = gtk_source_view_get_margin(Handle);
				uint ret = raw_ret;
				return ret;
			}
			set  {
				gtk_source_view_set_margin(Handle, value);
			}
		}

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_source_view_get_show_line_markers(IntPtr raw);

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_source_view_set_show_line_markers(IntPtr raw, bool show);

		[GLib.Property ("show_line_markers")]
		public bool ShowLineMarkers {
			get  {
				bool raw_ret = gtk_source_view_get_show_line_markers(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_source_view_set_show_line_markers(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void UndoVMDelegate (IntPtr view);

		static UndoVMDelegate UndoVMCallback;

		static void undo_cb (IntPtr view)
		{
			try {
				SourceView view_managed = GLib.Object.GetObject (view, false) as SourceView;
				view_managed.OnUndo ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideUndo (GLib.GType gtype)
		{
			if (UndoVMCallback == null)
				UndoVMCallback = new UndoVMDelegate (undo_cb);
			OverrideVirtualMethod (gtype, "undo", UndoVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(GtkSourceView.SourceView), ConnectionMethod="OverrideUndo")]
		protected virtual void OnUndo ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			using (var val0 = new GLib.Value (this)) {
				inst_and_params.Append (val0);
				g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			}
		}

		[GLib.Signal("undo")]
		public event System.EventHandler Undo {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "undo");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "undo");
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void RedoVMDelegate (IntPtr view);

		static RedoVMDelegate RedoVMCallback;

		static void redo_cb (IntPtr view)
		{
			try {
				SourceView view_managed = GLib.Object.GetObject (view, false) as SourceView;
				view_managed.OnRedo ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideRedo (GLib.GType gtype)
		{
			if (RedoVMCallback == null)
				RedoVMCallback = new RedoVMDelegate (redo_cb);
			OverrideVirtualMethod (gtype, "redo", RedoVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(GtkSourceView.SourceView), ConnectionMethod="OverrideRedo")]
		protected virtual void OnRedo ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			using (var val0 = new GLib.Value (this)) {
				inst_and_params.Append (val0);
				g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			}
		}

		[GLib.Signal("redo")]
		public event System.EventHandler Redo {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "redo");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "redo");
				sig.RemoveDelegate (value);
			}
		}

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_source_view_set_marker_pixbuf(IntPtr raw, IntPtr marker_type, IntPtr pixbuf);

		public void SetMarkerPixbuf(string marker_type, Gdk.Pixbuf pixbuf) {
			IntPtr native_marker_type = GLib.Marshaller.StringToPtrGStrdup (marker_type);
			gtk_source_view_set_marker_pixbuf(Handle, native_marker_type, pixbuf == null ? IntPtr.Zero : pixbuf.Handle);
			GLib.Marshaller.Free (native_marker_type);
		}

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_source_view_get_type();

		static GLib.GType _gtype = new GLib.GType (gtk_source_view_get_type());
		public static new GLib.GType GType { 
			get {
								return _gtype;
			}
		}

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtksourceview_gettext(IntPtr msgid);

		public static string Gettext(string msgid) {
			IntPtr native_msgid = GLib.Marshaller.StringToPtrGStrdup (msgid);
			IntPtr raw_ret = gtksourceview_gettext(native_msgid);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			GLib.Marshaller.Free (native_msgid);
			return ret;
		}

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_source_view_get_marker_pixbuf(IntPtr raw, IntPtr marker_type);

		public Gdk.Pixbuf GetMarkerPixbuf(string marker_type) {
			IntPtr native_marker_type = GLib.Marshaller.StringToPtrGStrdup (marker_type);
			IntPtr raw_ret = gtk_source_view_get_marker_pixbuf(Handle, native_marker_type);
			Gdk.Pixbuf ret = GLib.Object.GetObject(raw_ret) as Gdk.Pixbuf;
			GLib.Marshaller.Free (native_marker_type);
			return ret;
		}


		static SourceView ()
		{
			GtkSharp.GtksourceviewSharp.ObjectManager.Initialize ();
		}
#endregion
	}

	internal class SourceViewAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_source_view_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gtk_source_view_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}