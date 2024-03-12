using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project_JobApp.Classes
{
    internal class Info
    {
        private string _id;
        private string _password;
        private string _name;
        private string _role;
        private string _bday;
        private string _sex;
        private string _address;
        private string _phone;
        private string _email;
        private Image _photo;
        private string _moreinfo;
        
        public Info(string _id, string _password, string _name, string _role, string _bday, string _sex, string _address, string _phone, string _email, Image _photo, string _moreinfo)
        {
            this._id = _id;
            this._password = _password; 
            this._name = _name; 
            this._role = _role;
            this._bday = _bday;
            this._sex = _sex;
            this._address = _address;
            this._phone = _phone;
            this._email = _email;
            this._photo = _photo;
            this._moreinfo = _moreinfo;
        }
        
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Role
        {
            get { return _role; }
            set { _role = value; }
        }
        public string Bday
        {
            get { return _bday; }
            set { _bday = value; }
        }
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public Image Photo
        {
            get { return _photo; }
            set { _photo = value; }
        }
        public string MoreInfo
        {
            get { return _moreinfo; }
            set { _moreinfo = value; }
        }
    }
}
