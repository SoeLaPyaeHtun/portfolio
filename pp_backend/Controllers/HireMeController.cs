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
      

        try{
              _context.HireMe.Add(hireMeMail);
             await _context.SaveChangesAsync();

            MailMessage message = new MailMessage();
            message.From = new MailAddress("singlapyaehtun@gmail.com");
           
            message.Subject = "Thanks for reaching out.";
            message.To.Add(new MailAddress(hireMeMail.Mail.ToString()));
            message.Body = "<html><body><h3>Hello ,<br /><br />Thank you for contacting me. <br />"+
                        "This is an automated response to confirm that you got your contact. <br />" +
                        "I will get back to you as soon as possible. <br /><br />Thanks.</h3>" +
                        "<h5>Best Regards,<br />Soe La Pyae Htun<br />+65 86470728<br /></h5></body ></html > ";
            message.IsBodyHtml = true;

            var smtpClient = new System.Net.Mail.SmtpClient("smtp.gmail.com")
            {
                Port = 587, 
                Credentials = new NetworkCredential("singlapyaehtun@gmail.com", "goievbsimpkllixj"),
                EnableSsl = true,
            };

            smtpClient.Send(message);

    
        return Ok(true);

        }catch(Exception e){
            return Ok(e.Message);
        }
           
    }

    [HttpGet]
    [Route("getresume")]   
    public IActionResult DownloadResume(String filename){
        var path = Path.Combine(Directory.GetCurrentDirectory(), "ResumeFile" , filename);
        var stream = new FileStream(path, FileMode.Open);
        return File(stream, "application/octet-stream", filename);
    }

}


// Soe_La Pyae Htun_Resume.pdf