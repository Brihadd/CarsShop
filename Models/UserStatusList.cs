using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class UserStatusList
    {
        public static List<UserStatus> AdminList = Enum.GetValues(typeof(UserStatus))
                            .Cast<UserStatus>()
                            .ToList();


    }
}
