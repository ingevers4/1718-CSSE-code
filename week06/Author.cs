using System;

namespace week06
{
   // Class definition.
   public class Author
   {
      private string authorName;
      private string email;
      private char gender;


      public string AuthorName { get => authorName; set => authorName = value; }
      
      public string Email { get => email; set => email = value; }

      public char Gender { get => gender; set => gender = value; }
        
   }
}