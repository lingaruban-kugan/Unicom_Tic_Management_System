﻿namespace Unicom_Tic_Management_System
{
    partial class TimetableForm
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
            this.Timetanlegv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txSubject = new System.Windows.Forms.TextBox();
            this.txTime = new System.Windows.Forms.TextBox();
            this.txRoom = new System.Windows.Forms.TextBox();
            this.butADD = new System.Windows.Forms.Button();
            this.butUPDATE = new System.Windows.Forms.Button();
            this.butDELETE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Timetanlegv)).BeginInit();
            this.SuspendLayout();
            // 
            // Timetanlegv
            // 
            this.Timetanlegv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Timetanlegv.Location = new System.Drawing.Point(184, 246);
            this.Timetanlegv.Name = "Timetanlegv";
            this.Timetanlegv.Size = new System.Drawing.Size(401, 150);
            this.Timetanlegv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "TimeTable";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subject";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(229, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Room";
            // 
            // txSubject
            // 
            this.txSubject.Location = new System.Drawing.Point(323, 66);
            this.txSubject.Name = "txSubject";
            this.txSubject.Size = new System.Drawing.Size(142, 20);
            this.txSubject.TabIndex = 5;
            // 
            // txTime
            // 
            this.txTime.Location = new System.Drawing.Point(323, 101);
            this.txTime.Name = "txTime";
            this.txTime.Size = new System.Drawing.Size(142, 20);
            this.txTime.TabIndex = 6;
            // 
            // txRoom
            // 
            this.txRoom.Location = new System.Drawing.Point(323, 140);
            this.txRoom.Name = "txRoom";
            this.txRoom.Size = new System.Drawing.Size(142, 20);
            this.txRoom.TabIndex = 7;
            // 
            // butADD
            // 
            this.butADD.Location = new System.Drawing.Point(220, 196);
            this.butADD.Name = "butADD";
            this.butADD.Size = new System.Drawing.Size(75, 23);
            this.butADD.TabIndex = 8;
            this.butADD.Text = "ADD";
            this.butADD.UseVisualStyleBackColor = true;
            // 
            // butUPDATE
            // 
            this.butUPDATE.Location = new System.Drawing.Point(331, 196);
            this.butUPDATE.Name = "butUPDATE";
            this.butUPDATE.Size = new System.Drawing.Size(75, 23);
            this.butUPDATE.TabIndex = 9;
            this.butUPDATE.Text = "UPDATE";
            this.butUPDATE.UseVisualStyleBackColor = true;
            // 
            // butDELETE
            // 
            this.butDELETE.Location = new System.Drawing.Point(433, 196);
            this.butDELETE.Name = "butDELETE";
            this.butDELETE.Size = new System.Drawing.Size(75, 23);
            this.butDELETE.TabIndex = 10;
            this.butDELETE.Text = "DELETE";
            this.butDELETE.UseVisualStyleBackColor = true;
            // 
            // TimetableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butDELETE);
            this.Controls.Add(this.butUPDATE);
            this.Controls.Add(this.butADD);
            this.Controls.Add(this.txRoom);
            this.Controls.Add(this.txTime);
            this.Controls.Add(this.txSubject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Timetanlegv);
            this.Name = "TimetableForm";
            this.Text = "TimetableForm";
            ((System.ComponentModel.ISupportInitialize)(this.Timetanlegv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Timetanlegv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txSubject;
        private System.Windows.Forms.TextBox txTime;
        private System.Windows.Forms.TextBox txRoom;
        private System.Windows.Forms.Button butADD;
        private System.Windows.Forms.Button butUPDATE;
        private System.Windows.Forms.Button butDELETE;
    }
}