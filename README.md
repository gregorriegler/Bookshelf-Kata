# Bookshelf Kata

## Introduction
The purpose of this kata is to practice dealing with expensive and hard-to-test infrastructure at the outgoing side of an application (in this example, a database).

## Challenges
- How could we develop this using mostly fast unit tests?
- Do we have to use mocks in this case? What are the alternatives?
- Can we make sure that we can easily and safely replace the database in the future?
- How do we properly abstract and separate the code that is hard to test from the code that is easy to test?
- And how do we design our tests, so that they assist future refactorings?

## Links for further inspiration (Theory, Patterns, Principles)

- [Repository Pattern](https://martinfowler.com/eaaCatalog/repository.html)
- [Fake](https://martinfowler.com/bliki/TestDouble.html)
- [Logic Sandwich](http://www.jamesshore.com/v2/blog/2018/testing-without-mocks#logic-sandwich)
- [Dependency Inversion Principle](https://en.wikipedia.org/wiki/Dependency_inversion_principle)
- [Abstract Contract Test](https://blog.thecodewhisperer.com/permalink/writing-contract-tests-in-java-differently)
- [Abstract Test Cases, 20 Years later](https://blog.thecodewhisperer.com/permalink/abstract-test-cases-20-years-later)
- [Hexagonal Architecture](https://alistair.cockburn.us/hexagonal-architecture/)
- [DomainService vs ApplicationService in DDD](https://enterprisecraftsmanship.com/posts/domain-vs-application-services/)
