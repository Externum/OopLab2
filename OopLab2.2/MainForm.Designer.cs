namespace OopLab2._2
{
    partial class MainForm
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
            this.StudentMenuButton = new System.Windows.Forms.Button();
            this.TeacherMenuButton = new System.Windows.Forms.Button();
            this.GroupMenuButton = new System.Windows.Forms.Button();
            this.SubjectMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentMenuButton
            // 
            this.StudentMenuButton.Location = new System.Drawing.Point(12, 12);
            this.StudentMenuButton.Name = "StudentMenuButton";
            this.StudentMenuButton.Size = new System.Drawing.Size(392, 44);
            this.StudentMenuButton.TabIndex = 0;
            this.StudentMenuButton.Text = "Студент";
            this.StudentMenuButton.UseVisualStyleBackColor = true;
            this.StudentMenuButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TeacherMenuButton
            // 
            this.TeacherMenuButton.Location = new System.Drawing.Point(12, 62);
            this.TeacherMenuButton.Name = "TeacherMenuButton";
            this.TeacherMenuButton.Size = new System.Drawing.Size(392, 42);
            this.TeacherMenuButton.TabIndex = 1;
            this.TeacherMenuButton.Text = "Учитель";
            this.TeacherMenuButton.UseVisualStyleBackColor = true;
            // 
            // GroupMenuButton
            // 
            this.GroupMenuButton.Location = new System.Drawing.Point(12, 110);
            this.GroupMenuButton.Name = "GroupMenuButton";
            this.GroupMenuButton.Size = new System.Drawing.Size(392, 45);
            this.GroupMenuButton.TabIndex = 2;
            this.GroupMenuButton.Text = "Группа";
            this.GroupMenuButton.UseVisualStyleBackColor = true;
            // 
            // SubjectMenuButton
            // 
            this.SubjectMenuButton.Location = new System.Drawing.Point(12, 161);
            this.SubjectMenuButton.Name = "SubjectMenuButton";
            this.SubjectMenuButton.Size = new System.Drawing.Size(392, 46);
            this.SubjectMenuButton.TabIndex = 3;
            this.SubjectMenuButton.Text = "Предмет";
            this.SubjectMenuButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 225);
            this.Controls.Add(this.SubjectMenuButton);
            this.Controls.Add(this.GroupMenuButton);
            this.Controls.Add(this.TeacherMenuButton);
            this.Controls.Add(this.StudentMenuButton);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StudentMenuButton;
        private System.Windows.Forms.Button TeacherMenuButton;
        private System.Windows.Forms.Button GroupMenuButton;
        private System.Windows.Forms.Button SubjectMenuButton;
    }
}