using VoteApi.Models;
using VoteApi.Models.Dto;

namespace VoteApi.Services;

public interface IPollService {
    Task<List<Poll>> GetPolls ();
    Task<Poll> GetPoll(int id);
    Task<Poll> PostPoll(InputPoll inputPoll);
}