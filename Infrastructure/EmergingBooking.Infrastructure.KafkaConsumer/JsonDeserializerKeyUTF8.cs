using System.Text;
using Confluent.Kafka;
using Newtonsoft.Json;

namespace EmergingBooking.Infrastructure.KafkaConsumer;

internal class JsonDeserializerKeyUTF8<TKeyType> : IDeserializer<TKeyType>
{
    private readonly Encoding _encoder;

    public JsonDeserializerKeyUTF8()
    {
        _encoder = Encoding.UTF8;
    }

    public TKeyType Deserialize(ReadOnlySpan<byte> data, bool isNull, SerializationContext context)
    {
        return JsonConvert.DeserializeObject<TKeyType>(_encoder.GetString(data.ToArray()));
    }
}