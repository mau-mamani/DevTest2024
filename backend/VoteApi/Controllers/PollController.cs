using Microsoft.AspNetCore.Mvc;
using VoteApi.Models;
using VoteApi.Models.Dto;
using VoteApi.Services;

namespace VoteApi.Controllers;

[ApiController]
[Route("api/v1/[Controller]")]
public class PollController : ControllerBase {
   
    private IPollService _pollService;

    public PollController(IPollService pollService){
        _pollService = pollService;
    }

    [HttpGet]
    public Task<List<Poll>> GetPolls() {
        return _pollService.GetPolls();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Poll>> Get(int id){
        return await _pollService.GetPoll(id);
    }

    [HttpPost]
    public async Task<ActionResult<Poll>> PostPull(InputPoll inputPoll){
        
        try{
            Poll pollCreated = await _pollService.PostPoll(inputPoll);
            if(pollCreated != null){
                return CreatedAtAction(nameof(Get), new { id = pollCreated.Id }, pollCreated);
            }else{
                return StatusCode(500, $"An error occurred ");
            }
            
        }catch(Exception ex){
            return StatusCode(500, $"An error occurred : {ex.Message}");
        }
    }

}