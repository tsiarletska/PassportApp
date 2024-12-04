using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc;
using PassportsApp.Data;
using PassportsApp.Models;
using System.Linq;
using ZstdSharp.Unsafe;

namespace PassportsApp.Controllers
{
    public class ManagementController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ManagementController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddRecord()
        {
            return View();
        }


        [HttpGet]
        public IActionResult DeleteRecord()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteRecord(string table, string id)
        {
            try
            {
                switch (table)
                {
                    case "Passport":
                        var passport = _context.Passport.FirstOrDefault(p => p.PassportId.ToString() == id);
                        if (passport != null)
                            _context.Passport.Remove(passport);
                        else
                            TempData["ErrorMessage"] = "Passport record not found.";
                        break;

                    case "PassportHolder":
                        var holder = _context.PassportsHolder.FirstOrDefault(h => h.HolderId.ToString() == id);
                        if (holder != null)
                            _context.PassportsHolder.Remove(holder);
                        else
                            TempData["ErrorMessage"] = "PassportHolder record not found.";
                        break;

                    case "Country":
                        var country = _context.Country.FirstOrDefault(c => c.CountryCode == id);
                        if (country != null)
                            _context.Country.Remove(country);
                        else
                            TempData["ErrorMessage"] = "Country record not found.";
                        break;

                    case "PassportType":
                        var type = _context.PassportType.FirstOrDefault(pt => pt.PassportTypeAbr == id);
                        if (type != null)
                            _context.PassportType.Remove(type);
                        else
                            TempData["ErrorMessage"] = "PassportType record not found.";
                        break;

                    case "Sex":
                        var sex = _context.Sex.FirstOrDefault(s => s.SexAbr == id);
                        if (sex != null)
                            _context.Sex.Remove(sex);
                        else
                            TempData["ErrorMessage"] = "Sex record not found.";
                        break;

                    case "Authority":
                        var authority = _context.Authority.FirstOrDefault(a => a.AutorityId.ToString() == id);
                        if (authority != null)
                            _context.Authority.Remove(authority);
                        else
                            TempData["ErrorMessage"] = "Authority record not found.";
                        break;

                    default:
                        return NotFound("Unknown table.");
                }

                _context.SaveChanges();
                TempData["SuccessMessage"] = "Record deleted successfully.";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "An error occurred while deleting the record: " + ex.Message;
                return RedirectToAction("DeleteRecord");
            }
        }




        [HttpPost]
        public IActionResult Save(IFormCollection form)
        {
            var type = form["type"];
            switch (type)
            {
                case "Passport":
                    var passport = new Passport
                    {
                        PassportId = int.Parse(form["PassportId"]),
                        Type = form["PassportType"],
                        IssueDate = DateTime.Parse(form["IssueDate"]),
                        ExpirationDate = DateTime.Parse(form["ExpirationDate"]),
                        AuthorityId = int.Parse(form["AuthorityId"])
                    };
                    _context.Passport.Add(passport);
                    break;

                case "PassportHolder":
                    var holder = new PassportHolder
                    {
                        HolderId = int.Parse(form["HolderId"]),
                        PassportId = int.Parse(form["PassportId"]),
                        HolderName = form["HolderName"],
                        HolderSurname = form["HolderSurname"],
                        PatronymicMatronymic = form["PatronymicMatronymic"],
                        Birthday = DateTime.Parse(form["Birthday"]),
                        SexAbr = form["Sex"],
                        BirthPlace = form["BirthPlace"],
                        Citizenship = form["Citizenship"],
                        Signature = form["Signature"],
                        HolderPhoto = form["HolderPhoto"]
                    };
                    _context.PassportsHolder.Add(holder);
                    break;

                case "Authority":
                    var authority = new Authority
                    {
                        AutorityId = int.Parse(form["AuthorityId"]),
                        CountryCode = form["CountryCode"],
                        City = form["City"],
                        Street = form["Street"],
                        HouseNum = form["HouseNum"],
                        Phone = form["Phone"],
                        Email = form["Email"],
                        EstablishmentDate = DateTime.Parse(form["EstablishmentDate"])
                    };
                    _context.Authority.Add(authority);
                    break;


                case "Country":
                    var country = new Country
                    {
                        CountryCode = form["CountryCode"], 
                        CountryName = form["CountryName"]
                    };
                    _context.Country.Add(country);
                    break;

                case "Sex":
                    var sex = new Sex
                    {
                        SexAbr = form["SexAbr"],
                        FullSex = form["FullSex"]
                    };
                    _context.Sex.Add(sex);
                    break;


                
                default:
                    return Content("Unknown form type.");
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }




        [HttpGet]
        public IActionResult GetRecord(string table, string id)
        {
            object record = table switch
            {
                "Passport" => _context.Passport.FirstOrDefault(p => p.PassportId.ToString() == id),
                "PassportHolder" => _context.PassportsHolder.FirstOrDefault(ph => ph.HolderId.ToString() == id),
                "Country" => _context.Country.FirstOrDefault(c => c.CountryCode == id),
                "PassportType" => _context.PassportType.FirstOrDefault(pt => pt.PassportTypeAbr == id),
                "Sex" => _context.Sex.FirstOrDefault(s => s.SexAbr == id),
                "Authority" => _context.Authority.FirstOrDefault(a => a.AutorityId.ToString() == id),
                _ => null
            };

            if (record == null)
            {
                return Json(null);
            }

            return Json(record);
        }


        [HttpGet]
        public IActionResult EditRecord()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveEditedRecord(string table, IFormCollection form)
        {
            try
            {
                switch (table)
                {
                    case "Passport":
                        var passport = _context.Passport.FirstOrDefault(p => p.PassportId.ToString() == form["PassportId"]);
                        if (passport != null)
                        {
                            passport.Type = form["Type"];
                            passport.IssueDate = DateTime.Parse(form["IssueDate"]);
                            passport.ExpirationDate = DateTime.Parse(form["ExpirationDate"]);
                            passport.AuthorityId = int.Parse(form["AuthorityId"]);
                        }
                        break;

                    case "PassportHolder":
                        var holder = _context.PassportsHolder.FirstOrDefault(h => h.HolderId.ToString() == form["HolderId"]);
                        if (holder != null)
                        {
                            holder.HolderName = form["HolderName"];
                            holder.HolderSurname = form["HolderSurname"];
                            holder.PatronymicMatronymic = form["PatronymicMatronymic"];
                            holder.Birthday = DateTime.Parse(form["Birthday"]);
                            holder.SexAbr = form["SexAbr"];
                            holder.BirthPlace = form["BirthPlace"];
                            holder.Citizenship = form["Citizenship"];
                            holder.Signature = form["Signature"];
                            holder.HolderPhoto = form["HolderPhoto"];
                        }
                        break;

                    case "Country":
                        var country = _context.Country.FirstOrDefault(c => c.CountryCode == form["CountryCode"]);
                        if (country != null)
                        {
                            country.CountryName = form["CountryName"];
                        }
                        break;

                    case "PassportType":
                        var type = _context.PassportType.FirstOrDefault(pt => pt.PassportTypeAbr == form["PassportTypeAbr"]);
                        if (type != null)
                        {
                            type.PassportTypeDesc = form["PassportTypeDesc"];
                        }
                        break;

                    case "Sex":
                        var sex = _context.Sex.FirstOrDefault(s => s.SexAbr == form["SexAbr"]);
                        if (sex != null)
                        {
                            sex.FullSex = form["FullSex"];
                        }
                        break;

                    case "Authority":
                        var authority = _context.Authority.FirstOrDefault(a => a.AutorityId.ToString() == form["AutorityId"]);
                        if (authority != null)
                        {
                            authority.CountryCode = form["CountryCode"];
                            authority.City = form["City"];
                            authority.Street = form["Street"];
                            authority.HouseNum = form["HouseNum"];
                            authority.Phone = form["Phone"];
                            authority.Email = form["Email"];
                            authority.EstablishmentDate = DateTime.Parse(form["EstablishmentDate"]);
                        }
                        break;

                    default:
                        return NotFound("Unknown table.");
                }

                _context.SaveChanges();
                TempData["SuccessMessage"] = "Record updated successfully.";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"An error occurred while saving the record: {ex.Message}";
                return RedirectToAction("EditRecord");
            }
        }






        [HttpPost]
        public IActionResult UpdateRecord()
        {

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult RemoveRecord()
        {

            return RedirectToAction("Index");
        }
    }
}
