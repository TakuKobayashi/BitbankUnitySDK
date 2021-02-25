using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BitbankUnitySDK
{
    internal class CandlestickParseData
    {
        public List<CandlestickData> candlestick;
    }

    public class CandlestickData {
        public string type;
        public List<List<string>> ohlcv; // [open, high, low, close, volume, unix timestamp (milliseconds)]
    }
}
