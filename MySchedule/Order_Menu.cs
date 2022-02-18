using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchedule
{
    public class Order_Menu
    {

        public string Menu { get; set; }
        public string User_Name { get; set; }
        public string HP { get; set; }
        public int Seq { get; set; }
        public Order_Menu()
        {

        }
        public Order_Menu(string MENU, string USER_NAME, string HP, int SEQ)
        {
            this.Menu = MENU;
            this.User_Name = USER_NAME;
            this.HP = HP;
            this.Seq = SEQ;
        }
    }
}
