namespace SemanticVersioningForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.srcButtDia = new System.Windows.Forms.Button();
            this.srcFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.destFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.sourceFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.destFileBox = new System.Windows.Forms.TextBox();
            this.destButtDia = new System.Windows.Forms.Button();
            this.sortButt = new System.Windows.Forms.Button();
            this.stLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(610, 170);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.destButtDia);
            this.groupBox1.Controls.Add(this.destFileBox);
            this.groupBox1.Controls.Add(this.srcButtDia);
            this.groupBox1.Controls.Add(this.srcFilePath);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 67);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // srcButtDia
            // 
            this.srcButtDia.Location = new System.Drawing.Point(428, 7);
            this.srcButtDia.Name = "srcButtDia";
            this.srcButtDia.Size = new System.Drawing.Size(24, 23);
            this.srcButtDia.TabIndex = 1;
            this.srcButtDia.Text = "...";
            this.srcButtDia.UseVisualStyleBackColor = true;
            this.srcButtDia.Click += new System.EventHandler(this.srcButtDia_Click);
            // 
            // srcFilePath
            // 
            this.srcFilePath.Location = new System.Drawing.Point(7, 11);
            this.srcFilePath.Name = "srcFilePath";
            this.srcFilePath.Size = new System.Drawing.Size(414, 20);
            this.srcFilePath.TabIndex = 0;
            this.srcFilePath.Text = "File to sort...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Use Files:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(71, 209);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // destFileDialog
            // 
            this.destFileDialog.FileName = "Sorted.txt";
            this.destFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // sourceFileDialog
            // 
            this.sourceFileDialog.FileName = "openFileDialog1";
            // 
            // destFileBox
            // 
            this.destFileBox.Location = new System.Drawing.Point(7, 38);
            this.destFileBox.Name = "destFileBox";
            this.destFileBox.Size = new System.Drawing.Size(414, 20);
            this.destFileBox.TabIndex = 2;
            this.destFileBox.Text = "Save to...";
            // 
            // destButtDia
            // 
            this.destButtDia.Location = new System.Drawing.Point(428, 38);
            this.destButtDia.Name = "destButtDia";
            this.destButtDia.Size = new System.Drawing.Size(24, 23);
            this.destButtDia.TabIndex = 3;
            this.destButtDia.Text = "...";
            this.destButtDia.UseVisualStyleBackColor = true;
            this.destButtDia.Click += new System.EventHandler(this.destButtDia_Click);
            // 
            // sortButt
            // 
            this.sortButt.Location = new System.Drawing.Point(546, 298);
            this.sortButt.Name = "sortButt";
            this.sortButt.Size = new System.Drawing.Size(75, 23);
            this.sortButt.TabIndex = 2;
            this.sortButt.Text = "Sort";
            this.sortButt.UseVisualStyleBackColor = true;
            this.sortButt.Click += new System.EventHandler(this.sortButt_Click);
            // 
            // stLabel
            // 
            this.stLabel.AutoSize = true;
            this.stLabel.Location = new System.Drawing.Point(12, 307);
            this.stLabel.Name = "stLabel";
            this.stLabel.Size = new System.Drawing.Size(38, 13);
            this.stLabel.TabIndex = 3;
            this.stLabel.Text = "Ready";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 329);
            this.Controls.Add(this.stLabel);
            this.Controls.Add(this.sortButt);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Semantic Variable Sorter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog destFileDialog;
        private System.Windows.Forms.TextBox srcFilePath;
        private System.Windows.Forms.Button srcButtDia;
        private System.Windows.Forms.OpenFileDialog sourceFileDialog;
        private System.Windows.Forms.Button destButtDia;
        private System.Windows.Forms.TextBox destFileBox;
        private System.Windows.Forms.Button sortButt;
        private System.Windows.Forms.Label stLabel;
    }
}

