﻿using ToyShop.Core.Utils;

namespace ToyShop.Core.Store
{
    public enum StatusCodeHelper
    {
        [CustomName("Success")]
        OK = 200,

        [CustomName("Bad Request")]
        BadRequest = 400,

        [CustomName("Unauthorized")]
        Unauthorized = 401,

        [CustomName("Internal Server Error")]
        ServerError = 500,

        [CustomName("Not found")]
        Notfound = 400
    }
}