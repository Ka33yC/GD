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

		/// <returns>Домен из email вместе с @. Вернёт null, если переданный email не содержит домен или домен неверный</returns>
		public static string GetDomain(string email)
		{
			string[] parts = email.Split("@");
			string domain = null;
			if (parts.Length == 2 && CheckRightPart(parts[1]))
			{
				domain = "@" + parts[1];
			}

			return domain;
		}

		/// <param name="domain">Должен содержать @. Если её не будет, то это не домен</param>
		/// <returns></returns>
		public static bool IsDomain(string domain)
		{
			int domainLength = domain.Length;

			return domain.Length > 4 && domain[0] == '@' &&
				CheckRightPart(domain.Substring(1, domainLength - 1));
		}

		/// <returns>Структуру данных, содержащую эмейлы среди всех найденых в words</returns>
		public static IEnumerable<string> GetAllEmails(IEnumerable<string> words)
		{
			var emails = from mightEmails in words
						 where IsEmail(mightEmails)
						 select mightEmails;
			return emails;
		}

		/// <returns>Структуру данных, содержащую только уникальные эмейлы среди всех найденых в words</returns>
		public static IEnumerable<string> GetUniqueEmails(IEnumerable<string> words)
		{
			// ToHashSet - потому что он хранит уникальные значения
			return GetAllEmails(words).ToHashSet();
		}

		/// <returns>Структура данных, содержащая только уникальные эмейлы среди всех найденых в words с доменами, 
		/// содержащимися в domains</returns>
		public static IEnumerable<string> GetUniqueEmails(IEnumerable<string> words, IEnumerable<string> domains)
		{
			// Получаем все эмейлы
			var allUniqueEmails = GetUniqueEmails(words);
			// Фильтруем их по параметру содержания домена в domains
			IEnumerable<string> filteredEmails = from email in allUniqueEmails
										  where domains.Contains(GetDomain(email))
										  select email;
			
			return filteredEmails;
		}

		/// <param name="mightDomains">Домены к проверке</param>
		/// <returns>Структура данных, содержащая только домены в правильном формате</returns>
		public static IEnumerable<string> GetCorrectDomains(IEnumerable<string> mightDomains) 
		{
			var domains = from mightDomain in mightDomains
						  where IsDomain(mightDomain)
						  select mightDomain;

			return domains;
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
