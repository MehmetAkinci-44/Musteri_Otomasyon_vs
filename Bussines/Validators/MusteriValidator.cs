using Bussines.Managers;
using DataAccess.Context;
using DataAccess.Repositories;
using Entity;
using FluentValidation;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Bussines.Validators
{
    public class MusteriValidator:AbstractValidator<Musteri>
    {
        public MusteriValidator()
        {
            RuleFor(x => x.Telefon).Must((musteri, telefon) => BeUnique_tel(musteri, telefon)).WithMessage("Bu telefon numarası başka bir müşteri tarafından kullanılıyor.");
            RuleFor(x => x.E_mail).Must((musteri,email) => BeUniqu_email(musteri,email)).WithMessage("Bu email adresi başka bir müşteri tarafından kullanılıyor.");
            RuleFor(x => x.Adi).NotNull().WithMessage("Adı boş geçilemez");
            RuleFor(x => x.Soyadi).NotNull().WithMessage("Soyadı boş geçilemez");
            RuleFor(x => x.Dogum_Tarihi).NotNull().WithMessage("Doğum tarihi boş geçilemez");
            RuleFor(x => x.Adi).MinimumLength(2).WithMessage("Adı alanı en az 2 karakter içermeli");
            RuleFor(x => x.Soyadi).MinimumLength(2).WithMessage("Soyadı alanı en az 2 karakter içermeli");
            RuleFor(x => x.Adi).MaximumLength(25).WithMessage("Adı alanı 25 karakterden fazla olamaz");
            RuleFor(x => x.Soyadi).MaximumLength(25).WithMessage("Soyadı alanı 25 karakterden fazla olamaz");
            RuleFor(x => x.E_mail).EmailAddress().WithMessage("Geçerli bir email adresi girin");
            RuleFor(x => x.Telefon).MaximumLength(11).WithMessage("Telefon numarası 11 haneden büyük olamaz");
            RuleFor(x => x.Telefon).MinimumLength(11).WithMessage("Telefon numarası 11 haneden küçük olamaz");
            RuleFor(x => x.Dogum_Tarihi).LessThan(DateTime.Now.Date).WithMessage("Lütfen geçerli bir doğum taihi giriniz");
            RuleFor(x => x.Dogum_Tarihi).GreaterThan(Convert.ToDateTime ("01.01.1900")).WithMessage("Doğum tarihi 01.01.1900'den önce olamaz");

        } 

        private bool BeUnique_tel (Musteri musteri, string telefon)
        {
            //int deger = 0;
            //string connectionstring = "server = (localdb)\\MSSQLLocalDB; database = Musteridb; integrated security = true;";
            //string sqlquery = "SELECT Telefon FROM Musteris WHERE Telefon = @telefon ";
            //using (SqlConnection connection = new SqlConnection(connectionstring)) 
            //{
            //connection.Open();
            //using (SqlCommand command = new SqlCommand(sqlquery, connection))
            //{
            //    command.Parameters.AddWithValue("@telefon", telefon);
            //    using (SqlDataReader reader = command.ExecuteReader())
            //    {
            //        while(reader.Read())
            //        {
            //            MyModel model = new MyModel
            //            {
            //                sayi = reader.GetInt32(reader.GetOrdinal("COUNT(*)")),
            //            };
            //            deger = model.sayi;
            //        }
            //    }
            //}


            // }

            //if (deger >= 1)
            // {
            //     return false;
            // }
            //else
            // {
            //     return true;

            //}


            using (context_musteri context = new context_musteri())
            {


                var item = context.Musteris.FirstOrDefault(x => x.Telefon == musteri.Telefon);
                if (item != null)
                {
                    return false;
                }

                else
                {
                    return true;
                }
            }

            
        }

        private bool BeUniqu_email (Musteri musteri, string email)
        {
            using (context_musteri context = new context_musteri())
            {


                var item = context.Musteris.FirstOrDefault(x => x.E_mail == email);
                if (item != null)
                {
                    return false;
                }

                else
                {
                    return true;
                }
            }
        }


        //public class MyModel 
        //{
        //    public int sayi { get; set; }
            
        //}
    }
}
