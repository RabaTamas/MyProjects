import { Component, OnInit } from '@angular/core';
import {ActivatedRoute } from '@angular/router';
import { MoviesServiceService } from '../../service/movies-service.service';

@Component({
  selector: 'app-movie-deatils',
  templateUrl: './movie-deatils.component.html',
  styleUrl: './movie-deatils.component.css'
})
export class MovieDeatilsComponent implements OnInit{

  constructor(private service: MoviesServiceService, private router:ActivatedRoute) {}
  
  // Változók az eredmények tárolására
  GetMovieOverviewResult: any;
  GetMovieCastResult: any;
  GetRecomendMoviesResult: any;
  GetSimilarMoviesResult: any;

  // Feliratkozás az útvonal paraméterek változásaira
  // Az aktuális 'id' paraméter elmentése
  ngOnInit(): void {
    this.router.params.subscribe(params => {
      let Id = params['id'];
      console.log(Id,'id#');
  
      this.GetMovieOverviewData(Id);
      this.GetMovieCastData(Id);
      this.GetRecomendMoviesData(Id);
      this.GetSimilarMoviesData(Id);
    });
  }


  //A megadott azonosítójú film részletes adatainak lekérése és tárolása
  // Hívja a szolgáltatás `GetMovieOverview` metódusát aminek átadja az id
  //Kiírja a result-ot a konzolra a getmovieoverview# kulcs segítségével
  // A kapott adatokat a GetActorDetailsResult tömbben tárolja
  GetMovieOverviewData(id: any){

    this.service.GetMovieOverview(id).subscribe((result)=>{
      console.log(result,'getmovieoverview#');
      this.GetMovieOverviewResult =  result;

    });

    

  }

  //Ugyanaz mint GetMovieOverviewData
  GetMovieCastData(id:any)
  {
    this.service.GetMovieCast(id).subscribe((result)=>{
      console.log(result,'movieCast#');
      this.GetMovieCastResult = result.cast;
    });
  }

  //Ugyanaz mint GetMovieOverviewData
  GetRecomendMoviesData(id: any) {
    this.service.GetRecomendMovies(id).subscribe((result) => {
      console.log(result,'recomendmovies#');
      this.GetRecomendMoviesResult = result.results;
    });
  }

  //Ugyanaz mint GetMovieOverviewData
  GetSimilarMoviesData(id: any) {
    this.service.GetSimilarMovies(id).subscribe((result) => {
      console.log(result,'similarmovies#');
      this.GetSimilarMoviesResult = result.results;
    });
  }


}
