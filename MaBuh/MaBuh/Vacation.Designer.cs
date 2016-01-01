namespace MaBuh
{
    partial class Vacation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vacation));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.головнеМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.вийтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPeriodDaysAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPeriodHolidaysAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPeriodTotalSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTotalSum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox15PercentTax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1Dot5PercentTax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3Dot6PercentTax = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxTotalTax = new System.Windows.Forms.TextBox();
            this.textBoxResultSum = new System.Windows.Forms.TextBox();
            this.buttonCleanAllVacationFields = new System.Windows.Forms.Button();
            this.buttonCalcVacation = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxVacationDaysAmount = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(430, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.головнеМенюToolStripMenuItem,
            this.toolStripMenuItem1,
            this.вийтиToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // головнеМенюToolStripMenuItem
            // 
            this.головнеМенюToolStripMenuItem.Name = "головнеМенюToolStripMenuItem";
            this.головнеМенюToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.головнеМенюToolStripMenuItem.Text = "Головне вікно";
            this.головнеМенюToolStripMenuItem.Click += new System.EventHandler(this.головнеМенюToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // вийтиToolStripMenuItem
            // 
            this.вийтиToolStripMenuItem.Name = "вийтиToolStripMenuItem";
            this.вийтиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.вийтиToolStripMenuItem.Text = "Вийти";
            this.вийтиToolStripMenuItem.Click += new System.EventHandler(this.вийтиToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F);
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кількість календарних днів";
            // 
            // textBoxPeriodDaysAmount
            // 
            this.textBoxPeriodDaysAmount.Location = new System.Drawing.Point(12, 60);
            this.textBoxPeriodDaysAmount.Name = "textBoxPeriodDaysAmount";
            this.textBoxPeriodDaysAmount.Size = new System.Drawing.Size(207, 20);
            this.textBoxPeriodDaysAmount.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F);
            this.label2.Location = new System.Drawing.Point(227, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Кількість святкових днів";
            // 
            // textBoxPeriodHolidaysAmount
            // 
            this.textBoxPeriodHolidaysAmount.Location = new System.Drawing.Point(230, 60);
            this.textBoxPeriodHolidaysAmount.Name = "textBoxPeriodHolidaysAmount";
            this.textBoxPeriodHolidaysAmount.Size = new System.Drawing.Size(186, 20);
            this.textBoxPeriodHolidaysAmount.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F);
            this.label3.Location = new System.Drawing.Point(16, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(400, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Нарахована заробітня плата за розрахунковий період";
            // 
            // textBoxPeriodTotalSalary
            // 
            this.textBoxPeriodTotalSalary.Location = new System.Drawing.Point(12, 176);
            this.textBoxPeriodTotalSalary.Name = "textBoxPeriodTotalSalary";
            this.textBoxPeriodTotalSalary.Size = new System.Drawing.Size(404, 20);
            this.textBoxPeriodTotalSalary.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F);
            this.label4.Location = new System.Drawing.Point(43, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Разом";
            // 
            // textBoxTotalSum
            // 
            this.textBoxTotalSum.Location = new System.Drawing.Point(12, 223);
            this.textBoxTotalSum.Name = "textBoxTotalSum";
            this.textBoxTotalSum.Size = new System.Drawing.Size(120, 20);
            this.textBoxTotalSum.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F);
            this.label5.Location = new System.Drawing.Point(48, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "15%";
            // 
            // textBox15PercentTax
            // 
            this.textBox15PercentTax.Location = new System.Drawing.Point(12, 271);
            this.textBox15PercentTax.Name = "textBox15PercentTax";
            this.textBox15PercentTax.Size = new System.Drawing.Size(120, 20);
            this.textBox15PercentTax.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F);
            this.label6.Location = new System.Drawing.Point(200, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "1,5%";
            // 
            // textBox1Dot5PercentTax
            // 
            this.textBox1Dot5PercentTax.Location = new System.Drawing.Point(155, 271);
            this.textBox1Dot5PercentTax.Name = "textBox1Dot5PercentTax";
            this.textBox1Dot5PercentTax.Size = new System.Drawing.Size(120, 20);
            this.textBox1Dot5PercentTax.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F);
            this.label7.Location = new System.Drawing.Point(335, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "3,6%";
            // 
            // textBox3Dot6PercentTax
            // 
            this.textBox3Dot6PercentTax.Location = new System.Drawing.Point(296, 271);
            this.textBox3Dot6PercentTax.Name = "textBox3Dot6PercentTax";
            this.textBox3Dot6PercentTax.Size = new System.Drawing.Size(120, 20);
            this.textBox3Dot6PercentTax.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F);
            this.label8.Location = new System.Drawing.Point(26, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Утримання";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 12F);
            this.label9.Location = new System.Drawing.Point(176, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "До видачі";
            // 
            // textBoxTotalTax
            // 
            this.textBoxTotalTax.Location = new System.Drawing.Point(12, 329);
            this.textBoxTotalTax.Name = "textBoxTotalTax";
            this.textBoxTotalTax.Size = new System.Drawing.Size(120, 20);
            this.textBoxTotalTax.TabIndex = 17;
            // 
            // textBoxResultSum
            // 
            this.textBoxResultSum.Location = new System.Drawing.Point(155, 329);
            this.textBoxResultSum.Name = "textBoxResultSum";
            this.textBoxResultSum.Size = new System.Drawing.Size(120, 20);
            this.textBoxResultSum.TabIndex = 18;
            // 
            // buttonCleanAllVacationFields
            // 
            this.buttonCleanAllVacationFields.Font = new System.Drawing.Font("Georgia", 12F);
            this.buttonCleanAllVacationFields.Location = new System.Drawing.Point(179, 367);
            this.buttonCleanAllVacationFields.Name = "buttonCleanAllVacationFields";
            this.buttonCleanAllVacationFields.Size = new System.Drawing.Size(150, 45);
            this.buttonCleanAllVacationFields.TabIndex = 20;
            this.buttonCleanAllVacationFields.Text = "Очистити все";
            this.buttonCleanAllVacationFields.UseVisualStyleBackColor = true;
            this.buttonCleanAllVacationFields.Click += new System.EventHandler(this.buttonCleanAllVacationFields_Click);
            // 
            // buttonCalcVacation
            // 
            this.buttonCalcVacation.Font = new System.Drawing.Font("Georgia", 12F);
            this.buttonCalcVacation.Location = new System.Drawing.Point(11, 367);
            this.buttonCalcVacation.Name = "buttonCalcVacation";
            this.buttonCalcVacation.Size = new System.Drawing.Size(150, 45);
            this.buttonCalcVacation.TabIndex = 19;
            this.buttonCalcVacation.Text = "Рахувати";
            this.buttonCalcVacation.UseVisualStyleBackColor = true;
            this.buttonCalcVacation.Click += new System.EventHandler(this.buttonCalcVacation_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 12F);
            this.label10.Location = new System.Drawing.Point(11, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 18);
            this.label10.TabIndex = 21;
            this.label10.Text = "Кількість днів відпустки";
            // 
            // textBoxVacationDaysAmount
            // 
            this.textBoxVacationDaysAmount.Location = new System.Drawing.Point(11, 115);
            this.textBoxVacationDaysAmount.Name = "textBoxVacationDaysAmount";
            this.textBoxVacationDaysAmount.Size = new System.Drawing.Size(208, 20);
            this.textBoxVacationDaysAmount.TabIndex = 22;
            // 
            // Vacation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 430);
            this.Controls.Add(this.textBoxVacationDaysAmount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonCleanAllVacationFields);
            this.Controls.Add(this.buttonCalcVacation);
            this.Controls.Add(this.textBoxResultSum);
            this.Controls.Add(this.textBoxTotalTax);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3Dot6PercentTax);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1Dot5PercentTax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox15PercentTax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTotalSum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPeriodTotalSalary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPeriodHolidaysAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPeriodDaysAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Vacation";
            this.Text = "Відпустка";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem головнеМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вийтиToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPeriodDaysAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPeriodHolidaysAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPeriodTotalSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTotalSum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox15PercentTax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1Dot5PercentTax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3Dot6PercentTax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxTotalTax;
        private System.Windows.Forms.TextBox textBoxResultSum;
        private System.Windows.Forms.Button buttonCleanAllVacationFields;
        private System.Windows.Forms.Button buttonCalcVacation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxVacationDaysAmount;
    }
}