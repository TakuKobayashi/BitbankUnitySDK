using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BitbankUnitySDK
{
    public class SpotStatusData
    {
        public string pair;
        public string status; // NORMAL, BUSY, VERY_BUSY, HALT
        public string min_amount;
    }
}
