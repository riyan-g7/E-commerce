using MainProject.Models;
using MainProject.Models.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MainProject.Controllers
{
    public class AdminController : Controller
    {
        private readonly AppDbContext _dbcontext;
        private readonly IWebHostEnvironment webHostEnvironment;
        private const int PageSize = 1;
        public AdminController(AppDbContext dbcontext,IWebHostEnvironment hostEnvironment)
        {
            _dbcontext = dbcontext;
            webHostEnvironment = hostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddUser()
        {
            ViewBag.co = new SelectList(_dbcontext.company.ToList(), "Id", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult AddUser(Admin ad)
        {
            ViewBag.co = new SelectList(_dbcontext.company.ToList(), "Id", "Name");
            if (ModelState.IsValid)
            {
                _dbcontext.admin.Add(ad);
                _dbcontext.SaveChanges();
                ViewBag.msg = "Added....";
            }
            return View("AddUser");
        }
        [HttpGet]
        public ActionResult Admin_home()
        {
            IEnumerable<Product> p = _dbcontext.product.ToList();
            return View(p);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category cg)
        {
            if (ModelState.IsValid)
            {
                _dbcontext.category.Add(cg);
                _dbcontext.SaveChanges();
                ViewBag.msg = "Added.....";
            }
            return View();
        }
        [HttpGet]
        public ActionResult Category_list(int pageIndex = 1)
        {
            var count = _dbcontext.category.Count();
            var ct = _dbcontext.category
                .OrderBy(p => p.Id)
                .Skip((pageIndex - 1) * PageSize)
                .Take(PageSize)
                .ToList();

            var paginatedList = new PaginatedList<Category>(ct, count, pageIndex, PageSize);
            return View(paginatedList);
        }
        [HttpGet]
        public ActionResult AddCover()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCover(Cover_type ct)
        {
            if (ModelState.IsValid)
            {
                _dbcontext.cover.Add(ct);
                _dbcontext.SaveChanges();
                ViewBag.msg = "Added.....";
            }
            return View();
        }
        [HttpGet]
        public ActionResult Cover_list(int pageIndex = 1)
        {
            var count = _dbcontext.cover.Count();
            var ct = _dbcontext.cover
                .OrderBy(p => p.Id)
                .Skip((pageIndex - 1) * PageSize)
                .Take(PageSize)
                .ToList();

            var paginatedList = new PaginatedList<Cover_type>(ct, count, pageIndex, PageSize);
            return View(paginatedList);
        }
        [HttpGet]
        public ActionResult EditCategory(int id)
        {
            Category ct = _dbcontext.category.Find(id);
            return View(ct);
        }
        [HttpPost]
        public ActionResult EditCategory(int id, Category ct)
        {
            Category cdb = _dbcontext.category.Find(id);
            if (cdb != null)
            {
                cdb.Name = ct.Name;
                _dbcontext.SaveChanges();
                ViewBag.msg = "Edited....";
            }
            return View();
        }
        [HttpGet]
        public ActionResult EditCover(int id)
        {
            Cover_type ct = _dbcontext.cover.Find(id);
            return View(ct);
        }
        [HttpPost]
        public ActionResult EditCover(int id, Cover_type c)
        {
            Cover_type cdb = _dbcontext.cover.Find(id);
            if (cdb != null)
            {
                cdb.Ctname = c.Ctname;
                _dbcontext.SaveChanges();
                ViewBag.msg = "Edited....";
            }
            return View();
        }
        public ActionResult Delete(int id)
        {
            Category ct = _dbcontext.category.Find(id);
            if (ct != null)
            {
                _dbcontext.category.Remove(ct);
                _dbcontext.SaveChanges();
            }
            return RedirectToAction("Category_list");
        }
        public ActionResult DeleteCover(int id)
        {
            Cover_type ct = _dbcontext.cover.Find(id);
            if (ct != null)
            {
                _dbcontext.cover.Remove(ct);
                _dbcontext.SaveChanges();
            }
            return RedirectToAction("Cover_list");
        }
        [HttpGet]
        public ActionResult AddCompany()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCompany(Company co)
        {
            if (ModelState.IsValid)
            {
                _dbcontext.company.Add(co);
                _dbcontext.SaveChanges();
                ViewBag.msg = "Added.....";
            }
            return View();
        }
        public ActionResult Company_list(int pageIndex = 1)
        {
            var count = _dbcontext.company.Count();
            var ct = _dbcontext.company
                .OrderBy(p => p.Id)
                .Skip((pageIndex - 1) * PageSize)
                .Take(PageSize)
                .ToList();

            var paginatedlist = new PaginatedList<Company>(ct, count, pageIndex, PageSize);
            return View(paginatedlist);
        }
        [HttpGet]
        public ActionResult EditCompany(int id)
        {
            Company ct = _dbcontext.company.Find(id);
            return View(ct);
        }
        [HttpPost]
        public ActionResult EditCompany(int id, Company co)
        {
            Company cdb = _dbcontext.company.Find(id);
            if (cdb != null)
            {
                cdb.Name = co.Name;
                cdb.Street = co.Street;
                cdb.City = co.City;
                cdb.State = co.State;
                cdb.Mobile = co.Mobile;
                cdb.IsAuthorized = co.IsAuthorized;
                _dbcontext.SaveChanges();
            }
            return RedirectToAction("Company_list");
        }
        public ActionResult DeleteCompany(int id)
        {
            Company c = _dbcontext.company.Find(id);
            if (c != null)
            {
                _dbcontext.company.Remove(c);
                _dbcontext.SaveChanges();
            }
            return RedirectToAction("Company_list");
        }
        [HttpGet]
        public ActionResult AddProduct()
        {
            ProductViewModel pr = new ProductViewModel()
            {
                product = new Product(),
                categories = new SelectList(_dbcontext.category.ToList(), "Id", "Name"),
                covers = new SelectList(_dbcontext.cover.ToList(), "Id", "Ctname"),
            };
            return View(pr);
        }
        [HttpPost]
        public ActionResult AddProduct(ProductViewModel pt)
        {
            string uniqueFileName = null;
            if (pt.product.Img != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "media");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + pt.product.Img.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    pt.product.Img.CopyTo(stream);
                    pt.product.Image = "/" + uniqueFileName;
                }
            }

            _dbcontext.product.Add(pt.product);
            _dbcontext.SaveChanges();                
            return RedirectToAction("Product_list");
        }
        [HttpGet]
        public ActionResult Product_list(int pageIndex = 1)
        {
            var count = _dbcontext.product.Count();
            var ct = _dbcontext.product
                .OrderBy(p => p.Id)
                .Skip((pageIndex - 1) * PageSize)
                .Take(PageSize).Include(x=>x.Categories)
                .ToList();
            var paginatedList = new PaginatedList<Product>(ct, count, pageIndex, PageSize);
            return View(paginatedList);
        }
        [HttpPost]
        public ActionResult Product_list(string search, int pageIndex = 1)
        {
            var count = _dbcontext.product.Where(n => n.Title.Contains(search)).Count();
            var ct = _dbcontext.product
                .OrderBy(p => p.Id)
                .Skip((pageIndex - 1) * PageSize)
                .Take(PageSize).Include(x => x.Categories)
                .Where(n => n.Title.Contains(search))
                .ToList();
            var paginatedList = new PaginatedList<Product>(ct, count, pageIndex, PageSize);
            return View(paginatedList);
        }

        [HttpGet]
        public ActionResult EditProduct(int id)
        {
            ProductViewModel pr = new ProductViewModel()
            {
                product = _dbcontext.product.Find(id),
                categories = new SelectList(_dbcontext.category.ToList(), "Id", "Name"),
                covers = new SelectList(_dbcontext.cover.ToList(), "Id", "Ctname"),
            };
/*            Product pt = _dbcontext.product.Find(id);*/
            return View(pr);
        }
        [HttpPost]
        public ActionResult EditProduct(int id,ProductViewModel pt)
        {
            string uniqueFileName = null;
            if (pt.product.Img != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "media");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + pt.product.Img.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    pt.product.Img.CopyTo(stream);
                    pt.product.Image = "/" + uniqueFileName;
                }
            }

            ProductViewModel pr = new ProductViewModel()
            {
                product = _dbcontext.product.Find(id),
                categories = new SelectList(_dbcontext.category.ToList(), "Id", "Name"),
                covers = new SelectList(_dbcontext.cover.ToList(), "Id", "Ctname"),
            };
            pr.product.Title = pt.product.Title;
            pr.product.ISBN = pt.product.ISBN;
            pr.product.Author = pt.product.Author;
            pr.product.Description = pt.product.Description;
            pr.product.ListPrice = pt.product.ListPrice;
            pr.product.Price = pt.product.Price;
            pr.product.Price50 = pt.product.Price50;
            pr.product.Price100 = pt.product.Price100;
            pr.product.CategoryId = pt.product.CategoryId;
            pr.product.CoverId = pt.product.CoverId;
            if (pt.product.Image != null)
            {
                pr.product.Image = pt.product.Image;
            }
            else
            {
                pt.product.Image = pt.product.Image;
            }
            _dbcontext.SaveChanges();
            return RedirectToAction("Product_list");
        }
        
        public ActionResult DeleteProduct(int id)
        {
            Product pd = _dbcontext.product.Find(id);
            if(pd!=null)
            {
                _dbcontext.product.Remove(pd);
                _dbcontext.SaveChanges();
            }
            return RedirectToAction("Product_list");
        }

        [HttpGet]
        public ActionResult ProductDetails(int id)
        {
            ProductViewModel p = new ProductViewModel()
            {
                product = _dbcontext.product.Find(id),
                categories = new SelectList(_dbcontext.category.ToList(), "Id", "Name"),
                covers = new SelectList(_dbcontext.cover.ToList(), "Id", "Ctname"),
            };
            return View(p);
        }

        [HttpGet]
        public ActionResult OrderList(int pageIndex = 1)
        {
            int PageSize = 2;
            var count = _dbcontext.order.Count();
            var ct = _dbcontext.order
                .OrderBy(p => p.Id)
                .Skip((pageIndex - 1) * PageSize)
                .Take(PageSize).Include(x => x.Users)
                .ToList();
            var paginatedList = new PaginatedList<Order>(ct, count, pageIndex, PageSize);
            return View(paginatedList);
        }

        [HttpGet]
        public ActionResult OrderDetails(int id)
        {
            OrderViewModel o = new OrderViewModel()
            {
                orders = _dbcontext.order.Include(x => x.Users).FirstOrDefault(x=>x.Id==id),
                order_items = _dbcontext.order_items.Include(x=>x.Products).Where(x => x.OrderId == id),
            };
            int n = 0, total = 0, amt = 0;
            foreach (var item in o.order_items)
            {
                amt = item.Total;
                total = amt + n;
                n = total;
            }
            ViewBag.total = n;
            return View(o);
        }

        [HttpPost]
        public ActionResult OrderDetails(OrderViewModel o)
        {
            Order ot = _dbcontext.order.Find(o.orders.Id);
            ot.Carrier = o.orders.Carrier;
            ot.Tracking = o.orders.Tracking;
            ot.Order_status = "Shipped";
            _dbcontext.SaveChanges();
            return RedirectToAction("OrderList");
        }
        
        public ActionResult StartProcess(int id)
        {
            OrderViewModel o = new OrderViewModel()
            {
                orders = _dbcontext.order.Include(x => x.Users).FirstOrDefault(x => x.Id == id),
                order_items = _dbcontext.order_items.Include(x => x.Products).Where(x => x.OrderId == id),
            };
            o.orders.Order_status = "Processing";
            _dbcontext.SaveChanges();
            return RedirectToAction("OrderList");
        }

        public ActionResult CancelOrder(int id)
        {
            OrderViewModel o = new OrderViewModel()
            {
                orders = _dbcontext.order.Include(x => x.Users).FirstOrDefault(x => x.Id == id),
                order_items = _dbcontext.order_items.Include(x => x.Products).Where(x => x.OrderId == id),
            };
            o.orders.Order_status = "Cancelled";
            _dbcontext.SaveChanges();
            return RedirectToAction("OrderList");
        }

        [HttpGet]
        public ActionResult Allusers(int pageIndex = 1)
        {
            int PageSize = 1;
            var count = _dbcontext.order.Count();
            var ct = _dbcontext.order
                .OrderBy(p => p.Id)
                .Skip((pageIndex - 1) * PageSize)
                .Take(PageSize).Include(x => x.Users)
                .ToList();
            var paginatedList = new PaginatedList<Order>(ct, count, pageIndex, PageSize);
            return PartialView("_Order", paginatedList);
        }


        [HttpGet]
        public ActionResult ProcessUsers(int pageIndex = 1)
        {
            int PageSize = 1;
            var count = _dbcontext.order.Where(x => x.Order_status == "Processing").Count();
            var ct = _dbcontext.order
                .Where(x => x.Order_status == "Processing")
                .OrderBy(p => p.Id)
                .Skip((pageIndex - 1) * PageSize)
                .Take(PageSize).Include(x => x.Users)
                .ToList();
            var paginatedList = new PaginatedList<Order>(ct, count, pageIndex, PageSize);
            return PartialView("_Order", paginatedList);
        }

        [HttpGet]
        public ActionResult PendingUsers(int pageIndex = 1)
        {
            int PageSize = 1;
            var count = _dbcontext.order.Where(x => x.Payment_Status == "Pending").Count();
            var ct = _dbcontext.order
                .Where(x => x.Payment_Status == "Pending")
                .OrderBy(p => p.Id)
                .Skip((pageIndex - 1) * PageSize)
                .Take(PageSize).Include(x => x.Users)
                .ToList();
            var paginatedList = new PaginatedList<Order>(ct, count, pageIndex, PageSize);
            return PartialView("_Order", paginatedList);
        }

        [HttpGet]
        public ActionResult PaidUsers(int pageIndex = 1)
        {
            int PageSize = 1;
            var count = _dbcontext.order.Where(x => x.Order_status == "Completed").Count();
            var ct = _dbcontext.order
                .Where(x => x.Order_status == "Completed")
                .OrderBy(p => p.Id)
                .Skip((pageIndex - 1) * PageSize)
                .Take(PageSize).Include(x => x.Users)
                .ToList();
            var paginatedList = new PaginatedList<Order>(ct, count, pageIndex, PageSize);
            return PartialView("_Order", paginatedList);
        }

        [HttpGet]
        public ActionResult RejectedUsers(int pageIndex = 1)
        {
            int PageSize = 1;
            var count = _dbcontext.order.Where(x => x.Order_status == "Cancelled").Count();
            var ct = _dbcontext.order
                .Where(x => x.Order_status == "Cancelled")
                .OrderBy(p => p.Id)
                .Skip((pageIndex - 1) * PageSize)
                .Take(PageSize).Include(x => x.Users)
                .ToList();
            var paginatedList = new PaginatedList<Order>(ct, count, pageIndex, PageSize);
            return PartialView("_Order", paginatedList);
        }

    }
}
