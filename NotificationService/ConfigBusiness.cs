using NotificationService.Interface;
using Newtonsoft.Json;

namespace NotificationService
{
    public class ConfigBusiness : IConfigBusiness
    {
        private readonly IConfigRepository _configRepository;

        public ConfigBusiness(IConfigRepository configRepository)
        {
            _configRepository = configRepository;
        }

        public T? GetConfigValue<T>(string key)
        {
            return _configRepository.GetConfigValue<T>(key);
        }

    }

}
