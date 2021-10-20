# Just an app

## Running locally

Download and install .NET 6 [from official source](https://dotnet.microsoft.com/download/dotnet/6.0) (at least RC2), and run 

```bash
dotnet run
```

## Running with docker

Build the image

```bash
docker build -t anapp .
```

then run the app

```bash
docker run -e "ENV=Staging" -d -p 8080:80 anapp
```

and, then browse [http://localhost:8080/](http://localhost:8080/)