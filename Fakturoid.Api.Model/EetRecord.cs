using System;
using System.Text.Json.Serialization;
using Fakturoid.Api.Model.Enums;
using JPropertyName = System.Text.Json.Serialization.JsonPropertyNameAttribute;

namespace Fakturoid.Api.Model
{
    public class EetRecord
    {
        /// <summary>
        /// ID záznamu
        /// </summary>
        [JPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// DIČ účtu ve fakturoidu
        /// <para>Required</para>
        /// </summary>
        [JPropertyName("vat_no")]
        public string VatNo { get; set; }

        /// <summary>
        /// Pořadové číslo dokladu
        /// <para>Required</para>
        /// </summary>
        [JPropertyName("number")]
        public string Number { get; set; }

        /// <summary>
        /// ID provozovny
        /// <para>Required</para>
        /// </summary>
        [JPropertyName("store")]
        public int Store { get; set; }

        /// <summary>
        /// Číslo pokladny
        /// <para>Required</para>
        /// </summary>
        [JPropertyName("cash_register")]
        public string CashRegister { get; set; }

        /// <summary>
        /// Datum a čas tržby
        /// <para>Required</para>
        /// </summary>
        [JPropertyName("paid_at")]
        public DateTimeOffset PaidAt { get; set; }

        /// <summary>
        /// Základ nepodléhající DPH
        /// </summary>
        [JPropertyName("vat_base0")]
        public decimal VatBase0 { get; set; }

        /// <summary>
        /// Základ pro základní sazbu DPH (21 %)
        /// </summary>
        [JPropertyName("vat_base1")]
        public decimal VatBase1 { get; set; }

        /// <summary>
        /// DPH pro základní sazbu
        /// </summary>
        [JPropertyName("vat1")]
        public decimal Vat1 { get; set; }

        /// <summary>
        /// Základ pro 1. sníženou sazbu DPH (15 %)
        /// </summary>
        [JPropertyName("vat_base2")]
        public decimal VatBase2 { get; set; }

        /// <summary>
        /// DPH pro 1. sníženou sazbu DPH
        /// </summary>
        [JPropertyName("vat2")]
        public decimal Vat2 { get; set; }

        /// <summary>
        /// Základ pro 2. sníženou sazbu DPH (10 %)
        /// </summary>
        [JPropertyName("vat_base3")]
        public decimal VatBase3 { get; set; }

        /// <summary>
        /// DPH pro 2. sníženou sazbu DPH
        /// </summary>
        [JPropertyName("vat3")]
        public decimal Vat3 { get; set; }

        /// <summary>
        /// Celková částka tržby
        /// <para>Required</para>
        /// </summary>
        [JPropertyName("total")]
        public decimal Total { get; set; }

        /// <summary>
        /// FIK kód
        /// </summary>
        [JPropertyName("fik")]
        public string Fik { get; set; }

        /// <summary>
        /// BKP kód
        /// </summary>
        [JPropertyName("bkp")]
        public string Bkp { get; set; }

        /// <summary>
        /// PKP kód
        /// </summary>
        [JPropertyName("pkp")]
        public string Pkp { get; set; }

        /// <summary>
        /// Stav zaevidování
        /// </summary>
        [JPropertyName("status")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public EetStatus Status { get; set; }

        /// <summary>
        /// Datum a čas získání FIK ze serverů EET
        /// </summary>
        [JPropertyName("fik_received_at")]
        public DateTimeOffset? FikReceivedAt { get; set; }

        /// <summary>
        /// <para>true - Tržba je zaevidována mimo Fakturoid a potřebné kódy jsou zadány přes API</para>
        /// <para>false - Fakturoid se stará o zaevidování tržby</para>
        /// </summary>
        [JPropertyName("external")]
        public string External { get; set; }

        /// <summary>
        /// Počet pokusů o zaevidování tržby
        /// </summary>
        [JPropertyName("attempts")]
        public string Attempts { get; set; }

        /// <summary>
        /// Datum a čas posledního pokusu o zaevidování tržby
        /// </summary>
        [JPropertyName("last_attempt_at")]
        public DateTimeOffset? LastAttemptAt { get; set; }

        /// <summary>
        /// UUID posledního pokusu o zaevidování tržby
        /// </summary>
        [JPropertyName("last_uuid")]
        public Guid? LastUuid { get; set; }

        /// <summary>
        /// Evidováno v EET Playground prostředí
        /// </summary>
        [JPropertyName("playground")]
        public string Playground { get; set; }

        /// <summary>
        /// ID faktury, ke které EET záznam patří
        /// </summary>
        [JPropertyName("invoice_id")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// Datum a čas vytvoření záznamu
        /// </summary>
        [JPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Datum a čas poslední úpravy záznamu
        /// </summary>
        [JPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }
    }
}