using System;
using System.Text.Json.Serialization;
using JPropertyName = System.Text.Json.Serialization.JsonPropertyNameAttribute;

namespace Fakturoid.Api.Model
{
    /// <summary>
    /// Příloha
    /// </summary>
    public class Attachment
    {
        /// <summary>
        /// název souboru
        /// </summary>
        [JPropertyName("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// MIME type souboru
        /// </summary>
        [JPropertyName("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// URL pro download přílohy přes API
        /// </summary>
        [JPropertyName("download_url")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// Data pro upload přílohy
        /// <para>Pro zpracování je potřeba mít vyplněný ContentType</para>
        /// </summary>
        [JsonIgnore]
        public byte[] Data { get; set; }

        public static implicit operator string(Attachment attachment)
        {
            if (attachment?.Data == null || attachment.Data.Length == 0 || string.IsNullOrEmpty(attachment.ContentType))
            {
                return null;
            }

            var result = $"data:{attachment.ContentType};base64,{Convert.ToBase64String(attachment.Data)}";

            return result;
        }
    }
}