namespace NoteApplication.Forms
{
    partial class UpdateNoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            exitUpdateForm = new Label();
            lblDate = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnUpdate = new Button();
            rtxtNoteContent = new RichTextBox();
            txtNoteTitle = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PaleGoldenrod;
            groupBox1.Controls.Add(exitUpdateForm);
            groupBox1.Controls.Add(lblDate);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(rtxtNoteContent);
            groupBox1.Controls.Add(txtNoteTitle);
            groupBox1.Location = new Point(52, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(527, 401);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // exitUpdateForm
            // 
            exitUpdateForm.AutoSize = true;
            exitUpdateForm.Cursor = Cursors.Hand;
            exitUpdateForm.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitUpdateForm.Location = new Point(485, 10);
            exitUpdateForm.Name = "exitUpdateForm";
            exitUpdateForm.Size = new Size(28, 28);
            exitUpdateForm.TabIndex = 8;
            exitUpdateForm.Text = "X";
            exitUpdateForm.Click += exitUpdateForm_Click;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(27, 299);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(0, 20);
            lblDate.TabIndex = 7;
            lblDate.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 178);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 6;
            label3.Text = "Note Content";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 109);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 5;
            label2.Text = "Note Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(162, 23);
            label1.Name = "label1";
            label1.Size = new Size(188, 35);
            label1.TabIndex = 4;
            label1.Text = "Update Notes";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(400, 333);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnSave_Click;
            // 
            // rtxtNoteContent
            // 
            rtxtNoteContent.Location = new Point(230, 178);
            rtxtNoteContent.Name = "rtxtNoteContent";
            rtxtNoteContent.Size = new Size(264, 127);
            rtxtNoteContent.TabIndex = 1;
            rtxtNoteContent.Text = "";
            // 
            // txtNoteTitle
            // 
            txtNoteTitle.Location = new Point(230, 109);
            txtNoteTitle.Name = "txtNoteTitle";
            txtNoteTitle.Size = new Size(264, 27);
            txtNoteTitle.TabIndex = 0;
            // 
            // UpdateNoteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            ClientSize = new Size(631, 450);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateNoteForm";
            Text = "UpdateNoteForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnUpdate;
        private RichTextBox rtxtNoteContent;
        private TextBox txtNoteTitle;
        private Label lblDate;
        private Label exitUpdateForm;
    }
}