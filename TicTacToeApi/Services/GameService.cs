using System;
using TicTacToeApi.Models;

namespace TicTacToeApi.Services
{
    public interface IGameService
    {
        List<Game> GetGames();
        void SaveGame(Game game);
    }
    public class GameService : IGameService
    {       
        public List<Game> GetGames()
        {
            return MemoryDB.Games;
        }

        public void SaveGame(Game game)
        {
            game.Id = MemoryDB.Games.Count + 1;
            game.EndAt = DateTime.Now;
            MemoryDB.SaveGame(game);
        }
    }
}

