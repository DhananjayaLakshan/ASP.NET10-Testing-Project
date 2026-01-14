namespace GameStore.Api.Dtos;

public record GameDtailsDto(
    int Id,
    string Name,
    int GenreId,
    decimal Price,
    DateOnly ReleaseDate
);