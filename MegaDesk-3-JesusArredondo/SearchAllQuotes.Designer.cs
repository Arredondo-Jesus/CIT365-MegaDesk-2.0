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
            this.SearchAllQuotesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchAllQuotesTextBox
            // 
            this.SearchAllQuotesTextBox.Location = new System.Drawing.Point(154, 29);
            this.SearchAllQuotesTextBox.Name = "SearchAllQuotesTextBox";
            this.SearchAllQuotesTextBox.Size = new System.Drawing.Size(100, 20);
            this.SearchAllQuotesTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.Location = new System.Drawing.Point(154, 219);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(108, 30);
            this.MainMenuButton.TabIndex = 5;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // SearchAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.MainMenuButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchAllQuotesTextBox);
            this.Name = "SearchAllQuotes";
            this.Text = "SearchAllQuotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchAllQuotesTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MainMenuButton;
    }
}