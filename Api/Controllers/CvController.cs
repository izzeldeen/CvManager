using Domain.Entities;
using Domain.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CvController : ControllerBase
    {
        private readonly ICvService _cvService;

        public CvController(ICvService cvService)
        {
            _cvService = cvService;
        }

        [HttpGet("{Id}")]
        public ActionResult<Cv> GetById(int Id) => _cvService.Get(Id);


        [HttpGet]
        public async  Task<ActionResult<IEnumerable<Cv>>> GetAll() => 
            Ok(await _cvService.GetAll());
      


        [HttpPost]
        public ActionResult<Cv> Post(Cv cv)
        {
            return _cvService.Add(cv) ? Ok(cv) : BadRequest();
        }

        [HttpPut]
        public ActionResult<Cv> Update(Cv cv)
        {
            return _cvService.Update(cv) ? Ok(cv) : BadRequest();
        }

        [HttpDelete("{Id}")]
        public ActionResult<Cv> Delete(int Id)
        {
            return _cvService.Remove(Id) ? Ok() : BadRequest();
        }

    }
}
