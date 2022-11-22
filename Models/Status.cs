using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class Status
    {
        public static bool LoginCRM(Employee user)
        {
            return ((user.UserStatus == UserStatus.Admin)
                || (user.UserStatus == UserStatus.CrmManager) ||
                (user.UserStatus == UserStatus.Buyer) || (user.UserStatus == UserStatus.Seller))&& (user.Deleted ==false);
        }
        public static bool LoginBSG(Employee user)
        {
            return ((user.UserStatus == UserStatus.Admin)
                || (user.UserStatus == UserStatus.Buyer) || (user.UserStatus == UserStatus.Seller))&& (user.Deleted ==false);
        }

        public static bool LoginPricing(Employee user)
        {
            return ((user.UserStatus == UserStatus.Admin)
                || (user.UserStatus == UserStatus.SeniorPricer) || (user.UserStatus == UserStatus.Pricer))&& (user.Deleted== false);
        }
        public static bool EntryRights(Employee user)
        {
            return (user.UserStatus == UserStatus.Admin)
                || (user.UserStatus == UserStatus.CrmManager);
        }
        public static bool BGEntryRights(Employee user)
        {
            return (user.UserStatus == UserStatus.Admin)
                            || (user.UserStatus == UserStatus.Buyer);
        }
        public static bool SGEntryRights(Employee user)
        {
            return (user.UserStatus == UserStatus.Admin)
                            || (user.UserStatus == UserStatus.Seller);
        }
        public static bool LPEntryRights(Employee user)
        {
            return (user.UserStatus == UserStatus.Admin)
                            || (user.UserStatus == UserStatus.SeniorPricer);
        }
        public static bool AdminRighs(Employee user)
        {
            return user.UserStatus == UserStatus.Admin;
        }

    }
}
