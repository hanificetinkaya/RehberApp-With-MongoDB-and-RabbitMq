using RehberApp.Core.Models;
using RehberApp.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RehberApp.Core.Models.Result;

namespace RehberApp.Business.Abstract
{
    public interface IRehberService
    {
        Task<GetManyResult<Rehber>> GetRehberAsync();
        Task<GetOneResult<Rehber>> InsertRehberAsync(Rehber rehber);
    }
}
