using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHerencia
{
    abstract class Usuario
    {
        public string Cuenta { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }

        public bool login(string username, string password){
            if(username==this.Cuenta && password==Password)
            {
                Console.WriteLine("Bienvenidos al Sistema");
                return true;
            }
            else{
                Console.WriteLine("Error");
                return false;
            }
        }
        public void login()
        {
            Console.WriteLine("Login con Polimorfismo");
        }
    }
    
}
