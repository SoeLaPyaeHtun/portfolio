using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pp_backend.models;

namespace pp_backend.Controllers;


[ApiController]
[Route("api/[controller]")]
public class HireMeController : ControllerBase
{
    private readonly mailDBContext _context;

    public HireMeController(mailDBContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<HireMe>>> getHireMeMail()
    {
        return Ok(await _context.HireMe.ToListAsync());
    }


    [HttpPost]
    public async Task<ActionResult<HireMe>> postHireMeMail(HireMe hireMeMail){  
        _context.HireMe.Add(hireMeMail);
            await _context.SaveChangesAsync();
    
        return Ok(true);
    }

    [HttpGet]
    [Route("getresume")]
    public IActionResult DownloadResume(){
        var path = Path.Combine(Directory.GetCurrentDirectory(), "ResumeFile" , "Soe_La Pyae Htun_Resume.pdf");
        var stream = new FileStream(path, FileMode.Open);
        return File(stream, "application/octet-stream", "Soe_La Pyae Htun_Resume.pdf");
    }

}