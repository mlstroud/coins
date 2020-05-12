# _Coin Combinations_

#### _Epicodus Project May 12, 2020_

#### By _**Matt Stroud**_

## Description

_An Epicodus individual project using C# and MSTest. This project prioritizes unit testing to validate code and logic before writing code._
_The application will take a given amount of change and return the smallest combination of coins to make that change._

## Specs
| Behavior                                                                    | Input | Output        |
|:----------------------------------------------------------------------------|:-----:|--------------:|
| Program will store change amount input from user.                           | 0.97  | Change = 0.97 |
| Program will count quarters by seeing how many times it can subtract 0.25   | 0.97  | 3             |
| Program will count dimes by seeing how many times it can subtract 0.1       | 0.41  | 4             |
| Program will count nickels by seeing how many times it can subtract 0.05    | 0.25  | 5             |
| Program will count pennies by seeing how many times it can subtract 0.01    | 0.06  | 6             |
| Program will subtract all coin values one after another until 0 is reached. | 0.71  | 2Q, 2D, 1P    |

## Setup/Installation Requirements

1. Clone this repository from GitHub.
2. Open the downloaded directory in a text editor of your choice.
  (VSCode, Atom, etc.)
3. To install the REPL dotnet script, run dotnet tool install -g dotnet-script in your terminal.
4. Run the program with the command dotnet build.

## Known Bugs

There are no known bugs at the time of this update.
 
## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/mlstroud/coins/issues) here on GitHub._

## Technologies Used

* C#
* .NET Core
* MSTest
* Git

### License

This software is licensed under the MIT license.

Copyright © 2020 **_Matt Stroud_**