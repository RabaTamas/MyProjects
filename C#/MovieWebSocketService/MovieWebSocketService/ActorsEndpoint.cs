using MovieWebSocketService.Data;
using MovieWebSocketService.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Net.WebSockets;
using System.Text.Json;



namespace MovieWebSocketService
{
    public class ActorsEndpoint: BaseEndpoint
    {
        List<Actor> actors = new List<Actor>();

        AppDbContext dbcontext = new AppDbContext();

         public override async Task<string> Create(WebSocket socket,Dictionary<string,string> entity) {


            Actor actor = new Actor() { Name = entity["name"], CV = entity["cv"], PictureUrl = entity["pictureurl"] };
            string valueOfmovieids = entity["movieids"];

            foreach (var v in valueOfmovieids.Split(','))
            {
                if (int.TryParse(v, out int id))
                {

                    actor.Movies.Add(dbcontext.Movies.FirstOrDefault(m => m.MovieId == id));

                }

            }

            dbcontext.Add(actor);
            dbcontext.SaveChanges();

            return Output();

        }

        public override async Task<string> Delete(WebSocket socket, Dictionary<string, string> entity)
        {
            
            var actorToDelete = dbcontext.Actors.FirstOrDefault(a => a.ActorId == int.Parse(entity["actorid"]));
            if (actorToDelete != null)
            {
                dbcontext.Actors.Remove(actorToDelete);
                dbcontext.SaveChanges();

                return Output();
            }
            else
            {
                return "Actor not found.";
            }
        }

        public override async Task<string> GetEntities(WebSocket socket)
        {
            var movies = dbcontext.Movies.ToList();
            Dictionary<int, string> d = new Dictionary<int, string>();
            foreach (var movie in movies)
            {
                d[movie.MovieId] = movie.Title;
            }
            Dictionary<string, Dictionary<int, string>> dd = new Dictionary<string, Dictionary<int, string>>();
            dd["movies"] = d;
            string json = JsonConvert.SerializeObject(d, Formatting.Indented);
            return json;


        }

        private string Output() {

            List<Dictionary<string, string>> actors = new List<Dictionary<string, string>>();
            List<Movie> movies = dbcontext.Movies.Include(x => x.Actors).ToList();

            foreach (var a in dbcontext.Actors)
            {

                Dictionary<string, string> d = new Dictionary<string, string>();
                d["ActorId"] = a.ActorId.ToString();
                d["name"] = a.Name;
                d["cv"] = a.CV;
                d["actorimageurl"] = a.PictureUrl;
                d["movies"] = String.Join(", ", movies.Where(x => x.Actors.Select(x => x.Name).Contains(a.Name)).Select(x => x.Title));
                actors.Add(d);

            }
            Dictionary<string, List<Dictionary<string, string>>> dd = new Dictionary<string, List<Dictionary<string, string>>>();
            dd["actors"] = actors;
            string json = JsonConvert.SerializeObject(dd, Formatting.Indented);
            return json;
        }

        public override async Task<string> ListEntities(WebSocket socket)
        {
            return Output();
        }


    }


}
