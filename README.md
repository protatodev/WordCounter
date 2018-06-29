# Word Counter

#### Epicodus C# Week 1 Word Counter Project, 6.29.2018

#### By Protatodev (Thad Donaghue)

## Description

This program will prompt the user to enter a word. The program will then prompt the user to enter a string and will display how many times the word they entered appears in the string. The program will ignore special characters for both the word and phrase inputs. The program will ignore whitespaces for the word input, but not the phrase input (whitespaces are used to delimit each word). Both inputs are handled case insensitively.

## Specs

| Behavior | Input | Output | Why |
|----------|-------|--------|-----|
| Prompt user to enter a word | Food | *Food* | Simple input gathering is the first step in the program |
| Prompt user to enter a string of words | Food is great | *Food is great* | Simple input gathering for the phrase to check |
| Convert word to lowercase | FOOD | food | Necessary for comparison of individual words. Simple to implement |
| Convert phrase to lowercase | Food is gReAt | food is great | Necessary for comparison of individual words. Simple to implement |
| Search each word for multiple occurences and update a counter for each occurence | Food is great | *'Food' was found 1 time* | Incrementing a counter and reporting the occurences is required program functionality. Simple to implement |
| Display findings to the user | Food is great | The word Food was found 1 time(s) in the phrase you entered. | This report is required for program functionality. Simple to implement |
| Check to ensure word is a string | food | *word is a string* | Necessary to ensure valid input. Moderately difficult to implement |
| Check to ensure the input is a string | Food is great | *phrase is a string* | Necessary to ensure valid input. Moderately difficult to implement |
| Allow for numerical characters | Food is great! 123 | *Read '123' as if it were a string* | User may enter '5' instead of 'five'. Moderately difficult to implement |
| Check word for special characters | food | *no special characters exist* | Remove any non-word characters that would break the search algorithm. Difficult to implement |
| Check each word in the phrase for special characters | Food is great | *whitespace characters exist* | Remove any non-word characters that would break the search algorithm. Difficult to implement | 
| If special characters are found, handle them | Food is great! | *leave whitespace as delimiter, remove '!'* | Validation required to support search algorithm. Difficult to implement |


## Setup on OSX / Windows

* Download and install .Net Core 1.1.4 (Linked below)
* Download and install Mono (Linked below)
* Clone the repo
* Run `dotnet restore` from within the project directory using PowerShell / Terminal

## Contribution Requirements

1. Clone the repo
1. Make a new branch
1. Commit and push your changes
1. Create a PR

## Technologies Used

* .Net Core 1.1.4

## Links

* https://github.com/protatodev/WordCounter
* https://github.com/dotnet/core/blob/master/release-notes/download-archives/1.1.4-download.md
* https://www.mono-project.com/

## License

This software is licensed under the MIT license.

Copyright (c) 2018 **Protatodev**
