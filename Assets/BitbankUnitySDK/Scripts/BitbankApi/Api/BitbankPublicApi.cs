using System;
using System.Collections.Generic;
using UnityEngine;

namespace BitbankUnitySDK
{
    public class BitbankPublicApi
    {
        public static void Depth(string pair, Action<DepthData> onSuccess = null)
        {
            HTTPManager.Instance.Request(BaseUrl() + string.Format("/{0}/depth", pair), onSuccess: (dh) =>
            {
                Debug.Log(dh.text);
                ApiResponseTemplate<DepthData> responseData = JsonUtility.FromJson<ApiResponseTemplate<DepthData>>(dh.text);
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
                ApiResponseTemplate<TransactionParseData> responseData = JsonUtility.FromJson<ApiResponseTemplate<TransactionParseData>>(dh.text);
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
                ApiResponseTemplate<TickerData> responseData = JsonUtility.FromJson<ApiResponseTemplate<TickerData>>(dh.text);
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
                ApiResponseTemplate<CandlestickParseData> responseData = JsonUtility.FromJson<ApiResponseTemplate<CandlestickParseData>>(dh.text);
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