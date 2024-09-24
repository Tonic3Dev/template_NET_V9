using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace template_net_9.Helpers;

public class DateTimeToDateTimeOffsetConverter(ConverterMappingHints mappingHints = null) : ValueConverter<DateTime, DateTimeOffset>(
        v => new DateTimeOffset(v, TimeSpan.Zero),
        v => v.UtcDateTime,
        mappingHints)
{
    public static ValueConverterInfo DefaultInfo { get; }
        = new ValueConverterInfo(typeof(DateTime), typeof(DateTimeOffset), i => 
            new DateTimeToDateTimeOffsetConverter(i.MappingHints));
}