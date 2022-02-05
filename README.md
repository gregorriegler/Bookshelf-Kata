# BookShelve Kata

## Introduction
This purpose of this kata is to practice to deal with expensive and hard to test infrastructure at the outgoing side of an application (in this example, a database).

## Challenges
- How could we develop this using mostly fast unit tests?
- Do we have to use mocks in this case? What are the alternatives?
- Can we make sure that we can easily and safely replace the database in the future?
- How do we properly abstract and separate the code that is hard to test from the code that is easy to test?
- And how do we design our tests, so that they assist future refactorings?

---

Follow the steps one by one and do not read ahead.

### Step 1 
There is a database library in the `db` package called `Db` and you don't own it, so you are not allowed to change it either.
Program a book shelve that can create and store books and use the given database for it.
For now, books should only have a title.
It is not necessary to create a UI, CLI or any other complicated API for this. 
A simple service class/module/function will do.

### Step 2
We would like to be able to skim the books we have added so far. 
Add a feature that allows us to retrieve all books that were stored in the book shelve.

### Step 3
Lets add more spice to the book shelve.
Mark every 10th book you add as an anniversary book.

### Step 4
We really love our book shelve so far. We added so many books, we would like to celebrate that.
Therefor, every 25th book we add should be marked as a golden anniversary book.

### Step 5
A new version of `Db` came out. It's much faster, but they renamed the persist function.
And it has a new feature where you can get the count of stored objects.
This should help with the anniversary features.
Migrate to the new version, it's located in the `db2` package.


## Links for further inspiration (Theory, Patterns, Principles)

- [Repository Pattern](https://martinfowler.com/eaaCatalog/repository.html)
- [Fake](https://martinfowler.com/bliki/TestDouble.html)
- [Logic Sandwich](http://www.jamesshore.com/v2/blog/2018/testing-without-mocks#logic-sandwich)
- [Dependency Inversion Principle](https://en.wikipedia.org/wiki/Dependency_inversion_principle)
- [Abstract Contract Test](https://blog.thecodewhisperer.com/permalink/writing-contract-tests-in-java-differently)
- [Abstract Test Cases, 20 Years later](https://blog.thecodewhisperer.com/permalink/abstract-test-cases-20-years-later)
- [Hexagonal Architecture](https://alistair.cockburn.us/hexagonal-architecture/)
