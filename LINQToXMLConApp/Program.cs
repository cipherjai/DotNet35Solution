using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQToXMLConApp
{
  class Program
  {
    static void Main(string[] args)
    {
      XElement xmlBook = XElement.Load("Book.xml");

      #region Select all
      //var result = from x in xmlBook.Elements("Book")
      //             select x;
      #endregion


      //var result = xmlBook.Elements("Book").Where(b => b.Element("Title").Value.Equals("Bourne Identity")).Select(b => b.Element("Title"));

      // var result = xmlBook.Elements("Book").Where(b => b.Element("Title").Value.Equals("Bourne Identity")).ElementAtOrDefault(0);

      //var result = xmlBook.Elements("Book").Where(b => b.Element("Title").Value.Equals("Bourne Identity")).First();

      //foreach (var item in result)
      //{

      // Get all the title with data 
      //var result = from x in xmlBook.Elements("Book")
      //             select x.Element("Title");

      // Get the attribute category
      //var result = from x in xmlBook.Elements("Book")

      //             group x.Element("Title").Value by x.Attribute("Category").Value;


      //foreach (var item in result)
      //{
      //  Console.WriteLine($"{item.Key}-- {item.Count()}");
      //  foreach (var _item in item)
      //  {
      //    Console.WriteLine(_item);
      //  }

      //}

      var result = from x in xmlBook.Elements("Book")
                   where x.Elements("Author").Count() > 1
                   select x;
      foreach (var item in result)
      {
        Console.WriteLine(item);
      }

      XElement contact = new XElement("contacts"),



      contact.Save(@"../../new.xml", SaveOptions.None);

      // functional Construction


      XElement fictionBooks = new XElement("FictionBooks",
        from x in xmlBook.Elements("Book")
        where x.Attribute("Category").Value == "Fiction"
        select  x.Element("Title"));

      Console.WriteLine(fictionBooks);
      fictionBooks.Save(@"../../FictionBooks.xml");
      Console.WriteLine("XML Saved");


      //}
    }
  }
}