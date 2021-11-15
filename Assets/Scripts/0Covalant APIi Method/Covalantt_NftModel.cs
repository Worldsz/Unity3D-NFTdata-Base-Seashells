using System;
using System.Collections.Generic;
//www.embracingearth.space

//Referring https://www.covalenthq.com/docs/api/#/0/Class-A/Get-all-contract-metadata/lng=en
namespace Covalant
{
    [Serializable]
    public class Covalant_NFTModel
    {
    }
    [Serializable]
    public class Attribute
    {
        public string trait_type;
        public string value;
    }
    [Serializable]
    public class ExternalData
    {
        public string name;
        public string description;
        public string image;
        public string image_256;
        public string image_512;
        public string image_1024;
        public object animation_url;
        public object external_url;
        public List<Attribute> attributes;
        public object owner;
    }
    [Serializable]
    public class NftData
    {
        public string token_id;
        public string token_balance;
        public string token_url;
        public List<string> supports_erc;
        public object token_price_wei;
        public object token_quote_rate_eth;
        public string original_owner;
        public ExternalData external_data;
        public string owner;
        public string owner_address;
        public bool burned;
    }
    [Serializable]
    public class Item
    {
        public int contract_decimals;
        public string contract_name;
        public string contract_ticker_symbol;
        public string contract_address;
        public List<string> supports_erc;
        public string logo_url;
        public object last_transferred_at;
        public string type;
        public object balance;
        public object balance_24h;
        public object quote_rate;
        public object quote_rate_24h;
        public object quote;
        public object quote_24h;
        public List<NftData> nft_data;
    }
    [Serializable]
    public class Data
    {
        public string updated_at;
        public List<Item> items;
        public object pagination;
    }
    [Serializable]
    public class Root
    {
        public Data data;
        public bool error;
        public object error_message;
        public object error_code;
    }


}
