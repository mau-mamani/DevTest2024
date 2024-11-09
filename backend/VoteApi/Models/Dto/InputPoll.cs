namespace VoteApi.Models.Dto;

public class InputPoll {
    public string? Name {get; set;}
    public List<Option>? Options {get;set;}
}