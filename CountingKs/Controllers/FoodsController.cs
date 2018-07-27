﻿using CountingKs.Data;
using CountingKs.Data.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace CountingKs.Controllers
{
    public class FoodsController : ApiController
    {
        ICountingKsRepository _repo { get; set; }

        public FoodsController(ICountingKsRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Food> Get()
        {

            var results = _repo.GetAllFoods()
                            .OrderBy(f => f.Description)
                            .Take(25)
                            .ToList();

            return results;
        }
    }
}
