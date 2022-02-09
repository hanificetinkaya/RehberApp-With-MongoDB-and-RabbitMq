using RehberApp.Business.Abstract;
using RehberApp.Core.Models;
using RehberApp.DataAccess.Abstract;
using RehberApp.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RehberApp.Core.Models.Result;

namespace RehberApp.Business.Concrete
{
    public class RehberManager: IRehberService
    {
        private readonly IRehberDataAccess _rehberDataAccess;

        public RehberManager(IRehberDataAccess rehberDataAccess)
        {
            _rehberDataAccess = rehberDataAccess;
        }

        public async Task<GetManyResult<Rehber>> GetRehberAsync()
        {
            var rehberList = await _rehberDataAccess.GetAllAsync();
            return rehberList;
        }

        public async Task<GetOneResult<Rehber>> InsertRehberAsync(Rehber rehber)
        {
            var rehberList = await _rehberDataAccess.InsertOneAsync(rehber);
            return rehberList;
        }
    }
}
