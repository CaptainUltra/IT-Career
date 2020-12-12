using MiniHTTPServer.HTTP.Common;
using MiniHTTPServer.HTTP.Enums;
using MiniHTTPServer.HTTP.Exceptions;
using MiniHTTPServer.HTTP.Extensions;
using MiniHTTPServer.HTTP.Headers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniHTTPServer.HTTP.Requests
{
    public class HttpRequest : IHttpRequest
    {
        public HttpRequest(string requestString)
        {
            CoreValidator.ThrowIfNullOrEmpty(requestString, nameof(requestString));

            this.FormData = new Dictionary<string, object>();
            this.QueryData = new Dictionary<string, object>();
            this.Headers = new HttpHeaderCollection();

            this.ParseRequest(requestString);
        }
        public string Path { get; private set; }

        public string Url { get; private set; }

        public Dictionary<string, object> FormData { get; }

        public Dictionary<string, object> QueryData { get; }

        public IHttpHeaderCollection Headers { get; }

        public HttpRequestMethod RequestMethod { get; private set; }

        private void ParseRequest(string requestString)
        {
            string[] splitRequest = requestString.Split(new[] { GlobalConstants.HttpNewLine }, StringSplitOptions.None);
            string[] requestLine = splitRequest[0].Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if(!this.IsValidRequestLine(requestLine))
            {
                throw new BadRequestException();
            }

            this.ParseRequestMethod(requestLine);
            this.ParseRequestUrl(requestLine);
            this.ParseRequestPath();

            this.ParseHeaders(splitRequest.Skip(1).ToArray());
            //this.ParseCookies();

            this.ParseRequestParameters(splitRequest[splitRequest.Length -1]);
        }

        private bool IsValidRequestLine(string[] requestLine)
        {
            if (requestLine.Length != 3)
            {
                return false;
            }
            if(requestLine[2] != GlobalConstants.HttpOneProtocolFragment)
            {
                return false;
            }
            return true;
        }
        private bool IsValidRequestQueryString(string queryString, string[] queryParameters)
        {
            if(String.IsNullOrEmpty(queryString))
            {
                return false;
            }    
            if(queryParameters.Length < 1)
            {
                return false;
            }
            return true;
        }
        private void ParseRequestMethod(string[] requestLine)
        {
            bool parseResult = HttpRequestMethod.TryParse(requestLine[0], true, out HttpRequestMethod method);

            if (!parseResult)
            {
                throw new BadRequestException($"Unsupported Method: {requestLine[0]}");
            }

            this.RequestMethod = method;
        }
        private void ParseRequestUrl(string[] requestLine)
        {
            this.Url = requestLine[1];
        }
        private void ParseRequestPath()
        {
            this.Path = this.Url.Split(new char[] { '?' }, StringSplitOptions.RemoveEmptyEntries)[0];
        }
        private void ParseHeaders(string[] requestContent)
        {
            foreach (var item in requestContent)
            {
                if (String.IsNullOrEmpty(item)) continue;
                var headerString = item.Split(": ", StringSplitOptions.RemoveEmptyEntries);

                this.Headers.AddHeader(new HttpHeader(headerString[0], headerString[1]));
            }
        }
        private void ParseCookies()
        {
            throw new NotImplementedException();
        }
        private void ParseQueryParameters()
        {
            string queryString = this.Url.IndexOf('?') > -1
                ? this.Url.Split(new char[] { '?', '#' }, StringSplitOptions.RemoveEmptyEntries)[1]
                : string.Empty;

            var queryParameters = queryString.Split('&');

            if (this.IsValidRequestQueryString(queryString, queryParameters))
            {
                foreach (var item in queryParameters)
                {
                    var pair = item.Split('=');
                    this.QueryData.Add(pair[0], pair[1]);
                }
            }
        }
        private void ParseFormDataParameters(string formData)
        {
            if (!string.IsNullOrEmpty(formData))
            {
                var formDataParameters = formData.Split('&');
                foreach (var item in formDataParameters)
                {
                    var pair = item.Split('=');
                    this.FormData.Add(pair[0], pair[1]);
                }
            }
        }
        private void ParseRequestParameters(string formData)
        {
            ParseQueryParameters();
            ParseFormDataParameters(formData);
        }
    }
}
