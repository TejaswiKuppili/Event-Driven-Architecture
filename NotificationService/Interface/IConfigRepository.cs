namespace NotificationService.Interface
{
    public interface IConfigRepository
    {
        T? GetConfigValue<T>(string Key);
    }
}
