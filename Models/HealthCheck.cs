using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace TodoApi.Models;

public class HealthCheck
{
    [Required]
    [AllowNull]
    private string Pong { get; set; } = null;

    public HealthCheck()
    {
        Pong = "ping";
    }
}

