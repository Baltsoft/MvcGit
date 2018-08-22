#### 1. Install the ConvertAPI library from NuGet

PM> Install-Package ConvertApi

#### 2.a. Convert local file

```csharp
//Import
using ConvertApiDotNet;


//Convert word document
const string sourceFile = @"c:\test.docx";

//Get your secret at https://www.convertapi.com/a
var convertApi = new ConvertApi("your api secret");

//Set input and output formats and pass file parameter
var convertToPdf = convertApi.ConvertAsync("docx", "pdf", new ConvertApiFileParam(sourceFile));
//Save PDF result 
convertToPdf.Result.SaveFiles(@"c:\output");
```

#### 2.b. Convert remote file
