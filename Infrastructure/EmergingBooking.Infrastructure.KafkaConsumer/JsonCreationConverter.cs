﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace EmergingBooking.Infrastructure.KafkaConsumer;

public abstract class JsonCreationConverter<T> : JsonConverter
{
    protected abstract T Create(Type objectType, JObject jObject);

    public override bool CanConvert(Type objectType)
    {
        return typeof(T).IsAssignableFrom(objectType);
    }

    public override bool CanWrite => false;

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        JObject jObject = JObject.Load(reader);

        T target = Create(objectType, jObject);

        serializer.Populate(jObject.CreateReader(), target);

        return target;
    }
}