using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BitbankUnitySDK
{
    public class RequestWithdrawalData : WithdrawalAccountData
    {
        public string asset;
        public string account_uuid;
        public long amount;
        public float fee;
        public string txid;
        public string status; //  CONFIRMING, EXAMINING, SENDING, DONE, REJECTED, CANCELED, CONFIRM_TIMEOUT
        public long requested_at;
    }
}