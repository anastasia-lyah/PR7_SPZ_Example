namespace PR7_SPZ_Example
{
    partial class fTowm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.tbRegion = new System.Windows.Forms.TextBox();
            this.tbPopulation = new System.Windows.Forms.TextBox();
            this.tbYearIncome = new System.Windows.Forms.TextBox();
            this.tbSquare = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbHasPort = new System.Windows.Forms.CheckBox();
            this.cbHasAirport = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSquare);
            this.groupBox1.Controls.Add(this.tbYearIncome);
            this.groupBox1.Controls.Add(this.tbPopulation);
            this.groupBox1.Controls.Add(this.tbRegion);
            this.groupBox1.Controls.Add(this.tbCountry);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 284);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загальні дані";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "Площа, кв. км";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Річний дохід, грн";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Кількість мешканців";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Регіон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Країна";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва міста";
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Location = new System.Drawing.Point(214, 40);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(184, 29);
            this.tbName.TabIndex = 6;
            this.tbName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbCountry
            // 
            this.tbCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCountry.Location = new System.Drawing.Point(214, 79);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(184, 29);
            this.tbCountry.TabIndex = 7;
            // 
            // tbRegion
            // 
            this.tbRegion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRegion.Location = new System.Drawing.Point(214, 118);
            this.tbRegion.Name = "tbRegion";
            this.tbRegion.Size = new System.Drawing.Size(184, 29);
            this.tbRegion.TabIndex = 8;
            // 
            // tbPopulation
            // 
            this.tbPopulation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPopulation.Location = new System.Drawing.Point(214, 157);
            this.tbPopulation.Name = "tbPopulation";
            this.tbPopulation.Size = new System.Drawing.Size(184, 29);
            this.tbPopulation.TabIndex = 9;
            // 
            // tbYearIncome
            // 
            this.tbYearIncome.BackColor = System.Drawing.SystemColors.Window;
            this.tbYearIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbYearIncome.Location = new System.Drawing.Point(214, 196);
            this.tbYearIncome.Name = "tbYearIncome";
            this.tbYearIncome.Size = new System.Drawing.Size(184, 29);
            this.tbYearIncome.TabIndex = 10;
            // 
            // tbSquare
            // 
            this.tbSquare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSquare.Location = new System.Drawing.Point(214, 235);
            this.tbSquare.Name = "tbSquare";
            this.tbSquare.Size = new System.Drawing.Size(184, 29);
            this.tbSquare.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbHasAirport);
            this.groupBox2.Controls.Add(this.cbHasPort);
            this.groupBox2.Location = new System.Drawing.Point(12, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 131);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Транспорт";
            // 
            // cbHasPort
            // 
            this.cbHasPort.AutoSize = true;
            this.cbHasPort.Location = new System.Drawing.Point(28, 46);
            this.cbHasPort.Name = "cbHasPort";
            this.cbHasPort.Size = new System.Drawing.Size(158, 31);
            this.cbHasPort.TabIndex = 2;
            this.cbHasPort.Text = "Місто має порт";
            this.cbHasPort.UseVisualStyleBackColor = true;
            // 
            // cbHasAirport
            // 
            this.cbHasAirport.AutoSize = true;
            this.cbHasAirport.Location = new System.Drawing.Point(28, 83);
            this.cbHasAirport.Name = "cbHasAirport";
            this.cbHasAirport.Size = new System.Drawing.Size(197, 31);
            this.cbHasAirport.TabIndex = 3;
            this.cbHasAirport.Text = "Місто має аеропорт";
            this.cbHasAirport.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(474, 49);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(126, 37);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "Ок";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(474, 93);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(126, 37);
            this.btnNo.TabIndex = 14;
            this.btnNo.Text = "Скасувати";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // fTowm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 451);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Onest", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fTowm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дані про нове місто";
            this.Load += new System.EventHandler(this.fTowm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSquare;
        private System.Windows.Forms.TextBox tbYearIncome;
        private System.Windows.Forms.TextBox tbPopulation;
        private System.Windows.Forms.TextBox tbRegion;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbHasAirport;
        private System.Windows.Forms.CheckBox cbHasPort;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnNo;
    }
}