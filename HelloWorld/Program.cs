using HelloWorld.Models;
using System;
using System.Data.Entity;
using Wisej.Web;

namespace HelloWorld
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{

			Window1 window = new Window1(DataContext.Instance);
			Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DataContext>());
			window.Show();
		}

		//
		// You can use the entry method below
		// to receive the parameters from the URL in the args collection.
		//
		//static void Main(NameValueCollection args)
		//{
		//}
	}
}