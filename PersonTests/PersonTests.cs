using System.Collections.Generic;
using System.Linq;
using Xunit;

using Domain;
using System;

namespace PersonTests
{
    public class PersonTests
    {
        [Fact]
        public void IsstringInterpolationCorrect()
        {
            // Arrange
            var p = new Person("Adam", "Freeman" );

            // Act
            string FullName = p.GetName();

            //TODO: Implement GetName() with the use of string interpolation so the test succeeds
            //Assert
            Assert.Equal("FirstName: Adam, LastName: Freeman", FullName);
        }


        [Fact]
        public void IsAutoImplementedPropertyInitializersCorrectlyImplemented()
        {
            // Arrange
            var Jane = new Person("Jane","King");
            var Dave = new Person("Dave","Freeman");

            // Act
            Jane.City = "Amsterdam";

            //Assert
            Assert.Equal("Amsterdam", Jane.City);
            // TODO: Use Auto-implemented Property Initializers for City to succeed test
            Assert.Equal("Rotterdam", Dave.City);

        }

        [Fact]
        public void IsConditionalAndCoalescingOperatorsCorrecltyImplemented()
        {
            // Arrange
            var Jane = new Person("Jane","King");

            // Act
            string RelatedName = Jane.GetRelatedName();

            //Assert
            // TODO: Use conditional and coalescing operators to succeed test
            Assert.Equal("None", RelatedName);
        }

        [Fact]
        public void IsInterpolationWithFormatingCorrectlyImplemented()
        {
            // Arrange
            var Jane = new Person("Jane", "King");
            Jane.Salary = 1275.55M;

            // Act
            string SalaryText = Jane.GetSalaryAsString();

            // Use String interpolation to format the Salary value as a value with one decimal digit to succeed test
            //Assert
            Assert.Equal("Salary is: ? 1.275,6", SalaryText);
        }

        [Fact]
        public void IsBornAfter2000ImplementedCorrectly()
        {
            // Arrange
            var person1 = new Person("Jane", "King");
            var person2 = new Person("Anne", "King");
            var person3 = new Person("Albert", "King");

            person1.DateOfBirth = new DateTime(1990, 01, 23);
            person2.DateOfBirth = new DateTime(2000, 01, 23);
            person3.DateOfBirth = new DateTime(2003, 01, 23);

            // TODO: Use an extension method IsBornAfter2000() to succeed these tests

            //Assert
            Assert.Fail("Deze assert weghalen na implementatie van IsBornAfter2000()");
            //Assert.False(person1.IsBornAfter2000());
            //Assert.True(person2.IsBornAfter2000());
            //Assert.True(person3.IsBornAfter2000());

        }

        [Fact]
        public void IsGetBirthDateFormattedImplementedCorrectly()
        {
            // Arrange
            var person1 = new Person("Jane", "King");
            person1.DateOfBirth = new DateTime(1990, 1, 23);

            // Assert
            Assert.Fail("Deze assert weghalen na implementatie van GetBirthDateFormatted()");
            // TODO: implement an extension method GetBirthDateFormatted() to succeed this test
            //Assert.Equal("23-01-1990", person1.GetBirthDateFormatted());
        }


        [Fact]
        public void IsGetAllHobbiesWithBallImplementedCorrectly()
        {
            // Arrange
            var person1 = new Person("Jane", "King");
            person1.Hobbies =  new string[] { "Basketball", "Swimming", "Running", "Baseball", "Football"};

            // Act
            // TODO: Implemented an extension method GetAllHobbiesWithBall() with filter to succeed this test
            //var hobbies = person1.GetAllHobbiesWithBall();
            
            // Assert
            Assert.Fail("Deze assert weghalen na implementatie van GetAllHobbiesWithBall()");
           // Assert.Equal(3, hobbies.Count());
           // Assert.Contains("Basketball", hobbies);
           // Assert.Contains("Baseball", hobbies);
           // Assert.Contains("Football", hobbies);
        }

        [Fact]
        public void IsGetAllHobbiesWithBallLINQImplementedCorrectly()
        {
            // Arrange
            var person1 = new Person("Jane", "King");
            person1.Hobbies = new string[] { "Basketball", "Swimming", "Running", "Baseball", "Football" };

            // Act
            // TODO: Implemented LINQ query to get all hobbies with 'ball' in the name to succeed this test
            string[] hobbies = null;

            // Assert
            Assert.Fail("Deze assert weghalen nadat hobbies correct gevuld is");
            // Assert.Equal(3, hobbies.Count());
            // Assert.Contains("Basketball", hobbies);
            // Assert.Contains("Baseball", hobbies);
            // Assert.Contains("Football", hobbies);
        }

        [Fact]
        public void IsUnionOfHobbiesImplementedCorrectly()
        {
            // Arrange
            var person1 = new Person("Jane", "King");
            person1.Hobbies = new string[] { "Basketball", "Swimming" };

            var person2 = new Person("Albert", "King");
            person2.Hobbies = new string[] { "Running", "Swimming" };

            // Act
            // TODO: Implemented LINQ query to get all hobbies of both  persons to succeed this test
            //var hobbiesUnion = null;

            // Assert
            Assert.Fail("Deze assert weghalen nadat hobbiesUnion correct gevuld is");
            // Assert.Equal(3, hobbiesUnion.Count());
            // Assert.Contains("Basketball", hobbiesUnion);
             //Assert.Contains("Swimming", hobbiesUnion);
             //Assert.Contains("Running", hobbiesUnion);
        }

        [Fact]
        public void IsGetAllHobbiesLambdaUppercaseImplementedCorrectly()
        {
            // Arrange
            var person1 = new Person("Jane", "King");
            person1.Hobbies = new string[] { "Basketball", "Swimming" };


            // TODO: Use a lambda expression to uppercase the hobbies to succeed the tests
            string[] hobbiesAltered = null;
            // Assert
            Assert.Fail("Deze assert weghalen nadat hobbiesAltered correct gevuld is");
             //Assert.Equal(2, hobbiesAltered.Count());
             //Assert.Contains("BASKETBALL", hobbiesAltered);
             //Assert.Contains("SWIMMING", hobbiesAltered);

        }

        [Fact]
        public void IsGetOrderByBirthyearBallLambdaImplementedCorrectly()
        {
            // Arrange
            var person1 = new Person("Jane", "King");
            var person2 = new Person("Anne", "King");
            var person3 = new Person("Albert", "King");

            person1.DateOfBirth = new DateTime(1990, 01, 23);
            person2.DateOfBirth = new DateTime(2000, 01, 23);
            person3.DateOfBirth = new DateTime(2003, 01, 23);

            Person[] persons = { person1, person2, person3 };

            // TODO: use a lambda query to order the list by birthdate to succeed the tests
            // Act
            Person[] orderedPersons = null;

            var person1Ordered = orderedPersons.ElementAt(0); 
            var person2Ordered = orderedPersons.ElementAt(1);
            var person3Ordered = orderedPersons.ElementAt(2);
            // Assert
            
            Assert.Equal(2000, person1Ordered.DateOfBirth.Year);
            Assert.Equal(2003, person2Ordered.DateOfBirth.Year);
            Assert.Equal(2012, person3Ordered.DateOfBirth.Year);

        }


        [Fact]
        public void IsCorrectCountOfPersonsWithOddNumbersCalculated()
        {
            // Arrange
            var person1 = new Person("Jane", "King");
            var person2 = new Person("Anne", "King");
            var person3 = new Person("Albert", "King");

            person1.CountChildren = 5;
            person2.CountChildren = 4;
            person3.CountChildren = 1;

            Person[] persons = { person1, person2, person3 };

            //TODO: use LINQ to count the persons where CountChildren is an odd number to succeed the test
            int oddNumbers = 0;

            Assert.Equal(2, oddNumbers);
        }

        [Fact]
        public void IsCorrectAverageOfChildrenCalculated()
        {
            // Arrange
            var person1 = new Person("Jane", "King");
            var person2 = new Person("Anne", "King");
            var person3 = new Person("Albert", "King");

            person1.CountChildren = 5;
            person2.CountChildren = 4;
            person3.CountChildren = 0;

            Person[] persons = { person1, person2, person3 };

            // Act
            //TODO: use LINQ to count the persons average children  to succeed the test
            //double average = null;

            // Assert
            Assert.Fail("Deze assert weghalen als average correct gevuld is");
            //Assert.Equal(3, average);
        }


        [Fact]
        public void IsCorrectPersonsWithFirstNameStartWithTCalculated()
        {
            // Arrange
            var person1 = new Person("Tessa", "Jansen");
            var person2 = new Person("Tristan", "Jansen");
            var person3 = new Person("Chris", "Jansen");
            var person4 = new Person("Adri", "Jansen");

            Person[] persons = { person1, person2, person3, person4 };

            //TODO: use LINQ query to retrieve the persons with FirstName starting with a T to succeed the test
            // Act
            IEnumerable<Person> querySyntax = null; 

            Assert.Equal(2, querySyntax.Count());
            Assert.Contains(person1, querySyntax);
            Assert.Contains(person2, querySyntax);
            Assert.DoesNotContain(person3, querySyntax);
            Assert.DoesNotContain(person4, querySyntax);
        }

        [Fact]
        public void IsCorrecFirstPersonsWithFirstNameStartWithTCalculated()
        {
            // Arrange
            var person1 = new Person("Tessa", "Jansen");
            var person2 = new Person("Tristan", "Jansen");
            var person3 = new Person("Chris", "Jansen");
            var person4 = new Person("Adri", "Jansen");

            Person[] persons = { person1, person2, person3, person4 };

            //TODO: Use LINQ to retrieve first person who's name starts with a T to succeed the test
            Person querySyntax = null;

            Assert.Equal(person1, querySyntax);

        }

        [Fact]
        public void IsExceptionThrownWhenDoubleNames()
        {
            // Arrange
            var person1 = new Person("Tessa", "Jansen");
            var person2 = new Person("Tristan", "Jansen");
            var person3 = new Person("Tessa", "Jansen");
            var person4 = new Person("Adri", "Jansen");

            Person[] persons = { person1, person2, person3, person4 };

            var exceptionHasBeenThrown = false;

            try
            {
                // Act
                //TODO: Use LINQ to retrieve the Single only person who's name starts with a T 
                Person querySyntax = null;
            }
            catch (InvalidOperationException)
            {
                exceptionHasBeenThrown = true;
            }

            // Assert
            Assert.True(exceptionHasBeenThrown);

        }

        [Fact]
        public void IsExceptionThrownWhenDateOfBirthIsAfterNow()
        {
            // Arrange
            var exceptionHasBeenThrown = false;

            var person = new Person("Kitty", "Alberts");

            try
            {
                // Act
                // TODO: implement method SetDateOfBirth() that throws exception when dateofbirth is after today/now
                //person.SetDateOfBirth(DateTime.Now.AddDays(4));

            }
            catch (InvalidOperationException)
            {
                exceptionHasBeenThrown = true;
            }

            // Assert
            Assert.True(exceptionHasBeenThrown);
        }

        [Fact]
        public void IsNoExceptionThrownWhenDateOfBirthIsBeforeNow()
        {
            // Arrange
            var exceptionHasBeenThrown = false;

            var person = new Person("Kitty", "Alberts");

            try
            {
                // Act
                // TODO: implement method SetDateOfBirth() that throws no exception when dateofbirth is before today/now (see previous test)
                //person.SetDateOfBirth(DateTime.Now.AddDays(-5));

            }
            catch (InvalidOperationException)
            {
                exceptionHasBeenThrown = true;
            }

            // Assert
            Assert.Fail("Deze assert weghalen als SetDateOfBirth geimplementeerd is");
            Assert.False(exceptionHasBeenThrown);
        }


        [Fact]
            public void IsExceptionThrownWhenReadOnlyPropertyIsSet()
            {
                // Arrange
                var exceptionHasBeenThrown = false;

                var person = new Person("Kitty","Alberts");

                try
                {
                    // Act

                    // After modifying the code, you can delete the test
                    //person.LastName = "Jansen";

                }
                catch (InvalidOperationException)
                {
                    exceptionHasBeenThrown = true;
                }

                // Assert
                Assert.True(exceptionHasBeenThrown);
            }
        }
}
