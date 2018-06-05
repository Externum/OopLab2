namespace OopLab2._2
{
    partial class GroupForm
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
            this.GroupListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SubjectListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ExamListBox = new System.Windows.Forms.ListBox();
            this.CreateGroupButton = new System.Windows.Forms.Button();
            this.DeleteGroupButton = new System.Windows.Forms.Button();
            this.AddStudentToGroupButton = new System.Windows.Forms.Button();
            this.RemoveStudentFromGroupButton = new System.Windows.Forms.Button();
            this.AddSubjectToGroupButton = new System.Windows.Forms.Button();
            this.AddExamToGroupButton = new System.Windows.Forms.Button();
            this.RemoveSubjectFromGroupButton = new System.Windows.Forms.Button();
            this.RemoveExamFromGroupButton = new System.Windows.Forms.Button();
            this.GroupNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GroupListBox
            // 
            this.GroupListBox.FormattingEnabled = true;
            this.GroupListBox.Location = new System.Drawing.Point(16, 29);
            this.GroupListBox.Name = "GroupListBox";
            this.GroupListBox.Size = new System.Drawing.Size(233, 290);
            this.GroupListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список групп";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Список студентов";
            // 
            // StudentListBox
            // 
            this.StudentListBox.FormattingEnabled = true;
            this.StudentListBox.Location = new System.Drawing.Point(273, 29);
            this.StudentListBox.Name = "StudentListBox";
            this.StudentListBox.Size = new System.Drawing.Size(266, 290);
            this.StudentListBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(562, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Список предметов";
            // 
            // SubjectListBox
            // 
            this.SubjectListBox.FormattingEnabled = true;
            this.SubjectListBox.Location = new System.Drawing.Point(565, 30);
            this.SubjectListBox.Name = "SubjectListBox";
            this.SubjectListBox.Size = new System.Drawing.Size(223, 121);
            this.SubjectListBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(562, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Список экзаменов";
            // 
            // ExamListBox
            // 
            this.ExamListBox.FormattingEnabled = true;
            this.ExamListBox.Location = new System.Drawing.Point(565, 184);
            this.ExamListBox.Name = "ExamListBox";
            this.ExamListBox.Size = new System.Drawing.Size(223, 134);
            this.ExamListBox.TabIndex = 7;
            // 
            // CreateGroupButton
            // 
            this.CreateGroupButton.Location = new System.Drawing.Point(16, 340);
            this.CreateGroupButton.Name = "CreateGroupButton";
            this.CreateGroupButton.Size = new System.Drawing.Size(120, 49);
            this.CreateGroupButton.TabIndex = 8;
            this.CreateGroupButton.Text = "Создать Группу";
            this.CreateGroupButton.UseVisualStyleBackColor = true;
            // 
            // DeleteGroupButton
            // 
            this.DeleteGroupButton.Location = new System.Drawing.Point(142, 340);
            this.DeleteGroupButton.Name = "DeleteGroupButton";
            this.DeleteGroupButton.Size = new System.Drawing.Size(107, 49);
            this.DeleteGroupButton.TabIndex = 9;
            this.DeleteGroupButton.Text = "Удалить Группу";
            this.DeleteGroupButton.UseVisualStyleBackColor = true;
            // 
            // AddStudentToGroupButton
            // 
            this.AddStudentToGroupButton.Location = new System.Drawing.Point(273, 340);
            this.AddStudentToGroupButton.Name = "AddStudentToGroupButton";
            this.AddStudentToGroupButton.Size = new System.Drawing.Size(128, 49);
            this.AddStudentToGroupButton.TabIndex = 10;
            this.AddStudentToGroupButton.Text = "Добавить Студента";
            this.AddStudentToGroupButton.UseVisualStyleBackColor = true;
            // 
            // RemoveStudentFromGroupButton
            // 
            this.RemoveStudentFromGroupButton.Location = new System.Drawing.Point(407, 340);
            this.RemoveStudentFromGroupButton.Name = "RemoveStudentFromGroupButton";
            this.RemoveStudentFromGroupButton.Size = new System.Drawing.Size(131, 49);
            this.RemoveStudentFromGroupButton.TabIndex = 11;
            this.RemoveStudentFromGroupButton.Text = "Удалить Студента";
            this.RemoveStudentFromGroupButton.UseVisualStyleBackColor = true;
            // 
            // AddSubjectToGroupButton
            // 
            this.AddSubjectToGroupButton.Location = new System.Drawing.Point(566, 340);
            this.AddSubjectToGroupButton.Name = "AddSubjectToGroupButton";
            this.AddSubjectToGroupButton.Size = new System.Drawing.Size(107, 49);
            this.AddSubjectToGroupButton.TabIndex = 12;
            this.AddSubjectToGroupButton.Text = "Добавить Предмет";
            this.AddSubjectToGroupButton.UseVisualStyleBackColor = true;
            // 
            // AddExamToGroupButton
            // 
            this.AddExamToGroupButton.Location = new System.Drawing.Point(679, 340);
            this.AddExamToGroupButton.Name = "AddExamToGroupButton";
            this.AddExamToGroupButton.Size = new System.Drawing.Size(108, 49);
            this.AddExamToGroupButton.TabIndex = 13;
            this.AddExamToGroupButton.Text = "Добавить Экзамен";
            this.AddExamToGroupButton.UseVisualStyleBackColor = true;
            // 
            // RemoveSubjectFromGroupButton
            // 
            this.RemoveSubjectFromGroupButton.Location = new System.Drawing.Point(565, 397);
            this.RemoveSubjectFromGroupButton.Name = "RemoveSubjectFromGroupButton";
            this.RemoveSubjectFromGroupButton.Size = new System.Drawing.Size(108, 49);
            this.RemoveSubjectFromGroupButton.TabIndex = 14;
            this.RemoveSubjectFromGroupButton.Text = "Удалить Предмет";
            this.RemoveSubjectFromGroupButton.UseVisualStyleBackColor = true;
            // 
            // RemoveExamFromGroupButton
            // 
            this.RemoveExamFromGroupButton.Location = new System.Drawing.Point(679, 395);
            this.RemoveExamFromGroupButton.Name = "RemoveExamFromGroupButton";
            this.RemoveExamFromGroupButton.Size = new System.Drawing.Size(108, 53);
            this.RemoveExamFromGroupButton.TabIndex = 15;
            this.RemoveExamFromGroupButton.Text = "Удалить Экзамен";
            this.RemoveExamFromGroupButton.UseVisualStyleBackColor = true;
            // 
            // GroupNameTextBox
            // 
            this.GroupNameTextBox.Location = new System.Drawing.Point(16, 418);
            this.GroupNameTextBox.Name = "GroupNameTextBox";
            this.GroupNameTextBox.Size = new System.Drawing.Size(233, 20);
            this.GroupNameTextBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Название группы";
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GroupNameTextBox);
            this.Controls.Add(this.RemoveExamFromGroupButton);
            this.Controls.Add(this.RemoveSubjectFromGroupButton);
            this.Controls.Add(this.AddExamToGroupButton);
            this.Controls.Add(this.AddSubjectToGroupButton);
            this.Controls.Add(this.RemoveStudentFromGroupButton);
            this.Controls.Add(this.AddStudentToGroupButton);
            this.Controls.Add(this.DeleteGroupButton);
            this.Controls.Add(this.CreateGroupButton);
            this.Controls.Add(this.ExamListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SubjectListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StudentListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroupListBox);
            this.Name = "GroupForm";
            this.Text = "GroupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox GroupListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox StudentListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox SubjectListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox ExamListBox;
        private System.Windows.Forms.Button CreateGroupButton;
        private System.Windows.Forms.Button DeleteGroupButton;
        private System.Windows.Forms.Button AddStudentToGroupButton;
        private System.Windows.Forms.Button RemoveStudentFromGroupButton;
        private System.Windows.Forms.Button AddSubjectToGroupButton;
        private System.Windows.Forms.Button AddExamToGroupButton;
        private System.Windows.Forms.Button RemoveSubjectFromGroupButton;
        private System.Windows.Forms.Button RemoveExamFromGroupButton;
        private System.Windows.Forms.TextBox GroupNameTextBox;
        private System.Windows.Forms.Label label5;
    }
}