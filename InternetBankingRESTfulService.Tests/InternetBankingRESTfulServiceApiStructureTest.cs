
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
    public class InternetBankingRESTfulServiceApiStructureTest
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
        public void ApiStructureTest()
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
            assembly = Assembly.Load(Decode("SW50ZXJuZXRCYW5raW5nUkVTVGZ1bFNlcnZpY2UuQXBpLCBWZXJzaW9uPTEuMC4wLjAsIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49bnVsbA==") /*"InternetBankingRESTfulService.Api, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"*/ );
            Assert.IsNotNull(assembly, "Missing  InternetBankingRESTfulService.Api, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("SUludGVybmV0QmFua2luZ0FwaQ==") /*"IInternetBankingApi"*/ );
                Assert.IsNotNull(type, "Missing assembly: InternetBankingRESTfulService.Api, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Api.IInternetBankingApi");
                    Assert.IsTrue(type.IsAbstract, "assembly: InternetBankingRESTfulService.Api, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Api.IInternetBankingApi is not abstract class");
                    Assert.IsTrue(type.IsInterface, "assembly: InternetBankingRESTfulService.Api, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Api.IInternetBankingApi is not interface");
                    Assert.IsTrue(type.IsPublic, "assembly: InternetBankingRESTfulService.Api, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Api.IInternetBankingApi is not public class");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("R2V0QXBpVmVyc2lvbg==") /*"GetApiVersion"*/ );                            Assert.IsNotNull(method, "method: InternetBankingRESTfulService.Api, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Api.IInternetBankingApi.GetApiVersion() does not exists");
                            Assert.IsTrue(method.IsPublic, "method: InternetBankingRESTfulService.Api, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Api.IInternetBankingApi.GetApiVersion() is not public");
                            Assert.IsTrue(method.IsAbstract, "method: InternetBankingRESTfulService.Api, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Api.IInternetBankingApi.GetApiVersion() is not abstract");
                            Assert.IsTrue(method.IsVirtual, "method: InternetBankingRESTfulService.Api, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Api.IInternetBankingApi.GetApiVersion() is not virtual");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.String",methodReturnType.FullName, "method: InternetBankingRESTfulService.Api, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Api.IInternetBankingApi.GetApiVersion() return type has changed");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("Q2FsY3VsYXRlTUQ1") /*"CalculateMD5"*/ );                            Assert.IsNotNull(method, "method: InternetBankingRESTfulService.Api, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Api.IInternetBankingApi.CalculateMD5(String value) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: InternetBankingRESTfulService.Api, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Api.IInternetBankingApi.CalculateMD5(String value) is not public");
                            Assert.IsTrue(method.IsAbstract, "method: InternetBankingRESTfulService.Api, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Api.IInternetBankingApi.CalculateMD5(String value) is not abstract");
                            Assert.IsTrue(method.IsVirtual, "method: InternetBankingRESTfulService.Api, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Api.IInternetBankingApi.CalculateMD5(String value) is not virtual");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.String",methodReturnType.FullName, "method: InternetBankingRESTfulService.Api, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Api.IInternetBankingApi.CalculateMD5(String value) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: InternetBankingRESTfulService.Api, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Api.IInternetBankingApi.CalculateMD5(String value) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("dmFsdWU=") /*"value"*/  && x.ParameterType.FullName == "System.String");
                                Assert.IsNotNull(parameter, "method: InternetBankingRESTfulService.Api, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Api.IInternetBankingApi.CalculateMD5(String value) parameter value does not exists or does not have type System.String");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("SXNQYXNzd29yZFN0cm9uZw==") /*"IsPasswordStrong"*/ );                            Assert.IsNotNull(method, "method: InternetBankingRESTfulService.Api, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Api.IInternetBankingApi.IsPasswordStrong(String password) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: InternetBankingRESTfulService.Api, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Api.IInternetBankingApi.IsPasswordStrong(String password) is not public");
                            Assert.IsTrue(method.IsAbstract, "method: InternetBankingRESTfulService.Api, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Api.IInternetBankingApi.IsPasswordStrong(String password) is not abstract");
                            Assert.IsTrue(method.IsVirtual, "method: InternetBankingRESTfulService.Api, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Api.IInternetBankingApi.IsPasswordStrong(String password) is not virtual");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Boolean",methodReturnType.FullName, "method: InternetBankingRESTfulService.Api, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Api.IInternetBankingApi.IsPasswordStrong(String password) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: InternetBankingRESTfulService.Api, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Api.IInternetBankingApi.IsPasswordStrong(String password) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("cGFzc3dvcmQ=") /*"password"*/  && x.ParameterType.FullName == "System.String");
                                Assert.IsNotNull(parameter, "method: InternetBankingRESTfulService.Api, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:InternetBankingRESTfulService.Api.IInternetBankingApi.IsPasswordStrong(String password) parameter password does not exists or does not have type System.String");


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
