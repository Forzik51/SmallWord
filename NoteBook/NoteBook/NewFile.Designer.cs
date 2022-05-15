namespace NoteBook
{
    partial class New
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New));
            this.NewFile = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewFile
            // 
            this.NewFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewFile.Location = new System.Drawing.Point(12, 166);
            this.NewFile.Name = "NewFile";
            this.NewFile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NewFile.Size = new System.Drawing.Size(292, 20);
            this.NewFile.TabIndex = 0;
            this.NewFile.Text = "Enter Name";
            this.NewFile.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(366, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(366, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 20);
            this.button2.TabIndex = 2;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NoteBook.Properties.Resources.istockphoto_170005774_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(507, 199);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NewFile);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximumSize = new System.Drawing.Size(523, 238);
            this.MinimumSize = new System.Drawing.Size(523, 238);
            this.Name = "New";
            this.Text = "NewFile";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.New_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}