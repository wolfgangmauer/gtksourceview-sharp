// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSourceView {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	[SourceTagStyle]
	public struct SourceTagStyle {

		public bool IsDefault;
		public uint Mask;
		public Gdk.Color Foreground;
		public Gdk.Color Background;
		public bool Italic;
		public bool Bold;
		public bool Underline;
		public bool Strikethrough;
		[MarshalAs (UnmanagedType.ByValArray, SizeConst=16)]
		public byte[] Reserved;

		public static GtkSourceView.SourceTagStyle Zero = new GtkSourceView.SourceTagStyle ();

		public static GtkSourceView.SourceTagStyle New (IntPtr raw) {
			if (raw == IntPtr.Zero)
				return GtkSourceView.SourceTagStyle.Zero;
			return Marshal.PtrToStructure<GtkSourceView.SourceTagStyle> (raw);
		}

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_source_tag_style_new();

		public static SourceTagStyle New()
		{
			SourceTagStyle result = SourceTagStyle.New (gtk_source_tag_style_new());
			return result;
		}

		[DllImport("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_source_tag_style_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_source_tag_style_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("glibsharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr glibsharp_value_get_boxed (ref GLib.Value val);

		[DllImport("glibsharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void glibsharp_value_set_boxed (ref GLib.Value val, ref GtkSourceView.SourceTagStyle boxed);

		public static explicit operator GLib.Value (GtkSourceView.SourceTagStyle boxed)
		{
			GLib.Value val = GLib.Value.Empty;
			val.Init (SourceTagStyleAttribute.GType);
			glibsharp_value_set_boxed (ref val, ref boxed);
			return val;
		}

		public static explicit operator GtkSourceView.SourceTagStyle (GLib.Value val)
		{
			IntPtr boxed_ptr = glibsharp_value_get_boxed (ref val);
			return New (boxed_ptr);
		}
#endregion
	}

	internal class SourceTagStyleAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("gtksourceview-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_source_tag_style_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gtk_source_tag_style_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
