﻿using MiniHTTPServer.HTTP.Common;
using MiniHTTPServer.HTTP.Enums;
using MiniHTTPServer.HTTP.Headers;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniHTTPServer.HTTP.Responses
{
    public class HttpResponse : IHttpResponse
    {
        public HttpResponse()
        {
            this.Headers = new HttpHeaderCollection();
            this.Content = new byte[0];
        }
        public HttpResponse(HttpResponseStatusCode statusCode)
            :this()
        {
            CoreValidator.ThrowIfNull(statusCode, nameof(statusCode));
            this.StatusCode = statusCode;
        }
        public HttpResponseStatusCode StatusCode { get; set; }

        public IHttpHeaderCollection Headers { get; }

        public byte[] Content { get; set; }

        public void AddHeader(HttpHeader header)
        {
            CoreValidator.ThrowIfNull(header, nameof(header));
            this.Headers.AddHeader(header);
        }

        public byte[] GetBytes()
        {
            byte[] upperResponse = Encoding.UTF8.GetBytes(this.ToString());
            byte[] lowerResponse = this.Content;

            byte[] totalResponse = new byte[upperResponse.Length + lowerResponse.Length];

            for (int i = 0; i < upperResponse.Length; i++)
            {
                totalResponse[i] = upperResponse[i];
            }

            for (int i = upperResponse.Length; i < totalResponse.Length; i++)
            {
                totalResponse[i] = lowerResponse[i - upperResponse.Length];
            }

            return totalResponse;
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append($"{GlobalConstants.HttpOneProtocolFragment} {(int)this.StatusCode} {this.StatusCode.ToString()}")
                .Append(GlobalConstants.HttpNewLine)
                .Append(this.Headers.ToString())
                .Append(GlobalConstants.HttpNewLine);

            result.Append(GlobalConstants.HttpNewLine);

            return result.ToString();
        }
    }
}
