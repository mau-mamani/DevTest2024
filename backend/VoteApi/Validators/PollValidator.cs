using System.Text.RegularExpressions;
using VoteApi.Models;

namespace VoteApi.Validators;

public class PollValidator : IValidator<Poll>
{
    public bool Validate(Poll value)
    {
        bool isValid = true;
        var letterPattern = "[a-z]";
        var numberPattern = "[0-9]";
        var characters = value.Name.ToArray();
        for (int i = 0; i == characters.Length - 1; i++)
        {
            if (characters[i] != ' ')
            {
                isValid = false;
            }
            else if (!MatchPatter(characters[i], letterPattern))
            {
                isValid = false;
            }
            else if (!MatchPatter(characters[i], numberPattern))
            {
                isValid = false;
            }
        }
        
        return isValid;
    }

    private bool MatchPatter(char letter, string pattern)
    {
        return Regex.IsMatch(letter.ToString(), pattern);
    }
}