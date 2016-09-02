using playsports.data.DAL;
using playsports.data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace playsports.data.Facade
{
    public class GameFacade
    {
        private GameDAL GameDAL = new GameDAL();

        public List<Game> GetAll()
        {
            return GameDAL.GetAll();
        }

        public Game GetById(int id)
        {
            return GameDAL.GetByID(id);
        }

        public bool AddGame(GameVM vm)
        {
            return GameDAL.AddGame(vm);
        }

        public bool UpdateGame(GameVM vm)
        {
            return GameDAL.UpdateGame(vm);
        }

        public bool DeleteGame(int id)
        {
            return GameDAL.DeleteGame(id);
        }
    }
}