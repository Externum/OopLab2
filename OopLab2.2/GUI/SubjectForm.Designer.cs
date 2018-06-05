namespace OopLab2._2
{
    partial class SubjectForm
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
            this.SubjectListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TeacherListBox = new System.Windows.Forms.ListBox();
            this.CreateSubjectButton = new System.Windows.Forms.Button();
            this.DeleteSubjectButton = new System.Windows.Forms.Button();
            this.AddTecherToSubjectButton = new System.Windows.Forms.Button();
            this.DeleteTeacherFromSubjectButton = new System.Windows.Forms.Button();
            this.SubjectNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SubjectListBox
            // 
            this.SubjectListBox.FormattingEnabled = true;
            this.SubjectListBox.Location = new System.Drawing.Point(13, 34);
            this.SubjectListBox.Name = "SubjectListBox";
            this.SubjectListBox.Size = new System.Drawing.Size(225, 290);
            this.SubjectListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список предметов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Список учителей";
            // 
            // TeacherListBox
            // 
            this.TeacherListBox.FormattingEnabled = true;
            this.TeacherListBox.Location = new System.Drawing.Point(274, 34);
            this.TeacherListBox.Name = "TeacherListBox";
            this.TeacherListBox.Size = new System.Drawing.Size(325, 290);
            this.TeacherListBox.TabIndex = 3;
            // 
            // CreateSubjectButton
            // 
            this.CreateSubjectButton.Location = new System.Drawing.Point(13, 330);
            this.CreateSubjectButton.Name = "CreateSubjectButton";
            this.CreateSubjectButton.Size = new System.Drawing.Size(109, 48);
            this.CreateSubjectButton.TabIndex = 4;
            this.CreateSubjectButton.Text = "Создать Предмет";
            this.CreateSubjectButton.UseVisualStyleBackColor = true;
            // 
            // DeleteSubjectButton
            // 
            this.DeleteSubjectButton.Location = new System.Drawing.Point(128, 330);
            this.DeleteSubjectButton.Name = "DeleteSubjectButton";
            this.DeleteSubjectButton.Size = new System.Drawing.Size(110, 48);
            this.DeleteSubjectButton.TabIndex = 5;
            this.DeleteSubjectButton.Text = "Удалить Предмет";
            this.DeleteSubjectButton.UseVisualStyleBackColor = true;
            // 
            // AddTecherToSubjectButton
            // 
            this.AddTecherToSubjectButton.Location = new System.Drawing.Point(274, 330);
            this.AddTecherToSubjectButton.Name = "AddTecherToSubjectButton";
            this.AddTecherToSubjectButton.Size = new System.Drawing.Size(155, 48);
            this.AddTecherToSubjectButton.TabIndex = 6;
            this.AddTecherToSubjectButton.Text = "Добавить Преподавателя";
            this.AddTecherToSubjectButton.UseVisualStyleBackColor = true;
            // 
            // DeleteTeacherFromSubjectButton
            // 
            this.DeleteTeacherFromSubjectButton.Location = new System.Drawing.Point(435, 330);
            this.DeleteTeacherFromSubjectButton.Name = "DeleteTeacherFromSubjectButton";
            this.DeleteTeacherFromSubjectButton.Size = new System.Drawing.Size(164, 48);
            this.DeleteTeacherFromSubjectButton.TabIndex = 7;
            this.DeleteTeacherFromSubjectButton.Text = "Удалить Преподавателя";
            this.DeleteTeacherFromSubjectButton.UseVisualStyleBackColor = true;
            // 
            // SubjectNameTextBox
            // 
            this.SubjectNameTextBox.Location = new System.Drawing.Point(10, 415);
            this.SubjectNameTextBox.Name = "SubjectNameTextBox";
            this.SubjectNameTextBox.Size = new System.Drawing.Size(224, 20);
            this.SubjectNameTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Название предмета";
            // 
            // SubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SubjectNameTextBox);
            this.Controls.Add(this.DeleteTeacherFromSubjectButton);
            this.Controls.Add(this.AddTecherToSubjectButton);
            this.Controls.Add(this.DeleteSubjectButton);
            this.Controls.Add(this.CreateSubjectButton);
            this.Controls.Add(this.TeacherListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubjectListBox);
            this.Name = "SubjectForm";
            this.Text = "SubjectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox SubjectListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox TeacherListBox;
        private System.Windows.Forms.Button CreateSubjectButton;
        private System.Windows.Forms.Button DeleteSubjectButton;
        private System.Windows.Forms.Button AddTecherToSubjectButton;
        private System.Windows.Forms.Button DeleteTeacherFromSubjectButton;
        private System.Windows.Forms.TextBox SubjectNameTextBox;
        private System.Windows.Forms.Label label3;
    }
}