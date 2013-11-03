namespace WindowsFormsApplication1
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
            this.btn_convert = new System.Windows.Forms.Button();
            this.lbl_timespan = new System.Windows.Forms.Label();
            this.nud_offset = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_offset)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(12, 48);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(75, 23);
            this.btn_convert.TabIndex = 0;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_timespan
            // 
            this.lbl_timespan.AutoSize = true;
            this.lbl_timespan.Location = new System.Drawing.Point(12, 9);
            this.lbl_timespan.Name = "lbl_timespan";
            this.lbl_timespan.Size = new System.Drawing.Size(74, 13);
            this.lbl_timespan.TabIndex = 1;
            this.lbl_timespan.Text = "Process Time:";
            // 
            // nud_offset
            // 
            this.nud_offset.Location = new System.Drawing.Point(96, 20);
            this.nud_offset.Name = "nud_offset";
            this.nud_offset.Size = new System.Drawing.Size(120, 20);
            this.nud_offset.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Allowed Offset:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 417);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_offset);
            this.Controls.Add(this.lbl_timespan);
            this.Controls.Add(this.btn_convert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_offset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.Label lbl_timespan;
        private System.Windows.Forms.NumericUpDown nud_offset;
        private System.Windows.Forms.Label label1;
    }
}

