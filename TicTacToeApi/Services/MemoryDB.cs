using System;
using TicTacToeApi.Models;

namespace TicTacToeApi.Services
{
    public static class MemoryDB
    {        
        public static List<Game> Games { get; set; } = new List<Game>();        

        public static void SaveGame(Game game)
        {
            Games.Add(game);
        }

    }
}

