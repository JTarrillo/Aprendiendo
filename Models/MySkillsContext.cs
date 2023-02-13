using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Aprendiendo.Models
{
    public class MySkillsContext : DbContext
    {
        public MySkillsContext()
              : base("CSharpCornerEntities")
        {

        }
       
        public DbSet<MySkills> MySkills { get; set; }
    }
}
