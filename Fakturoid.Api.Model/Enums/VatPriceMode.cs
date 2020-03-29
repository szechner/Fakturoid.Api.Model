using System.Runtime.Serialization;

namespace Fakturoid.Api.Model.Enums
{
    /// <summary>
    /// Způsob zadávání cen do řádků
    /// </summary>
    public enum VatPriceMode
    {
        [EnumMember(Value = "without_vat")]
        WithoutVat = 0,

        [EnumMember(Value = "from_total_with_vat")]
        FromTotalWithVat = 1
    }
}