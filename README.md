# mockDriveXpo
APIs for providing mock load data and dispatching. This is a .NET Core 1.1 WebAPI running on Kestral.

## Running
```
cd Xpo.DriveXpo.Api
dotnet run
```

## APIs

- [GET]  /api/loads
- [GET]  /api/loads/{id}
- [GET]  /api/dispatch/{carrierId}
- [POST] /api/dispatch
- [POST] /api/location
Sample dispatch post
```
POST http://localhost:32128/api/dispatch HTTP/1.1
Host: localhost:32128
Connection: keep-alive
Content-Length: 41
Content-Type: application/json

{ "carrierId": 10000, "loadId": 125 }
```

Sample location post
```
POST http://localhost:32128/api/location HTTP/1.1
Host: localhost:32128
Connection: keep-alive
Content-Length: 41
Content-Type: application/json

{ "latitude": 1.123, "longitude": 2.234, "loadId": 123 }
```

## Fun stuff
- Origin is always the first item in the stop array
- Destination is always the last item in the stop array
- CarrierId is something you can make up. Just be sure to remember it if you want to ask the dispatch API about things you dispatched
- The app should provide a list view of loads with minimal information (Origin/destination, price, customer)
- Clicking a load should show all the load detail with an option to dispatch
- Provide an option to show all loads you've been dispatched to (for the sake of this hack-a-thon we can say a carrier can be dispatched to multiple loads)
- Send GPS pings (lat/lon) to `/api/location`
- You can modify this source code

