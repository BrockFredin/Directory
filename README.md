# Directory Introduction

This application displays the total number of files processed, total number of files that contain code, and total number of lines of code

Built with Dependency Injection (SimpleInjector) and basic services

# Architecture
Foundation => Bootstrap (dependency injection) & Unit Tests
Demo => Scenarios (directory stats) & Services (logging or system wide needs)

# Instructions
1) Obtain Sample Directory and place in default path => C:\CandidateSampleCodeBase
2) Maintain or Change Path for Sample Directory within Accenture.DirectoryStatistics.Core (App.Config => Path)
3) Run AccentureDemoDisplayDirectoryStatistics 
4) Run DirectoryStatisticsUserScenarios_DoesGettingDirectoryStatisticsWork_HappyPath

# Sample Output (includes the readme file in the count)
http://imgur.com/a/nW6nW

22, 19, 208
Total Number Of Files Processed, Total Number of Files That Contain Code, Total Number Of Lines Of Code
