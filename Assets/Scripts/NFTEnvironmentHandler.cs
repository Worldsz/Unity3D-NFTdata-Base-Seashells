using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFTEnvironmentHandler : MonoBehaviour
{
    [SerializeField] private Material[] modelmaterial;
    [SerializeField] private NFTModel NftModel;
    [Space(10)] 
    [SerializeField] private GameObject Lobster;
    [SerializeField] private GameObject Langoustine;
    [SerializeField] private GameObject Shrimp;
    [SerializeField] private GameObject Mudcrab;
    
    
    public void updateNFTLooks()
    {
        foreach(Material m in modelmaterial)
        {
            m.mainTexture = NftModel.image;
        }
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
