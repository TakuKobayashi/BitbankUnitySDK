using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BitbankUnitySDK
{
    public class SpotPairData {
        public string name;
        public string base_asset;
        public string quote_asset;
        public string maker_fee_rate_base;
        public string taker_fee_rate_base;
        public string maker_fee_rate_quote;
        public string taker_fee_rate_quote;
        public string unit_amount;
        public string limit_max_amount;
        public string market_max_amount;
        public string market_allowance_rate;
        public int price_digits;
        public int amount_digits;
        public bool is_enabled;
        public bool stop_order;
        public bool stop_order_and_cancel;
    }
}
