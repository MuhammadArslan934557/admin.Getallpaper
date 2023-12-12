using Getallpaper_admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interface
{
    public interface IOrderService
    {
        public Task<List<AsOrder>> GetAllUnpaidOrder();
        public Task<AsOrder> DeleteUnpaidOrder(AsOrder obj);
        public Task<AsOrder> UpdateUnpaidOrder(AsOrder obj);
        public Task<List<AsOrder>> GetAllpaidOrder();
        public Task<AsOrder> DeletepaidOrder(AsOrder obj);
        public Task<AsOrder> UpdatepaidOrder(AsOrder obj);
        public Task<List<AsOrder>> GetAllOrder();
        public Task<AsOrder> DeleteOrder(AsOrder obj);
        public Task<AsOrder> UpdateOrder(AsOrder obj);
    }
}
