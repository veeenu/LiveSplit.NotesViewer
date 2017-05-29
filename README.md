# LiveSplit.NotesViewer

A control for viewing notes for the current split.
Currently requires consistency between number of splits in LiveSplits and sections in the settings (example shown below), and the notes have to be changed from the layout settings window when switching between different games. But it works, somewhat.

### Installing

Simply copy `LiveSplit.NotesViewer.dll` in the `Components` folder of LiveSplit.

### Example

Write your notes in a file named in the same way as your splits file, and positioned right next to it. For example:

- Create your splits and save them in `Dark Souls III - All Bosses.lss`
- Save your notes in the same directory, on a file named `Dark Souls III - All Bosses.txt`.

The content of the file has to look like this:

```
# First split

Example 1
Example 1
Example 1
Example 1

# Second split

Example 2
Example 2
Example 2
Example 2

# Third split

Example 3
Example 3
Example 3
Example 3
```

Spaces before and after the `# Split name` line are optional, but good for readability.

Enjoy!

### Disclaimer

The project is not actively maintained for the time being due to the little time I can devote to it. 
Also, little testing has been done for bugs and stuff, but I've been using this myself for a long time
without encountering any problems. Pull requests and suggestions will be taken into consideration!