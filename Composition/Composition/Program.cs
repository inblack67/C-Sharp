using System;
using System.Collections.Generic;
namespace Composition
{
	class Program
	{
		public static void Main(string[] args)
		{
			var logger = new Logger();
			var dbmigrator = new DbMigrator(logger);
			var installer = new Installer(logger);

			dbmigrator.Migrate();
			installer.Install();
		}
	}

	public class Logger
	{
		public void Log(string message)
		{
			Console.WriteLine("Logger.Log() called with message = " + message);
		}
	}

	public class DbMigrator
	{
		private readonly Logger _logger;

		public DbMigrator(Logger logger)
		{
			_logger = logger;
		}

		public void Migrate()
		{
			_logger.Log("DbMigrator.Migrate()");
		}
	}

	public class Installer
	{
		private readonly Logger _logger;

		public Installer(Logger logger)
		{
			_logger = logger;
		}

		public void Install()
		{
			_logger.Log("Installer.Install()");
		}
	}


}
