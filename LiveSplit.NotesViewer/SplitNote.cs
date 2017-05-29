using System;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveSplit.NotesViewer {
  class SplitNote {

    private string splitText;

    private float lastWidth, lastHeight;
    private Font font;
    private StringFormat drawFormat;

    public SplitNote(string st) {
      splitText = st;
      lastWidth = lastHeight = -1.0f;
      drawFormat = new StringFormat();
    }

    public void draw(Graphics g, float w, float h, Font f, Color c) {

      if(lastWidth != w || lastHeight != h) {
        font = GetAdjustedFont(g, splitText, f, Convert.ToInt32(w), Convert.ToInt32(h), Convert.ToInt32(f.SizeInPoints), 5, false);
        lastWidth = w;
        lastHeight = h;
      };

      g.DrawString(splitText, font, new SolidBrush(c), 0, 0, drawFormat);
      
    }

    public Font GetAdjustedFont(Graphics GraphicRef, string GraphicString, Font OriginalFont, int ContainerWidth, int ContainerHeight, int MaxFontSize, int MinFontSize, bool SmallestOnFail) {
      Font testFont = null;
      // We utilize MeasureString which we get via a control instance           
      for (int AdjustedSize = MaxFontSize; AdjustedSize >= MinFontSize; AdjustedSize--) {
        testFont = new Font(OriginalFont.Name, AdjustedSize, OriginalFont.Style);

        // Test the string with the new size
        SizeF AdjustedSizeNew = GraphicRef.MeasureString(GraphicString, testFont);

        if (ContainerWidth > Convert.ToInt32(AdjustedSizeNew.Width) && ContainerHeight > Convert.ToInt32(AdjustedSizeNew.Height)) {
          // Good font, return it
          return testFont;
        }
      }

      // If you get here there was no fontsize that worked
      // return MinimumSize or Original?
      if (SmallestOnFail) {
        return testFont;
      } else {
        return OriginalFont;
      }
    }

  }
}
