// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSourceView {

	using System;

	public delegate void HighlightUpdatedHandler(object o, HighlightUpdatedArgs args);

	public class HighlightUpdatedArgs : GLib.SignalArgs {
		public Gtk.TextIter Start{
			get {
				return (Gtk.TextIter) Args [0];
			}
		}

		public Gtk.TextIter End{
			get {
				return (Gtk.TextIter) Args [1];
			}
		}

	}
}
