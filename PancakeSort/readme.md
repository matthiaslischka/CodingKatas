# Pancake Sort

Inspired by: https://www.youtube.com/watch?v=Y4G55jk5Ymg

Given an array of integers `arr`:
 1. Write a function `flip(arr, k)` that reverses the order of the first `k` elements in the array `arr`.
 
 2. Write a function `pancakeSort(arr)` that sorts and returns the input array. You are allowed to use only the function `flip` you wrote in the first step in order to make changes in the array.
 
 Examples:
 
 ```
 input: arr = [1, 5, 4, 3, 2]
 
 output: [1, 2, 3, 4, 5] # to clarify, this is pancake Sorted
 ```
 
 Analyze the time and space complexities of your solution.
 
 **Note:** it's called pancake sort because it resembles sorting pancakes on a plate with a spatula, where you can only use the spatula to flip some of the top pancakes in the plate. To read more about the problem, see the [Pancake Sorting Wikipedia Page](https://en.wikipedia.org/wiki/Pancake_sorting).