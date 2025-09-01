# ASP.NET Fishies

This is a small project to get familiar with C# on the backend

## GET Endpoints

These can all be accessed from the browser by typing the URL into the search bar.

### POST, PUT, DELETE Endpoints

The easiest way to test these is with the following curl commands:

**POST**
`curl -X POST https://localhost:7014/fish \
  -H "Content-Type: application/json" \
  -d '{
    "name": "Barramundi",
    "scientificName": "Lates calcarifer",
    "description": "A tropical fish prized for its mild flavor.",
    "habitat": "Saltwater",
    "location": "Northern Australia",
    "status": "LeastConcern",
    "averageWeightKg": 3.2,
    "marketValue": 18.0,
    "seasonality": "Spring",
    "imageUrl": "https://example.com/barramundi.jpg",
    "lastUpdated": "2025-09-01T10:59:00Z"
  }' -k
`

**PUT**
`
curl -X PUT https://localhost:7014/fish/1 \
  -H "Content-Type: application/json" \
  -d '{
    "id": 1,
    "name": "Atlantic Salmon",
    "scientificName": "Salmo salar",
    "description": "Updated description for Atlantic Salmon.",
    "habitat": "Saltwater",
    "location": "North Atlantic Ocean",
    "status": "LeastConcern",
    "averageWeightKg": 4.8,
    "marketValue": 17.0,
    "seasonality": "Spring-Summer",
    "imageUrl": "https://example.com/salmon.jpg",
    "lastUpdated": "2025-09-01T16:09:00Z"
  }' -k
`

**DELETE**
`curl -X DELETE https://localhost:7014/fish/1 -k`
