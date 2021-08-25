using app_mysql.Models;
using System.Collections.Generic;
using System.Linq;


namespace app_mysql.Services
{
    public class InfoService
    {
        static List<Info> Infos { get; }
        static int nextId = 4;
        static InfoService()
        {
            Infos = new List<Info>
            {
                new Info { id = 1, name = "Lisandro", age = 10 },
                new Info { id = 2, name = "Sebas", age = 43 },
                new Info { id = 3, name = "Florencia", age = 29 }
            };
        }

        public static List<Info> GetAll() => Infos;

        public static Info Get(int id) => Infos.FirstOrDefault(p => p.id == id);

        public static void Add(Info info)
        {
            info.id = nextId++;
            Infos.Add(info);
        }


        public static void Delete(int id)
        {
            var info = Get(id);
            if(info is null)
                return;

            Infos.Remove(info);
        }

        public static void Update(Info info)
        {
            var index = Infos.FindIndex(p => p.id == info.id);
            if(index == -1)
                return;

            Infos[index] = info;
        }



    }
}