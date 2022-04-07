using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GD
{
	public partial class FindMailsInTheText : Form
	{
		string mainText = null;
		public FindMailsInTheText()
		{
			InitializeComponent();
		}

		private void LoadTextFromFileButton_Click(object sender, EventArgs e)
		{
			var dialog = openFileDialog1.ShowDialog();
			if (dialog == DialogResult.OK || dialog == DialogResult.Yes)
			{
				string fileName = openFileDialog1.FileName;
				CheckFile(fileName);
			}
		}

		private void CheckFile(string fileName)
        {
			string textFromFile = Path.GetExtension(fileName);
			if (textFromFile != ".txt")
			{
				MessageBox.Show("Файл должен иметь расширение '.txt'");
				return;
			}
			try
			{
				using (StreamReader reader = new StreamReader(fileName))
				{
					textFromFile = reader.ReadToEnd();
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Ошибка при открытии файла!");
				return;
			}

			mainText = textFromFile;
			//Вывожу текст на экран
			DisplayTextFromFile(textFromFile);
			//DisplayuniqueMails(textFromFile);

			//ПОТОМ УДАЛИТЬ
			SetNumbersOfSourseMails(15);

			//разбиваю текст на части
			SplitTheText(textFromFile);
		}

		private void DisplayTextFromFile(string text)
        {
			SourseTextBox.Text = text.Trim();
        }

		private void DisplayuniqueMails(string text)
		{
			UniqueTextBox.Clear();
			UniqueTextBox.Text = text.Trim();
		}

		private string[] SplitTheText(string text)
		{
			char[] separators = new char[] { ' ', ',', ':', ';', '-', '=', '!', '?', '/', '\\', '|', '*', '$', '%', '^', '\r', '\n' };
			string[] splitedText = text.Trim().Split(separators, StringSplitOptions.TrimEntries);
			return splitedText;
		}

        private void FindUniqueMailsButton_Click(object sender, EventArgs e)
        {
			if (SourseTextBox.Text == null)
				return;
			string[] splitted = SplitTheText(SourseTextBox.Text);
			List<string> listOfUniqueMails = EmailCounter.GetAllEmails(splitted);
			string NotListOfUniqueMails = "";
			foreach (string s in listOfUniqueMails)
				NotListOfUniqueMails += s + "\n";

			DisplayuniqueMails(NotListOfUniqueMails);

			SetNumbersOfSourseMails(listOfUniqueMails.Count());
			SetNumbersOfUniqueMails(listOfUniqueMails.Count());
		}

        private void SaveMailsToFileButton_Click(object sender, EventArgs e)
        {
			if (UniqueTextBox.Text != null && UniqueTextBox.Text.Trim().Length > 0)
			{
				SaveFileDialog sfd = new SaveFileDialog();
				sfd.Title = "Сохранить текст как...";
				sfd.OverwritePrompt = true;
				sfd.CheckPathExists = true;
				sfd.Filter = "Txt Files(*.txt)|*.txt";
				sfd.ShowHelp = true;

				if (sfd.ShowDialog() == DialogResult.OK)
				{
					try
					{
						using (StreamWriter writer = new StreamWriter(sfd.FileName, true)) // дозапись
						{
							writer.Write(UniqueTextBox.Text);
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show($"Невозможно записать данные в файл\n{ex}");
					}
				}
			}
		}

		private void SetNumbersOfSourseMails(int number)
        {
			NumbersOfSourseMailsLabel.Text = $"Количество e-mail'ов: {number}";
		}

		private void SetNumbersOfUniqueMails(int number)
		{
			NumbersOfUniqueMailsLabel.Text = $"Количество e-mail'ов: {number}";
		}

        private void SetSampleButton_Click(object sender, EventArgs e)
        {
			if (!String.IsNullOrEmpty(SampleTextBox.Text))
			{
				MessageBox.Show(EmailCounter.CheckDomain(SampleTextBox.Text.Trim()).ToString());
			}
			else
			{
			}
		}

        private void UniqueTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
