import { Component, OnInit } from '@angular/core';
import {FormControl,FormGroup} from '@angular/forms';
import { SeriesServiceService } from '../../service/series-service.service';

@Component({
  selector: 'app-series',
  templateUrl: './series.component.html',
  styleUrl: './series.component.css'
})
export class SeriesComponent implements OnInit{

  // Dependency injection segítségével injektáljuk a SeriesServiceService osztályt.
  constructor(private service: SeriesServiceService) {
    
  }

  // Deklaráljuk a különböző sorozatok eredményeit tartalmazó tömböket.
  ComedySeriesResult: any=[]
  TopRatedSeriesResult: any=[]
  PopularSeriesResult: any=[]
  UpcomingSeriesResult: any=[]
  HistorySeriesResult: any=[]
  CrimeSeriesResult: any=[]
  ActionSeriesResult: any=[]
  SciFiSeriesResult: any=[]

  // A komponens inicializációjakor meghívott ngOnInit metódus.
  // Az ngOnInit metódus meghívja a különböző adatlekérő metódusokat
  // a különböző típusú filmek számára.
  ngOnInit(): void {
    this.ComedySeriesData();
    this.UpcomingSeriesData();
    this.TopRatedSeriesData();
    this.PopularSeriesData();
    this.HistorySeriesData();
    this.CrimeSeriesData();
    this.ActionSeriesData();
    this.SciFiSeriesData();
  }

  // A keresési eredményeket tároló változó.
  searchResult:any;
  
  // A keresési űrlapot reprezentáló FormGroup objektum.
  // Egyetlen vezérlővel rendelkező FormGroup, ami egy beviteli mezőt tartalmaz a sorozatok kereséséhez.
  searchForm = new FormGroup({
    'seriesName':new FormControl(null)
  });


  // Az űrlap elküldéséért felelős metódus. A keresési űrlap értékének logolása.
  // A keresési szolgáltatás meghívása a keresett filmekkel. A keresési eredmények logolása.
  // A keresési eredmények mentése a searchResult változóba.
  submitForm()
  {
      console.log(this.searchForm.value,'searchform#');
      this.service.GetSearchSeries(this.searchForm.value).subscribe((result)=>{
          console.log(result,'searchseries##');
          this.searchResult = result.results;
      });
  }

  //Hamarosan érkező sorozatok lekérése
  // Először hívja a szolgáltatás `GetUpcomingMovies` metódusát
  //Kiírja a result-ot a konzolra a upcomingmoviesresult# kulcs segítségével
  // A kapott adatokat a UpcomingMoviesResult tömbben tárolja
  UpcomingSeriesData(){

    this.service.GetOnTheAirSeries().subscribe((result)=>{
        console.log(result,'upcomingseriesresult#');
        this.UpcomingSeriesResult = result.results;

    });

  }

  //Ugyanaz mint az UpcomingSeriesData
  TopRatedSeriesData(){

    this.service.GetTopRatedSeries().subscribe((result)=>{
        console.log(result,'topratedseriesresult#');
        this.TopRatedSeriesResult = result.results;

    });

  }

  //Ugyanaz mint az UpcomingSeriesData
  PopularSeriesData(){

    this.service.GetPopularSeries().subscribe((result)=>{
        console.log(result,'popularseriesresult#');
        this.PopularSeriesResult = result.results;

    });

  }

  //Ugyanaz mint az UpcomingSeriesData, csak itt nincs logolás
  ComedySeriesData(){
    this.service.GetComedySeries().subscribe((result)=>{
        this.ComedySeriesResult = result.results;

    });

  }

  //Ugyanaz mint az UpcomingSeriesData, csak itt nincs logolás
  HistorySeriesData(){
    this.service.GetHistorySeries().subscribe((result)=>{
        this.HistorySeriesResult = result.results;

    });

  }

  //Ugyanaz mint az UpcomingSeriesData, csak itt nincs logolás
  CrimeSeriesData(){
    this.service.GetCrimeSeries().subscribe((result)=>{
        this.CrimeSeriesResult = result.results;

    });

  }

  //Ugyanaz mint az UpcomingSeriesData, csak itt nincs logolás
  ActionSeriesData(){
    this.service.GetActionSeries().subscribe((result)=>{
        this.ActionSeriesResult = result.results;

    });

  }

  //Ugyanaz mint az UpcomingSeriesData, csak itt nincs logolás
  SciFiSeriesData(){
    this.service.GetSciFiSeries().subscribe((result)=>{
        this.SciFiSeriesResult = result.results;

    });

  }





}
