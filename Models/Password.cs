namespace PasswordsApp.Models;

public class Password
{
    public int Length { get; set; }
    public string? Value { get; set; }

    public void GeneratePassword()
    {
        const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        var random = new Random();
        Value = new string(Enumerable.Repeat(validChars, Length)
                                    .Select(s => s[random.Next(s.Length)]).ToArray());
    }
}
