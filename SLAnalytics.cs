using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Assets
{

    public enum TrackingSegmentsCategories { 
        EYE_TRACKING,
        HANDS,
        GENERAL,
        CUSTOM
    }

    public class SLAnalytics : SLAnalyticsFactory<SLAnalytics>
    {

        private Dictionary<string, List<string>> TrackingSegments = new Dictionary<string, List<string>>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="trackingCategory"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public void AddEvent(TrackingSegmentsCategories trackingCategory, string timestamp, string value)
        {
            string category = trackingCategory.ToString();
            if (!TrackingSegments.ContainsKey(category)) {
                TrackingSegments[category] = new List<string>();
            }

            TrackingSegments[category].Add($"{timestamp}, {value}.");
        }

        public void AddEvent(TrackingSegmentsCategories trackingCategory, string timestamp, Dictionary<string,string> data) {

            string s = string.Join(",", data.Select(x => x.Key + "=" + x.Value).ToArray());
            this.AddEvent(trackingCategory, timestamp, s);
        }
        /// <summary>
        /// Flush and save our data to a csv file
        /// </summary>
        public void SaveCSV(string path, string fileName, bool flush = true)
        {
            string csvHeaders = GetCSVHeadersFromData();
        }

        private string GetCSVHeadersFromData()
        {
            return "";
        }

    }
}
