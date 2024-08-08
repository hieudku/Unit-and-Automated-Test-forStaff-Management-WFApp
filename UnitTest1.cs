using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium;
using SD6503BenchmarkAppAssignment1;
using System;
using System.Collections.Generic;
using System.IO;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SD6503BenchmarkAppUnitTests
{
    // Unit Tests
    [TestClass]
    public class DataValidationTests
    // Testing Data Validation for ID, Name, Salary
    {
        // ID test
        [TestMethod]
        // Valid case for ID - int
        public void ValidateId_ValidId_ShouldPass()
        {
            var result = ValidateId(123);
            Assert.IsTrue(result);
        }

        [TestMethod]
        // Invalid case for ID - negative number
        public void ValidateId_NegativeId_ShouldFail()
        {
            var result = ValidateId(-1);
            Assert.IsFalse(result);
        }

        [TestMethod]
        // Invalid case for ID - Non numeric characters
        public void ValidateId_NonNumericId_ShouldFail()
        {
            var result = ValidateId("ABC");
            Assert.IsFalse(result);
        }
        // Method to perform validation only if the input is valid
        private bool ValidateId(object id)
        {
            if (id is int intId)
            {
                return intId >= 0;
            }
            return false;
        }

        /*********************/
        // Name test
        [TestMethod]
        // Valid case for name - string
        public void ValidateName_ValidName_ShouldPass()
        {
            var result = ValidateName("John Doe");
            Assert.IsTrue(result);
        }

        [TestMethod]
        // Invalid case for name - empty input
        public void ValidateName_EmptyName_ShouldFail()
        {
            var result = ValidateName("");
            Assert.IsFalse(result);
        }

        [TestMethod]
        // Valid case for name - special character
        public void ValidateName_NameWithSpecialCharacters_ShouldPass()
        {
            var result = ValidateName("John@Doe");
            Assert.IsTrue(result);
        }

        // Method to perform validation only if the input is valid
        private bool ValidateName(string name)
        {
            // Replace with actual validation logic
            return !string.IsNullOrWhiteSpace(name);
        }

        /*********************/
        // Salary Test - Boundary Value Test
        // Constants defining the valid salary range
        private const decimal MinSalary = 30000m;
        private const decimal MaxSalary = 200000m;

        // Test case to verify that a valid salary within the range is accepted
        [TestMethod]
        public void ValidateSalary_ValidSalary_ShouldPass()
        {
            // Arrange
            decimal salary = 50000m;

            // Act
            var result = ValidateSalary(salary);

            // Assert
            Assert.IsTrue(result, "The salary should be valid and within the range.");
        }

        // Test case to verify that the minimum boundary salary is accepted
        [TestMethod]
        public void ValidateSalary_BoundarySalaryMin_ShouldPass()
        {
            // Arrange
            decimal salary = MinSalary;

            // Act
            var result = ValidateSalary(salary);

            // Assert
            Assert.IsTrue(result, "The minimum boundary salary should be valid.");
        }

        // Test case to verify that the maximum boundary salary is accepted
        [TestMethod]
        public void ValidateSalary_BoundarySalaryMax_ShouldPass()
        {
            // Arrange
            decimal salary = MaxSalary;

            // Act
            var result = ValidateSalary(salary);

            // Assert
            Assert.IsTrue(result, "The maximum boundary salary should be valid.");
        }

        // Test case to verify that a salary below the minimum boundary is rejected
        [TestMethod]
        public void ValidateSalary_BelowMinSalary_ShouldFail()
        {
            // Arrange
            decimal salary = 29000m;

            // Act
            var result = ValidateSalary(salary);

            // Assert
            Assert.IsFalse(result, "The salary below the minimum boundary should be invalid.");
        }

        // Test case to verify that a salary above the maximum boundary is rejected
        [TestMethod]
        public void ValidateSalary_AboveMaxSalary_ShouldFail()
        {
            // Arrange
            decimal salary = 210000m;

            // Act
            var result = ValidateSalary(salary);

            // Assert
            Assert.IsFalse(result, "The salary above the maximum boundary should be invalid.");
        }

        // Method to validate if a salary is within the acceptable range
        private bool ValidateSalary(decimal salary)
        {
            // Check if the salary is within the defined range
            return salary >= MinSalary && salary <= MaxSalary;
        }
    }


    [TestClass]
    // Filter Class Test
    public class FilterTests
    {
        private List<MyClass> testList;

        [TestInitialize]
        public void SetUp()
        {
            // Initialize a sample list of MyClass objects as each staff for testing 
            testList = new List<MyClass>
            {
                new MyClass { StaffId = 1, Name = "Alice", DateOfBirth = new DateTime(1985, 1, 1), Email = "alice@example.com", AnnualSalary = 50000m },
                new MyClass { StaffId = 2, Name = "Bob", DateOfBirth = new DateTime(1990, 2, 2), Email = "bob@example.com", AnnualSalary = 60000m },
                new MyClass { StaffId = 3, Name = "Charlie", DateOfBirth = new DateTime(1980, 3, 3), Email = "charlie@example.com", AnnualSalary = 70000m }
            };
        }

        [TestMethod]
        // Test method for sorting from A to Z by staff's name
        public void SortAZ_ShouldSortListInAscendingOrder()
        {
            // Arrange
            Filter filter = new Filter();

            // Act
            var sortedList = filter.SortAZ(testList);

            // Assert
            Assert.AreEqual("Alice", sortedList[0].Name);
            Assert.AreEqual("Bob", sortedList[1].Name);
            Assert.AreEqual("Charlie", sortedList[2].Name);
        }

        [TestMethod]
        // Test method for sorting from Z to A by staff's name
        public void SortZA_ShouldSortListInDescendingOrder()
        {
            // Arrange
            Filter filter = new Filter();

            // Act
            var sortedList = filter.SortZA(testList);

            // Assert
            Assert.AreEqual("Charlie", sortedList[0].Name);
            Assert.AreEqual("Bob", sortedList[1].Name);
            Assert.AreEqual("Alice", sortedList[2].Name);
        }

        [TestMethod]
        // Test method to return search result from given search term
        public void Search_ShouldReturnMatchingResults()
        {
            // Arrange
            Filter filter = new Filter();
            string searchTerm = "Bob";

            // Act
            var results = filter.Search(testList, searchTerm);

            // Assert
            Assert.AreEqual(1, results.Count);
            Assert.AreEqual("Bob", results[0].Name);
        }
    }

    [TestClass]
    // MyClass Tests
    public class MyClassTests
    {
        [TestMethod]
        // Test method to ensure the format of returned value is string for all members.
        public void ToString_ShouldReturnFormattedString()
        {
            // Arrange
            MyClass myClass = new MyClass
            {
                StaffId = 1,
                Name = "Alice",
                DateOfBirth = new DateTime(1985, 1, 1),
                Email = "alice@example.com",
                AnnualSalary = 50000m
            };

            // Act
            string result = myClass.ToString();

            // Assert
            Assert.AreEqual("1 Alice 01/01/1985 alice@example.com 50,000", result);
        }
    }

    [TestClass]
    // FileManager Class Tests
    public class FileManagerTests
    {
        [TestMethod]
        // Test method to ensure LoadStaff method load staff details properly
        public void LoadStaff_ShouldLoadStaffList()
        {
            // Arrange
            FileManager fileManager = new FileManager();

            // Act
            var staffList = fileManager.LoadStaff();

            // Assert
            Assert.IsNotNull(staffList);
            Assert.IsTrue(staffList.Count > 0);
        }

        [TestMethod]
        // Test method to ensure the most recent staff added are saved successfully into the list and text file.
        public void SaveStaff_ShouldReturnTrue_WhenSuccessful()
        {
            // Arrange
            FileManager fileManager = new FileManager();
            MyClass staff = new MyClass
            {
                StaffId = 4,
                Name = "David",
                DateOfBirth = new DateTime(1995, 5, 5),
                Email = "david@example.com",
                AnnualSalary = 75000m
            };
            string fileName = "testStaffData.txt";

            // Act
            bool result = fileManager.SaveStaff(staff, fileName);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        // Test method to ensure the next staff added to the list is at the end of the text file and list and display properly.
        public void AppendStaff_ShouldReturnTrue_WhenSuccessful()
        {
            // Arrange
            FileManager fileManager = new FileManager();
            List<MyClass> staffList = new List<MyClass>
            {
                new MyClass { StaffId = 5, Name = "Eve", DateOfBirth = new DateTime(2000, 6, 6), Email = "eve@example.com", AnnualSalary = 80000m }
            };

            // Act
            bool result = fileManager.AppendStaff(staffList);

            // Assert
            Assert.IsTrue(result);
        }
    }


    /************************************/
    // Automation Tests
    [TestClass]

    public class AutoTest
    {
        static WindowsDriver<WindowsElement> StaffAppSession;

        
        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            try
            {
                // Opening app once for auto testing using ClassInitialize and static method
                string exePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SD6503BenchmarkAppAssignment1.exe");
                AppiumOptions option = new AppiumOptions();
                option.AddAdditionalCapability("app", exePath);

                StaffAppSession = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723/"), option);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error during initialization: " + e.Message);
                throw;
            }
        }

        // ClassCleanup method after tests are done
        [ClassCleanup]
        public static void Cleanup()
        {
            if (StaffAppSession != null)
            {
                StaffAppSession.Quit();
                StaffAppSession = null;
            }
        }

        // Adding Staff Automation Test
        [TestMethod]
        public void TestAddStaff()
        {
            // Arrange app elements to match their Id(name) from the UI using find ID method
            var staffIdTextBox = StaffAppSession.FindElementByAccessibilityId("tbxID");
            var nameTextBox = StaffAppSession.FindElementByAccessibilityId("tbxName");
            var dobDatePicker = StaffAppSession.FindElementByAccessibilityId("dateSelect");
            var emailTextBox = StaffAppSession.FindElementByAccessibilityId("tbxEmail");
            var salaryTextBox = StaffAppSession.FindElementByAccessibilityId("tbxSalary");
            var addButton = StaffAppSession.FindElementByAccessibilityId("btnAdd");
            var staffListBox = StaffAppSession.FindElementByAccessibilityId("lstStaff");

            // Automatic Actions - Fill inputs into text box automatically
            staffIdTextBox.SendKeys("123");
            nameTextBox.SendKeys("John Doe");
            dobDatePicker.SendKeys("01/01/1990");
            emailTextBox.SendKeys("john.doe@example.com");
            salaryTextBox.SendKeys("50000");
            staffListBox.Click();
            addButton.Click();

            // Wait for the staff to be added and appear in the list box
            System.Threading.Thread.Sleep(1000);

            // Assert - check if staff is added using given strings
            var addedStaff = staffListBox.FindElementByName("123 John Doe 01/01/1990 john.doe@example.com 50,000");
            addedStaff.Click();

            // Assert - check if staff is added using given strings
            Assert.IsNotNull(addedStaff);
        }
    }

}
