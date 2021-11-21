using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NFTEnvironmentHandler : MonoBehaviour
{
    [SerializeField] private Material[] modelmaterial;
    [SerializeField] private NFTModel NftModel;
    [Space(10)] 
    [SerializeField] private GameObject Lobster;
    [SerializeField] private GameObject Langoustine;
    [SerializeField] private GameObject Shrimp;
    [SerializeField] private GameObject Mudcrab;
    [Space(10)] [SerializeField] private Material BasefxMat;
    
    public void updateNFTLooks()
    {
        foreach(Material m in modelmaterial)
        {
            m.mainTexture = NftModel.image;
        }
        
        BasefxMat.SetTexture("_DetailAlbedoMap", NftModel.image);
        
        
        ChooseSSpecies();
    }

    public void DisableAllModels()
    {
        Lobster.SetActive(false);
        Langoustine.SetActive(false);
        Shrimp.SetActive(false);
        Mudcrab.SetActive(false);
    }
    
    void ChooseSSpecies()
    {
        if (NftModel.species == "Lobster")
        {
            Lobster.SetActive(true);
        }
        else if (NftModel.species == "Langoustine")
        {
            Langoustine.SetActive(true);
        }
        else if (NftModel.species == "Shrimp")
        {
            Shrimp.SetActive(true);
        }
        else if (NftModel.species == "Mudcrab")
        {
            Mudcrab.SetActive(true);
        }
    }                             
}
