using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssignmentOneNetCoreMvc.Models;
using Microsoft.VisualBasic;

namespace AssignmentOneNetCoreMvc.Services
{
    public class FakeCarDetailService : ICarDetailService
    {
        public Task<CarDetail[]> GetCarReportAsync()
        {
            var item1 = new CarDetail
            {
                Make = "Totyota",
                Model = "Yaris",
                Year= 2007,
                Type = "Sedan",
                IsNew = false
            };
            var item2 = new CarDetail
            {
                Make = "Honda",
                Model = "Civic",
                Year = 2015,
                Type = "Sedan",
                IsNew = true
            };    
            return Task.FromResult(new[] { item1, item2 });
        }
    }
}

