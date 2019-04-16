using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFIntroduction.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new UsersContext())
            {
                var person = new Person
                {
                    FullName = "Вася Пупкин",
                    Age = 48
                };

                var user = new User
                {
                    Login = "vasja",
                    Password = "b2",
                    PersonId = person.Id
                };

                context.People.Add(person);
                context.Users.Add(user);
                context.SaveChanges();

                var people = context.People.ToList();
            }
        }
    }
}
