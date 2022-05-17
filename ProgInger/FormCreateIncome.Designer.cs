
namespace ProgInger
{
    partial class FormCreateIncome
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
            this.createIncomeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.goalView = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.moneyView = new System.Windows.Forms.NumericUpDown();
            this.dateTimeView = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.moneyView)).BeginInit();
            this.SuspendLayout();
            // 
            // createIncomeBtn
            // 
            this.createIncomeBtn.Location = new System.Drawing.Point(41, 250);
            this.createIncomeBtn.Name = "createIncomeBtn";
            this.createIncomeBtn.Size = new System.Drawing.Size(136, 54);
            this.createIncomeBtn.TabIndex = 0;
            this.createIncomeBtn.Text = "Добавить";
            this.createIncomeBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // goalView
            // 
            this.goalView.Location = new System.Drawing.Point(41, 104);
            this.goalView.Name = "goalView";
            this.goalView.Size = new System.Drawing.Size(200, 23);
            this.goalView.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // moneyView
            // 
            this.moneyView.Location = new System.Drawing.Point(288, 104);
            this.moneyView.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.moneyView.Name = "moneyView";
            this.moneyView.Size = new System.Drawing.Size(200, 23);
            this.moneyView.TabIndex = 4;
            // 
            // dateTimeView
            // 
            this.dateTimeView.Location = new System.Drawing.Point(41, 187);
            this.dateTimeView.Name = "dateTimeView";
            this.dateTimeView.Size = new System.Drawing.Size(200, 23);
            this.dateTimeView.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(288, 186);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(41, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Создание дохода";
            // 
            // FormCreateIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 336);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimeView);
            this.Controls.Add(this.moneyView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.goalView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createIncomeBtn);
            this.Name = "FormCreateIncome";
            this.Text = "FormCreateIncome";
            ((System.ComponentModel.ISupportInitialize)(this.moneyView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createIncomeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox goalView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown moneyView;
        private System.Windows.Forms.DateTimePicker dateTimeView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}