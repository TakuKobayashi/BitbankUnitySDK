using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BitbankUnitySDK
{
    public class ApiResponseTemplate<T>
    {
        public T data;
        public int success;
    }
}