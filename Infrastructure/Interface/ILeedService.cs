using Getallpaper_admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interface
{
    public interface ILeedService
    {
        public Task<List<AsLeed>> GetAllLeed();
        public Task<AsLeed> UpdateLeed(AsLeed obj);
        public Task<AsLeed> DeleteLeed(AsLeed obj);
    }
}
