using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MimeKit;
using MimeKit.Text;
using pp_backend.models;

namespace pp_backend.Controllers;


[ApiController]
[Route("api/[controller]")]
public class VistiMeController : ControllerBase
{
    private readonly mailDBContext _context;

    public VistiMeController(mailDBContext context)
    {
        _context = context;

    }

    [HttpGet]
    public async Task<ActionResult<List<VistiMe>>> getVisitMe()
    {
        return Ok(await _context.VisitMe.ToListAsync());
    }


    [HttpPost]
    public async Task<ActionResult<VistiMe>> postVisitMe(VistiMe visitMe)
    {
        _context.VisitMe.Add(visitMe);
        await _context.SaveChangesAsync();
        return Ok(true);
    }
}
