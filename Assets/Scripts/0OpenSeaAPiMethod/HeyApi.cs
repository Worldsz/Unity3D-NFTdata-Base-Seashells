using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;
using Newtonsoft.Json;
using UnityEngine.UI;

//fetching NFT data , traits images etc from OpenSea API.
//sz embracingearth.space

public class HeyApi : MonoBehaviour
{
    [SerializeField] string BaseUrl = "https://api.opensea.io/api/v1/asset/0x026224a2940bfe258d0dbe947919b62fe321f042/";
    public int tokenid;
    private string WEB_URL;
    public string str1;
    public string str2;
    public Text _text;
    void Start()
    {
        Hi();
    }
    
    void OnEnable()
    {
        Hi();
    }

    void Hi()
    {
        WEB_URL = BuildUrl();
        StopAllCoroutines();
        StartCoroutine(CallAPIProcess());
    }
    

    string BuildUrl()
    {
        var Finalurl = BaseUrl + tokenid.ToString() + "/";
        return Finalurl;
    }

    IEnumerator CallAPIProcess()
    {
        UnityWebRequest rq = UnityWebRequest.Get(WEB_URL);
        {
            yield return rq.SendWebRequest();

            // rq.downloadHandler.text;
            //  Debug.Log(rq.downloadHandler.text);
            string jsonResult = System.Text.Encoding.UTF8.GetString(rq.downloadHandler.data);
            Debug.Log(jsonResult);
            var _10b57e6 = JsonConvert.DeserializeObject<Root>(jsonResult);
            if (_10b57e6 == null) { 
                Debug.LogError($"Null data. Response code: {rq.responseCode}.");
                yield break;
            }

            str1 = _10b57e6.traits[1].trait_type;
            str2 = _10b57e6.traits[1].value;
            _text.text = str2;

        }  
    }
}
