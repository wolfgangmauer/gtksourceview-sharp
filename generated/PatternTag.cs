// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSourceView {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[PatternTag]
	public class PatternTag : GtkSourceView.SourceTag {

		[Obsolete]
		protected PatternTag(GLib.GType gtype) : base(gtype) {}
		public PatternTag(IntPtr raw) : base(raw) {}

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_pattern_tag_new(IntPtr id, IntPtr name, IntPtr pattern);

		public PatternTag (string id, string name, string pattern) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (PatternTag)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			IntPtr native_id = GLib.Marshaller.StringToPtrGStrdup (id);
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr native_pattern = GLib.Marshaller.StringToPtrGStrdup (pattern);
			owned = true;
			Raw = gtk_pattern_tag_new(native_id, native_name, native_pattern);
			GLib.Marshaller.Free (native_id);
			GLib.Marshaller.Free (native_name);
			GLib.Marshaller.Free (native_pattern);
		}

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_pattern_tag_get_type();

		static GLib.GType _gtype = new GLib.GType (gtk_pattern_tag_get_type());
		public static new GLib.GType GType { 
			get {
								return _gtype;
			}
		}


		static PatternTag ()
		{
			GtkSharp.GtksourceviewSharp.ObjectManager.Initialize ();
		}
#endregion
	}

	internal class PatternTagAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_pattern_tag_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gtk_pattern_tag_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
