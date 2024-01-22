# Simple Thunder Todo List ⚡️

Simple crud project for Thunder Recruiting Process

_The project is using .net8 version._

## Installation

FIRST OF ALL !! Install .net 8 from [here](https://dotnet.microsoft.com/pt-br/download/dotnet/8.0)

OR

If you have docker desktop, just open project folder and run:

```bash
docker build -t thunder-todo-list .
```

It will create a image, next, run command to create and start the container

```bash
docker run -d -p 5001:8080 --name thunder-todo-list thunder-todo-list
```

Now just open application on http://localhost:5001/
That's it !!

## Usage

After installation go to your command line and open /Thunder-Todo-List folder
Next step is run

```bash
dotnet run --project Api/Api.csproj
```

This will build and run the project and make it available at http://localhost:5203

This project are using a Memory Database so, on every starts, it will erase data

If you have any question I will be glad to respond. 👉🏼 [Linkedin](www.linkedin.com/in/paulod1as)
