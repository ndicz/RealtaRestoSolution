Imports System.Data.SqlClient
Imports RealtaVbNetApi.Context
Imports RealtaVbNetApi.Model

Namespace Repository
    Public Class RestoMenusRepository

        Implements IRestoMenusRepository


        Private ReadOnly _context As IRepositoryContext

        Public Sub New(context As IRepositoryContext)
            _context = context
        End Sub

        Public Function CreateRestoMenus(restomenus As RestoMenus) As RestoMenus Implements IRestoMenusRepository.CreateRestoMenus
            Dim newRestoMenus As New RestoMenus()
            Dim stmtIdentity As String = "INSERT INTO Resto.resto_menus " &
                                                "(reme_faci_id,reme_name,reme_description,reme_price,reme_status,reme_modified_date) " &
                                         "values (@remeFaciId, @reme_name,@reme_description,@reme_price,@reme_status,@reme_modified_date); " &
                                          "Select cast(scope_identity() as int);"
            Using conn As New SqlConnection With {.ConnectionString = _context.GetConnectionString}
                Using cmd As New SqlCommand With {.Connection = conn, .CommandText = stmtIdentity}

                    cmd.Parameters.AddWithValue("@remeFaciId", 2)
                    cmd.Parameters.AddWithValue("@reme_name", restomenus.RemeName)
                    cmd.Parameters.AddWithValue("@reme_description", restomenus.RemeDesc)
                    cmd.Parameters.AddWithValue("@reme_price", restomenus.RemePrice)
                    cmd.Parameters.AddWithValue("@reme_status", restomenus.RemeStatus)
                    cmd.Parameters.AddWithValue("@reme_modified_date", restomenus.RemeModDate)

                    Try
                        conn.Open()
                        'ExecuteScalar return 1 row & get first column
                        Dim omde_id = cmd.ExecuteScalar()
                        newRestoMenus = FindRestoMenusById(omde_id)

                        conn.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try

                End Using
            End Using
            Return newRestoMenus

        End Function

        Public Function DeleteRestoMenus(id As Integer) As Integer Implements IRestoMenusRepository.DeleteRestoMenus
            Throw New NotImplementedException()
        End Function

        Public Function FindAllRestoMenus() As List(Of RestoMenus) Implements IRestoMenusRepository.FindAllRestoMenus
            Throw New NotImplementedException()
        End Function

        Public Function FindAllRestoMenuslAsync() As Task(Of List(Of RestoMenus)) Implements IRestoMenusRepository.FindAllRestoMenuslAsync
            Throw New NotImplementedException()
        End Function

        Public Function FindRestoMenusById(id As Integer) As RestoMenus Implements IRestoMenusRepository.FindRestoMenusById
            Dim restoMenu As New RestoMenus With {.RemeId = id}
            Dim stmt As String = "Select reme_faci_id,reme_id,reme_name,reme_description,reme_price,reme_status,reme_modified_date from Resto.resto_menus " &
                                "where reme_id = @reme_id;"

            Using conn As New SqlConnection With {.ConnectionString = _context.GetConnectionString}

                Using cmd As New SqlCommand With {.Connection = conn, .CommandText = stmt}

                    cmd.Parameters.AddWithValue("@reme_id", id)
                    Try
                        conn.Open()
                        Dim reader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            reader.Read()


                            restoMenu.RemeFaciId = If(reader.IsDBNull(0), 0, reader.GetInt32(0))
                            restoMenu.RemeId = If(reader.IsDBNull(1), 0, reader.GetInt32(1))
                            restoMenu.RemeName = If(reader.IsDBNull(2), "", reader.GetString(2))
                            restoMenu.RemeDesc = If(reader.IsDBNull(3), "", reader.GetString(3))
                            restoMenu.RemePrice = If(reader.IsDBNull(4), "", reader.GetDecimal(4))
                            restoMenu.RemeStatus = If(reader.IsDBNull(5), "", reader.GetString(5))
                            restoMenu.RemeModDate = If(reader.IsDBNull(6), "", reader.GetDateTime(6))
                        End If

                        reader.Close()
                        conn.Close()
                    Catch ex As Exception

                    End Try
                End Using
            End Using
            Return restoMenu
        End Function

        Public Function UpdateRestoMenuslById(id As Integer, value As String, Optional showCommand As Boolean = False) As Boolean Implements IRestoMenusRepository.UpdateRestoMenuslById
            Throw New NotImplementedException()
        End Function

        Public Function UpdateRestoMenusBySp(id As Integer, value As String, Optional showCommand As Boolean = False) As Boolean Implements IRestoMenusRepository.UpdateRestoMenusBySp
            Throw New NotImplementedException()
        End Function
    End Class

End Namespace

