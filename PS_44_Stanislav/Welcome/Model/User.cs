using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Others;

namespace Welcome.Model
{
    public class User
    {

        public int Id { get; set; }
        public string Names {  get; set; }
        public string Password { get; set; }
        public UserRolesEnum Role {  get; set; }
        public DateTime Expires { get; set; }
    }
}
