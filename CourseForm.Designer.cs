namespace Unicom_Tic_Management_System
{
    partial class CourseForm
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
            this.lbCourseName = new System.Windows.Forms.Label();
            this.coursegv = new System.Windows.Forms.DataGridView();
            this.BtADD = new System.Windows.Forms.Button();
            this.BtDELETE = new System.Windows.Forms.Button();
            this.BtUPDATE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txCourseName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.coursegv)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCourseName
            // 
            this.lbCourseName.AutoSize = true;
            this.lbCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCourseName.Location = new System.Drawing.Point(217, 90);
            this.lbCourseName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCourseName.Name = "lbCourseName";
            this.lbCourseName.Size = new System.Drawing.Size(97, 16);
            this.lbCourseName.TabIndex = 0;
            this.lbCourseName.Text = "CourseName";
            // 
            // coursegv
            // 
            this.coursegv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coursegv.Location = new System.Drawing.Point(208, 227);
            this.coursegv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.coursegv.Name = "coursegv";
            this.coursegv.Size = new System.Drawing.Size(385, 162);
            this.coursegv.TabIndex = 4;
            this.coursegv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CourseGridView_CellContentClick);
            this.coursegv.SelectionChanged += new System.EventHandler(this.coursegv_SelectionChanged);
            // 
            // BtADD
            // 
            this.BtADD.Location = new System.Drawing.Point(220, 164);
            this.BtADD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtADD.Name = "BtADD";
            this.BtADD.Size = new System.Drawing.Size(88, 25);
            this.BtADD.TabIndex = 7;
            this.BtADD.Text = "ADD";
            this.BtADD.UseVisualStyleBackColor = true;
            this.BtADD.Click += new System.EventHandler(this.BtADD_Click);
            // 
            // BtDELETE
            // 
            this.BtDELETE.Location = new System.Drawing.Point(366, 164);
            this.BtDELETE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtDELETE.Name = "BtDELETE";
            this.BtDELETE.Size = new System.Drawing.Size(88, 25);
            this.BtDELETE.TabIndex = 8;
            this.BtDELETE.Text = "DELETE";
            this.BtDELETE.UseVisualStyleBackColor = true;
            this.BtDELETE.Click += new System.EventHandler(this.BtDELETE_Click);
            // 
            // BtUPDATE
            // 
            this.BtUPDATE.Location = new System.Drawing.Point(492, 164);
            this.BtUPDATE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtUPDATE.Name = "BtUPDATE";
            this.BtUPDATE.Size = new System.Drawing.Size(88, 25);
            this.BtUPDATE.TabIndex = 9;
            this.BtUPDATE.Text = "UPDATE";
            this.BtUPDATE.UseVisualStyleBackColor = true;
            this.BtUPDATE.Click += new System.EventHandler(this.BtUPDATE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Course Form";
            // 
            // txCourseName
            // 
            this.txCourseName.Location = new System.Drawing.Point(366, 87);
            this.txCourseName.Name = "txCourseName";
            this.txCourseName.Size = new System.Drawing.Size(190, 19);
            this.txCourseName.TabIndex = 11;
            this.txCourseName.TextChanged += new System.EventHandler(this.txCourseName_TextChanged);
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 485);
            this.Controls.Add(this.txCourseName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtUPDATE);
            this.Controls.Add(this.BtDELETE);
            this.Controls.Add(this.BtADD);
            this.Controls.Add(this.coursegv);
            this.Controls.Add(this.lbCourseName);
            this.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coursegv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCourseName;
        private System.Windows.Forms.DataGridView coursegv;
        private System.Windows.Forms.Button BtADD;
        private System.Windows.Forms.Button BtDELETE;
        private System.Windows.Forms.Button BtUPDATE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txCourseName;
    }
}