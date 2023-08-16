namespace Backend.Features.Help;

public record HelpResponse(string Text);

internal class HelpQuery
{
    public HelpResponse Execute() => new($"Help needed at {DateTime.Now}");

}