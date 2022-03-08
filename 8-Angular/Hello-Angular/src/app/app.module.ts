import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from "@angular/common/http";

import { AppComponent } from './app.component';
import { PokemonListComponent } from './pokemon-list/pokemon-list.component';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { FormsModule } from '@angular/forms';
import { PokeProfileComponent } from './poke-profile/poke-profile.component';
import { RouterModule } from '@angular/router';
import { NotFoundComponent } from './not-found/not-found.component';

@NgModule({
  declarations: [ //This will hold our references to our components
    AppComponent,
    PokemonListComponent,
    NavBarComponent,
    PokeProfileComponent,
    NotFoundComponent
  ],
  imports: [ //This will hold our references to modules inside our node_module folder
    BrowserModule,
    HttpClientModule,
    FormsModule,
    
    RouterModule.forRoot([
      {path: "pokeList", component: PokemonListComponent}, //if you want the endpoint to look like website/pokeList
      {path: "profile", component: PokeProfileComponent}, //if you want the endpoint to look like website/profile
      {path: "", component:PokemonListComponent}, //Default component you want to show
      {path: "**", component:NotFoundComponent} //Wildcard for any endpoint that doesn't exist
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
