using System.Collections.Generic;
using System.Text;

namespace IMCore.TypesAndInterfaces
{
	public interface IUserTaskHandler
	{
		string LastMessage { get; set; }

		bool HandleTask();

		bool HasDuplicateOpenTasks();
		void ClearAdditionalTasks();
	}

	public interface IUserTaskHandler<T> : IUserTaskHandler
	{
		void SetTaskData(T t);
	}

}
