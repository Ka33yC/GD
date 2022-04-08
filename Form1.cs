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
		// Это поле во-первых, не нужно, во-вторых, не соответсвует правилу кодирования
		//string mainText = null;
		char[] _separators = new char[] { ' ', ',', ':', ';', '-', '=', '!', '?', '/', 
			'\\', '|', '*', '$', '%', '^', '\r', '\n' };
		public FindMailsInTheTextForm()
		{
			InitializeComponent();
		}

		private void LoadTextFromFileButton_Click(object sender, EventArgs e)
		{
			var dialog = openFileWithEmail.ShowDialog();
			if (dialog == DialogResult.OK || dialog == DialogResult.Yes)
			{
				string fileName = openFileWithEmail.FileName;
				CheckFile(fileName);
			}
		}

		private void CheckFile(string fileName)
        {
			string textFromFile = Path.GetExtension(fileName);
			// Этот код не нужен. Поставил фильтр у openFileDialog 
			//if (textFromFile != ".txt")
			//{
			//	MessageBox.Show("Файл должен иметь расширение '.txt'");
			//	return;
			//}
			try
			{
				using (StreamReader reader = new StreamReader(fileName))
				{
					textFromFile = reader.ReadToEnd();
				}
			}
			// внизу ты выводишь эксепшен, а тут нет -______-
			catch (Exception ex)
			{
				MessageBox.Show($"Ошибка при открытии файла! {ex.Message}");
				return;
			}

			//Вывожу текст на экран
			DisplayTextFromFile(textFromFile);
			//DisplayuniqueMails(textFromFile);

			// Непонятно зачем ты эту функцию вызываешь она возвращает резуьтат работы, который в пустоту уходит
			// SplitTheText(textFromFile);
		}

		private void DisplayTextFromFile(string text) => SourseTextBox.Text = text.Trim();
        
		private void DisplayUniqueMails(string text)
		{
			UniqueTextBox.Clear();
			UniqueTextBox.Text = text.Trim();
		}

		private string[] SplitTheText(string text)
		{
			string[] splitedText = text.Trim().Split(_separators, StringSplitOptions.TrimEntries);
			return splitedText;
		}

        private void FindUniqueMailsButton_Click(object sender, EventArgs e)
        {
			// Text вроде не может быть null, даже если может, лучше проверять не пустая ли строка и !null
			if (String.IsNullOrEmpty(SourseTextBox.Text)) return;

			string[] words = SplitTheText(SourseTextBox.Text);

			var listOfAllMails = EmailCounter.GetAllEmails(words);
			var listOfUniqueMails = EmailCounter.GetUniqueEmails(listOfAllMails);

			// почему переменная названа с большой буквы?
			// а также она не отображает того, что функция возвращает
			// а также {} нужно ставить. Их можно не ставить только если как в 76й строке - return
			// А также тут ты непрерывно конкатенируешь строки. Нельзя это оставлять в стринге,
			// ты будешь генерировать очень много мусора. Нужно использовать StringBuilder, он оптимальнее
			StringBuilder uniqueMailsText = new StringBuilder();
			foreach (string mail in listOfUniqueMails)
			{
				uniqueMailsText.Append(mail);
				uniqueMailsText.Append("\n");
			}

			DisplayUniqueMails(uniqueMailsText.ToString());

			SetNumbersOfSourseMails(listOfAllMails.Count());
			SetNumbersOfUniqueMails(listOfUniqueMails.Count());
		}

        private void SaveMailsToFileButton_Click(object sender, EventArgs e)
        {
			// Проверка говно. В UniqueTextBox никогда не будет null и даже если стркоа будет пустой,
			// то пусть юзер решает, что ему записывать в файл, а что - нет
			if (String.IsNullOrEmpty(UniqueTextBox.Text)) return;
			// Зачем ты создаёшь SaveFileDialog -____- я его создал единожды в форме
			//SaveFileDialog sfd = new SaveFileDialog();
			//sfd.Title = "Сохранить текст как...";
			//sfd.OverwritePrompt = true;
			//sfd.CheckPathExists = true;
			//sfd.Filter = "Txt Files(*.txt)|*.txt";
			//sfd.ShowHelp = true;
			DialogResult dialogResult = saveEmailsToFile.ShowDialog();
			if (dialogResult != DialogResult.OK && dialogResult != DialogResult.Yes) return;
			
			try
			{
				using (StreamWriter writer = new StreamWriter(saveEmailsToFile.FileName))
				{
					writer.Write(UniqueTextBox.Text);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Невозможно записать данные в файл. {ex.Message}");
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
			if (String.IsNullOrEmpty(SampleTextBox.Text)) return;
			
			char[] separators = new char[] { ' ', ',', '\r', '\n' };
			string[] splitedText = SampleTextBox.Text.Trim().Split(separators, StringSplitOptions.TrimEntries);

			List<string> trueDomains = new List<string>();
			foreach (string s in splitedText)
            {
				if (EmailCounter.IsDomain(s))
                {
					trueDomains.Add(s);
				}
            }

			SampleTextBox.Clear();
			foreach (string s in trueDomains)
			{
				SampleTextBox.Text += s + ", ";
			}
		}

        private void UniqueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResetSampleButton_Click(object sender, EventArgs e)
        {
			SampleTextBox.Clear();
		}
    }
}
