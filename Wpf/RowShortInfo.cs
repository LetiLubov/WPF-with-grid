using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf
{
    public class RowShortInfo
    {
        public RowShortInfo(int i1, String s2)
        {
            RowNumber = i1;
            Title = s2;
        }
        public RowShortInfo(int r, String t, int i, string a, string p, string c)
        {
            RowNumber = r;
            Title = t;
            Id = i;
            Author = a;
            Price = p;
            Country = c;
        }
        public RowShortInfo(MyProduct p)
        {
          
            Title = p.Title;
            Id = p.Id;
            Author = p.Author;
            Price = p.Price;
            Country = p.Country;
        }
        public String Title {get; set;}
        public int RowNumber { get; set; }
        public int Id { get; set; }
        public string Author { get; set; }
        public string Price { get; set; }
        public string Country { get; set; }
    }
}
