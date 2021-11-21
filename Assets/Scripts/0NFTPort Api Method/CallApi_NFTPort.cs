using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using Newtonsoft.Json;
using UnityEngine.UI;

/*
 *Fetches details of an NFT via NFTPort API
 *refer https://docs.nftport.xyz/docs/nftport/b3A6MjAzNDUzNTM-retrieve-nft-details
 *
 * This example showcases implementation in Unity3D Game Engine for NFT properties via NFTPort api
 *
 * by sz.sahaj
 * www.embracingearth.space
 */



namespace NFTPort
{
    public class CallApi_NFTPort : MonoBehaviour
    {
        [SerializeField] private string APIWEB_URL = "https://api.nftport.xyz/v0/nfts/";
        [SerializeField] private string NFTContract = "0x026224a2940bfe258d0dbe947919b62fe321f042";
        [SerializeField] private string NFTTokenID = "1111";
        [SerializeField] private string chain = "ethereum"; //"ethereum" or "polygon" 
        [SerializeField] private string NFTPortAuthorization = "acb9f52c-a320-44da-ab01-36c31815c159";

        public NFTPort.Root NFTPort_NFTModel;
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
            WEB_URL = APIWEB_URL + NFTContract + "/" + NFTTokenID + "?chain=" + chain;
            //WEB_URL = APIWEB_URL + NFTContract + "/" + "?chain=" + chain +"&include=metadata";
            return WEB_URL;
        }

        IEnumerator CallAPIProcess()
        {

            UnityWebRequest rq = UnityWebRequest.Get(WEB_URL);
            rq.SetRequestHeader("Content-Type", "application/json");
            rq.SetRequestHeader("Authorization", NFTPortAuthorization);

            {
                yield return rq.SendWebRequest();

                string jsonResult = System.Text.Encoding.UTF8.GetString(rq.downloadHandler.data);


                Debug.Log(jsonResult);
                NFTPort_NFTModel = JsonConvert.DeserializeObject<NFTPort.Root>(jsonResult);
                if (NFTPort_NFTModel == null)
                {
                    Debug.LogError($"Null data. Response code: {rq.responseCode}.");
                    yield break;
                }
            }

            
            StartCoroutine(GetTexture(NFTPort_NFTModel.nft.file_url));
        }
        
        IEnumerator GetTexture(string ipfsurl)
        {

            string fullimageurl = "https://cloudflare-ipfs.com/ipfs/" + ipfsurl.Replace("ipfs://", "");
            Debug.Log(fullimageurl);
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
            //example function showing how to access data from model , refer NFTPort_NftModel.cs
            imagecanvas.texture = NFTImage;
            Debug.Log(NFTPort_NFTModel.nft.metadata.attributes.Count); //number of properties/traits of NFT
            Debug.Log(NFTPort_NFTModel.nft.metadata.attributes[0].trait_type); //first trait name
            Debug.Log(NFTPort_NFTModel.nft.metadata.attributes[0].value); // first trait value
            Debug.Log(NFTPort_NFTModel.nft.metadata.description); // Nft description
        }
    }
}