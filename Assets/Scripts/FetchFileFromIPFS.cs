using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using System.IO;
using UnityEngine.Events;

/* //Fetches csv file from IPFS - Unity3D C#.
 The InterPlanetary File System is a protocol and peer-to-peer network 
 for storing and sharing data in a distributed file system. IPFS uses 
 content-addressing to uniquely identify each file in a global namespace 
 connecting all computing devices.
 
 You can’t edit a file once it’s on IPFS. It's great to store and 
 read data which shouldn't be tampered with. 
 
 In this iteration its used to create a tamperproof NFT properties database.
 web3.storage
 */

//sz www.embracingearth.space 

public class FetchFileFromIPFS : MonoBehaviour
{
    [SerializeField] private string _fileIPFSHash = "bafybeiczdp52pebdgxzcznmqumtvg2oxf3awcfzabzmmvnhhlfxez45xzu/Copy%20of%20LOBS%20Overall%20Ranking%20-%20Changed%20-%20full_collection.csv";


    [SerializeField] private DataParsing _dataparsing;
    [SerializeField] private UnityEvent OnFetchDatabaseComplete;

    private string ipfsURL;
    string file_name;

    void Awake()
    {
        ipfsURL = "https://cloudflare-ipfs.com/ipfs/" + _fileIPFSHash;
        StartCoroutine(FetchCSVIPFSFile());
    }

    IEnumerator FetchCSVIPFSFile()
    {

        using (UnityWebRequest www = UnityWebRequest.Get(ipfsURL)) //webrequest to fetch file
        {
            yield return www.Send();
            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                //save csv from ipfs
                string savePath = string.Format("{0}/{1}.csv", Application.persistentDataPath, file_name);
                //Debug.Log(savePath);
                System.IO.File.WriteAllText(savePath, www.downloadHandler.text);

                //readsaved_csv
                savePath = Application.persistentDataPath + "/.csv";
                if (File.Exists(savePath))
                {
                    byte[] m_bytes = File.ReadAllBytes(savePath);
                    string s = System.Text.Encoding.UTF8.GetString(m_bytes);

                   Debug.Log("Fetched Database from IPFS");
                   _dataparsing.PopulateData(s); 
                   OnFetchDatabaseComplete.Invoke();
                }
            }

           
        }
    }
    
}

