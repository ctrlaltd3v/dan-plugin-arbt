using System;

namespace Altinn.Dan.Plugin.Arbeidstilsynet.Config
{
    public interface IApplicationSettings
    {
        string RedisConnectionString { get; }
        TimeSpan Breaker_RetryWaitTime { get; }
        TimeSpan Breaker_OpenCircuitTime { get; }
        bool IsTest { get; }
        string BemanningUrl { get; }
        string RenholdUrl { get; }
    }
}
