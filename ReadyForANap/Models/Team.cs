using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ReadyForANap.Models
{
    public class Team
    {
        //Make sure you build before you do anything, to make your model visible
        //When you Build Solution, you're basically COMPILE your codes, making sure you're syntactically correct (syntax)
        //Store Data --> Purpose of Model

        [DisplayName("Team ID")]
        public string TeamID { get; set; }
        //.NET automatically thinks anything that contains "ID" is the primary key! (Last two characters, which is "ID" in this case)
        //We don't normally want people to edit our Primary Key, so it is not showing up in our index view but Team Name does!

        [DisplayName("Team Name")]
        public string TeamDescription { get; set; }

        [DisplayName("Team Score")]
        public int TeamScore { get; set; }
    }
}