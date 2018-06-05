namespace OopLab2._2
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
            this.CreateStudentButton = new System.Windows.Forms.Button();
            this.DeleteStudentButton = new System.Windows.Forms.Button();
            this.StudentLastNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.StudentsListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultsListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateStudentButton
            // 
            this.CreateStudentButton.Location = new System.Drawing.Point(12, 439);
            this.CreateStudentButton.Name = "CreateStudentButton";
            this.CreateStudentButton.Size = new System.Drawing.Size(138, 59);
            this.CreateStudentButton.TabIndex = 0;
            this.CreateStudentButton.Text = "Создать студента";
            this.CreateStudentButton.UseVisualStyleBackColor = true;
            // 
            // DeleteStudentButton
            // 
            this.DeleteStudentButton.Location = new System.Drawing.Point(185, 439);
            this.DeleteStudentButton.Name = "DeleteStudentButton";
            this.DeleteStudentButton.Size = new System.Drawing.Size(156, 59);
            this.DeleteStudentButton.TabIndex = 1;
            this.DeleteStudentButton.Text = "Удалить студента";
            this.DeleteStudentButton.UseVisualStyleBackColor = true;
            // 
            // StudentLastNameTextBox
            // 
            this.StudentLastNameTextBox.Location = new System.Drawing.Point(12, 536);
            this.StudentLastNameTextBox.Name = "StudentLastNameTextBox";
            this.StudentLastNameTextBox.Size = new System.Drawing.Size(138, 20);
            this.StudentLastNameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 517);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 517);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя";
            // 
            // StudentFirstNameTextBox
            // 
            this.StudentFirstNameTextBox.Location = new System.Drawing.Point(185, 536);
            this.StudentFirstNameTextBox.Name = "StudentFirstNameTextBox";
            this.StudentFirstNameTextBox.Size = new System.Drawing.Size(156, 20);
            this.StudentFirstNameTextBox.TabIndex = 5;
            // 
            // StudentsListBox
            // 
            this.StudentsListBox.FormattingEnabled = true;
            this.StudentsListBox.Location = new System.Drawing.Point(16, 38);
            this.StudentsListBox.Name = "StudentsListBox";
            this.StudentsListBox.Size = new System.Drawing.Size(325, 381);
            this.StudentsListBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Список студентов";
            // 
            // ResultsListBox
            // 
            this.ResultsListBox.FormattingEnabled = true;
            this.ResultsListBox.Location = new System.Drawing.Point(375, 38);
            this.ResultsListBox.Name = "ResultsListBox";
            this.ResultsListBox.Size = new System.Drawing.Size(351, 381);
            this.ResultsListBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Результаты экзаменов";
            // 
            // StudentForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(759, 568);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ResultsListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StudentsListBox);
            this.Controls.Add(this.StudentFirstNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentLastNameTextBox);
            this.Controls.Add(this.DeleteStudentButton);
            this.Controls.Add(this.CreateStudentButton);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateStudentButton;
        private System.Windows.Forms.Button DeleteStudentButton;
        private System.Windows.Forms.TextBox StudentLastNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StudentFirstNameTextBox;
        private System.Windows.Forms.ListBox StudentsListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ResultsListBox;
        private System.Windows.Forms.Label label4;
    }
}