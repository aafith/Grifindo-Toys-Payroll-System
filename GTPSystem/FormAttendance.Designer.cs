namespace GTPSystem
{
    partial class FormAttendance
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
            this.AnnualLeaveBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CasualLeaveBox = new System.Windows.Forms.TextBox();
            this.EmployeeListCBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LoadDb)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadDb
            // 
            this.LoadDb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoadDb.Location = new System.Drawing.Point(310, 91);
            this.LoadDb.Name = "LoadDb";
            this.LoadDb.Size = new System.Drawing.Size(470, 361);
            this.LoadDb.TabIndex = 48;
            this.LoadDb.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LoadDb_CellClick);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(189)))), ((int)(((byte)(97)))));
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Nunito Medium", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBtn.Location = new System.Drawing.Point(94, 306);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(121, 42);
            this.AddBtn.TabIndex = 47;
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
            this.DeleteBtn.Location = new System.Drawing.Point(94, 410);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(121, 42);
            this.DeleteBtn.TabIndex = 46;
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
            this.UpdateBtn.Location = new System.Drawing.Point(94, 358);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(121, 42);
            this.UpdateBtn.TabIndex = 45;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(331, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 33);
            this.label7.TabIndex = 44;
            this.label7.Text = "ATTENDANCE";
            // 
            // AnnualLeaveBox
            // 
            this.AnnualLeaveBox.Font = new System.Drawing.Font("Nunito", 12F);
            this.AnnualLeaveBox.Location = new System.Drawing.Point(61, 157);
            this.AnnualLeaveBox.Multiline = true;
            this.AnnualLeaveBox.Name = "AnnualLeaveBox";
            this.AnnualLeaveBox.Size = new System.Drawing.Size(200, 34);
            this.AnnualLeaveBox.TabIndex = 43;
            this.AnnualLeaveBox.TextChanged += new System.EventHandler(this.AnnualLeaveBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nunito Medium", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 41;
            this.label4.Text = "Annual Leave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nunito Medium", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "Casual Leave";
            // 
            // CasualLeaveBox
            // 
            this.CasualLeaveBox.Font = new System.Drawing.Font("Nunito", 12F);
            this.CasualLeaveBox.Location = new System.Drawing.Point(61, 235);
            this.CasualLeaveBox.Multiline = true;
            this.CasualLeaveBox.Name = "CasualLeaveBox";
            this.CasualLeaveBox.Size = new System.Drawing.Size(200, 34);
            this.CasualLeaveBox.TabIndex = 43;
            this.CasualLeaveBox.TextChanged += new System.EventHandler(this.CasualLeaveBox_TextChanged);
            // 
            // EmployeeListCBox
            // 
            this.EmployeeListCBox.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeListCBox.FormattingEnabled = true;
            this.EmployeeListCBox.ItemHeight = 22;
            this.EmployeeListCBox.Location = new System.Drawing.Point(61, 82);
            this.EmployeeListCBox.Name = "EmployeeListCBox";
            this.EmployeeListCBox.Size = new System.Drawing.Size(200, 30);
            this.EmployeeListCBox.TabIndex = 50;
            this.EmployeeListCBox.SelectedIndexChanged += new System.EventHandler(this.EmployeeListCBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nunito Medium", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(58, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 18);
            this.label8.TabIndex = 49;
            this.label8.Text = "Employee Name";
            // 
            // FormAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 501);
            this.Controls.Add(this.EmployeeListCBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LoadDb);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CasualLeaveBox);
            this.Controls.Add(this.AnnualLeaveBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Name = "FormAttendance";
            this.Text = "FormAttendance";
            this.Load += new System.EventHandler(this.FormAttendance_Load);
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
        private System.Windows.Forms.TextBox AnnualLeaveBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CasualLeaveBox;
        private System.Windows.Forms.ComboBox EmployeeListCBox;
        private System.Windows.Forms.Label label8;
    }
}