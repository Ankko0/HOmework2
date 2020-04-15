using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOmework2
{
    class DBInit: CreateDatabaseIfNotExists<studentsDB>
    {
        protected override void Seed(studentsDB db)
        {
            Name name = new Name { ID = 0, Name1 = "радиофизика" };
            Name name2 = new Name { ID = 1, Name1 = "микроэлектроника" };
            Name name3 = new Name { ID = 2, Name1 = "общая физика" };
            
            db.Names.Add(name);
            db.Names.Add(name2);
            db.Names.Add(name3);
            db.SaveChanges();


            Group g1 = new Group { ID = 0, Name_ID = 0, Number = 1 };
            Group g2 = new Group { ID = 1, Name_ID = 1, Number = 2 };
            Group g3 = new Group { ID = 2, Name_ID = 2, Number = 3 };

            db.Groups.Add(g1);
            db.Groups.Add(g2);
            db.Groups.Add(g3);
            db.SaveChanges();
        }
    }
   

}
