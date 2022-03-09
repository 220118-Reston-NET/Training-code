//You want your models to be similar (if not the same) as the models in your backend to help map things correctly and have the angular compiler help you out
export interface Pokemon
{
    pokeId:number;
    attack:number;
    defense:number;
    health:number;
    speed:number;
    type:string;
    rating:number;
    name:string;
    level:number;

    // sprites: 
    // {
    //     front_default:string;
    // }
}