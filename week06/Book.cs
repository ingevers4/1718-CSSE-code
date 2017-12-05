using System;

namespace week06
{
   // Book erft een gedeelte over van Author = inheritance
   public class Book : Author
   {
       private string bookname;
       private double price;
       private int qtyInStock = 0;

    // deze waarden neem ik over van de Author Class
    // dus hij neemt de waarden via de get en set methodes van Author en zet deze om naar een book method
    // zodat ze in deze klasse nu ook bruikbaar worden, ookal zijn het wel private methods
       public Book (string bookname, string authorName, double price, int qtyInStock) {
           this.Bookname = bookname;
           this.AuthorName = authorName;
           this.Price = price;
           this.QtyInStock = qtyInStock;
       }

       public string Bookname { get => bookname; set => bookname = value; }

       public double Price {get => price; set => price = value; }

       public int QtyInStock {get => qtyInStock; set => qtyInStock = value; }

       public void GetAuthor (string authorName) {
           this.AuthorName = authorName;
       }

       public void GetEmail (string email) {
           this.Email = email;
       }

       public void GetGender (char gender) {
           this.Gender = gender;
       }

       public void Print() {

       }


       
   }
}