#region Includes

// .NET Libraries
using System;
using System.Collections.Generic;
using System.Linq;

// SOLID libraries
using SOLID.SingleResponsibility.Common;

#endregion

namespace SOLID.SingleResponsibility
{
    /// <summary>
    /// Represents a scheduler in the system.
    /// </summary>
    public class Scheduler
        : IEntryManager<ScheduledTask>
    {
        #region Includes

        private readonly List<ScheduledTask> _scheduledTasks;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes an instance of Scheduler in the system.
        /// </summary>
        public Scheduler()
        {
            _scheduledTasks = new List<ScheduledTask>();
        }

        #endregion

        #region IEntryManager Members

        /// <summary>
        /// Adds an entry.
        /// </summary>
        /// <param name="entry">The <see cref="ScheduledTask"/> instance.</param>
        public void AddEntry(ScheduledTask entry) => _scheduledTasks.Add(entry);

        /// <summary>
        /// Removes an entry at the specified index.
        /// </summary>
        /// <param name="idx">The index of the entry to remove.</param>
        public void RemoveEntryAt(int idx) => _scheduledTasks.RemoveAt(idx);

        #endregion

        #region Miscellaneous Methods

        /// <summary>
        /// Converts the current instance to a specialized string version.
        /// </summary>
        /// <returns>The current WorkReport instance as a string.</returns>
        public override string ToString() => string.Join(Environment.NewLine,
            _scheduledTasks.Select(x => $"Task ID:  {x.TaskId}, Content:  {x.Content}, Execute On:  {x.ExecuteOn}"));

        #endregion
    }
}
