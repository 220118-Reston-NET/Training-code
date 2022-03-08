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
    HttpClientModule, //Required module to include Http requests
    FormsModule, //Required to include two-way data binding
    
    //Required module to start routing
    RouterModule.forRoot([
      //Path property indicates what endpoint the user needs to specify to go to that component
      //component property indicates what component to display if the user goes to that endpoing
      {path: "pokeList", component: PokemonListComponent}, //if you want the endpoint to look like website/pokeList
      {path: "profile", component: PokeProfileComponent}, //if you want the endpoint to look like website/profile
      {path: "", component:PokemonListComponent}, //Default component you want to show
      {path: "**", component:NotFoundComponent} //Wildcard for any endpoint that doesn't exist
    ])
  ],
  providers: [], //If you don't use @Injector decorator, you would have to specify your services here
  bootstrap: [AppComponent] //This is the first loaded component/code in the Angular app
})
export class AppModule { }
