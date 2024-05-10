namespace BookerAPIRequests;

using System;
using RestSharp;

public class RestBookerAPI
{
    public static async Task<RestResponse> createBooking()
    {
        var options = new RestClientOptions("https://restful-booker.herokuapp.com")
        {
            MaxTimeout = -1,
        };
        var client = new RestClient(options);
        var request = new RestRequest("/booking", Method.Post);
        request.AddHeader("Content-Type", "application/json");
        var body = @"{
" + "\n" +
        @"    ""firstname"" : ""Jim"",
" + "\n" +
        @"    ""lastname"" : ""Brown"",
" + "\n" +
        @"    ""totalprice"" : 111,
" + "\n" +
        @"    ""depositpaid"" : true,
" + "\n" +
        @"    ""bookingdates"" : {
" + "\n" +
        @"        ""checkin"" : ""2018-01-01"",
" + "\n" +
        @"        ""checkout"" : ""2019-01-01""
" + "\n" +
        @"    },
" + "\n" +
        @"    ""additionalneeds"" : ""Breakfast""
" + "\n" +
        @"}";
        request.AddStringBody(body, DataFormat.Json);
        RestResponse response = await client.ExecuteAsync(request);
        Console.WriteLine(response.Content);
        return response;
    }

    public static async Task<RestResponse> deleteBooking()
    {
        var options = new RestClientOptions("https://restful-booker.herokuapp.com")
        {
            MaxTimeout = -1,
        };
        var client = new RestClient(options);
        var request = new RestRequest("/booking/1421", Method.Delete);
        request.AddHeader("Authorization", "Basic YWRtaW46cGFzc3dvcmQxMjM=");
        RestResponse response = await client.ExecuteAsync(request);
        Console.WriteLine(response.Content);
        return response;
    }

    public static async Task<RestResponse> doAuth()
    {
        var options = new RestClientOptions("https://restful-booker.herokuapp.com")
        {
            MaxTimeout = -1,
        };
        var client = new RestClient(options);
        var request = new RestRequest("/auth", Method.Post);
        request.AddHeader("Content-Type", "application/json");
        var body = @"{
" + "\n" +
        @"    ""username"" : ""admin"",
" + "\n" +
        @"    ""password"" : ""password123""
" + "\n" +
        @"}";
        request.AddStringBody(body, DataFormat.Json);
        RestResponse response = await client.ExecuteAsync(request);
        Console.WriteLine(response.Content);
        return response;
    }

    public static async Task<RestResponse> getBookingDetails()
    {
        var options = new RestClientOptions("https://restful-booker.herokuapp.com")
        {
            MaxTimeout = -1,
        };
        var client = new RestClient(options);
        var request = new RestRequest("/booking/358", Method.Get);
        RestResponse response = await client.ExecuteAsync(request);
        Console.WriteLine(response.Content);
        return response;
    }

    public static async Task<RestResponse> getBookingIds()
    {
        var options = new RestClientOptions("https://restful-booker.herokuapp.com")
        {
            MaxTimeout = -1,
        };
        var client = new RestClient(options);
        var request = new RestRequest("/booking", Method.Get);
        var body = @"";
        request.AddParameter("text/plain", body, ParameterType.RequestBody);
        RestResponse response = await client.ExecuteAsync(request);
        Console.WriteLine(response.Content);
        return response;
    }

    public static async Task<RestResponse> updateBooking()
    {
        var options = new RestClientOptions("https://restful-booker.herokuapp.com")
        {
            MaxTimeout = -1,
        };
        var client = new RestClient(options);
        var request = new RestRequest("/booking/1620", Method.Put);
        request.AddHeader("Cookie", "token=95195ec5a9853c2");
        request.AddHeader("Authorization", "Basic YWRtaW46cGFzc3dvcmQxMjM=");
        request.AddHeader("Content-Type", "application/json");
        var body = @"{
" + "\n" +
        @"    ""firstname"" : ""James"",
" + "\n" +
        @"    ""lastname"" : ""Brown"",
" + "\n" +
        @"    ""totalprice"" : 111,
" + "\n" +
        @"    ""depositpaid"" : true,
" + "\n" +
        @"    ""bookingdates"" : {
" + "\n" +
        @"        ""checkin"" : ""2018-01-01"",
" + "\n" +
        @"        ""checkout"" : ""2019-01-01""
" + "\n" +
        @"    },
" + "\n" +
        @"    ""additionalneeds"" : ""Breakfast""
" + "\n" +
        @"}";
        request.AddStringBody(body, DataFormat.Json);
        RestResponse response = await client.ExecuteAsync(request);
        Console.WriteLine(response.Content);
        return response;
    }

    public static async Task<RestResponse> updatePartialBooking()
    {
        var options = new RestClientOptions("https://restful-booker.herokuapp.com")
        {
            MaxTimeout = -1,
        };
        var client = new RestClient(options);
        var request = new RestRequest("/booking/1620", Method.Patch);
        request.AddHeader("Cookie", "token=95195ec5a9853c2");
        request.AddHeader("Content-Type", "application/json");
        var body = @"{
" + "\n" +
        @"    ""firstname"" : ""James"",
" + "\n" +
        @"    ""lastname"" : ""Brown""
" + "\n" +
        @"}";
        request.AddStringBody(body, DataFormat.Json);
        RestResponse response = await client.ExecuteAsync(request);
        Console.WriteLine(response.Content);
        return response;
    }
}
