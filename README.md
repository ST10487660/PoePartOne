# PoePartOne.1
# PoePartOne.1
# Cybersecurity Awareness Chatbot (C# .NET 8)

## Project Overview

This project is a console-based Cybersecurity Awareness Chatbot built using C# (.NET 8).  
The purpose of the project is to help users learn basic cybersecurity awareness in an interactive way.

The system includes a voice greeting, an ASCII logo display and a chatbot that interacts with the user through the console.



## Features

- Audio greeting when the program starts  
- ASCII logo generated from an image  
- Interactive chatbot responses  
- User name input and personalised welcome message  
- Basic cybersecurity awareness messages  
- Input validation and error handling  
- Structured object-oriented programming design  



## Project Structure
PoePartOne/
│
├── Program.cs
├── Chatbot.cs
├── VoiceLogo.cs
├── PoePartOne.csproj
├── PoePartOne.sln
│
├── Resources/
│ ├── greet.wav
│ └── logo.png
│
├── .github/
│ └── workflows/
│ └── dotnet.yml
│
└── .gitignore




## Technologies Used

- C# (.NET 8)
- Visual Studio
- Git and GitHub
- GitHub Actions (CI/CD)
- System.Media for audio playback
- System.Drawing for image processing

---

## CI/CD Pipeline

This project uses GitHub Actions to automatically build the project when changes are pushed to the repository.

The workflow file is located in:
`.github/workflows/dotnet.yml`

The pipeline:
- Restores dependencies  
- Builds the project  
- Runs the build checks
- <img width="1353" height="640" alt="image" src="https://github.com/user-attachments/assets/f8a59c4d-4060-408b-9b5e-9012cfe58944" />



## How to Run the Project

1. Clone the repository:


git clone https://github.com/ST10487660/PoePartOne.git



2. Open the solution file:


PoePartOne.sln

3. Run the project in Visual Studio by pressing F5



## What I Learned

- How to build a C# console application  
- Working with classes and methods  
- File handling for audio and images  
- Using Git and GitHub for version control  
- Setting up a basic CI/CD pipeline using GitHub Actions  
- Structuring a project properly  

---

## Author

Matlou Shaun Rakgoale  
Student ID: ST10487660  
Software Development Student

---

## Version History

- Initial commit – Project setup  
- Added chatbot logic  
- Added voice greeting system  
- Added ASCII logo conversion  
- Improved chatbot responses  
- Added GitHub Actions workflow  
- Final cleanup and improvements  






## References

The following resources and tools were used during the development of this project:

- ChatGPT (OpenAI) – used for guidance, debugging help and explaining programming concepts
- Google – used for general research and problem solving
- ASCII art and ASCII conversion techniques – used to generate console-based visual output
- design.com – used to design image logo
- bandlab - used for voice wav audio
