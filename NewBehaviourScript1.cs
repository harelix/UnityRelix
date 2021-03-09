using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using System.IO;

namespace Assets
{
    public class NewBehaviourScript1 : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            /*
            SLAnalytics.Instance.AddEvent(TrackingSegmentsCategories.EYE_TRACKING,
                new Dictionary<string, string>
                { 
                    {"vec",  "[x,y,z]" } ,
                    {"Param2",  "9090" } ,
                    { "ts" ,  "12/12/2021 10:00:12" }
                });
            */
            //SLAnalytics.Instance.AddHeaders(TrackingSegmentsCategories.EYE_TRACKING, "")
            SLAnalytics.Instance.AddEvent(TrackingSegmentsCategories.EYE_TRACKING, "12/12/2021 10:00:12", "vector:[1,2,3]");            
            //SLAnalytics.Instance.SaveCSV(, "");
            SLAnalytics.Instance.AddEvent(TrackingSegmentsCategories.EYE_TRACKING, "12/12/2021 10:00:12", "k,v");
        }

        // Update is called once per frame
        void Update()
        {
        }
    }
}