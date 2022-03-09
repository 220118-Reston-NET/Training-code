import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from "@angular/common/http";

import { AppComponent } from './app.component';
import { PokemonListComponent } from './pokemon-list/pokemon-list.component';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { PokeProfileComponent } from './poke-profile/poke-profile.component';
import { RouterModule } from '@angular/router';
import { NotFoundComponent } from './not-found/not-found.component';
import { StarComponent } from './star/star.component';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { AddPokeComponent } from './add-poke/add-poke.component';

@NgModule({
  declarations: [ //This will hold our references to our components
    AppComponent,
    PokemonListComponent,
    NavBarComponent,
    PokeProfileComponent,
    NotFoundComponent,
    StarComponent,
    AddPokeComponent
  ],
  imports: [ //This will hold our references to modules inside our node_module folder
    BrowserModule,
    HttpClientModule, //Required module to include Http requests
    FormsModule, //Required to include two-way data binding\
    FontAwesomeModule,
    ReactiveFormsModule,
    
    //Required module to start routing
    RouterModule.forRoot([
      //Path property indicates what endpoint the user needs to specify to go to that component
      //component property indicates what component to display if the user goes to that endpoing
      {path: "pokeList", component: PokemonListComponent}, //if you want the endpoint to look like website/pokeList
      {path: "profile/:pokename", component: PokeProfileComponent}, //if you want the endpoint to look like website/profile
      {path: "pokemon", component:AddPokeComponent},
      {path: "", component:PokemonListComponent}, //Default component you want to show
      {path: "**", component:NotFoundComponent} //Wildcard for any endpoint that doesn't exist
    ]), FontAwesomeModule
  ],
  providers: [], //If you don't use @Injector decorator, you would have to specify your services here
  bootstrap: [AppComponent] //This is the first loaded component/code in the Angular app
})
export class AppModule { }
