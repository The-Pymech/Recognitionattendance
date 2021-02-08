using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recognitionattendance.Services
{
    public class StartDatabase
    {
        public static void CreateDatabase()
        {

          SQLiteConnection db = new SQLiteConnection("FaceRecognizeation.db");
            string sSQl =
                @" CREATE TABLE IF NOT EXISTS User
        (Id    Integer Primary Key Autoincrement NOT NULL,
                LastName  VARCHAR(200),
	            FirstName  VARCHAR(200),
	            ImageName  VARCHAR(200)
                ";
            string dSQl =
               @" CREATE TABLE IF NOT EXISTS User
        (Id    Integer Primary Key Autoincrement NOT NULL,
                LastName  VARCHAR(200),
	            FirstName  VARCHAR(200),
	            ImageName  VARCHAR(200),
                Date VARCHAR(200)
                ";
            ISQLiteStatement eStatement = db.Prepare(sSQl);
            ISQLiteStatement sStatement = db.Prepare(dSQl);
            eStatement.Step();
            sStatement.Step();
        }
    }
}
