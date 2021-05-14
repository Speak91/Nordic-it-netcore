using System;

namespace Lesson5_02_self_work1
{
	class Program
	{
		static void Main(string[] args)
		{
			const int min = 1;
			const int max = 30;

			Console.WriteLine($"Введите срок договора аренды от {min} года до {max} лет");
			int leaseTerm = Convert.ToInt32(Console.ReadLine());

			if (leaseTerm <= min || leaseTerm > max)
			{
				Console.WriteLine("вы ввели неверное значение");
				return;
			}
			
			string yearsWordForm = string.Empty;

			if (leaseTerm == 1 || leaseTerm == 21 || leaseTerm == 31 || leaseTerm == 35)
			{
				yearsWordForm = "год";
			}
			else if (leaseTerm > 1 && leaseTerm < 5 || leaseTerm > 21 && leaseTerm < 25 || leaseTerm > 32 && leaseTerm < 35)
			{
				yearsWordForm = "года";
			}
			else
			{
				yearsWordForm = "лет";
			}

			Console.WriteLine($"Договор аренды оформлен на период длительностью {leaseTerm} {yearsWordForm}");
		}
	}
}
