namespace MaBuh
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.buttonSalary = new System.Windows.Forms.Button();
            this.buttonMedicine = new System.Windows.Forms.Button();
            this.buttonVaсation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSalary
            // 
            this.buttonSalary.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSalary.Location = new System.Drawing.Point(75, 75);
            this.buttonSalary.Name = "buttonSalary";
            this.buttonSalary.Size = new System.Drawing.Size(250, 50);
            this.buttonSalary.TabIndex = 0;
            this.buttonSalary.Text = "Заробітня плата";
            this.buttonSalary.UseVisualStyleBackColor = true;
            this.buttonSalary.Click += new System.EventHandler(this.buttonSalary_Click);
            // 
            // buttonMedicine
            // 
            this.buttonMedicine.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMedicine.Location = new System.Drawing.Point(75, 150);
            this.buttonMedicine.Name = "buttonMedicine";
            this.buttonMedicine.Size = new System.Drawing.Size(250, 50);
            this.buttonMedicine.TabIndex = 1;
            this.buttonMedicine.Text = "Лікарняний";
            this.buttonMedicine.UseVisualStyleBackColor = true;
            this.buttonMedicine.Click += new System.EventHandler(this.buttonMedicine_Click);
            // 
            // buttonVaсation
            // 
            this.buttonVaсation.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVaсation.Location = new System.Drawing.Point(75, 225);
            this.buttonVaсation.Name = "buttonVaсation";
            this.buttonVaсation.Size = new System.Drawing.Size(250, 50);
            this.buttonVaсation.TabIndex = 2;
            this.buttonVaсation.Text = "Відпустка";
            this.buttonVaсation.UseVisualStyleBackColor = true;
            this.buttonVaсation.Click += new System.EventHandler(this.buttonVaсation_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 370);
            this.Controls.Add(this.buttonVaсation);
            this.Controls.Add(this.buttonMedicine);
            this.Controls.Add(this.buttonSalary);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "MaBuh";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSalary;
        private System.Windows.Forms.Button buttonMedicine;
        private System.Windows.Forms.Button buttonVaсation;
    }
}

