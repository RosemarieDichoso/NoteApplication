namespace NoteApplication
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            exitMainForm = new Label();
            label1 = new Label();
            btnAddNote = new Button();
            notePanel = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Sienna;
            panel1.Controls.Add(exitMainForm);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAddNote);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 111);
            panel1.TabIndex = 0;
            // 
            // exitMainForm
            // 
            exitMainForm.AutoSize = true;
            exitMainForm.Cursor = Cursors.Hand;
            exitMainForm.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitMainForm.Location = new Point(759, 9);
            exitMainForm.Name = "exitMainForm";
            exitMainForm.Size = new Size(28, 28);
            exitMainForm.TabIndex = 2;
            exitMainForm.Text = "X";
            exitMainForm.Click += exitMainForm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 35);
            label1.Name = "label1";
            label1.Size = new Size(260, 38);
            label1.TabIndex = 1;
            label1.Text = "Note Application";
            // 
            // btnAddNote
            // 
            btnAddNote.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNote.Location = new Point(617, 44);
            btnAddNote.Name = "btnAddNote";
            btnAddNote.Size = new Size(94, 29);
            btnAddNote.TabIndex = 0;
            btnAddNote.Text = "Add Notes";
            btnAddNote.UseVisualStyleBackColor = true;
            btnAddNote.Click += btnAddNote_Click;
            // 
            // notePanel
            // 
            notePanel.AutoScroll = true;
            notePanel.BackColor = Color.PaleGoldenrod;
            notePanel.FlowDirection = FlowDirection.TopDown;
            notePanel.Location = new Point(2, 110);
            notePanel.Name = "notePanel";
            notePanel.Size = new Size(797, 274);
            notePanel.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 384);
            Controls.Add(notePanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel notePanel;
        private Label label1;
        private Button btnAddNote;
        private Label exitMainForm;
    }
}
