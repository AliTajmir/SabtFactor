using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public static class ConvertDate
    {
        public static string ToShamsi(this DateTime date)
        {
            PersianCalendar persian = new PersianCalendar();
          return  persian.GetYear(date).ToString("####") + "/" + persian.GetMonth(date).ToString("##") + "/" + persian.GetDayOfMonth(date).ToString("##");
        }
    }
}
