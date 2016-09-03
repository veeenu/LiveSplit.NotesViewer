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

    private List<string> notes;
    private int counterino = 0;
    private long time = 0;

    public NotesViewer(LiveSplitState state) {

      Settings = new NotesViewerSettings();
      notes = new List<string>();

      state.OnStart += onSplitChange;

      onSplitChange(null, null);

      time = DateTime.Now.Ticks;

    }

    private void onSplitChange(object sender, EventArgs e) {

      var lines = Settings.NotesText.Split('\n');
      string curNote = "";

      notes.Clear();

      if (lines.Length < 2) return;

      foreach (var l in lines) {

        if (l[0] == '#') {

          if (curNote != "") {
            notes.Add(curNote);
            curNote = "";
          }
            
        } else {

          curNote += l + '\n';
        }
      }

      notes.Add(curNote);
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

        float x = 0.0F;
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

        g.DrawString(text, state.LayoutSettings.TextFont, new SolidBrush(state.LayoutSettings.TextColor), x, (float)y, drawFormat);
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
