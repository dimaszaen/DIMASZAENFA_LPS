using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soal_A.Utility
{
    public class ConnectionString
    {
       private static string cName = "Data Source=10.112.86.70;Initial Catalog=DIMASZFA_LPS;User ID=sa;Password=P@ssw@rd";
       public static string CName { get => cName; }
    }
}
