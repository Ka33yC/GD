
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
            this.loadTextFromFileButton.Location = new System.Drawing.Point(27, 347);
            this.loadTextFromFileButton.Name = "loadTextFromFileButton";
            this.loadTextFromFileButton.Size = new System.Drawing.Size(160, 63);
            this.loadTextFromFileButton.TabIndex = 0;
            this.loadTextFromFileButton.Text = "Загрузить текст из файла";
            this.loadTextFromFileButton.UseVisualStyleBackColor = true;
            this.loadTextFromFileButton.Click += new System.EventHandler(this.LoadTextFromFileButton_Click);
            // 
            // sourseTextBox
            // 
            this.sourseTextBox.Location = new System.Drawing.Point(27, 44);
            this.sourseTextBox.Name = "sourseTextBox";
            this.sourseTextBox.Size = new System.Drawing.Size(334, 233);
            this.sourseTextBox.TabIndex = 1;
            this.sourseTextBox.Text = "";
            // 
            // labelSourse
            // 
            this.labelSourse.AutoSize = true;
            this.labelSourse.Location = new System.Drawing.Point(146, 9);
            this.labelSourse.Name = "labelSourse";
            this.labelSourse.Size = new System.Drawing.Size(118, 20);
            this.labelSourse.TabIndex = 2;
            this.labelSourse.Text = "Исходный текст";
            // 
            // uniqueTextBox
            // 
            this.uniqueTextBox.Location = new System.Drawing.Point(439, 44);
            this.uniqueTextBox.Name = "uniqueTextBox";
            this.uniqueTextBox.ReadOnly = true;
            this.uniqueTextBox.Size = new System.Drawing.Size(334, 233);
            this.uniqueTextBox.TabIndex = 3;
            this.uniqueTextBox.Text = "";
            // 
            // labelUnique
            // 
            this.labelUnique.AutoSize = true;
            this.labelUnique.Location = new System.Drawing.Point(537, 9);
            this.labelUnique.Name = "labelUnique";
            this.labelUnique.Size = new System.Drawing.Size(156, 20);
            this.labelUnique.TabIndex = 4;
            this.labelUnique.Text = "Уникальные e-mail\'ы";
            // 
            // findUniqueMailsButton
            // 
            this.findUniqueMailsButton.Location = new System.Drawing.Point(199, 347);
            this.findUniqueMailsButton.Name = "findUniqueMailsButton";
            this.findUniqueMailsButton.Size = new System.Drawing.Size(162, 63);
            this.findUniqueMailsButton.TabIndex = 6;
            this.findUniqueMailsButton.Text = "Найти все уникальные e-mail\'ы";
            this.findUniqueMailsButton.UseVisualStyleBackColor = true;
            this.findUniqueMailsButton.Click += new System.EventHandler(this.FindUniqueMailsButton_Click);
            // 
            // saveMailsToFileButton
            // 
            this.saveMailsToFileButton.Location = new System.Drawing.Point(537, 347);
            this.saveMailsToFileButton.Name = "saveMailsToFileButton";
            this.saveMailsToFileButton.Size = new System.Drawing.Size(152, 63);
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
            this.numbersOfSourseMailsLabel.Location = new System.Drawing.Point(27, 307);
            this.numbersOfSourseMailsLabel.Name = "numbersOfSourseMailsLabel";
            this.numbersOfSourseMailsLabel.Size = new System.Drawing.Size(160, 20);
            this.numbersOfSourseMailsLabel.TabIndex = 9;
            this.numbersOfSourseMailsLabel.Text = "Количество e-mail\'ов:";
            // 
            // numbersOfUniqueMailsLabel
            // 
            this.numbersOfUniqueMailsLabel.AutoSize = true;
            this.numbersOfUniqueMailsLabel.Location = new System.Drawing.Point(439, 307);
            this.numbersOfUniqueMailsLabel.Name = "numbersOfUniqueMailsLabel";
            this.numbersOfUniqueMailsLabel.Size = new System.Drawing.Size(160, 20);
            this.numbersOfUniqueMailsLabel.TabIndex = 10;
            this.numbersOfUniqueMailsLabel.Text = "Количество e-mail\'ов:";
            // 
            // domainsTemplateTextBox
            // 
            this.domainsTemplateTextBox.Location = new System.Drawing.Point(102, 437);
            this.domainsTemplateTextBox.Name = "domainsTemplateTextBox";
            this.domainsTemplateTextBox.PlaceholderText = "@gmail.com, @mail.ru";
            this.domainsTemplateTextBox.Size = new System.Drawing.Size(153, 27);
            this.domainsTemplateTextBox.TabIndex = 11;
            // 
            // setSampleButton
            // 
            this.setSampleButton.Location = new System.Drawing.Point(261, 431);
            this.setSampleButton.Name = "setSampleButton";
            this.setSampleButton.Size = new System.Drawing.Size(101, 41);
            this.setSampleButton.TabIndex = 12;
            this.setSampleButton.Text = "Применить";
            this.setSampleButton.UseVisualStyleBackColor = true;
            this.setSampleButton.Click += new System.EventHandler(this.SetSampleButton_Click);
            // 
            // SampleLabel
            // 
            this.SampleLabel.AutoSize = true;
            this.SampleLabel.Location = new System.Drawing.Point(27, 441);
            this.SampleLabel.Name = "SampleLabel";
            this.SampleLabel.Size = new System.Drawing.Size(69, 20);
            this.SampleLabel.TabIndex = 13;
            this.SampleLabel.Text = "Шаблон:";
            // 
            // resetSampleButton
            // 
            this.resetSampleButton.Location = new System.Drawing.Point(368, 431);
            this.resetSampleButton.Name = "resetSampleButton";
            this.resetSampleButton.Size = new System.Drawing.Size(101, 41);
            this.resetSampleButton.TabIndex = 14;
            this.resetSampleButton.Text = "Сбросить";
            this.resetSampleButton.UseVisualStyleBackColor = true;
            this.resetSampleButton.Click += new System.EventHandler(this.resetSampleButton_Click);
            // 
            // saveEmailsToFile
            // 
            this.saveEmailsToFile.Filter = "Txt Files(*.txt)|*.txt";
            this.saveEmailsToFile.ShowHelp = true;
            this.saveEmailsToFile.Title = "Сохранить текст как.";
            // 
            // FindMailsInTheTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
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
            this.Name = "FindMailsInTheTextForm";
            this.Text = "FindMailsInTheText";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.FindMailsInTheTextForm_Load);
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

