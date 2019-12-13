using System;
using System.Collections.Generic;
namespace Indexers
{
	class Program
	{
		public static void Main(string[] args)
		{
			var cookie = new HttpCookie();
			cookie["Name"] = "Ryuzaki";
			Console.WriteLine(cookie["Name"]);
		}
	}

	public class HttpCookie
	{
		private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();

		public string this[string key]
		{
			get { return _dictionary[key]; }
			set { _dictionary[key] = value; }
		}

	}

}
