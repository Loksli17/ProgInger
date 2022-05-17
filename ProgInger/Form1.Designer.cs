
namespace ProgInger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.incomesView = new System.Windows.Forms.DataGridView();
            this.lecionsView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.monthDropView = new System.Windows.Forms.ComboBox();
            this.yearDropView = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.monthResultView = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.incomesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecionsView)).BeginInit();
            this.SuspendLayout();
            // 
            // incomesView
            // 
            this.incomesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incomesView.Location = new System.Drawing.Point(21, 198);
            this.incomesView.Name = "incomesView";
            this.incomesView.RowTemplate.Height = 25;
            this.incomesView.Size = new System.Drawing.Size(476, 366);
            this.incomesView.TabIndex = 0;
            // 
            // lecionsView
            // 
            this.lecionsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lecionsView.Location = new System.Drawing.Point(523, 198);
            this.lecionsView.Name = "lecionsView";
            this.lecionsView.RowTemplate.Height = 25;
            this.lecionsView.Size = new System.Drawing.Size(504, 366);
            this.lecionsView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Доходы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Убытки";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить доход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 43);
            this.button2.TabIndex = 5;
            this.button2.Text = "Добавить убыток";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // monthDropView
            // 
            this.monthDropView.FormattingEnabled = true;
            this.monthDropView.Location = new System.Drawing.Point(376, 122);
            this.monthDropView.Name = "monthDropView";
            this.monthDropView.Size = new System.Drawing.Size(121, 23);
            this.monthDropView.TabIndex = 6;
            this.monthDropView.SelectedIndexChanged += new System.EventHandler(this.monthDropView_SelectedIndexChanged);
            // 
            // yearDropView
            // 
            this.yearDropView.FormattingEnabled = true;
            this.yearDropView.Location = new System.Drawing.Point(512, 122);
            this.yearDropView.Name = "yearDropView";
            this.yearDropView.Size = new System.Drawing.Size(121, 23);
            this.yearDropView.TabIndex = 7;
            this.yearDropView.SelectedIndexChanged += new System.EventHandler(this.yearDropView_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(899, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Итог за месяц";
            // 
            // monthResultView
            // 
            this.monthResultView.AutoSize = true;
            this.monthResultView.Location = new System.Drawing.Point(1014, 122);
            this.monthResultView.Name = "monthResultView";
            this.monthResultView.Size = new System.Drawing.Size(13, 15);
            this.monthResultView.TabIndex = 9;
            this.monthResultView.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 587);
            this.Controls.Add(this.monthResultView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yearDropView);
            this.Controls.Add(this.monthDropView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lecionsView);
            this.Controls.Add(this.incomesView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.incomesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecionsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView incomesView;
        private System.Windows.Forms.DataGridView lecionsView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox monthDropView;
        private System.Windows.Forms.ComboBox yearDropView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label monthResultView;
    }
}

