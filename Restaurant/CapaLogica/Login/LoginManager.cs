using CapaAccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data.Entity.Migrations;
using CapaLogica.Logger;

namespace CapaLogica.Login
{
    public class LoginManager
    {
        public static Trabajador Login(string username, string pass)
        {
            Trabajador trabajador = null;
            using (RestaurantEntities db = new RestaurantEntities())
            {
                User user = db.User.Include(u => u.Trabajador.Puesto).Where(u => u.username == username).FirstOrDefault();
                if (user == null) return null;
                byte[] generatedHash = HashSHA1(ByteToString(user.salt) + pass + ByteToString(user.salt));
                if (ByteToString(generatedHash) == ByteToString(user.hash))
                {
                    return user.Trabajador;
                }
            }
            return trabajador;
        }


        public static bool AgregarOEditar(string username, string pass, Trabajador trabajador)
        {
            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    byte[] saltA = CreateSalt();
                    User user = new User()
                    {
                        id_trabajador = trabajador.id_trabajador,
                        username = username,
                        hash = HashSHA1(ByteToString(saltA) + pass + ByteToString(saltA)),
                        salt = saltA
                    };
                    // db.User.Add(user);
                    db.Set<User>().AddOrUpdate(user);
                    db.SaveChanges();
                    return true;
                }
            } catch (Exception e)
            {
                Log.Write("Error " + e.Message);
            }
            return false;
        }

        private static byte[] CreateSalt()
        {
            var rng = RandomNumberGenerator.Create();
            const int saltSize = 128;
            var salt = new byte[saltSize];
            rng.GetBytes(salt);
            return salt;
        }

        private static string ByteToString(byte[] bytes)
        {
            var sb = new StringBuilder();
            for (var i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("X2"));
            }
            return sb.ToString();
        }

        private static byte[] HashSHA1(byte[] value)
        {
            var sha1 = System.Security.Cryptography.SHA1.Create();
            var inputBytes = value;
            var hash = sha1.ComputeHash(inputBytes);

            var sb = new StringBuilder();
            for (var i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            // return sb.ToString();
            return hash;
        }

        private static byte[] HashSHA1(string value)
        {
            byte[] inputBytes = Encoding.ASCII.GetBytes(value);
            return HashSHA1(inputBytes);
        }
    }
}
