using Application.DTO.Game;

namespace Application.Interfaces
{
    public interface IGameService
    {
        Task<IEnumerable<GameResponse>> GetAllGamesAsync();
        GameResponse GetGameById(int id);
        GameSearchResponse SearchGames(GameSearchRequest request, int page = 0, int pageSize = 10);
        GameResponse AddGame(GameRequest game);
        GameResponse UpdateGame(GameRequest game);
        bool DeleteGame(int id);
    }
}
