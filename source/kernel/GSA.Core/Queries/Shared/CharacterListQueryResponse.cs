namespace GSA.Core.Queries.Shared;

public record CharacterListQueryResponse : IQueryResponse
{
    public List<CharacterQueryResponse> Characters { get; set; }

    public CharacterListQueryResponse()
    {
        // Mock
        Characters = [];
        Characters.Add(new CharacterQueryResponse("Character", 1, DateTime.Now));
    }
}
