#region Includes

// .NET Libraries
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

#endregion


namespace SOLID.SingleResponsibility
{
    /// <summary>
    /// Represents a WorkReport instance in the system.
    /// </summary>
    /// <remarks>
    /// This class, as is, VIOLATES the Single Responsibility Principle.
    /// This class currently does the following:
    ///     1. Keeps track of our work report entries.
    ///     2. Saves a work entry to a file.
    /// 
    /// Therein lies the violation of SIP...the class the way it is has 2 reasons to change now.
    /// For example, suppose you want to track your work report entries in a different way, but you
    /// also want to save to a file in a different way.  This class now has two reasons to change.
    /// 
    /// See the "Do" folder to see SIP in action.
    /// </remarks>
    public class WorkReportDont
    {
        #region Fields

        private readonly List<WorkReportEntry> _entries;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of WorkReport in the system.
        /// </summary>
        public WorkReportDont()
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

        #region Change Reason:  Saving work report entries

        /// <summary>
        /// Saves an entry to the WorkReport.
        /// </summary>
        /// <param name="directoryPath">The path to the work entry.</param>
        /// <param name="fileName">The name of the file.</param>
        public void SaveToFile(string directoryPath, string fileName)
        {
            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);

            File.WriteAllText(Path.Combine(directoryPath, fileName), ToString());
        }

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
