using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class ItemDB
    {
        DBConnect db;

        public ItemDB()
        {
            db = new DBConnect();
        }
        public void addItem(string iN,string iD,string iT,string iW, int stam,int str,int intl,int agil, int has,int mas)
        {
            db.Insert(iN, iD, iT, iW, stam, str, intl, agil, has, mas);
        }    
    }
}
