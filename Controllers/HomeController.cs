using System.IO.Compression;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP8_Series.Models;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace TP8_Series.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(int idS)
    {
        ViewBag.Series =  BD.TraerSeries();
        return View();
    }

    public List<Actores> mostrarActoresAjax(int idS)
    {
        return ViewBag.listaActores = BD.TraerActores(idS);
    }

    public List<Series> mostrarSeriesAjax(int idS)
    {
        return ViewBag.serieActual = BD.verInfoSerie(idS);
    }




















    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
