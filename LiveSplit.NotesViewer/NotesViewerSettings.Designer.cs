using System.Windows.Forms;

namespace LiveSplit.NotesViewer {
  partial class NotesViewerSettings {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.label1 = new System.Windows.Forms.Label();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.notesFile = new System.Windows.Forms.TextBox();
      this.openFile = new System.Windows.Forms.Button();
      this.heightBox = new System.Windows.Forms.NumericUpDown();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.heightBox)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.Location = new System.Drawing.Point(3, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(448, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "By default, a file with the same name as the splits file but .txt extension will " +
    "be loaded.";
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(454, 528);
      this.tableLayoutPanel1.TabIndex = 2;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 2;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.07143F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.92857F));
      this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
      this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.heightBox, 1, 1);
      this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 2;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.57143F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.42857F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(448, 70);
      this.tableLayoutPanel2.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label2.Location = new System.Drawing.Point(3, 34);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(66, 36);
      this.label2.TabIndex = 0;
      this.label2.Text = "Height";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label3.Location = new System.Drawing.Point(3, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(66, 34);
      this.label3.TabIndex = 3;
      this.label3.Text = "Notes File";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.ColumnCount = 2;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.62803F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.37197F));
      this.tableLayoutPanel3.Controls.Add(this.notesFile, 0, 0);
      this.tableLayoutPanel3.Controls.Add(this.openFile, 1, 0);
      this.tableLayoutPanel3.Location = new System.Drawing.Point(75, 3);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 1;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(370, 28);
      this.tableLayoutPanel3.TabIndex = 4;
      // 
      // notesFile
      // 
      this.notesFile.Dock = System.Windows.Forms.DockStyle.Fill;
      this.notesFile.Location = new System.Drawing.Point(3, 3);
      this.notesFile.Name = "notesFile";
      this.notesFile.ReadOnly = true;
      this.notesFile.Size = new System.Drawing.Size(281, 20);
      this.notesFile.TabIndex = 0;
      // 
      // openFile
      // 
      this.openFile.Location = new System.Drawing.Point(290, 3);
      this.openFile.Name = "openFile";
      this.openFile.Size = new System.Drawing.Size(75, 22);
      this.openFile.TabIndex = 1;
      this.openFile.Text = "Open";
      this.openFile.UseVisualStyleBackColor = true;
      this.openFile.Click += new System.EventHandler(this.OpenFile_Click);
      // 
      // heightBox
      // 
      this.heightBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.heightBox.AutoSize = true;
      this.heightBox.Location = new System.Drawing.Point(75, 37);
      this.heightBox.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
      this.heightBox.Name = "heightBox";
      this.heightBox.Size = new System.Drawing.Size(370, 20);
      this.heightBox.TabIndex = 1;
      // 
      // NotesViewerSettings
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "NotesViewerSettings";
      this.Size = new System.Drawing.Size(454, 528);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel2.PerformLayout();
      this.tableLayoutPanel3.ResumeLayout(false);
      this.tableLayoutPanel3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.heightBox)).EndInit();
      this.ResumeLayout(false);

    }

    private void OpenFile_Click(object sender, System.EventArgs e) {
      MessageBox.Show("Still not implemented!");
      /*using (var selectFileDialog = new OpenFileDialog()) {
        if (selectFileDialog.ShowDialog() == DialogResult.OK) {
          notesFile.Text = selectFileDialog.FileName;
        }
      }*/
    }

    #endregion
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.NumericUpDown heightBox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.Button openFile;
    private System.Windows.Forms.TextBox notesFile;
  }
}
