using UnityEngine;
using UnityEngine.UI;

namespace BitbankUnitySDK
{
    public class ApiKeyForm : MonoBehaviour
    {
        [SerializeField] private InputField apiKeyInputField;
        [SerializeField] private InputField secretInputField;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void OnSaveButtonClicked()
        {
            ApikeyPrefs apiKeyPref = new ApikeyPrefs();
            apiKeyPref.apikey = apiKeyInputField.text;
            apiKeyPref.secret = secretInputField.text;
            ApikeyPrefs.WriteFile(apiKeyPref);
        }
    }
}