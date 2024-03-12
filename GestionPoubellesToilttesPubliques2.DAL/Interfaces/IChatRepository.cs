using GestionPoubellesToilttesPubliques2.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GestionPoubellesToilttesPubliques2.DAL.Entities.Chat;

namespace GestionPoubellesToilttesPubliques2.DAL.Interfaces
{
    public interface IChatRepository
    {
        bool Create(Chat chat);
        void CreateChat(Chat chat);
        IEnumerable<Chat?> GetAll();
        Chat? GetById(int chat_Id);
        Chat? Delete(int chat_Id);
    }
}
