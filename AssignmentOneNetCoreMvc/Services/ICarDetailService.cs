using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AssignmentOneNetCoreMvc.Models;

namespace AssignmentOneNetCoreMvc.Services
{
    public interface ICarDetailService
    {
        Task<CarDetail[]> GetCarReportAsync();
    }
}