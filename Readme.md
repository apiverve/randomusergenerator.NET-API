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
3. Click on Manage NuGet Packages..
4. Click on the Browse tab and search for "APIVerve.API.RandomUserGenerator".
5. Click on the APIVerve.API.RandomUserGenerator package, click Install.


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
var queryOptions = new RandomUserGeneratorQueryOptions {
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
      "id": "04e47b46-c078-4d51-a7e9-17708ebea53e",
      "name": "Yvette Greenholt",
      "gender": "Female",
      "username": "Julien.Kutch",
      "email": "Jude_Kuhic@yahoo.com",
      "password": "M90Tqd9_5_9tbuE",
      "registered": "2024-12-06T20:36:01.485Z",
      "phone": "832.718.9991 x55356",
      "cell": "(344) 512-8916 x36142",
      "birthdate": "1958-06-28T06:23:25.829Z"
    }
  ],
  "code": 200
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

Copyright (&copy;) 2025 APIVerve, and EvlarSoft LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.