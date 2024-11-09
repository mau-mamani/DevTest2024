using VoteApi.Models;

namespace VoteApi.Repositories;

public interface IRepository<T> {
    Task<T> GetValue(int id);
    Task<List<T>> GetValues ();
    Task<Poll> PostValue(T value);
}