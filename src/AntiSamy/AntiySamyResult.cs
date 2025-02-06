using System;
using System.Collections.Generic;

namespace U4.AntiSamy
{
    public class AntiySamyResult
    {
        public AntiySamyResult(DateTime startOfScan, string cleanHtml, IEnumerable<string> errorMessages)
        {
            Elapsed = DateTime.UtcNow - startOfScan;
            CleanHtml = cleanHtml;
            ErrorMessages = errorMessages;
        }

        public TimeSpan Elapsed { get; }

        public string CleanHtml { get; }

        public IEnumerable<string> ErrorMessages { get; }
    }
}
