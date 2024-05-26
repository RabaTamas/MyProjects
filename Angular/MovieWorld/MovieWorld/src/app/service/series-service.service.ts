import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SeriesServiceService {

  constructor(private http: HttpClient) { }
  url = "https://api.themoviedb.org/3";
  apikey = "2d0fbe73adf49123bf24bade7108cf85";

  // Keresés sorozatokra a megadott szórészletek alapján.
  //Az Observable aszinkron adatfolyamokat kezel
  GetSearchSeries(data: any): Observable<any> {
    console.log(data, 'series#');
    return this.http.get(`${this.url}/search/tv?api_key=${this.apikey}&query=${data.seriesName}`);
  }

  // Visszaadja a legjobbra értékelt sorozatokat.
  GetTopRatedSeries(): Observable<any> {
    return this.http.get(`${this.url}/tv/top_rated?api_key=${this.apikey}`)
  }

  // Visszaadja az aktuálisan sugárzott sorozatokat.
  GetOnTheAirSeries(): Observable<any> {
    return this.http.get(`${this.url}/tv/on_the_air?api_key=${this.apikey}`)
  }

  // Visszaadja a népszerű sorozatokat.
  GetPopularSeries(): Observable<any> {
    return this.http.get(`${this.url}/tv/popular?api_key=${this.apikey}`)
  }

  // Visszaadja egy sorozat egy adott évadának részleteit a megadott azonosító és évad szám alapján.
  GetSeriesSeasonDetails(id: any, snumber: any): Observable<any> {
    return this.http.get(`${this.url}/tv/${id}/season/${snumber}?api_key=${this.apikey}`)
  }

  // Visszaadja egy sorozat részleteit a megadott azonosító alapján.
  GetSeriesOverview(data: any): Observable<any> {
    return this.http.get(`${this.url}/tv/${data}?api_key=${this.apikey}`)
  }

  // Visszaadja egy sorozat szereplőit a megadott azonosító alapján.
  GetSeriesCast(data: any): Observable<any> {
    return this.http.get(`${this.url}/tv/${data}/credits?api_key=${this.apikey}`)
  }

  // Visszaadja a vígjáték sorozatokat.
  GetComedySeries(): Observable<any> {
    return this.http.get(`${this.url}/discover/tv?api_key=${this.apikey}&with_genres=35`);
  }

  // Visszaadja a történelmi sorozatokat.
  GetHistorySeries(): Observable<any> {
    return this.http.get(`${this.url}/discover/tv?api_key=${this.apikey}&with_genres=36`);
  }

  // Visszaadja a bűnügyi sorozatokat.
  GetCrimeSeries(): Observable<any> {
    return this.http.get(`${this.url}/discover/tv?api_key=${this.apikey}&with_genres=80`);
  }

  // Visszaadja a sci-fi sorozatokat.
  GetSciFiSeries(): Observable<any> {
    return this.http.get(`${this.url}/discover/tv?api_key=${this.apikey}&with_genres=878`);
  }

  // Visszaadja az akció sorozatokat.
  GetActionSeries(): Observable<any> {
    return this.http.get(`${this.url}/discover/tv?api_key=${this.apikey}&with_genres=28`);
  }

}