using System;
using System.Text.Json.Serialization;
using Fakturoid.Api.Model.Enums;
using JPropertyName = System.Text.Json.Serialization.JsonPropertyNameAttribute;

namespace Fakturoid.Api.Model
{
    /// <summary>
    /// Kontakt
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Identifikátor kontaktu
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Identifikátor kontaktu ve vaší aplikaci
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("custom_id")]
        public string CustomId { get; set; }

        /// <summary>
        /// Typ kontaktu
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public SubjectType Type { get; set; }

        /// <summary>
        /// Jméno firmy kontaktu
        /// <para>Required</para>
        /// </summary>
        [JPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Ulice
        /// <para>Optional</para>
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
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// PSČ
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("zip")]
        public string Zip { get; set; }

        /// <summary>
        /// Země (ISO Kód)
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// IČ podnikatele
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("registration_no")]
        public string RegistrationNo { get; set; }

        /// <summary>
        /// DIČ (plátci DPH, IČ DPH na Slovensku, je mezinárodní a začíná kódem země)
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("vat_no")]
        public string VatNo { get; set; }

        /// <summary>
        /// SK DIČ (pouze pro Slovensko, nezačíná kódem země)
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("local_vat_no")]
        public string LocalVatNo { get; set; }

        /// <summary>
        /// Číslo bankovního účtu
        /// <para>Optional</para>
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
        /// Variabilní symbol
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("variable_symbol")]
        public string VariableSymbol { get; set; }

        /// <summary>
        /// Příznak zda zasílat připomínky
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("enabled_reminders")]
        public bool EnabledReminders { get; set; } = true;

        /// <summary>
        /// Jméno kontaktní osoby
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("full_name")]
        public string FullName { get; set; }

        /// <summary>
        /// Email pro posílání faktur kontaktu
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Email pro posílání kopie faktur kontaktu
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("email_copy")]
        public string EmailCopy { get; set; }

        /// <summary>
        /// Telefon
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Web
        /// </summary>
        [JPropertyName("web")]
        public string Web { get; set; }

        /// <summary>
        /// Soukromá poznámka
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("private_note")]
        public string PrivateNote { get; set; }

        /// <summary>
        /// Adresa obrázku kontaktu
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("avatar_url")]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// HTML adresa kontaktu
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("html_url")]
        public string HtmlUrl { get; set; }

        /// <summary>
        /// API adresa kontaktu
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// Datum vytvoření kontaktu
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Datum poslední aktualizace kontaktu
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }
    }
}