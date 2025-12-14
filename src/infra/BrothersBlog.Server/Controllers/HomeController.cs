using BrothersBlog.Models.Models;
using BrothersBlog.Server.Base;
using BrothersBlog.Server.Database;
using IO.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BrothersBlog.Server.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Produces("application/json")]
[Route("api/v{version:apiVersion}/home/")]
public class HomeController : TControllerBase
{
    public HomeController(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    [HttpGet("init-home-page-data")]
    public IActionResult InitHomePageData()
    {
        var overview = DefaultData.DefaultOverview();
        var intro = DefaultData.DefaultIntroduce();
        var projs = DefaultData.DefaultProjectOverview();
        var plan = DefaultData.DefaultPlan();
        var personOverview = DefaultData.DefaultPersonOverview();
        var awards = DefaultData.DefaultAwards();

        var homeData = new HomeModel
        {
            Introduce = intro,
            Overview = overview,
            ProjectOverview = projs,
            Plan = plan,
            PersonOverview = personOverview,
            Awards = awards,
        };

        _homeService.Add(homeData);

        return Ok();
    }

    [HttpGet("get-home-page-data")]
    public IActionResult GetHomePageData()
    {
        var datas = _homeService.GetAll();
        var lastestData = datas?.OrderByDescending(x => x.UpdateTime).FirstOrDefault();

        if(lastestData is null)
            return BadRequest(new BaseResponse
            {
                Status = HttpStatusCode.BadRequest,
                Error = "Home page data is null",
            });

        return Ok(new BaseResponse
        {
            Status = HttpStatusCode.OK,
            Value = lastestData
        });
    }
}

