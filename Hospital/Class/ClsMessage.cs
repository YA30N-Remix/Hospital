using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Class
{
    public static class ClsMessage
    {
        public static string Error = "کد خطا ۱ : خطایی در انجام عملیات رخ داده است";
        public static string ErrRepeat = "کد خطا ۲ : سیستم قادر به ثبت اطلاعات تکراری نمی باشد.";
        public static string ErrModelData = "کد خطا ۳ : داده های اشتباه در اطلاعات ثبتی وجود دارد.";
        public static string ErrNotFound = "کد خطا ۴ : اطلاعات بارگزاری نشد.";
        public static string ErrNotDelete = "کد خطا ۵ : سیستم قادر به حذف این رکورد نمی باشد.";
        public static string ErrNotRegEmptyValue = "کد خطا ۵ : سیستم قادر به ثبت اطلاعات ناقص نمی باشد.";
        public static string ErrNotGetEmptyValue = "کد خطا ۶ : اطلاعات درخواستی ناقص می باشد.";               
    }

}

