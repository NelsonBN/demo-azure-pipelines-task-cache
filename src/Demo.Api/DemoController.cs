using Demo.Lib;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Api;

[ApiController]
[Route("[controller]")]
public class DemoController : ControllerBase
{
    [HttpGet("country")]
    public IActionResult GetCountry([FromQuery] string iso2)
    {
        return Ok(Utils.GetCountry(iso2));
    }

    [HttpGet("compress-text")]
    public IActionResult CompressText([FromQuery] string name)
    {
        return Ok(PowerUtils.Text.PowerUtilsExtensions.CompressText(name, 5));
    }
}
