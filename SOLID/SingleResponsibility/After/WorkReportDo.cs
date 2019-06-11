#region Includes

// .NET Libraries
using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace SOLID.SingleResponsibility
{
    /// <summary>
    /// Represents a WorkReport instance in the system.
    /// </summary>
    /// <remarks>
    /// This class, as is, SATISFIES the Single Responsibility Principle.
    /// This class currently does the following:
    ///     1. Keeps track of our work report entries.
    /// 
    /// This class has only 1 reason to change now.
    /// </remarks>
    public class WorkReportDo
    {

        #region Fields

        private readonly List<WorkReportEntry> _entries;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of WorkReport in the system.
        /// </summary>
        public WorkReportDo()
        {
            _entries = new List<WorkReportEntry>();
        }

        #endregion

        #region Change Reason:  Tracking work report entries

        /// <summary>
        /// Adds an entry to the current WorkReport instance.
        /// </summary>
        /// <param name="entry">The <see cref="WorkReportEntry"/> to add.</param>
        public void AddEntry(WorkReportEntry entry) => _entries.Add(entry);

        /// <summary>
        /// Removes an entry in the current WorkReport instance.
        /// </summary>
        /// <param name="idx">The id of the entry to remove.</param>
        public void RemoveEntryAt(int idx) => _entries.RemoveAt(idx);

        #endregion

        #region Miscellaneous Methods

        /// <summary>
        /// Converts the current instance to a specialized string version.
        /// </summary>
        /// <returns>The current WorkReport instance as a string.</returns>
        public override string ToString() => string.Join(Environment.NewLine,
            _entries.Select(x => $"Code:  {x.ProjectCode}, Name:  {x.ProjectName}, Hours:  {x.SpentHours}"));

        #endregion
    }
}
