# HTML
* Hypertext Markup Language
* Another markup language so that means it is just telling the computer what to do and not compiling it into machine code
* Very similar to xml (our .csproj files) but HTML is used to define the structure of our webpages
* Our browsers are essentially experts at reading this files and interpreting it to display something on the browser
* We are currently on version HTML 5

## HTML elements
* so like XML, it uses tags to define what something should be displayed and instead of calling them "tags" we also call them HTML elements
* They are, for the most part, a basic graphical unit of something you want to display/structure on your web page

## HTML attributes
* They are used to provide extra information that the tag can use
* Ex: img tag using src attribute to find a specific image to display

## Web Accessiblity
* In the past only a computer has access to a website and so usually websites are created for a pc only. That's not the case anymore.
* So Web accessiblity is configuring your website in a way so it is also readable beyond pc users such as phone, tablets, gaming consoles, etc. 
* This is usually done by manipulating CSS 

# CSS
* Cascading Style Sheets
    * Cascading is in the name because it uses a cascading algorithm to determine what style it should apple (more on this later)
* A way to stop making your website looking like it came from the 90s

## CSS Selectors
* Before applying styles everywhere, we need a way to select specific or group of HTMl elements first so we give them their own type of look
* There are three basic fundamental selectors we should keep in mind:
1. Element selector - When you want to select multiple elements of the same tag
2. Class selector - When you want to select multiple elements of differing tag by using the class attribute
3. Id selector - When you want to select one (mostly) or a couple elements using the id attribute

## Different ways to include CSS
* Inline CSS
    * Applies CSS to a single element
    * It uses the style attribute
    * Has the highest priority
* Internal CSS
    * Applies CSS by using the style tag inside of a HTML doc
    * Used to apply multiple css to multiple elements
    * Second priority
* External CSS
    * Creating an external .css file to apply css to multiple HTML docs (you can just apply it to one HTML but that kind of defeats the purpose of using an external css)
    * HTML doc must use the link tag to reference the external css
    * Used to apply multiple css to multiple elements in multiple HTML docs
        * So useful to create a universal theme of your website
    * Least priority

# Responsive Web Design
* Making your elements not have rigid in size but changes its size based on the viewport
    * Viewport is just how big the window of the browser is (small for phones, big for computers)
* Useful to accomodate for every devices out there that might access your website
* We will leverage Bootstrap libraries for pre-made css files to implement this design
    * Click [here](https://getbootstrap.com/docs/5.1/getting-started/introduction/) for Bootstrap documentation

# JavaScript
* Best way to make your website dynamically changed
* It is both a functional language and object-oriented programming language (ever since ES6)
    * Functional language just means that it uses a lot of functions and you can also use them as variables, parameters inside of other functions and it makes things look... very complicated
    * You can think of functions as methods in C# just with a different name and doesn't need a class attached to it to make one
* Key difference with C# is that it is **loosely typed**
    * Meaning every variable you create can hold any datatype and will have no issues switching between datatypes (Remember cannot implicity convert blah blah exception on C#? That's gone in JavaScript)
* Interesting enough JavaScript is both compiled and interpreted
    * It used to be just interpreted (like SQL) but with introduction to more modern tools that uses JavaScript they improved it to also be compiled
    * Essentially, if a function keeps getting called multiple times, it will compile that code into an optimized native machine code to be more efficient 
* We are currently in EcmaScript 6 version
    * It introduced many wonderful things but for the most part confused a ton of people who use JS often in the past since this is when classes are introduced.

# Datatypes
* QC might ask a list of datatypes from JS so here are a couple most used ones
* Numbers
* Boolean
* Strings
* Objects
* Null - Lack of value meaning this variable doesn't have any information at the moment
* Undefined - no value was set meaning you just created a variable and didn't set it with any value

# Prototype
* It is like a field in C# in a form of a key-value pair
* Every function (and other things) have prototypes and you can add prototypes as well
## Prototypal Inheritance
* The technical name that says you can inherit other prototypes so you have code re-usability

# Classes
* As you know, templates for creating objects
* Didn't use to exist which made things weird and divided some communities in JS
    * Essentially some people say to never use it because it's inefficient or error prone
    * Some people say to use it because it makes looking at your code easier to read (you should see example of how JS used to implement class-like things using just functions (spoiler alert: it looks gross))
* Has most of the OOP pillars we discussed and implements them easily except abstraction

# JS HTML DOM
* Allows JavaScript to specifically pick certain elements in the HTML and change/manipulate them somehow based on whatever function you created
* This is what makes JS a powerful tool to making your html page dynamically change based on whatever the user is doing

