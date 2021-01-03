using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using website.Services;
using website.Models;

namespace website.Pages
{
    public class PicturesModel : PageModel
    {
        private readonly PicturesService _pics;

        public PicturesModel(PicturesService pics)
        {
            _pics = pics;
        }

        public IList<Pictures> Pictures { get;set; }

        public void OnGet()
        {
            Pictures = _pics.Get();
        }
    }
}
