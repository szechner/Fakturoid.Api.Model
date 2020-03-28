using System.Text.Json.Serialization;

namespace Fakturoid.Api.Model
{
    /// <summary>
    /// Bankovní účet
    /// <para>Bankovní účty jsou pouze pro čtení, pro změny použijte prosím webové rozhraní.</para>
    /// </summary>
    public class BankAccount
    {
        /// <summary>
        /// Identifikátor bankovního účtu
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Název účtu
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Číslo účtu
        /// </summary>
        [JsonPropertyName("number")]
        public string Number { get; set; }

        /// <summary>
        /// Měna
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// IBAN
        /// <para>Optional</para>
        /// </summary>
        [JsonPropertyName("iban")]
        public string Iban { get; set; }

        /// <summary>
        /// BIC (pro SWIFT platby)
        /// <para>Optional</para>
        /// </summary>
        [JsonPropertyName("swift_bic")]
        public string SwiftBic { get; set; }

        /// <summary>
        /// Párovnání plateb
        /// </summary>
        [JsonPropertyName("pairing")]
        public bool Pairing { get; set; }

        /// <summary>
        /// Haléřové vyrovnání při párování plateb
        /// </summary>
        [JsonPropertyName("payment_adjustment")]
        public string PaymentAdjustment { get; set; }
    }
}
