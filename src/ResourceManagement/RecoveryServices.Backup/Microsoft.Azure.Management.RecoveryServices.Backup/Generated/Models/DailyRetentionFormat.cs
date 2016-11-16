// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// Daily retention format.
    /// </summary>
    public partial class DailyRetentionFormat
    {
        /// <summary>
        /// Initializes a new instance of the DailyRetentionFormat class.
        /// </summary>
        public DailyRetentionFormat() { }

        /// <summary>
        /// Initializes a new instance of the DailyRetentionFormat class.
        /// </summary>
        /// <param name="daysOfTheMonth">List of days of the month.</param>
        public DailyRetentionFormat(System.Collections.Generic.IList<Day> daysOfTheMonth = default(System.Collections.Generic.IList<Day>))
        {
            DaysOfTheMonth = daysOfTheMonth;
        }

        /// <summary>
        /// Gets or sets list of days of the month.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "daysOfTheMonth")]
        public System.Collections.Generic.IList<Day> DaysOfTheMonth { get; set; }

    }
}
