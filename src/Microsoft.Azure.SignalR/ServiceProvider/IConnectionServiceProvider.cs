﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.SignalR;

namespace Microsoft.Azure.SignalR
{
    public interface IConnectionServiceProvider
    {
        string GetEndpoint();

        string GetAccessToken();

        string GenerateClientAccessToken<THub>(IEnumerable<Claim> claims = null, TimeSpan? lifetime = null) where THub : Hub;

        string GenerateClientAccessToken(string hubName, IEnumerable<Claim> claims = null, TimeSpan? lifetime = null);

        string GenerateServerAccessToken<THub>(TimeSpan? lifetime = null) where THub : Hub;

        string GenerateServerAccessToken(string hubName, TimeSpan? lifetime = null);

        string GetClientEndpoint<THub>() where THub : Hub;

        string GetClientEndpoint(string hubName);

        string GetServerEndpoint<THub>() where THub : Hub;

        string GetServerEndpoint(string hubName);
    }
}