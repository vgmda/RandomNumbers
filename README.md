# RandomNumbers

> C# Random class provides functionality to generate random numbers in C#. The Random class can also generate other data types including strings. In this code example, learn how to create a random number in C#. 

By default, the .NET framework generates random numbers based on the current system time. Numbers generated using the Random class are not considered reliable for high-stake scenarios such as cryptography because the system clock has limited granularity. For example, two Random instances created withing couple of milliseconds yield the same sequence of values. The Random class has a constructor that accepts the seed value. Seed is a a starting value for the pseudo-random number generation algorithm. If we use the same seed for different Random objects, they will generate the same series of random numbers. This functionality is useful when we want reproducibility.

| Method | Description |
| --- | --- |
| Next() | Returns a positive random integer within the default range -2,147,483,648 to 2,147,483, 647. |
| Next(int) | Returns a positive random integer that is less than the specified maximum value. |
| Next(int, int) | Returns a positive random integer within the specified minimum and maximum range (includes min and excludes max). |
| NextDouble() | Generates random floating-point number that is greater than or equal to 0.0 and less than 1.0. |
| NextByte() | Fills the specified array with the random bytes. |
