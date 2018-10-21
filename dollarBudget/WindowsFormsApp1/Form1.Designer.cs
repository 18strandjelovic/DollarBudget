namespace WindowsFormsApp1
{
    partial class mainPaige
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
            System.Windows.Forms.Button save;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loadHome = new System.Windows.Forms.Button();
            this.loadAnalytics = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.expence = new System.Windows.Forms.Button();
            this.conAmount = new System.Windows.Forms.Button();
            this.newAmount = new System.Windows.Forms.TextBox();
            this.newType = new System.Windows.Forms.TextBox();
            this.incomeTxt = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.amountBalance = new System.Windows.Forms.ListBox();
            this.expenceAmount = new System.Windows.Forms.ListBox();
            this.expenceType = new System.Windows.Forms.ListBox();
            this.ldBudget = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.incomeLeft = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.totalIncomeLbl = new System.Windows.Forms.Label();
            this.clearField = new System.Windows.Forms.Button();
            save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkBlue;
            this.pictureBox1.Location = new System.Drawing.Point(1, -6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1173, 92);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox2.Location = new System.Drawing.Point(1, 78);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 514);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // loadHome
            // 
            this.loadHome.BackColor = System.Drawing.Color.DimGray;
            this.loadHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loadHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loadHome.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadHome.ForeColor = System.Drawing.Color.White;
            this.loadHome.Location = new System.Drawing.Point(1, 88);
            this.loadHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadHome.Name = "loadHome";
            this.loadHome.Size = new System.Drawing.Size(159, 80);
            this.loadHome.TabIndex = 5;
            this.loadHome.Text = "Home";
            this.loadHome.UseVisualStyleBackColor = false;
            this.loadHome.Click += new System.EventHandler(this.loadHome_Click);
            // 
            // loadAnalytics
            // 
            this.loadAnalytics.BackColor = System.Drawing.Color.DimGray;
            this.loadAnalytics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loadAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loadAnalytics.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadAnalytics.ForeColor = System.Drawing.Color.White;
            this.loadAnalytics.Location = new System.Drawing.Point(1, 164);
            this.loadAnalytics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadAnalytics.Name = "loadAnalytics";
            this.loadAnalytics.Size = new System.Drawing.Size(159, 80);
            this.loadAnalytics.TabIndex = 6;
            this.loadAnalytics.Text = "Analytics";
            this.loadAnalytics.UseVisualStyleBackColor = false;
            this.loadAnalytics.Click += new System.EventHandler(this.loadAnalytics_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkBlue;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGreen;
            this.label1.Location = new System.Drawing.Point(37, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 83);
            this.label1.TabIndex = 7;
            this.label1.Text = "$B";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.expence);
            this.groupBox1.Controls.Add(this.conAmount);
            this.groupBox1.Controls.Add(this.newAmount);
            this.groupBox1.Controls.Add(this.newType);
            this.groupBox1.Controls.Add(this.incomeTxt);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.LightGreen;
            this.groupBox1.Location = new System.Drawing.Point(262, 164);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(814, 142);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert New";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // expence
            // 
            this.expence.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.expence.Location = new System.Drawing.Point(739, 78);
            this.expence.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.expence.Name = "expence";
            this.expence.Size = new System.Drawing.Size(48, 35);
            this.expence.TabIndex = 8;
            this.expence.Text = "✔";
            this.expence.UseVisualStyleBackColor = true;
            this.expence.Click += new System.EventHandler(this.button5_Click);
            // 
            // conAmount
            // 
            this.conAmount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.conAmount.Location = new System.Drawing.Point(169, 78);
            this.conAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.conAmount.Name = "conAmount";
            this.conAmount.Size = new System.Drawing.Size(48, 35);
            this.conAmount.TabIndex = 6;
            this.conAmount.Text = "✔";
            this.conAmount.UseVisualStyleBackColor = true;
            this.conAmount.Click += new System.EventHandler(this.button3_Click);
            // 
            // newAmount
            // 
            this.newAmount.Location = new System.Drawing.Point(579, 78);
            this.newAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newAmount.Name = "newAmount";
            this.newAmount.Size = new System.Drawing.Size(154, 35);
            this.newAmount.TabIndex = 5;
            // 
            // newType
            // 
            this.newType.Location = new System.Drawing.Point(302, 78);
            this.newType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newType.Name = "newType";
            this.newType.Size = new System.Drawing.Size(154, 35);
            this.newType.TabIndex = 4;
            // 
            // incomeTxt
            // 
            this.incomeTxt.Location = new System.Drawing.Point(6, 78);
            this.incomeTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.incomeTxt.Name = "incomeTxt";
            this.incomeTxt.Size = new System.Drawing.Size(154, 35);
            this.incomeTxt.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(579, 34);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(154, 25);
            this.textBox4.TabIndex = 2;
            this.textBox4.Text = "Goal:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(302, 34);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(154, 25);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "New Expence:";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(6, 34);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 25);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Monthly Income:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkBlue;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(555, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 54);
            this.label2.TabIndex = 9;
            this.label2.Text = "DollarBudget";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DimGray;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.amountBalance);
            this.groupBox2.Controls.Add(this.expenceAmount);
            this.groupBox2.Controls.Add(this.expenceType);
            this.groupBox2.Location = new System.Drawing.Point(262, 362);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(808, 165);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(532, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Balance:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(267, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Goal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Category:";
            // 
            // amountBalance
            // 
            this.amountBalance.FormattingEnabled = true;
            this.amountBalance.ItemHeight = 20;
            this.amountBalance.Location = new System.Drawing.Point(536, 55);
            this.amountBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.amountBalance.Name = "amountBalance";
            this.amountBalance.Size = new System.Drawing.Size(259, 104);
            this.amountBalance.TabIndex = 2;
            // 
            // expenceAmount
            // 
            this.expenceAmount.FormattingEnabled = true;
            this.expenceAmount.ItemHeight = 20;
            this.expenceAmount.Location = new System.Drawing.Point(271, 55);
            this.expenceAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.expenceAmount.Name = "expenceAmount";
            this.expenceAmount.Size = new System.Drawing.Size(259, 104);
            this.expenceAmount.TabIndex = 1;
            // 
            // expenceType
            // 
            this.expenceType.FormattingEnabled = true;
            this.expenceType.ItemHeight = 20;
            this.expenceType.Location = new System.Drawing.Point(6, 55);
            this.expenceType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.expenceType.Name = "expenceType";
            this.expenceType.Size = new System.Drawing.Size(259, 104);
            this.expenceType.TabIndex = 0;
            // 
            // ldBudget
            // 
            this.ldBudget.BackColor = System.Drawing.Color.DimGray;
            this.ldBudget.Font = new System.Drawing.Font("Calibri", 8F);
            this.ldBudget.ForeColor = System.Drawing.Color.White;
            this.ldBudget.Location = new System.Drawing.Point(180, 99);
            this.ldBudget.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ldBudget.Name = "ldBudget";
            this.ldBudget.Size = new System.Drawing.Size(110, 49);
            this.ldBudget.TabIndex = 11;
            this.ldBudget.Text = "Load Budget";
            this.ldBudget.UseVisualStyleBackColor = false;
            this.ldBudget.Click += new System.EventHandler(this.ldBudget_Click);
            // 
            // save
            // 
            save.BackColor = System.Drawing.Color.DimGray;
            save.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            save.ForeColor = System.Drawing.Color.White;
            save.Location = new System.Drawing.Point(297, 99);
            save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            save.Name = "save";
            save.Size = new System.Drawing.Size(110, 49);
            save.TabIndex = 12;
            save.Text = "save";
            save.UseVisualStyleBackColor = false;
            save.Click += new System.EventHandler(this.save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Unallocated Income:";
            // 
            // incomeLeft
            // 
            this.incomeLeft.AutoSize = true;
            this.incomeLeft.Location = new System.Drawing.Point(423, 339);
            this.incomeLeft.Name = "incomeLeft";
            this.incomeLeft.Size = new System.Drawing.Size(0, 20);
            this.incomeLeft.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Total Income:";
            // 
            // totalIncomeLbl
            // 
            this.totalIncomeLbl.AutoSize = true;
            this.totalIncomeLbl.Location = new System.Drawing.Point(423, 309);
            this.totalIncomeLbl.Name = "totalIncomeLbl";
            this.totalIncomeLbl.Size = new System.Drawing.Size(0, 20);
            this.totalIncomeLbl.TabIndex = 16;
            // 
            // clearField
            // 
            this.clearField.BackColor = System.Drawing.Color.DimGray;
            this.clearField.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearField.ForeColor = System.Drawing.Color.White;
            this.clearField.Location = new System.Drawing.Point(415, 99);
            this.clearField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearField.Name = "clearField";
            this.clearField.Size = new System.Drawing.Size(102, 49);
            this.clearField.TabIndex = 17;
            this.clearField.Text = "Clear All";
            this.clearField.UseVisualStyleBackColor = false;
            this.clearField.Click += new System.EventHandler(this.clearField_Click);
            // 
            // mainPaige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1170, 588);
            this.Controls.Add(this.clearField);
            this.Controls.Add(this.totalIncomeLbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.incomeLeft);
            this.Controls.Add(this.label6);
            this.Controls.Add(save);
            this.Controls.Add(this.ldBudget);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadAnalytics);
            this.Controls.Add(this.loadHome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "mainPaige";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainPaige_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button loadHome;
        private System.Windows.Forms.Button loadAnalytics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button conAmount;
        private System.Windows.Forms.TextBox newAmount;
        private System.Windows.Forms.TextBox newType;
        private System.Windows.Forms.TextBox incomeTxt;
        private System.Windows.Forms.Button expence;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox amountBalance;
        private System.Windows.Forms.ListBox expenceAmount;
        private System.Windows.Forms.ListBox expenceType;
        private System.Windows.Forms.Button ldBudget;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label incomeLeft;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label totalIncomeLbl;
        private System.Windows.Forms.Button clearField;
    }
}

