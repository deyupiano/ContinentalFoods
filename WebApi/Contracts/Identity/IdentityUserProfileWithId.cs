﻿namespace ContinentalFoods.WebApi.Contracts.Identity;

public class IdentityUserProfileWithId
{
    public string? IdentityId { get; set; }
    public string? UserName { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? EmailAddress { get; set; }
    public string? Phone { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? CurrentCity { get; set; }
    public string? Token { get; set; }
    public DateTime AccessTokenExpirationTime { get; set; }
    public string RefreshToken { get; set; }
}