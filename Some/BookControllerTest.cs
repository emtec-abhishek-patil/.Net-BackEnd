﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using Practice_Project.Context;
using Practice_Project.Controllers;
using Practice_Project.Functions;
using Practice_Project.Model;

namespace Some
{
    public class BookControllerTest
    {
        TestFunctions testFunctions;

        [SetUp]
        public void SetUp()
        {
            testFunctions = new TestFunctions();
        }

        [Test]
        public void FindByBookName_Works()
        {
            string name = "Some";
           var books = new List<Book>()
            {
                new Book{ Title="Some",studentId=2 },
                new Book{ Title="Abhi",studentId=1 },
                new Book{ Title="Java Programming",studentId=2 },
                new Book{ Title="Java",studentId=1 },
            };

            var filteredUser = testFunctions.FindByBookName(name, books);

            Assert.That(filteredUser, Is.EqualTo(books.Where( n => n.Title == name)));
        }

    }
}