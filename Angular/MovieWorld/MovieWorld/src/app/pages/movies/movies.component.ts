import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { MoviesServiceService } from '../../service/movies-service.service';

@Component({
  selector: 'app-movies',
  templateUrl: './movies.component.html',
  styleUrl: './movies.component.css'
})
export class MoviesComponent implements OnInit {

  // Dependency injection segítségével injektáljuk a MoviesServiceService osztályt.
  constructor(private service: MoviesServiceService) {} 

  // Deklaráljuk a különböző filmek eredményeit tartalmazó tömböket.
  ComedyMoviesResult: any = [];
  TopRatedMoviesResult: any = [];
  PopularMoviesResult: any = [];
  UpcomingMoviesResult: any = [];
  HistoryMoviesResult: any = [];
  CrimeMoviesResult: any = [];
  ActionMoviesResult: any = [];
  SciFiMoviesResult: any = [];

  // A komponens inicializációjakor meghívott ngOnInit metódus.
  // Az ngOnInit metódus meghívja a különböző adatlekérő metódusokat
  // a különböző típusú filmek számára.
  ngOnInit(): void {
    
    this.ComedyMoviesData();
    this.UpcomingMoviesData();
    this.TopRatedMoviesData();
    this.PopularMoviesData();
    this.HistoryMoviesData();
    this.CrimeMoviesData();
    this.ActionMoviesData();
    this.SciFiMoviesData();
  }

  // A keresési eredményeket tároló változó.
  searchResult: any;
  
  // A keresési űrlapot reprezentáló FormGroup objektum.
  // Egyetlen vezérlővel rendelkező FormGroup, ami egy beviteli mezőt tartalmaz a filmek kereséséhez.
  searchForm = new FormGroup({
    'movieName': new FormControl(null) 
  });

  // Az űrlap elküldéséért felelős metódus. A keresési űrlap értékének logolása.
  // A keresési szolgáltatás meghívása a keresett filmekkel. A keresési eredmények logolása.
  // A keresési eredmények mentése a searchResult változóba.
  submitForm() {
    
    console.log(this.searchForm.value, 'searchform#');
    this.service.GetSearchMovie(this.searchForm.value).subscribe((result) => {
      console.log(result, 'searchmovie##');
      this.searchResult = result.results;
    });
  }

  //Hamarosan érkező filmek lekérése
  // Először hívja a szolgáltatás `GetUpcomingMovies` metódusát
  //Kiírja a result-ot a konzolra a upcomingmoviesresult# kulcs segítségével
  // A kapott adatokat a UpcomingMoviesResult tömbben tárolja
  UpcomingMoviesData() {
    this.service.GetUpcomingMovies().subscribe((result) => {
      console.log(result, 'upcomingmoviesresult#');
      this.UpcomingMoviesResult = result.results;
    });
  }

  //Ugyanaz mint az UpcomingMoviesData
  TopRatedMoviesData() {
    this.service.GetTopRatedMovies().subscribe((result) => {
      console.log(result, 'topratedmoviesresult#');
      this.TopRatedMoviesResult = result.results;
    });
  }

  //Ugyanaz mint az UpcomingMoviesData
  PopularMoviesData() {
    this.service.GetPopularMovies().subscribe((result) => {
      console.log(result, 'popularmoviesresult#');
      this.PopularMoviesResult = result.results;
    });
  }

  //Ugyanaz mint az UpcomingMoviesData, csak itt nincs logolás
  ComedyMoviesData() {
    this.service.GetComedyMovies().subscribe((result) => {
      this.ComedyMoviesResult = result.results;
    });
  }

  //Ugyanaz mint az UpcomingMoviesData, csak itt nincs logolás
  HistoryMoviesData() {
    this.service.GetHistoryMovies().subscribe((result) => {
      this.HistoryMoviesResult = result.results;
    });
  }

  //Ugyanaz mint az UpcomingMoviesData, csak itt nincs logolás
  CrimeMoviesData() {
    this.service.GetCrimeMovies().subscribe((result) => {
      this.CrimeMoviesResult = result.results;
    });
  }

  //Ugyanaz mint az UpcomingMoviesData, csak itt nincs logolás
  ActionMoviesData() {
    this.service.GetActionMovies().subscribe((result) => {
      this.ActionMoviesResult = result.results;
    });
  }

  //Ugyanaz mint az UpcomingMoviesData, csak itt nincs logolás
  SciFiMoviesData() {
    this.service.GetSciFiMovies().subscribe((result) => {
      this.SciFiMoviesResult = result.results;
    });
  }


}