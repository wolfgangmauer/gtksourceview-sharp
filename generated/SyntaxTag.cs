// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSourceView {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[SyntaxTag]
	public class SyntaxTag : GtkSourceView.SourceTag {

		[Obsolete]
		protected SyntaxTag(GLib.GType gtype) : base(gtype) {}
		public SyntaxTag(IntPtr raw) : base(raw) {}

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_syntax_tag_new(IntPtr id, IntPtr name, IntPtr pattern_start, IntPtr pattern_end);

		public SyntaxTag (string id, string name, string pattern_start, string pattern_end) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (SyntaxTag)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			IntPtr native_id = GLib.Marshaller.StringToPtrGStrdup (id);
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr native_pattern_start = GLib.Marshaller.StringToPtrGStrdup (pattern_start);
			IntPtr native_pattern_end = GLib.Marshaller.StringToPtrGStrdup (pattern_end);
			owned = true;
			Raw = gtk_syntax_tag_new(native_id, native_name, native_pattern_start, native_pattern_end);
			GLib.Marshaller.Free (native_id);
			GLib.Marshaller.Free (native_name);
			GLib.Marshaller.Free (native_pattern_start);
			GLib.Marshaller.Free (native_pattern_end);
		}

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_syntax_tag_get_type();

		static GLib.GType _gtype = new GLib.GType (gtk_syntax_tag_get_type());
		public static new GLib.GType GType { 
			get {
								return _gtype;
			}
		}


		static SyntaxTag ()
		{
			GtkSharp.GtksourceviewSharp.ObjectManager.Initialize ();
		}
#endregion
	}

	internal class SyntaxTagAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_syntax_tag_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gtk_syntax_tag_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}