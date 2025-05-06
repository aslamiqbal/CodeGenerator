namespace CodeGenerator
{
    partial class Form1
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
            label1 = new Label();
            txtSRCPATH = new TextBox();
            btnGenerate = new Button();
            checkBox1 = new CheckBox();
            btnBrowse = new Button();
            button3 = new Button();
            chkEntityList = new CheckedListBox();
            chkOverwrite = new CheckBox();
            chkFileList = new CheckedListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "SRC Path";
            // 
            // txtSRCPATH
            // 
            txtSRCPATH.Location = new Point(73, 6);
            txtSRCPATH.Name = "txtSRCPATH";
            txtSRCPATH.Size = new Size(550, 23);
            txtSRCPATH.TabIndex = 1;
            txtSRCPATH.Text = "D:\\OFFICE\\ML\\Backend\\CF-ONB-BE\\src";
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(639, 62);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(75, 23);
            btnGenerate.TabIndex = 2;
            btnGenerate.Text = "GENERATE";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(73, 37);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(76, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Check All";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(639, 5);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // button3
            // 
            button3.Location = new Point(753, 588);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "button1";
            button3.UseVisualStyleBackColor = true;
            // 
            // chkEntityList
            // 
            chkEntityList.FormattingEnabled = true;
            chkEntityList.Location = new Point(73, 62);
            chkEntityList.Name = "chkEntityList";
            chkEntityList.Size = new Size(550, 328);
            chkEntityList.TabIndex = 4;
            // 
            // chkOverwrite
            // 
            chkOverwrite.AutoSize = true;
            chkOverwrite.Location = new Point(174, 36);
            chkOverwrite.Name = "chkOverwrite";
            chkOverwrite.Size = new Size(87, 19);
            chkOverwrite.TabIndex = 5;
            chkOverwrite.Text = "Over Write?";
            chkOverwrite.UseVisualStyleBackColor = true;
            // 
            // chkFileList
            // 
            chkFileList.FormattingEnabled = true;
            chkFileList.Location = new Point(73, 409);
            chkFileList.Name = "chkFileList";
            chkFileList.Size = new Size(550, 202);
            chkFileList.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 687);
            Controls.Add(chkOverwrite);
            Controls.Add(chkFileList);
            Controls.Add(chkEntityList);
            Controls.Add(checkBox1);
            Controls.Add(button3);
            Controls.Add(btnBrowse);
            Controls.Add(btnGenerate);
            Controls.Add(txtSRCPATH);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSRCPATH;
        private Button btnGenerate;
        private CheckBox checkBox1;
        private Button btnBrowse;
        private Button button3;
        private CheckedListBox chkEntityList;
        private CheckBox chkOverwrite;
        private CheckedListBox chkFileList;
    }
}
