using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Zoomby_Clone.Models;
using Zoomby_Clone.Data;
using Zoomby_Clone.Models.Transaction;

namespace Zoomby_Clone.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;

    public HomeController(ILogger<HomeController> logger,
        ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult GetAll()
    {
        return Ok(new { data = _context.zoomScheduler.ToList() });
    }

    public IActionResult GetPic()
    {
        return Ok(_context.Pic.ToList());
    }

    public IActionResult Save(ZoomScheduler data)
    {
        if(data.Id == 0)
        {
            _context.zoomScheduler.Add(data);
            _context.SaveChanges();
            return Ok(data);
        }
        else
        {
            throw new Exception();
        }
    }

    public IActionResult GetZoom()
    {
        return Ok(_context.zoomAccount.ToList());
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

