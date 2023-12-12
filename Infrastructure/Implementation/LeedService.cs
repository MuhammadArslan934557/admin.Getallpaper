using Getallpaper_admin.Models;
using Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Implementation
{
    public class LeedService : ILeedService
    {
        public LeedService() { }
        public async Task<List<AsLeed>> GetAllLeed()
        {
            try
            {
                List<AsLeed> list = new List<AsLeed>();
                using var _context = new WritingfactorPortalDbContext();
                var user = _context.AsLeeds.Select(x => new AsLeed
                {
                    LeedId  = x.LeedId,
                    LeedDate = x.LeedDate,
                    Email = x.Email,
                    Pageno = x.Pageno,
                    Phone = x.Phone,
                    Price = x.Price,
                    Documentype = x.Documentype,
                    Level = x.Level,
                    DueDate = x.DueDate,
                    Status = x.Status,
                }).ToList();
                return user;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<AsLeed> UpdateLeed(AsLeed obj)
        {
            try
            {
                using var _context = new WritingfactorPortalDbContext();
                var leed = _context.AsLeeds.Where(x => x.LeedId == obj.LeedId).ToList();
                if (leed.Count > 0)
                {
                    leed[0].Level = obj.Level;
                    leed[0].Price = obj.Price;
                    leed[0].Status = obj.Status;
                    leed[0].Phone = obj.Phone;
                    _context.AsLeeds.Update(leed[0]);
                    _context.SaveChanges();
                }
                return obj;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<AsLeed> DeleteLeed(AsLeed obj)
        {
            try
            {
                using var _context = new WritingfactorPortalDbContext();
                var Leed = _context.AsLeeds.SingleOrDefault(x => x.LeedId == obj.LeedId);
                if (Leed != null)
                {
                    _context.AsLeeds.Remove(Leed);
                    _context.SaveChanges();
                }
                return obj;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
