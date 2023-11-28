using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants.Messages
{
    public static class RentalMessage
    {
        public static string RentalAdded = "Araba başarıyla kiralanmıştır.";
        public static string RentalStatus = "Araba teslim edilmediği için kiralanamamaktadır.";
        public static string RentalDeleted = "Araba kiralama bilgisi silinmiştir.";
        public static string RentalUpdated = "Araba kiralama bilgisi güncellendi";
        public static string RentalNameInvalid = "Araba kiralama bilgisi ismi geçersiz";
        public static string RentalsListed = "Araba kiralama bilgileri listelendi";
        public static string RentalGetting = "Araba kiralama bilgisi getirildi";
    }
}
