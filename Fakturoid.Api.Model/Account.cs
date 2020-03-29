using System;
using System.Text.Json.Serialization;
using Fakturoid.Api.Model.Enums;
using JPropertyName = System.Text.Json.Serialization.JsonPropertyNameAttribute;

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
        [JPropertyName("subdomain")]
        public string Subdomain { get; set; }

        /// <summary>
        /// Jméno tarifu
        /// </summary>
        [JPropertyName("plan")]
        public string Plan { get; set; }

        /// <summary>
        /// Cena tarifu
        /// </summary>
        [JPropertyName("plan_price")]
        public int PlanPrice { get; set; }

        /// <summary>
        /// Email vlastníka účtu
        /// </summary>
        [JPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Email, ze kterého jsou odesílány faktury
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("invoice_email")]
        public string InvoiceEmail { get; set; }

        /// <summary>
        /// Telefon vlastníka účtu
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Web vlastníka účtu
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("web")]
        public string Web { get; set; }

        /// <summary>
        /// Jméno firmy
        /// </summary>
        [JPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Jméno majitele účtu
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("full_name")]
        public string FullName { get; set; }

        /// <summary>
        /// IČ
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("registration_no")]
        public string RegistrationNo { get; set; }

        /// <summary>
        /// DIČ
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("vat_no")]
        public string VatNo { get; set; }

        /// <summary>
        /// Plátce DPH / Neplátce DPH / Identifikovaná osoba
        /// </summary>
        [JPropertyName("vat_mode")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public VatMode VatMode { get; set; }

        /// <summary>
        /// Způsob zadávání cen do řádků
        /// <para>Používá se pouze pro plátce DPH a identifikované osoby u neplátců DPH je ignorováno.</para>
        /// </summary>
        [JPropertyName("vat_price_mode")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public VatPriceMode VatPriceMode { get; set; }

        /// <summary>
        /// Ulice
        /// </summary>
        [JPropertyName("street")]
        public string Street { get; set; }

        /// <summary>
        /// Ulice 2
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("street2")]
        public string Street2 { get; set; }

        /// <summary>
        /// Město
        /// </summary>
        [JPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// PSČ
        /// </summary>
        [JPropertyName("zip")]
        public string Zip { get; set; }

        /// <summary>
        /// Země (ISO kód)
        /// </summary>
        [JPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// Výchozí bankovní účet
        /// </summary>
        [JPropertyName("bank_account")]
        public string BankAccount { get; set; }

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
        /// Měna
        /// </summary>
        [JPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Výchozí jednotka
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("unit_name")]
        public string UnitName { get; set; }

        /// <summary>
        /// Výchozí daňová sazba
        /// </summary>
        [JPropertyName("vat_rate")]
        public int VatRate { get; set; }

        /// <summary>
        /// Text patičky
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("displayed_note")]
        public string DisplayedNote { get; set; }

        /// <summary>
        /// Text před položkami faktury
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("invoice_note")]
        public string InvoiceNote { get; set; }

        /// <summary>
        /// Počet dní před splatností
        /// </summary>
        [JPropertyName("due")]
        public string Due { get; set; }

        /// <summary>
        /// Text emailu pro odeslání faktury
        /// </summary>
        [JPropertyName("custom_email_text")]
        public string CustomEmailText { get; set; }

        /// <summary>
        /// Text upomínky
        /// </summary>
        [JPropertyName("overdue_email_text")]
        public string OverdueEmailText { get; set; }

        /// <summary>
        /// Zapnutí PayPal plateb
        /// </summary>
        [JPropertyName("invoice_paypal")]
        public bool InvoicePaypal { get; set; }

        /// <summary>
        /// Zapnutí GoPay plateb
        /// </summary>
        [JPropertyName("invoice_gopay")]
        public bool InvoiceGopay { get; set; }

        /// <summary>
        /// HTML adresa účtu
        /// </summary>
        [JPropertyName("html_url")]
        public string HtmlUrl { get; set; }

        /// <summary>
        /// API adresa účtu
        /// </summary>
        [JPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// Datum vytvoření účtu
        /// </summary>
        [JPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Datum poslední úpravy účtu
        /// </summary>
        [JPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }
    }
}