using System;
using System.IO;
using System.Diagnostics;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;
using RenameFile.Models;

namespace RenameFile.Controllers
{
    public class HomeController : Controller
    {
        private int x = 0;
        private string mediaFile;
        private IHostingEnvironment hostingEnv;

        public IActionResult Index()
        {
            ViewBag.items = new[] { "Audio" };
            return View();
        }
        
        public HomeController(IHostingEnvironment env)
        {
            hostingEnv = env;
        }

        [HttpPost]
        public void Rename(IList<IFormFile> UploadFiles)
        {
            try
            {
                foreach (IFormFile file in UploadFiles)
                {
                    if (UploadFiles != null)
                    {
                        string filename = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                        mediaFile = filename;
                        string path = hostingEnv.WebRootPath + "\\Uploads" + $@"\{filename}";

                        // Create a new directory, if it does not exists
                        if (!Directory.Exists(hostingEnv.WebRootPath + "\\Uploads"))
                        {
                            Directory.CreateDirectory(hostingEnv.WebRootPath + "\\Uploads");
                        }

                        // Rename a uploaded media file name
                        while (System.IO.File.Exists(path))
                        {
                            mediaFile = "rteAudio" + x + "-" + filename;
                            path = hostingEnv.WebRootPath + "\\Uploads" + $@"\rteAudio{x}-{filename}";
                            x++;
                        }

                        if (!System.IO.File.Exists(path))
                        {
                            using (FileStream fs = System.IO.File.Create(path))
                            {
                                file.CopyTo(fs);
                                fs.Flush();
                                fs.Close();
                            }

                            // Modified file name shared through response header by adding custom header
                            Response.StatusCode = 200;
                            Response.Headers.Add("name", mediaFile);
                            Response.ContentType = "application/json; charset=utf-8";
                        }
                    }
                }
            }
            catch (Exception)
            {
                Response.StatusCode = 204;
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}