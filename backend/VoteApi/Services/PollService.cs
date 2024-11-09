using VoteApi.Models;
using VoteApi.Models.Dto;
using VoteApi.Repositories;

namespace VoteApi.Services;

public class PollService : IPollService
{
    private IRepository<Poll> _pollRepository;
    private IDtoConverter<InputPoll, Poll> _converter;

    public PollService(IRepository<Poll> pollRepository){
        _pollRepository = pollRepository;
        _converter = new PollDtoConverter();
    }

    public async Task<Poll> GetPoll(int id)
    {
        return await _pollRepository.GetValue(id);
    }

    public async Task<List<Poll>> GetPolls()
    {
        return await _pollRepository.GetValues();
    }

    public async Task<Poll> PostPoll(InputPoll inputPoll)
    {
        var poll = _converter.DtoToModel(inputPoll);
        return await _pollRepository.PostValue(poll);
    }
} 