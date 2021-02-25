using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BitbankUnitySDK
{
    public class BitbankRestApi
    {
        public static void SpotPairs()
        {
            HTTPManager.Instance.Request("https://api.bitbank.cc/v1/spot/pairs", onSuccess: (dh) =>
            {
                Debug.Log(dh.text);
            });
        }
    }
}

