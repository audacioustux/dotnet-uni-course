using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using static System.Net.WebRequestMethods;

namespace task1.Controllers;

[EnableCors("MyPolicy")]
[ApiController]
[Route("[controller]")]
public class ResumeReferencesController : ControllerBase
{
    private readonly ILogger<ResumeReferencesController> _logger;

    public ResumeReferencesController(ILogger<ResumeReferencesController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetResumeReference")]
    public IEnumerable<ResumeReference> Get()
    {
        return Enumerable.Range(1, 1).Select(index => new ResumeReference
        {
            Name = "Tanvir Ahmed",
            Link = "https://www.linkedin.com/in/taanveerahmeed/",
        })
        .ToArray();
    }
}

