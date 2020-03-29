using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Fakturoid.Api.Model.Converters;
using Fakturoid.Api.Model.Enums;
using JPropertyName = System.Text.Json.Serialization.JsonPropertyNameAttribute;

namespace Fakturoid.Api.Model
{
    /// <summary>
    /// Faktura
    /// </summary>
    public class Invoice
    {
        /// <summary>
        /// Identifikátor faktury ve vaší aplikaci
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("custom_id")]
        public string CustomId { get; set; }

        /// <summary>
        /// Identifikátor faktury
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Příznak proformy
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("proforma")]
        public bool Proforma { get; set; } = false;

        /// <summary>
        /// Přiznak zda je proforma na plnou částku
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("partial_proforma")]
        public bool PartialProforma { get; set; } = false;

        /// <summary>
        /// Číslo faktury (Př: 2011-0001, musí odpovídat formátu čísla v nastavení účtu)
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("number")]
        public string Number { get; set; }

        /// <summary>
        /// Variabilní symbol (nepovinné - doplní se z čísla faktury)
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("variable_symbol")]
        public string VariableSymbol { get; set; }

        /// <summary>
        /// Název vaší firmy
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("your_name")]
        public string YourName { get; set; }

        /// <summary>
        /// Vaše ulice
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("your_street")]
        public string YourStreet { get; set; }

        /// <summary>
        /// Vaše ulice 2
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("your_street2")]
        public string YourStreet2 { get; set; }

        /// <summary>
        /// Vaše město
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("your_city")]
        public string YourCity { get; set; }

        /// <summary>
        /// Vaše poštovní směrovací číslo
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("your_zip")]
        public string YourZip { get; set; }

        /// <summary>
        /// Vaše země (ISO kód)
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("your_country")]
        public string YourCountry { get; set; }

        /// <summary>
        /// Vaše IČ
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("your_registration_no")]
        public string YourRegistrationNo { get; set; }

        /// <summary>
        /// Vaše DIČ
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("your_vat_no")]
        public string YourVatNo { get; set; }

        /// <summary>
        /// Vaše SK DIČ (pouze pro Slovensko, nezačíná kódem země)
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("your_local_vat_no")]
        public string YourLocalVatNo { get; set; }

        /// <summary>
        /// Název firmy kontaktu
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("client_name")]
        public string ClientName { get; set; }

        /// <summary>
        /// Ulice kontatku
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("client_street")]
        public string ClientStreet { get; set; }

        /// <summary>
        /// Ulice 2 kontaktu
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("client_street2")]
        public string ClientStreet2 { get; set; }

        /// <summary>
        /// Město kontaktu
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("client_city")]
        public string ClientCity { get; set; }

        /// <summary>
        /// Poštovní směrovací číslo kontaktu
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("client_zip")]
        public string ClientZip { get; set; }

        /// <summary>
        /// Země kontaktu (ISO kód)
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("client_country")]
        public string ClientCountry { get; set; }

        /// <summary>
        /// IČ kontaktu
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("client_registration_no")]
        public string ClientRegistrationNo { get; set; }

        /// <summary>
        /// DIČ kontaktu
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("client_vat_no")]
        public string ClientVatNo { get; set; }

        /// <summary>
        /// SK DIČ kontaktu (pouze pro Slovensko, nezačíná kódem země)
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("client_local_vat_no")]
        public string ClientLocalVatNo { get; set; }

        /// <summary>
        /// ID kontaktu (povinné)
        /// <para>Required</para>
        /// </summary>
        [JPropertyName("subject_id")]
        public int SubjectId { get; set; }

        /// <summary>
        /// identifikátor kontaktu ve vaší aplikaci
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("subject_custom_id")]
        public int? SubjectCustomId { get; set; }

        /// <summary>
        /// ID šablony ze které byla faktura vystavena
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("generator_id")]
        public int? GeneratorId { get; set; }

        /// <summary>
        /// ID proformy/faktury (u faktur vystavených ze zálohových faktur)
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("related_id")]
        public int? RelatedId { get; set; }

        /// <summary>
        /// true - Opravný daňový doklad, false - faktura/proforma
        /// </summary>
        [JPropertyName("correction")]
        public bool Correction { get; set; } = false;

        /// <summary>
        /// ID opravovaného dokladu, zadává se pouze pokud je correction=true, na opravovaný doklad se automaticky doplní ID opravného daňového dokladu
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("correction_id")]
        public int? CorrectionId { get; set; }

        /// <summary>
        /// Token pro public akci
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("token")]
        public string Token { get; set; }

        /// <summary>
        /// Stav faktury
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("status")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public InvoiceState Status { get; set; }

        /// <summary>
        /// Číslo objednávky (nepovinné)
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("order_number")]
        public string OrderNumber { get; set; }

        /// <summary>
        /// Datum vystavení (zobrazeno na faktuře)
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("issued_on")]
        public string IssuedOn { get; set; } //Date

        /// <summary>
        /// Datum zdanitelného plnění
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("taxable_fulfillment_due")]
        public string TaxableFulfillmentDue { get; set; } // Date

        /// <summary>
        /// Počet dní, než bude po splatnosti (nepovinné - doplní se z účtu)
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("due")]
        public int Due { get; set; }

        /// <summary>
        /// Datum splatnosti (doplní se podle due)
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("due_on")]
        public string DueOn { get; set; } // Date

        /// <summary>
        /// Datum a čas odeslání faktury
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("sent_at")]
        public DateTimeOffset? SentAt { get; set; }

        /// <summary>
        /// Datum a čas zaplacení faktury
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("paid_at")]
        public DateTimeOffset? PaidAt { get; set; }

        /// <summary>
        /// Datum a čas odeslání upomínky
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("reminder_sent_at")]
        public DateTimeOffset? ReminderSentAt { get; set; }

        /// <summary>
        /// Datum a čas odsouhlasení faktury klientem
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("accepted_at")]
        public DateTimeOffset? AcceptedAt { get; set; }

        /// <summary>
        /// Datum stornování faktury (pouze pro neplátce DPH)
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("cancelled_at")]
        public DateTimeOffset? CancelledAt { get; set; }

        /// <summary>
        /// Text před položkami faktury (nepovinné - doplní se z účtu)
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("note")]
        public string Note { get; set; }

        /// <summary>
        /// Patička faktury (nepovinné - doplní se z účtu)
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("footer_note")]
        public string FooterNote { get; set; }

        /// <summary>
        /// Soukromá poznámka (nepovinné)
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("private_note")]
        public string PrivateNote { get; set; }

        /// <summary>
        /// Seznam tagů faktury
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("tags")]
        public IEnumerable<string> Tags { get; set; }

        /// <summary>
        /// ID bankovního účtu (nepovinné - použije se výchozí bankovní účet)
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("bank_account_id")]
        public int? BankAccountId { get; set; }

        /// <summary>
        /// Číslo bankovního účtu (nepovinné - použije se výchozí bankovní účet)
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("bank_account")]
        public string BankAccount { get; set; }

        /// <summary>
        /// IBAN (nepovinné - doplní se z účtu)
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("iban")]
        public string Iban { get; set; }

        /// <summary>
        /// BIC (nepovinné - doplní se z účtu)
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("swift_bic")]
        public string SwiftBic { get; set; }

        /// <summary>
        /// Typ platby
        /// </summary>
        [JPropertyName("payment_method")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PaymentMethod PaymentMethod { get; set; } = PaymentMethod.Bank;

        /// <summary>
        /// Kód měny (nepovinné - doplní se z účtu, 3 znaky)
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Kurz (povinný pokud je měna faktury jiná než měna účtu)
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("exchange_rate")]
        public string ExchangeRate { get; set; }

        /// <summary>
        /// Tlačítko pro platbu PayPalem
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("paypal")]
        public bool Paypal { get; set; } = false;

        /// <summary>
        /// Tlačítko pro platbu přes GoPay 
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("gopay")]
        public bool Gopay { get; set; } = false;

        /// <summary>
        /// Jazyk faktury (cz, sk, en, de, fr, it, es, ru, pl)
        /// </summary>
        [JPropertyName("language")]
        public string Language { get; set; } = "cz";

        /// <summary>
        /// Přenesená daňová povinnost
        /// </summary>
        [JPropertyName("transferred_tax_liability")]
        public bool TransferredTaxLiability { get; set; } = false;

        /// <summary>
        /// Kód plnění pro souhrnná hlášení (pouze pro zahraniční faktury do EU)
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("supply_code")]
        public int? SupplyCode { get; set; }

        /// <summary>
        /// Příznak, pokud je faktura v režimu MOSS
        /// </summary>
        [JPropertyName("eu_electronic_service")]
        public bool EuElectronicService { get; set; } = false;

        /// <summary>
        /// Způsob zadávání cen do řádků
        /// </summary>
        [JPropertyName("vat_price_mode")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public VatPriceMode? VatPriceMode { get; set; }

        /// <summary>
        /// Zaokrouhlit cenu s DPH (při vystavení)
        /// </summary>
        [JPropertyName("round_total")]
        public bool RoundTotal { get; set; } = false;

        /// <summary>
        /// Součet (bez DPH)
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("subtotal")]
        public decimal Subtotal { get; set; }

        /// <summary>
        /// Součet v měně účtu
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("native_subtotal")]
        public decimal NativeSubtotal { get; set; }

        /// <summary>
        /// Celkový součet (včetně DPH)
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("total")]
        public decimal Total { get; set; }

        /// <summary>
        /// Součet v měně účtu (včetně DPH)
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("native_total")]
        public decimal NativeTotal { get; set; }

        /// <summary>
        /// Částka k zaplacení (včetně DPH)
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("remaining_amount")]
        public decimal RemainingAmount { get; set; }

        /// <summary>
        /// Částka k zaplacení v měně účtu (včetně DPH)
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("remaining_native_amount")]
        public decimal RemainingNativeAmount { get; set; }

        /// <summary>
        /// Skutečně zaplacená částka
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("paid_amount")]
        public string PaidAmount { get; set; }

        /// <summary>
        /// Příznak jestli je faktura evidovaná v EET
        /// </summary>
        [JPropertyName("eet")]
        public bool Eet { get; set; } = false;

        /// <summary>
        /// Pokladna
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("eet_cash_register")]
        public string EetCashRegister { get; set; }

        /// <summary>
        /// Číslo provozovny
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("eet_store")]
        public int? EetStore { get; set; }

        /// <summary>
        /// EET záznamy
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("eet_records")]
        public IEnumerable<EetRecord> EetRecords { get; set; } = new List<EetRecord>();

        /// <summary>
        /// Příloha
        /// <para>Optional</para>
        /// </summary>
        [JPropertyName("attachment")]
        [JsonConverter(typeof(AttachmentJsonConverter))]
        public Attachment Attachment { get; set; }

        /// <summary>
        /// HTML adresa faktury
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("html_url")]
        public string HtmlUrl { get; set; }

        /// <summary>
        /// Veřejná HTML adresa faktury
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("public_html_url")]
        public string PublicHtmlUrl { get; set; }

        /// <summary>
        /// API adresa faktury
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// API adresa pro stažení faktury v PDF
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("pdf_url")]
        public string PdfUrl { get; set; }

        /// <summary>
        /// API adresa kontaktu
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("subject_url")]
        public string SubjectUrl { get; set; }

        /// <summary>
        /// Datum vytvoření faktury
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Datum poslední aktualizace faktury
        /// <para>Readonly</para>
        /// </summary>
        [JPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }
    }
}