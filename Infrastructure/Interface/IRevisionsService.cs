using Getallpaper_admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interface
{
    public interface IRevisionsService
    {
        public Task<List<AsRevision>> GetAllRevision();
        public Task<AsRevision> DeleteRevision(AsRevision obj);
        public Task<AsRevision> UpdateRevision(AsRevision obj);
    }
}
