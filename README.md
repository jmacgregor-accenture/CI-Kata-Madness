# CI-Kata-Madness
```
As a software Artisan,

I want to be able to build the "muscle memory" needed to stand up a basic CI pipeline

So that I can run end-to-end tests whenever I am ready to commit working code.
```

### A Note on Toolchains and Tech stacks
While this kata was developed using a GitHub/Travis-CI/Docker/Selenium tech stack, there is no one right way to play any of these cards. The ultimate goals is to incrementally grow the pipeline until all cards are played and the end result.

## Card: Front End Pipeline
```
As a software Artisan,

I want the solution to build and unit tests to run everytime I push the front end code to the repo

So that I can see if there are any errors.
```
Acceptance Criteria: Pushing code to the repo triggers a passing build and unit test run.

## Card: Back End Pipeline
```
As a software Artisan,

I want the solution to build and unit tests to run everytime I push back end code to the repo,

So that I can see if there are any errors.
```
Acceptance Criteria: Pushing code to the repo triggers a passing build and unit test run.

## Card: Containerize Front End Application
```
As a software Artisan,

I want my front end application to be packaged in a container, 

So that I can run it without an IDE in any environment.
```
Acceptance Criteria: Run container and reach the application home page from the browser

## Card: Containerize Back End Application
```
As a software Artisan,

I want my back end application to be packaged in a container, 

So that I can run it without an IDE in any environment.
```
Acceptance Criteria: Run container and receive expected values in the browser

## Card: Write End-to-End Tests
```
As a software Artisan,

I want to have end-to-end tests written,

So that I can confirm my front end and back end are communicating correctly.
```
Acceptance Criteria: With both containers running, integration tests should pass by pushing a button and receiving expected result. Tests fail if containers are not running.

## Card: Image Refresh
```
As a software Artisan,

I want to have a new image created whenever the code changes,

So that the container always reflects the current version of the source code.
```
Acceptance Criteria: When code is pushed an udpated image is created

## Card: End-to-End Testing in Pipeline
```
As a software Artisan,

I want to have my CI pipeline run end-to-end tests as part of the build process,

So that I know my application will run.
```
Acceptance Criteria: End-to-end tests pass as part of the build request.

## Card: End-to-End Testing Only on Pull Request Build
```
As a software Artisan,

I want to have my build behave differently for push requests and pull requests,

So that I am not spending server resources at inappropriate times.
```
Acceptance Criteria: End-to-End tests do not run when pushing code, only when a pull request is created.

