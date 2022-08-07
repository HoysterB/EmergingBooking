using System.Text;
using Confluent.Kafka;
using Newtonsoft.Json;

namespace EmergingBooking.Infrastructure.KafkaConsumer;

internal class JsonDeserializerValueUTF8<TEntity> : IDeserializer<TEntity>
{
    private readonly Encoding _encoder;
    private readonly JsonCreationConverter<TEntity> _customCreationConverter;
    public JsonDeserializerValueUTF8(JsonCreationConverter<TEntity> customCreationConverter)
    {
        _encoder = Encoding.UTF8;
        _customCreationConverter = customCreationConverter;
    }
    public TEntity Deserialize(ReadOnlySpan<byte> data, bool isNull, SerializationContext context)
    {
        return JsonConvert.DeserializeObject<TEntity>(_encoder.GetString(data.ToArray()));
    }
}