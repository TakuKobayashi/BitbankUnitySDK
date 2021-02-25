using System.Collections.Generic;

namespace BitbankUnitySDK
{
    public class DepthData {
        public List<List<string>> asks; // array of [price, amount]
        public List<List<string>> bids; // array of [price, amount]
    }
}
