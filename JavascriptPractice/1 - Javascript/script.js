var myName = 'Urooj Akram'
console.log(myName);
console.log(typeof myName);
console.log(9 - '2') //bug
console.log(9 + '2')

var string = null;
console.log(string);
console.log(typeof string); //bug
var standBy;
console.log(standBy); 
console.log(typeof standBy); //bug


// NAN 
var number = 948349384;
var myName = "urooj";
console.log(isNaN(number));
console.log(isNaN(myName));

console.log('------------------------');

console.log(NaN === NaN);
console.log(Number.NaN === NaN); // Nan property of global object
console.log(isNaN(NaN));
console.log(isNaN(Number.NaN));
console.log(Number.isNaN(NaN));

console.log('------------------------');
console.log(3**3);

console.log('--Swap without using third var--');
b = 5;
a=10;
a= a+b; // 15
b = a-b; // 5
a = a-b //10
console.log("a is ",a);
console.log("b is ",b);


console.log('------- == vs === -------');

console.log(3 == '3');
console.log(3 === '3');

console.log('----------if leap year or not------------');
var year= 2020;

if(year % 4 === 0){
 if(year % 100 === 0){
 if(year % 400 === 0)
 {
    console.log(year + " is a leap year ");
 }
 else
 {
    console.log(year + " is not a leap year");
}
}
else
{
    console.log(year + " is a leap year");
}
}
else 
{
    console.log(year + " is not a leap year");
}

console.log('----------truthy-and-falsy-----------');
// Total 5 falsy values in javascript. 0,"",undefined,null,NaN,false

console.log(0);
console.log("");
console.log(undefined);
console.log(null);
console.log(NaN);
console.log(false);
console.log("\n")
if(0)
{
    console.log("lost");
}
else
{
    console.log("won");
}

console.log('---ternay operator-');
var num =10;
console.log((num === '10')? true : false);
console.log('--switch--');
 let dayOfWeek = 3;
 switch(dayOfWeek)
 {
    case 1:
        console.log('Monday');
        break;
    case 2:
        console.log('Tuesday');
        break;
    case 3:
        console.log('Wednesday');
       break;
    default:
        console.log("Invalid Option");
 }


 console.log('---Functions-----');
 function sum(a,b)
 {
    sum=0;
    return sum = a+b;
 }

 console.log(sum(5,10));

 console.log('-----Anonymous Ftn-----');
//provides encapsulation, immediately invoked function expressions IIFE. creating isolated scopes
 var sum = function(a,b)
 {
    sum=0;
    return sum = a+b;
 }
var result = sum(5,10);
 console.log(sum);


 console.log('---ECMA Script--');
 //let vs const
 // var => function scope
 // let and const => block scope
 var scopeOfVar = function()
 {
    if(true) 
    {
        var x = 10;
       // console.log(x);
    }
    console.log(`Using var : ${x}`);
 }
 var scopeOfLet = function()
 {
    if(true) 
    {
        let y = 10;
        console.log(`Using Const :${y}`);
    }
   // console.log('Using Let',u);
 }
 var scopeOfConst = function()
 {
    if(true) 
    {
        const z = 10;
        console.log(`Using const : ${z}`);
    }
    //console.log('Using Const',z);
 }

scopeOfLet();
scopeOfVar();
scopeOfConst();

console.log('---default parameter---');
var defaultParameter = function(a, b=5)
{
    return a*b;
}
console.log(defaultParameter(6));


console.log('----Arrow Functions------');
const  sum1 =() =>{
    let a = 5, b=3
    return a+b;
}
console.log(sum1());

console.log('-------Arrays in JS--------');
var fruits = [];
fruits.push("banana", "apple", "peach");
console.log(fruits.length);
fruits[5] = "mango";
console.log(fruits[5]);
console.log(Object.keys(fruits));
console.log (fruits.length);
fruits.length = 10;
console.log(fruits);
console.log(Object.keys(fruits));
console.log(Object.values(fruits));
console.log(fruits.length);
console.log(fruits[8]);

fruits.length = 2;
console.log(Object.keys(fruits));
console.log(Object.values(fruits));
console.log(fruits.length);

var result = fruits.find(fruit => fruit.length > 0);
console.log(result);
fruits.push("Orange")
console.log(fruits);

// unshift -- adds one or more element to the beginning
fruits.unshift('apple');
console.log(fruits);

// pop -- removes the last element from an array
fruits.pop();
console.log(fruits);

// splice -- array manipulation
fruits.splice(2, 1);
console.log(fruits);
const months = ['Jan', 'march', 'feb', 'oct'];
const newMonth = months.splice(3,0,"sep");
console.log(months);

//empty array in splice
fruits.splice(0,0);
console.log(fruits);

//updating array using splice without delete
fruits.splice(2,2,'Apple')

//updating array using splice with delete
fruits.splice(2,0,'Apple')
console.log(fruits);

// shift -- removes the first element from an array
fruits.shift();
console.log(fruits);

// search and update using index of and splice

fruits.splice(fruits.indexOf('Apple'),1,'Orange');
console.log(fruits);

//map 
var fruits = ["banana", "apple", "peach"];
var newFruits = fruits.map(fruit => fruit.length);
console.log(newFruits);

console.log('-------map function in JS-------');
var array1 = [1, 2, 3, 4, 5];
let newArr = array1.map((currEm, index, arr) =>
{
    return `Index no = ${index} and the values is ${currEm} belong to ${arr} \n`;
})
console.log(newArr);

console.log('------MAP EXAMPLES-------');
let arr  = [25,33,23,65,32];
let arrSqr  = arr.map((currEm) =>{
    return Math.sqrt(currEm);
} )
console.log(arrSqr);

console.log('----Map with FILTER------');
let arr2 = arr.map((currEm) => {
    return currEm * 2;
}) .filter((currEm) => {
        return currEm > 30;
})
console.log(arr2);

//reduce -- flatten an array 3D-2D to single dim array
const arr3 = [[1], [2, 3], [4]];
let arr4 = arr3.reduce((acc, curr) => {
    return acc.concat(curr);
})
console.log('Before Reduce method : ', arr3)
console.log('After Reduce method : ', arr4);

//reduce -- using accumulator

var fruits = ["banana", "apple", "peach"];
var newFruits = fruits.reduce((acc, curr) => {
    return acc + curr;
});
console.log(newFruits);

//filter

var fruits = ["banana", "apple", "peach"];
var newFruits = fruits.filter(fruit => fruit.length > 3);
console.log(newFruits);

//sort     

var fruits = ["banana", "apple", "peach"];
var newFruits = fruits.sort();
console.log(newFruits);

//reverse

var fruits = ["banana", "apple", "peach"];
var newFruits = fruits.reverse();
console.log(newFruits);

console.log('-------Object in JS-------');
var person = {
    name: "Urooj",
    age: 25,
    city: "Islamabad"
}

console.log(Object.keys(person));
console.log(Object.values(person));
console.log(Object.getOwnPropertyNames(person));

console.log('---- Strings in JS ----');
let name = "urooj";
let name2 = new String("urooj");
console.log(name);
console.log(name === name2);
console.log(name === name2.valueOf());

// using search method
console.log(name.search("o"));
console.log(name2.search("o"));


//using slice
console.log(name.slice(0,3));
