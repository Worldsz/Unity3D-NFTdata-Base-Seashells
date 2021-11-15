using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class OpenSea__10b57e6_singleassetApiModel
{
}
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class AssetContract
    {
        public string address { get; set; }
        public string asset_contract_type { get; set; }
        public DateTime created_date { get; set; }
        public string name { get; set; }
        public string nft_version { get; set; }
        public object opensea_version { get; set; }
        public int owner { get; set; }
        public string schema_name { get; set; }
        public string symbol { get; set; }
        public string total_supply { get; set; }
        public string description { get; set; }
        public string external_link { get; set; }
        public string image_url { get; set; }
        public bool default_to_fiat { get; set; }
        public int dev_buyer_fee_basis_points { get; set; }
        public int dev_seller_fee_basis_points { get; set; }
        public bool only_proxied_transfers { get; set; }
        public int opensea_buyer_fee_basis_points { get; set; }
        public int opensea_seller_fee_basis_points { get; set; }
        public int buyer_fee_basis_points { get; set; }
        public int seller_fee_basis_points { get; set; }
        public string payout_address { get; set; }
    }

    public class PaymentToken
    {
        public int id { get; set; }
        public string symbol { get; set; }
        public string address { get; set; }
        public string image_url { get; set; }
        public string name { get; set; }
        public int decimals { get; set; }
        public double eth_price { get; set; }
        public double usd_price { get; set; }
    }

    public class PrimaryAssetContract
    {
        public string address { get; set; }
        public string asset_contract_type { get; set; }
        public DateTime created_date { get; set; }
        public string name { get; set; }
        public string nft_version { get; set; }
        public object opensea_version { get; set; }
        public int owner { get; set; }
        public string schema_name { get; set; }
        public string symbol { get; set; }
        public string total_supply { get; set; }
        public string description { get; set; }
        public string external_link { get; set; }
        public string image_url { get; set; }
        public bool default_to_fiat { get; set; }
        public int dev_buyer_fee_basis_points { get; set; }
        public int dev_seller_fee_basis_points { get; set; }
        public bool only_proxied_transfers { get; set; }
        public int opensea_buyer_fee_basis_points { get; set; }
        public int opensea_seller_fee_basis_points { get; set; }
        public int buyer_fee_basis_points { get; set; }
        public int seller_fee_basis_points { get; set; }
        public string payout_address { get; set; }
    }

    public class Traits
    {
        public string trait_type { get; set; }
        public string value { get; set; }
        public object display_type { get; set; }
        public object max_value { get; set; }
        public int trait_count { get; set; }
        public object order { get; set; }
    }

    public class Stats
    {
        public double one_day_volume { get; set; }
        public double one_day_change { get; set; }
        public string one_day_sales { get; set; }
        public double one_day_average_price { get; set; }
        public string seven_day_volume { get; set; }
        public string seven_day_change { get; set; }
        public string seven_day_sales { get; set; }
        public double seven_day_average_price { get; set; }
        public double thirty_day_volume { get; set; }
        public string thirty_day_change { get; set; }
        public string thirty_day_sales { get; set; }
        public double thirty_day_average_price { get; set; }
        public double total_volume { get; set; }
        public string total_sales { get; set; }
        public string total_supply { get; set; }
        public string count { get; set; }
        public string num_owners { get; set; }
        public double average_price { get; set; }
        public string num_reports { get; set; }
        public double market_cap { get; set; }
        public double floor_price { get; set; }
    }

    public class DisplayData
    {
        public string card_display_style { get; set; }
    }

    public class Collection
    {
        public List<PaymentToken> payment_tokens { get; set; }
        public List<PrimaryAssetContract> primary_asset_contracts { get; set; }
        public Traits traits { get; set; }
        public Stats stats { get; set; }
        public string banner_image_url { get; set; }
        public object chat_url { get; set; }
        public DateTime created_date { get; set; }
        public bool default_to_fiat { get; set; }
        public string description { get; set; }
        public string dev_buyer_fee_basis_points { get; set; }
        public string dev_seller_fee_basis_points { get; set; }
        public object discord_url { get; set; }
        public DisplayData display_data { get; set; }
        public string external_url { get; set; }
        public bool featured { get; set; }
        public string featured_image_url { get; set; }
        public bool hidden { get; set; }
        public string safelist_request_status { get; set; }
        public string image_url { get; set; }
        public bool is_subject_to_whitelist { get; set; }
        public string large_image_url { get; set; }
        public object medium_username { get; set; }
        public string name { get; set; }
        public bool only_proxied_transfers { get; set; }
        public string opensea_buyer_fee_basis_points { get; set; }
        public string opensea_seller_fee_basis_points { get; set; }
        public string payout_address { get; set; }
        public bool require_email { get; set; }
        public object short_description { get; set; }
        public string slug { get; set; }
        public string telegram_url { get; set; }
        public string twitter_username { get; set; }
        public object instagram_username { get; set; }
        public object wiki_url { get; set; }
    }

    public class User
    {
        public object username { get; set; }
    }

    public class Owner
    {
        public User user { get; set; }
        public string profile_img_url { get; set; }
        public string address { get; set; }
        public string config { get; set; }
    }

    public class Creator
    {
        public object user { get; set; }
        public string profile_img_url { get; set; }
        public string address { get; set; }
        public string config { get; set; }
    }

    public class Asset
    {
        public string token_id { get; set; }
        public int decimals { get; set; }
        public string id { get; set; }
        public string address { get; set; }
    }

    public class PaymentToken2
    {
        public int id { get; set; }
        public string symbol { get; set; }
        public string address { get; set; }
        public string image_url { get; set; }
        public string name { get; set; }
        public int decimals { get; set; }
        public string eth_price { get; set; }
        public string usd_price { get; set; }
    }

    public class FromAccount
    {
        public User user { get; set; }
        public string profile_img_url { get; set; }
        public string address { get; set; }
        public string config { get; set; }
    }

    public class ToAccount
    {
        public User user { get; set; }
        public string profile_img_url { get; set; }
        public string address { get; set; }
        public string config { get; set; }
    }

    public class Transaction
    {
        public string block_hash { get; set; }
        public string block_number { get; set; }
        public FromAccount from_account { get; set; }
        public int id { get; set; }
        public DateTime timestamp { get; set; }
        public ToAccount to_account { get; set; }
        public string transaction_hash { get; set; }
        public string transaction_index { get; set; }
    }

    public class LastSale
    {
        public Asset asset { get; set; }
        public object asset_bundle { get; set; }
        public string event_type { get; set; }
        public DateTime event_timestamp { get; set; }
        public object auction_type { get; set; }
        public string total_price { get; set; }
        public PaymentToken payment_token { get; set; }
        public Transaction transaction { get; set; }
        public DateTime created_date { get; set; }
        public string quantity { get; set; }
    }

    public class Metadata
    {
        public Asset asset { get; set; }
        public string schema { get; set; }
        public string referrerAddress { get; set; }
    }

    public class Maker
    {
        public object user { get; set; }
        public string profile_img_url { get; set; }
        public string address { get; set; }
        public string config { get; set; }
    }

    public class Taker
    {
        public User user { get; set; }
        public string profile_img_url { get; set; }
        public string address { get; set; }
        public string config { get; set; }
    }

    public class FeeRecipient
    {
        public User user { get; set; }
        public string profile_img_url { get; set; }
        public string address { get; set; }
        public string config { get; set; }
    }

    public class PaymentTokenContract
    {
        public int id { get; set; }
        public string symbol { get; set; }
        public string address { get; set; }
        public string image_url { get; set; }
        public string name { get; set; }
        public int decimals { get; set; }
        public string eth_price { get; set; }
        public string usd_price { get; set; }
    }

    public class Order
    {
        public DateTime created_date { get; set; }
        public DateTime closing_date { get; set; }
        public bool closing_extendable { get; set; }
        public int expiration_time { get; set; }
        public int listing_time { get; set; }
        public string order_hash { get; set; }
        public Metadata metadata { get; set; }
        public string exchange { get; set; }
        public Maker maker { get; set; }
        public Taker taker { get; set; }
        public string current_price { get; set; }
        public string current_bounty { get; set; }
        public string bounty_multiple { get; set; }
        public string maker_relayer_fee { get; set; }
        public string taker_relayer_fee { get; set; }
        public string maker_protocol_fee { get; set; }
        public string taker_protocol_fee { get; set; }
        public string maker_referrer_fee { get; set; }
        public FeeRecipient fee_recipient { get; set; }
        public int fee_method { get; set; }
        public int side { get; set; }
        public int sale_kind { get; set; }
        public string target { get; set; }
        public int how_to_call { get; set; }
        public string calldata { get; set; }
        public string replacement_pattern { get; set; }
        public string static_target { get; set; }
        public string static_extradata { get; set; }
        public string payment_token { get; set; }
        public PaymentTokenContract payment_token_contract { get; set; }
        public string base_price { get; set; }
        public string extra { get; set; }
        public string quantity { get; set; }
        public string salt { get; set; }
        public int v { get; set; }
        public string r { get; set; }
        public string s { get; set; }
        public bool approved_on_chain { get; set; }
        public bool cancelled { get; set; }
        public bool finalized { get; set; }
        public bool marked_invalid { get; set; }
        public string prefixed_hash { get; set; }
    }

    public class TopOwnership
    {
        public Owner owner { get; set; }
        public string quantity { get; set; }
    }

    public class Root
    {
        public int id { get; set; }
        public string token_id { get; set; }
        public int num_sales { get; set; }
        public object background_color { get; set; }
        public string image_url { get; set; }
        public string image_preview_url { get; set; }
        public string image_thumbnail_url { get; set; }
        public string image_original_url { get; set; }
        public object animation_url { get; set; }
        public object animation_original_url { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public object external_link { get; set; }
        public AssetContract asset_contract { get; set; }
        public string permalink { get; set; }
        public Collection collection { get; set; }
        public int decimals { get; set; }
        public string token_metadata { get; set; }
        public Owner owner { get; set; }
        public object sell_orders { get; set; }
        public Creator creator { get; set; }
        public List<Traits> traits { get; set; }
        public LastSale last_sale { get; set; }
        public object top_bid { get; set; }
        public object listing_date { get; set; }
        public bool is_presale { get; set; }
        public object transfer_fee_payment_token { get; set; }
        public object transfer_fee { get; set; }
        public List<object> related_assets { get; set; }
        public List<Order> orders { get; set; }
        public List<object> auctions { get; set; }
        public bool supports_wyvern { get; set; }
        public List<TopOwnership> top_ownerships { get; set; }
        public object ownership { get; set; }
        public object highest_buyer_commitment { get; set; }
    }

