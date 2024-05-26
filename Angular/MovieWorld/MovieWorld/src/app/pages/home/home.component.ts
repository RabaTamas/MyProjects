import { Component, OnInit } from '@angular/core';
import { ApiServiceService } from '../../service/api-service.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})

export class HomeComponent implements OnInit {

  // Az ApiServiceService szolgáltatás injektálása a konstruktorba
  constructor(private service:ApiServiceService){}
  
  // Tömbök, amelyek tárolják a különböző adatokat
  TrendingResult: any=[]
  TrendingMoviesResult: any=[]
  TrendingSeriesResult: any=[]
  
  ngOnInit(): void {
    // Az oldal betöltésekor lefuttatja a következő metódusokat
    this.TrendingData();
    this.TrendingMoivesData();
    this.TrendingSeriesData();
  }
  

  // Trending tartalom lekérése
  // Először hívja a szolgáltatás `trendingApiData` metódusát, ami a trending sorozatokat és filmeket kéri le
  //Kiírja a result-ot a konzolra a trendingresult# kulcs segítségével
  // A kapott adatokat a TrendingResult tömbben tárolja
  TrendingData(){
    this.service.trendingApiData().subscribe((result)=>{
        console.log(result,'trendingresult#');
        this.TrendingResult = result.results;

    });

  }


  // Trending filmek lekérése
  // Hívja a szolgáltatás `trendingmoviesApiData` metódusát, ami a trending filmeket kéri le
  //Kiírja a result-ot a konzolra a trendingmoviesresult# kulcs segítségével
  // A kapott adatokat a TrendingMoviesResult tömbben tárolja
  TrendingMoivesData(){

    this.service.trendingmoviesApiData().subscribe((result)=>{
        console.log(result,'trendingmoviesresult#');
        this.TrendingMoviesResult = result.results;

    });

  }

  // Trending sorozatok adatok lekérése
  // Hívja a szolgáltatás `trendingseriesApiData` metódusát, ami a trending sorozatokat kéri le
  //Kiírja a result-ot a konzolra a trendingseriesresult# kulcs segítségével
  // A kapott adatokat a TrendingSeriesResult tömbben tárolja
  TrendingSeriesData(){

    this.service.trendingseriesApiData().subscribe((result)=>{
        console.log(result,'trendingseriesresult#');
        this.TrendingSeriesResult = result.results;

    });

  }


}
