﻿
using ContinentalFoods.Application.Identity.Dtos;
using ContinentalFoods.Application.Models;
using MediatR;

namespace ContinentalFoods.Application.Identity.Commands;

public class RegisterIdentity : IRequest<OperationResult<IdentityUserProfileDto>>
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Phone { get; set; }
    public string CurrentCity { get; set; }
}