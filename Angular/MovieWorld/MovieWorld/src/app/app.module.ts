import { NgModule } from '@angular/core';
import { BrowserModule, provideClientHydration } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './pages/home/home.component';
import { MoviesComponent } from './pages/movies/movies.component';
import { SeriesComponent } from './pages/series/series.component';
import {HttpClientModule} from '@angular/common/http'
import { ApiServiceService } from './service/api-service.service';
import { MovieDeatilsComponent } from './pages/movie-deatils/movie-deatils.component';
import { ActorDeatilsComponent } from './pages/actor-deatils/actor-deatils.component';
import { SeriesDeatilsComponent } from './pages/tvshow-deatils/series-deatils.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MoviesServiceService } from './service/movies-service.service';
import { SeriesServiceService } from './service/series-service.service';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    MoviesComponent,
    SeriesComponent,
    MovieDeatilsComponent,
    ActorDeatilsComponent,
    SeriesDeatilsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule
  ],
  providers: [
    provideClientHydration(),
    ApiServiceService,
    MoviesServiceService,
    SeriesServiceService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
