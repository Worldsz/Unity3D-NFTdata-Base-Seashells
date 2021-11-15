using System;
using System.Collections.Generic;
//www.embracingearth.space

//Referring https://docs.nftport.xyz/docs/nftport/b3A6MjAzNDUzNTM-retrieve-nft-details
namespace NFTPort
{
       
    [Serializable]
    public class NFTPort_NftModel 
    {
    }
    
    [Serializable]
    public class Attribute
    {
        public string trait_type;
        public string value;
    }
    [Serializable]
    public class Metadata
        {
            public List<Attribute> attributes;
            public string compiler;
            public long date;
            public string description;
            public string dna;
            public int edition;
            public string image;
            public string name;
        }
        [Serializable]
        public class FileInformation
        {
            public int height;
            public int width;
            public int file_size;
        }
        [Serializable]
        public class Nft
        {
            public string chain;
            public string contract_address;
            public string token_id;
            public string metadata_url;
            public Metadata metadata;
            public FileInformation file_information;
            public string file_url;
            public string cached_file_url;
            public object mint_date;
            public DateTime updated_date;
        }
        [Serializable]
        public class Contract
        {
            public string name;
            public string symbol;
            public string type;
        }
        [Serializable]
        public class Root
        {
            public string response;
            public Nft nft;
            public Contract contract;
        }

}
