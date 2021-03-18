using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Tests.Mocks;

namespace PaymentContext.Tests
{
    [TestClass]
    public class SubscriptionHandlerTests
    {
        [TestMethod]
        public void ShouldReturnErrorWhenDocumentExists()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
            var command = new CreateBoletoSubscriptionCommand();

            command.FirstName = "Kayque";
            command.LastName = "Pereira";
            command.Document = "99999999999";
            command.Email = "kpere@gmail.com2";
            command.BarCode = "123465789";
            command.BoletoNumber = "123456789";
            command.PaymentNumber = "123456";
            command.PaidDate = DateTime.Now;
            command.ExpireDate = DateTime.Now.AddMonths(1);
            command.Total = 60;
            command.TotalPaid = 60;
            command.Payer = "KCORP";
            command.PayerDocument = "12345679811";
            command.PayerDocumentType = EDocumentType.CPF;
            command.Street = "ASDF";
            command.Number = "11";
            command.Neighborhood = "ASDF";
            command.City = "ASDF";
            command.State = "ASDF";
            command.Country = "ASDF";
            command.ZipCode = "ASDF";
            command.PayerEmail = "ASDF";

            handler.Handle(command);
            Assert.AreEqual(false, handler.IsValid);

        }
    }
}