#region Includes

// .NET Libraries
using System;

#endregion

namespace SOLID.SingleResponsibility.Common
{
    /// <summary>
    /// Represents a scheduled task in the system.
    /// </summary>
    public class ScheduledTask
    {
        #region Properties
        
        /// <summary>
        /// Gets or sets the task id.
        /// </summary>
        public int TaskId { get; set; }

        /// <summary>
        /// Gets or sets the datetime to execute scheduled task.
        /// </summary>
        public DateTime ExecuteOn { get; set; }

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        public string Content { get; set; }

        #endregion
    }
}
