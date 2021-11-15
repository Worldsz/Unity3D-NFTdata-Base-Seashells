using System.Collections;
using UnityEngine;
using System;
using UnityEngine.Events;
using UnityEngine.Networking;

//sz //www.embracingeart.space
//Assings Data to Model according to CSV 
public class DataParsing : MonoBehaviour
{

    [SerializeField] private NFTModel NftModel;
    [SerializeField] private NFTEnvironmentHandler _nftEnvironmentHandler;
    [SerializeField] private UIHandler _uiHandler;
    [SerializeField] private UnityEvent BeforeUpdateNFTModel;
    
    
    string[] data;
   //public TextAsset textassetdata; //for local method.
   
    public void PopulateData(string csvDataStrng)
    {
        //CSV table in an array where token id is equal to line number.
        data = csvDataStrng.Split(new string[] {",", "\n"}, StringSplitOptions.None);
        
        //for local csv loads-
        //data = textassetdata.text.Split(new string[] {",", "\n"}, StringSplitOptions.None);
        
        
        //PopulateNFTModelProp();
    }

    public void UpdateNFTModel()
    {
        BeforeUpdateNFTModel.Invoke();
        PopulateNFTModelProp();
    }

    void PopulateNFTModelProp()
    {
        //According to csv structure where token id is equal to line number>
        NftModel.name = data[37* (NftModel.id) + 4];
        NftModel.imageurl = data[37* (NftModel.id) + 6];
        NftModel.background = data[37* (NftModel.id) + 7];
        NftModel.deepwaterglare = data[37* (NftModel.id) + 8];
        NftModel.species =  data[37* (NftModel.id) + 9]; //Get Species
        NftModel.gene =  data[37* (NftModel.id) + 10];
        NftModel.mood =  data[37* (NftModel.id) + 11];

        FetchNFTTexturefromipfs();
    }
    
    private void FetchNFTTexturefromipfs()
    {
        var fullimageurl = "https://cloudflare-ipfs.com/" + NftModel.imageurl;
        StopAllCoroutines();
        StartCoroutine(GetTexture(fullimageurl));

    }
    
    IEnumerator GetTexture(string fullimageurl) {
        UnityWebRequest www = UnityWebRequestTexture.GetTexture(fullimageurl);
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success) {
            Debug.Log(www.error);
        }
        else {
            NftModel.image = ((DownloadHandlerTexture)www.downloadHandler).texture;
   
            Debug.Log("NFTData Fetch Complete");
            NFTDataFetchComplete();
        }
        
    }

    void NFTDataFetchComplete()
    {
        _nftEnvironmentHandler.updateNFTLooks();
        _uiHandler.UpdateNFTPropertiesUI();
    }
    
    
}
