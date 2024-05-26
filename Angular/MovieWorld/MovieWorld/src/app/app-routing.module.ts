import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { MoviesComponent } from './pages/movies/movies.component';
import { SeriesComponent } from './pages/series/series.component';
import { MovieDeatilsComponent } from './pages/movie-deatils/movie-deatils.component';
import { ActorDeatilsComponent } from './pages/actor-deatils/actor-deatils.component';
import { SeriesDeatilsComponent } from './pages/tvshow-deatils/series-deatils.component';

const routes: Routes = [
  {path:'',component:HomeComponent},
  {path:'movies',component:MoviesComponent},
  {path:'series',component:SeriesComponent},
  {path:'movie/:id', component:MovieDeatilsComponent},
  {path:'actor/:id', component:ActorDeatilsComponent},
  {path:'series/:id', component:SeriesDeatilsComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
