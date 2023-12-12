using Getallpaper_admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interface
{
    public interface IAuthService
    {
        public Task<AsUser> authenticate(AsUser obj);
    }
}
