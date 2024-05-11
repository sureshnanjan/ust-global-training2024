namespace RestfulBookerAPI
{
    public class RestfulBooker
    {
        public static async void DoTestDemo() {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://restful-booker.herokuapp.com/auth");
            var content = new StringContent("{\r\n    \"username\" : \"admin\",\r\n    \"password\" : \"wring\"\r\n}", null, "application/json");
            request.Content = content;
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            Console.WriteLine(await response.Content.ReadAsStringAsync());

        }





    }
}
