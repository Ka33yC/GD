
namespace GD
{
	partial class FindMailsInTheText
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
			this.LoadTextFromFileButton = new System.Windows.Forms.Button();
			this.SourseTextBox = new System.Windows.Forms.RichTextBox();
			this.labelSourse = new System.Windows.Forms.Label();
			this.UniqueTextBox = new System.Windows.Forms.RichTextBox();
			this.labelUnique = new System.Windows.Forms.Label();
			this.FindUniqueMailsButton = new System.Windows.Forms.Button();
			this.SaveMailsToFileButton = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.NumbersOfSourseMailsLabel = new System.Windows.Forms.Label();
			this.NumbersOfUniqueMailsLabel = new System.Windows.Forms.Label();
			this.SampleTextBox = new System.Windows.Forms.TextBox();
			this.SetSampleButton = new System.Windows.Forms.Button();
			this.SampleLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// LoadTextFromFileButton
			// 
			this.LoadTextFromFileButton.Location = new System.Drawing.Point(24, 260);
			this.LoadTextFromFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.LoadTextFromFileButton.Name = "LoadTextFromFileButton";
			this.LoadTextFromFileButton.Size = new System.Drawing.Size(133, 47);
			this.LoadTextFromFileButton.TabIndex = 0;
			this.LoadTextFromFileButton.Text = "Загрузить текст из файла";
			this.LoadTextFromFileButton.UseVisualStyleBackColor = true;
			this.LoadTextFromFileButton.Click += new System.EventHandler(this.LoadTextFromFileButton_Click);
			// 
			// SourseTextBox
			// 
			this.SourseTextBox.Location = new System.Drawing.Point(24, 33);
			this.SourseTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.SourseTextBox.Name = "SourseTextBox";
			this.SourseTextBox.Size = new System.Drawing.Size(293, 176);
			this.SourseTextBox.TabIndex = 1;
			this.SourseTextBox.Text = "";
			// 
			// labelSourse
			// 
			this.labelSourse.AutoSize = true;
			this.labelSourse.Location = new System.Drawing.Point(95, 7);
			this.labelSourse.Name = "labelSourse";
			this.labelSourse.Size = new System.Drawing.Size(95, 15);
			this.labelSourse.TabIndex = 2;
			this.labelSourse.Text = "Исходный текст";
			// 
			// UniqueTextBox
			// 
			this.UniqueTextBox.Location = new System.Drawing.Point(384, 33);
			this.UniqueTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.UniqueTextBox.Name = "UniqueTextBox";
			this.UniqueTextBox.ReadOnly = true;
			this.UniqueTextBox.Size = new System.Drawing.Size(293, 176);
			this.UniqueTextBox.TabIndex = 3;
			this.UniqueTextBox.Text = "";
			this.UniqueTextBox.TextChanged += new System.EventHandler(this.UniqueTextBox_TextChanged);
			// 
			// labelUnique
			// 
			this.labelUnique.AutoSize = true;
			this.labelUnique.Location = new System.Drawing.Point(438, 7);
			this.labelUnique.Name = "labelUnique";
			this.labelUnique.Size = new System.Drawing.Size(124, 15);
			this.labelUnique.TabIndex = 4;
			this.labelUnique.Text = "Уникальные e-mail\'ы";
			// 
			// FindUniqueMailsButton
			// 
			this.FindUniqueMailsButton.Location = new System.Drawing.Point(183, 260);
			this.FindUniqueMailsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.FindUniqueMailsButton.Name = "FindUniqueMailsButton";
			this.FindUniqueMailsButton.Size = new System.Drawing.Size(133, 47);
			this.FindUniqueMailsButton.TabIndex = 6;
			this.FindUniqueMailsButton.Text = "Найти уникальные e-mail\'ы";
			this.FindUniqueMailsButton.UseVisualStyleBackColor = true;
			this.FindUniqueMailsButton.Click += new System.EventHandler(this.FindUniqueMailsButton_Click);
			// 
			// SaveMailsToFileButton
			// 
			this.SaveMailsToFileButton.Location = new System.Drawing.Point(470, 260);
			this.SaveMailsToFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.SaveMailsToFileButton.Name = "SaveMailsToFileButton";
			this.SaveMailsToFileButton.Size = new System.Drawing.Size(133, 47);
			this.SaveMailsToFileButton.TabIndex = 7;
			this.SaveMailsToFileButton.Text = "Сохранить e-mail\'ы в файл\r\n";
			this.SaveMailsToFileButton.UseVisualStyleBackColor = true;
			this.SaveMailsToFileButton.Click += new System.EventHandler(this.SaveMailsToFileButton_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// NumbersOfSourseMailsLabel
			// 
			this.NumbersOfSourseMailsLabel.AutoSize = true;
			this.NumbersOfSourseMailsLabel.Location = new System.Drawing.Point(24, 230);
			this.NumbersOfSourseMailsLabel.Name = "NumbersOfSourseMailsLabel";
			this.NumbersOfSourseMailsLabel.Size = new System.Drawing.Size(128, 15);
			this.NumbersOfSourseMailsLabel.TabIndex = 9;
			this.NumbersOfSourseMailsLabel.Text = "Количество e-mail\'ов:";
			// 
			// NumbersOfUniqueMailsLabel
			// 
			this.NumbersOfUniqueMailsLabel.AutoSize = true;
			this.NumbersOfUniqueMailsLabel.Location = new System.Drawing.Point(384, 230);
			this.NumbersOfUniqueMailsLabel.Name = "NumbersOfUniqueMailsLabel";
			this.NumbersOfUniqueMailsLabel.Size = new System.Drawing.Size(128, 15);
			this.NumbersOfUniqueMailsLabel.TabIndex = 10;
			this.NumbersOfUniqueMailsLabel.Text = "Количество e-mail\'ов:";
			// 
			// SampleTextBox
			// 
			this.SampleTextBox.Location = new System.Drawing.Point(89, 328);
			this.SampleTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.SampleTextBox.Name = "SampleTextBox";
			this.SampleTextBox.PlaceholderText = "@gmail.com";
			this.SampleTextBox.Size = new System.Drawing.Size(134, 23);
			this.SampleTextBox.TabIndex = 11;
			// 
			// SetSampleButton
			// 
			this.SetSampleButton.Location = new System.Drawing.Point(228, 323);
			this.SetSampleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.SetSampleButton.Name = "SetSampleButton";
			this.SetSampleButton.Size = new System.Drawing.Size(88, 31);
			this.SetSampleButton.TabIndex = 12;
			this.SetSampleButton.Text = "Применить";
			this.SetSampleButton.UseVisualStyleBackColor = true;
			this.SetSampleButton.Click += new System.EventHandler(this.SetSampleButton_Click);
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
			// FindMailsInTheText
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 372);
			this.Controls.Add(this.SampleLabel);
			this.Controls.Add(this.SetSampleButton);
			this.Controls.Add(this.SampleTextBox);
			this.Controls.Add(this.NumbersOfUniqueMailsLabel);
			this.Controls.Add(this.NumbersOfSourseMailsLabel);
			this.Controls.Add(this.SaveMailsToFileButton);
			this.Controls.Add(this.FindUniqueMailsButton);
			this.Controls.Add(this.labelUnique);
			this.Controls.Add(this.UniqueTextBox);
			this.Controls.Add(this.labelSourse);
			this.Controls.Add(this.SourseTextBox);
			this.Controls.Add(this.LoadTextFromFileButton);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FindMailsInTheText";
			this.Text = "FindMailsInTheText";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Button LoadTextFromFileButton;
        private System.Windows.Forms.RichTextBox SourseTextBox;
        private System.Windows.Forms.Label labelSourse;
        private System.Windows.Forms.RichTextBox UniqueTextBox;
        private System.Windows.Forms.Label labelUnique;
        private System.Windows.Forms.Button FindUniqueMailsButton;
        private System.Windows.Forms.Button SaveMailsToFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label NumbersOfSourseMailsLabel;
        private System.Windows.Forms.Label NumbersOfUniqueMailsLabel;
        private System.Windows.Forms.TextBox SampleTextBox;
        private System.Windows.Forms.Button SetSampleButton;
        private System.Windows.Forms.Label SampleLabel;
    }
}

