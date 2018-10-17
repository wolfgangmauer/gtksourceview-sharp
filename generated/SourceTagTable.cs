// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSourceView {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[SourceTagTable]
	public class SourceTagTable : Gtk.TextTagTable {

		[Obsolete]
		protected SourceTagTable(GLib.GType gtype) : base(gtype) {}
		public SourceTagTable(IntPtr raw) : base(raw) {}

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_source_tag_table_new();

		public SourceTagTable () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (SourceTagTable)) {
				CreateNativeObject (Array.Empty<IntPtr> (), Array.Empty<GLib.Value> (), 0);
				return;
			}
			owned = true;
			Raw = gtk_source_tag_table_new();
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ChangedVMDelegate (IntPtr table);

		static ChangedVMDelegate ChangedVMCallback;

		static void changed_cb (IntPtr table)
		{
			try {
				SourceTagTable table_managed = GLib.Object.GetObject (table, false) as SourceTagTable;
				table_managed.OnChanged ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideChanged (GLib.GType gtype)
		{
			if (ChangedVMCallback == null)
				ChangedVMCallback = new ChangedVMDelegate (changed_cb);
			OverrideVirtualMethod (gtype, "changed", ChangedVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(GtkSourceView.SourceTagTable), ConnectionMethod="OverrideChanged")]
		protected virtual void OnChanged ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			using (var val0 = new GLib.Value (this)) {
				inst_and_params.Append (val0);
				g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			}
		}

		[GLib.Signal("changed")]
		public event System.EventHandler Changed {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "changed");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "changed");
				sig.RemoveDelegate (value);
			}
		}

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_source_tag_table_get_type();

		static GLib.GType _gtype = new GLib.GType (gtk_source_tag_table_get_type());
		public static new GLib.GType GType { 
			get {
								return _gtype;
			}
		}

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_source_tag_table_remove_source_tags(IntPtr raw);

		public void RemoveSourceTags() {
			gtk_source_tag_table_remove_source_tags(Handle);
		}


		static SourceTagTable ()
		{
			GtkSharp.GtksourceviewSharp.ObjectManager.Initialize ();
		}
#endregion
#region Customized extensions
#line 1 "SourceTagTable.custom"
		
		[DllImport("gtksourceview-1.0")]
		static extern void gtk_source_tag_table_add_tags(IntPtr raw, IntPtr tags);
                                                                                
		public void AddTags(SourceTag[] tags) {
			GLib.SList list = new GLib.SList (typeof (SourceTag));
			foreach (SourceTag tag in tags)
				list.Append (tag.Handle);
			gtk_source_tag_table_add_tags(Handle, list.Handle);
		}

#endregion
	}

	internal class SourceTagTableAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_source_tag_table_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gtk_source_tag_table_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
