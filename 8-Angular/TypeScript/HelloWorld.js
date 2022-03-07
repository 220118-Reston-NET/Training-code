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
let num1;
//Union type in TS
let t1;
t1 = 10;
t1 = 29.4;
t1 = "hello";
t1 = "world";
//Arrays
let arry1;
arry1 = [233, 12, 10];
arry1.push(29); // You can add new elements into arrays in TS/JS unlike C#
let arry2;
arry2 = [192, 28.34, true, false];
let arry3;
arry3 = ["awei", "hello"];
arry3 = 1298;
//Tuple - It is an array but has a fixed position of datatypes
let tul;
tul = [5, "hello", true, 10.4];
console.log(tul);
tul.push(12);
console.log(tul);
//Enums
var Engine;
(function (Engine) {
    Engine[Engine["Off"] = 0] = "Off";
    Engine[Engine["Idle"] = 1] = "Idle";
    Engine[Engine["Accel"] = 2] = "Accel";
})(Engine || (Engine = {}));
;
let engineState = Engine.Accel;
if (engineState == Engine.Accel) {
    console.log("The car is running");
}
//====================== Functions ======================
function myFunc(params1, params2) {
    console.log(`${params1} ${params2}`);
}
myFunc("Hello", "World");
function myFunc2(params) {
    return params.concat(" myFunc2!");
}
console.log(myFunc2("Test"));
//====================== Classes and Objects ======================
class Dog {
    constructor(color, name, numOfLegs, isAlive) {
        this.color = color;
        this.name = name;
        this.numOfLegs = numOfLegs;
        this.isAlive = isAlive;
    }
    run(speed) {
        return "Run for your lives! The spider is going " + speed + "mph";
    }
    // giveColor()
    // {
    //     console.log("The dog's color is " + this.color);
    // }
    //Method overloading
    giveColor(p_color) {
        if (typeof p_color == "undefined") {
            console.log("The dog's color is " + this.color);
        }
        else {
            console.log("The dog's color is " + p_color);
        }
    }
}
let dog1 = new Dog("black", "Minnie", 4, true);
dog1.giveColor("yellow");
let ani;
ani =
    {
        numOfLegs: 8,
        isAlive: false,
        //speed: 20,
        // speak()
        // {
        //     return "Evil sounding noise";
        // },
        run(speed) {
            this.speed = speed;
            return "Run for your lives! The spider is going " + this.speed + "mph";
        }
    };
//Arrow Notation
let arrNot = (para1) => console.log(para1);
arrNot("Hello World");
let arrNot2 = (para1) => {
    console.log(para1);
    console.log("More Line of Code");
};
