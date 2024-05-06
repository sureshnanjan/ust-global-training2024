namespace BookerAPIRequests;

using System;
using RestSharp;

public class RestBookerAPI
{
    public static void createBooking()
    {
        throw new NotImplementedException();
    }

    public static void deleteBooking()
    {
        throw new NotImplementedException();
    }

    public static async void doAuth()
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
    }

    public static void getBookingDetails()
    {
        throw new NotImplementedException();
    }

    public static void getBookingIds()
    {
        throw new NotImplementedException();
    }

    public static void updateBooking()
    {
        throw new NotImplementedException();
    }

    public static void updatePartialBooking()
    {
        throw new NotImplementedException();
    }
}
