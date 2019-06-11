#region Includes

// .NET Libraries
using System.IO;

#endregion

namespace SOLID.SingleResponsibility
{
    /// <summary>
    /// Represents a mechanism to save work report entries to a file.
    /// </summary>
    public class FileSaverBetter
    {
        /// <summary>
        /// Saves a <see cref="WorkReportDo"/> to a file.
        /// </summary>
        /// <param name="directoryPath">The directory path.</param>
        /// <param name="fileName">The file name for the work report.</param>
        /// <param name="report">The work report instance to save.</param>
        public void SaveToFile<T>(string directoryPath, string fileName, IEntryManager<T> report)
        {
            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);

            File.WriteAllText(Path.Combine(directoryPath, fileName), report.ToString());
        }
    }
}
