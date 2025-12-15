using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFManagerMoney
{
    public class Format
    {
        // Hàm định dạng tiền Việt Nam cho lbGiveMoney
        public static string SetGiveMoney(decimal amount)
        {
            return amount.ToString("N0") + " đ";
        }

        // Hàm định dạng xx/XX cho lbNumberContractDuedate
        public static string SetNumberContractDuedate(int dueCount, int totalCount)
        {
            return $"{dueCount:D2}/{totalCount:D2}";
        }
    }
}
