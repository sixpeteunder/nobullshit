# nobullshit
No bullshit.

## Features

- [x] Web scraper
    - [x] Hosted service
    - [ ] Configurable interval
- [x] Rest API server
    - [x] Pagination
    - [ ] Search
    - [ ] Sort
    - [ ] Filter
- [x] Database
- [ ] Logo

## Projects

This repository is a Visual Studio Solution that comprises 6 of 10 planned projects:

- [x] [NoBullshit.Shared](tree/main/src/NoBullshit.Shared) - .NET Class Library
    
    *TFM: net6.0*
    
    *Depends on: N/A*
    
    Contains code shared between all the projects.

- [x] [NoBullshit.Server](tree/main/src/NoBullshit.Server) - ASP.NET Core Web API
    
    *TFM: net6.0*

    *Depends on: NoBullshit.Shared*
    
    Contains web scraper, database operations, REST API.

- [x] [NoBullshit.Client](tree/main/src/NoBullshit.Client) - .NET Class Library

    *TFM: net6.0*

    *Depends on: NoBullshit.Shared*
    
    Contains client library for the API.

- [x] [NoBullshit.Cli](tree/main/src/NoBullshit.Cli) - Console Application
    
    *TFM: net6.0*

    *Depends on: NoBullshit.Client*
    
    Contains console application.

- [x] [NoBullshit.Web](tree/main/src/NoBullshit.Web) - Blazor Webassembly Application
    
    *TFM: net6.0*

    *Depends on: NoBullshit.Client, NoBullshit.RazorUI*
    
    Contains Blazor Webassembly progressive web application (PWA).

- [x] [NoBullshit.RazorUI](tree/main/src/NoBullshit.RazorUI) - Razor Class Library
    
    *TFM: net6.0*

    *Depends on: NoBullshit.Shared*
    
    Contains Razor UI shared between Nobullshit.Web and NoBullshit.Lite.
    
- [ ] NoBullshit.Bot - Microsoft Bot Framework Bot
    
    *TFM: net6.0*

    *Depends on: NoBullshit.Client*
    
    Will contain a Microsoft Bot Framework Bot.

- [ ] NoBullshit.App - .NET MAUI Application
    
    *TFM: net6.0*

    *Depends on: NoBullshit.Client*
    
    Will contain a native multiplatform .NET MAUI App.

- [ ] NoBullshit.Lite - .NET MAUI Blazor Application
    
    *TFM: net6.0*

    *Depends on: NoBullshit.Client, NoBullshit.RazorUI*
    
    Will contain a lightweight multiplatform .NET MAUI Blazor App.

- [ ] nobs - Vue PWA, TypeScript client
    
    *TFM: N/A*

    *Depends on: N/A*
    
    Contains VueJS progressive web application (PWA) and TypeScript client library.