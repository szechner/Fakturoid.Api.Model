using System.Runtime.Serialization;

namespace Fakturoid.Api.Model.Enums
{
    /// <summary>
    /// Plátce DPH / Neplátce DPH / Identifikovaná osoba
    /// </summary>
    public enum VatMode
    {
        [EnumMember(Value = "vat_payer")]
        VatPayer = 0,

        [EnumMember(Value = "non_vat_payer")]
        NonVatPayer = 1,

        [EnumMember(Value = "identified_person")]
        IdentifiedPerson = 2
    }
}
