using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.NotesViewer {
  public partial class NotesViewerSettings : UserControl {

    public string NotesFile { get; set; }
    public int CtrlHeight { get; set; }

    public NotesViewerSettings() {
      InitializeComponent();
      //NotesText = "# First split\r\nExample 1\r\nExample 1\r\nExample 1\r\nExample 1\r\n# Second split\r\nExample 2\r\nExample 2\r\nExample 2\r\nExample 2\r\n# Third split\r\nExample 3\r\nExample 3\r\nExample 3\r\nExample 3";
      CtrlHeight = 512;

      notesFile.DataBindings.Add("Text", this, "NotesFile", false, DataSourceUpdateMode.OnPropertyChanged);
      heightBox.DataBindings.Add("Value", this, "CtrlHeight", false, DataSourceUpdateMode.OnPropertyChanged);
    }

    public void SetSettings(XmlNode node) {
      var el = (XmlElement)node;
      Version version = new Version(el["Version"].InnerText);
      NotesFile = el["NotesFile"].InnerText;

      int boh = 512;
      if(!el["CtrlHeight"].Equals(null))
        int.TryParse(el["CtrlHeight"].InnerText, out boh);

      Console.WriteLine(el);

      CtrlHeight = boh;
      
    }

    public XmlNode GetSettings(XmlDocument document) {
      var parent = document.CreateElement("Settings");

      var verEl = document.CreateElement("Version");
      verEl.InnerText = "1.6";
      parent.AppendChild(verEl);

      var memEl = document.CreateElement("NotesFile");
      memEl.InnerText = NotesFile;
      parent.AppendChild(memEl);

      var hgtEl = document.CreateElement("CtrlHeight");
      hgtEl.InnerText = String.Format("{0}", CtrlHeight);
      parent.AppendChild(hgtEl);

      return parent;
    }

    public int GetSettingsHashCode() => 31337;

  }
}
