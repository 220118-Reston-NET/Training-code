import { Component, OnInit } from "@angular/core";
import { Pokemon } from "../models/pokemon.model";
import { PokeService } from "../services/poke.service";

@Component({
    selector:'app-pokemon-list',
    templateUrl: './pokemon-list.component.html',
    styleUrls: ['./pokemon-list.component.css']
})
export class PokemonListComponent implements OnInit {
    title:string = "List of Pokemon";
    src1:string = "https://upload.wikimedia.org/wikipedia/commons/6/6a/Door_Tree_1898.png";
    isVisible:boolean = true;
    isRatingVisible:boolean = false;

    filteredName:string = "";

    listOfPokemon:Pokemon[];
    filteredListOfPoke:Pokemon[];

    constructor(private pokeServ: PokeService){
        this.listOfPokemon = [];
        this.filteredListOfPoke = [];

    }
    
    ngOnInit(): void {
        //getAllPokemon() methods gives an observable that has a subscribe method to start the http request and then handle x amount of responses
        this.pokeServ.getAllPokemon().subscribe(result => {
            //The result of a response is then stored in our listOfPokemon property
            console.log(result);
            result.forEach(poke => poke.rating = this.getRandomInt(5)); //Adds rating to pokemon since Db doesn't have it
    
            this.listOfPokemon = result;
            this.filteredListOfPoke = result;
        });
    }


    getRandomInt(max:number) {
        return Math.floor(Math.random() * max);
    }
      

    changeTitle()
    {
        this.title = "title has been changed!";
        this.src1 = "https://upload.wikimedia.org/wikipedia/commons/5/56/Hudson_Yards_from_Hudson_Commons_%2895131p%29.jpg";
        // this.listOfPokemon.push({base_experience:64, id:1,name:'bulbasaur',sprites:{front_default:'https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/1.png'}});
    }

    changeVisible()
    {
        this.isVisible = !this.isVisible;
    }

    public set FilteredName(s1:string)
    {
        this.filteredName = s1;
        /*
            if input box for the search card is empty then it will be false
            if it is not empty, it will be true so perform the filter method
        */
        this.filteredListOfPoke = this.filteredName ? this.performFilter(this.filteredName) : this.listOfPokemon;
    }

    /*
        This filter will give a filtered array of Pokemon based on what the user gave
        filter based on names
        It will not care about case-sensitive
    */
    performFilter(filter:string):Pokemon[]
    {
        filter = filter.toLowerCase();

        let tempListOfPoke:Pokemon[]

        /*
            -filter method from the array object will return a new array based on some condition I set
            "Bulbsarous".indexOf("b") == 1
            "Hello".indexOf("aowlefjio") == -1 
        */
        tempListOfPoke = this.listOfPokemon.filter((pokemon:Pokemon) => pokemon.name.toLowerCase().indexOf(filter) != -1);

        return tempListOfPoke;
    }

    starEventWasTriggered(num1:number)
    {
        console.log(num1);
        this.isRatingVisible = !this.isRatingVisible;
    }
}