using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;

namespace pp_backend.models;

public class VistiMe
{

    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Column(TypeName = "nvarchar(50)")]
    public string Ip { get; set; } = string.Empty;

    [Column(TypeName = "nvarchar(50)")]
    public string IpVersion { get; set; } = string.Empty;

    [Column(TypeName = "nvarchar(50)")]
    public string Device { get; set; } = string.Empty;

    [Column(TypeName = "nvarchar(50)")]
    public string OS { get; set; } = string.Empty;

    [Column(TypeName = "nvarchar(50)")]
    public String Browser { get; set; } = string.Empty;

    [Column(TypeName = "nvarchar(50)")]
    public string Country { get; set; } = string.Empty;

    public DateTime recievedDate { get; set; } = DateTime.Now;
}