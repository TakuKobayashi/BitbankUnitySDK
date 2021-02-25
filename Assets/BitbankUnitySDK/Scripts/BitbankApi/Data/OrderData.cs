using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BitbankUnitySDK
{
    public class OrderData
    {
        public long order_id;
        public string pair;
        public string side; // buy or sell
        public string type; // limit or market
        public string start_amount;
        public string remaining_amount;
        public string executed_amount;
        public string price;
        public string average_price;
        public long ordered_at;
        public long? canceled_at;
        public string status; // UNFILLED, PARTIALLY_FILLED, FULLY_FILLED, CANCELED_UNFILLED, CANCELED_PARTIALLY_FILLED
    }
}
