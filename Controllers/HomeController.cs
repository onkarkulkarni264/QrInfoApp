using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using QRCoder;
using QrInfoApp.Models;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace QrInfoApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Generate(UserProfile model)
    {
        if (ModelState.IsValid)
        {
            string payload = $"Name: {model.Name}\nRole: {model.Role}\nMobile: {model.MobileNo}\nExp: {model.ExperienceYears} years\nLast Company: {model.LastCompany}\nSkills: {model.Skills}";

            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
                PngByteQRCode qrCode = new PngByteQRCode(qrCodeData);
                byte[] qrCodeImage = qrCode.GetGraphic(20);
                string base64Image = Convert.ToBase64String(qrCodeImage);
                ViewBag.QrCodeImage = $"data:image/png;base64,{base64Image}";
            }
            
            return View("Result", model);
        }
        return View("Index", model);
    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
