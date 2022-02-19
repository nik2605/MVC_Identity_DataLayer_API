using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_Identity_DataLayer.Models;
using MVC_Identity_DataLayer_Data;

namespace MVC_Identity_DataLayer.Mapper
{
    public static class UserModelMapper
    {
        public static UserModel Map(this User.UserDetails details)
        {
            return new UserModel()
            {
                UserId = details.UserId,
                FirstName = details.FirstName,
                LastName = details.LastName,
                Name = details.FirstName + " " + details.LastName
            };
        }
    }
}