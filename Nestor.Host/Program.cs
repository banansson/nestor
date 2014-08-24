using System;
using Nancy.Hosting.Self;

namespace Nestor.Host
{
	class Application
	{
		public static void Main (string[] args)
		{
			var addr = "http://localhost";
			var	port = 4242;
			var uri = new Uri (String.Format("{0}:{1}", addr, port));

			var config = new HostConfiguration { UrlReservations = new UrlReservations { CreateAutomatically = true } };
			using (var host = new NancyHost(config, new [] { uri }))
			{
				host.Start();

				Console.WriteLine(String.Format("Host started on port {0}", port));
				Console.WriteLine("Press Enter to stop...");
				Console.ReadLine();
			}
		}
	}

}
