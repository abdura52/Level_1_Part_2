﻿namespace N70.Identity.Api.Configuration;

public static partial class HostConfiguration
{
    public static ValueTask<WebApplicationBuilder> ConfigureAsync(this WebApplicationBuilder builder)
    {
        builder
            .AddPersistence()
            .AddIdentityInfrastructure()
            .AddNotificationInfrastructure()
            .AddDevTools()
            .AddExposers();

        return new(builder);
    }

    public static ValueTask<WebApplication> ConfigureAsync(this WebApplication app)
    {
        app
            .UseIdentityInfrastructure()
            .UseDevTools()
            .UseExposers();

        return new(app);
    }
}