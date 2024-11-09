namespace VoteApi.Models;

public class Poll {
    public int Id {get; set;}
    public string? Name {get; set;}
    public List<Option>? Options {get;set;}
}