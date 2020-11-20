using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using TP_Application.Services;
using TP_Domain.DTOs;

namespace TP_Template_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController:ControllerBase
    {
        private readonly IAutenticationService _service;
        public LoginController(IAutenticationService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Post(RequestLoginDto userInfo)
        {
            try
            {
                return new JsonResult(_service.Login(userInfo)) { StatusCode = 201 };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
