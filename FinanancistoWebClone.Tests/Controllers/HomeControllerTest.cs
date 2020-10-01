using FinancistoCloneWeb.Controllers;
using FinancistoCloneWeb.Models;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanancistoWebClone.Tests.Controllers
{
    public class HomeControllerTest
    {
        [Test]
        public void IndexRetornaHolaMundoComoString()
        {
            var controller = new HomeController(null);
            var view = controller.Index();
            Assert.IsInstanceOf<ViewResult>(view);
        }

        [Test]
        public void CreateGuardaCorrectamenteConDatosValidos()
        {
            var account = new Account { Name = "Efectivo", Type = "Credito" };
            var controller = new HomeController(null);
            
            var result = controller.Create(account);
            Assert.IsInstanceOf<RedirectToActionResult>(result);
        }

        [Test]
        public void CreateFallaCuandoNoEnvioNombre()
        {
            var account = new Account { Name = null };
            var controller = new HomeController(null);

            var result = controller.Create(account);
            Assert.IsInstanceOf<ViewResult>(result);
        }

        [Test]
        public void BuscarEfectivoRetornaUnElemento()
        {
            var controller = new HomeController(null);
            var result = controller.BuscarPorNombre("Efectivo");

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(1, result[0].Id);
        }

        [Test]
        public void BuscarCreditoRetornaDosElementos()
        {
            var controller = new HomeController(null);
            var result = controller.BuscarPorNombre("Credito");

            Assert.AreEqual(2, result.Count);
        }

        [Test]
        public void BuscarCreditoConTildeRetornaDosElementos()
        {
            var controller = new HomeController(null);
            var result = controller.BuscarPorNombre("Crédito");

            Assert.AreEqual(2, result.Count);
        }
    }
}
