using DogApi.Controllers;
using Domain;
using IBusinessLogic;
using Microsoft.AspNetCore.Mvc;
using Models.In;
using Models.Out;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogApiTest
{
    [TestClass]
    public class UserConrollerTest
    {
        private User _user;

        [TestInitialize]
        public void Setup()
        {
            _user = new User
            {
                Id = 3,
                Token = new Guid("C1B94565-BDF1-4C16-B890-2DD46328227A"),
                Email = "ort@gmail.com",
                Password = "123"
            };
        }
        //TODO lines 39 a 44
        [TestMethod]
        public void GetUserTokenOk()
        {
            UserLoginModelIn userCreateModel = new UserLoginModelIn() {Email = "ort@gmail.com", Password = "123"};
            UserLoginModelOut expectedResult = new UserLoginModelOut() {Token = _user.Token };
            var mockUserLogic = new Mock<IUserLogic>(MockBehavior.Strict);
            mockUserLogic.Setup(x => x.GetUserToken(It.IsAny<string>(), It.IsAny<string>())).Returns(_user.Token);
            var userController = new UserController(mockUserLogic.Object);

            var result = userController.GetUserToken(userCreateModel);
            var okResult = result as OkObjectResult;
            var content = okResult.Value as UserLoginModelOut;

            mockUserLogic.VerifyAll();
            Assert.AreEqual(expectedResult, content);
        }
    }
}
