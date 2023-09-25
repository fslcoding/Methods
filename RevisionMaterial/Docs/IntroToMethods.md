# Intro to methods

This is a short breakdown of the [IntroToMethods.cs](https://github.com/fslcoding/Methods/blob/main/RevisionMaterial/IntroToMethods.cs) class.

+ A `method` is a block of code that can be called onto to perform a specific function over and over again.
+ A `method` exists outside of the `Main` `method` 
+ A `method` will return the **_power of execution_** to the `Main` `method`.

Lets look at the definitions of our methods:

```cs
static void MethodOne() 
{
    Console.WriteLine("This is the first method");
}
```

+ `MethodOne()` will print that it is the first method. 
+ It will then return **_power of exectution_** to the `Main` `method`

Let's look at the next method:

```cs
static void MethodTwo() 
{
    Console.WriteLine("This is the second method");
}
```

+ Similary to `MethodOne()`, `MethodTwo()` will print out that it is the second method.
+ Then it will return **_power of execution_** to the `Main` `method`


Here is a `Method` `call`.

This means that we are running the code _defined_ in the method.

```cs
MethodOne();
```

<details>
    <summary>
        What would the output be?
    </summary>

    This is the first method

</details>

<br>

Now let's look at the [program](https://github.com/fslcoding/Methods/blob/main/RevisionMaterial/IntroToMethods.cs):

```cs
MethodOne();
MethodTwo();
MethodOne();
```

<details>
    <summary>
        What would the output be?
    </summary>

    This is the first method
    This is the second method
    This is the first method

</details>

<br>

Finally, lets look at the [for](https://github.com/fslcoding/Loops) loop:

```cs
for (int i = 0; i < 5; i++) {
    MethodTwo();
}
```

The code above will run the `MethodTwo()` five times.

<details>
    <summary>
        What would the output be?
    </summary>

    This is the second method
    This is the second method
    This is the second method
    This is the second method
    This is the second method

</details>


