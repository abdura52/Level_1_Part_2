﻿using N53_HT1.Api.Interfaces;

namespace N53_HT1.Api.Services;

public class SmsSenderService : INotificationService
{
    public ValueTask SendAsync(Guid userId, string content)
    {
        Console.WriteLine($"Sending sms to {userId} with content: {content}");

        return new ValueTask();
    }
}
