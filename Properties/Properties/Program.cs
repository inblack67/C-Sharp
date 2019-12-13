using System;
namespace Properties
{
	class Program
	{
		public static void Main(string[] args)
		{
			var person = new Person();
			person.Name = "Slim Shady";
			person.Intro();
		}
	}

	public class Person
	{
		public DateTime Birthdate
		{
			get     // custom mutators
			{
				var timespan = DateTime.Today.AddDays(5);
				return timespan;
			}

			set
			{
				Birthdate = value;      // which will be set by the object
			}
		}

		public string Name { get; set; }    // auto implemented properties

		public void Intro()
		{
			Console.WriteLine("Hi! My name is " + Name + " of birthdate " + Birthdate);
		}
	}
}
