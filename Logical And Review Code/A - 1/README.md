# LPS A-1


### Cons Old Code

1. Nested if statements: Although the code ensures safety by checking for null values, it creates a nested if structure, which can sometimes reduce readability, especially if there are more levels of nesting or if the code becomes longer.
2. Return inside nested if: Depending on the context and the surrounding code, returning directly from a nested if statement might not be the most maintainable solution. It can make the control flow less obvious.


### Suggestion Code

1. Early return: We could use early returns to reduce nesting and improve readability further.
2. Guard Clauses: Using guard clauses can make the code clearer by checking for invalid conditions at the beginning of the method.
\
My Suggestion Code :
```csharp
if (application == null)
    return null; // or throw an exception
if (application.protected == null)
    return null; // or throw an exception

return application.protected.shieldLastRun;
```


### Alternative Suggestion
To write simpler code in 1 line code, we can use the null conditional operator (?.) introduced in C# 6.0
```csharp
return application?.protected?.shieldLastRun;
```
