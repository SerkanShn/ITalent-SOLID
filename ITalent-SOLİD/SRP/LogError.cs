using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITalent_SOLİD.SRP
{
    class LogError
    {
        public void LogErrorToTextFile(string error)
        {
            Console.WriteLine("Dosyaya log kaydı eklendi");
        }

        public void LogErrorToOracleDatabase(string error)
        {
            Console.WriteLine("Oracle veritabanına log kaydı eklendi");
        }

        public void LogErrorToSQLDatabase(string error)
        {
            Console.WriteLine("SQL veritabanına log kaydı eklendi");
        }

    }
}
