using System;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

namespace BitbankUnitySDK
{
    public class BitbankPublicApi
    {
        public static void Depth(string pair, Action<DepthData> onSuccess = null)
        {
            HTTPManager.Instance.Request(BaseUrl() + string.Format("/{0}/depth", pair), onSuccess: (dh) =>
            {
                Debug.Log(dh.text);
                ApiResponseTemplate<DepthData> responseData = JsonConvert.DeserializeObject<ApiResponseTemplate<DepthData>>(dh.text);
                if(onSuccess != null)
                {
                    onSuccess(responseData.data);
                }
            });
        }

        public static void Transaction(string pair, string dateString, Action<List<TransactionData>> onSuccess = null)
        {
            HTTPManager.Instance.Request(BaseUrl() + string.Format("/{0}/transactions/{1}/", pair, dateString), onSuccess: (dh) =>
            {
                Debug.Log(dh.text);
                ApiResponseTemplate<TransactionParseData> responseData = JsonConvert.DeserializeObject<ApiResponseTemplate<TransactionParseData>>(dh.text);
                if (onSuccess != null)
                {
                    onSuccess(responseData.data.transactions);
                }
            });
        }

        public static void Ticker(string pair, Action<TickerData> onSuccess = null)
        {
            HTTPManager.Instance.Request(BaseUrl() + string.Format("/{0}/ticker", pair), onSuccess: (dh) =>
            {
                Debug.Log(dh.text);
                ApiResponseTemplate<TickerData> responseData = JsonConvert.DeserializeObject<ApiResponseTemplate<TickerData>>(dh.text);
                if (onSuccess != null)
                {
                    onSuccess(responseData.data);
                }
            });
        }

        public static void Candlestick(string pair, string candleType, string dateString, Action<List<CandlestickData>> onSuccess = null)
        {
            HTTPManager.Instance.Request(BaseUrl() + string.Format("/{0}/candlestick/{1}/{2}", pair, candleType, dateString), onSuccess: (dh) =>
            {
                Debug.Log(dh.text);
                ApiResponseTemplate<CandlestickParseData> responseData = JsonConvert.DeserializeObject<ApiResponseTemplate<CandlestickParseData>>(dh.text);
                if (onSuccess != null)
                {
                    onSuccess(responseData.data.candlestick);
                }
            });
        }

        private static string BaseUrl()
        {
            return "https://public.bitbank.cc";
        }
    }
}