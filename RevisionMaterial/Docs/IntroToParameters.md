# Intro to parameters

This is a short breakdown of the [IntroToParameters.cs](https://github.com/fslcoding/Methods/blob/main/RevisionMaterial/IntroToParameters.cs) class.

+ A `method` can send variables to use as part of its _execution_
+ These `parameters` must be declared within the `method` signature and must include the [type](https://github/fslcoding/Data-Types).

Let's look at what a `method` with a `parameter` might look like:

```cs
static void MethodOne(string name) 
{
    Console.WriteLine("This is MethodOne, and your name is: " + name);
}
```

+ We can see that the method takes in a `parameter`, which is a `string`, called `name`.
+ Inside the `method`, we use the name which is passed through to it.

### Calling the `method`

This is what calling `MethodOne(string name)` would look like:

```cs
MethodOne("Joshua");
```

<details>
    <summary>
        What would the output be?
    </summary>

    This is MethodOne, and your name is:  Joshua

</details>

Now let's try calling it multiple times:

```cs
MethodOne("Joshua");
MethodOne("Jules");
MethodOne("Johnathon");
MethodOne("Jay");
```

<details>
    <summary>
        What would the output be?
    </summary>

    This is MethodOne, and your name is:  Joshua
    This is MethodOne, and your name is:  Jules
    This is MethodOne, and your name is:  Johnathon
    This is MethodOne, and your name is:  Jay

</details>


### Passing multiple `parameters`

To pass multiple `parameters`, you should just separate them with a `,`.

Here's an example:

```cs
static void MethodTwo(string name, int age) 
{
    Console.WriteLine("You are called, " + name + " and your age is " + age );
}
```

To call this `method`, it would look something like this:

```cs
MethodTwo("Jules", 17);
```


<details>
    <summary>
        What would the output be?
    </summary>

    You are called, Jules and your age is 17

</details>
