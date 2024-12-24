﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contratos.Domain.Enum
{
    public enum RoleEnum
    {
        Admin = 1,
        User
    }

    public static class RoleEnumExtension
    {
        public static string GetRoleName(this RoleEnum role)
        {
            return role switch
            {
                RoleEnum.Admin => "Admin",
                RoleEnum.User => "User",
                _ => "User"
            };
        }
    }
}