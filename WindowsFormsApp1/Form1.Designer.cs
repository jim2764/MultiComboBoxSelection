namespace WindowsFormsApp1
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.studentVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.sidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.teacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnSearch = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.studentVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(0, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 450);
			this.splitter1.TabIndex = 1;
			this.splitter1.TabStop = false;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(41, 69);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 20);
			this.comboBox1.TabIndex = 2;
			// 
			// comboBox2
			// 
			this.comboBox2.DataSource = this.studentVMBindingSource;
			this.comboBox2.DisplayMember = "Teacher";
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(41, 115);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 20);
			this.comboBox2.TabIndex = 2;
			this.comboBox2.ValueMember = "Sid";
			// 
			// studentVMBindingSource
			// 
			this.studentVMBindingSource.DataSource = typeof(WindowsFormsApp1.Form1.StudentVM);
			// 
			// comboBox3
			// 
			this.comboBox3.DataSource = this.studentVMBindingSource;
			this.comboBox3.DisplayMember = "Grade";
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(41, 160);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(121, 20);
			this.comboBox3.TabIndex = 2;
			this.comboBox3.ValueMember = "Sid";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.teacherDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.studentVMBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(238, 69);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(445, 353);
			this.dataGridView1.TabIndex = 3;
			// 
			// sidDataGridViewTextBoxColumn
			// 
			this.sidDataGridViewTextBoxColumn.DataPropertyName = "Sid";
			this.sidDataGridViewTextBoxColumn.HeaderText = "Sid";
			this.sidDataGridViewTextBoxColumn.Name = "sidDataGridViewTextBoxColumn";
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// teacherDataGridViewTextBoxColumn
			// 
			this.teacherDataGridViewTextBoxColumn.DataPropertyName = "Teacher";
			this.teacherDataGridViewTextBoxColumn.HeaderText = "Teacher";
			this.teacherDataGridViewTextBoxColumn.Name = "teacherDataGridViewTextBoxColumn";
			// 
			// gradeDataGridViewTextBoxColumn
			// 
			this.gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
			this.gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
			this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(41, 225);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 4;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.splitter1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.studentVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn sidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn teacherDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource studentVMBindingSource;
		private System.Windows.Forms.Button btnSearch;
	}
}

