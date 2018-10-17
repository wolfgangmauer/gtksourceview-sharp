// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSourceView {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[SourceTag]
	public class SourceTag : Gtk.TextTag {

		[Obsolete]
		protected SourceTag(GLib.GType gtype) : base(gtype) {}
		public SourceTag(IntPtr raw) : base(raw) {}

		protected SourceTag() : base(IntPtr.Zero)
		{
			CreateNativeObject (Array.Empty<IntPtr> (), Array.Empty<GLib.Value> (), 0);
		}

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_source_tag_get_id(IntPtr raw);

		[GLib.Property ("id")]
		public string Id {
			get  {
				IntPtr raw_ret = gtk_source_tag_get_id(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[GLib.Property ("tag_style")]
		public GtkSourceView.SourceTagStyle TagStyle {
			get {
				using (GLib.Value val = GetProperty ("tag_style")) {
					GtkSourceView.SourceTagStyle ret = (GtkSourceView.SourceTagStyle) val;
					return ret;
				}
			}
			set {
				using (GLib.Value val = (GLib.Value) value) {
					SetProperty("tag_style", val);
				}
			}
		}

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_source_tag_get_type();

		static GLib.GType _gtype = new GLib.GType (gtk_source_tag_get_type());
		public static new GLib.GType GType { 
			get {
								return _gtype;
			}
		}


		static SourceTag ()
		{
			GtkSharp.GtksourceviewSharp.ObjectManager.Initialize ();
		}
#endregion
	}

	internal class SourceTagAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_source_tag_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gtk_source_tag_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}