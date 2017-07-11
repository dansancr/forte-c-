using System;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;

namespace ForteSdk
{
    internal static class Requestor
    {
        public static RequestorResponse PostString<T>(string url, T content, string username, string password, string authOrganizationId)
        {
            string jsonString = JsonConvert.SerializeObject(content);
            RequestorResponse requestorResponse = GetResponse(url, "POST", jsonString, username, password, authOrganizationId);
            return requestorResponse;
        }

        public static RequestorResponse Get(string URL, string username, string password, string authOrganizationId)
        {
            RequestorResponse requestorResponse = GetResponse(URL, "GET", "", username, password, authOrganizationId);
            return requestorResponse;
        }

        public static RequestorResponse PutString<T>(string url, T content, string username, string password, string authOrganizationId)
        {
            string jsonString = JsonConvert.SerializeObject(content);
            RequestorResponse requestorResponse = GetResponse(url, "PUT", jsonString, username, password, authOrganizationId);
            return requestorResponse;
        }

        public static RequestorResponse Delete(string URL, string username, string password, string authOrganizationId)
        {
            RequestorResponse requestorResponse = GetResponse(URL, "DELETE", "", username, password, authOrganizationId);
            return requestorResponse;
        }

        private static string ReadStream(Stream stream)
        {
            using (var reader = new StreamReader(stream, Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }

        internal static RequestorResponse GetResponse(String URL, String method, string requestBody, string username, string password, string authOrganizationId)
        {
            HttpResponseMessage response;
            using (var client = new HttpClient())
            {
                string authHeaderText = Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(string.Format("{0}:{1}", username, password)));
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", authHeaderText);
                client.DefaultRequestHeaders.Add("x-forte-auth-organization-id", authOrganizationId);

                StringContent content = new System.Net.Http.StringContent(requestBody, Encoding.UTF8, "application/json");
                try
                {
                    switch ((method).ToUpper())
                    {
                        default:
                        case "GET":
                            response = client.GetAsync(URL).Result;
                            break;

                        case "POST":
                            response = client.PostAsync(URL, content).Result;
                            break;

                        case "PUT":
                            response = client.PutAsync(URL, content).Result;
                            break;

                        case "DELETE":
                            response = client.DeleteAsync(URL).Result;
                            break;
                    }
                }
                catch (AggregateException webException)
                {
                    if (webException.Data != null)
                    {
                        var forteError = new ForteError();
                        forteError.ErrorType = "AggregateException";
                        forteError.Message = webException.InnerException.ToString();
                        var statusCode = HttpStatusCode.Forbidden;
                        throw new ForteException(statusCode, forteError, forteError.Message);
                    }

                    throw;
                }
                catch (WebException webException)
                {
                    if (webException.Response != null)
                    {
                        var statusCode = ((HttpWebResponse)webException.Response).StatusCode;

                        var forteError = new ForteError();

                        if (webException.Response.ResponseUri.ToString().Contains("oauth"))
                            forteError = Mapper<ForteError>.MapFromJson(ReadStream(webException.Response.GetResponseStream()));
                        else
                            forteError = Mapper<ForteError>.MapFromJson(ReadStream(webException.Response.GetResponseStream()), "error");

                        throw new ForteException(statusCode, forteError, forteError.Message);
                    }

                    throw;
                }
                catch (Exception ex)
                {
                    throw ex;
                }


                RequestorResponse requestorResponse = new RequestorResponse();
                
                if (response != null && response.IsSuccessStatusCode)
                {
                    requestorResponse.Content = response.Content.ReadAsStringAsync().Result;
                    requestorResponse.StatusCode = response.StatusCode;

                    switch ((method).ToUpper())
                    {
                        case "POST":
                            requestorResponse.Message = "Record Successfully.";
                            break;

                        case "PUT":
                            requestorResponse.Message = "Record Successfully Updated.";
                            break;

                        case "DELETE":
                            requestorResponse.Message = "Record Successfully Deleted.";
                            break;

                        default:
                            break;
                    }
                    return requestorResponse;
                }
                else if (response != null && !(response.IsSuccessStatusCode))
                {
                    requestorResponse.Content = response.Content.ReadAsStringAsync().Result;
                    requestorResponse.StatusCode = response.StatusCode;
                    requestorResponse.Message = "#ERROR#";
                    return requestorResponse;
                }
                else
                {
                    requestorResponse.Content = response.Content.ReadAsStringAsync().Result;
                    requestorResponse.Message = "#ERROR#";
                    return requestorResponse;
                }
            }


        }
    }
}