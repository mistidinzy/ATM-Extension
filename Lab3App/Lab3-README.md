<!-- markdownlint-disable MD024 -->
# Lab 03 - Part 2: `Review`

## Problem Domain

- Create a single `Console Application Project` within Visual Studio.
- Write all of your code in the `Program.cs` file.
- Write a method for each of the challenges below.
- Call each of these methods in your Main method.
- Be sure to use exception handling where appropriate, and write tests as outlined in each of the challenges.
- Whiteboard at least one of the challenges and include it in your `README.md`.

---

## *Skip To...*

> ### [Challenge 1: *Product of 3*](#challenge-1)
>
> ### [Challenge 2: *Random Average*](#challenge-2)
>
> ### [Challenge 3: *Diamond Stars*](#challenge-3)
>
> ### [Challenge 4: *Most Frequent Integer*](#challenge-4)
>
> ### [Challenge 5: *Array's Max Value*](#challenge-5)
>
> ### [Challenge 6: *User's Word to Text File*](#challenge-6)
>
> ### [Challenge 7: *Word File to Console Message*](#challenge-7)
>
> ### [Challenge 8: *Remove and Rewrite*](#challenge-8)
>
> ### [Challenge 9: *Character Count*](#challenge-9)

---

## Challenge 1

### *Product of 3*

- Write a program that asks the user for 3 numbers.
- Return the product of these 3 numbers, multiplied together.
- If the user puts in less than 3 numbers, return 0.
- If the user puts in more than 3 numbers, only multiply the first 3.
- If the number is not a number, default that value to 1.

### *Example:*

```js
Please enter 3 numbers: 4 8 15
The product of these 3 numbers is: 480
```

> ---
>
> Hint: Consider using the 'split' method.
>
> ---

### *Tests:*

- Input a string of numbers and it returns a product of all numbers
- Input more than 3 numbers
- Input of less than 3 numbers
- Can it handle negative numbers

---

## Challenge 2

### *Random Average*

- Create a method that asks the user to enter a number between 2-10.
- Then, prompt the user that number of times for random numbers.
- After the user has entered all of the numbers, find the average of all the numbers given.
- Do not let the user put in negative numbers.
- Confirm each input is a real number.

### *Example:*

```js
Please enter a number between 2-10: 4

1 of 4 - Enter a number: 4
2 of 4 - Enter a number: 8
3 of 4 - Enter a number: 15
4 of 4 - Enter a number: 16
The average of these 4 numbers is: 10
```

### *Tests:*

- Input different ranges of numbers and confirm averages.
- Confirm input.
- All numbers are 0s.

---

## Challenge 3

### *Diamond Stars*

- Create a method that will output to the console the following design.
- Pay attention to spacing.

### *Example:*

```js
    *
   ***
  *****
 *******
*********
 *******
  *****
   ***
    *
```

### *Tests:*

- No tests are required

---

## Challenge 4

### *Most Frequent Integer*

- Write a method that brings in an integer array and returns the number that appears the most times.
- If there are no duplicates, return the first number in the array.
- If more than one number show up the same amount of time, return the first found.

### *Example:*

```js
Input: [1,1,2,2,3,3,3,1,1,5,5,6,7,8,2,1,1]
Output: 1
```

### *Tests:*

- Input different size arrays.
- All numbers in the array are the same value.
- No duplicates exist in the array.
- There multiple numbers that show up the same amount of times.

---

## Challenge 5

### *Array's Max Value*

- Write a method in that finds the maximum value in the array.
- The array is not sorted.
- You may not use `.Sort()`.

### *Example:*

```js
Input [5, 25, 99, 123, 78, 96, 555, 108, 4]
Output: 555
```

### *Tests:*

- Negative numbers.
- All values are the same.

---

## Challenge 6

### *User's Word to Text File*

- Write a method that asks the user to input a word, then saves that word into an external file named `words.txt`.

> Hint: Have a file already saved in the root of your directory, with a couple of words already present in the file.

### *Tests:*

- **Stretch Goal**: Tests are optional for this challenge.

---

## Challenge 7

### *Word File to Console Message*

- Write a method that reads the file in from Challenge 6, then outputs the contents to the console.

### *Tests:*

- **Stretch Goal**: Tests are optional for this challenge.

---

## Challenge 8

### *Remove and Rewrite*

- Write a method that reads the file from Challenge 6, removes one of the words, and rewrites it back to the file.

### *Tests:*

- **Stretch Goal**: Tests are optional for this challenge.

---

## Challenge 9

### *Character Count*

- Write a method that asks the user to input a sentence, and returns an array, that lists out each word, and the number of characters that word contains.

### *Example:*

```js
Input: "This is a sentence about important things"

Output: ["This: 4","is: 2", "a: 1", "sentence: 8", "about: 5", "important: 9", "things: 6"]
```

### *Tests:*

- Input a sentence and confirm it returns an array.
- Input a sentence, and it returns the ***correct*** array.
- Use different sentences with different symbols.

---
