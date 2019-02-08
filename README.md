[![Build Status](https://travis-ci.com/cognophile/MedClerk.svg?branch=master)](https://travis-ci.com/cognophile/MedClerk)

# MedClerk 
A reception management application for a medical center. Group assignment for MOD003263.

## Purpose
This application has been designed and developed to support the Over Surgery's receptionists in their operational management duties, and retire the paper-based system currently in use. A brief selection of objectives it aims to provide include: 
- Improved data integrity
- Improved security of sensitive data access
- Intuitive UX for efficient and accurate interations and completion of user goals
- Enable the surgery to increase patient satisfaction by reducing waiting times, preventing double bookings, and improving availability and accuracy of information. 

## Functionality
- Secure login
- Check staff on duty and their availability 
- Register new patients
- Search for existing patient data with varying search criteria
- Manage appointments 
- Manage patient prescriptions 
- Check and print patient test results

## Using the Application
### Login 
**Username:** reception

**Password:** password

## Contributions
### Issues
- Give a suitable subject line, description, and regular updates. A template is provided. 
- Label all issues suitably
- If an issue can be assigned or claimed immediately, do so. Else, leave it unassigned for another team member to claim at the earliest convenience. 

### Branching
- Each issues gets its own branch. 
- Name the branch with the issue number, type, and the issue subject (eg. 2-bugfix-fixBrokenLink, 3-feature-addLogin)

### Nunit 
NUnit and NUnit3TestAdapter are used in this solution for Unit testing. The versions can be found in the packages.config file.

To have Visual Studio NuGet handle retreiving the packages for you, see the [official Microsoft Docs page for Installing and Reinstalling Packages with Package Restore](https://docs.microsoft.com/en-us/nuget/consume-packages/package-restore). Alternatively, see [Edward Wilde's StackOverflow answer](https://stackoverflow.com/questions/4978709/checking-in-packages-from-nuget-into-version-control/7619988#7619988) for extra NUnit tooling packages you might need (not in the packages config).

If you still can't get them to work, go `Tools` -> `NuGet Package Manager` -> `Manage NuGet Packages for Solution` and seatch for `NUnit` (this is NUnit 3) and `NUnit3TestAdapter`. 

When opening the solution, from the `.sln`, you may get a `NullReferenceException` in the Test Explorer when attempting to run the tests. If that's the case, follow the [simple solution here](https://developercommunity.visualstudio.com/content/problem/96181/test-explorer-fails-to-load-when-it-opens-with-the.html) which solved it for me. I'm yet to work out why this happens. 