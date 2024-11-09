namespace VoteApi.Models.Dto;

public class PollDtoConverter : IDtoConverter<InputPoll, Poll>
{
    public Poll DtoToModel(InputPoll dto)
    {
        return new Poll{
            Id = 0,
            Name = dto.Name,
            Options = dto.Options,
        };
    }

    public InputPoll ModelToDto(Poll model)
    {
        return new InputPoll {
            Name = model.Name,
            Options = model.Options,
        };
    }
}