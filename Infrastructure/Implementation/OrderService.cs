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
    public class OrderService : IOrderService
    {
        public OrderService() { }
        public async Task<List<AsOrder>> GetAllUnpaidOrder()
        {
            try
            {
                List<AsOrder> list = new List<AsOrder>();
                using var _context = new WritingfactorPortalDbContext();
                var order = await _context.AsOrders.Where(x=>x.Payment.ToLower().Trim() == "unpaid").ToListAsync();
                return order;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<AsOrder> DeleteUnpaidOrder(AsOrder obj)
        {
            try
            {
                using var _context = new WritingfactorPortalDbContext();
                var order = await _context.AsOrders.SingleOrDefaultAsync(x => x.Id == obj.Id);
                if (order != null)
                {
                    _context.AsOrders.Remove(order);
                    _context.SaveChanges();
                }
                return obj;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<AsOrder> UpdateUnpaidOrder(AsOrder obj)
        {
            try
            {
                using var _context = new WritingfactorPortalDbContext();
                var order = await _context.AsOrders.Where(x => x.Id == obj.Id).FirstOrDefaultAsync();
                if (order != null)
                {
                    order.Pages = obj.Pages;
                    order.Price = obj.Price;
                    order.Payment = obj.Payment;
                    order.Phone = obj.Phone;
                    order.OrderStatus = obj.OrderStatus;
                    order.Citation = obj.Citation;
                    _context.AsOrders.Update(order);
                    _context.SaveChanges();
                }
                return obj;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<AsOrder>> GetAllpaidOrder()
        {
            try
            {
                List<AsOrder> list = new List<AsOrder>();
                using var _context = new WritingfactorPortalDbContext();
                var order = await  _context.AsOrders.Where(x => x.Payment.ToLower().Trim() == "paid").ToListAsync();
                return order;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<AsOrder> DeletepaidOrder(AsOrder obj)
        {
            try
            {
                using var _context = new WritingfactorPortalDbContext();
                var order = await _context.AsOrders.SingleOrDefaultAsync(x => x.Id == obj.Id);
                if (order != null)

                {
                    _context.AsOrders.Remove(order);
                    _context.SaveChanges();
                }
                return obj;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<AsOrder> UpdatepaidOrder(AsOrder obj)
        {
            try
            {
                using var _context = new WritingfactorPortalDbContext();
                var order = await _context.AsOrders.Where(x => x.Id == obj.Id).FirstOrDefaultAsync();
                if (order != null)
                {
                    order.Pages = obj.Pages;
                    order.Price = obj.Price;
                    order.Payment = obj.Payment;
                    order.Phone = obj.Phone;
                    order.OrderStatus = obj.OrderStatus;
                    order.Citation = obj.Citation;
                    _context.AsOrders.Update(order);
                    _context.SaveChanges();
                }
                return obj;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<AsOrder>> GetAllOrder()
        {
            try
            {
                List<AsOrder> list = new List<AsOrder>();
                using var _context = new WritingfactorPortalDbContext();
                var order = await _context.AsOrders.ToListAsync();
                return order;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<AsOrder> DeleteOrder(AsOrder obj)
        {
            try
            {
                using var _context = new WritingfactorPortalDbContext();
                var order = await _context.AsOrders.SingleOrDefaultAsync(x => x.Id == obj.Id);
                if (order != null)
                {
                    _context.AsOrders.Remove(order);
                    _context.SaveChanges();
                }
                return obj;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<AsOrder> UpdateOrder(AsOrder obj)
        {
            try
            {
                using var _context = new WritingfactorPortalDbContext();
                var order = await _context.AsOrders.Where(x => x.Id == obj.Id).FirstOrDefaultAsync();
                if (order != null)
                {
                    order.Pages = obj.Pages;
                    order.Price = obj.Price;
                    order.Payment = obj.Payment;
                    order.Phone = obj.Phone;
                    order.OrderStatus = obj.OrderStatus;
                    order.Citation = obj.Citation;
                    _context.AsOrders.Update(order);
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
