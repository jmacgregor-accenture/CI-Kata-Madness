# CI-Kata-Madness
```
As a software Artisan,

I want to be able to build the "muscle memory" needed to stand up a basic CI pipeline

So that I can run end-to-end tests whenever I am ready to commit working code.
```

### A Note on Toolchains and Tech stacks
While this kata was developed using a GitHub/Travis-CI/Docker/Selenium tech stack, there is no one right way to play any of these cards. The ultimate goal is to incrementally grow the pipeline until all cards are complete.

# Template Code
A skeleton application with a front end and a back end has been provided. Feel free to fork this repo or download a zipfile of the code in order to create a wholly-new repo. The goal is to allow you to focus on the CI portion rather than developing an MVP application.

## DO NOT FORGET TO PRACTICE RED-GREEN-REFACTOR WHEN CONFIGURING YOUR PIPELINE; FALSE POSITIVES ARE EASY TO REACH 

### .NET Core MVC Front End

The front end is an ASP.NET Core MVC solution that uses the default template with some modifications for this kata.

The index page has a button that is wired to a Values controller. The Values controller calls a Value service, which is intended to call the provided back end project API end point. **NOTE** The URL in the ValueService.GetValue method will need to be changed unless you configure a container to be mapped to that port.

There is a single test written against the ValueService.GetValue method that will fail due to connection issues from the start.

There are no integration/end-to-end/smoke tests provided as there is a card in the kata calling for that.

### .NET Core Back End

The back end project is a scaled down .NET Core Web API template with only one endpoint that returns a single hardcoded message. 

There is a single test written against the BusinessLogic class that should fail until it is rewritten.

# Card Backlog

## Front End Pipeline
```
As a software Artisan,

I want the solution to build and unit tests to run everytime I push the front end code to the repo

So that I can see if there are any errors.
```
Acceptance Criteria: Pushing code to the repo triggers a build and, upon build success, runs unit tests.

## Back End Pipeline
```
As a software Artisan,

I want the solution to build and unit tests to run everytime I push back end code to the repo,

So that I can see if there are any errors.
```
Acceptance Criteria: Pushing code to the repo triggers a build and, upon build success, runs unit tests.

## Containerize Front End Application
```
As a software Artisan,

I want my front end application to be packaged in a container, 

So that I can run it without an IDE in any environment.
```
Acceptance Criteria: Run container and reach the application home page from the browser

## Containerize Back End Application
```
As a software Artisan,

I want my back end application to be packaged in a container, 

So that I can run it without an IDE in any environment.
```
Acceptance Criteria: Run container and receive expected values in the browser

## Write End-to-End Tests
```
As a software Artisan,

I want to have end-to-end tests written,

So that I can confirm my front end and back end are communicating correctly.
```
Acceptance Criteria: With both containers running, end-to-end tests should pass by pushing a button and receiving expected result. Tests fail if containers are not running.

## Image Refresh
```
As a software Artisan,

I want to have a new image created whenever the code changes,

So that the container always reflects the current version of the source code.
```
Acceptance Criteria: When code is pushed, an updated image is created.

## End-to-End Testing in Pipeline
```
As a software Artisan,

I want to have my CI pipeline run end-to-end tests as part of the build process,

So that I know my application will run.
```
Acceptance Criteria: End-to-end tests run as part of the build process.

## End-to-End Testing Only on Pull Request Build
```
As a software Artisan,

I want to have my build behave differently for push requests and pull requests,

So that I am not spending server resources at inappropriate times.
```
Acceptance Criteria: End-to-End tests do not run when pushing code, only when a pull request is created.

## Build Process Runs When Amending Pull Request
```
As a software Artisan,

I want my build process to be triggered when making changes to the code included in a pull request,

So that I know the updated code is being checked.
```
Acceptance Criteria: New or updated code pushed to an existing pull request triggers a build and, upon build success, runs all tests.
