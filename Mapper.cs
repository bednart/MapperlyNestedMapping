using Riok.Mapperly.Abstractions;

namespace MapperlyNestedMapping;

[Mapper]
public partial class ClaimedRewardsMappers
{
    public partial Target Map(Source output);

    [MapperIgnoreSource(nameof(source.Actions))]
    [MapPropertyFromSource(nameof(Target.RewardItem.Complete), Use = nameof(MapComplete))]
    private partial Target.RewardItem Map(Source.RewardItem source);

    private static Target.CompleteActionUrl MapComplete(Source.RewardItem sourceItem)
        => new()
        {
            Method = sourceItem.Actions?.Complete?.Method ?? string.Empty,
            Url = sourceItem.Actions?.Complete?.Url ?? string.Empty
        };
}
