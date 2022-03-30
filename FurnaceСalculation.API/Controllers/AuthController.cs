using AutoMapper;
using FurnaceCalculation.BusinessLogic.Interface;
using FurnaceCalculation.DAL.MSSQL.Entity;
using FurnaceCalculation.Domain.Entity;
using FurnaceСalculation.API.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace FurnaceСalculation.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : Controller //
    {
        private readonly IAuthService<User> _authService; //интерфейс логин регистер
        private readonly IMapper _mapper;

        public AuthController(IAuthService<User> authService, IMapper mapper) //конструктор
        {
            _authService = authService;
            _mapper = mapper;
        }


        [HttpPost]
        [Route("Login")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public IActionResult Login([FromBody] Login request)
        {
            if (ModelState.IsValid == false)
                return BadRequest();

            var response = _authService.Login(request.Mail, request.Password);

            return Ok(response);
        }


        [HttpPost]
        [Route("Register")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public IActionResult Register([FromBody] User request)
        {
            if (ModelState.IsValid == false)
                return BadRequest();

            //var user = _mapper.Map<IUser>(request);

            var response = _authService.Register(request);

            return Ok(response);
        }
    }
}
