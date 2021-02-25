using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BitbankUnitySDK
{
    public class CandlestickData {
        public List<List<string>> ohlcv; // [open, high, low, close, volume, unix timestamp (milliseconds)]
    }
}
