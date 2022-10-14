
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

namespace InternetBankingRESTfulService.Tests
{
    /// <summary>
    /// !!! WARNING 
    /// !!! Project structure test.
    /// !!! DON'T CHANGE IT! 
    /// !!! Changes may cause the solution to be rejected.
    /// </summary>
    public class InternetBankingRESTfulServiceWebStructureTest
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// !!! WARNING 
        /// !!! Project structure test.
        /// !!! DON'T CHANGE IT! 
        /// !!! Changes may cause the solution to be rejected.
        /// </summary>
        [Test]
        public void WebStructureTest()
        {
            
            Assembly assembly;
            Type type;
            Type methodReturnType;
            MethodInfo method;
            int methodsCount;
            ParameterInfo parameter;
            int parametersCount;
            int constructorsCount;
            List<string> constructorParameterNameTypeDictionary;
            ConstructorInfo constructor;
            int fieldsCount;
            FieldInfo field;
            Type fieldReturnType;
            PropertyInfo property;
            int propertiesCount;
            Type propertyReturnType;
            assembly = Assembly.Load(Decode("SW50ZXJuZXRCYW5raW5nUkVTVGZ1bFNlcnZpY2UuV2ViLCBWZXJzaW9uPTEuMC4wLjAsIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49bnVsbA==") /*"InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"*/ );
            Assert.IsNotNull(assembly, "Missing  InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("UHJvZ3JhbQ==") /*"Program"*/ );
                Assert.IsNotNull(type, "Missing assembly: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Program");
                    Assert.IsTrue(type.IsClass, "assembly: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Program is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Program is not public class");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("TWFpbg==") /*"Main"*/ );                            Assert.IsNotNull(method, "method: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Program.Main(String[] args) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Program.Main(String[] args) is not public");
                            Assert.IsTrue(method.IsStatic, "method: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Program.Main(String[] args) is not static");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Void",methodReturnType.FullName, "method: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Program.Main(String[] args) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Program.Main(String[] args) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("YXJncw==") /*"args"*/  && x.ParameterType.FullName == "System.String[]");
                                Assert.IsNotNull(parameter, "method: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Program.Main(String[] args) parameter args does not exists or does not have type System.String[]");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("Q3JlYXRlV2ViSG9zdEJ1aWxkZXI=") /*"CreateWebHostBuilder"*/ );                            Assert.IsNotNull(method, "method: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Program.CreateWebHostBuilder(String[] args) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Program.CreateWebHostBuilder(String[] args) is not public");
                            Assert.IsTrue(method.IsStatic, "method: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Program.CreateWebHostBuilder(String[] args) is not static");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("Microsoft.AspNetCore.Hosting.IWebHostBuilder",methodReturnType.FullName, "method: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Program.CreateWebHostBuilder(String[] args) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Program.CreateWebHostBuilder(String[] args) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("YXJncw==") /*"args"*/  && x.ParameterType.FullName == "System.String[]");
                                Assert.IsNotNull(parameter, "method: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Program.CreateWebHostBuilder(String[] args) parameter args does not exists or does not have type System.String[]");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Program() does not exists");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("U3RhcnR1cA==") /*"Startup"*/ );
                Assert.IsNotNull(type, "Missing assembly: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Startup");
                    Assert.IsTrue(type.IsClass, "assembly: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Startup is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Startup is not public class");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("Q29uZmlndXJlU2VydmljZXM=") /*"ConfigureServices"*/ );                            Assert.IsNotNull(method, "method: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Startup.ConfigureServices(IServiceCollection services) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Startup.ConfigureServices(IServiceCollection services) is not public");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Void",methodReturnType.FullName, "method: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Startup.ConfigureServices(IServiceCollection services) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Startup.ConfigureServices(IServiceCollection services) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("c2VydmljZXM=") /*"services"*/  && x.ParameterType.FullName == "Microsoft.Extensions.DependencyInjection.IServiceCollection");
                                Assert.IsNotNull(parameter, "method: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Startup.ConfigureServices(IServiceCollection services) parameter services does not exists or does not have type Microsoft.Extensions.DependencyInjection.IServiceCollection");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("Q29uZmlndXJl") /*"Configure"*/ );                            Assert.IsNotNull(method, "method: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Startup.Configure(IApplicationBuilder appIWebHostEnvironment env) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Startup.Configure(IApplicationBuilder appIWebHostEnvironment env) is not public");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Void",methodReturnType.FullName, "method: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Startup.Configure(IApplicationBuilder appIWebHostEnvironment env) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(2,parametersCount, "method: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Startup.Configure(IApplicationBuilder appIWebHostEnvironment env) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("YXBw") /*"app"*/  && x.ParameterType.FullName == "Microsoft.AspNetCore.Builder.IApplicationBuilder");
                                Assert.IsNotNull(parameter, "method: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Startup.Configure(IApplicationBuilder appIWebHostEnvironment env) parameter app does not exists or does not have type Microsoft.AspNetCore.Builder.IApplicationBuilder");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(2,parametersCount, "method: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Startup.Configure(IApplicationBuilder appIWebHostEnvironment env) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("ZW52") /*"env"*/  && x.ParameterType.FullName == "Microsoft.AspNetCore.Hosting.IWebHostEnvironment");
                                Assert.IsNotNull(parameter, "method: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Startup.Configure(IApplicationBuilder appIWebHostEnvironment env) parameter env does not exists or does not have type Microsoft.AspNetCore.Hosting.IWebHostEnvironment");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructorParameterNameTypeDictionary.Add("Microsoft.Extensions.Configuration.IConfiguration");
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Startup(IConfiguration configuration) does not exists");
                                parametersCount = constructor.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "constructor: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Startup(IConfiguration configuration)  parameters count has changed");
                                parameter = constructor.GetParameters().FirstOrDefault(x=>x.Name == Decode("Y29uZmlndXJhdGlvbg==") /*"configuration"*/  && x.ParameterType.FullName == "Microsoft.Extensions.Configuration.IConfiguration");
                                Assert.IsNotNull(parameter, "constructor: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Startup(IConfiguration configuration) parameter configuration does not exists or does not have type Microsoft.Extensions.Configuration.IConfiguration");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("Q29uZmlndXJhdGlvbg==") /*"Configuration"*/ );
                            Assert.IsNotNull(property, "property: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Startup.IConfiguration Configuration does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0NvbmZpZ3VyYXRpb24=") /*"get_Configuration"*/ );                                Assert.IsNotNull(method, "method: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Startup.get_Configuration() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Startup.get_Configuration() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("Microsoft.Extensions.Configuration.IConfiguration",methodReturnType.FullName, "method: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Startup.get_Configuration() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("Microsoft.Extensions.Configuration.IConfiguration",propertyReturnType.FullName, "property: InternetBankingRESTfulService.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Startup.IConfiguration Configuration  type has changed");


        }

        /// <summary>
        /// !!! WARNING 
        /// !!! Project structure test.
        /// !!! DON'T CHANGE IT! 
        /// !!! Changes may cause the solution to be rejected.
        /// </summary>
        private string Decode(string text)
        {
            return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(text));
        }
    }
}
