using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIHandler : MonoBehaviour
{
    [SerializeField] private TMP_InputField _idinput;
    [SerializeField] private NFTModel NftModel;
    [SerializeField] private DataParsing _dataparsing;

    [SerializeField] private TMP_Text name;
    [SerializeField] private TMP_Text background;
    [SerializeField] private TMP_Text deepwaterglare;
    [SerializeField] private TMP_Text species;
    [SerializeField] private TMP_Text gene;
    [SerializeField] private TMP_Text mood;
    [SerializeField] private RawImage image;
    public void IDInput()
    {
        NftModel.id = Int32.Parse(_idinput.text);
        _dataparsing.UpdateNFTModel();
    }
    
    
    public void UpdateNFTPropertiesUI()
    {
        name.text = NftModel.name;
        background.text = NftModel.background;
        deepwaterglare.text = NftModel.deepwaterglare;
        species.text = NftModel.species;
        gene.text = NftModel.gene;
        mood.text = NftModel.mood;
        image.texture = NftModel.image;
    }
}
