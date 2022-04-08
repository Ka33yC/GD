using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Text;

namespace GD
{
	public partial class FindMailsInTheTextForm : Form
	{
		char[] _separators = new char[] { ' ', ',', ':', ';', '-', '=', '!', '?', '/', 
			'\\', '|', '*', '$', '%', '^', '\r', '\n' };


		public FindMailsInTheTextForm()
		{
			InitializeComponent();
		}

		private void LoadTextFromFileButton_Click(object sender, EventArgs e)
		{
			var dialog = openFileWithEmail.ShowDialog();
			if (dialog != DialogResult.OK && dialog != DialogResult.Yes) return;
			
			string fileName = openFileWithEmail.FileName;
			DisplayTextFromFile(fileName);
		}

		private void DisplayTextFromFile(string fileName)
        {
			try
			{
				using (StreamReader reader = new StreamReader(fileName))
				{
					string textFromFile = reader.ReadToEnd().Trim();
					sourseTextBox.Text = textFromFile;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Ошибка при открытии файла! {ex.Message}");
			}
		}
       

		private string[] SplitTheText(string text)
		{
			string[] splitedText = text.Trim().Split(_separators, StringSplitOptions.TrimEntries);
			return splitedText;
		}

        private void FindUniqueMailsButton_Click(object sender, EventArgs e)
        {
			if (String.IsNullOrEmpty(sourseTextBox.Text)) return;

			string[] words = SplitTheText(sourseTextBox.Text);

			var listOfAllMails = EmailCounter.GetAllEmails(words);
			var listOfUniqueMails = EmailCounter.GetUniqueEmails(listOfAllMails);

			SetEmailsToUniqueEmailsText(listOfUniqueMails);

			SetNumbersOfSourseMails(listOfAllMails.Count());
			SetNumbersOfUniqueMails(listOfUniqueMails.Count());
		}

		private void SetNumbersOfSourseMails(int number)
		{
			numbersOfSourseMailsLabel.Text = $"Количество e-mail'ов: {number}";
		}

		private void SetNumbersOfUniqueMails(int number)
		{
			numbersOfUniqueMailsLabel.Text = $"Количество e-mail'ов: {number}";
		}

		/// <summary>
		/// Функция записывает emailsToSet через '\n' в uniqueTextBox
		/// </summary>
		/// <param name="emailsToSet">Эмейлы к записи</param>
		private void SetEmailsToUniqueEmailsText(IEnumerable<string> emailsToSet)
		{
			StringBuilder uniqueEmailsText = new StringBuilder();
			foreach (string email in emailsToSet)
			{
				uniqueEmailsText.Append(email);
				uniqueEmailsText.Append('\n');
			}

			uniqueTextBox.Text = uniqueEmailsText.ToString().Trim();
		}

		private void SetSampleButton_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(domainsTemplateTextBox.Text)) return;

			char[] separators = new char[] { ' ', ',', '\r', '\n' };
			string[] splitedDomainsTemplate = domainsTemplateTextBox.Text.Trim().Split(separators);

			var domains = EmailCounter.GetCorrectDomains(splitedDomainsTemplate);

			SetDomainsTemplateText(domains);

			var listOfUniqueEmails = uniqueTextBox.Text.Split('\n');
			var filteredEmails = EmailCounter.GetUniqueEmails(listOfUniqueEmails, domains);

			SetEmailsToUniqueEmailsText(filteredEmails);
		}

		private void SaveMailsToFileButton_Click(object sender, EventArgs e)
        {
			if (String.IsNullOrEmpty(uniqueTextBox.Text)) return;

			DialogResult dialogResult = saveEmailsToFile.ShowDialog();
			if (dialogResult != DialogResult.OK && dialogResult != DialogResult.Yes) return;
			
			try
			{
				using (StreamWriter writer = new StreamWriter(saveEmailsToFile.FileName))
				{
					writer.Write(uniqueTextBox.Text);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Невозможно записать данные в файл. {ex.Message}");
			}
		}

		/// <summary>
		/// Функция записи domainsToSet через ", " в domainsTemplateTextBox
		/// </summary>
		/// <param name="domainsToSet">Домены к записи</param>
		private void SetDomainsTemplateText(IEnumerable<string> domainsToSet)
		{
			StringBuilder uniqueDomainsText = new StringBuilder();
			foreach (string domain in domainsToSet)
			{
				uniqueDomainsText.Append(domain);
				uniqueDomainsText.Append(", ");
			}

			int uniqueMailsTextLength = uniqueDomainsText.Length;
			// Удаляются добавленные последними ", "
			if (uniqueMailsTextLength != 0)
			{
				uniqueDomainsText.Remove(uniqueMailsTextLength - 2, 2);
			}

			domainsTemplateTextBox.Text = uniqueDomainsText.ToString();
		}
	}
}
