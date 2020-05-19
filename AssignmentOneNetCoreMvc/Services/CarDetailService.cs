using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssignmentOneNetCoreMvc.Data;
using AssignmentOneNetCoreMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace AssignmentOneNetCoreMvc.Services
{
    public class CarDetailService : ICarDetailService
    {
        private readonly ApplicationDbContext _context;
        public CarDetailService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<CarDetail[]> GetCarReportAsync()
        {
            return await _context.Details
              //.Where(x => x.IsDone == false)
              .ToArrayAsync();
        }

        public async Task<bool> AddDetailAsync(CarDetail newDetail)
        {
            newDetail.Id = Guid.NewGuid();
            //newDetail.Make = ;
            //newDetail.Model =;
            //newDetail.Year =;
            //newDetail.Type =;
            //newDetail.IsNew = true;
            //newDetail.DueAt = DateTimeOffset.Now.AddDays(3);

            _context.Details.Add(newDetail);
            var saveResult = await _context.SaveChangesAsync();
            return saveResult == 1;
        }
    }
}
