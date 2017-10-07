namespace MegaDesk_3_JesusArredondo
{
    partial class AddQuote
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
            this.ClientName = new System.Windows.Forms.TextBox();
            this.DeskWidth = new System.Windows.Forms.TextBox();
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DeskDepth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Material = new System.Windows.Forms.ComboBox();
            this.rushDays = new System.Windows.Forms.ComboBox();
            this.TodayDate = new System.Windows.Forms.Label();
            this.SaveQuote = new System.Windows.Forms.Button();
            this.DeskDrawers = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.Label();
            this.label09 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClientName
            // 
            this.ClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientName.Location = new System.Drawing.Point(152, 32);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(120, 26);
            this.ClientName.TabIndex = 0;
            this.ClientName.TextChanged += new System.EventHandler(this.ClientName_TextChanged);
            // 
            // DeskWidth
            // 
            this.DeskWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskWidth.Location = new System.Drawing.Point(152, 70);
            this.DeskWidth.Name = "DeskWidth";
            this.DeskWidth.Size = new System.Drawing.Size(120, 26);
            this.DeskWidth.TabIndex = 1;
            this.DeskWidth.TextChanged += new System.EventHandler(this.DeskWidth_TextChanged);
            this.DeskWidth.Validating += new System.ComponentModel.CancelEventHandler(this.DeskWidth_Validating);
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.Location = new System.Drawing.Point(321, 241);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(108, 30);
            this.MainMenuButton.TabIndex = 5;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Client Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Desk With";
            // 
            // DeskDepth
            // 
            this.DeskDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskDepth.Location = new System.Drawing.Point(152, 108);
            this.DeskDepth.Name = "DeskDepth";
            this.DeskDepth.Size = new System.Drawing.Size(120, 26);
            this.DeskDepth.TabIndex = 8;
            this.DeskDepth.TextChanged += new System.EventHandler(this.DeskDepth_TextChanged);
            this.DeskDepth.Validating += new System.ComponentModel.CancelEventHandler(this.DeskDepth_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Desk Depth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(318, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Rush Days";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(318, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Material";
            // 
            // Material
            // 
            this.Material.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Material.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Material.FormattingEnabled = true;
            this.Material.Location = new System.Drawing.Point(423, 70);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(137, 28);
            this.Material.TabIndex = 13;
            this.Material.SelectedIndexChanged += new System.EventHandler(this.Material_SelectedIndexChanged);
            // 
            // rushDays
            // 
            this.rushDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rushDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushDays.FormattingEnabled = true;
            this.rushDays.Items.AddRange(new object[] {
            "3",
            "5",
            "7"});
            this.rushDays.Location = new System.Drawing.Point(423, 32);
            this.rushDays.Name = "rushDays";
            this.rushDays.Size = new System.Drawing.Size(137, 28);
            this.rushDays.TabIndex = 14;
            this.rushDays.SelectedIndexChanged += new System.EventHandler(this.rushDays_SelectedIndexChanged);
            // 
            // TodayDate
            // 
            this.TodayDate.AutoSize = true;
            this.TodayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodayDate.Location = new System.Drawing.Point(125, 154);
            this.TodayDate.Name = "TodayDate";
            this.TodayDate.Size = new System.Drawing.Size(0, 20);
            this.TodayDate.TabIndex = 15;
            // 
            // SaveQuote
            // 
            this.SaveQuote.Location = new System.Drawing.Point(452, 241);
            this.SaveQuote.Name = "SaveQuote";
            this.SaveQuote.Size = new System.Drawing.Size(108, 30);
            this.SaveQuote.TabIndex = 16;
            this.SaveQuote.Text = "Save Quote";
            this.SaveQuote.UseVisualStyleBackColor = true;
            this.SaveQuote.Click += new System.EventHandler(this.SaveQuote_Click);
            // 
            // DeskDrawers
            // 
            this.DeskDrawers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeskDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskDrawers.FormattingEnabled = true;
            this.DeskDrawers.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.DeskDrawers.Location = new System.Drawing.Point(423, 108);
            this.DeskDrawers.Name = "DeskDrawers";
            this.DeskDrawers.Size = new System.Drawing.Size(137, 28);
            this.DeskDrawers.TabIndex = 18;
            this.DeskDrawers.SelectedIndexChanged += new System.EventHandler(this.DeskDrawers_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(318, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Drawers";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(318, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Surface";
            // 
            // size
            // 
            this.size.AutoSize = true;
            this.size.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size.Location = new System.Drawing.Point(436, 150);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(0, 20);
            this.size.TabIndex = 21;
            // 
            // label09
            // 
            this.label09.AutoSize = true;
            this.label09.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label09.Location = new System.Drawing.Point(317, 181);
            this.label09.Name = "label09";
            this.label09.Size = new System.Drawing.Size(44, 20);
            this.label09.TabIndex = 22;
            this.label09.Text = "Price";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(435, 181);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(0, 20);
            this.Price.TabIndex = 23;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 289);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label09);
            this.Controls.Add(this.size);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DeskDrawers);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SaveQuote);
            this.Controls.Add(this.TodayDate);
            this.Controls.Add(this.rushDays);
            this.Controls.Add(this.Material);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeskDepth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainMenuButton);
            this.Controls.Add(this.DeskWidth);
            this.Controls.Add(this.ClientName);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ClientName;
        private System.Windows.Forms.TextBox DeskWidth;
        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DeskDepth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Material;
        private System.Windows.Forms.ComboBox rushDays;
        private System.Windows.Forms.Label TodayDate;
        private System.Windows.Forms.Button SaveQuote;
        private System.Windows.Forms.ComboBox DeskDrawers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label size;
        private System.Windows.Forms.Label label09;
        private System.Windows.Forms.Label Price;
    }
}