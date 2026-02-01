using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Säg åt appen att lyssna på port 8080 (Standard för AWS)
builder.WebHost.UseUrls("http://0.0.0.0:8080");

var app = builder.Build();

// En startsida så vi ser att det funkar direkt på länken
app.MapGet("/", () => "API:et är igång! Lägg till /encrypt?text=test&shift=1 i adressen.");

// Endpoint 1: Kryptera
app.MapGet("/encrypt", ([FromQuery] string text, [FromQuery] int shift) =>
{
    return Results.Ok(CipherHelper.CaesarCipher(text, shift));
});

// Endpoint 2: Avkryptera
app.MapGet("/decrypt", ([FromQuery] string text, [FromQuery] int shift) =>
{
    return Results.Ok(CipherHelper.CaesarCipher(text, -shift));
});

app.Run();

// Hjälpklass
public static class CipherHelper
{
    public static string CaesarCipher(string input, int shift)
    {
        if (string.IsNullOrEmpty(input)) return "";
        
        char[] buffer = input.ToCharArray();
        for (int i = 0; i < buffer.Length; i++)
        {
            char letter = buffer[i];
            if (char.IsLetter(letter))
            {
                char offset = char.IsUpper(letter) ? 'A' : 'a';
                buffer[i] = (char)((((letter + shift) - offset) % 26 + 26) % 26 + offset);
            }
        }
        return new string(buffer);
    }
}