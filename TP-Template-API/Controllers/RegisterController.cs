using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using TP_Application.Services;
using TP_Domain.DTOs;

namespace TP_Template_API.Controllers
{
    [ApiController]
    [Route("api/register")]
    public class RegisterPacienteController : ControllerBase
    {
        private readonly IAutenticationService _service;
        public RegisterPacienteController(IAutenticationService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Post(RequestRegisterDto userInfo)
        {
            try
            {
                return new JsonResult(_service.RegisterUser(userInfo)) { StatusCode = 201 };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }

    [ApiController]
    [Route("api/register/profesional")]
    //[Authorize]
    public class RegisterProfesionalController : ControllerBase
    {
        private readonly IAutenticationService _service;
        public RegisterProfesionalController(IAutenticationService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Post(RequestRegisterDto userInfo)
        {
            try
            {
                return new JsonResult(_service.RegisterProfesional(userInfo)) { StatusCode = 201 };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }

    [ApiController]
    [Route("api/register/administrator")]
    //[Authorize]
    public class RegisterAdministratorController : ControllerBase
    {
        private readonly IAutenticationService _service;
        public RegisterAdministratorController(IAutenticationService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Post(RequestRegisterDto userInfo)
        {
            try
            {
                return new JsonResult(_service.RegisterAdministrador(userInfo)) { StatusCode = 201 };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
