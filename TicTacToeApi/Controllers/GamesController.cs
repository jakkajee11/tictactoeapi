using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TicTacToeApi.Dtos;
using TicTacToeApi.Models;
using TicTacToeApi.Services;

namespace TicTacToeApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GamesController : ControllerBase
{
    private readonly IGameService _service;

    private readonly IMapper _mapper;

    public GamesController(IGameService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    [HttpGet]    
    public IActionResult Get()
    {        
        return Ok(_mapper.Map<List<GameDto>>(_service.GetGames()));
    }

    [HttpPost]
    public IActionResult Save(Game game)
    {
        _service.SaveGame(game);
        return Ok();
    }
}

