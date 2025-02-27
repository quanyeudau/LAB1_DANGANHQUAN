namespace LAB1_DangAnhQuan.Service
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
