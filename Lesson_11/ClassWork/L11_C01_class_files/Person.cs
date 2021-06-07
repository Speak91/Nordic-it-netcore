class Person
{
	public string Name { get; set; }

	public int Age { get; set; }

	//public int AgeInFourYears
	//{
	//	get { return Age + 4; }
	//}

	public int GetAgeInSomeYears(int yearsCount)
	{
		return Age + yearsCount;
	}

	public string GetPropertiesString(int yearsCount)
	{
		return $"Name: {Name}, age in {yearsCount} years: {GetAgeInSomeYears(yearsCount)}.";
	}
}
