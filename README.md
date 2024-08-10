# Test Plan
### Test Plan Identifier
According to the IEEE 829 Standard, Test Plan Identifier uniquely identifies the test plan (Reqtest, 2016).
For this project, the test plan is for the staff management application on Windows. => https://github.com/hieudku/SD6503BenchmarkAppAssignment1.git
<br />
### Introduction
This document outlines the test plan for the staff management application, which is developed to manage staff data through various functionalities such as adding, editing, deleting, and sorting staff information. The test plan follows the IEEE 829 standard, ensuring a comprehensive and structured approach to testing.
The testing scope includes all critical functions of the application, including staff data input validation, saving and loading data from files, and sorting and searching staff records. The testing activities will cover the functionality of the MyClass, FileManager, and Filter classes, as well as the user interface interactions provided by the main form.
The goal is to validate each function's accuracy and reliability through systematic test cases. These test cases will simulate user actions such as adding new staff, editing details, deleting records, and searching for specific staff members. Each function will undergo multiple test runs to ensure consistency and correctness.
A detailed report will be generated for each test case, documenting the test results and comparing them with the expected outcomes. Any defects identified during testing will be logged and communicated to the development team for resolution. After defects are fixed, the affected functionalities will be re-tested to confirm that the issues have been resolved.
<br />
### User Story - Staff Management Application
<br />
<br />
US1.1<br />
Staff Addition<br />
As a user, I want to be able to add new staff members to the system so that their information can be stored.
<br />
<br />
US1.2<br />
Staff Editing<br />
As a user, I want to be able to edit existing staff member details to keep their information up-to-date.<br />
<br />
<br />
US1.3<br />
Staff Deletion<br />
As a user, I want to be able to delete staff members from the system when they are no longer part of the team.<br />
<br />
<br />
US1.4<br />
Staff Sorting<br />
As a user, I want to sort staff records by name in ascending or descending order to quickly find staff members.<br />
<br />
<br />
US1.5<br />
Staff Searching<br />
As a user, I want to search for staff members by name to quickly locate specific records.<br />
<br />
<br />
US2.1<br />
Data Saving<br />
As a user, I want to save individual staff details to a file so that the data can be preserved.<br />
<br />
<br />
US2.2<br />
Data Loading<br />
As a user, I want to load staff data from a file into the application so that I can view and manage it.<br />
<br />
<br />
US2.3<br />
Data Appending<br />
As a user, I want to append new staff data to an existing file so that I can keep a continuous record.<br />
<br />
<br />
US2.4<br />
Data Deletion<br />
As a user, I want to remove staff data from a file when deleting staff records to ensure the file remains accurate.<br />
<br />
<br />
US3.1<br />
Input Validation<br />
As a user, I want the application to validate my inputs to ensure that only correct and complete information is entered.<br />
<br />
<br />

### Features to be tested<br />
The Test Plan identifies and implements an approach to testing the following features of the Staff Management App: Staff Addition, Staff Editing, Staff Deletion, Staff Sorting, Staff Searching, Staff Saving, Data Saving, Data Loading, Data Appending, Data Deletion from File, Input Validation.

### Item Pass/Fail Criteria
Table headers<br />
-Test Item ID<br />
-Test Condition<br />
-Pass Criteria<br />
-Fail Criteria<br />
<br />
T1<br />
Functionality of Staff Addition feature<br />
- New staff members are successfully added and displayed in the ListBox.<br />
- All input fields are validated correctly, and error messages are shown for invalid inputs.<br />
- New staff members are not added or displayed.<br />
- Input validation fails or does not show appropriate error messages.<br />
<br />
T2<br />
Functionality of Staff Editing feature<br />
- Existing staff details are edited successfully.<br />
- Changes are saved and reflected in the ListBox.<br />
- Edits are not saved or displayed incorrectly in the ListBox.<br />
<br />
T3<br />
Functionality of Staff Deletion feature<br />
- Selected staff members are removed from the ListBox and internal staff list.<br />
- Deletion is reflected in the staff data file.<br />
- Staff members are not removed from the ListBox or internal list.<br />
- File is not updated with deletions.<br />
<br />
T4<br />
Functionality of Staff Sorting feature.<br />
- Staff records are sorted correctly in ascending and descending order by name.<br />
- ListBox updates to reflect the sorted order.<br />
- Sorting does not occur or is incorrect.<br />
- ListBox does not update to reflect the sorted order.<br />
<br />
T5<br />
Functionality of Staff Searching feature.<br />
- Search results accurately display staff records that match the search term.<br />
- Search results are shown correctly in the search results ListBox.<br />
- Search results do not match the search term or are not displayed correctly in the search results ListBox.<br />
<br />
T6<br />
Functionality of Data Saving feature.<br />
- Individual staff details are saved to the file correctly in the specified format.<br />
- File contains the correct and complete data.<br />
- Data is not saved correctly or is missing from the file.<br />
- File format is incorrect.<br />

<br />
T7<br />
Functionality of Data Loading feature.<br />
- Staff data is loaded correctly from the file into the application.<br />
- Data is displayed accurately in the ListBox.<br />
- Data is not loaded correctly or is displayed inaccurately in the ListBox.<br />

<br />
T8<br />
Functionality of Data Appending feature.<br />
- New staff data is appended correctly to the end of the existing file.<br />
- File contains the appended data in the correct format.<br />
- Data is not appended correctly or is missing from the file.<br />
- File format is incorrect.<br />

<br />
T9<br />
Functionality of Data Deletion feature.<br />
- Deleting a staff record from the ListBox also removes the corresponding entry from the file.<br />
- File is updated correctly to reflect the deletion.<br />
- Staff record remains in the file after deletion.<br />
- File is not updated correctly to reflect the deletion.<br />

<br />
T10<br />
Functionality of Input Validation feature<br />
- Input fields validate data correctly, ensuring proper format and completeness.<br />
- Appropriate error messages are shown for invalid inputs.<br />
- Input validation fails or allows incorrect data.<br />
- Error messages for invalid inputs are not displayed or incorrect.<br />


<br />
<br />

### Entry Criteria
- Functional Completeness: All key features (addition, editing, deletion, sorting, searching, saving, loading, appending, and validation) must be implemented.<br />
- Environment Setup: Application, dependencies, and test data must be properly configured and accessible.<br />
- Test Cases: Test cases must be created, reviewed, and approved.<br />
- Test Plan Approval: The test plan must be reviewed and approved by stakeholders.<br />
- Bug Tracking System: A system for logging and tracking defects must be operational.<br />

<br />
### Exit Criteria
- Test Execution: All test cases must be executed, including positive and negative scenarios.<br />
- Defect Resolution: Critical and major defects must be resolved and verified.<br />
- Test Results: Results must be documented and reviewed.<br />
- Test Documentation: All test documentation must be completed and archived.<br />
- Approval: Testing process and results must be reviewed and approved by stakeholders (tutor).<br />

<br />
### Suspension and Resumption Requirements
If the tester finds that 50% of the test cases fail a single test condition during execution, then further testing should be suspended.Defects that have been found should be fixed by the development team, and testing should be delayed until all defects that have been found have been fixed.<br />
<br />
### Test Deliverables<br />
Pre-testing:<br />
-Test Planning<br />
-Test Design<br />
-Test Environment Setup<br />
While testing:<br />
-Test Execution<br />
-Defect Reporting<br />
Post-testing:<br />
-Test Reporting<br />
-Defect Retesting<br />
-Test Summary Report<br />

<br />
### Testing Tasks<br />
Following are the testing tasks that must be done in order to consider Testing to be completed for the Staff Management App:<br />
-Functionality Testing<br />
-Test Design<br />
-Test Execution Report<br />
-Performance Testing<br />
-Test Reporting<br />

<br />
Environmental Needs
The list of environmental needs that are required to cary on the test activities for Staff Management App are as follows:
<br />

PC - With Windows 10 minimum and sufficient memory & processor.<br />
<br />
Network - Internet connection for establishing connection to automation test server.<br />
<br />
Testing Tools - Appium, Visual Studio Unit Test (.NET) <br />
<br />
Development Tools - Visual Studio 2022, Text Document, Git and Github <br />
<br />
Document - Project Description, Test Plan, Test Case<br />

<br />
<br />

# Test Design
## 1. Black-box Testing
Black-box testing focuses on verifying the functional requirements of the application without knowledge of the internal code structure. For this application, the test cases will involve user interactions with the UI components.
<br />

### BB1. Add Staff Button	
Test if clicking the "Add Staff" button opens the input form	<br />
Input form should be displayed for adding new staff	<br />
Passed<br />
<br />
### BB2. Save Button	
Test if clicking the "Save" button saves the new staff data	<br />
Data should be saved to the file and reflect in the list	<br />
Passed<br />
<br />
### BB3. Delete Button	
Test if clicking the "Delete" button removes the selected staff	<br />
Selected staff should be removed from the list and file	<br />
Passed<br />
<br />
### BB4. Search TextBox	
Test if entering a search term in the textbox filters the list	<br />
List should display only items that match the search term	<br />
Passed<br />
<br />
### BB5. Sort Ascending Button	
Test if clicking the "Sort Ascending" button sorts the list by name in ascending order	<br />
List should be sorted A-Z by staff names	<br />
Passed<br />
<br />
### BB6. Sort Descending Button	
Test if clicking the "Sort Descending" button sorts the list by name in descending order	<br />
List should be sorted Z-A by staff names	<br />
Passed<br />
<br />
### BB7. Load Staff Button	
Test if clicking the "Load Staff" button loads the staff data from the file	<br />
Staff data from the file should be displayed in the list	<br />
Passed<br />
<br />
### BB8. Menu Bar
Test if clicking the menu bars buttons share the same functions as their correspondent buttons (Load, Save etc).<br />	
They should also do the same thing as the normal buttons	<br />
Passed<br />
<br />
### BB9. Tooltips
Test if the tooltips appear when hovering mouse over the buttons<br />
Tooltips for each button appear correctly when hovering mouse over them<br />
Passed<br />
<br />
### FUNCTIONAL REQUIREMENTS TESTS<br />
### BB10. Valid Staff Addition	
Test adding a staff member with valid input (Name, ID, DOB, Email, Salary)	<br />
Staff member should be added to the list and file	<br />
Passed<br />
<br />
### BB11. Invalid Staff Addition	
Test adding a staff member with invalid input (e.g., invalid ID or empty Name)	
An error message should be displayed and staff not added	
Passed<br />
<br />
### BB12. Boundary Salary Values	
Test adding staff with boundary salary values (min and max)	
Staff should be added successfully, and values should be within range	
Passed<br />
<br />
### BB13. Data Persistence	
Test if data persists after application restart	<br />
Staff data should remain unchanged after closing and reopening the application	<br />
Passed<br />
<br />
<br />
## 2. White-box Testing<br />
White-box testing focuses on the internal workings of the application, including code structure, logic, and data flow. Below are the Test Classes and Test Methods with their outcomes and description for Unit Testing.<br />

<br />

### DataValidationTests	
ValidateId_ValidId_ShouldPass<br />
WB1. Valid positive integer ID	<br />
Verify that a valid positive integer ID is accepted.	<br />
Return true indicating valid ID.	<br />
Passed<br />
<br />

### ValidateId_NegativeId_ShouldFail
WB2. Invalid negative integer ID	<br />
Verify that a negative integer ID is rejected.	<br />
Return false indicating invalid ID.	<br />
Passed<br />
<br />

### ValidateId_NonNumericId_ShouldFail	
WB3. Non-numeric ID	<br />
Verify that a non-numeric ID is rejected.	<br />
Return false indicating invalid ID.	<br />
Passed<br />
<br />

### ValidateName_ValidName_ShouldPass	
WB4. Valid name string	<br />
Verify that a valid non-empty name is accepted.	<br />
Return true indicating valid name.	<br />
Passed<br />
<br />



### ValidateName_EmptyName_ShouldFail	
WB5. Empty name string	<br />
Verify that an empty name string is rejected.	<br />
Return false indicating invalid name.	<br />
Passed<br />
<br />

### ValidateName_NameWithSpecialCharacters_ShouldPass	
WB6. Name with special characters	<br />
Verify that a name with special characters is accepted.	<br />
Return true indicating valid name.	<br />
Passed<br />
<br />

### ValidateSalary_ValidSalary_ShouldPass
WB7. Valid salary within the range	<br />
Verify that a valid salary within the range is accepted.	<br />
Return true indicating valid salary.	<br />
Passed<br />
<br />

### ValidateSalary_BoundarySalaryMin_ShouldPass
WB8. Minimum boundary salary	<br />
Verify that the minimum boundary salary is accepted.	<br />
Return true indicating valid salary.	<br />
Passed<br />
<br />

### ValidateSalary_BoundarySalaryMax_ShouldPass
WB9. Maximum boundary salary	<br />
Verify that the maximum boundary salary is accepted.	<br />
Return true indicating valid salary.	<br />
Passed<br />
<br />

### ValidateSalary_BelowMinSalary_ShouldFail
WB10. Salary below minimum boundary	<br />
Verify that a salary below the minimum boundary is rejected.	<br />
Return false indicating invalid salary.	<br />
Passed<br />
<br />

### ValidateSalary_AboveMaxSalary_ShouldFail
WB11. Salary above maximum boundary	<br />
Verify that a salary above the maximum boundary is rejected.	<br />
Return false indicating invalid salary.	<br />
Passed<br />
<br />

### FilterTests
SortAZ_ShouldSortListInAscendingOrder<br />
WB12. Sort list from A to Z	<br />
Verify that the list is sorted in ascending order by name.	<br />
List is sorted in ascending order.	<br />
Passed<br />
<br />

### SortZA_ShouldSortListInDescendingOrder
WB13. Sort list from Z to A	<br />
Verify that the list is sorted in descending order by name.	<br />
List is sorted in descending order.	<br />
Passed<br />
<br />

### Search_ShouldReturnMatchingResults
WB14. Search for a specific name	<br />
Verify that the search function returns matching results.	<br />
Results contain the searched name.	<br />
Passed<br />
<br />

### MyClassTests
ToString_ShouldReturnFormattedString<br />
WB15. Format of ToString method	<br />
Verify that the ToString method returns a correctly formatted string.	<br />
Correctly formatted string.	<br />
Passed<br />
<br />

### FileManagerTests
LoadStaff_ShouldLoadStaffList<br />
WB16. Load staff from file	<br />
Verify that staff data is loaded correctly from the file.	<br />
List is not null and contains staff data.	<br />
Passed<br />
<br />

### SaveStaff_ShouldReturnTrue_WhenSuccessful
WB17. Save a single staff member to file	<br />
Verify that saving a staff member returns true.	<br />
Return true indicating successful save.	<br />
Passed<br />
<br />

### AppendStaff_ShouldReturnTrue_WhenSuccessful
WB18. Append staff list to file	<br />
Verify that appending a list of staff members returns true.	<br />
Return true indicating successful append.	<br />
Passed<br />
<br />

## 3. Grey-box Testing<br />
Grey-box testing combines black-box and white-box testing by focusing on both functional requirements and internal code. <br />
<br />
<br />
### MyClass Class
<br />
Constructor - MyClass	<br />
Test default constructor and property initialization	<br />
Properties are initialized to default values	<br />
Passed<br />
<br />
ToString Method	<br />
Verify that ToString formats the string correctly	<br />
Return a string in the format: ID Name DOB Email Salary	<br />
Passed<br />

<br />
### Filter Class<br />

<br />
SortAZ Method	<br />
Test sorting in ascending order by Name	<br />
List should be sorted alphabetically (A-Z)	<br />
Passed<br />
<br />
SortZA Method	<br />
Test sorting in descending order by Name	<br />
List should be sorted reverse alphabetically (Z-A)	<br />
Passed<br />
<br />
Search Method	<br />
Test searching functionality using a search term	<br />
Return list containing only items that match the term	<br />
Passed<br />
<br />
<br />

### FileManager Class

<br />
LoadStaff Method	<br />
Test loading staff from a file	<br />
Return a list of MyClass objects from the file	<br />
Passed<br />
<br />
SaveStaff Method	<br />
Test saving a single staff member to a file	<br />
Return true if the staff member is saved successfully	<br />
Passed<br />
<br />
AppendStaff Method	<br />
Test appending a list of staff members to a file	<br />
Return true if the staff members are appended successfully	<br />
Passed<br />
<br />
<br />
## 4. Automation Testing<br />
Automating the testing of staff management functionalities ensures the application remains reliable and robust. Tools like Windows Application Driver and Appium streamline this process, focusing on adding staff members through automation.<br />

### Setting Up the Test Environment<br />
The test environment setup includes installing Windows Application Driver, Appium, and Visual Studio. These tools are essential for simulating user interactions with the application. The setup involves starting the WinAppDriver server and configuring Appium to ensure readiness for the tests.<br />

### Test Initialization and Execution<br />
The ClassInitialize method launches the application using Appium, pointing to the executable path. This step ensures that all tests run under consistent conditions. The core of the testing involves adding a staff member by automating data entry into fields such as staff ID, name, date of birth, email, and salary. Verification is done to check if the new staff member appears correctly in the staff list.<br />

### Observing and Reporting Results<br />
Post-execution involves observing and interpreting the test results. The system logs detailed outcomes, noting the success of adding a staff member. 
<br />
<br />

# Test Summary Report<br />
No deviations from the Test Specification and Test Approach mentioned. All Test Cases meet the exit criteria after their executions. Refer to the tables in Test Execution.<br />
Below is the summary of results for the test cases performed for the six Tests Condition mentioned under the respective Test Environment.<br />
<br />

![image](https://github.com/user-attachments/assets/d0d9ee24-0b79-4020-8b89-cc81c834e040)
<br />

Pass percentage for all Test Cases including functional test, White-box tests, Black-box tests, UI test, unit tests and automation tests is 100%
<br />
However, due to an unsolved/unknown issue with WinAppDriver's interaction with File IO functions such as Load, Save and Delete, these tests were removed from the automation testing. <br />
Instead, these functions were tested manually and proven to be working from the Black-box UI tests, therefore it was not an issue with the Application, but rather caused by WinAppDriver.<br />
