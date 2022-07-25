# On The Beach : Find Your Holiday Console Application (Please Check in master branch)

  The Aim of the project is to develop a Holiday Search Console Application designed based on common Object Oriented Programming principles and to bulid my coding skills.
  As we know the Test Driven Developemt(TDD) is an important code practice to develop a higher quality code, here I have implemented the TDD approach. Here we have two Json files for
  1. Flight.json -> with flight data
  2. Hotels.json -> with hotel data

Shown below is the Project Flow

![ProgramFlowChart](https://user-images.githubusercontent.com/87146801/180698481-5fbfa70b-4271-4fed-9897-d0413dec75e3.jpg)


<!-- Technologies Involved -->
##  Technologies Involved

    language : C# .NET Framework , NUnit Framework

    IDE      : Visual Studio 2022

<!-- How It Works -->
##  How It Works 
    The application reads the Json data and stores in respective Objects (flight : contains 12 set of Flight data and hotels : contains 13 set of hotel data). Based on the 
    user input I am calling a method that does all validations and returns the actual result. 
    Main Checks were
    1. Validate the actual input and output.
    2. Validate if Depart from "Any London Airport"
    3. Validate if Depart from "Any Airport"
    4. Filter with the cheapest price
    5. If Invalid user input handling.
    
    Below is the sample Input and output shown.

![SampleInput_OutputData](https://user-images.githubusercontent.com/87146801/180698532-d9d684a7-5d8b-4c0f-b137-852de6f71168.jpg)
