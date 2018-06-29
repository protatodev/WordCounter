# Word Counter

#### Epicodus C# Week 1 Word Counter Project, 6.29.2018

#### By Protatodev

## Description

This program will prompt the user to enter a word. The program will then prompt the user to enter a string and will display how many times the word they entered appears in the string.

## Specs

| Behavior | Input | Output | Why |
|----------|-------|--------|-----|
| Prompt user to enter a word | Food | *Food* | Simple input gathering is the first step in the program |
| Convert word to lowercase | FOOD | food | Necessary for comparison of individual words |
| Check to ensure word is a string | Food | *word is a string* | Necessary to ensure valid input |
| Check word for special characters | Food | *no special characters exist* | Remove any non-word characters that would break the search algorithm |
| Prompt user to enter a string of words | Food is great | *Food is great* | Simple input gathering for the phrase to check |
| Check to ensure the input is a string | Food is great | *phrase is a string* | Necessary to ensure valid input |
| Check each word in the phrase for special characters | Food is great | *whitespace characters exist* | Remove any non-word characters that would break the search algorithm | 
| If special characters are found, handle them | Food is great! | *set whitespace as delimiter, remove '!'* | Validation required to support search algorithm |
| Allow for numerical characters | Food is great! 123 | *Read '123' as if it were a string* | User may enter '5' instead of 'five' |
| Convert phrase to lowercase | Food is gReAt | food is great | Necessary for comparison of individual words |
| Search each word for multiple occurences and update a counter for each occurence | Food is great | *'Food' was found 1 time* | Incrementing a counter and reporting the occurences is required program functionality |
| Display findings to the user | Food is great | The word Food was found 1 time(s) in the phrase you entered. | This report is required for program functionality |


## Setup on OSX

* Download and install .Net Core 1.1.4
* Download and install Mono
* Clone the repo
* Run `dotnet restore` from within the project directory

## Contribution Requirements

1. Clone the repo
1. Make a new branch
1. Commit and push your changes
1. Create a PR

## Technologies Used

* .Net Core 1.1.4

## Links

* https://github.com/protatodev/WordCounter

## License

This software is licensed under the MIT license.

Copyright (c) 2018 **Protatodev**
