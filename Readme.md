Random User Generator API
============

Random User Generator is a simple tool for generating random user data. It returns the user's name, email, and more.

![Build Status](https://img.shields.io/badge/build-passing-green)
![Code Climate](https://img.shields.io/badge/maintainability-B-purple)
![Prod Ready](https://img.shields.io/badge/production-ready-blue)

This is a .NET Wrapper for the [Random User Generator API](https://apiverve.com/marketplace/api/randomusergenerator)

---

## Installation

Using the .NET CLI:
```
dotnet add package APIVerve.API.RandomUserGenerator
```

Using the Package Manager:
```
nuget install APIVerve.API.RandomUserGenerator
```

Using the Package Manager Console:
```
Install-Package APIVerve.API.RandomUserGenerator
```

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on Manage NuGet Packages...
4. Click on the Browse tab and search for "APIVerve.API.RandomUserGenerator".
5. Click on the APIVerve.API.RandomUserGenerator package, select the appropriate version in the right-tab and click Install.


---

## Configuration

Before using the randomusergenerator API client, you have to setup your account and obtain your API Key.  
You can get it by signing up at [https://apiverve.com](https://apiverve.com)

---

## Usage

The Random User Generator API documentation is found here: [https://docs.apiverve.com/api/randomusergenerator](https://docs.apiverve.com/api/randomusergenerator).  
You can find parameters, example responses, and status codes documented here.

### Setup

###### Authentication
Random User Generator API uses API Key-based authentication. When you create an instance of the API client, you can pass your API Key as a parameter.

```
// Create an instance of the API client
var apiClient = new RandomUserGeneratorAPIClient("[YOUR_API_KEY]", true);
```

---


### Perform Request
Using the API client, you can perform requests to the API.

###### Define Query

```
var queryOptions = new randomusergeneratorQueryOptions {
  count = 1
};
```

###### Simple Request

```
var response = apiClient.Execute(queryOptions);
if(response.error != null) {
	Console.WriteLine(response.error);
} else {
    var jsonResponse = JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented);
    Console.WriteLine(jsonResponse);
}
```

###### Example Response

```
{
  "status": "ok",
  "error": null,
  "data": [
    {
      "id": "6d5c9f84-75b9-4b0d-a462-8f77712dcf0d",
      "name": "Kendra Reilly",
      "gender": "Male",
      "username": "Marlin16",
      "email": "Vinnie_Schowalter@gmail.com",
      "password": "NsOxuNDs_a_5R_p",
      "registered": "2023-10-24T10:02:59.857Z",
      "phone": "(943) 873-2068 x512",
      "cell": "535.765.2400 x888",
      "birthdate": "1972-12-17T20:46:12.771Z"
    }
  ]
}
```

---

## Customer Support

Need any assistance? [Get in touch with Customer Support](https://apiverve.com/contact).

---

## Updates
Stay up to date by following [@apiverveHQ](https://twitter.com/apiverveHQ) on Twitter.

---

## Legal

All usage of the APIVerve website, API, and services is subject to the [APIVerve Terms of Service](https://apiverve.com/terms) and all legal documents and agreements.

---

## License
Licensed under the The MIT License (MIT)

Copyright (&copy;) 2024 APIVerve, and Evlar LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.