namespace MegaDesk_3_JesusArredondo
{
    partial class SearchAllQuotes
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
            this.label1 = new System.Windows.Forms.Label();
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.SearchComboBox = new System.Windows.Forms.ComboBox();
            this.Results = new System.Windows.Forms.RichTextBox();
            this.Search = new System.Windows.Forms.Button();
            this.Criteria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.Location = new System.Drawing.Point(29, 261);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(108, 30);
            this.MainMenuButton.TabIndex = 5;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // SearchComboBox
            // 
            this.SearchComboBox.FormattingEnabled = true;
            this.SearchComboBox.Items.AddRange(new object[] {
            "Client",
            "Material"});
            this.SearchComboBox.Location = new System.Drawing.Point(101, 26);
            this.SearchComboBox.Name = "SearchComboBox";
            this.SearchComboBox.Size = new System.Drawing.Size(121, 21);
            this.SearchComboBox.TabIndex = 6;
            // 
            // Results
            // 
            this.Results.Location = new System.Drawing.Point(29, 70);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(478, 175);
            this.Results.TabIndex = 7;
            this.Results.Text = "";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(399, 261);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(108, 30);
            this.Search.TabIndex = 8;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Criteria
            // 
            this.Criteria.Location = new System.Drawing.Point(417, 26);
            this.Criteria.Name = "Criteria";
            this.Criteria.Size = new System.Drawing.Size(100, 20);
            this.Criteria.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Criteria";
            // 
            // SearchAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 303);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Criteria);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.MainMenuButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchComboBox);
            this.Name = "SearchAllQuotes";
            this.Text = "SearchAllQuotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.ComboBox SearchComboBox;
        private System.Windows.Forms.RichTextBox Results;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox Criteria;
        private System.Windows.Forms.Label label2;
    }
}