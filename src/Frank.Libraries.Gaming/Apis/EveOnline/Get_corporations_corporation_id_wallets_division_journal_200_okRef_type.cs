using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace EveOnlineApi;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public enum Get_corporations_corporation_id_wallets_division_journal_200_okRef_type
{
    [EnumMember(Value = @"acceleration_gate_fee")]
    Acceleration_gate_fee = 0,

    [EnumMember(Value = @"advertisement_listing_fee")]
    Advertisement_listing_fee = 1,

    [EnumMember(Value = @"agent_donation")]
    Agent_donation = 2,

    [EnumMember(Value = @"agent_location_services")]
    Agent_location_services = 3,

    [EnumMember(Value = @"agent_miscellaneous")]
    Agent_miscellaneous = 4,

    [EnumMember(Value = @"agent_mission_collateral_paid")]
    Agent_mission_collateral_paid = 5,

    [EnumMember(Value = @"agent_mission_collateral_refunded")]
    Agent_mission_collateral_refunded = 6,

    [EnumMember(Value = @"agent_mission_reward")]
    Agent_mission_reward = 7,

    [EnumMember(Value = @"agent_mission_reward_corporation_tax")]
    Agent_mission_reward_corporation_tax = 8,

    [EnumMember(Value = @"agent_mission_time_bonus_reward")]
    Agent_mission_time_bonus_reward = 9,

    [EnumMember(Value = @"agent_mission_time_bonus_reward_corporation_tax")]
    Agent_mission_time_bonus_reward_corporation_tax = 10,

    [EnumMember(Value = @"agent_security_services")]
    Agent_security_services = 11,

    [EnumMember(Value = @"agent_services_rendered")]
    Agent_services_rendered = 12,

    [EnumMember(Value = @"agents_preward")]
    Agents_preward = 13,

    [EnumMember(Value = @"alliance_maintainance_fee")]
    Alliance_maintainance_fee = 14,

    [EnumMember(Value = @"alliance_registration_fee")]
    Alliance_registration_fee = 15,

    [EnumMember(Value = @"asset_safety_recovery_tax")]
    Asset_safety_recovery_tax = 16,

    [EnumMember(Value = @"bounty")] Bounty = 17,

    [EnumMember(Value = @"bounty_prize")] Bounty_prize = 18,

    [EnumMember(Value = @"bounty_prize_corporation_tax")]
    Bounty_prize_corporation_tax = 19,

    [EnumMember(Value = @"bounty_prizes")] Bounty_prizes = 20,

    [EnumMember(Value = @"bounty_reimbursement")]
    Bounty_reimbursement = 21,

    [EnumMember(Value = @"bounty_surcharge")]
    Bounty_surcharge = 22,

    [EnumMember(Value = @"brokers_fee")] Brokers_fee = 23,

    [EnumMember(Value = @"clone_activation")]
    Clone_activation = 24,

    [EnumMember(Value = @"clone_transfer")]
    Clone_transfer = 25,

    [EnumMember(Value = @"contraband_fine")]
    Contraband_fine = 26,

    [EnumMember(Value = @"contract_auction_bid")]
    Contract_auction_bid = 27,

    [EnumMember(Value = @"contract_auction_bid_corp")]
    Contract_auction_bid_corp = 28,

    [EnumMember(Value = @"contract_auction_bid_refund")]
    Contract_auction_bid_refund = 29,

    [EnumMember(Value = @"contract_auction_sold")]
    Contract_auction_sold = 30,

    [EnumMember(Value = @"contract_brokers_fee")]
    Contract_brokers_fee = 31,

    [EnumMember(Value = @"contract_brokers_fee_corp")]
    Contract_brokers_fee_corp = 32,

    [EnumMember(Value = @"contract_collateral")]
    Contract_collateral = 33,

    [EnumMember(Value = @"contract_collateral_deposited_corp")]
    Contract_collateral_deposited_corp = 34,

    [EnumMember(Value = @"contract_collateral_payout")]
    Contract_collateral_payout = 35,

    [EnumMember(Value = @"contract_collateral_refund")]
    Contract_collateral_refund = 36,

    [EnumMember(Value = @"contract_deposit")]
    Contract_deposit = 37,

    [EnumMember(Value = @"contract_deposit_corp")]
    Contract_deposit_corp = 38,

    [EnumMember(Value = @"contract_deposit_refund")]
    Contract_deposit_refund = 39,

    [EnumMember(Value = @"contract_deposit_sales_tax")]
    Contract_deposit_sales_tax = 40,

    [EnumMember(Value = @"contract_price")]
    Contract_price = 41,

    [EnumMember(Value = @"contract_price_payment_corp")]
    Contract_price_payment_corp = 42,

    [EnumMember(Value = @"contract_reversal")]
    Contract_reversal = 43,

    [EnumMember(Value = @"contract_reward")]
    Contract_reward = 44,

    [EnumMember(Value = @"contract_reward_deposited")]
    Contract_reward_deposited = 45,

    [EnumMember(Value = @"contract_reward_deposited_corp")]
    Contract_reward_deposited_corp = 46,

    [EnumMember(Value = @"contract_reward_refund")]
    Contract_reward_refund = 47,

    [EnumMember(Value = @"contract_sales_tax")]
    Contract_sales_tax = 48,

    [EnumMember(Value = @"copying")] Copying = 49,

    [EnumMember(Value = @"corporate_reward_payout")]
    Corporate_reward_payout = 50,

    [EnumMember(Value = @"corporate_reward_tax")]
    Corporate_reward_tax = 51,

    [EnumMember(Value = @"corporation_account_withdrawal")]
    Corporation_account_withdrawal = 52,

    [EnumMember(Value = @"corporation_bulk_payment")]
    Corporation_bulk_payment = 53,

    [EnumMember(Value = @"corporation_dividend_payment")]
    Corporation_dividend_payment = 54,

    [EnumMember(Value = @"corporation_liquidation")]
    Corporation_liquidation = 55,

    [EnumMember(Value = @"corporation_logo_change_cost")]
    Corporation_logo_change_cost = 56,

    [EnumMember(Value = @"corporation_payment")]
    Corporation_payment = 57,

    [EnumMember(Value = @"corporation_registration_fee")]
    Corporation_registration_fee = 58,

    [EnumMember(Value = @"courier_mission_escrow")]
    Courier_mission_escrow = 59,

    [EnumMember(Value = @"cspa")] Cspa = 60,

    [EnumMember(Value = @"cspaofflinerefund")]
    Cspaofflinerefund = 61,

    [EnumMember(Value = @"daily_challenge_reward")]
    Daily_challenge_reward = 62,

    [EnumMember(Value = @"datacore_fee")] Datacore_fee = 63,

    [EnumMember(Value = @"dna_modification_fee")]
    Dna_modification_fee = 64,

    [EnumMember(Value = @"docking_fee")] Docking_fee = 65,

    [EnumMember(Value = @"duel_wager_escrow")]
    Duel_wager_escrow = 66,

    [EnumMember(Value = @"duel_wager_payment")]
    Duel_wager_payment = 67,

    [EnumMember(Value = @"duel_wager_refund")]
    Duel_wager_refund = 68,

    [EnumMember(Value = @"ess_escrow_transfer")]
    Ess_escrow_transfer = 69,

    [EnumMember(Value = @"external_trade_delivery")]
    External_trade_delivery = 70,

    [EnumMember(Value = @"external_trade_freeze")]
    External_trade_freeze = 71,

    [EnumMember(Value = @"external_trade_thaw")]
    External_trade_thaw = 72,

    [EnumMember(Value = @"factory_slot_rental_fee")]
    Factory_slot_rental_fee = 73,

    [EnumMember(Value = @"flux_payout")] Flux_payout = 74,

    [EnumMember(Value = @"flux_tax")] Flux_tax = 75,

    [EnumMember(Value = @"flux_ticket_repayment")]
    Flux_ticket_repayment = 76,

    [EnumMember(Value = @"flux_ticket_sale")]
    Flux_ticket_sale = 77,

    [EnumMember(Value = @"gm_cash_transfer")]
    Gm_cash_transfer = 78,

    [EnumMember(Value = @"industry_job_tax")]
    Industry_job_tax = 79,

    [EnumMember(Value = @"infrastructure_hub_maintenance")]
    Infrastructure_hub_maintenance = 80,

    [EnumMember(Value = @"inheritance")] Inheritance = 81,

    [EnumMember(Value = @"insurance")] Insurance = 82,

    [EnumMember(Value = @"item_trader_payment")]
    Item_trader_payment = 83,

    [EnumMember(Value = @"jump_clone_activation_fee")]
    Jump_clone_activation_fee = 84,

    [EnumMember(Value = @"jump_clone_installation_fee")]
    Jump_clone_installation_fee = 85,

    [EnumMember(Value = @"kill_right_fee")]
    Kill_right_fee = 86,

    [EnumMember(Value = @"lp_store")] Lp_store = 87,

    [EnumMember(Value = @"manufacturing")] Manufacturing = 88,

    [EnumMember(Value = @"market_escrow")] Market_escrow = 89,

    [EnumMember(Value = @"market_fine_paid")]
    Market_fine_paid = 90,

    [EnumMember(Value = @"market_provider_tax")]
    Market_provider_tax = 91,

    [EnumMember(Value = @"market_transaction")]
    Market_transaction = 92,

    [EnumMember(Value = @"medal_creation")]
    Medal_creation = 93,

    [EnumMember(Value = @"medal_issued")] Medal_issued = 94,

    [EnumMember(Value = @"milestone_reward_payment")]
    Milestone_reward_payment = 95,

    [EnumMember(Value = @"mission_completion")]
    Mission_completion = 96,

    [EnumMember(Value = @"mission_cost")] Mission_cost = 97,

    [EnumMember(Value = @"mission_expiration")]
    Mission_expiration = 98,

    [EnumMember(Value = @"mission_reward")]
    Mission_reward = 99,

    [EnumMember(Value = @"office_rental_fee")]
    Office_rental_fee = 100,

    [EnumMember(Value = @"operation_bonus")]
    Operation_bonus = 101,

    [EnumMember(Value = @"opportunity_reward")]
    Opportunity_reward = 102,

    [EnumMember(Value = @"planetary_construction")]
    Planetary_construction = 103,

    [EnumMember(Value = @"planetary_export_tax")]
    Planetary_export_tax = 104,

    [EnumMember(Value = @"planetary_import_tax")]
    Planetary_import_tax = 105,

    [EnumMember(Value = @"player_donation")]
    Player_donation = 106,

    [EnumMember(Value = @"player_trading")]
    Player_trading = 107,

    [EnumMember(Value = @"project_discovery_reward")]
    Project_discovery_reward = 108,

    [EnumMember(Value = @"project_discovery_tax")]
    Project_discovery_tax = 109,

    [EnumMember(Value = @"reaction")] Reaction = 110,

    [EnumMember(Value = @"redeemed_isk_token")]
    Redeemed_isk_token = 111,

    [EnumMember(Value = @"release_of_impounded_property")]
    Release_of_impounded_property = 112,

    [EnumMember(Value = @"repair_bill")] Repair_bill = 113,

    [EnumMember(Value = @"reprocessing_tax")]
    Reprocessing_tax = 114,

    [EnumMember(Value = @"researching_material_productivity")]
    Researching_material_productivity = 115,

    [EnumMember(Value = @"researching_technology")]
    Researching_technology = 116,

    [EnumMember(Value = @"researching_time_productivity")]
    Researching_time_productivity = 117,

    [EnumMember(Value = @"resource_wars_reward")]
    Resource_wars_reward = 118,

    [EnumMember(Value = @"reverse_engineering")]
    Reverse_engineering = 119,

    [EnumMember(Value = @"season_challenge_reward")]
    Season_challenge_reward = 120,

    [EnumMember(Value = @"security_processing_fee")]
    Security_processing_fee = 121,

    [EnumMember(Value = @"shares")] Shares = 122,

    [EnumMember(Value = @"skill_purchase")]
    Skill_purchase = 123,

    [EnumMember(Value = @"sovereignity_bill")]
    Sovereignity_bill = 124,

    [EnumMember(Value = @"store_purchase")]
    Store_purchase = 125,

    [EnumMember(Value = @"store_purchase_refund")]
    Store_purchase_refund = 126,

    [EnumMember(Value = @"structure_gate_jump")]
    Structure_gate_jump = 127,

    [EnumMember(Value = @"transaction_tax")]
    Transaction_tax = 128,

    [EnumMember(Value = @"upkeep_adjustment_fee")]
    Upkeep_adjustment_fee = 129,

    [EnumMember(Value = @"war_ally_contract")]
    War_ally_contract = 130,

    [EnumMember(Value = @"war_fee")] War_fee = 131,

    [EnumMember(Value = @"war_fee_surrender")]
    War_fee_surrender = 132
}