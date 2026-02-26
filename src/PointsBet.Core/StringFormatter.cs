
using System.Text;
          
namespace PointsBet_Backend_Online_Code_Test
{
    /// <summary>
    /// An utility method for string formatting operations.
    /// </summary>
    public class StringFormatter
    {
        /// <summary>
        /// Converts a string array to a comma-separated list.
        /// </summary>
        /// <param name="items">The array of strings.</param>
        /// <param name="quote">The quote character to wrap each item. Default to empty string.</param>
        /// <returns>A comma-separated string with each item wrapped in the specified quote character.</returns>
        /// <exception cref="ArgumentNullException">Thrown when items array is null.</exception>
        public static string ToCommaSeparatedList(string[] items, string quote = "")
        {
             if (items == null)
                throw new ArgumentNullException(nameof(items));

            return string.Join(", ", items.Select(item => $"{quote}{item}{quote}"));
        }
    }
}
