using Microsoft.AspNetCore.Mvc.Testing;
using NUnit.Framework;
using System;
using System.Globalization;
using System.Threading.Tasks;

namespace InternetBankingRESTfulService.Tests
{
    public class ApiTest
    {
        [Test]
        public async Task TestApiVersion()
        {
            var factory = new WebApplicationFactory<Startup>();
            var Client = factory.CreateClient();
            var result = await Client.GetAsync("/bank/api/version");
            Assert.AreEqual(System.Net.HttpStatusCode.OK, result.StatusCode);
            var content = result.Content;
            var data = await content.ReadAsStringAsync();
            Assert.AreEqual($"{DateTime.UtcNow.ToString("yyyy.MM.dd", CultureInfo.InvariantCulture)}.1.0", data);
        }

        [Test]
        public async Task TestApiVersion_Second()
        {
            var factory = new WebApplicationFactory<Startup>();
            var Client = factory.CreateClient();
            var result = await Client.GetAsync("/bank/api-version");
            Assert.AreEqual(System.Net.HttpStatusCode.OK, result.StatusCode);
            var content = result.Content;
            var data = await content.ReadAsStringAsync();
            Assert.AreEqual($"{DateTime.UtcNow.ToString("yyyy.MM.dd", CultureInfo.InvariantCulture)}.1.0", data);
        }

        [Test]
        public async Task TestPasswordStrongIsFalse()
        {
            var factory = new WebApplicationFactory<Startup>();
            var Client = factory.CreateClient();
            var result = await Client.GetAsync($"/bank/api/password/strong/123");
            Assert.AreEqual(System.Net.HttpStatusCode.OK, result.StatusCode);
            var content = result.Content;
            var data = await content.ReadAsStringAsync();
            Assert.AreEqual("false", data);
        }

        [Test]
        public async Task TestPasswordStrongIsTrue()
        {
            var factory = new WebApplicationFactory<Startup>();
            var Client = factory.CreateClient();
            var result = await Client.GetAsync($"/bank/api/password/strong/ALhj89*19896");
            Assert.AreEqual(System.Net.HttpStatusCode.OK, result.StatusCode);
            var content = result.Content;
            var data = await content.ReadAsStringAsync();
            Assert.AreEqual("true", data);
        }

        [Test]
        public async Task CalculateMD5()
        {
            var factory = new WebApplicationFactory<Startup>();
            var Client = factory.CreateClient();
            var result = await Client.GetAsync($"/bank/api/calc/MD5/test-string-ABC");
            Assert.AreEqual(System.Net.HttpStatusCode.OK, result.StatusCode);
            var content = result.Content;
            var data = await content.ReadAsStringAsync();
            Assert.AreEqual("79C8DC4F3BAEBF0A4F40517225F41A86", data);
        }

        [Test]
        public async Task CalculateMD5_SecondURL()
        {
            var factory = new WebApplicationFactory<Startup>();
            var Client = factory.CreateClient();
            var result = await Client.GetAsync($"/bank/api/calc/test-string-ABC/MD5");
            Assert.AreEqual(System.Net.HttpStatusCode.OK, result.StatusCode);
            var content = result.Content;
            var data = await content.ReadAsStringAsync();
            Assert.AreEqual("79C8DC4F3BAEBF0A4F40517225F41A86", data);
        }
    }
}
