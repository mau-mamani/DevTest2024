using System.ComponentModel.DataAnnotations;

namespace VoteApi.Models.Dto;

public class InputPoll {
    [Required]
    [StringLength(100)]
    public string? Name {get; set;}
    [Required]
    public List<Option>? Options {get;set;}
}