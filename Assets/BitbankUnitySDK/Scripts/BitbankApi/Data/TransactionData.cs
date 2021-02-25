using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BitbankUnitySDK
{
    internal class TransactionParseData
    {
        public List<TransactionData> transactions;
    }

    public class TransactionData {
        public string transaction_id;
        public string side; // buy, sell
        public string price;
        public string amount;
        public long executed_at;
    }
}
