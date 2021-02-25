namespace BitbankUnitySDK
{
    public class TradeData
    {
        public long trade_id;
        public string pair;
        public long order_id;
        public string side; // buy or sell
        public string type; // limit or market
        public string amount;
        public string price;
        public string maker_taker; // maker or taker
        public string fee_amount_base;
        public string fee_amount_quote;
        public long executed_at;
    }
}