using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSPR_API.Models
{
    public class Information
    {
        private int _Id;
        public int Id { get => _Id; set => _Id = value; }

        private string _Name;
        public string Name { get => _Name; set => _Name = value; }

        private string _Value;
        public string Value { get => _Value; set => _Value = value; }

        public Information(int i,string n, string v)
        {
            _Id = i;
            _Name = n;
            _Value = v;
        }
    }
}