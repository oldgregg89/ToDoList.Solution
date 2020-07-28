using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ToDoList.Models
{
  public class Item
  {
    public int ItemId { get; set; }
    public string Description { get; set; }
  }
  public ActionResult Create()
  {
      return View();
  }

  [HttpPost]
  public ActionResult Create(Item item)
  {
      _db.Items.Add(item);
      _db.SaveChanges();
      return RedirectToAction("Index");
  }

}