// <copyright file="BusinessTest.cs">Copyright ©  2016</copyright>

using System;
using CorreiosBusiness;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CorreiosBusiness.Tests
{
    [TestClass]
    [PexClass(typeof(Business))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class BusinessTest
    {

        [PexMethod]
        public void CodigoComComplexidadeSintomaticaAlta([PexAssumeUnderTest]Business target, string s)
        {
            target.CodigoComComplexidadeSintomaticaAlta(s);
            // TODO: add assertions to method BusinessTest.CodigoComComplexidadeSintomaticaAlta(Business, String)
        }
    }
}
