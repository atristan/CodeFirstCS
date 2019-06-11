namespace SOLID.SingleResponsibility
{
    /// <summary>
    /// Represents an instance of WorkReportEntry in the system.
    /// </summary>
    public class WorkReportEntry
    {
        #region Properties

        /// <summary>
        /// Gets or sets the spent hours for the entry.
        /// </summary>
        public int SpentHours { get; set; }

        /// <summary>
        /// Gets or sets the project code for the entry.
        /// </summary>
        public string ProjectCode { get; set; }

        /// <summary>
        /// Gets or sets the project name for the entry.
        /// </summary>
        public string ProjectName { get; set; }

        #endregion
    }
}
