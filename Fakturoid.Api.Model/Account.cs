using System;
using System.Text.Json.Serialization;
using Fakturoid.Api.Model.Enums;

namespace Fakturoid.Api.Model
{
    /// <summary>
    /// Účet
    /// <para>Účet je pouze pro čtení, pro změny použijte prosím webové rozhraní.</para>
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Název účtu (slug)
        /// </summary>
        [JsonPropertyName("subdomain")]
        public string Subdomain { get; set; }

        /// <summary>
        /// Jméno tarifu
        /// </summary>
        [JsonPropertyName("plan")]
        public string Plan { get; set; }

        /// <summary>
        /// Cena tarifu
        /// </summary>
        [JsonPropertyName("plan_price")]
        public int PlanPrice { get; set; }

        /// <summary>
        /// Email vlastníka účtu
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Email, ze kterého jsou odesílány faktury
        /// <para>Optional</para>
        /// </summary>
        [JsonPropertyName("invoice_email")]
        public string InvoiceEmail { get; set; }

        /// <summary>
        /// Telefon vlastníka účtu
        /// <para>Optional</para>
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Web vlastníka účtu
        /// <para>Optional</para>
        /// </summary>
        [JsonPropertyName("web")]
        public string Web { get; set; }

        /// <summary>
        /// Jméno firmy
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Jméno majitele účtu
        /// <para>Optional</para>
        /// </summary>
        [JsonPropertyName("full_name")]
        public string FullName { get; set; }

        /// <summary>
        /// IČ
        /// <para>Optional</para>
        /// </summary>
        [JsonPropertyName("registration_no")]
        public string RegistrationNo { get; set; }

        /// <summary>
        /// DIČ
        /// <para>Optional</para>
        /// </summary>
        [JsonPropertyName("vat_no")]
        public string VatNo { get; set; }

        /// <summary>
        /// Plátce DPH / Neplátce DPH / Identifikovaná osoba
        /// </summary>
        [JsonPropertyName("vat_mode")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public VatMode VatMode { get; set; }

        /// <summary>
        /// Způsob zadávání cen do řádků
        /// <para>Používá se pouze pro plátce DPH a identifikované osoby u neplátců DPH je ignorováno.</para>
        /// </summary>
        [JsonPropertyName("vat_price_mode")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public VatPriceMode VatPriceMode { get; set; }

        /// <summary>
        /// Ulice
        /// </summary>
        [JsonPropertyName("street")]
        public string Street { get; set; }

        /// <summary>
        /// Ulice 2
        /// <para>Optional</para>
        /// </summary>
        [JsonPropertyName("street2")]
        public string Street2 { get; set; }

        /// <summary>
        /// Město
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// PSČ
        /// </summary>
        [JsonPropertyName("zip")]
        public string Zip { get; set; }

        /// <summary>
        /// Země (ISO kód)
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// Výchozí bankovní účet
        /// </summary>
        [JsonPropertyName("bank_account")]
        public string BankAccount { get; set; }

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
        /// Měna
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Výchozí jednotka
        /// <para>Optional</para>
        /// </summary>
        [JsonPropertyName("unit_name")]
        public string UnitName { get; set; }

        /// <summary>
        /// Výchozí daňová sazba
        /// </summary>
        [JsonPropertyName("vat_rate")]
        public int VatRate { get; set; }

        /// <summary>
        /// Text patičky
        /// <para>Optional</para>
        /// </summary>
        [JsonPropertyName("displayed_note")]
        public string DisplayedNote { get; set; }

        /// <summary>
        /// Text před položkami faktury
        /// <para>Optional</para>
        /// </summary>
        [JsonPropertyName("invoice_note")]
        public string InvoiceNote { get; set; }

        /// <summary>
        /// Počet dní před splatností
        /// </summary>
        [JsonPropertyName("due")]
        public string Due { get; set; }

        /// <summary>
        /// Text emailu pro odeslání faktury
        /// </summary>
        [JsonPropertyName("custom_email_text")]
        public string CustomEmailText { get; set; }

        /// <summary>
        /// Text upomínky
        /// </summary>
        [JsonPropertyName("overdue_email_text")]
        public string OverdueEmailText { get; set; }

        /// <summary>
        /// Zapnutí PayPal plateb
        /// </summary>
        [JsonPropertyName("invoice_paypal")]
        public bool InvoicePaypal { get; set; }

        /// <summary>
        /// Zapnutí GoPay plateb
        /// </summary>
        [JsonPropertyName("invoice_gopay")]
        public bool InvoiceGopay { get; set; }

        /// <summary>
        /// HTML adresa účtu
        /// </summary>
        [JsonPropertyName("html_url")]
        public string HtmlUrl { get; set; }

        /// <summary>
        /// API adresa účtu
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// Datum vytvoření účtu
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Datum poslední úpravy účtu
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }
    }
}