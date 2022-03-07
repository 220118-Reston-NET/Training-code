/*
    command tsc [filename] - will transpile the TS into JS
    command tsc [filename] -w - will transpile the TS into JS every time there is a change in the TS file
*/

//============================= Variables =============================
console.log("==== Variables ====");

//String Variables
let s1 = "hello";
// s1 = 10; this will work in JS after transpilation due to JS being loosely typed

console.log(`s1 is typeof ${typeof s1}`);

//Any - it is the default type of a declared variable if no type was implicitly or explicitly given
let a1;
a1 = "string";
a1 = 10;
a1 = null;
a1 = true;
console.log(`a1 is type of ${typeof a1}`);

//Null or Undefined
let uni1;
let nul1 = null;
console.log(`uni1: ${uni1} nul1: ${nul1}`);

//Enforcing type in TS
let num1:number;

//Union type in TS
let t1:number | string;
t1 = 10;
t1 = 29.4;
t1 = "hello";
t1 = "world";

//Arrays
let arry1: number[];
arry1 = [233, 12, 10];
arry1.push(29); // You can add new elements into arrays in TS/JS unlike C#

let arry2: (number | boolean)[];
arry2 = [192, 28.34, true, false];

let arry3: string[] | number;
arry3 = ["awei", "hello"];
arry3 = 1298;

//Tuple - It is an array but has a fixed position of datatypes
let tul: [number, string, boolean, number];
tul = [5, "hello", true, 10.4];
console.log(tul);
tul.push(12);
console.log(tul);

//Enums
enum Engine
{
    Off,
    Idle,
    Accel
};

let engineState = Engine.Accel;

if(engineState == Engine.Accel)
{
    console.log("The car is running");
}

//====================== Functions ======================
function myFunc(params1:string, params2:string) {
    console.log(`${params1} ${params2}`);
}

myFunc("Hello", "World");

function myFunc2(params:string) : string {
    return params.concat(" myFunc2!");
}

console.log(myFunc2("Test"));

//====================== Classes and Objects ======================
class Dog implements Animal {
    public color:string;
    private name:string;
    isAlive: boolean;
    numOfLegs: number;

    constructor(color:string, name:string, numOfLegs: number, isAlive: boolean) {
        this.color = color;
        this.name = name;
        this.numOfLegs = numOfLegs;
        this.isAlive = isAlive;
    }
    
    run(speed?:number)
    {
        return "Run for your lives! The spider is going "+speed+"mph";
    }

    // giveColor()
    // {
    //     console.log("The dog's color is " + this.color);
    // }

    //Method overloading
    giveColor(p_color?:string)
    {
        if (typeof p_color == "undefined") 
        {
            console.log("The dog's color is " + this.color);
        }
        else
        {
            console.log("The dog's color is " + p_color);
        }
    }
}  

let dog1 = new Dog("black", "Minnie", 4, true);
dog1.giveColor("yellow");

//Interfaces in TS is just a scaffold that an object needs to follow when you are trying to create an object out of an interface
interface Animal
{
    numOfLegs: number;
    isAlive: boolean;
    speed?: number;

    speak?:() => string; //function that will return a string
    run:(speed?:number) => string; //function that takes in a parameter and returns a string
}

let ani:Animal;

ani = 
{
    numOfLegs: 8,
    isAlive: false,
    //speed: 20,

    // speak()
    // {
    //     return "Evil sounding noise";
    // },

    run(speed?:number)
    {
        this.speed = speed;
        return "Run for your lives! The spider is going "+this.speed+"mph";
    }
}

//Arrow Notation
let arrNot = (para1:string) => console.log(para1);
arrNot("Hello World");

let arrNot2 = (para1:string) => 
{
    console.log(para1);
    console.log("More Line of Code");
}