using template_net_9.DTOs;
using template_net_9.Entities;
using template_net_9.Entities.Employees;

namespace template_net_9.Extensions
{
    public static class LegacyUserPublicDTOExtensions
    {
        public static LegacyUserPublicDTO InjectFileNumber(this LegacyUserPublicDTO user, List<Employee> employees)
        {
            var employee = employees.Find(e => e.LegacyUserId == user.Id);
            if (employee != null)
            {
                user.FileNumber = (int)employee.FileNumber;
            }
            return user;
        }

        public static LegacyUserPublicDTO InjectFileNumberForProviders(this LegacyUserPublicDTO user, List<Provider> providers)
        {
            var provider = providers.Find(e => e.LegacyUserId == user.Id);
            if (provider == null) return user;
            if (provider.FileNumber != null) user.FileNumber = (int)provider.FileNumber;
            return user;
        }
    }
}
