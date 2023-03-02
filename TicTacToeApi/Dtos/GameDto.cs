using System;
namespace TicTacToeApi.Dtos
{
    public class GameDto
    {
        public int Id { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime? EndAt { get; set; }
        public GameStatus Status { get; set; }
        public Dictionary<int, string[]> Board { get; set; }
        public double Duration { get; set; }
    }
}

