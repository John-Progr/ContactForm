using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ContactForm.Models
{
    public class UserRepository
    {

        String Directory { get; set; }
        public UserRepository(String Directory)
        {
            this.Directory = Directory;
        }
        



        public  async void saveUser(User user)
        {
            string line = user.Fullname + "," + user.Phone + "," + user.Email + "," + user.Message;
            

            using StreamWriter file = new(Directory, append: true);

            await file.WriteLineAsync(line);

        }


       

    }
}
