namespace GTPSystem
{
    partial class FormSalary
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
            this.LoadDb = new System.Windows.Forms.DataGridView();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.GrossPayBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BasePayBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EmployeeListCBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NoPayBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SalaryCycleDateRangeBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TotalSalaryBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.AbsentBox = new System.Windows.Forms.TextBox();
            this.HolidayListBox = new System.Windows.Forms.ComboBox();
            this.SalaryIssueDateBox = new System.Windows.Forms.DateTimePicker();
            this.CulculationBtn = new System.Windows.Forms.Button();
            this.AllowancesBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OvertimeRateBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.GovTexBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LoadDb)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadDb
            // 
            this.LoadDb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoadDb.Location = new System.Drawing.Point(33, 313);
            this.LoadDb.Name = "LoadDb";
            this.LoadDb.Size = new System.Drawing.Size(607, 174);
            this.LoadDb.TabIndex = 45;
            this.LoadDb.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LoadDb_CellClick);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(189)))), ((int)(((byte)(97)))));
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Nunito Medium", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBtn.Location = new System.Drawing.Point(666, 323);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(121, 42);
            this.AddBtn.TabIndex = 44;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Salmon;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Nunito Medium", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteBtn.Location = new System.Drawing.Point(666, 435);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(121, 42);
            this.DeleteBtn.TabIndex = 43;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Nunito Medium", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateBtn.Location = new System.Drawing.Point(666, 379);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(121, 42);
            this.UpdateBtn.TabIndex = 42;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(287, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 33);
            this.label7.TabIndex = 41;
            this.label7.Text = "SALARY RECORDS";
            // 
            // GrossPayBox
            // 
            this.GrossPayBox.Font = new System.Drawing.Font("Nunito", 12F);
            this.GrossPayBox.Location = new System.Drawing.Point(60, 128);
            this.GrossPayBox.Multiline = true;
            this.GrossPayBox.Name = "GrossPayBox";
            this.GrossPayBox.Size = new System.Drawing.Size(200, 34);
            this.GrossPayBox.TabIndex = 37;
            this.GrossPayBox.TextChanged += new System.EventHandler(this.GrossPayBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nunito Medium", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(280, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 18);
            this.label6.TabIndex = 31;
            this.label6.Text = "Salary Issue Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nunito Medium", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Gross Pay Value";
            // 
            // BasePayBox
            // 
            this.BasePayBox.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasePayBox.Location = new System.Drawing.Point(506, 67);
            this.BasePayBox.Multiline = true;
            this.BasePayBox.Name = "BasePayBox";
            this.BasePayBox.Size = new System.Drawing.Size(200, 34);
            this.BasePayBox.TabIndex = 40;
            this.BasePayBox.TextChanged += new System.EventHandler(this.BasePayBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nunito Medium", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(503, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Base Pay Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nunito Medium", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 31;
            this.label3.Text = "Employee Name";
            // 
            // EmployeeListCBox
            // 
            this.EmployeeListCBox.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeListCBox.FormattingEnabled = true;
            this.EmployeeListCBox.ItemHeight = 22;
            this.EmployeeListCBox.Location = new System.Drawing.Point(60, 67);
            this.EmployeeListCBox.Name = "EmployeeListCBox";
            this.EmployeeListCBox.Size = new System.Drawing.Size(200, 30);
            this.EmployeeListCBox.TabIndex = 46;
            this.EmployeeListCBox.SelectedIndexChanged += new System.EventHandler(this.EmployeeListCBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nunito Medium", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(280, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 30;
            this.label5.Text = "No Pay Value";
            // 
            // NoPayBox
            // 
            this.NoPayBox.Font = new System.Drawing.Font("Nunito", 12F);
            this.NoPayBox.Location = new System.Drawing.Point(283, 128);
            this.NoPayBox.Multiline = true;
            this.NoPayBox.Name = "NoPayBox";
            this.NoPayBox.Size = new System.Drawing.Size(200, 34);
            this.NoPayBox.TabIndex = 37;
            this.NoPayBox.TextChanged += new System.EventHandler(this.NoPayBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nunito Medium", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 18);
            this.label8.TabIndex = 23;
            this.label8.Text = "Salary Cycle Date Range";
            // 
            // SalaryCycleDateRangeBox
            // 
            this.SalaryCycleDateRangeBox.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryCycleDateRangeBox.Location = new System.Drawing.Point(60, 196);
            this.SalaryCycleDateRangeBox.Multiline = true;
            this.SalaryCycleDateRangeBox.Name = "SalaryCycleDateRangeBox";
            this.SalaryCycleDateRangeBox.Size = new System.Drawing.Size(200, 34);
            this.SalaryCycleDateRangeBox.TabIndex = 40;
            this.SalaryCycleDateRangeBox.TextChanged += new System.EventHandler(this.SalaryCycleDateRangeBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nunito Medium", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(503, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 18);
            this.label9.TabIndex = 29;
            this.label9.Text = "Total Salary";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nunito Medium", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(503, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 18);
            this.label10.TabIndex = 30;
            this.label10.Text = "Holiday Month";
            // 
            // TotalSalaryBox
            // 
            this.TotalSalaryBox.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSalaryBox.Location = new System.Drawing.Point(506, 128);
            this.TotalSalaryBox.Multiline = true;
            this.TotalSalaryBox.Name = "TotalSalaryBox";
            this.TotalSalaryBox.Size = new System.Drawing.Size(200, 34);
            this.TotalSalaryBox.TabIndex = 36;
            this.TotalSalaryBox.TextChanged += new System.EventHandler(this.TotalSalaryBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nunito Medium", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(280, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 18);
            this.label11.TabIndex = 31;
            this.label11.Text = "Absent";
            // 
            // AbsentBox
            // 
            this.AbsentBox.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbsentBox.Location = new System.Drawing.Point(283, 196);
            this.AbsentBox.Multiline = true;
            this.AbsentBox.Name = "AbsentBox";
            this.AbsentBox.Size = new System.Drawing.Size(200, 34);
            this.AbsentBox.TabIndex = 40;
            this.AbsentBox.TextChanged += new System.EventHandler(this.AbsentBox_TextChanged);
            // 
            // HolidayListBox
            // 
            this.HolidayListBox.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HolidayListBox.FormattingEnabled = true;
            this.HolidayListBox.ItemHeight = 22;
            this.HolidayListBox.Location = new System.Drawing.Point(506, 196);
            this.HolidayListBox.Name = "HolidayListBox";
            this.HolidayListBox.Size = new System.Drawing.Size(200, 30);
            this.HolidayListBox.TabIndex = 46;
            this.HolidayListBox.SelectedIndexChanged += new System.EventHandler(this.HolidayListBox_SelectedIndexChanged);
            // 
            // SalaryIssueDateBox
            // 
            this.SalaryIssueDateBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SalaryIssueDateBox.Location = new System.Drawing.Point(283, 68);
            this.SalaryIssueDateBox.Name = "SalaryIssueDateBox";
            this.SalaryIssueDateBox.Size = new System.Drawing.Size(200, 20);
            this.SalaryIssueDateBox.TabIndex = 47;
            this.SalaryIssueDateBox.ValueChanged += new System.EventHandler(this.SalaryIssueDateBox_ValueChanged);
            // 
            // CulculationBtn
            // 
            this.CulculationBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.CulculationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CulculationBtn.Font = new System.Drawing.Font("Nunito Medium", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CulculationBtn.ForeColor = System.Drawing.Color.White;
            this.CulculationBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CulculationBtn.Location = new System.Drawing.Point(666, 267);
            this.CulculationBtn.Name = "CulculationBtn";
            this.CulculationBtn.Size = new System.Drawing.Size(121, 42);
            this.CulculationBtn.TabIndex = 44;
            this.CulculationBtn.Text = "Culculation";
            this.CulculationBtn.UseVisualStyleBackColor = false;
            this.CulculationBtn.Click += new System.EventHandler(this.CulculationBtn_Click);
            // 
            // AllowancesBox
            // 
            this.AllowancesBox.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllowancesBox.Location = new System.Drawing.Point(60, 266);
            this.AllowancesBox.Multiline = true;
            this.AllowancesBox.Name = "AllowancesBox";
            this.AllowancesBox.Size = new System.Drawing.Size(200, 34);
            this.AllowancesBox.TabIndex = 40;
            this.AllowancesBox.TextChanged += new System.EventHandler(this.AllowancesBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nunito Medium", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Allowances";
            // 
            // OvertimeRateBox
            // 
            this.OvertimeRateBox.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OvertimeRateBox.Location = new System.Drawing.Point(283, 266);
            this.OvertimeRateBox.Multiline = true;
            this.OvertimeRateBox.Name = "OvertimeRateBox";
            this.OvertimeRateBox.Size = new System.Drawing.Size(200, 34);
            this.OvertimeRateBox.TabIndex = 40;
            this.OvertimeRateBox.TextChanged += new System.EventHandler(this.OvertimeRateBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nunito Medium", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(280, 245);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 18);
            this.label12.TabIndex = 31;
            this.label12.Text = "Overtime Rate";
            // 
            // GovTexBox
            // 
            this.GovTexBox.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GovTexBox.Location = new System.Drawing.Point(506, 264);
            this.GovTexBox.Multiline = true;
            this.GovTexBox.Name = "GovTexBox";
            this.GovTexBox.Size = new System.Drawing.Size(146, 34);
            this.GovTexBox.TabIndex = 40;
            this.GovTexBox.TextChanged += new System.EventHandler(this.GovTexBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Nunito Medium", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(503, 243);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 18);
            this.label13.TabIndex = 31;
            this.label13.Text = "Government Tax Rate";
            // 
            // FormSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 501);
            this.Controls.Add(this.SalaryIssueDateBox);
            this.Controls.Add(this.HolidayListBox);
            this.Controls.Add(this.EmployeeListCBox);
            this.Controls.Add(this.LoadDb);
            this.Controls.Add(this.CulculationBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NoPayBox);
            this.Controls.Add(this.GrossPayBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TotalSalaryBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GovTexBox);
            this.Controls.Add(this.OvertimeRateBox);
            this.Controls.Add(this.AllowancesBox);
            this.Controls.Add(this.AbsentBox);
            this.Controls.Add(this.SalaryCycleDateRangeBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BasePayBox);
            this.Controls.Add(this.label2);
            this.Name = "FormSalary";
            this.Text = "FormSalary";
            this.Load += new System.EventHandler(this.FormSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoadDb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView LoadDb;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox GrossPayBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BasePayBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox EmployeeListCBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NoPayBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SalaryCycleDateRangeBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TotalSalaryBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox AbsentBox;
        private System.Windows.Forms.ComboBox HolidayListBox;
        private System.Windows.Forms.DateTimePicker SalaryIssueDateBox;
        private System.Windows.Forms.Button CulculationBtn;
        private System.Windows.Forms.TextBox AllowancesBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OvertimeRateBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox GovTexBox;
        private System.Windows.Forms.Label label13;
    }
}