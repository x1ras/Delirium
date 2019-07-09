namespace Synoptic_Project_1
{
    partial class Delirium
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delirium));
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbStart = new System.Windows.Forms.Label();
            this.lbAbout = new System.Windows.Forms.Label();
            this.lbExit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Edwardian Script ITC", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(229, 53);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(317, 113);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Delirium";
            // 
            // lbStart
            // 
            this.lbStart.AutoSize = true;
            this.lbStart.BackColor = System.Drawing.Color.Transparent;
            this.lbStart.Font = new System.Drawing.Font("Chiller", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStart.ForeColor = System.Drawing.Color.White;
            this.lbStart.Location = new System.Drawing.Point(352, 213);
            this.lbStart.Name = "lbStart";
            this.lbStart.Size = new System.Drawing.Size(71, 43);
            this.lbStart.TabIndex = 1;
            this.lbStart.Text = "Start";
            // 
            // lbAbout
            // 
            this.lbAbout.AutoSize = true;
            this.lbAbout.BackColor = System.Drawing.Color.Transparent;
            this.lbAbout.Font = new System.Drawing.Font("Chiller", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAbout.ForeColor = System.Drawing.Color.White;
            this.lbAbout.Location = new System.Drawing.Point(346, 265);
            this.lbAbout.Name = "lbAbout";
            this.lbAbout.Size = new System.Drawing.Size(85, 43);
            this.lbAbout.TabIndex = 2;
            this.lbAbout.Text = "About";
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.BackColor = System.Drawing.Color.Transparent;
            this.lbExit.Font = new System.Drawing.Font("Chiller", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExit.ForeColor = System.Drawing.Color.White;
            this.lbExit.Location = new System.Drawing.Point(356, 321);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(63, 43);
            this.lbExit.TabIndex = 3;
            this.lbExit.Text = "Exit";
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            // 
            // Delirium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.ControlBox = false;
            this.Controls.Add(this.lbExit);
            this.Controls.Add(this.lbAbout);
            this.Controls.Add(this.lbStart);
            this.Controls.Add(this.lbTitle);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Delirium";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbStart;
        private System.Windows.Forms.Label lbAbout;
        private System.Windows.Forms.Label lbExit;
    }
}

