@Code
   Dim db = Database.Open("bakery")
   Dim consulta = "select * from Products"
   Dim data = db.Query(consulta)
   Dim grid = New WebGrid(data)

End Code 

<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />
        <title></title>
    </head>
    <body>
        <center>
        <h1>Informacion de la tabla Productos</h1>
            <div id = "Grid">
            @grid.GetHtml()
                </div>
            <table border="2">
            <tr>
            <th>ID</th>
            <th>Nombre</th>
                <th>Descripcion</th>
                <th>Precio</th>
            </tr>
                <br>
            @code
                Dim i
                For Each i In db.Query(consulta)
            End code 
            <tr>
                <td>@i.Id</td>
                <td>@i.Name</td>
                <td>@i.Description</td>
                <td>@i.Price</td>
            </tr>
            @code
                Next i
            End Code
            
            </table>

        
        
        </center>
    </body>
</html>
