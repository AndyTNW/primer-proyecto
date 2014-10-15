    

<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />
        <title></title>
    </head>
    <body>
 @Code
    Dim db = Database.Open("Bakery")
    Dim dbdata = db.Query("SELECT Name, Price FROM Products")
    Dim myChart = new Chart(600,400)
    myChart.addtitle("Product Sales")
    myChart.DataBindtable(dbdata,"Name")
    myChart.write()
    End Code
    </body>
</html>
