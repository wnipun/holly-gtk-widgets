// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace test {
    
    
    public partial class MainWin {
        
        private Gtk.VBox vbox1;
        
        private Gtk.HBox hbox1;
        
        private Gtk.Button button2;
        
        private Gtk.Button button3;
        
        private Gtk.Button button4;
        
        private HollyLibrary.HFontPicker BtnMoreColors;
        
        private HollyLibrary.HColorPicker hcolorpicker1;
        
        private HollyLibrary.HRegExEntry hregexentry1;
        
        private Gtk.ScrolledWindow GtkScrolledWindow;
        
        private HollyLibrary.HSimpleList hsimplelist1;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget test.MainWin
            this.Name = "test.MainWin";
            this.Title = Mono.Unix.Catalog.GetString("MainWin");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            // Container child test.MainWin.Gtk.Container+ContainerChild
            this.vbox1 = new Gtk.VBox();
            this.vbox1.Name = "vbox1";
            this.vbox1.Spacing = 6;
            // Container child vbox1.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.button2 = new Gtk.Button();
            this.button2.CanFocus = true;
            this.button2.Name = "button2";
            this.button2.UseUnderline = true;
            this.button2.Label = Mono.Unix.Catalog.GetString("button2");
            this.hbox1.Add(this.button2);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.hbox1[this.button2]));
            w1.Position = 0;
            // Container child hbox1.Gtk.Box+BoxChild
            this.button3 = new Gtk.Button();
            this.button3.CanFocus = true;
            this.button3.Name = "button3";
            this.button3.UseUnderline = true;
            this.button3.Label = Mono.Unix.Catalog.GetString("button3");
            this.hbox1.Add(this.button3);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox1[this.button3]));
            w2.Position = 1;
            // Container child hbox1.Gtk.Box+BoxChild
            this.button4 = new Gtk.Button();
            this.button4.CanFocus = true;
            this.button4.Name = "button4";
            this.button4.UseUnderline = true;
            this.button4.Label = Mono.Unix.Catalog.GetString("button4");
            this.hbox1.Add(this.button4);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox1[this.button4]));
            w3.Position = 2;
            this.vbox1.Add(this.hbox1);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
            w4.Position = 0;
            // Container child vbox1.Gtk.Box+BoxChild
            this.BtnMoreColors = new HollyLibrary.HFontPicker();
            this.BtnMoreColors.Events = ((Gdk.EventMask)(256));
            this.BtnMoreColors.Name = "BtnMoreColors";
            this.vbox1.Add(this.BtnMoreColors);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.vbox1[this.BtnMoreColors]));
            w5.Position = 1;
            // Container child vbox1.Gtk.Box+BoxChild
            this.hcolorpicker1 = new HollyLibrary.HColorPicker();
            this.hcolorpicker1.Events = ((Gdk.EventMask)(256));
            this.hcolorpicker1.Name = "hcolorpicker1";
            this.vbox1.Add(this.hcolorpicker1);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.vbox1[this.hcolorpicker1]));
            w6.Position = 2;
            // Container child vbox1.Gtk.Box+BoxChild
            this.hregexentry1 = new HollyLibrary.HRegExEntry();
            this.hregexentry1.Events = ((Gdk.EventMask)(256));
            this.hregexentry1.Name = "hregexentry1";
            this.vbox1.Add(this.hregexentry1);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.vbox1[this.hregexentry1]));
            w7.Position = 3;
            // Container child vbox1.Gtk.Box+BoxChild
            this.GtkScrolledWindow = new Gtk.ScrolledWindow();
            this.GtkScrolledWindow.Name = "GtkScrolledWindow";
            this.GtkScrolledWindow.ShadowType = ((Gtk.ShadowType)(1));
            // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
            this.hsimplelist1 = new HollyLibrary.HSimpleList();
            this.hsimplelist1.CanFocus = true;
            this.hsimplelist1.Name = "hsimplelist1";
            this.hsimplelist1.HeadersClickable = true;
            this.hsimplelist1.ItemHeight = 0;
            this.hsimplelist1.SelectedIndex = 0;
            this.hsimplelist1.OwnerDraw = false;
            this.GtkScrolledWindow.Add(this.hsimplelist1);
            this.vbox1.Add(this.GtkScrolledWindow);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.vbox1[this.GtkScrolledWindow]));
            w9.Position = 4;
            this.Add(this.vbox1);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 400;
            this.DefaultHeight = 289;
            this.Show();
            this.DeleteEvent += new Gtk.DeleteEventHandler(this.OnDeleteEvent);
        }
    }
}
