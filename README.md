# SCB.Open.API.Net
About SCB Open API Ref: https://developer.scb/#/home

# Create your account
https://developer.scb/#/preregistration

# Doccumentation
https://developer.scb/#/documents/documentation/basics/getting-started.html

# Usage

NuGet Package

  ```
  PM> Install-Package SCB.Open.API.Net -Version 0.0.0
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
  ```
  
