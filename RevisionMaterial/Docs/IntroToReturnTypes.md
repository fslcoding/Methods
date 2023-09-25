# Intro to `return types`

This is a short breakdown of the [IntroToMethods.cs](https://github.com/fslcoding/Methods/blob/main/RevisionMaterial/IntroToReturnTypes.cs) class.

+ A `Return type` is what a `method` gives back to it's caller
+ A `Return type` can be any [type](https://github.com/fslcoding/Data-Types)

Let's look at an example `Calculator`

+ First, we should have a method which takes in two `parameters`, `int` `num1` and `int` `num2`.
+ We should `return` the sum of the two numbers.

The method will look something like this:

```cs
static int Add(int num1, int num2) 
{
    return num1 + num2;
}
```

+ The `return` keyword is what will be given back the the caller of the method.

### Accessing the `return` value of a method.

To access the `return` value, simply use it like a variable.

```cs
int sum = Add(2, 4);
```

<details>
    <summary>
        What would the result be?
    </summary>

    6

</details>
