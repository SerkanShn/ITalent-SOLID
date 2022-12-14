using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITalent_SOLİD.SRP
{
    internal class GetError
    {
        public string GetErrorLogs(string type)
        {
            return type switch
            {
                "FromSQLDatabase" => "SQL veritabanından loglar alındı",
                "FromOracleDatabase" => "Oracle veritabanından loglar alındı",
                "FromTextFile" => "Dosyadan loglar alındı",

            };
        }

        public int GetErrorLogsCount(string type)
        {
            return type switch
            {
                "FromSQLDatabase" => 10,
                "FromOracleDatabase" => 20,
                "FromTextFile" => 30,

            };
        }
    }
}
