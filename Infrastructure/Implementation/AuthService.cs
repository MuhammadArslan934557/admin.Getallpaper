using Getallpaper_admin.Models;
using Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Implementation
{
    public class AuthService:IAuthService
    {
        public async Task<AsUser> authenticate(AsUser obj)
        {
            //using var _context = new WritingfactorPortalDbContext();
            //var AsUser = await _context.AsUsers.Where(x =>  x.Email.Equals(obj.Email)).FirstOrDefaultAsync();
            //if (AsUser == null)
            //{
            //    return new AsUser()
            //    {
            //        Email = "No User found!"
            //    };
            //}
            //else
            //{
            //    return obj;
            //}
            try
            {
                using var _context = new WritingfactorPortalDbContext();
                var AsUser = await _context.AsUsers.FirstOrDefaultAsync(x => x.Email.Equals(obj.Email));//x => x.Password.Equals(obj.Password) && 
                if (AsUser is not null)
                {
                    return new AsUser()
                    {
                        Email = "User found!",
                        Password = AsUser.Password,
                    };
                }
                else
                {
                    return new AsUser()
                    {
                        Email = "No User found!"
                    };
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
