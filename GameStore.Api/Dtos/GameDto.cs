namespace GameStore.Api.Dtos;


// Data to object --> Dto
public record class GameDto(
    int Id,
    string Name,
    string Genre,
    decimal Price,
    DateOnly ReleaseDate);
