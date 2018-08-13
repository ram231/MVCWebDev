using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCwebdev.Models;
using System.Web;


namespace MVCwebdev.Controllers
{
    public class SongsController : Controller
    {
        public ActionResult Songs()
        {
            var songs = new Songs()
            {
                SongID = "song-001",
                SongName = "Waka aka",
                AlbumID = "waka waka",
                SongDesc = "Viewer"
            };
            return View(songs);
        }

    }
}