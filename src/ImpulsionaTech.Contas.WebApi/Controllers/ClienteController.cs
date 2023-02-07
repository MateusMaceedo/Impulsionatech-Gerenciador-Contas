using Equinox.Services.Api.Controllers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NetDevPack.Identity.Jwt;
using NetDevPack.Identity.Model;

namespace ImpulsionaTech.Contas.WebApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ClienteController : ApiController
  {
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly UserManager<IdentityUser> _userManager;
    private readonly AppJwtSettings _appJwtSettings;

    private readonly ILogger<ClienteController> _logger;

    public ClienteController(
      ILogger<ClienteController> logger,
      SignInManager<IdentityUser> signInManager,
      UserManager<IdentityUser> userManager,
      AppJwtSettings appJwtSettings)
    {
      _logger = logger;
      _signInManager = signInManager;
      _userManager = userManager;
      _appJwtSettings = appJwtSettings;
    }

    [HttpPost]
    [Route("register-cliente")]
    public async Task<ActionResult> RegisterClient(RegisterUser registerUser)
    {
      if (!ModelState.IsValid) return CustomResponse(ModelState);


      var user = new IdentityUser
      {
        UserName = registerUser.Email,
        Email = registerUser.Email,
        EmailConfirmed = true
      };

      var result = await _userManager.CreateAsync(user, registerUser.Password);

      if (result.Succeeded)
      {
        return CustomResponse(GetFullJwt(user.Email));
      }

      foreach (var error in result.Errors)
      {
        AddError(error.Description);
      }

      return CustomResponse();
    }

    private string GetFullJwt(string email)
    {
      return new JwtBuilder()
          .WithUserManager(_userManager)
          .WithJwtSettings(_appJwtSettings)
          .WithEmail(email)
          .WithJwtClaims()
          .WithUserClaims()
          .WithUserRoles()
          .BuildToken();
    }
  }
}
