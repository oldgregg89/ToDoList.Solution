using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;
using System.Linq;

namespace ToDoList.Controllers
{
  public class ItemsController : Controller
  {
    private readonly ToDoListContext _db;
    public ItemsController(ToDoListContext db)
    {
_db = db;
    }
    public ActionResult Index()
    {
      List<Item> model = _db.Items.ToList();
      return View(model);
    }

    public ActionResult Details( int id )
    {
      Item thisItem = _db.Items.FirstOrDefault(items => items.ItemId == id);
return View(thisItem);
    }
  }
}

