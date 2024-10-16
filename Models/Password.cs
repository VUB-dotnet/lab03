namespace PasswordsApp.Models;

public class Password
{
    public int Length { get; set; }
    public string? Value { get; set; }

    public string GeneratePassword()
    {
        const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        var random = new Random();
        return new string(Enumerable.Repeat(validChars, Length)
                                    .Select(s => s[random.Next(s.Length)]).ToArray());
    }
}
