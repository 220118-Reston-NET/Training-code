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

# Services
* It is a class that is not dependent on any component
* It is used to **share data/logic across components** and encapsulate external interactions (like our backend api)
* It uses the **Injectable** decorator to specify to Angular Injector to automatically create an object of this service if a component needs it (i.e. it is stated in the constructor)
## Dependency Injection
* It is a design pattern where we declare the dependencies in the constructor of the dependent class.
* For Angular, this is done for us automatically using **Angular Injector**

# HttpClient
* It is an API for Angular application that handles HTTP requests
* Note that HttpClient methods will return an **Observable**
## Observable
* It is similar to a promise in JS except it has 0, 1, or many activations
* It follows a publisher and subscriber model
    * That model is very similar to how Youtube operates, you have a creator (Publisher) and whenever a creator uploads a video, everyone who is subscribed (Subscribers) to that creator will get a notification
    * So a publisher and subscriber model in terms of an observable is that is an observable is subscribed to an endpoint, it will keep receiving information from that endpoint as long as the backend keeps on sending information
* It has an array that stores data that arrives asynchronous over time

# Routing
* Provides a way for us to navigate from one view to another view in the application
* Routing in Angular is a bit different mostly because it is a SPA (single page application) so instead of showing pages, the route will show different components to display instead
* You must provide the RouterModule in app.module.ts

# Angular Forms (Reactive Forms)
* Reactive forms are great for creating a more complex validation process when asking for input from the user
* It uses TS to handle most of the validation process (Using the Validation class)
* You must import ReactiveFormsModule in app.module.ts
## Different Form Control States
* Form control has been visited
    * False - ng-untouched
    * True - ng-touched
* Form control's value has been changed
    * False - ng-pristine
    * True - ng-dirty
* Form control's value is valid
    * False - ng-invalid
    * True - ng-valid

# Jasmine and Karma
## Behavior Driven Development (BDD)
* Development that occurs based off collaborations between non-technical members and technical development team
* Conversations between business analyst and Client/Owner will determine what kind of functions this app should have (user stories)
* Conversations -> test cases -> development
## Jasmine
* It is a JavaScript unit testing framework that supports BDD
* Tests will run in the browser and results are displayed in the browser
* Features to know about:
    * Test suite (a collection of test case) we use the describe(“string of the description of what the unit test is testing for”, arrow function) method
    * Test spec (basically a unit test) we use it() method
    * Expect() method (Similar to Assert)
        * It is used with conjunction with a marcher that does Boolean comparison
    * TestBed keyword is used to configure the testing environment with special methods such as .configureTestingModule() that gives the dependencies required to make it work
    * Spying is one way we can mock dependencies inside of Jasmine
## Karma
* Manually run Jasmine test by refreshing the browser in different browsers (such as google chrome, edge, firefox. Etc.) every time we edit our code
* It is a tool developed to spawn browsers and run Jasmine tests on all the browser in your command line

# Introduction to ORM
* Object-Relational Mapper
* They are used to essentially translate data from a table structure in SQL into something C# language (basically objects)
* The ORM that we will be using is Entity Framework Core

# Entity Framework Core
* One of the popular ORM for .NET core
* It allows us to work with a database by using .NET objects and almost completely removing the need for most data-access code you usually have to write (unlike our ADO.NET)
## Two approaches to EF
* Database first approach
    * This is when you created a database architecture/schema first
    * It will create the entities and DBcontext for us based on the database
* Code first approach
    * This is when you create a .NET application first
    * It will create the database for you and establish the relationships as well based on the models
    * You would need to create the DBContext
## Useful terminology/artificats to know when working with EF
* DBContext
    * Represents a session with the database
    * So any CRUD operations will start here
    * Also used to configure how EF will construct your database architecture using **Fluent API** in OnModelCreating() method
* Migration
    * They are a snapshot of the database architecture given the current state of your models
    * So if you change your models/db architecture, you would need to create another migration and update the database
* Entities
    * It is the model version of the tables of your database
    * So a Student table in Database will have a student entity in EF core
* Relationships
    * Same thing as multiplicity in SQL
    * They way you signify the relationships will be use of data annotations/Fluent API/Model structure
