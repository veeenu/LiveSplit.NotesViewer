using LiveSplit.Model;
using LiveSplit.NotesViewer;
using LiveSplit.UI.Components;
using System;

[assembly: ComponentFactory(typeof(NotesViewerFactory))]

namespace LiveSplit.NotesViewer {

  public class NotesViewerFactory : IComponentFactory {
    public string ComponentName => "Notes viewer";

    public string Description => "Shows the notes for the current split.";

    public ComponentCategory Category => ComponentCategory.Other;

    public IComponent Create(LiveSplitState state) => new NotesViewer(state);

    public string UpdateName => ComponentName;
    
    public string UpdateURL => "http://johndisandonato.stream/livesplit.notesviewer";

    public string XMLURL => UpdateURL + "/LiveSplit.NotesViewer.xml";

    public Version Version => Version.Parse("1.6.3");
  }
}
