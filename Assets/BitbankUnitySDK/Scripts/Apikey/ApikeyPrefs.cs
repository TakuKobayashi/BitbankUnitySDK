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

        public string access_token;
        public string token_type;
        public string refresh_token;
        public string scope;
        public long expires_in;
        public long created_at;

        public DateTime CreatedAtDateTime()
        {
            DateTime UNIX_EPOCH = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            return UNIX_EPOCH.AddSeconds(created_at).ToLocalTime();
        }

        public DateTime ExpiresAtDateTime()
        {
            DateTime createdAt = CreatedAtDateTime();
            return createdAt.AddSeconds(expires_in).ToLocalTime();
        }

        public bool IsExired()
        {
            return DateTime.Now > ExpiresAtDateTime();
        }

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
