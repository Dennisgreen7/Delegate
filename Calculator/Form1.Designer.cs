
namespace Calculator
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
            this.components = new System.ComponentModel.Container();
            this.ScreenBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.n1 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.badd = new System.Windows.Forms.Button();
            this.bsub = new System.Windows.Forms.Button();
            this.bmult = new System.Windows.Forms.Button();
            this.bdiv = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.bequal = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScreenBox
            // 
            this.ScreenBox.Font = new System.Drawing.Font("Courier New", 20.2F);
            this.ScreenBox.Location = new System.Drawing.Point(-2, 1);
            this.ScreenBox.Multiline = true;
            this.ScreenBox.Name = "ScreenBox";
            this.ScreenBox.ReadOnly = true;
            this.ScreenBox.Size = new System.Drawing.Size(695, 85);
            this.ScreenBox.TabIndex = 0;
            this.ScreenBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // n1
            // 
            this.n1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n1.Font = new System.Drawing.Font("Courier New", 20.25F);
            this.n1.Location = new System.Drawing.Point(133, 104);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(80, 80);
            this.n1.TabIndex = 2;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = false;
            this.n1.Click += new System.EventHandler(this.n1_Click);
            // 
            // n5
            // 
            this.n5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n5.Font = new System.Drawing.Font("Courier New", 20.25F);
            this.n5.Location = new System.Drawing.Point(247, 221);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(80, 80);
            this.n5.TabIndex = 3;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = false;
            this.n5.Click += new System.EventHandler(this.n5_Click);
            // 
            // n2
            // 
            this.n2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n2.Font = new System.Drawing.Font("Courier New", 20.25F);
            this.n2.Location = new System.Drawing.Point(247, 104);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(80, 80);
            this.n2.TabIndex = 4;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = false;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // n4
            // 
            this.n4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n4.Font = new System.Drawing.Font("Courier New", 20.25F);
            this.n4.Location = new System.Drawing.Point(133, 221);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(80, 80);
            this.n4.TabIndex = 5;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = false;
            this.n4.Click += new System.EventHandler(this.n4_Click);
            // 
            // n3
            // 
            this.n3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n3.Font = new System.Drawing.Font("Courier New", 20.25F);
            this.n3.Location = new System.Drawing.Point(365, 104);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(80, 80);
            this.n3.TabIndex = 6;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = false;
            this.n3.Click += new System.EventHandler(this.n3_Click);
            // 
            // n0
            // 
            this.n0.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n0.Font = new System.Drawing.Font("Courier New", 20.25F);
            this.n0.Location = new System.Drawing.Point(247, 446);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(80, 80);
            this.n0.TabIndex = 7;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = false;
            this.n0.Click += new System.EventHandler(this.n0_Click);
            // 
            // n9
            // 
            this.n9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n9.Font = new System.Drawing.Font("Courier New", 20.25F);
            this.n9.Location = new System.Drawing.Point(365, 337);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(80, 80);
            this.n9.TabIndex = 8;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = false;
            this.n9.Click += new System.EventHandler(this.n9_Click);
            // 
            // n8
            // 
            this.n8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n8.Font = new System.Drawing.Font("Courier New", 20.25F);
            this.n8.Location = new System.Drawing.Point(247, 337);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(80, 80);
            this.n8.TabIndex = 9;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = false;
            this.n8.Click += new System.EventHandler(this.n8_Click);
            // 
            // n7
            // 
            this.n7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n7.Font = new System.Drawing.Font("Courier New", 20.25F);
            this.n7.Location = new System.Drawing.Point(133, 337);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(80, 80);
            this.n7.TabIndex = 10;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = false;
            this.n7.Click += new System.EventHandler(this.n7_Click);
            // 
            // n6
            // 
            this.n6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n6.Font = new System.Drawing.Font("Courier New", 20.25F);
            this.n6.Location = new System.Drawing.Point(365, 221);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(80, 80);
            this.n6.TabIndex = 11;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = false;
            this.n6.Click += new System.EventHandler(this.n6_Click);
            // 
            // badd
            // 
            this.badd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.badd.Font = new System.Drawing.Font("Courier New", 20.25F);
            this.badd.Location = new System.Drawing.Point(481, 104);
            this.badd.Name = "badd";
            this.badd.Size = new System.Drawing.Size(80, 80);
            this.badd.TabIndex = 12;
            this.badd.Text = "+";
            this.badd.UseVisualStyleBackColor = false;
            this.badd.Click += new System.EventHandler(this.badd_Click);
            // 
            // bsub
            // 
            this.bsub.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bsub.Font = new System.Drawing.Font("Courier New", 20.25F);
            this.bsub.Location = new System.Drawing.Point(481, 221);
            this.bsub.Name = "bsub";
            this.bsub.Size = new System.Drawing.Size(80, 80);
            this.bsub.TabIndex = 13;
            this.bsub.Text = "-";
            this.bsub.UseVisualStyleBackColor = false;
            this.bsub.Click += new System.EventHandler(this.bsub_Click);
            // 
            // bmult
            // 
            this.bmult.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bmult.Font = new System.Drawing.Font("Courier New", 20.25F);
            this.bmult.Location = new System.Drawing.Point(481, 337);
            this.bmult.Name = "bmult";
            this.bmult.Size = new System.Drawing.Size(80, 80);
            this.bmult.TabIndex = 14;
            this.bmult.Text = "*";
            this.bmult.UseVisualStyleBackColor = false;
            this.bmult.Click += new System.EventHandler(this.bmult_Click);
            // 
            // bdiv
            // 
            this.bdiv.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bdiv.Font = new System.Drawing.Font("Courier New", 20.25F);
            this.bdiv.Location = new System.Drawing.Point(481, 446);
            this.bdiv.Name = "bdiv";
            this.bdiv.Size = new System.Drawing.Size(80, 80);
            this.bdiv.TabIndex = 15;
            this.bdiv.Text = "/";
            this.bdiv.UseVisualStyleBackColor = false;
            this.bdiv.Click += new System.EventHandler(this.bdiv_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button5.Font = new System.Drawing.Font("Courier New", 20.25F);
            this.button5.Location = new System.Drawing.Point(365, 446);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 80);
            this.button5.TabIndex = 16;
            this.button5.Text = "1";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // bequal
            // 
            this.bequal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bequal.Font = new System.Drawing.Font("Courier New", 20.25F);
            this.bequal.Location = new System.Drawing.Point(133, 446);
            this.bequal.Name = "bequal";
            this.bequal.Size = new System.Drawing.Size(80, 80);
            this.bequal.TabIndex = 18;
            this.bequal.Text = "=";
            this.bequal.UseVisualStyleBackColor = false;
            this.bequal.Click += new System.EventHandler(this.bequal_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.clear.Font = new System.Drawing.Font("Courier New", 20.25F);
            this.clear.Location = new System.Drawing.Point(308, 545);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(80, 80);
            this.clear.TabIndex = 17;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(693, 652);
            this.Controls.Add(this.bequal);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.bdiv);
            this.Controls.Add(this.bmult);
            this.Controls.Add(this.bsub);
            this.Controls.Add(this.badd);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.ScreenBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ScreenBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button badd;
        private System.Windows.Forms.Button bsub;
        private System.Windows.Forms.Button bmult;
        private System.Windows.Forms.Button bdiv;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button bequal;
        private System.Windows.Forms.Button clear;
    }
}

