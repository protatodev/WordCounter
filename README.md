# Word Counter

#### Epicodus C# Week 1 Word Counter Project, 6.29.2018

#### By Protatodev

## Description

This program will prompt the user to enter a word. The program will then prompt the user to enter a string and will display how many times the word they entered appears in the string.

## Specs

| Behavior | Input | Output |
|----------|-------|--------|
| Prompt user to enter a word | Food | *Food* |
| Check to ensure word is a string | Food | *word is a string* |
| Prompt user to enter a string of words | Food is great | *Food is great* |
| Check to ensure the input is a string | Food is great | *phrase is a string* |
| Check each word in the phrase for special characters | Food is great | *whitespace characters exist* |
| If special characters are found, handle them | Food is great! | *set whitespace as delimiter, remove '!'* |
| Allow for numerical characters | Food is great! 123 | *Read '123' as if it were a string* |
| Search each word for multiple occurences and update a counter for each occurence | Food is great | *'Food' was found 1 time* |
| Display findings to the user | Food is great | The word Food was found 1 time(s) in the phrase you entered. |


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
