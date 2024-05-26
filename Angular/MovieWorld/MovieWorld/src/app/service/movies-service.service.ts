import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MoviesServiceService {

  constructor(private http:HttpClient) { }
  url = "https://api.themoviedb.org/3";
  apikey = "2d0fbe73adf49123bf24bade7108cf85";

  // Keresés filmekre a megadott szórészletek alapján.
  //Az Observable aszinkron adatfolyamokat kezel
  GetSearchMovie(data: any): Observable<any> {
    console.log(data, 'movie#');
    return this.http.get(`${this.url}/search/movie?api_key=${this.apikey}&query=${data.movieName}`);
  }

  // Visszaadja a legjobbra értékelt filmeket.
  GetTopRatedMovies(): Observable<any> {
    return this.http.get(`${this.url}/movie/top_rated?api_key=${this.apikey}`)
  }

  // Visszaadja a hamarosan érkező filmeket.
  GetUpcomingMovies(): Observable<any> {
    return this.http.get(`${this.url}/movie/upcoming?api_key=${this.apikey}`)
  }

  // Visszaadja a népszerű filmeket.
  GetPopularMovies(): Observable<any> {
    return this.http.get(`${this.url}/movie/popular?api_key=${this.apikey}`)
  }

  // Visszaadja egy film részleteit a megadott azonosító alapján.
  GetMovieOverview(data: any): Observable<any> {
    return this.http.get(`${this.url}/movie/${data}?api_key=${this.apikey}`)
  }

  // Visszaadja egy film szereplőit a megadott azonosító alapján.
  GetMovieCast(data: any): Observable<any> {
    return this.http.get(`${this.url}/movie/${data}/credits?api_key=${this.apikey}`)
  }

  // Visszaadja egy film ajánlásait a megadott azonosító alapján.
  GetRecomendMovies(id: any): Observable<any> {
    return this.http.get(`${this.url}/movie/${id}/recommendations?api_key=${this.apikey}`);
  }

  // Visszaadja egy film hasonló filmjeit a megadott azonosító alapján.
  GetSimilarMovies(id: any): Observable<any> {
    return this.http.get(`${this.url}/movie/${id}/similar?api_key=${this.apikey}`);
  }

  // Visszaadja a vígjáték filmeket.
  GetComedyMovies(): Observable<any> {
    return this.http.get(`${this.url}/discover/movie?api_key=${this.apikey}&with_genres=35`);
  }

  // Visszaadja a történelmi filmeket.
  GetHistoryMovies(): Observable<any> {
    return this.http.get(`${this.url}/discover/movie?api_key=${this.apikey}&with_genres=36`);
  }

  // Visszaadja a bűnügyi filmeket.
  GetCrimeMovies(): Observable<any> {
    return this.http.get(`${this.url}/discover/movie?api_key=${this.apikey}&with_genres=80`);
  }

  // Visszaadja a sci-fi filmeket.
  GetSciFiMovies(): Observable<any> {
    return this.http.get(`${this.url}/discover/movie?api_key=${this.apikey}&with_genres=878`);
  }

  // Visszaadja az akciófilmeket.
  GetActionMovies(): Observable<any> {
    return this.http.get(`${this.url}/discover/movie?api_key=${this.apikey}&with_genres=28`);
  }
  
}
