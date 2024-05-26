import { Component, OnInit } from '@angular/core';
import { ApiServiceService } from '../../service/api-service.service';
import { ActivatedRoute } from '@angular/router';
import { SeriesServiceService } from '../../service/series-service.service';

@Component({
  selector: 'app-series-deatils',
  templateUrl: './series-deatils.component.html',
  styleUrls: ['./series-deatils.component.css'] 
})
export class SeriesDeatilsComponent implements OnInit {
  GetSeriesOverviewResult: any;
  GetSeriesCastResult: any;
  GetSeriesEpisodesResult: any[] = [];
  selectedSeason: number | null = null;
  seasons: number[] = [];
  
  // Injektálja a SeriesServiceService és ActivatedRoute szolgáltatásokat az osztályba.
  constructor(private service: SeriesServiceService, private router: ActivatedRoute) {}

  // Feliratkozik a router.params eseményre, amely a beágyazott útválasztó paraméterek változásait jelzi.
  // Lekéri a sorozat azonosítóját és a szezonszámot a paraméterekből.
  // Ha van megadva szezonszám, akkor lekéri az adott szezon epizódjait is.
  // Lekéri a sorozat részeleteit és a szereplőit.
  ngOnInit(): void {
    this.router.params.subscribe(params => {
      let Id = params['id'];
      let SeasonNumber = params['season_number'];

      console.log(Id, 'id#');
      console.log(SeasonNumber, 'seasonnumber#');

      this.GetSeriesOverviewData(Id);
      this.GetSeriesCastData(Id);

      if (SeasonNumber !== undefined) {
        this.GetSeriesEpisodesData(Id, SeasonNumber);
      }
    });
  }
  
  //A megadott azonosítójú sorozat részletes adatainak lekérése és tárolása
  // Hívja a szolgáltatás `GetSeriesOverview` metódusát aminek átadja az id
  //Kiírja a result-ot a konzolra a getseriesoverview# kulcs segítségével
  // A kapott adatokat a GetSeriesOverviewResult tömbben tárolja
  //Meghívja az initSeason függvényt
  GetSeriesOverviewData(id: any) {
    this.service.GetSeriesOverview(id).subscribe((result) => {
      console.log(result, 'getseriesoverview#');
      this.GetSeriesOverviewResult = result;
      this.initSeasons();
    });
  }

  //Ugyanaz mint GetSeriesOverviewData, csak nem hívjameg az initSeasons-t
  GetSeriesCastData(id: any) {
    this.service.GetSeriesCast(id).subscribe((result) => {
      console.log(result, 'seriesCast#');
      this.GetSeriesCastResult = result.cast;
    });
  }

  //Ugyanaz mint GetSeriesOverviewData, csak nem hívjameg az initSeasons-t
  // Hívja a szolgáltatás `GetSeriesSeasonDetails` metódusát aminek átadja az sorozat id-t és az évad számát
  GetSeriesEpisodesData(id: any, seasonNumber: any){
    this.service.GetSeriesSeasonDetails(id, seasonNumber).subscribe((result)=>{
      console.log(result,'getseriesseason#');
      this.GetSeriesEpisodesResult =  result.episodes;
    });
  }

  
  // Az initSeasons függvény inicializálja a szezonokat a sorozat összes szezonjával
  // Létrehozza a 'seasons' tömböt, amely a szezonok sorszámait tartalmazza 1-től a sorozat összes szezonjáig
  // Beállítja a 'selectedSeason' változót az első szezonra
  // Meghívja a GetSeriesEpisodesData függvényt az első szezon epizódjainak lekérésére
  initSeasons() {
    this.seasons = Array.from({length: this.GetSeriesOverviewResult.number_of_seasons}, (_, i) => i + 1);
    this.selectedSeason = 1;
    this.GetSeriesEpisodesData(this.router.snapshot.params['id'], this.selectedSeason);
  }

  // Az onSeasonChange függvény reagál a szezonválasztó változásaira
  // A paraméterként kapott objektumból kinyeri a kiválasztott szezon sorszámát
  // Beállítja a 'selectedSeason' változót a kiválasztott szezon sorszámára
  // Meghívja a GetSeriesEpisodesData függvényt a kiválasztott szezon epizódjainak lekérésére
  onSeasonChange(event: any) {
    const selectedSeasonNumber = event.target.value;
    this.selectedSeason = selectedSeasonNumber;
    if (this.selectedSeason) {
      this.GetSeriesEpisodesData(this.router.snapshot.params['id'], selectedSeasonNumber);
    }
  }
}