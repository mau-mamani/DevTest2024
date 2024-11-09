using VoteApi.Models;
using VoteApi.Models.Dto;
using VoteApi.Repositories;
using VoteApi.Validators;

namespace VoteApi.Services;

public class PollService : IPollService
{
    private IRepository<Poll> _pollRepository;
    private IDtoConverter<InputPoll, Poll> _converter;
    private IValidator<Poll> _validator;

    public PollService()
    {
        _pollRepository = new PollMemoryRepository();
        _converter = new PollDtoConverter();
        _validator = new PollValidator();
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
        var isValid = _validator.Validate(poll);
        if (isValid)
        {
            return _pollRepository.PostValue(poll);
        }
        else
        {
            return null;
        }
    }
}