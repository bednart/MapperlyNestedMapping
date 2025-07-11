using Riok.Mapperly.Abstractions;

namespace MapperlyNestedMapping;

[Mapper]
public partial class ClaimedRewardsMappers
{
    public partial Target Map(Source output);
}
