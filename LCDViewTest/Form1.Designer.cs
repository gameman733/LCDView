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
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lcdView1 = new LCDView.LCDView();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSetX = new System.Windows.Forms.TextBox();
            this.txtSetY = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(103, 299);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 20);
            this.txtY.TabIndex = 1;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(103, 273);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number X Pixels";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number Y Pixels";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Update NumPixels";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Update NumPixels";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Set Y Pixel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Set X Pixel";
            // 
            // txtSetX
            // 
            this.txtSetX.Location = new System.Drawing.Point(409, 27);
            this.txtSetX.Name = "txtSetX";
            this.txtSetX.Size = new System.Drawing.Size(100, 20);
            this.txtSetX.TabIndex = 7;
            // 
            // txtSetY
            // 
            this.txtSetY.Location = new System.Drawing.Point(409, 53);
            this.txtSetY.Name = "txtSetY";
            this.txtSetY.Size = new System.Drawing.Size(100, 20);
            this.txtSetY.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 417);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSetX);
            this.Controls.Add(this.txtSetY);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.lcdView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LCDView.LCDView lcdView1;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSetX;
        private System.Windows.Forms.TextBox txtSetY;
    }
}

