namespace CCLF_DataConvert
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
            this.Process = new System.Windows.Forms.Button();
            this.ProgressCount = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Process
            // 
            this.Process.Location = new System.Drawing.Point(40, 82);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(75, 23);
            this.Process.TabIndex = 2;
            this.Process.Text = "Process";
            this.Process.UseVisualStyleBackColor = true;
            this.Process.Click += new System.EventHandler(this.Process_Click);
            // 
            // ProgressCount
            // 
            this.ProgressCount.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ProgressCount.Location = new System.Drawing.Point(141, 85);
            this.ProgressCount.Name = "ProgressCount";
            this.ProgressCount.Size = new System.Drawing.Size(65, 20);
            this.ProgressCount.TabIndex = 3;
            this.ProgressCount.TextChanged += new System.EventHandler(this.ProgressCount_TextChanged);
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(40, 132);
            this.Status.Multiline = true;
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(665, 276);
            this.Status.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 506);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.ProgressCount);
            this.Controls.Add(this.Process);
            this.Name = "Form1";
            this.Text = "CCLF Data Convert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Process;
        private System.Windows.Forms.TextBox ProgressCount;
        private System.Windows.Forms.TextBox Status;
    }
}

