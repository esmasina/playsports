using playsports.data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Web;

namespace playsports.data.DAL
{
    public class GameDAL
    {
        public List<Game> GetAll()
        {
            using (PlayContext context = new PlayContext())
            {
                List<Game> list = context.Games
                                            .Include("Location")
                                            .Include("Attendance")
                                            .ToList();
                return list;
            }
        }

        public Game GetByID(int id)
        {
            using (PlayContext context = new PlayContext())
            {
                var game = context.Games
                                    .Include("Location")
                                    .Include("Attendance")
                                    .FirstOrDefault(x => x.ID == id);
                                    
                return game;
            }
        }

        public bool AddGame(GameVM vm)
        {
            using (PlayContext context = new PlayContext())
            {
                try
                {
                    Game game = new Entities.Game();
                    Location loc = new Entities.Location();

                    game.Name = vm.Game.Name;
                    game.Type = vm.Game.Type;
                    game.Description = vm.Game.Description;
                    game.Start = vm.Game.Start;
                    game.End = vm.Game.End;
                    game.Created = DateTime.Now;

                    loc.Name = vm.Game.Location.Name;
                    loc.Coordinates = CreatePoint(vm.Latitude, vm.Longitude);

                    game.Location = loc;

                    context.Games.Add(game);
                    context.SaveChanges();

                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }

            
        }

        public bool UpdateGame(GameVM vm)
        {
            using (PlayContext context = new PlayContext())
            {
                try
                {
                    Game game = context.Games.Single(x => x.ID == vm.Game.ID);
                    Location loc = new Entities.Location();

                    game.Name = vm.Game.Name;
                    game.Type = vm.Game.Type;
                    game.Description = vm.Game.Description;
                    game.Start = vm.Game.Start;
                    game.End = vm.Game.End;
                    game.Modified = DateTime.Now;

                    loc.Name = vm.Game.Location.Name;
                    loc.Coordinates = CreatePoint(vm.Latitude, vm.Longitude);

                    game.Location = loc;

                    context.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }

        }

        public bool DeleteGame(int id)
        {
            using (PlayContext context = new PlayContext())
            {
                try
                {
                    Game game = context.Games.Single(x => x.ID == id);
                    context.Games.Remove(game);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }



        public static DbGeography CreatePoint(double lat, double lon, int srid = 4326)
        {
            string wkt = String.Format("POINT({0} {1})", lon, lat);

            return DbGeography.PointFromText(wkt, srid);
        }
    }
}