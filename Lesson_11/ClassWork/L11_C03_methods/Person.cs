﻿class Person
{
	public string Name { get; set; }

	public int Age { get; set; }

	public int AgeInFourYears
	{
		get { return Age + 4; }
	}

	public string PropertiesString
	{
		get { return $"Name: {Name}, age in 4 years: {GetAgeInFourYears()}."; }
	}

	public int GetAgeInFourYears()
	{
		return AgeInFourYears;

		int a = 0;
		a++;
		System.Console.WriteLine(a);
	}

	

}