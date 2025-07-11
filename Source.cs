namespace MapperlyNestedMapping;

public sealed record Source
{
    public required ICollection<RewardItem> Rewards { get; init; }

    public sealed record RewardItem
    {
        public required string Id { get; init; }

        public Actions? Actions { get; init; }
    }

    public sealed record Actions
    {
        public CompleteActionUrl? Complete { get; init; }
    }

    public sealed record CompleteActionUrl
    {
        public required string Method { get; init; }

        public required string Url { get; init; }
    }
}
