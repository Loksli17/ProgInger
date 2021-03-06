
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
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lecionsView = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.monthDropView = new System.Windows.Forms.ComboBox();
            this.yearDropView = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.monthResultView = new System.Windows.Forms.Label();
            this.monthView = new System.Windows.Forms.ListView();
            this.month = new System.Windows.Forms.ColumnHeader();
            this.result = new System.Windows.Forms.ColumnHeader();
            this.currentYearView = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.incomesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecionsView)).BeginInit();
            this.SuspendLayout();
            // 
            // incomesView
            // 
            this.incomesView.AllowUserToAddRows = false;
            this.incomesView.AllowUserToDeleteRows = false;
            this.incomesView.AllowUserToResizeColumns = false;
            this.incomesView.AllowUserToResizeRows = false;
            this.incomesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incomesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn1,
            this.dataGridViewButtonColumn2});
            this.incomesView.Location = new System.Drawing.Point(24, 144);
            this.incomesView.Name = "incomesView";
            this.incomesView.ReadOnly = true;
            this.incomesView.RowTemplate.Height = 25;
            this.incomesView.Size = new System.Drawing.Size(420, 366);
            this.incomesView.TabIndex = 0;
            this.incomesView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.incomesView_CellContentClick);
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Удалить";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewButtonColumn1.Text = "Удалить";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn1.Width = 60;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "Изменить";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.ReadOnly = true;
            this.dataGridViewButtonColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewButtonColumn2.Text = "Изменить";
            this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn2.Width = 70;
            // 
            // lecionsView
            // 
            this.lecionsView.AllowUserToAddRows = false;
            this.lecionsView.AllowUserToDeleteRows = false;
            this.lecionsView.AllowUserToResizeColumns = false;
            this.lecionsView.AllowUserToResizeRows = false;
            this.lecionsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lecionsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.Edit});
            this.lecionsView.Location = new System.Drawing.Point(467, 144);
            this.lecionsView.Name = "lecionsView";
            this.lecionsView.ReadOnly = true;
            this.lecionsView.RowTemplate.Height = 25;
            this.lecionsView.Size = new System.Drawing.Size(420, 366);
            this.lecionsView.TabIndex = 1;
            this.lecionsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lecionsView_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Удалить";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.Text = "Удалить";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 60;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Изменить";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edit.Text = "Изменить";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Доходы (Месяц)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(467, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Убытки (Месяц)";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(24, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить доход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Pink;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(196, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 43);
            this.button2.TabIndex = 5;
            this.button2.Text = "Добавить убыток";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // monthDropView
            // 
            this.monthDropView.FormattingEnabled = true;
            this.monthDropView.ItemHeight = 15;
            this.monthDropView.Location = new System.Drawing.Point(595, 43);
            this.monthDropView.Name = "monthDropView";
            this.monthDropView.Size = new System.Drawing.Size(144, 23);
            this.monthDropView.TabIndex = 6;
            this.monthDropView.SelectedIndexChanged += new System.EventHandler(this.monthDropView_SelectedIndexChanged);
            // 
            // yearDropView
            // 
            this.yearDropView.FormattingEnabled = true;
            this.yearDropView.Location = new System.Drawing.Point(745, 43);
            this.yearDropView.Name = "yearDropView";
            this.yearDropView.Size = new System.Drawing.Size(144, 23);
            this.yearDropView.TabIndex = 7;
            this.yearDropView.SelectedIndexChanged += new System.EventHandler(this.yearDropView_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(378, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Итог за месяц";
            // 
            // monthResultView
            // 
            this.monthResultView.AutoSize = true;
            this.monthResultView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monthResultView.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.monthResultView.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.monthResultView.Location = new System.Drawing.Point(511, 41);
            this.monthResultView.Name = "monthResultView";
            this.monthResultView.Size = new System.Drawing.Size(24, 27);
            this.monthResultView.TabIndex = 9;
            this.monthResultView.Text = "0";
            // 
            // monthView
            // 
            this.monthView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.month,
            this.result});
            this.monthView.GridLines = true;
            this.monthView.HideSelection = false;
            this.monthView.Location = new System.Drawing.Point(912, 144);
            this.monthView.Name = "monthView";
            this.monthView.Size = new System.Drawing.Size(218, 366);
            this.monthView.TabIndex = 10;
            this.monthView.UseCompatibleStateImageBehavior = false;
            this.monthView.View = System.Windows.Forms.View.Details;
            // 
            // month
            // 
            this.month.Text = "Месяц";
            this.month.Width = 105;
            // 
            // result
            // 
            this.result.Text = "Итог";
            this.result.Width = 105;
            // 
            // currentYearView
            // 
            this.currentYearView.AutoSize = true;
            this.currentYearView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentYearView.Location = new System.Drawing.Point(912, 116);
            this.currentYearView.Name = "currentYearView";
            this.currentYearView.Size = new System.Drawing.Size(41, 20);
            this.currentYearView.TabIndex = 11;
            this.currentYearView.Text = "0000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(959, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "год";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 547);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.currentYearView);
            this.Controls.Add(this.monthView);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Учет доходов и расходов";
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
        private System.Windows.Forms.ListView monthView;
        private System.Windows.Forms.ColumnHeader month;
        private System.Windows.Forms.ColumnHeader result;
        private System.Windows.Forms.Label currentYearView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
    }
}

