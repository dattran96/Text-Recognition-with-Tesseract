namespace Text_recognize
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
            this.Load_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Display_ptbx = new System.Windows.Forms.PictureBox();
            this.Process_btn = new System.Windows.Forms.Button();
            this.Cam_btn = new System.Windows.Forms.Button();
            this.Stop_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Display_ptbx)).BeginInit();
            this.SuspendLayout();
            // 
            // Load_btn
            // 
            this.Load_btn.Location = new System.Drawing.Point(12, 12);
            this.Load_btn.Name = "Load_btn";
            this.Load_btn.Size = new System.Drawing.Size(87, 39);
            this.Load_btn.TabIndex = 0;
            this.Load_btn.Text = "Load";
            this.Load_btn.UseVisualStyleBackColor = true;
            this.Load_btn.Click += new System.EventHandler(this.Load_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.Display_ptbx);
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 428);
            this.panel1.TabIndex = 1;
            // 
            // Display_ptbx
            // 
            this.Display_ptbx.Location = new System.Drawing.Point(3, 3);
            this.Display_ptbx.Name = "Display_ptbx";
            this.Display_ptbx.Size = new System.Drawing.Size(1025, 422);
            this.Display_ptbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Display_ptbx.TabIndex = 0;
            this.Display_ptbx.TabStop = false;
            // 
            // Process_btn
            // 
            this.Process_btn.Location = new System.Drawing.Point(105, 12);
            this.Process_btn.Name = "Process_btn";
            this.Process_btn.Size = new System.Drawing.Size(87, 39);
            this.Process_btn.TabIndex = 2;
            this.Process_btn.Text = "Scan";
            this.Process_btn.UseVisualStyleBackColor = true;
            this.Process_btn.Click += new System.EventHandler(this.Process_btn_Click);
            // 
            // Cam_btn
            // 
            this.Cam_btn.Location = new System.Drawing.Point(198, 12);
            this.Cam_btn.Name = "Cam_btn";
            this.Cam_btn.Size = new System.Drawing.Size(87, 39);
            this.Cam_btn.TabIndex = 3;
            this.Cam_btn.Text = "WebCam";
            this.Cam_btn.UseVisualStyleBackColor = true;
            this.Cam_btn.Click += new System.EventHandler(this.Cam_btn_Click);
            // 
            // Stop_btn
            // 
            this.Stop_btn.Location = new System.Drawing.Point(291, 12);
            this.Stop_btn.Name = "Stop_btn";
            this.Stop_btn.Size = new System.Drawing.Size(87, 39);
            this.Stop_btn.TabIndex = 4;
            this.Stop_btn.Text = "Stop";
            this.Stop_btn.UseVisualStyleBackColor = true;
            this.Stop_btn.Click += new System.EventHandler(this.Stop_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 497);
            this.Controls.Add(this.Stop_btn);
            this.Controls.Add(this.Cam_btn);
            this.Controls.Add(this.Process_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Load_btn);
            this.Name = "Form1";
            this.Text = "Scan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Display_ptbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Load_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Display_ptbx;
        private System.Windows.Forms.Button Process_btn;
        private System.Windows.Forms.Button Cam_btn;
        private System.Windows.Forms.Button Stop_btn;
    }
}

