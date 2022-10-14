# Internet Banking RESTful service

## Introduction
You are developing an internal interface for a Banking systems as a *RESTful API*.
One of the requirements is to implement a simple interface for an Internet Banking System.

## Problem Statement

To complete this task, you have to add a new custom controller in the ***`InternetBankingRESTfulService.Web`*** project which will implement the `InternetBankingRESTfulService.Api.IInternetBankingApi` interface.
*Remember* that the controller should implement the interface as a *RESTful API*.
***Again, remember*** that you should create your new controller ***in*** `InternetBankingRESTfulService.Web` project ***not in `InternetBankingRESTfulService.Api`!***

Requirements:

* The `GetApiVersion` method should return the current version (1.0) in the following format: `YYYY.MM.DD.1.0`, where:
    * YYYY is the current year (UTC time), 
    * MM is the current month (UTC time), 
    * DD is the current day (UTC time).

- The `CalculateMD5` should calculate the MD5 hash for the data passed as a function parameter:
	- Before calculate MD5 the all digits in *value* parameter should be replaced by 'X' char (ex.: "asd4-56" should be replaced to "asdX-XX")
	- The MD5 hash should be returned as hex characters (for example test-string-1 should be replaced to test-string-X and MD5 should be D3F0A6CF3F628B90DBF0B57E661D193F).
	- The passed parameter will never be empty.
	
* The `IsPasswordStrong` should check if the passed password (as a parameter) is strong. 
	The password will be recognized as strong if it is:
		- at least twelve characters long and 
		- contains at least one uppercase letter and
		- contains at least one lowercase letter and 
		- contains at least one digit and 
		- contains at least one character from: @!*+- 
		- doesn't contain any white-space characters

### Configure endpoints availability
***Remember*** that you're ***not allowed*** to make any changes to `Startup.cs` or `Program.cs`, so you have to configure availability in your controller.

* The `GetApiVersion` should be available at both: `bank/api/version` and `bank/api-version` url.
* The `CalculateMD5` should be available at both: `bank/api/calc/MD5/<passed md5 value>` and `bank/api/calc/<passed md5 value>/MD5` url.
* The `IsPasswordStrong` should be available at both: `bank/api/password/strong/<passed md5 value>` and `bank/api/is-password-strong/<passed md5 value>` url.

**NOTE:** Please, make sure not to change the task structure/refactor code, as it can break verification process. 

## Hints
1. Your solution should pass all tests.
2. You're ***not*** suposed to inject anything in your new custom controller construtor.
