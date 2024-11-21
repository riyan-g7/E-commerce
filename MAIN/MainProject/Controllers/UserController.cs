using MainProject.Models;
using MainProject.Models.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Stripe.Checkout;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MainProject.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDbContext _dbcontext;
        private const int PageSize = 1;
        public UserController(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User us)
        {
            if (ModelState.IsValid)
            {
                _dbcontext.user.Add(us);
                _dbcontext.SaveChanges();
                ViewBag.msg = "Registered........";
            }
            return View("Register");
        }

        [HttpGet]
        public ActionResult Login()
        {
            HttpContext.Session.Clear();
            return View();
        }
        [HttpPost]
        public ActionResult Login(string uname, string pass)
        {
            User udb = _dbcontext.user.Where(x => x.Email == uname && x.Password == pass).FirstOrDefault();
            Admin adb = _dbcontext.admin.Where(x => x.Email == uname && x.Password == pass).FirstOrDefault();
            if (adb != null)
            {
                if (adb.Role == "Admin")
                {
                    HttpContext.Session.SetInt32("SessionId", (adb.Id));
                    HttpContext.Session.SetString("SessionRole", "Admin");
                    return RedirectToAction("Admin_home", "Admin");
                }
            }
            else if (udb != null)
            {
                HttpContext.Session.SetInt32("SessionId", (udb.Id));
                HttpContext.Session.SetString("SessionRole", "User");
                return RedirectToAction("User_home");
            }
            else
            {
                ViewBag.msg = "Incorrect credentials";
            }
            return View();
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        [HttpGet]
        public ActionResult User_home()
        {
            IEnumerable<Product> pr = _dbcontext.product.ToList();
            return View(pr);
        }

        [HttpGet]
        public ActionResult ProductDetails(int id)
        {

            Cart p = new Cart()
            {
                Products = _dbcontext.product
                .Include(x => x.Categories)
                .Include(x => x.Cover_Types)
                .FirstOrDefault(x => x.Id == id),
                ProductId = id,
            };
            return View(p);
        }
        [HttpPost]
        public ActionResult ProductDetails(int id, int count, Cart cr)
        {
            Cart c = new Cart()
            {
                Products = _dbcontext.product
                .Include(x => x.Categories)
                .Include(x => x.Cover_Types)
                .FirstOrDefault(x => x.Id == id),
                ProductId = id,
            };
            if (ModelState.IsValid)
            {
                cr.Id = 0;
                cr.UserId = Convert.ToInt32(HttpContext.Session.GetInt32("SessionId"));
                Product p = _dbcontext.product.Find(cr.ProductId);
                if (count <= 49)
                {
                    cr.Rate = p.Price;
                }
                else if (count <= 99)
                {
                    cr.Rate = p.Price50;
                }
                else
                {
                    cr.Rate = p.Price100;
                }
                _dbcontext.cart.Add(cr);
                _dbcontext.SaveChanges();
                ViewBag.msg = "Added to cart.....";
            }
            return View(c);
        }

        [HttpGet]
        public ActionResult ViewCart()
        {
            var id = Convert.ToInt32(HttpContext.Session.GetInt32("SessionId"));
            IEnumerable<Cart> c = _dbcontext.cart.Include(x => x.Products)
                .Where(x => x.UserId == id);
            int n = 0, total = 0;
            foreach (var item in c)
            {
                total = (item.Rate * item.Count) + n;
                n = total;
            }
            ViewBag.total = n;
            return View(c);
        }
        public ActionResult DeleteCart(int cid)
        {
            Cart c = _dbcontext.cart.Find(cid);
            if (c != null)
            {
                _dbcontext.cart.Remove(c);
                _dbcontext.SaveChanges();
            }
            return RedirectToAction("ViewCart");
        }

        public ActionResult AddCount(int cid)
        {
            Cart c = _dbcontext.cart.Include(x => x.Products).FirstOrDefault(x => x.Id == cid);
            if (c != null)
            {
                c.Count = c.Count + 1;
                if (c.Count > 0 && c.Count < 50)
                {
                    c.Rate = c.Products.Price;
                }
                if (c.Count > 49 && c.Count < 100)
                {
                    c.Rate = c.Products.Price50;
                }
                if (c.Count > 99)
                {
                    c.Rate = c.Products.Price100;
                }
                _dbcontext.SaveChanges();
            }
            return RedirectToAction("ViewCart");
        }

        public ActionResult SubCount(int cid)
        {
            Cart c = _dbcontext.cart.Include(x => x.Products).FirstOrDefault(x => x.Id == cid);
            if (c != null)
            {
                c.Count = c.Count - 1;
                if (c.Count > 0 && c.Count < 50)
                {
                    c.Rate = c.Products.Price;
                }
                if (c.Count > 49 && c.Count < 100)
                {
                    c.Rate = c.Products.Price50;
                }
                if (c.Count > 99)
                {
                    c.Rate = c.Products.Price100;
                }
                if (c.Count == 0)
                {
                    _dbcontext.cart.Remove(c);
                }
                _dbcontext.SaveChanges();
            }
            return RedirectToAction("ViewCart");
        }

        [HttpGet]
        public ActionResult Summary()
        {
            var uid = Convert.ToInt32(HttpContext.Session.GetInt32("SessionId"));
            CartViewModel c = new CartViewModel()
            {
                orders = new Order(),
                carts = _dbcontext.cart.Include(x => x.Products).Where(x => x.UserId == uid),
            };
            c.orders.Users = _dbcontext.user.Where(x => x.Id == uid).FirstOrDefault();
            c.orders.Name = c.orders.Users.Name;
            c.orders.Phone = c.orders.Users.Phone;
            c.orders.Street = c.orders.Users.Street;
            c.orders.City = c.orders.Users.City;
            c.orders.State = c.orders.Users.State;
            c.orders.Zip_code = c.orders.Users.P_Code;
            int n = 0, total = 0, amt = 0;
            foreach (var item in c.carts)
            {
                amt = (item.Rate * item.Count);
                total = amt + n;
                n = total;
            }
            ViewBag.total = n;
            return View(c);
        }

        [HttpPost]
        public ActionResult Summary(CartViewModel c)
        {
            //Payment
            var domain = "https://localhost:44337";
            List<SessionLineItemOptions> lineItems = new List<SessionLineItemOptions>();
            CartViewModel ct = new CartViewModel()
            {
                orders = new Order(),
                carts = _dbcontext.cart.Include(x => x.Products).Where(x => x.UserId == Convert.ToInt32(HttpContext.Session.GetInt32("SessionId"))),
            };
            foreach (var item in ct.carts)
            {
                string imageUrl = $"{domain}/media{item.Products.Image}";

                lineItems.Add(new SessionLineItemOptions
                {
                    PriceData=new SessionLineItemPriceDataOptions
                    {
                        Currency="usd",
                        UnitAmount=item.Rate*100,
                        ProductData=new SessionLineItemPriceDataProductDataOptions
                        {
                            Name=item.Products.Title,
                            Images=new List<string> { imageUrl },                          
                        }
                    },
                    Quantity = item.Count,
                });;
            }

            var options = new SessionCreateOptions
            {
                LineItems = lineItems,
                Mode = "payment",
                SuccessUrl = domain + "/User/success?session_id={CHECKOUT_SESSION_ID}",
                CancelUrl = domain + "/User/cancel",
            };
            var service = new SessionService();
            Session session = service.Create(options);
            Response.Headers.Add("Location", session.Url);
            //
            c.orders.UserId = Convert.ToInt32(HttpContext.Session.GetInt32("SessionId"));
            c.orders.Users = _dbcontext.user.Where(x => x.Id == Convert.ToInt32(HttpContext.Session.GetInt32("SessionId"))).FirstOrDefault();
            c.orders.Email = c.orders.Users.Email;
            c.orders.Order_date = DateTime.Now.ToString("dd/MM/yyyy");
            c.orders.Shipping_Date = DateTime.Now.AddDays(1).ToString("dd/MM/yyyy");
            c.orders.Payment_Due_Date = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy");
            c.orders.Order_status = "Pending";
            c.orders.Payment_Status = "Pending";
            c.orders.SessionId = session.Id;
            int n = 0, total = 0, amt = 0;
            foreach (var item in ct.carts)
            {
                amt = (item.Rate * item.Count);
                total = amt + n;
                n = total;
            }
            c.orders.Order_total = n;
            _dbcontext.order.Add(c.orders);
            _dbcontext.SaveChanges();
            foreach (var item in ct.carts)
            {
                Order_items ot = new Order_items()
                {
                    OrderId = c.orders.Id,
                    ProductId = item.ProductId,
                    Count = item.Count,
                    Total = item.Rate * item.Count,
                };
                _dbcontext.order_items.Add(ot);
                _dbcontext.cart.Remove(item);
            }
            _dbcontext.SaveChanges();
            
            return new StatusCodeResult(303);
        }
        [HttpGet]
        public ActionResult Ordered()
        {
            return View();
        }          
        
        [HttpGet]
        public ActionResult success(string session_id)
        {
            var order = _dbcontext.order.SingleOrDefault(o => o.SessionId == session_id);
            string path = Path.GetRandomFileName();
            path = path.Replace(".", ""); // Remove period.

            var finalString = new String("txn_"+ path.Substring(0, 8));
            if (order!=null)
            {
                order.Payment_Status = "Paid";
                order.Order_status = "Completed";
                order.TransactionID = finalString;
                _dbcontext.SaveChanges();
            }
            return View();
        }
        [HttpGet]
        public ActionResult cancel()
        {
            return View();
        }

        [HttpGet]
        public ActionResult OrderHistory(int pageIndex=1)
        {
            int id = Convert.ToInt32(HttpContext.Session.GetInt32("SessionId"));
            var count = _dbcontext.order.Where(x => x.UserId == id).Count();
            var ct = _dbcontext.order
                .Where(x=>x.UserId==id)
                .OrderBy(p => p.Id)
                .Skip((pageIndex - 1) * PageSize)
                .Take(PageSize)
                .ToList();
            var paginatedList = new PaginatedList<Order>(ct, count, pageIndex, PageSize);
            return View(paginatedList); 
        }

        [HttpGet]
        public ActionResult MyProfile()
        {
            int id = Convert.ToInt32(HttpContext.Session.GetInt32("SessionId"));
            User u = _dbcontext.user.Find(id);
            return View(u);
        }

        [HttpPost]
        public ActionResult MyProfile(User us)
        {
            int id = Convert.ToInt32(HttpContext.Session.GetInt32("SessionId"));
            User u = _dbcontext.user.Find(id);
            u.Name = us.Name;
            u.Email = us.Email;
            u.Phone = us.Phone;
            u.Street = us.Street;
            u.City = us.City;
            u.State = us.State;
            u.P_Code = us.P_Code;
            _dbcontext.SaveChanges();
            return RedirectToAction("User_home");
        }

        public ActionResult ChangePass(string oldpass,string newpass,string confirm)
        {
            int id = Convert.ToInt32(HttpContext.Session.GetInt32("SessionId"));
            User u = _dbcontext.user.Find(id);
            if (oldpass != null)
            {
                if (oldpass != u.Password)
                {
                    ViewBag.c = "Wrong Password";
                    return View();
                }
                else
                {
                    if (newpass!=null && confirm!=null)
                    {
                        if (newpass != confirm)
                        {
                            ViewBag.c = "Passwords do not match";
                            return View();
                        }
                        else
                        {
                            u.Password = newpass;
                            _dbcontext.SaveChanges();
                            ViewBag.msg = "Password has been changed";
                            return View();
                        }
                    }
                    else
                    {
                        ViewBag.c = "Enter valid Passwords";
                        return View();
                    }
                }
            }
            else
            {

                return View(); 
            }
        }
    }
}

