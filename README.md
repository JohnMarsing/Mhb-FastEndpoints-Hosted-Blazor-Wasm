# Mhb-FastEndpoints-Hosted-Blazor-Wasm
MyHebrewBible (MHB) is Hosted Blazor 8 WASM web app using FastEndpoints and Sqlite

I had another version of this app that I couldn't get working, but this one does, so I have a good baseline

## Server `.csproj`
### Fig 1: Solution
![Fig-1-Server-Solution](https://github.com/user-attachments/assets/ddb70a87-759b-44ff-a1e5-948c392a1866)

### Fig 2: `App.razor`
![Fig-2-Server-App-razor](https://github.com/user-attachments/assets/d2085890-97d4-4238-9885-ce4e7ab0c104)

### Fig 3: `Program.cs`
![Fig-3-Server-Program-cs](https://github.com/user-attachments/assets/d9881c34-88bc-4947-a707-b11c0fa97b0e)

### Fig 4: Endpoints and Repository     
![Fig-4-Server-Endpoints-Repository](https://github.com/user-attachments/assets/8ce80807-a149-46f1-9af2-ebab9af5c78f)

## `Client.csproj`
### Fig 5: Solution with `HttpClient` 
- NSwag generated code

![Fig-5-Client-Solution-HttpClient-NSwag-generated-code](https://github.com/user-attachments/assets/7cfce6fe-7203-41ab-9f6e-6c36bf7c0cad)

### Fig 6: `Program.cs`, `MainLayout.Razor`, `Routes.razor`
![Fig-6-Client-Program-MainLayout-Routes](https://github.com/user-attachments/assets/5f985c02-7d25-4e7e-b568-1ae011fa8b63)

### Fig 7: `WordPartTable.razor`
- Components folder

![Fig-7-Client-Components-WordPartTable](https://github.com/user-attachments/assets/7bb707c3-d2f5-438a-9954-e209e7ffe1f0)

### Fig 8: `BookChapter.razor`
- Features folder

![Fig-8-Client-Feature-Page-BookChapter](https://github.com/user-attachments/assets/7ecb4e59-8c76-4a58-a0f0-78390dadef08)

### Fig 9: Interactive Search
- Search Interactive Entire Solution

![Fig-9-Search-Interactive-Entire-Solution](https://github.com/user-attachments/assets/a3f6d16a-215c-4c07-89b0-bd285cf7aefd)
