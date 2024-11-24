# Web-Service-utilizando-Entity-FrameWork
 Este es mi trabajo final de programacion 3
## Diagrama Relacional(Sql Server)
[![Screenshot-2024-11-23-180158.png](https://i.postimg.cc/tR2DpFYd/Screenshot-2024-11-23-180158.png)](https://postimg.cc/nM9q1jKM)

## Como se ve la aplicacion Corriendo 
[![image.png](https://i.postimg.cc/tgNWDH6d/image.png)](https://postimg.cc/Jyts4vPt)

##Url Para acceder a los Metodos
## get
```shell
http://localhost:44374/api/inConteo/Listar
```
##Post
```shell
http://localhost:44374/api/inConteo/Agregar/
```
body 
```shell
{
  "Nombre": "Ejemplo",
  "Cantidad": 2
}
```

##Put
```shell
http://localhost:44374/api/inConteo/Agregar/
```
body 
```shell
{
        "Id": 1,
        "Nombre": "Ejemplo",
        "Catidad": 0
}
```

##Delete/Destroy
```shell
http://localhost:44374/api/inConteo/Destroy/
```
body 
```shell
{
        "Id": 1,
        "Nombre": "Ejemplo",
        "Catidad": 0
}
```

