using System;

namespace week07
{
    public interface IAccount
    {
        // interface members
        Int32 getLeeftijd();

       // Void generatePassword();

        String generateLogin();
        
        String createAhsMail();
    }
}