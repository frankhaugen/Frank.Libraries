namespace EveOnlineApi;

    /// <summary>
    /// Filter buy/sell orders, return all orders by default. If you query without type_id, we always return both buy and sell orders
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public enum Order_type
    {

        [System.Runtime.Serialization.EnumMember(Value = @"buy")]
        Buy = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"sell")]
        Sell = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"all")]
        All = 2,

    }
