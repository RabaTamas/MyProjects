import { Component, OnInit } from '@angular/core';
import { ApiServiceService } from '../../service/api-service.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-actor-deatils',
  templateUrl: './actor-deatils.component.html',
  styleUrl: './actor-deatils.component.css'
})
export class ActorDeatilsComponent implements OnInit {

  constructor(private service: ApiServiceService, private router: ActivatedRoute) {}

  // Változók az eredmények tárolására
  GetActorDetailsResult: any;
  GetActorMovieCreditsResult: any;
  GetActorSeriesCreditsResult: any;

  // Feliratkozás az útvonal paraméterek változásaira
  // Az aktuális 'id' paraméter elmentése
  ngOnInit(): void {
   
    this.router.params.subscribe(params => {
      let Id = params['id'];
      console.log(Id,'id#');
      
      this.GetActorDetailsData(Id);
      this.GetActorMovieCreditsData(Id);
      this.GetActorSeriesCreditsData(Id);
    }); 
  }

  // Színész részletes adatainak lekérése és tárolása
  // Hívja a szolgáltatás `GetActorDeails` metódusát aminek átadja az id
  //Kiírja a result-ot a konzolra a getactordetails# kulcs segítségével
  // A kapott adatokat a GetActorDetailsResult tömbben tárolja
  GetActorDetailsData(id: any){
    this.service.GetActorDetails(id).subscribe((result)=>{
      console.log(result,'getactordetails#');
      this.GetActorDetailsResult = result;
    });
  }

  //Ugyanaz mint GetActorDetailsData
  GetActorMovieCreditsData(id: any) {
    this.service.GetActorMovieCredits(id).subscribe((result)=>{
      console.log(result,'moviecredits#');
      this.GetActorMovieCreditsResult = result.cast;
    });
  }

  //Ugyanaz mint GetActorDetailsData
  GetActorSeriesCreditsData(id: any) {
    this.service.GetActorSeriesCredits(id).subscribe((result)=>{
      console.log(result,'seriescredits#');
      this.GetActorSeriesCreditsResult = result.cast;
    });
  }
}