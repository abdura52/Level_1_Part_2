﻿namespace N90_HT1.Domain.Common.Caching;

/// <summary>
///     Defines cache model properties
/// </summary>
public interface ICacheModel
{
    /// <summary>
    ///     Gets computed cache key.
    /// </summary>
    string CacheKey { get; }
}