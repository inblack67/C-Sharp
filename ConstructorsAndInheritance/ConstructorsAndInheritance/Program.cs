using System;
using System.Collections.Generic;
namespace ConstructorsAndInheritance
{
	class Program
	{
		public static void Main(string[] args)
		{
			var car = new Car("123");
		}

	}

	public class Vehicle
	{
		private readonly string _registrationNumber;

		public Vehicle(string registrationNumber)
		{
			this._registrationNumber = registrationNumber;
			Console.WriteLine("Param of Vehicle");
		}

	}

	public class Car : Vehicle
	{
		public Car(string regNum) : base(regNum)
		{
			Console.WriteLine("Car Default");

		}
		// without base(regNum) -> error as Car would have tried to call the default contructor of Vehicle, which doesn't exists
	}


}
