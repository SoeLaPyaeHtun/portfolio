using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;

namespace pp_backend.models;

public class HireMe{

    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Column(TypeName = "nvarchar(50)")] 
    public string Mail{ get; set; } = string.Empty;

    [Column(TypeName = "nvarchar(100)")]
    public string Subject { get; set; } = string.Empty;

    [Column(TypeName = "nvarchar(250)")]
    public string Message { get; set; } = string.Empty;

    [Column(TypeName = "nvarchar(50)")] 
    public string Ip {get; set; } = string.Empty;

    public DateTime recievedDate { get; set; } = DateTime.Now;
}