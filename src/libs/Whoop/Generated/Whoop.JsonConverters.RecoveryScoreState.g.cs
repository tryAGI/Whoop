#nullable enable

namespace Whoop.JsonConverters
{
    /// <inheritdoc />
    public sealed class RecoveryScoreStateJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Whoop.RecoveryScoreState>
    {
        /// <inheritdoc />
        public override global::Whoop.RecoveryScoreState Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Whoop.RecoveryScoreStateExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Whoop.RecoveryScoreState)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Whoop.RecoveryScoreState);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Whoop.RecoveryScoreState value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Whoop.RecoveryScoreStateExtensions.ToValueString(value));
        }
    }
}
