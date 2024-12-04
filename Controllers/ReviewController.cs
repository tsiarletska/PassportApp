
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PassportsApp.Data; 
using PassportsApp.Models; 
using System.Linq;

namespace PassportsApp.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReviewsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(); 
        }

        public IActionResult ViewAllPassports() 
        {
            var passports = _context.Passport.ToList();
            return View(passports);
        }


        public IActionResult ViewAllCountries()
        {
            var countries = _context.Country.ToList();
            return View(countries);
        }

        public IActionResult ViewAllTypes()
        {
            var types = _context.PassportType.ToList();
            return View(types);
        }

        public IActionResult ViewAllSex()
        {
            var sexes = _context.Sex.ToList();
            return View(sexes);
        }

        public IActionResult ViewAllHolders()
        {
            var holders = _context.PassportsHolder.ToList();
            return View(holders);
        }
        public IActionResult ViewAllAuthorities()
        {
            var authorities = _context.Authority.ToList();
            return View(authorities);
        }


   
        public IActionResult Search(string term)
        {
            
            term = term.ToLower();

           
            var passportResults = _context.Passport
                .Where(p => p.PassportId.ToString().Contains(term)
                            || p.Type.ToLower().Contains(term)
                            || p.AuthorityId.ToString().Contains(term)
                            || p.IssueDate.ToString().Contains(term)
                            || p.ExpirationDate.ToString().Contains(term))
                .ToList();

            var countryResults = _context.Country
                .Where(c => c.CountryCode.ToLower().Contains(term)
                            || c.CountryName.ToLower().Contains(term))
                .ToList();

            var typeResults = _context.PassportType
                .Where(t => t.PassportTypeAbr.ToLower().Contains(term)
                            || t.PassportTypeDesc.ToLower().Contains(term))
                .ToList();

            var sexResults = _context.Sex
                .Where(s => s.SexAbr.ToLower().Contains(term)
                            || s.FullSex.ToLower().Contains(term))
                .ToList();

            var holderResults = _context.PassportsHolder
                .Where(h => h.HolderId.ToString().Contains(term)
                            || h.HolderName.ToLower().Contains(term)
                            || h.HolderSurname.ToLower().Contains(term)
                            || h.PatronymicMatronymic.ToLower().Contains(term)
                            || h.Birthday.ToString().Contains(term)
                            || h.SexAbr.ToLower().Contains(term)
                            || h.Citizenship.ToLower().Contains(term))
                .ToList();

            var authorityResults = _context.Authority
                .Where(a => a.AutorityId.ToString().Contains(term)
                            || a.CountryCode.ToLower().Contains(term)
                            || a.City.ToLower().Contains(term)
                            || a.Street.ToLower().Contains(term)
                            || a.HouseNum.ToLower().Contains(term)
                            || a.Phone.ToLower().Contains(term)
                            || a.EstablishmentDate.ToString().Contains(term))
                .ToList();

        
            ViewData["Passports"] = passportResults;
            ViewData["Countries"] = countryResults;
            ViewData["PassportTypes"] = typeResults;
            ViewData["Sexes"] = sexResults;
            ViewData["Holders"] = holderResults;
            ViewData["Authorities"] = authorityResults;

            return View("SearchResults"); 
        }




    }
}


