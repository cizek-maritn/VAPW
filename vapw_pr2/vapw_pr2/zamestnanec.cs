using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vapw_pr2
{
    public class zamestnanec
    {
    }

    public class clovek
    {
        public string Name { get; set; }

        public string Name2 { get; set; } = string.Empty;

        public string Name3
        {
            set { if (value.Length > 3) _name3 = value;
                else _name3 = "default";
            }

            get { return _name3.Split('a')[0]; }
        }

        private string _name3;
        public string Description { get; set; }

        public clovek() {
            Name = "default"+_name3;
            Name = Name.ToUpper();
        }
    }
}
