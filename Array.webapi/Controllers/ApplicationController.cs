using Array.Application.Contract;
using Microsoft.AspNetCore.Mvc;

namespace Array.webapi.Controllers;

[ApiController]
[Route("Array.api/[controller]")]
public class ApplicationController : ControllerBase

{
	protected readonly IApplication _app;
	public ApplicationController(IApplication app)
	{
		_app = app;
	}
	[HttpGet]
	[Route("GetApplication")]
	public IActionResult GetApplication(string Name)
	{
		return new JsonResult(_app.solve() + " " + Name + "!!!");
	}
}
