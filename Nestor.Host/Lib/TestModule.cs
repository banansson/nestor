using System;
using Nancy;

namespace Nestor.Host.Lib
{
	public class TestModule : NancyModule
	{
		public TestModule()
		{
			Get["/"] = _ =>
			{
				return "Helo";
			};

			Get["/time"] = _ =>
			{
				return String.Format("{0} UTC", DateTime.UtcNow.ToString());
			};

			Get["/random/{nr?}"] = parameters =>
			{
				var max = (parameters.nr == null) ? int.MaxValue : parameters.nr;
				return new Random()
					.Next(max)
					.ToString();
			};
		}
	}
}
