
namespace LenseguaTranslatorBot.Engine.Definitions.Dtos;

public sealed class BotRequest
{
    public int UpdateId { get; set; }
    public MessageDto Message { get; set; }
}
public class MessageDto
{
    public int MessageId { get; set; }
    public UserDto From { get; set; }
    public ChatDto Chat { get; set; }
    public int Date { get; set; }
    public string Text { get; set; }
    public List<EntityDto> Entities { get; set; }
}

public class UserDto
{
    public int Id { get; set; }
    public bool IsBot { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public string LanguageCode { get; set; }
}

public class ChatDto
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public string Type { get; set; }
}

public class EntityDto
{
    public int Offset { get; set; }
    public int Length { get; set; }
    public string Type { get; set; }
}