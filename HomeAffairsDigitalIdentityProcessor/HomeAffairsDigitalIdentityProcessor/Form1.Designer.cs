namespace HomeAffairsDigitalIdentityProcessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.labelCitizenship = new System.Windows.Forms.Label();
            this.comboBoxCitizenship = new System.Windows.Forms.ComboBox();
            this.buttonVaildate = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.textResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(427, 81);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(126, 16);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Enter your Name:";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(620, 78);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(141, 22);
            this.textName.TabIndex = 1;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(427, 117);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(158, 16);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "Enter your ID Number:";
            this.labelID.Click += new System.EventHandler(this.labelID_Click);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(620, 111);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(141, 22);
            this.textID.TabIndex = 3;
            // 
            // labelCitizenship
            // 
            this.labelCitizenship.AutoSize = true;
            this.labelCitizenship.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCitizenship.Location = new System.Drawing.Point(427, 144);
            this.labelCitizenship.Name = "labelCitizenship";
            this.labelCitizenship.Size = new System.Drawing.Size(177, 16);
            this.labelCitizenship.TabIndex = 4;
            this.labelCitizenship.Text = "Choose your Citizenship:";
            this.labelCitizenship.Click += new System.EventHandler(this.labelCitizenship_Click);
            // 
            // comboBoxCitizenship
            // 
            this.comboBoxCitizenship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCitizenship.FormattingEnabled = true;
            this.comboBoxCitizenship.Items.AddRange(new object[] {
            "South African",
            "Tourist",
            "Permanent Resident"});
            this.comboBoxCitizenship.Location = new System.Drawing.Point(620, 141);
            this.comboBoxCitizenship.Name = "comboBoxCitizenship";
            this.comboBoxCitizenship.Size = new System.Drawing.Size(141, 24);
            this.comboBoxCitizenship.TabIndex = 5;
            this.comboBoxCitizenship.SelectedIndexChanged += new System.EventHandler(this.comboBoxCitizenship_SelectedIndexChanged);
            // 
            // buttonVaildate
            // 
            this.buttonVaildate.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonVaildate.Location = new System.Drawing.Point(632, 194);
            this.buttonVaildate.Name = "buttonVaildate";
            this.buttonVaildate.Size = new System.Drawing.Size(110, 23);
            this.buttonVaildate.TabIndex = 6;
            this.buttonVaildate.Text = "Validate ID";
            this.buttonVaildate.UseVisualStyleBackColor = false;
            this.buttonVaildate.Click += new System.EventHandler(this.buttonVaildate_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonProfile.Location = new System.Drawing.Point(632, 489);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(112, 23);
            this.buttonProfile.TabIndex = 7;
            this.buttonProfile.Text = "Generate Profile";
            this.buttonProfile.UseVisualStyleBackColor = false;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(330, 238);
            this.textResult.Multiline = true;
            this.textResult.Name = "textResult";
            this.textResult.ReadOnly = true;
            this.textResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textResult.Size = new System.Drawing.Size(448, 200);
            this.textResult.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(241, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Home Affairs Digital Identity Processor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 347);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.buttonProfile);
            this.Controls.Add(this.buttonVaildate);
            this.Controls.Add(this.comboBoxCitizenship);
            this.Controls.Add(this.labelCitizenship);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label labelCitizenship;
        private System.Windows.Forms.ComboBox comboBoxCitizenship;
        private System.Windows.Forms.Button buttonVaildate;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

