using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi.";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarDeleted = "Araba silindi.";
        public static string CarsListed = "Arabalar listelendi.";
        public static string CarsListedByBrandId = "Arabalar markalarına göre listelendi.";
        public static string CarsListedByColorId = "Arabalar renklerine göre listelendi.";
        public static string InvalidCarDescription = "Araba açıklaması geçersiz.";
        public static string InvalidCarDailyPrice = "Araba günlük fiyatı geçersiz.";

        public static string UserAdded = "Kullanıcı eklendi.";

        public static string CarNotReturned = "Araba hala kullanımda.";

        public static string RentalAdded = "Kiralama başarılır.";
    }
}
