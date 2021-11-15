using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using Newtonsoft.Json;
using UnityEngine.UI;

/*
 *Fetches details of an NFT via Covalant API
 *refer https://www.covalenthq.com/docs/api/#/0/Class-A/Get-all-contract-metadata/lng=en
 *
 * This example showcases implementation in Unity3D Game Engine for NFT properties via Covalant^ api
 *
 * by sz.sahaj
 * www.embracingearth.space
 */



namespace Covalant
{
    public class CallApi_Covalant : MonoBehaviour
    {
        [SerializeField] private string APIWEB_URL = "https://api.covalenthq.com/v1/1/tokens/";
        [SerializeField] private string NFTContract = "0x026224a2940bfe258d0dbe947919b62fe321f042";
        [SerializeField] private string NFTTokenID = "1111";
        [SerializeField] private string CovalantAuthorization = "ckey_a14b1c7b84b74099bd59fffcd5f";

        public Covalant.Root Covalant_NFTModel;
        private string WEB_URL;

        public Texture NFTImage;
        [SerializeField] private RawImage imagecanvas;
        void Start()
        {
            WEB_URL = BuildUrl();
            StartCoroutine(CallAPIProcess());
        }

        string BuildUrl()
        {
            WEB_URL = APIWEB_URL + NFTContract + "/nft_metadata/" + NFTTokenID + "/?quote-currency=USD&format=JSON&key=" + CovalantAuthorization;

            return WEB_URL;
        }

        IEnumerator CallAPIProcess()
        {

            UnityWebRequest rq = UnityWebRequest.Get(WEB_URL);
          //  rq.SetRequestHeader("Content-Type", "application/json");
          //  rq.SetRequestHeader("Authorization", CovalantAuthorization);

            {
                yield return rq.SendWebRequest();

                string jsonResult = System.Text.Encoding.UTF8.GetString(rq.downloadHandler.data);


                Debug.Log(jsonResult);
                Covalant_NFTModel = JsonConvert.DeserializeObject<Covalant.Root>(jsonResult);
                if (Covalant_NFTModel == null)
                {
                    Debug.LogError($"Null data. Response code: {rq.responseCode}.");
                    yield break;
                }
            }

            StartCoroutine(GetTexture(Covalant_NFTModel.data.items[0].nft_data[0].external_data.image_1024));
        }
        
        IEnumerator GetTexture(string fullimageurl) {
            UnityWebRequest www = UnityWebRequestTexture.GetTexture(fullimageurl);
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success) {
                Debug.Log(www.error);
            }
            else {
                NFTImage = ((DownloadHandlerTexture)www.downloadHandler).texture;
            }

            Debug.Log("NFT Data Fetch Complete");
            useNFTData();

        }


        void useNFTData()
        {
            //example function showing how to access data from model , refer Covalant_NFTModel.cs
            //you can assign these values in a player properties script for ease of access according to your game requirements
            
            imagecanvas.texture = NFTImage;
            Debug.Log(Covalant_NFTModel.data.items[0].nft_data[0].external_data.attributes.Count); //number of properties/traits of NFT
            Debug.Log(Covalant_NFTModel.data.items[0].nft_data[0].external_data.attributes[0].trait_type); //first trait name
            Debug.Log(Covalant_NFTModel.data.items[0].nft_data[0].external_data.attributes[0].value); // first trait value
            Debug.Log(Covalant_NFTModel.data.items[0].nft_data[0].owner); // Owner of NFT
        }
    }
}