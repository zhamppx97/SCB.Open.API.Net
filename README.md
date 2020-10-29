# SCB.Open.API.Net
About SCB Open API Ref: https://developer.scb/#/home

# Create your account
https://developer.scb/#/preregistration

# Doccumentation
https://developer.scb/#/documents/documentation/basics/getting-started.html

# Usage

NuGet Package
https://www.nuget.org/packages/SCB.Open.API.Net/

  ```
  PM> Install-Package SCB.Open.API.Net -Version 0.2.0
  ```

Sample

  ```
  SCBOpenAPI.Authentication auth = new SCBOpenAPI.Authentication();
  
  auth.CreateAuthorizeRequestHeader.ApiKey = "<Your API Key>";
  auth.CreateAuthorizeRequestHeader.ApiSecret = "<Your API Secret>";
  auth.CreateAuthorizeRequestHeader.ResourceOwnerId = "<Your API Key>";
  auth.CreateAuthorizeRequestHeader.RequestUId = Guid.NewGuid().ToString();
  auth.CreateAuthorizeRequestHeader.ResponseChannel = "mobile";
  auth.CreateAuthorizeRequestHeader.EndState = "mobile_web";
  auth.CreateAuthorizeRequestHeader.AcceptLanguage = "EN";
  auth.CreateAuthorizeRequestHeader.ApplicationId = null;
  auth.CreateAuthorizeRequestHeader.RedirectOption = null;
  auth.CreateAuthorizeRequestHeader.State = null;
  auth.CreateAuthorizeRequestHeader.CodeChallenge = null;
  
  var resultAuthorize = auth.GetAuthorize(auth.CreateAuthorizeRequestHeader);
  
  Console.WriteLine(resultAuthorize.status.code);
  // Display
  // 1000
  
  Console.WriteLine(resultAuthorize.status.description);
  // Display
  // Success
  
  Console.WriteLine(resultAuthorize.data.callbackUrl);
  // Display
  // scbeasysim://login/a2f816bf-5e33-4a7b-a3fd-3babd1e95428
  
  Console.WriteLine(resultAuthorize.jsonString);
  // Display
  // {
  //   "status": {
  //     "code": 1000,
  //     "description": "Success"
  //   },
  //   "data": {
  //     "callbackUrl": "scbeasysim://login/a2f816bf-5e33-4a7b-a3fd-3babd1e95428"
  //   }
  // }
  ```
  
# Upcoming

- Loan Origination
