﻿using N70.Identity.Application.Common.Enums;

namespace N70.Identity.Application.Common.Identity.Models;

public class VerificationToken
{
    public Guid UserId { get; set; }
    
    public VerificationType VerificationType { get; set; }
    
    public DateTimeOffset ExpiryTime { get; set; }
}