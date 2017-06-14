# FlatFrameworkCore
ASP.NET CORE

 环境说明:
 
WIN7+VS2015+PostgreSQL

1.Add-Migration AddTest
2.Update-Database
3.Remove-Migration            Removes the last migration./*报错.*/如果不想加添见4.
4.Update-Database "20170605054159_Init"
5.Update-Database /*更新数据库为最新的DbContext*/

