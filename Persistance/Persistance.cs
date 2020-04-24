using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TP01M05.BO;

namespace TP01M05.Persistance
{
    public class Persistance
    {
        private static Persistance _instance;
        static readonly object instanceLock = new object();

        private Persistance()
        {
            chats = this.GetChats();
        }

        public static Persistance Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (instanceLock)
                    {
                        if (_instance == null)
                            _instance = new Persistance();
                    }
                }
                return _instance;
            }
        }

        private List<Chat> chats;

        public List<Chat> Chats
        {
            get { return chats; }
        }

        private List<Chat> GetChats()
        {
            var i = 1;
            return new List<Chat>
            {
                new Chat{Id=i++,Nom = "Felix",Age = 3},
                new Chat{Id=i++,Nom = "Minette",Age = 1},
                new Chat{Id=i++,Nom = "Miss",Age = 10},
                new Chat{Id=i++,Nom = "Garfield",Age = 6},
                new Chat{Id=i++,Nom = "Chatran",Age = 4},
                new Chat{Id=i++,Nom = "Minou",Age = 2},
                new Chat{Id=i,Nom = "Bichette",Age = 12}
            };
        }
    }
}