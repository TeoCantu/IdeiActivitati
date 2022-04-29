using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace IdeiActivitati
{
    public class DaoActivitate
    {
        SQLiteConnection connection;
        string cale;

        public DaoActivitate()
        {
            cale = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "activitate.db");
            connection = new SQLiteConnection(cale);
            connection.CreateTable<Activitate>();
        }

        public int AdaugaActivitate (Activitate activitate)
        {
            return connection.Insert(activitate);
        }

        public List<Activitate> ObtineToateInregistrarile ()
        {
            return connection.Query<Activitate>("select * from activitati");
        }
        public List<Activitate> ObtineActivitateDindData(DateTime data)
        {
            return connection.Query<Activitate>("select * from curs_valutar where date(data) = ?", data.ToString("yyyy-MM-dd"));
        }
    }
}
