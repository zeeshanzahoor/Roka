using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifexPay.Backbone.Security
{
    public sealed partial class Permissions
    {
        [Description("Kullanıcı İşlemleri")]
        public sealed class User
        {
            [Description("Kullanıcı Oluşturma")]
            public string Ekleme { get; set; }
            [Description("Kullanıcı Silme")]
            public string Silme { get; set; }
            [Description("Kullanıcı Güncelleme")]
            public string Guncelleme { get; set; }
            [Description("Kullanıcı Akif Durumu Değiştirme")]
            public string AktifPasifYapma { get; set; }

        }

        [Description("Ürün İşlemleri")]
        public sealed class Urun
        {
            [Description("Ürün Ekleme")]
            public string Ekleme { get; set; }
            [Description("Ürün Silme")]
            public string Silme { get; set; }
            [Description("Ürün Güncelleme")]
            public string Guncelleme { get; set; }
        }
    }
}
