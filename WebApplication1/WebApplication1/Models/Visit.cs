using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1;

public class Visit
{
    public DateTime VisitDate { get; set; }
    public Animal Animal{ get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
}