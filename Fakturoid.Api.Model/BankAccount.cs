using JPropertyName = System.Text.Json.Serialization.JsonPropertyNameAttribute;

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
        [JPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Název účtu
        /// </summary>
        [JPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Číslo účtu
        /// </summary>
        [JPropertyName("number")]
        public string Number { get; set; }

        /// <summary>
        /// Měna
        /// </summary>
        [JPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// IBAN
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("iban")]
        public string Iban { get; set; }

        /// <summary>
        /// BIC (pro SWIFT platby)
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("swift_bic")]
        public string SwiftBic { get; set; }

        /// <summary>
        /// Párovnání plateb
        /// </summary>
        [JPropertyName("pairing")]
        public bool Pairing { get; set; }

        /// <summary>
        /// Haléřové vyrovnání při párování plateb
        /// </summary>
        [JPropertyName("payment_adjustment")]
        public string PaymentAdjustment { get; set; }
    }
}