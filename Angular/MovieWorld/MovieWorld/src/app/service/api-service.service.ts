import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiServiceService {

  constructor(private http:HttpClient) { }
  url = "https://api.themoviedb.org/3";
  apikey = "2d0fbe73adf49123bf24bade7108cf85";

  // Visszaadja az aktuálisan trending összes tartalmat a TMDB API-jából.
  //Az Observable aszinkron adatfolyamokat kezel
  trendingApiData(): Observable<any> {
    return this.http.get(`${this.url}/trending/all/week?api_key=${this.apikey}`);
  }

  // Visszaadja az aktuálisan trending filmeket a TMDB API-jából.
  trendingmoviesApiData(): Observable<any> {
    return this.http.get(`${this.url}/trending/movie/day?api_key=${this.apikey}`);
  }

  // Visszaadja az aktuálisan trending filmeket a TMDB API-jából.
  trendingseriesApiData(): Observable<any> {
    return this.http.get(`${this.url}/trending/tv/day?api_key=${this.apikey}`);
  }

  // Visszaadja egy színész részletes információit a megadott azonosító alapján a TMDB API-jából.
  GetActorDetails(id: any): Observable<any> {
    return this.http.get(`${this.url}/person/${id}?api_key=${this.apikey}`)
  }

  // Visszaadja egy színész azon filmjeit, amiben szerepel a megadott azonosító alapján a TMDB API-jából.
  GetActorMovieCredits(id: any): Observable<any> {
    return this.http.get(`${this.url}/person/${id}/movie_credits?api_key=${this.apikey}`)
  }

  // Visszaadja egy színész azon sorozatait, amiben szerepel a megadott azonosító alapján a TMDB API-jából.
  GetActorSeriesCredits(id: any): Observable<any> {
    return this.http.get(`${this.url}/person/${id}/tv_credits?api_key=${this.apikey}`)
  }

}