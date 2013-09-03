﻿using System;
using ReallySimpleRestClient.Http.DataPackets;

namespace ReallySimpleRestClient.Http
{
    public class ErrorResponseException: Exception
    {
        public Errors Errors { get; set; }
        public HttpResponseMessage Response { get; private set; }

        public ErrorResponseException(HttpResponseMessage response, Errors errors, string message)
            : base(message)
        {
            Errors = errors;
            Response = response;
        }

        public override string ToString()
        {
            return Response.StatusCode + ":" + base.ToString();
        }
    }
}
