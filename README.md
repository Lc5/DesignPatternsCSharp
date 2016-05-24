# Design Patterns C# #
A collection of "Gang of Four" and other design patterns implemented in C#. The goal of this project was to gain ultimate
knowledge of popular design patterns. The code was inspired by
examples found in the web. It was written with minimalistic approach in mind in order to keep it as small as possible,
 while still achieving the goal of clearly presenting the patterns. 
 
 Please note, that tests are not meant to be pure unit tests, but rather serve to show the patterns usage.
 
## Usage
The project can be compiled and run using Visual Studio 2015.

## Gang of Four patterns

### Behavioral

* [ChainOfResponsibility](DesignPatterns/GangOfFour/Behavioral/ChainOfResponsibility) - delegates commands to a chain of processing objects.
* [Command](DesignPatterns/GangOfFour/Behavioral/Command) - creates objects which encapsulate actions and parameters.
* [Interpreter](DesignPatterns/GangOfFour/Behavioral/Interpreter) - implements a specialized language.
* [Iterator](DesignPatterns/GangOfFour/Behavioral/Iterator) - accesses the elements of an object sequentially without exposing its underlying representation.
* [Mediator](DesignPatterns/GangOfFour/Behavioral/Mediator) - allows loose coupling between classes by being the only class that has detailed knowledge of their methods.
* [Memento](DesignPatterns/GangOfFour/Behavioral/Memento) - provides the ability to restore an object to its previous state (undo).
* [Observer](DesignPatterns/GangOfFour/Behavioral/Observer) - is a publish/subscribe pattern which allows a number of observer objects to see an event.
* [State](DesignPatterns/GangOfFour/Behavioral/State) - allows an object to alter its behavior when its internal state changes.
* [Strategy](DesignPatterns/GangOfFour/Behavioral/Strategy) - allows one of a family of algorithms to be selected on-the-fly at runtime.
* [TemplateMethod](DesignPatterns/GangOfFour/Behavioral/TemplateMethod) - defines the skeleton of an algorithm as an abstract class, allowing its subclasses to provide concrete behavior.
* [Visitor](DesignPatterns/GangOfFour/Behavioral/Visitor) - separates an algorithm from an object structure by moving the hierarchy of methods into one object.

### Creational

* [AbstractFactory](DesignPatterns/GangOfFour/Creational/AbstractFactory) - groups object factories that have a common theme.
* [Builder](DesignPatterns/GangOfFour/Creational/Builder) - constructs complex objects by separating construction and representation.
* [FactoryMethod](DesignPatterns/GangOfFour/Creational/FactoryMethod) - creates objects without specifying the exact class to create.
* [Prototype](DesignPatterns/GangOfFour/Creational/Prototype) - creates objects by cloning an existing object.
* [Singleton](DesignPatterns/GangOfFour/Creational/Singleton) - restricts object creation for a class to only one instance.

### Structural

* [Adapter](DesignPatterns/GangOfFour/Structural/Adapter) - allows classes with incompatible interfaces to work together by wrapping its own interface around that of an already existing class.
* [Bridge](DesignPatterns/GangOfFour/Structural/Bridge) - decouples an abstraction from its implementation so that the two can vary independently.
* [Composite](DesignPatterns/GangOfFour/Structural/Composite) - composes zero-or-more similar objects so that they can be manipulated as one object.
* [Decorator](DesignPatterns/GangOfFour/Structural/Decorator) - dynamically adds/overrides behaviour in an existing method of an object.
* [Facade](DesignPatterns/GangOfFour/Structural/Facade) - provides a simplified interface to a large body of code.
* [Flyweight](DesignPatterns/GangOfFour/Structural/Flyweight) - reduces the cost of creating and manipulating a large number of similar objects.
* [Proxy](DesignPatterns/GangOfFour/Structural/Proxy) - provides a placeholder for another object to control access, reduce cost, and reduce complexity. 

## Other patterns

### Creational

* [ObjectPool](DesignPatterns/Other/Creational/ObjectPool) - avoids expensive acquisition and release of resources by recycling objects that are no longer in use.
* [SimpleFactory](DesignPatterns/Other/Creational/SimpleFactory) - creates objects without specifying the exact class to create.
