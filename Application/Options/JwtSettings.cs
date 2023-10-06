namespace ContinentalFoods.Application.Options;

public class JwtSettings
{
    public string SigningKey { get; set; }
    public double AccessTokenExpirationMinutes { get; set; }
    public string Issuer { get; set; }
    public string[] Audiences { get; set; }
    public string RefreshTokenSecret { get; set; }
    public double RefreshTokenExpirationMinutes { get; set; }
}