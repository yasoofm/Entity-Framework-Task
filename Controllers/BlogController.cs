using Entity_FrameWork.Models;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;

namespace Entity_FrameWork.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            var db = new BloggingContext();
            var a = db.Blogs.ToList();
            return View(db.Blogs.ToList());
        }

        public IActionResult AddBlog()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBlog(FormBlogAdd blog)
        {
            if(ModelState.IsValid)
            {
                var db = new BloggingContext();
                Blog newBlog = new Blog() { Name = blog.Name, Url = blog.Url};
                db.Blogs.Add(newBlog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(blog);
        }

        public IActionResult DeleteBlog(int Id)
        {
            var db = new BloggingContext();
            var blog = db.Blogs.Where(b => b.Id == Id).FirstOrDefault();
            if(blog != null)
            {
                db.Blogs.Remove(blog);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
