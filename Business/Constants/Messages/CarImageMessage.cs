using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants.Messages
{
    public static class CarImageMessage
    {
        public static string CarImageAdded = "Araba resmi eklendi";
        public static string CarImageDeleted = "Araba resmi silindi";
        public static string CarImageUpdated = "Araba resmi güncellendi";
        public static string CarImagesListed = "Tüm arabaların resimleri listelendi";
        public static string CarImagesByCarListed = "Arabanın resimleri listelendi";
        public static string CarImageGetting = "Araba resmi getirildi";


        public static string CarImageCountError = "Bir arabanın en fazla 5 resmi olabilir.";
    }
}
