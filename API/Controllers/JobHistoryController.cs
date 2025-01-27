﻿using API.Context;
using API.Models;
using API.Repositories.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class JobHistoryController : BaseController<JobHistoryRepository, JobHistory, int>
    {
        public JobHistoryController(JobHistoryRepository jobHistoryRepository) : base(jobHistoryRepository)
        {
            
        }
    }
}
