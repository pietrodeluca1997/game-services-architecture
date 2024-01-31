namespace GSA.Core.Queries.Shared;

public record CharacterQueryResponse : IQueryResponse
{
    public string CharacterName { get; init; }
    public uint CurrentLevel { get; init; }
    public DateTime CreatedAt { get; init; }

    public CharacterQueryResponse(string characterName, uint currentLevel, DateTime createdAt)
    {
        CharacterName = characterName;
        CurrentLevel = currentLevel;
        CreatedAt = createdAt;
    }
}
