using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Project_JobApp.Classes
{
    internal class Seeker : Info
    {
        public Seeker(string _id, string _password, string _name, string _role, string _bday, string _sex, string _address, string _phone, string _email, Image _photo, string _moreinfo):base(_id, _password, _name, _role, _bday, _sex, _address, _phone,  _email, _photo, _moreinfo)
        {

        }
    }
}
