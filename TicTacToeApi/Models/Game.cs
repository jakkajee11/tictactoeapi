using System;
namespace TicTacToeApi.Models
{
    public class Game
    {
        public int Id { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime? EndAt { get; set; }
        public GameStatus Status { get; set; }
        public Dictionary<int, string[]> Board { get; set; }

        public TimeSpan Duration => EndAt.HasValue ? (EndAt.Value - StartAt) : (DateTime.Now - StartAt);
    }
}

