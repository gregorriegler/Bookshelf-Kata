Bring in an ISBN, and a feature to find books by ISBN.
Db2 could add such a findById feature, and then the question is were did you put the filtering logic?
Inside the Repository implementation? Then it should be easy to migrate and unse the new findById feature.
However, if you did put the filtering in your business logic, it will be a little harder as you have to change the contract

Would bring new possible Constraints:
- No Nulls
- Selfvalidating Objects
