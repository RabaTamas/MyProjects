using MovieWebSocketService.Data;
using MovieWebSocketService.Models;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.WebSockets;

namespace MovieWebSocketService
{
    public class MoviesEndpoint: BaseEndpoint
    {
        AppDbContext dbcontext = new AppDbContext();

        public override async Task<string> Create(WebSocket socket, Dictionary<string, string> entity)
        {
            Movie movie = new Movie() { Title = entity["title"], Description = entity["description"], MovieImageUrl = entity["movieimageurl"], Year = int.Parse(entity["year"]) };
            string valueOfactorids = entity["actorids"];
           
            foreach (var v in valueOfactorids.Split(','))
            {
                if(int.TryParse(v,out int id)) {

                    movie.Actors.Add(dbcontext.Actors.FirstOrDefault(a => a.ActorId == id));

                }
                
            }

            dbcontext.Movies.Add(movie);
            dbcontext.SaveChanges();

            return Output();
        }

        public override async Task<string> Delete(WebSocket socket, Dictionary<string, string> entity)
        {
            var movieToDelete = dbcontext.Movies.FirstOrDefault(m =>m.MovieId == int.Parse(entity["movieid"]));
            if (movieToDelete != null)
            {
                dbcontext.Movies.Remove(movieToDelete);
                dbcontext.SaveChanges();
               
                return Output();
            }
            else
            {
                return "Movie not found.";
            }
        }

        public override async Task<string> GetEntities(WebSocket socket) { 
            var actors = dbcontext.Actors.ToList();
            Dictionary<int, string> d = new Dictionary<int, string>();
            foreach (var actor in actors)
            {
                d[actor.ActorId] = actor.Name;
            }
            Dictionary<string,Dictionary<int,string>> dd = new Dictionary<string,Dictionary<int,string>>();
            dd["actors"] = d;
            string json = JsonConvert.SerializeObject(dd, Formatting.Indented);
            
            return json;
        }

        private string Output() {

            List<Dictionary<string, string>> movies = new List<Dictionary<string, string>>();
            List<Actor> actors = dbcontext.Actors.Include(x => x.Movies).ToList();
            
            foreach (var m in dbcontext.Movies)
            {

                Dictionary<string, string> d = new Dictionary<string, string>();
                d["MovieId"] = m.MovieId.ToString();
                d["title"] = m.Title;
                d["description"] = m.Description;
                d["movieimageurl"] = m.MovieImageUrl;
                d["year"] = m.Year.ToString();
                d["actors"] = String.Join(", ", actors.Where(x => x.Movies.Select(x=>x.Title).Contains(m.Title)).Select(x => x.Name));
                movies.Add(d);

            }
            Dictionary<string, List<Dictionary<string, string>>> dd = new Dictionary<string, List<Dictionary<string, string>>>();
            dd["movies"] = movies;
            string json = JsonConvert.SerializeObject(dd, Formatting.Indented);
            return json;

        }

        public override async Task<string> ListEntities(WebSocket socket) {
            return Output();
        }



    }

}
