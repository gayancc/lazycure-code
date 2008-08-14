using System.Collections.Generic;

namespace LifeIdea.LazyCure.Core.Tasks
{
    public interface ITaskCollection:IEnumerable<Task>,ITaskActivityLinker
    {
        void Add(Task task);

        bool Contains(string taskName);

        Task GetTask(string name);

        Task[] ToArray();

        bool IsWorking(string taskName);

        void Remove(string taskName);

        void UpdateIsWorkingProperty(string taskName, bool working);
    }
}