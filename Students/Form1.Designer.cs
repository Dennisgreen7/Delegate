
namespace Students
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
            this.SearchComboBox = new System.Windows.Forms.ComboBox();
            this.FilterBox = new System.Windows.Forms.TextBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.SortView = new System.Windows.Forms.DataGridView();
            this.bCheck = new System.Windows.Forms.Button();
            this.checkGrade = new System.Windows.Forms.CheckBox();
            this.checkFirstChar = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SumCombo = new System.Windows.Forms.ComboBox();
            this.bSum = new System.Windows.Forms.Button();
            this.bAverage = new System.Windows.Forms.Button();
            this.AverageBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.SortView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchComboBox
            // 
            this.SearchComboBox.BackColor = System.Drawing.Color.DarkGray;
            this.SearchComboBox.FormattingEnabled = true;
            this.SearchComboBox.Items.AddRange(new object[] {
            "Search By Id",
            "Search By FirstName",
            "Search By LastName",
            "Search By Grade"});
            this.SearchComboBox.Location = new System.Drawing.Point(35, 64);
            this.SearchComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchComboBox.Name = "SearchComboBox";
            this.SearchComboBox.Size = new System.Drawing.Size(196, 24);
            this.SearchComboBox.TabIndex = 4;
            // 
            // FilterBox
            // 
            this.FilterBox.BackColor = System.Drawing.Color.DarkGray;
            this.FilterBox.Location = new System.Drawing.Point(35, 105);
            this.FilterBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilterBox.Name = "FilterBox";
            this.FilterBox.Size = new System.Drawing.Size(196, 22);
            this.FilterBox.TabIndex = 8;
            this.FilterBox.Text = "Search";
            this.FilterBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FilterBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox4_MouseClick);
            // 
            // bSearch
            // 
            this.bSearch.BackColor = System.Drawing.Color.DarkRed;
            this.bSearch.Location = new System.Drawing.Point(94, 148);
            this.bSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(91, 30);
            this.bSearch.TabIndex = 9;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = false;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            this.bSearch.MouseEnter += new System.EventHandler(this.bSearch_MouseEnter);
            // 
            // SortView
            // 
            this.SortView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SortView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SortView.Location = new System.Drawing.Point(292, 37);
            this.SortView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SortView.Name = "SortView";
            this.SortView.RowHeadersWidth = 51;
            this.SortView.RowTemplate.Height = 28;
            this.SortView.Size = new System.Drawing.Size(660, 433);
            this.SortView.TabIndex = 11;
            // 
            // bCheck
            // 
            this.bCheck.BackColor = System.Drawing.Color.DarkRed;
            this.bCheck.Location = new System.Drawing.Point(94, 306);
            this.bCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bCheck.Name = "bCheck";
            this.bCheck.Size = new System.Drawing.Size(91, 30);
            this.bCheck.TabIndex = 14;
            this.bCheck.Text = "Check";
            this.bCheck.UseVisualStyleBackColor = false;
            this.bCheck.Click += new System.EventHandler(this.bCheck_Click);
            // 
            // checkGrade
            // 
            this.checkGrade.AutoSize = true;
            this.checkGrade.ForeColor = System.Drawing.Color.White;
            this.checkGrade.Location = new System.Drawing.Point(23, 21);
            this.checkGrade.Name = "checkGrade";
            this.checkGrade.Size = new System.Drawing.Size(182, 21);
            this.checkGrade.TabIndex = 12;
            this.checkGrade.Text = "Check Grade  Below 50 ";
            this.checkGrade.UseVisualStyleBackColor = true;
            // 
            // checkFirstChar
            // 
            this.checkFirstChar.AutoSize = true;
            this.checkFirstChar.ForeColor = System.Drawing.Color.White;
            this.checkFirstChar.Location = new System.Drawing.Point(23, 48);
            this.checkFirstChar.Name = "checkFirstChar";
            this.checkFirstChar.Size = new System.Drawing.Size(222, 21);
            this.checkFirstChar.TabIndex = 13;
            this.checkFirstChar.Text = "Check First Char In FN And LN";
            this.checkFirstChar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.checkFirstChar);
            this.groupBox1.Controls.Add(this.checkGrade);
            this.groupBox1.Location = new System.Drawing.Point(12, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 88);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // SumCombo
            // 
            this.SumCombo.BackColor = System.Drawing.Color.DarkGray;
            this.SumCombo.FormattingEnabled = true;
            this.SumCombo.Items.AddRange(new object[] {
            "Payment Sum",
            "Need To pay Sum"});
            this.SumCombo.Location = new System.Drawing.Point(35, 365);
            this.SumCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SumCombo.Name = "SumCombo";
            this.SumCombo.Size = new System.Drawing.Size(196, 24);
            this.SumCombo.TabIndex = 15;
            // 
            // bSum
            // 
            this.bSum.BackColor = System.Drawing.Color.DarkRed;
            this.bSum.Location = new System.Drawing.Point(94, 412);
            this.bSum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bSum.Name = "bSum";
            this.bSum.Size = new System.Drawing.Size(91, 30);
            this.bSum.TabIndex = 16;
            this.bSum.Text = "Sum";
            this.bSum.UseVisualStyleBackColor = false;
            this.bSum.Click += new System.EventHandler(this.bSum_Click);
            // 
            // bAverage
            // 
            this.bAverage.BackColor = System.Drawing.Color.DarkRed;
            this.bAverage.Location = new System.Drawing.Point(94, 529);
            this.bAverage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAverage.Name = "bAverage";
            this.bAverage.Size = new System.Drawing.Size(91, 30);
            this.bAverage.TabIndex = 18;
            this.bAverage.Text = "Average";
            this.bAverage.UseVisualStyleBackColor = false;
            this.bAverage.Click += new System.EventHandler(this.bAverage_Click);
            // 
            // AverageBox
            // 
            this.AverageBox.BackColor = System.Drawing.Color.DarkGray;
            this.AverageBox.FormattingEnabled = true;
            this.AverageBox.Items.AddRange(new object[] {
            "Age Average",
            "Grade Average"});
            this.AverageBox.Location = new System.Drawing.Point(35, 482);
            this.AverageBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AverageBox.Name = "AverageBox";
            this.AverageBox.Size = new System.Drawing.Size(196, 24);
            this.AverageBox.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(982, 606);
            this.Controls.Add(this.bAverage);
            this.Controls.Add(this.AverageBox);
            this.Controls.Add(this.bSum);
            this.Controls.Add(this.SumCombo);
            this.Controls.Add(this.bCheck);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SortView);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.FilterBox);
            this.Controls.Add(this.SearchComboBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SortView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox SearchComboBox;
        private System.Windows.Forms.TextBox FilterBox;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.DataGridView SortView;
        private System.Windows.Forms.Button bCheck;
        private System.Windows.Forms.CheckBox checkGrade;
        private System.Windows.Forms.CheckBox checkFirstChar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox SumCombo;
        private System.Windows.Forms.Button bSum;
        private System.Windows.Forms.Button bAverage;
        private System.Windows.Forms.ComboBox AverageBox;
    }
}

