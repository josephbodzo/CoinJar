# Coin Jar API Application
The coin jar will only accept the latest US coinage and has a volume of **0.42** fluid ounces. Additionally, the jar has a counter to keep track of the total amount of money collected and can reset the count back to $0.00.

Each US coin has the assumed fluid ounces:
- Penny (1c): 0.0122
- Nickel (5c): 0.0243
- Dime (25c): 0.0270
- Half Dollar(50c): 0.0534
- Dollar (100c): 0.0800

The application exposes 3 endpoints:
1. Add a coin.
2. Get the total amount of our coins.
3. Reset the coins.

**NB: The assignment required the jar to have a volume of 42 fluid ounces but I made it to be 0.42 fluid ounces so that all use cases can be easily testable.**

## Requisites
- Install [.Net 5.0 SDK](https://dotnet.microsoft.com/download/dotnet/5.0) or [Visual Studio Version 16.8](https://docs.microsoft.com/en-us/visualstudio/releases/2019/release-notes)

## How to run the project via cli
- Open your command line
- Run ```dotnet dev-certs https --trust``` to trust the https development certificate
- Clone the git repository
- Navigate into the folder CoinJar.API
- Run ```dotnet watch run```
- Swagger page comes up in your default browser

## How to run the project from IDE 
- Open visual studio and set CoinJar.API as start up project
- Run the solution
- Swagger page comes up in your default browser