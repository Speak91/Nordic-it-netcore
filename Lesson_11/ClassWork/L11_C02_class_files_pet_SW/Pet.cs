using System;

public class Pet
{
	public string Kind;
	public string Name;
	public char Sex;
	public DateTimeOffset DateOfBirth;

	public byte Age
	{
		get
		{
			TimeSpan age = DateTimeOffset.Now - DateOfBirth;
			return (byte)Math.Floor(age.TotalDays / 365.242);
		}
	}

	public string Description
	{
		get
		{
			return $"{Name} is a {Kind} ({Sex}) of {Age} years old.";
		}
	}

	public string ShortDescription
	{
		get
		{
			return $"{Name} is a {Kind}";
		}
	}

	public Pet()
	{
	}

	public Pet(string name, string kind, char sex, DateTimeOffset dateOfBirth)
	{
		Name = name;
		Kind = kind;
		Sex = sex;
		DateOfBirth = dateOfBirth;
	}

	public void WriteDescription(string prefix, bool showFullDescription = false)
	{
		Console.WriteLine(
			prefix + " " +
			(showFullDescription
				? Description
				: ShortDescription));
	}

	public void UpdateProperties(string name, string kind)
	{
		Name = name;
		Kind = kind;
	}
	public void UpdateProperties(string name, string kind, char sex, DateTimeOffset dateOfBirth)
	{
		Name = name;
		Kind = kind;
		Sex = sex;
		DateOfBirth = dateOfBirth;
	}
}
