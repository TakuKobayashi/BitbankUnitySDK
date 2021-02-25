using System;
using System.Text;
using System.IO;
using UnityEngine;
using UnityCipher;

namespace BitbankUnitySDK
{
    public class ApikeyPrefs
    {
        private const string EncyptPassword = "+jW:f`4?6p)RG^Qq6M|g0Nh2r|jGke)k";

        public string apikey;
        public string secret;

        public static void WriteFile(ApikeyPrefs account)
        {
            string accountJson = JsonUtility.ToJson(account);
            byte[] encryptedBinary = RijndaelEncryption.Encrypt(Encoding.ASCII.GetBytes(accountJson), EncyptPassword);
            File.WriteAllBytes(RecordFilePath, encryptedBinary);
        }

        public static ApikeyPrefs LoadFromFile()
        {
            byte[] encryptedBinary = File.ReadAllBytes(RecordFilePath);
            byte[] accountBinary = RijndaelEncryption.Decrypt(encryptedBinary, EncyptPassword);
            return JsonUtility.FromJson<ApikeyPrefs>(Encoding.ASCII.GetString(accountBinary));
        }

        public static bool ExistsAccount
        {
            get
            {
                return File.Exists(RecordFilePath);
            }
        }

        public static void DeleteAccount()
        {
            if (ExistsAccount)
            {
                File.Delete(RecordFilePath);
            }
        }

        private static string RecordFilePath
        {
            get
            {
                return Path.Combine(UnityEngine.Application.persistentDataPath, "apikey");
            }
        }
    }
}
