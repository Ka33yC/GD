
namespace GD
{
	partial class FindMailsInTheTextForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.loadTextFromFileButton = new System.Windows.Forms.Button();
			this.sourseTextBox = new System.Windows.Forms.RichTextBox();
			this.labelSourse = new System.Windows.Forms.Label();
			this.uniqueTextBox = new System.Windows.Forms.RichTextBox();
			this.labelUnique = new System.Windows.Forms.Label();
			this.findUniqueMailsButton = new System.Windows.Forms.Button();
			this.saveMailsToFileButton = new System.Windows.Forms.Button();
			this.openFileWithEmail = new System.Windows.Forms.OpenFileDialog();
			this.numbersOfSourseMailsLabel = new System.Windows.Forms.Label();
			this.numbersOfUniqueMailsLabel = new System.Windows.Forms.Label();
			this.domainsTemplateTextBox = new System.Windows.Forms.TextBox();
			this.setSampleButton = new System.Windows.Forms.Button();
			this.SampleLabel = new System.Windows.Forms.Label();
			this.resetSampleButton = new System.Windows.Forms.Button();
			this.saveEmailsToFile = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// loadTextFromFileButton
			// 
			this.loadTextFromFileButton.Location = new System.Drawing.Point(24, 260);
			this.loadTextFromFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.loadTextFromFileButton.Name = "loadTextFromFileButton";
			this.loadTextFromFileButton.Size = new System.Drawing.Size(133, 47);
			this.loadTextFromFileButton.TabIndex = 0;
			this.loadTextFromFileButton.Text = "Загрузить текст из файла";
			this.loadTextFromFileButton.UseVisualStyleBackColor = true;
			this.loadTextFromFileButton.Click += new System.EventHandler(this.LoadTextFromFileButton_Click);
			// 
			// sourseTextBox
			// 
			this.sourseTextBox.Location = new System.Drawing.Point(24, 33);
			this.sourseTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.sourseTextBox.Name = "sourseTextBox";
			this.sourseTextBox.Size = new System.Drawing.Size(293, 176);
			this.sourseTextBox.TabIndex = 1;
			this.sourseTextBox.Text = "";
			// 
			// labelSourse
			// 
			this.labelSourse.AutoSize = true;
			this.labelSourse.Location = new System.Drawing.Point(128, 7);
			this.labelSourse.Name = "labelSourse";
			this.labelSourse.Size = new System.Drawing.Size(95, 15);
			this.labelSourse.TabIndex = 2;
			this.labelSourse.Text = "Исходный текст";
			// 
			// uniqueTextBox
			// 
			this.uniqueTextBox.Location = new System.Drawing.Point(384, 33);
			this.uniqueTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.uniqueTextBox.Name = "uniqueTextBox";
			this.uniqueTextBox.ReadOnly = true;
			this.uniqueTextBox.Size = new System.Drawing.Size(293, 176);
			this.uniqueTextBox.TabIndex = 3;
			this.uniqueTextBox.Text = "";
			// 
			// labelUnique
			// 
			this.labelUnique.AutoSize = true;
			this.labelUnique.Location = new System.Drawing.Point(470, 7);
			this.labelUnique.Name = "labelUnique";
			this.labelUnique.Size = new System.Drawing.Size(124, 15);
			this.labelUnique.TabIndex = 4;
			this.labelUnique.Text = "Уникальные e-mail\'ы";
			// 
			// findUniqueMailsButton
			// 
			this.findUniqueMailsButton.Location = new System.Drawing.Point(183, 260);
			this.findUniqueMailsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.findUniqueMailsButton.Name = "findUniqueMailsButton";
			this.findUniqueMailsButton.Size = new System.Drawing.Size(133, 47);
			this.findUniqueMailsButton.TabIndex = 6;
			this.findUniqueMailsButton.Text = "Найти уникальные e-mail\'ы";
			this.findUniqueMailsButton.UseVisualStyleBackColor = true;
			this.findUniqueMailsButton.Click += new System.EventHandler(this.FindUniqueMailsButton_Click);
			// 
			// saveMailsToFileButton
			// 
			this.saveMailsToFileButton.Location = new System.Drawing.Point(470, 260);
			this.saveMailsToFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.saveMailsToFileButton.Name = "saveMailsToFileButton";
			this.saveMailsToFileButton.Size = new System.Drawing.Size(133, 47);
			this.saveMailsToFileButton.TabIndex = 7;
			this.saveMailsToFileButton.Text = "Сохранить e-mail\'ы в файл\r\n";
			this.saveMailsToFileButton.UseVisualStyleBackColor = true;
			this.saveMailsToFileButton.Click += new System.EventHandler(this.SaveMailsToFileButton_Click);
			// 
			// openFileWithEmail
			// 
			this.openFileWithEmail.FileName = "email.txt";
			this.openFileWithEmail.Filter = "txt files (*.txt)|*.txt*";
			// 
			// numbersOfSourseMailsLabel
			// 
			this.numbersOfSourseMailsLabel.AutoSize = true;
			this.numbersOfSourseMailsLabel.Location = new System.Drawing.Point(24, 230);
			this.numbersOfSourseMailsLabel.Name = "numbersOfSourseMailsLabel";
			this.numbersOfSourseMailsLabel.Size = new System.Drawing.Size(128, 15);
			this.numbersOfSourseMailsLabel.TabIndex = 9;
			this.numbersOfSourseMailsLabel.Text = "Количество e-mail\'ов:";
			// 
			// numbersOfUniqueMailsLabel
			// 
			this.numbersOfUniqueMailsLabel.AutoSize = true;
			this.numbersOfUniqueMailsLabel.Location = new System.Drawing.Point(384, 230);
			this.numbersOfUniqueMailsLabel.Name = "numbersOfUniqueMailsLabel";
			this.numbersOfUniqueMailsLabel.Size = new System.Drawing.Size(128, 15);
			this.numbersOfUniqueMailsLabel.TabIndex = 10;
			this.numbersOfUniqueMailsLabel.Text = "Количество e-mail\'ов:";
			// 
			// domainsTemplateTextBox
			// 
			this.domainsTemplateTextBox.Location = new System.Drawing.Point(89, 328);
			this.domainsTemplateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.domainsTemplateTextBox.Name = "domainsTemplateTextBox";
			this.domainsTemplateTextBox.PlaceholderText = "@gmail.com, @mail.ru";
			this.domainsTemplateTextBox.Size = new System.Drawing.Size(134, 23);
			this.domainsTemplateTextBox.TabIndex = 11;
			// 
			// setSampleButton
			// 
			this.setSampleButton.Location = new System.Drawing.Point(228, 323);
			this.setSampleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.setSampleButton.Name = "setSampleButton";
			this.setSampleButton.Size = new System.Drawing.Size(88, 31);
			this.setSampleButton.TabIndex = 12;
			this.setSampleButton.Text = "Применить";
			this.setSampleButton.UseVisualStyleBackColor = true;
			this.setSampleButton.Click += new System.EventHandler(this.SetSampleButton_Click);
			// 
			// SampleLabel
			// 
			this.SampleLabel.AutoSize = true;
			this.SampleLabel.Location = new System.Drawing.Point(24, 331);
			this.SampleLabel.Name = "SampleLabel";
			this.SampleLabel.Size = new System.Drawing.Size(55, 15);
			this.SampleLabel.TabIndex = 13;
			this.SampleLabel.Text = "Шаблон:";
			// 
			// resetSampleButton
			// 
			this.resetSampleButton.Location = new System.Drawing.Point(322, 323);
			this.resetSampleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.resetSampleButton.Name = "resetSampleButton";
			this.resetSampleButton.Size = new System.Drawing.Size(88, 31);
			this.resetSampleButton.TabIndex = 14;
			this.resetSampleButton.Text = "Сбросить";
			this.resetSampleButton.UseVisualStyleBackColor = true;
			// 
			// saveEmailsToFile
			// 
			this.saveEmailsToFile.Filter = "Txt Files(*.txt)|*.txt";
			this.saveEmailsToFile.ShowHelp = true;
			this.saveEmailsToFile.Title = "Сохранить текст как.";
			// 
			// FindMailsInTheTextForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 372);
			this.Controls.Add(this.resetSampleButton);
			this.Controls.Add(this.SampleLabel);
			this.Controls.Add(this.setSampleButton);
			this.Controls.Add(this.domainsTemplateTextBox);
			this.Controls.Add(this.numbersOfUniqueMailsLabel);
			this.Controls.Add(this.numbersOfSourseMailsLabel);
			this.Controls.Add(this.saveMailsToFileButton);
			this.Controls.Add(this.findUniqueMailsButton);
			this.Controls.Add(this.labelUnique);
			this.Controls.Add(this.uniqueTextBox);
			this.Controls.Add(this.labelSourse);
			this.Controls.Add(this.sourseTextBox);
			this.Controls.Add(this.loadTextFromFileButton);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FindMailsInTheTextForm";
			this.Text = "FindMailsInTheText";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Button loadTextFromFileButton;
        private System.Windows.Forms.RichTextBox sourseTextBox;
        private System.Windows.Forms.Label labelSourse;
        private System.Windows.Forms.RichTextBox uniqueTextBox;
        private System.Windows.Forms.Label labelUnique;
        private System.Windows.Forms.Button findUniqueMailsButton;
        private System.Windows.Forms.Button saveMailsToFileButton;
        private System.Windows.Forms.OpenFileDialog openFileWithEmail;
        private System.Windows.Forms.Label numbersOfSourseMailsLabel;
        private System.Windows.Forms.Label numbersOfUniqueMailsLabel;
        private System.Windows.Forms.TextBox domainsTemplateTextBox;
        private System.Windows.Forms.Button setSampleButton;
        private System.Windows.Forms.Label SampleLabel;
        private System.Windows.Forms.Button resetSampleButton;
		private System.Windows.Forms.SaveFileDialog saveEmailsToFile;
	}
}

