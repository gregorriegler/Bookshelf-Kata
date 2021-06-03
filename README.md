# BookShelve Kata

## Motivation
The motivation of this Kata is to practice the testing of code that is at the outgoing side of the boundary of an application, like persistence.
In terms of the [Hexagonal Architecture](https://alistair.cockburn.us/hexagonal-architecture/) this would be a port/adapter on the "driven" side.

## Initial Requirements
You are implementing a system that utilizes the persistence of a BookShelve.

1. The BookShelve starts empty.
2. The system can add a book to the BookShelve, a book consists of an ISBN and a title.
3. It can find a book by its ISBN.
4. It can grab a list of all books that have been added to the shelve.

### Things to think about
How could we design this so that it allows us to write fast unit tests in our application that don't hit the database?
What are the alternatives to a mock, and what are their advantages/disadvantages?
How can we make sure to be able to change the database in the future with minimal effort, and can we reuse the tests for that?

## Further Requirements
A new consumer of the BookShelve implementation is added.
It's job is to find and remove books from the shelve that have "bad" names.
This new subsystem needs the following features from the BookShelve implementation.

1. It can find books whose title contains a given "bad" word.
2. It can remove a book from the shelve by providing its ISBN.

### Things to think about
What does the new consumer need to know about the BookShelve, and what doesn't it need to know?
What if the new consumer was in a separate module or even a microservice? How could we structure our code and its dependencies in this case?

## Ideas for Constraints

- No Nulls
- No Primitives
- Selfvalidating Objects (Must not be possible to create invalid Books, e.g. missing title, missing or invalid ISBN)
