using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace GD
{
	class EmailCounter
	{
		public static bool IsEmail(string mightEmail)
		{
			string[] emailParts = mightEmail.Split('@');
			// Если мы разделили возможный email и не получили 2 слова, то есть разделили
			// "domain.ru" - получим одну часть слова или "afdf@do.ru@fre" - получим 3 части
			// Интересует именно формат "afdf@do.ru" когда этих частей будет две
			if (emailParts.Length != 2) return false;

			string leftPart = emailParts[0];
			string rightPart = emailParts[1];

			return CheckLeftPart(leftPart) && CheckRightPart(rightPart);
		}

		public static IEnumerable<string> GetAllEmails(IEnumerable<string> words)
		{
			var emails = from mightEmails in words
						 where IsEmail(mightEmails)
						 select mightEmails;
			return emails;
		}

		public static IEnumerable<string> GetUniqueEmails(IEnumerable<string> words)
		{
			// ToHashSet - потому что он хранит уникальные значения
			return GetAllEmails(words).ToHashSet();
		}

		public static bool IsDomain(string domain)
		{
			int domainLength = domain.Length;

			return domain.Length > 4 && domain[0] == '@' && 
				CheckRightPart(domain.Substring(1, domainLength - 1));
		}

		private static bool CheckLeftPart(string partToCheck)
		{
			int partToCheckLength = partToCheck.Length;
			// Ограничение для создания email`ов
			// 59 - это такая левая часть a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a.a
			// Максмальное число знаков в email - 30(которые не являются точками)
			// separatedLength будет меньше 1, если 2 точки стоят подряд или точка в начале/в конце
			// Такой эмейл не может сущестовать
			return partToCheckLength >= 6 && partToCheckLength <= 59 && CheckPart(partToCheck, 1, 30);
		}

		private static bool CheckRightPart(string partToCheck)
		{
			int partToCheckLength = partToCheck.Length;
			// Ограничение для создания email`ов
			// minSeparatedCount - это минимальное кол-во строк, на которые разделяет точка
			return partToCheckLength >= 5 && partToCheckLength <= 63 && CheckPart(partToCheck, 2, 63, 2);
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
		private static bool CheckPart(string partToCheck, int minSeparatedLength, int maxSymbolsCount, 
			int minSeparatedCount = 1)
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
