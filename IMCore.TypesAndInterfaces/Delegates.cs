using System;

namespace IMCore.TypesAndInterfaces
{
	public class Delegates
	{
		public delegate void MessageHandlerDelegate(string Message);
		public delegate void JobUpdatedEventHandler(object sender, EventArgs e);
	}

}
