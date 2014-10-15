

<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />
        <title></title>
    </head>
    <body>
   @Code
    Dim db=Database.Open("bakery")
    Dim consulta="Select * From Products"
    Dim data = db.Query(consulta)
    Dim grid = New WebGrid(data)
End Code
        
       <form method="post" action="">	
            Nombre de Usuario:<br />
            	<input type="text" name="Nombre1" value="" />
            <br />
            	Apellido del Usuario:<br />	
            <input type="text" name="Apellido1" value="" />
            <br /><br />	
            <input type="submit" value=“Enviar" class="submit" />	
        </form>	
        <h3>@nombre</h3>
        <br> 
        <h3>@apellido </h3>         
    </body>
</html>
