using System.Windows.Markup;
using VoteApi.Models;

namespace VoteApi.Repositories;

public class PollMemoryRepository : IRepository<Poll>
{
    private IList<Poll> _polls;

    public PollMemoryRepository()
    {
        _polls = new List<Poll>();
        Poll pollExample = new Poll{
            Id = 1,
            Name = "example base",
            
        };
        _polls.Add(pollExample);
    }

    public Task<Poll> GetValue(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Poll>> GetValues()
    {
        try{
            return (List<Poll>)_polls;
        }catch(Exception e){
            return null;
        }
    }

    public async Task<Poll> PostValue(Poll value)
    {
        try
        {
            var currentCount = _polls.Count;
            if (currentCount > 1)
            {
                value.Id = _polls[currentCount].Id + 1;
            }
            else
            {
                value.Id = 1;
            }
            _polls.Add(value);
            return value;
        }
        catch (Exception e)
        {
            return null;
        }

    }
}