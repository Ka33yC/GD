using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace GD
{
	class EmailCounter
	{
		public static List<string> GetAllEmails(string[] words)
		{
			List<string> emails = new List<string>();

			// Проверяю каждый возможный эмейл в массиве слов на то, является ли он эмейлом
			foreach(string mightEmail in words)
			{
				 string[] emailParts = mightEmail.Split('@');
				// Если мы разделили возможный email и не получили 2 слова, то есть разделили
				// "domain.ru" - получим одну часть слова или "afdf@do.ru@fre" - получим 3 части
				// Интересует именно формат "afdf@do.ru" когда этих частей будет две
				if (emailParts.Length != 2) continue;

				string leftPart = emailParts[0];
				string rightPart = emailParts[1];

				if(CheckLeftPart(leftPart) && CheckRightPart(rightPart))
				{
					emails.Add(mightEmail);
				}
			}

			return emails;
		}

		public static bool CheckDomain(string domain)
		{
			int domainLength = domain.Length;
			if (domain.Length < 2 || domain[0] != '@') return false;

			return CheckRightPart(domain.Substring(1, domainLength - 1));
		}

		private static bool CheckLeftPart(string partToCheck)
		{
			int partToCheckLength = partToCheck.Length;
			// Ограничение для создания email`ов
			// 59 - это такая левая часть a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a
			if (partToCheckLength < 6 || partToCheckLength > 59) return false;

			// Максмальное число знаков в email - 30(которые не являются точками)
			// separatedLength будет меньше 1, если 2 точки стоят подряд или точка в начале/в конце
			// Такой эмейл не может сущестовать
			return CheckPart(partToCheck, 1, 30);
		}

		private static bool CheckRightPart(string partToCheck)
		{
			int partToCheckLength = partToCheck.Length;
			// Ограничение для создания email`ов
			// 59 - это такая левая часть a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a
			if (partToCheckLength < 5 || partToCheckLength > 63) return false;

			// Максмальное число знаков в email - 30(которые не являются точками)
			// separatedLength будет меньше 1, если 2 точки стоят подряд или точка в начале/в конце
			// Такой эмейл не может сущестовать
			// minSeparatedCount - это минимальное кол-во строк, на которые разделяет точка
			return CheckPart(partToCheck, 2, 63, 2);
		}

		/// <summary>
		/// Проверяет, может ли правая или левая части существовать
		/// </summary>
		/// <param name="partToCheck">Часть для проверки</param>
		/// <param name="minSeparatedLength">Минимальное количество символов между точками</param>
		/// <param name="maxSymbolsCount">Максмальное количество символов(не точек) в части</param>
		/// <param name="minSeparatedCount">Минимальное количество частей, 
		/// на которые точка может разделить partToCheck</param>
		/// <returns></returns>
		private static bool CheckPart(string partToCheck, int minSeparatedLength, int maxSymbolsCount, int minSeparatedCount = 1)
		{
			string[] separatedByDot = partToCheck.Split('.');
			if (separatedByDot.Length < minSeparatedCount) return false;

			int symbolsCount = 0;
			foreach (var separated in separatedByDot)
			{
				int separatedLength = separated.Length;
				symbolsCount += separatedLength;
				
				if (separatedLength < minSeparatedLength || symbolsCount > maxSymbolsCount) return false;

				// Если есть символ не из английского алфавита или не 0-9, то такой эмейл не может существовать
				if (!Regex.IsMatch(separated, "^[a-zA-Z0-9]*$")) return false;
			}
			return true;
		}
	}
}
