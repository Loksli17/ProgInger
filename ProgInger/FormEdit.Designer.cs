
namespace ProgInger
{
    partial class FormEdit
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
            this.editBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.timeViewEdit = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateViewEdit = new System.Windows.Forms.DateTimePicker();
            this.moneyViewEdit = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.goalViewEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.moneyViewEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // editBtn
            // 
            this.editBtn.ForeColor = System.Drawing.Color.LightGreen;
            this.editBtn.Location = new System.Drawing.Point(25, 248);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(136, 54);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "Изменить";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Время";
            // 
            // timeViewEdit
            // 
            this.timeViewEdit.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeViewEdit.Location = new System.Drawing.Point(272, 182);
            this.timeViewEdit.Name = "timeViewEdit";
            this.timeViewEdit.ShowUpDown = true;
            this.timeViewEdit.Size = new System.Drawing.Size(200, 23);
            this.timeViewEdit.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Дата";
            // 
            // dateViewEdit
            // 
            this.dateViewEdit.Location = new System.Drawing.Point(25, 182);
            this.dateViewEdit.Name = "dateViewEdit";
            this.dateViewEdit.Size = new System.Drawing.Size(200, 23);
            this.dateViewEdit.TabIndex = 9;
            // 
            // moneyViewEdit
            // 
            this.moneyViewEdit.Location = new System.Drawing.Point(272, 99);
            this.moneyViewEdit.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.moneyViewEdit.Name = "moneyViewEdit";
            this.moneyViewEdit.Size = new System.Drawing.Size(200, 23);
            this.moneyViewEdit.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Сумма";
            // 
            // goalViewEdit
            // 
            this.goalViewEdit.Location = new System.Drawing.Point(25, 99);
            this.goalViewEdit.Name = "goalViewEdit";
            this.goalViewEdit.Size = new System.Drawing.Size(200, 23);
            this.goalViewEdit.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Источник";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(25, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 28);
            this.label5.TabIndex = 17;
            this.label5.Text = "Изменение дохода";
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 345);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.moneyViewEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.goalViewEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timeViewEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateViewEdit);
            this.Controls.Add(this.editBtn);
            this.Name = "FormEdit";
            this.Text = "FormEdit";
            ((System.ComponentModel.ISupportInitialize)(this.moneyViewEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker timeViewEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateViewEdit;
        private System.Windows.Forms.NumericUpDown moneyViewEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox goalViewEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}