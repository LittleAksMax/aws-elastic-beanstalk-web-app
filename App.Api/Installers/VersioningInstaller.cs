﻿namespace App.Api.Installers;

internal sealed class VersioningInstaller : InstallerSingleton<VersioningInstaller>
{
    public override void InstallServices(WebApplicationBuilder builder)
    {
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddApiVersioning();
        builder.Services.AddVersionedApiExplorer(options =>
        {
            options.AssumeDefaultVersionWhenUnspecified = true;
            options.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
        });
    }
}