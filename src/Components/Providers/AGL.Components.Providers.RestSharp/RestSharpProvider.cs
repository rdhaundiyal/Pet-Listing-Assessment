using System;
using AGL.Components.Providers.Inteface;
using RestSharp;
using AGL.Components.Providers.Inteface.Exception;

namespace AGL.Components.Providers.RestSharp
{
    public class RestSharpProvider : IProvider
    {
        private readonly IRestClient _restClient;

        public string BaseUrl
        {
            set { _restClient.BaseUrl = new Uri(value); }
        }
        public RestSharpProvider()
        {
            _restClient = new RestClient();
        }
        public RestSharpProvider(string baseUrl)
        {
            _restClient = new RestClient(baseUrl);
        }
        public RestSharpProvider(IRestClient restClient)
        {
            _restClient = restClient;
        }

        public T Get<T>(string resource) where T : class, new()
        {
            var response = Execute<T>(resource, Method.GET);
            ValidateResponse(response);
            return response.Data;
        }

        protected virtual RestRequest BuildRestRequest(string resource, Method method)
        {
            return new RestRequest(resource, method) { RequestFormat = DataFormat.Json };

        }

        private IRestResponse<T> Execute<T>(string resource, Method methodType) where T : class, new()
        {
            return _restClient.Execute<T>(BuildRestRequest(resource, methodType)) as RestResponse<T>;
        }
        protected virtual void ValidateResponse(IRestResponse response)
        {
            if (response.ResponseStatus != ResponseStatus.Completed)

                throw new RestException(response.ResponseUri.AbsoluteUri, response.ErrorMessage);
        }
    }
}
