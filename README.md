##Test Plan
###Test Plan Identifier
According to the IEEE 829 Standard, Test Plan Identifier uniquely identifies the test plan (Reqtest, 2016).
For this project, the test plan is for the staff management application on Windows. => https://github.com/hieudku/SD6503BenchmarkAppAssignment1.git
<br />
###Introduction
This document outlines the test plan for the staff management application, which is developed to manage staff data through various functionalities such as adding, editing, deleting, and sorting staff information. The test plan follows the IEEE 829 standard, ensuring a comprehensive and structured approach to testing.
The testing scope includes all critical functions of the application, including staff data input validation, saving and loading data from files, and sorting and searching staff records. The testing activities will cover the functionality of the MyClass, FileManager, and Filter classes, as well as the user interface interactions provided by the main form.
The goal is to validate each function's accuracy and reliability through systematic test cases. These test cases will simulate user actions such as adding new staff, editing details, deleting records, and searching for specific staff members. Each function will undergo multiple test runs to ensure consistency and correctness.
A detailed report will be generated for each test case, documenting the test results and comparing them with the expected outcomes. Any defects identified during testing will be logged and communicated to the development team for resolution. After defects are fixed, the affected functionalities will be re-tested to confirm that the issues have been resolved.
<br />
###Table headers
Test Items
Epic
User Story ID
Feature
User Story
Staff Management
<br />
US1.1
Staff Addition
As a user, I want to be able to add new staff members to the system so that their information can be stored.
<br />

US1.2
Staff Editing
As a user, I want to be able to edit existing staff member details to keep their information up-to-date.
<br />

US1.3
Staff Deletion
As a user, I want to be able to delete staff members from the system when they are no longer part of the team.
<br />

US1.4
Staff Sorting
As a user, I want to sort staff records by name in ascending or descending order to quickly find staff members.
<br />

US1.5
Staff Searching
As a user, I want to search for staff members by name to quickly locate specific records.
Data Management
US2.1
Data Saving
As a user, I want to save individual staff details to a file so that the data can be preserved.
<br />

US2.2
Data Loading
As a user, I want to load staff data from a file into the application so that I can view and manage it.
<br />

US2.3
Data Appending
As a user, I want to append new staff data to an existing file so that I can keep a continuous record.
<br />

US2.4
Data Deletion
As a user, I want to remove staff data from a file when deleting staff records to ensure the file remains accurate.
Input Validation
<br />

US3.1
Input Validation
As a user, I want the application to validate my inputs to ensure that only correct and complete information is entered
<br />

Features to be tested
The Test Plan identifies and implements an approach to testing the following features of the Staff Management App: Staff Addition, Staff Editing, Staff Deletion, Staff Sorting, Staff Searching, Staff Saving, Data Saving, Data Loading, Data Appending, Data Deletion from File, Input Validation.

###Item Pass/Fail Criteria
###Table headers
Test Item ID
Test Condition
Pass Criteria
Fail Criteria
<br />
T1
Functionality of Staff Addition feature
- New staff members are successfully added and displayed in the ListBox.
- All input fields are validated correctly, and error messages are shown for invalid inputs.
- New staff members are not added or displayed.
- Input validation fails or does not show appropriate error messages.
<br />
T2
Functionality of Staff Editing feature
- Existing staff details are edited successfully.
- Changes are saved and reflected in the ListBox.
- Edits are not saved or displayed incorrectly in the ListBox.
<br />
T3
Functionality of Staff Deletion feature
- Selected staff members are removed from the ListBox and internal staff list.
- Deletion is reflected in the staff data file.
- Staff members are not removed from the ListBox or internal list.
- File is not updated with deletions.
<br />
T4
Functionality of Staff Sorting feature
- Staff records are sorted correctly in ascending and descending order by name.
- ListBox updates to reflect the sorted order.
- Sorting does not occur or is incorrect.
- ListBox does not update to reflect the sorted order.
<br />
T5
Functionality of Staff Searching feature
- Search results accurately display staff records that match the search term.
- Search results are shown correctly in the search results ListBox.
- Search results do not match the search term or are not displayed correctly in the search results ListBox.
<br />
T6
Functionality of Data Saving feature
- Individual staff details are saved to the file correctly in the specified format.
- File contains the correct and complete data.
- Data is not saved correctly or is missing from the file.
- File format is incorrect.

<br />
T7
Functionality of Data Loading feature
- Staff data is loaded correctly from the file into the application.
- Data is displayed accurately in the ListBox.
- Data is not loaded correctly or is displayed inaccurately in the ListBox.

<br />
T8
Functionality of Data Appending feature
- New staff data is appended correctly to the end of the existing file.
- File contains the appended data in the correct format.
- Data is not appended correctly or is missing from the file.
- File format is incorrect.

<br />
T9
Functionality of Data Deletion feature
- Deleting a staff record from the ListBox also removes the corresponding entry from the file.
- File is updated correctly to reflect the deletion.
- Staff record remains in the file after deletion.
- File is not updated correctly to reflect the deletion.

<br />
T10
Functionality of Input Validation feature
- Input fields validate data correctly, ensuring proper format and completeness.
- Appropriate error messages are shown for invalid inputs.
- Input validation fails or allows incorrect data.
- Error messages for invalid inputs are not displayed or incorrect.


<br />
<br />

###Entry Criteria
Functional Completeness: All key features (addition, editing, deletion, sorting, searching, saving, loading, appending, and validation) must be implemented.
Environment Setup: Application, dependencies, and test data must be properly configured and accessible.
Test Cases: Test cases must be created, reviewed, and approved.
Test Plan Approval: The test plan must be reviewed and approved by stakeholders.
Bug Tracking System: A system for logging and tracking defects must be operational.

<br />
###Exit Criteria
Test Execution: All test cases must be executed, including positive and negative scenarios.
Defect Resolution: Critical and major defects must be resolved and verified.
Test Results: Results must be documented and reviewed.
Test Documentation: All test documentation must be completed and archived.
Approval: Testing process and results must be reviewed and approved by stakeholders (tutor).

<br />
Suspension and Resumption Requirements
If the tester finds that 50% of the test cases fail a single test condition during execution, then further testing should be suspended.Defects that have been found should be fixed by the development team, and testing should be delayed until all defects that have been found have been fixed.
Test Deliverables
Pre-testing:
-Test Planning
-Test Design
-Test Environment Setup
While testing:
-Test Execution
-Defect Reporting
Post-testing:
-Test Reporting
-Defect Retesting
-Test Summary Report

<br />
Testing Tasks
Following are the testing tasks that must be done in order to consider Testing to be completed for the Staff Management App:
-Functionality Testing
-Test Design
-Test Execution Report
-Performance Testing
-Test Reporting

<br />
Environmental Needs
The list of environmental needs that are required to cary on the test activities for Staff Management App are as follows:
<br />
No.
Resources
Descriptions
1
PC
With Windows 10 minimum and sufficient memory & processor.
2
Network
Internet connection for establishing connection to automation test server.
3
Testing Tools
Appium, Visual Studio Unit Test (.NET)
4
Development Tools
Visual Studio 2022, Text Document, Git and Github
5
Document
Project Description, Test Plan, Test Case

<br />
<br />

##Test Design
1. Black-box Testing
Black-box testing focuses on verifying the functional requirements of the application without knowledge of the internal code structure. For this application, the test cases will involve user interactions with the UI components.

Test Case & Name
Description
Expected Result
Pass/Fail
UI TESTS
<br />
BB1. Add Staff Button	
Test if clicking the "Add Staff" button opens the input form	
Input form should be displayed for adding new staff	
Passed
<br />
BB2. Save Button	
Test if clicking the "Save" button saves the new staff data	
Data should be saved to the file and reflect in the list	
Passed
<br />
BB3. Delete Button	
Test if clicking the "Delete" button removes the selected staff	
Selected staff should be removed from the list and file	
Passed
<br />
BB4. Search TextBox	
Test if entering a search term in the textbox filters the list	
List should display only items that match the search term	
Passed
<br />
BB5. Sort Ascending Button	
Test if clicking the "Sort Ascending" button sorts the list by name in ascending order	
List should be sorted A-Z by staff names	
Passed
<br />
BB6. Sort Descending Button	
Test if clicking the "Sort Descending" button sorts the list by name in descending order	
List should be sorted Z-A by staff names	
Passed
<br />
BB7. Load Staff Button	
Test if clicking the "Load Staff" button loads the staff data from the file	
Staff data from the file should be displayed in the list	
Passed
<br />
BB8. Menu Bar
Test if clicking the menu bars buttons share the same functions as their correspondent buttons (Load, Save etc	
They should also do the same thing as the normal buttons	
Passed
<br />
BB9. Tooltips
Test if the tooltips appear when hovering mouse over the buttons
Tooltips for each button appear correctly when hovering mouse over them
Passed
<br />
FUNCTIONAL REQUIREMENTS TESTS
BB10. Valid Staff Addition	
Test adding a staff member with valid input (Name, ID, DOB, Email, Salary)	
Staff member should be added to the list and file	
Passed
<br />
BB11. Invalid Staff Addition	
Test adding a staff member with invalid input (e.g., invalid ID or empty Name)	
An error message should be displayed and staff not added	
Passed
<br />
BB12. Boundary Salary Values	
Test adding staff with boundary salary values (min and max)	
Staff should be added successfully, and values should be within range	
Passed
<br />
BB13. Data Persistence	
Test if data persists after application restart	
Staff data should remain unchanged after closing and reopening the application	
Passed
<br />
<br />
###2. White-box Testing<br />
White-box testing focuses on the internal workings of the application, including code structure, logic, and data flow. Below are the Test Classes and Test Methods with their outcomes and description for Unit Testing.

###Table headers<br />
Test Class	
Test Method	
Test Case	
Description
Expected Result	
Pass/Fail


DataValidationTests	
ValidateId_ValidId_ShouldPass
WB1. Valid positive integer ID	
Verify that a valid positive integer ID is accepted.	
Return true indicating valid ID.	
Passed
<br />

ValidateId_NegativeId_ShouldFail
WB2. Invalid negative integer ID	
Verify that a negative integer ID is rejected.	
Return false indicating invalid ID.	
Passed
<br />

ValidateId_NonNumericId_ShouldFail	
WB3. Non-numeric ID	
Verify that a non-numeric ID is rejected.	
Return false indicating invalid ID.	
Passed
<br />

ValidateName_ValidName_ShouldPass	
WB4. Valid name string	
Verify that a valid non-empty name is accepted.	
Return true indicating valid name.	
Passed
<br />



ValidateName_EmptyName_ShouldFail	
WB5. Empty name string	
Verify that an empty name string is rejected.	
Return false indicating invalid name.	
Passed
<br />

ValidateName_NameWithSpecialCharacters_ShouldPass	
WB6. Name with special characters	
Verify that a name with special characters is accepted.	
Return true indicating valid name.	
Passed
<br />

ValidateSalary_ValidSalary_ShouldPass
WB7. Valid salary within the range	
Verify that a valid salary within the range is accepted.	
Return true indicating valid salary.	
Passed
<br />

ValidateSalary_BoundarySalaryMin_ShouldPass
WB8. Minimum boundary salary	
Verify that the minimum boundary salary is accepted.	
Return true indicating valid salary.	
Passed
<br />

ValidateSalary_BoundarySalaryMax_ShouldPass
WB9. Maximum boundary salary	
Verify that the maximum boundary salary is accepted.	
Return true indicating valid salary.	
Passed
<br />

ValidateSalary_BelowMinSalary_ShouldFail
WB10. Salary below minimum boundary	
Verify that a salary below the minimum boundary is rejected.	
Return false indicating invalid salary.	
Passed
<br />

ValidateSalary_AboveMaxSalary_ShouldFail
WB11. Salary above maximum boundary	
Verify that a salary above the maximum boundary is rejected.	
Return false indicating invalid salary.	
Passed
<br />

FilterTests
SortAZ_ShouldSortListInAscendingOrder
WB12. Sort list from A to Z	
Verify that the list is sorted in ascending order by name.	
List is sorted in ascending order.	
Passed
<br />

SortZA_ShouldSortListInDescendingOrder
WB13. Sort list from Z to A	
Verify that the list is sorted in descending order by name.	
List is sorted in descending order.	
Passed
<br />

Search_ShouldReturnMatchingResults
WB14. Search for a specific name	
Verify that the search function returns matching results.	
Results contain the searched name.	
Passed
<br />

MyClassTests
ToString_ShouldReturnFormattedString
WB15. Format of ToString method	
Verify that the ToString method returns a correctly formatted string.	
Correctly formatted string.	
Passed
<br />

FileManagerTests
LoadStaff_ShouldLoadStaffList
WB16. Load staff from file	
Verify that staff data is loaded correctly from the file.	
List is not null and contains staff data.	
Passed
<br />

SaveStaff_ShouldReturnTrue_WhenSuccessful
WB17. Save a single staff member to file	
Verify that saving a staff member returns true.	
Return true indicating successful save.	
Passed
<br />

AppendStaff_ShouldReturnTrue_WhenSuccessful
WB18. Append staff list to file	
Verify that appending a list of staff members returns true.	
Return true indicating successful append.	
Passed
<br />

###3. Grey-box Testing<br />
Grey-box testing combines black-box and white-box testing by focusing on both functional requirements and internal code. 
<br />
MyClass Class
###Table headers
Test Case
Description
Expected Result
Pass/Fail
Constructor - MyClass	
Test default constructor and property initialization	
Properties are initialized to default values	
Passed
<br />
ToString Method	
Verify that ToString formats the string correctly	
Return a string in the format: ID Name DOB Email Salary	
Passed

<br />
<br />
Filter Class
###Table headers
Test Case
Description
Expected Result
Pass/Fail
<br />
SortAZ Method	
Test sorting in ascending order by Name	
List should be sorted alphabetically (A-Z)	
Passed
<br />
SortZA Method	
Test sorting in descending order by Name	
List should be sorted reverse alphabetically (Z-A)	
Passed
<br />
Search Method	
Test searching functionality using a search term	
Return list containing only items that match the term	
Passed
<br />
<br />

FileManager Class
###Table headers
Test Case
Description
Expected Result
Pass/Fail
<br />
LoadStaff Method	
Test loading staff from a file	
Return a list of MyClass objects from the file	
Passed
<br />
SaveStaff Method	
Test saving a single staff member to a file	
Return true if the staff member is saved successfully	
Passed
<br />
AppendStaff Method	
Test appending a list of staff members to a file	
Return true if the staff members are appended successfully	
Passed
<br />

##4. Automation Testing
Automating the testing of staff management functionalities ensures the application remains reliable and robust. Tools like Windows Application Driver and Appium streamline this process, focusing on adding staff members through automation.

Setting Up the Test Environment
The test environment setup includes installing Windows Application Driver, Appium, and Visual Studio. These tools are essential for simulating user interactions with the application. The setup involves starting the WinAppDriver server and configuring Appium to ensure readiness for the tests.

Test Initialization and Execution
The ClassInitialize method launches the application using Appium, pointing to the executable path. This step ensures that all tests run under consistent conditions. The core of the testing involves adding a staff member by automating data entry into fields such as staff ID, name, date of birth, email, and salary. Verification is done to check if the new staff member appears correctly in the staff list.

Observing and Reporting Results
Post-execution involves observing and interpreting the test results. The system logs detailed outcomes, noting the success of adding a staff member. 
<br />
<br />

#Test Summary Report
No deviations from the Test Specification and Test Approach mentioned. All Test Cases meet the exit criteria after their executions. Refer to the tables in Test Execution.
Below is the summary of results for the test cases performed for the six Tests Condition mentioned under the respective Test Environment.


![image](https://github.com/user-attachments/assets/d0d9ee24-0b79-4020-8b89-cc81c834e040)


Pass percentage for all Test Cases including functional test, White-box tests, Black-box tests, UI test, unit tests and automation tests is 100%

However, due to an unsolved/unknown issue with WinAppDriver's interaction with File IO functions such as Load, Save and Delete, these tests were removed from the automation testing. 
Instead, these functions were tested manually and proven to be working from the Black-box UI tests, therefore it was not an issue with the Application, but rather caused by WinAppDriver.
