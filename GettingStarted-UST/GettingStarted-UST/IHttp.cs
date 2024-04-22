namespace GettingStarted_UST
{
    internal interface IHttp
    {
        void send(string data);
        string receive();
    }
}
