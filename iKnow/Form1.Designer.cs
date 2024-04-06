namespace iKnow
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
            this.lbAllCourses = new System.Windows.Forms.ListBox();
            this.clbEnrolledCourses = new System.Windows.Forms.CheckedListBox();
            this.tbCourseName = new System.Windows.Forms.TextBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnMoveEnrolled = new System.Windows.Forms.Button();
            this.btnMoveBackAllCourses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAllCourses
            // 
            this.lbAllCourses.FormattingEnabled = true;
            this.lbAllCourses.ItemHeight = 20;
            this.lbAllCourses.Location = new System.Drawing.Point(201, 56);
            this.lbAllCourses.Name = "lbAllCourses";
            this.lbAllCourses.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbAllCourses.Size = new System.Drawing.Size(254, 344);
            this.lbAllCourses.TabIndex = 0;
            this.lbAllCourses.SelectedIndexChanged += new System.EventHandler(this.lbAllCourses_SelectedIndexChanged);
            // 
            // clbEnrolledCourses
            // 
            this.clbEnrolledCourses.FormattingEnabled = true;
            this.clbEnrolledCourses.Location = new System.Drawing.Point(723, 56);
            this.clbEnrolledCourses.Name = "clbEnrolledCourses";
            this.clbEnrolledCourses.Size = new System.Drawing.Size(254, 349);
            this.clbEnrolledCourses.TabIndex = 1;
            // 
            // tbCourseName
            // 
            this.tbCourseName.Location = new System.Drawing.Point(201, 424);
            this.tbCourseName.Name = "tbCourseName";
            this.tbCourseName.Size = new System.Drawing.Size(254, 26);
            this.tbCourseName.TabIndex = 2;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(201, 456);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(129, 30);
            this.btnAddCourse.TabIndex = 3;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnMoveEnrolled
            // 
            this.btnMoveEnrolled.Location = new System.Drawing.Point(551, 147);
            this.btnMoveEnrolled.Name = "btnMoveEnrolled";
            this.btnMoveEnrolled.Size = new System.Drawing.Size(91, 43);
            this.btnMoveEnrolled.TabIndex = 4;
            this.btnMoveEnrolled.Text = ">>";
            this.btnMoveEnrolled.UseVisualStyleBackColor = true;
            this.btnMoveEnrolled.Click += new System.EventHandler(this.btnMoveEnrolled_Click);
            // 
            // btnMoveBackAllCourses
            // 
            this.btnMoveBackAllCourses.Location = new System.Drawing.Point(551, 218);
            this.btnMoveBackAllCourses.Name = "btnMoveBackAllCourses";
            this.btnMoveBackAllCourses.Size = new System.Drawing.Size(91, 44);
            this.btnMoveBackAllCourses.TabIndex = 5;
            this.btnMoveBackAllCourses.Text = "<<";
            this.btnMoveBackAllCourses.UseVisualStyleBackColor = true;
            this.btnMoveBackAllCourses.Click += new System.EventHandler(this.btnMoveBackAllCourses_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 498);
            this.Controls.Add(this.btnMoveBackAllCourses);
            this.Controls.Add(this.btnMoveEnrolled);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.tbCourseName);
            this.Controls.Add(this.clbEnrolledCourses);
            this.Controls.Add(this.lbAllCourses);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAllCourses;
        private System.Windows.Forms.CheckedListBox clbEnrolledCourses;
        private System.Windows.Forms.TextBox tbCourseName;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnMoveEnrolled;
        private System.Windows.Forms.Button btnMoveBackAllCourses;
    }
}

