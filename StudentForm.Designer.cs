namespace Unicom_Tic_Management_System
{
    partial class StudentForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbCourse = new System.Windows.Forms.Label();
            this.txName = new System.Windows.Forms.TextBox();
            this.txAddress = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.StudentGV = new System.Windows.Forms.DataGridView();
            this.lbStudentform = new System.Windows.Forms.Label();
            this.ComCourse = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(221, 284);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(263, 86);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(44, 16);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(263, 134);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(58, 16);
            this.lbAddress.TabIndex = 2;
            this.lbAddress.Text = "Address";
            // 
            // lbCourse
            // 
            this.lbCourse.AutoSize = true;
            this.lbCourse.Location = new System.Drawing.Point(263, 178);
            this.lbCourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCourse.Name = "lbCourse";
            this.lbCourse.Size = new System.Drawing.Size(50, 16);
            this.lbCourse.TabIndex = 3;
            this.lbCourse.Text = "Course";
            this.lbCourse.Click += new System.EventHandler(this.lbCourse_Click);
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(392, 80);
            this.txName.Margin = new System.Windows.Forms.Padding(4);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(228, 22);
            this.txName.TabIndex = 5;
            this.txName.TextChanged += new System.EventHandler(this.txName_TextChanged);
            // 
            // txAddress
            // 
            this.txAddress.Location = new System.Drawing.Point(392, 128);
            this.txAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txAddress.Name = "txAddress";
            this.txAddress.Size = new System.Drawing.Size(228, 22);
            this.txAddress.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(392, 284);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(559, 284);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // StudentGV
            // 
            this.StudentGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGV.Location = new System.Drawing.Point(137, 339);
            this.StudentGV.Margin = new System.Windows.Forms.Padding(4);
            this.StudentGV.Name = "StudentGV";
            this.StudentGV.Size = new System.Drawing.Size(664, 202);
            this.StudentGV.TabIndex = 10;
            this.StudentGV.SelectionChanged += new System.EventHandler(this.StudentGV_CellContentClick);
            // 
            // lbStudentform
            // 
            this.lbStudentform.AutoSize = true;
            this.lbStudentform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentform.Location = new System.Drawing.Point(421, 22);
            this.lbStudentform.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStudentform.Name = "lbStudentform";
            this.lbStudentform.Size = new System.Drawing.Size(119, 20);
            this.lbStudentform.TabIndex = 11;
            this.lbStudentform.Text = "Student Form";
            // 
            // ComCourse
            // 
            this.ComCourse.FormattingEnabled = true;
            this.ComCourse.Location = new System.Drawing.Point(392, 178);
            this.ComCourse.Margin = new System.Windows.Forms.Padding(4);
            this.ComCourse.Name = "ComCourse";
            this.ComCourse.Size = new System.Drawing.Size(228, 24);
            this.ComCourse.TabIndex = 14;
            this.ComCourse.SelectedIndexChanged += new System.EventHandler(this.ComCourse_SelectedIndexChanged);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ComCourse);
            this.Controls.Add(this.lbStudentform);
            this.Controls.Add(this.StudentGV);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txAddress);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.lbCourse);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbCourse;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.TextBox txAddress;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView StudentGV;
        private System.Windows.Forms.Label lbStudentform;
        private System.Windows.Forms.ComboBox ComCourse;
    }
}