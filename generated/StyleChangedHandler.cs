// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSourceView {

	using System;

	public delegate void StyleChangedHandler(object o, StyleChangedArgs args);

	public class StyleChangedArgs : GLib.SignalArgs {
		public string TagId{
			get {
				return (string) Args [0];
			}
		}

	}
}