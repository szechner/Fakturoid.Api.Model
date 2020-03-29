using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Fakturoid.Api.Model.Converters
{
    public class AttachmentJsonConverter : JsonConverter<Attachment>
    {
        public override Attachment Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return null;
            }

            var attachment = new Attachment();

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject)
                {
                    return attachment;
                }

                if (reader.TokenType == JsonTokenType.PropertyName)
                {
                    var propertyName = reader.GetString();
                    reader.Read();
                    switch (propertyName)
                    {
                        case "file_name":
                        {
                            var fileName = reader.GetString();
                            attachment.FileName = fileName;
                            break;
                        }
                        case "content_type":
                        {
                            var contentType = reader.GetString();
                            attachment.ContentType = contentType;
                            break;
                        }
                        case "download_url":
                        {
                            var downloadUrl = reader.GetString();
                            attachment.DownloadUrl = downloadUrl;
                            break;
                        }
                    }
                }
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, Attachment value, JsonSerializerOptions options)
        {
            writer.WriteStringValue((string) value);
        }
    }
}