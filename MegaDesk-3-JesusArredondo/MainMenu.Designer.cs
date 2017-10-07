namespace MegaDesk_3_JesusArredondo
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.AddQuotesButton = new System.Windows.Forms.Button();
            this.ViewQuotesButton = new System.Windows.Forms.Button();
            this.SearchQuotesButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddQuotesButton
            // 
            this.AddQuotesButton.Location = new System.Drawing.Point(27, 58);
            this.AddQuotesButton.Name = "AddQuotesButton";
            this.AddQuotesButton.Size = new System.Drawing.Size(108, 30);
            this.AddQuotesButton.TabIndex = 0;
            this.AddQuotesButton.Text = "Add New Quote";
            this.AddQuotesButton.UseVisualStyleBackColor = true;
            this.AddQuotesButton.Click += new System.EventHandler(this.AddQuotesButton_Click);
            // 
            // ViewQuotesButton
            // 
            this.ViewQuotesButton.Location = new System.Drawing.Point(27, 109);
            this.ViewQuotesButton.Name = "ViewQuotesButton";
            this.ViewQuotesButton.Size = new System.Drawing.Size(108, 30);
            this.ViewQuotesButton.TabIndex = 1;
            this.ViewQuotesButton.Text = "View Quotes";
            this.ViewQuotesButton.UseVisualStyleBackColor = true;
            this.ViewQuotesButton.Click += new System.EventHandler(this.ViewQuotesButton_Click);
            // 
            // SearchQuotesButton
            // 
            this.SearchQuotesButton.Location = new System.Drawing.Point(27, 160);
            this.SearchQuotesButton.Name = "SearchQuotesButton";
            this.SearchQuotesButton.Size = new System.Drawing.Size(108, 30);
            this.SearchQuotesButton.TabIndex = 2;
            this.SearchQuotesButton.Text = "Search Quotes";
            this.SearchQuotesButton.UseVisualStyleBackColor = true;
            this.SearchQuotesButton.Click += new System.EventHandler(this.SearchQuotesButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(27, 209);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(108, 30);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(178, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 222);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(417, 293);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SearchQuotesButton);
            this.Controls.Add(this.ViewQuotesButton);
            this.Controls.Add(this.AddQuotesButton);
            this.Name = "MainMenuForm";
            this.Text = "Mega Desk";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddQuotesButton;
        private System.Windows.Forms.Button ViewQuotesButton;
        private System.Windows.Forms.Button SearchQuotesButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

