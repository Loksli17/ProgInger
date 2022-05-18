
namespace ProgInger
{
    partial class FormCreate
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
            this.dateView = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.timeView = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.moneyView)).BeginInit();
            this.SuspendLayout();
            // 
            // createIncomeBtn
            // 
            this.createIncomeBtn.BackColor = System.Drawing.Color.LightGreen;
            this.createIncomeBtn.Location = new System.Drawing.Point(26, 250);
            this.createIncomeBtn.Name = "createIncomeBtn";
            this.createIncomeBtn.Size = new System.Drawing.Size(136, 54);
            this.createIncomeBtn.TabIndex = 0;
            this.createIncomeBtn.Text = "Добавить";
            this.createIncomeBtn.UseVisualStyleBackColor = false;
            this.createIncomeBtn.Click += new System.EventHandler(this.createIncomeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Источник";
            // 
            // goalView
            // 
            this.goalView.Location = new System.Drawing.Point(26, 104);
            this.goalView.Name = "goalView";
            this.goalView.Size = new System.Drawing.Size(200, 23);
            this.goalView.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сумма";
            // 
            // moneyView
            // 
            this.moneyView.Location = new System.Drawing.Point(273, 104);
            this.moneyView.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.moneyView.Name = "moneyView";
            this.moneyView.Size = new System.Drawing.Size(200, 23);
            this.moneyView.TabIndex = 4;
            // 
            // dateView
            // 
            this.dateView.Location = new System.Drawing.Point(26, 187);
            this.dateView.Name = "dateView";
            this.dateView.Size = new System.Drawing.Size(200, 23);
            this.dateView.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дата";
            // 
            // timeView
            // 
            this.timeView.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeView.Location = new System.Drawing.Point(273, 187);
            this.timeView.Name = "timeView";
            this.timeView.ShowUpDown = true;
            this.timeView.Size = new System.Drawing.Size(200, 23);
            this.timeView.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Время";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(26, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Создание дохода";
            // 
            // FormCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 336);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timeView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateView);
            this.Controls.Add(this.moneyView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.goalView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createIncomeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCreate";
            this.Text = "Добавление поступления / убытка";
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
        private System.Windows.Forms.DateTimePicker dateView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker timeView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}