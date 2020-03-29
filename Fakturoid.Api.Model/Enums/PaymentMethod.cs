using System.Runtime.Serialization;

namespace Fakturoid.Api.Model.Enums
{
    /// <summary>
    /// Typ platby
    /// </summary>
    public enum PaymentMethod
    {
        /// <summary>
        /// Bankovní převod
        /// </summary>
        [EnumMember(Value = "bank")]
        Bank = 0,

        /// <summary>
        /// Hotově
        /// </summary>
        [EnumMember(Value = "cash")]
        Cash = 1,

        /// <summary>
        /// Dobírka
        /// </summary>
        [EnumMember(Value = "cod")]
        Cod = 2,

        /// <summary>
        /// PayPal
        /// </summary>
        [EnumMember(Value = "paypal")]
        Paypal = 3,

        /// <summary>
        /// Karta
        /// </summary>
        [EnumMember(Value = "card")]
        Card = 4
    }
}