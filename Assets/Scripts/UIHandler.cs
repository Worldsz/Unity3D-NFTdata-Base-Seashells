using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

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

    [Space(10)]
    [SerializeField] private TMP_Text _datatext1;
    [SerializeField] private TMP_Text _datatext2;
    [SerializeField] private TMP_Text _datatext3;
    [SerializeField] private TMP_Text _datatext4;
    [SerializeField] private TMP_Text _datatext5;
    [SerializeField] private TMP_Text _datatext6;
    [SerializeField] private TMP_Text _datatext7;
    [SerializeField] private TMP_Text _datatext8;
    [SerializeField] private TMP_Text _datatext9;
    [SerializeField] private TMP_Text _datatext10;
    [SerializeField] private TMP_Text _datatext11;
    [SerializeField] private TMP_Text _datatext12;


    [SerializeField] private UnityEvent UIUpdatedone;
    public void IDInput()
    {
        NftModel.id = Int32.Parse(_idinput.text);
        _dataparsing.UpdateNFTModel();
    }
    
    public void ClearUI()
    {
        name.text = "";
        background.text = "";
        deepwaterglare.text = "";
        species.text = "";
        gene.text = "";
        mood.text = "";
        image.texture = null;
        _datatext1.text = "";
        _datatext2.text = "";
        _datatext3.text = "";
        _datatext4.text = "";
        _datatext5.text = "";
        
        
    }

    public void UpdateAllui()
    {
        UpdateNFTPropertiesUI();
        UpdateDataPropertiesUI();
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

    private void UpdateDataPropertiesUI()
    {
        _datatext1.text = NftModel._1;
        _datatext2.text = NftModel._2;
        _datatext3.text = NftModel._3;
        _datatext4.text = NftModel._4;
        _datatext5.text = NftModel._5;
        _datatext6.text = NftModel._6;
        _datatext7.text = NftModel._7;
        _datatext8.text = NftModel._8;
        _datatext9.text = NftModel._9;
        _datatext10.text = NftModel._10;
        _datatext11.text = NftModel._11;
        _datatext12.text = NftModel._12;
        
        
        UIUpdatedone.Invoke();
    }
}
