using LiveSplit.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using LiveSplit.UI.Components;
using LiveSplit.UI;
using System.Text.RegularExpressions;

namespace LiveSplit.NotesViewer {
  public class NotesViewer : IComponent {
    public string ComponentName => "Notes Viewer";

    public NotesViewerSettings Settings { get; set; }

    public IDictionary<string, Action> ContextMenuControls => null;

    public float HorizontalWidth => 128f;
    public float VerticalHeight => (!Settings.Equals(null) ? (Settings.CtrlHeight == 0 ?  512f : Settings.CtrlHeight) : 512f);

    public float MinimumHeight => 16f;
    public float MinimumWidth => 16f;

    public float PaddingBottom => 7f;
    public float PaddingLeft => 7f;
    public float PaddingRight => 7f;
    public float PaddingTop => 7f;

    private List<SplitNote> notes;
    private int counterino = 0;
    private long time = 0;

    public NotesViewer(LiveSplitState state) {

      Settings = new NotesViewerSettings();
      Settings.NotesFile = new Regex(@"(.+)\.\w+$").Replace(state.Run.FilePath, "$1.txt");

      if(!System.IO.File.Exists(Settings.NotesFile)) {
        System.IO.File.WriteAllText(Settings.NotesFile, "# First split\n\nExample 1\nExample 1\nExample 1\n\n# Second split\n\nExample2 \nExample 2\nExample 2\n\n# Third split\n\nExample 3\nExample 3\nExample 3\n\n");
      }

      notes = new List<SplitNote>();

      state.OnStart += onSplitChange;

      onSplitChange(null, null);

      time = DateTime.Now.Ticks;

    }
    

    private void onSplitChange(object sender, EventArgs e) {
      try {

        var sr = new System.IO.StreamReader(Settings.NotesFile);

        string curNote = "", line;
        var regex = new Regex(@"^\s+(.+)\s+$");

        notes.Clear();

        while((line = sr.ReadLine()) != null) {
          if(line.Length > 0 && line[0] == '#') {
            if(curNote != "") {
              notes.Add(new SplitNote((regex.Replace(curNote, "$1"))));
              curNote = "";
            }
          } else {
            curNote += line + '\n';
          }
        }

        notes.Add(new SplitNote(regex.Replace(curNote, "$1")));

      } catch(Exception ex) {
        notes.Clear();
      }

      /*var lines = Settings.NotesText.Split('\n');
      string curNote = "";

      notes.Clear();

      if (lines.Length < 2) return;

      foreach (var l in lines) {

        if (l.Length > 0 && l[0] == '#') {

          if (curNote != "") {
            notes.Add(curNote);
            curNote = "";
          }
            
        } else {

          curNote += l + '\n';
        }
      }

      notes.Add((new Regex(@"^\s+(.+)\s+$")).Replace(curNote, "$1"));*/
      //notes.RemoveAt(0);
      //foreach (var i in notes)
      //  System.Diagnostics.Debug.WriteLine(i);

      counterino = notes.Count;
      time = DateTime.Now.Ticks;

    }

    public void Dispose() { }

    private void Draw(System.Drawing.Graphics g, LiveSplitState state, float width, float height, System.Drawing.Region clipRegion) {

      if(notes.Count == 0) onSplitChange(null, null);

      var index = Math.Min(notes.Count - 1, state.CurrentSplitIndex);

      //System.Diagnostics.Debug.WriteLine(String.Format("{0} {1} {2}", state.CurrentSplitIndex, notes.Count, index));

      if (index >= 0 && index < notes.Count) {

        SplitNote sn = notes.ElementAt(index);
        sn.draw(g, width, height, state.LayoutSettings.TextFont, state.LayoutSettings.TextColor);

        //g.DrawImage(sn.getImage(), new Point(0, 0));

        /*float x = 0.0F;
        double y = 0.0F;
        String text = notes.ElementAt(index);
        StringFormat drawFormat = new StringFormat();
        SizeF sz = g.MeasureString(text, state.LayoutSettings.TextFont);

        double span = Math.Max(-VerticalHeight + sz.Height, 0);
        long range = 100000000,
             tm = ((DateTime.Now.Ticks - time) % range);

        double d = (double)tm / (double)range;
        d = 2f * (d > 0.5 ? 1 - d : d);

        y = -span * d;

        g.DrawString(text, state.LayoutSettings.TextFont, new SolidBrush(state.LayoutSettings.TextColor), x, (float)y, drawFormat);*/
      }

    }

    public void DrawHorizontal(System.Drawing.Graphics g, LiveSplitState state, float height, System.Drawing.Region clipRegion) {
      Draw(g, state, HorizontalWidth, height, clipRegion);
    }

    public void DrawVertical(System.Drawing.Graphics g, LiveSplitState state, float width, System.Drawing.Region clipRegion) {
      Draw(g, state, width, VerticalHeight, clipRegion);
    }

    public XmlNode GetSettings(XmlDocument document) {
      return Settings.GetSettings(document);
    }

    public System.Windows.Forms.Control GetSettingsControl(LayoutMode mode) {
      return Settings;
    }

    public void SetSettings(XmlNode settings) {
      Settings.SetSettings(settings);
    }

    public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode) {
      if (invalidator != null)
        invalidator.Invalidate(0, 0, width, height);
    }
  }
}
