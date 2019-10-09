# Przykład autentykacji w .NET Core 2.2 z użyciem tokenów JWT


## Generowanie tokena

~~~ 
POST http://localhost:5000/api/users
Content-Type: application/json
{"Username":"john","HashPassword":"12345"}
~~~

- Przykład wygenerowanego tokena

https://jwt.io/#debugger-io?token=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6ImpvaG4uc21pdGhAZG9tYWluLmNvbSIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL21vYmlsZXBob25lIjoiNTU1MzMzMjIyIiwibmJmIjoxNTcwNjEzNTkxLCJleHAiOjE1NzEyMTgzOTEsImlhdCI6MTU3MDYxMzU5MX0.tcHkvrLyP8gTC-27QFuw_oUsxmaxEVB7xq29apJSS9M


## Przykład użycia

 GET http://localhost:5000/api/values
 Authorization: Bearer {token}
 
 
