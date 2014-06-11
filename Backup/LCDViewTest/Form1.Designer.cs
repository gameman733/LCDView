namespace LCDViewTest
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
            this.lcdView1 = new LCDView.LCDView();
            this.SuspendLayout();
            // 
            // lcdView1
            // 
            this.lcdView1.BackColor = System.Drawing.Color.White;
            this.lcdView1.Location = new System.Drawing.Point(13, 13);
            this.lcdView1.Name = "lcdView1";
            this.lcdView1.Size = new System.Drawing.Size(259, 237);
            this.lcdView1.TabIndex = 0;
            this.lcdView1.XPixels = 64;
            this.lcdView1.YPixels = 64;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lcdView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private LCDView.LCDView lcdView1;
    }
}

