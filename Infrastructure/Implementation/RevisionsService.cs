using Getallpaper_admin.Models;
using Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Implementation
{
    public class RevisionsService : IRevisionsService
    {
        public RevisionsService() { }
        public async Task<List<AsRevision>> GetAllRevision()
        {
            try
            {
                List<AsRevision> list = new List<AsRevision>();
                using var _context = new WritingfactorPortalDbContext();
                var revision = await _context.AsRevisions.ToListAsync();
                return revision;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<AsRevision> DeleteRevision(AsRevision obj)
        {
            try
            {
                using var _context = new WritingfactorPortalDbContext();
                var revision = await _context.AsRevisions.SingleOrDefaultAsync(x => x.Id == obj.Id);
                if (revision != null)
                {
                    _context.AsRevisions.Remove(revision);
                    _context.SaveChanges();
                }
                return obj;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<AsRevision> UpdateRevision(AsRevision obj)
        {
            try
            {
                using var _context = new WritingfactorPortalDbContext();
                var revision = await _context.AsRevisions.Where(x => x.Id == obj.Id).FirstOrDefaultAsync();
                if (revision != null)
                {
                    revision.Description = obj.Description;
                    revision.Verified = obj.Verified;
                    revision.VerifiedBy = obj.VerifiedBy;
                    revision.Phone = obj.Phone;
                    _context.AsRevisions.Update(revision);
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
