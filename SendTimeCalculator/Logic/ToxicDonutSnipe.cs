using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SendTimeCalculator.Logic
{
    internal class ToxicDonutSnipe
    {

        public static (string, string) calculateSendTime()
        {
            try
            {
                string input = Program.MainForm.TextboxContent;

                // Split the input string by lines
                var lines = input.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

                foreach (var line in lines)
                {
                    var parts = line.Split(',');

                    if (parts.Length < 7)
                    {
                        continue; // Skip this line and move to the next one
                    }

                    string arrivalTimeStr = parts[4];
                    DateTime arrivalTime;
                    if (!DateTime.TryParseExact(arrivalTimeStr, "yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture, DateTimeStyles.None, out arrivalTime))
                    {
                        continue; // Skip this line and move to the next one
                    }

                    DateTime sendTime;
                    if (!DateTime.TryParseExact(parts[6], "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out sendTime))
                    {
                        continue; // Skip this line and move to the next one
                    }

                    // Check if the send time is at least 15 seconds from the current time
                    if ((sendTime - DateTime.Now).TotalSeconds >= 15)
                    {
                        var combinedTime = new DateTime(
                            sendTime.Year, sendTime.Month, sendTime.Day,
                            sendTime.Hour, sendTime.Minute, sendTime.Second, arrivalTime.Millisecond);

                        return (combinedTime.ToString("yyyy-MM-dd HH:mm:ss.fff"), arrivalTimeStr);
                    }
                }

                return ("Error: No suitable send time found.", "");
            }
            catch (Exception ex)
            {
                // Log the exception details for debugging purposes
                Console.WriteLine(ex.ToString());

                // Return a generic error message
                return ("Error: An unexpected error occurred.", "");
            }
        }
    }
}
