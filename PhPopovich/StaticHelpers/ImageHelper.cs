﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;
using PhPopovich.Models;

namespace PhPopovich.StaticHelpers
{
    public static class ImageHelper
    {
        public static string GetFullUrl(this ImageModel imageModel, HttpRequest httpRequest)
        {
            var url = $@"{HttpScheme.Http}://{httpRequest.Host.Value}{imageModel?.Url}";
            return url;
        }
    }
}