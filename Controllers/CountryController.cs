using AutoMapper;
using listingApi.Irepo;
using listingApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace listingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CountryController> _logger;
        private readonly IMapper _maper;

        public CountryController(IUnitOfWork unitOfWork, ILogger<CountryController> logger, IMapper maper)
        {
            _unitOfWork =unitOfWork;
            _logger = logger;
            _maper = maper;

        }

        [HttpGet]
        public async Task<IActionResult> getContries() {

            try
            {
                var cotries = await _unitOfWork.contries.GetAll();
              var result =  _maper.Map<IList<CountryDTO>>(cotries);
                return Ok(result);
                    }
            catch (Exception ex) {
                _logger.LogError(ex, "error");
                return StatusCode(500);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> getContries(int id)
        {

            try
            {
                var cotries = await _unitOfWork.contries.Get(q=>q.countryId ==id,new List<string> { "Hotels"});
                var result = _maper.Map<CountryDTO>(cotries);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "error");
                return StatusCode(500);
            }
        }

    }
}
