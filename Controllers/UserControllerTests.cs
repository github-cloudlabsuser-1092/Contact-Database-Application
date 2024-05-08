using NUnit.Framework;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using YourNamespace.Controllers; // Replace with your actual namespace
using YourNamespace.Models; // Replace with your actual namespace

[TestFixture]
public class UserControllerTests
{
    private Mock<List<User>> _mockUserList;
    private UserController _controller;

    [SetUp]
    public void Setup()
    {
        _mockUserList = new Mock<List<User>>();
        _controller = new UserController(_mockUserList.Object);
    }
    [Test]
    public void Index_ReturnsViewWithUserList()
    {
        var result = _controller.Index() as ViewResult;
        var model = result.Model as List<User>;

        Assert.AreEqual(_userList, model);
    }

        [Test]
    public void Details_ReturnsViewWithCorrectUser()
    {
        var result = _controller.Details(1) as ViewResult;
        var model = result.Model as User;

        Assert.AreEqual(_userList[0], model);
    }
    [Test]
    public void Details_ReturnsViewWithCorrectUser()
    {
        var result = _controller.Details(1) as ViewResult;
        var model = result.Model as User;

        Assert.AreEqual(_userList[0], model);
    }

    [Test]
    public void Details_ReturnsViewWithCorrectUser()
    {
        var result = _controller.Details(1) as ViewResult;
        var model = result.Model as User;

        Assert.AreEqual(_userList[0], model);
    }

        [Test]
    public void Edit_Get_ReturnsViewWithCorrectUser()
    {
        var result = _controller.Edit(1) as ViewResult;
        var model = result.Model as User;

        Assert.AreEqual(_userList[0], model);
    }

    [Test]
    public void Edit_Post_UpdatesUserInList()
    {
        var updatedUser = new User { Id = 1, Name = "Updated User" };

        _controller.Edit(1, updatedUser);

        Assert.AreEqual(updatedUser.Name, UserController.userlist[0].Name);
    }

    [Test]
    public void Delete_RemovesUserFromUserList_ReturnsViewWithUser()
    {
        var user = new User { Id = 1, Name = "Test User" };
        _mockUserList.Setup(m => m.FirstOrDefault(u => u.Id == user.Id)).Returns(user);

        var result = _controller.Delete(user.Id) as ViewResult;

        _mockUserList.Verify(m => m.Remove(user), Times.Once);
        Assert.AreEqual(user, result.Model);
    }

        [Test]
    public void Delete_Get_ReturnsViewWithCorrectUser()
    {
        var result = _controller.Delete(1) as ViewResult;
        var model = result.Model as User;

        Assert.AreEqual(_userList[0], model);
    }

    [Test]
    public void Delete_Post_RemovesUserFromList()
    {
        _controller.Delete(1, new FormCollection());

        Assert.IsFalse(UserController.userlist.Any(u => u.Id == 1));
    }
}