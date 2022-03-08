import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Pokemon } from '../models/pokemon.model';

@Injectable({
  providedIn: 'root'
})
export class PokeService {

  constructor(private http:HttpClient) { }

  getAllPokemon() : Observable<Pokemon[]>
  {
    return this.http.get<Pokemon[]>("https://pokedemo.azurewebsites.net/api/Pokemon/GetAll");
  }

}
