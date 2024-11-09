using System.Windows.Markup;
using VoteApi.Models;

namespace VoteApi.Repositories;

public class PollMemoryRepository : IRepository<Poll>
{
    private List<Poll> _polls;

    public PollMemoryRepository()
    {
        _polls = new List<Poll>();
        Poll pollExample = new Poll{
            Id = 1,
            Name = "example base",
            Options = [
                new Option {
                    Id = 2,
                    Name = "option 1",
                    Votes = 1
                }
            ]   
        };
        _polls.Add(pollExample);
    }

    public async Task<Poll> GetValue(int id)
    {
        return _polls.Find(x => x.Id == id);
    } 

    public async Task<List<Poll>> GetValues()
    {
        try{
            return _polls;
        }catch(Exception e){
            return null;
        }
    }

    public Poll PostValue(Poll value)
    {
        try
        {
            var currentCount = _polls.Count;
            if (currentCount > 1)
            {
                value.Id = _polls[currentCount - 1].Id + 1;
            }
            else
            {
                value.Id = 1;
            }
            _polls.Add(value);
            return  value;
        }
        catch (Exception e)
        {
            return null;
        }

    }
}