# Node.js
* It is a free open-source JS interpreter/server environment that allows us to run JS outside of a web browser
* Platform independent
* Made from google chromium V8 engine

# NPM
* Node Package Manager
    * Included with Node.js installation
* Similar to Nuget Package Manager, it can manage our dependencies for our frontend project and also install other frontend tech packages to include in our frontend project
* It will install our packages in a folder called node_modules in our Angular application
## CLI commands
* npm install -g typescript - NPM installs typescript globally
* npm install -g @angular/cli - NPM installs Angular globally

# TypeScript
* It is an open-source language and object-oriented language developed by Microsoft
* Essentially, it made JS into a OOP language (before ECMAScript 6 was a thing)
* It is a superset of JS
    * This just means that TS has all the capabilities that JS have but more
* It is strictly-typed
## Tiny problem with TS (Transpilation required)
* Most, if not all, browsers only support JS and can't interpret a TS file inherently
* So we have  tsc cli command do a transpilation process that converts the TS language into a JS language
    * Transpilation is just the process of converting one programming langauge file into another programming langauge
## CLI commands
* Tsc -v - checks the version of TS you have
* Tsc [filepath] - transpile TS file into JS file
* Tsc [filepath] -w - will automatically transpile our TS into JS every time the file changes
* Tsc [filepath] -t es[ECMA Script Version] - will transpile the TS into JS into a specific ES version
* Tsc --init - automatically creates a tsconfig.json file

# Different types of Variables specific to TS
* Any - default value to any variable that isn't given a type and doesn't hold any value
* Void - Used for functions/methods to indicate that it will not return anything
    * Similar to void in C#
    * Do not use as a normal datatype since it is made just for methods/functions
* Never - Used for exception handling
* Union - Being able to combine more than 1 datatype
* Any datatype JS have (because TS is superset of JS)
    * String
    * Boolean
    * Array
    * Object
    * etc.

# Angular
* It is an open-source framework TS based front-end framework
* Angular first started as AngularJS (JS based framework), but in Angular 2 they switched from JS to TS
## Why switch and the changes?
* AngualrJS did not support dynamic loading of the page or server-side programming language
* Angular 2 has better support for mobile devices
* (the big change) They changed architecture design from MVC design to a **Component and Decorator** architecture design
## Single Page Application (SPA)
* Allows us to route to pre-loaded components (JS, HTML, CSS) onto the same page without reloading the window
* Allows us to navigate in the same page without refreshing the whole page
* Advantages
    * It is more mobile friendly
        * Once it is loaded, the user can still navigate through the website
        * Very useful for users with unstable internet connection
    * Caching capabilities
        * It can store information in your computer/phone/device
        * Once internet connection has been established, there is an automated process to synchronize your local data with the online data
* Disadvantages
    * Doesn't perform well with SEO (search engine optimization)
        * Because of webpack bundling
## Webpack - bundling
* Loading multiple script tags into HTML pages is inefficient as it reduces the page speed since the browser requests each script file separately. Instead, we have one big request that grabs one JS file in a single requests
* Webpack bundling is the process of **bundling** several JS files together into one JS file
* Angular automatically does webpack bundling for us

# Data Binding
* The process in where we share/project values from the components TS file to the HTML or HTML to the TS
* There are different way for data binding but we will focus on one-way and two-way data binding
* Interpolation
    * Syntax using "{{}}"
    * Can be used to reference properties inside of the TS file of that component
    * Can also be used to evalue simple mathematical operations
* Property Binding
    * Syntax using "[]"
    * It binds the attributes of a HTML element to the component's property
* Event Binding
    * Syntax using "()"
    * It binds the DOM events such as keystrokes, button clicks, etc. to a method in the component's TS class
## Two way Data Binding
* Allows us to bind data from both the component to the view and the view to the component
* It is achieved by combining both property and event binding together
* Syntax using "[()]"
* Angular uses ngModel directive to achive two-way data binding
* Note: you must import FormsModule package in app.module.ts

# Decorators
* A decorator is similar to data annotations in C#
* It adds special metadata to the class, function, parameter, accessor, or property it is placed over
* Defined with @expression syntax
* Different types of decorators
    * Class Decorator
        * Ex: @Component, @NgModule, @Injectable
    * Method Decorator
        * Ex: @HostListener
    * Property Decorator
        * Ex: @Input, @Output

# Directives
* It allows us to manipulate the DOM itself
* Essentially abstracts the old way of document.querySelector() and then changing the information there
* It acts as a marker on the DOM element that tells Angular to change that DOM element
* You can also create your own directives in Angular
## Structural Directive
* Changes/manipulate the structure of the DOM itself
* So adding new elements, or removing existing elements, etc.
* Ex: *ngIf - Removes or adds the element back in depending on the condition
    *ngFor - Repeats the element multiple times depending on how many things are inside of the array
    *ngSwitch - similar to c# switch
## Attribute Directive
* It is used to change the look and behavior of the DOM elements
* Ex: ngClass - adds CSS claases to the element dynamically
      ngStyle - adds CSS style to the element dynamically

# Pipes
* They provide a way to transform values before it is displayed
    * Tranform just means you can modify, change, or reformat the values into what you want it to be
* They are used in conjunction with interpolation so syntax would be {{targetData | pipe}}

# 
