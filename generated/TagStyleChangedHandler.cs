// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSourceView {

	using System;

	public delegate void TagStyleChangedHandler(object o, TagStyleChangedArgs args);

	public class TagStyleChangedArgs : GLib.SignalArgs {
		public string Name{
			get {
				return (string) Args [0];
			}
		}

	}
}
