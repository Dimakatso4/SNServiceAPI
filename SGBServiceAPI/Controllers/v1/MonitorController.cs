using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SNServiceAPI.Models;
using SNServiceAPI.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SNServiceAPI.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonitorController : ControllerBase
    {
        private readonly IDapper _dapper;
        public MonitorController(IDapper dapper)
        {
            _dapper = dapper;
        }
        [HttpGet(nameof(DistrictCodeByPosition))]
        public Task<List<MonitorModel>> DistrictCodeByPosition(string DistrictCode,string Position)
        {
            var result = Task.FromResult(_dapper.GetAll<MonitorModel>($" select * from [tblUsers] where DistrictCode LIKE'{DistrictCode}' AND Position LIKE'{Position}'", null,
                    commandType: CommandType.Text));
            return result;
        }
    }
}
