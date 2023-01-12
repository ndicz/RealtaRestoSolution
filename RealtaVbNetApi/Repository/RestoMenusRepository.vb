Imports System.Data.SqlClient
Imports RealtaVbNetApi.Context
Imports RealtaVbNetApi.Model

Namespace Repository
    Public Class RestoMenusRepository

        Implements IRestoMenuRepository


        Private ReadOnly _context As IRepositoryContext

        Public Sub New(context As IRepositoryContext)
            _context = context
        End Sub

        Public Function CreateRestoMenus(restomenus As RestoMenu) As RestoMenu Implements IRestoMenuRepository.CreateRestoMenus
            Dim newRestoMenus As New RestoMenu()
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

        Public Function DeleteRestoMenus(id As Integer) As Integer Implements IRestoMenuRepository.DeleteRestoMenus
            Dim rowEffect As Int32 = 0
            Dim stmt As String = "DELETE FROM resto.resto_menus where reme_id = @reme_id"

            Using conn As New SqlConnection With {.ConnectionString = _context.GetConnectionString}

                Using cmd As New SqlCommand With {.Connection = conn, .CommandText = stmt}

                    cmd.Parameters.AddWithValue("reme_id", id)

                    Try
                        conn.Open()
                        rowEffect = cmd.ExecuteNonQuery()

                        conn.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try

                End Using
            End Using

            Return rowEffect
        End Function

        Public Function FindAllRestoMenus() As List(Of RestoMenu) Implements IRestoMenuRepository.FindAllRestoMenus
            Dim restoMenusList As New List(Of RestoMenu)
            Dim sql As String = "select reme_faci_id,reme_id,reme_name,reme_description,reme_price,reme_status,reme_modified_date from Resto.resto_menus " &
                                "order by reme_id desc;"

            Using conn As New SqlConnection With {.ConnectionString = _context.GetConnectionString}

                Using cmd As New SqlCommand With {.Connection = conn, .CommandText = sql}


                    Try
                        conn.Open()
                        Dim reader = cmd.ExecuteReader()

                        While reader.Read()

                            restoMenusList.Add(New RestoMenu() With {
                            .RemeFaciId = If(reader.IsDBNull(0), 0, reader.GetInt32(0)),
                            .RemeId = If(reader.IsDBNull(1), 0, reader.GetInt32(1)),
                            .RemeName = If(reader.IsDBNull(2), "", reader.GetString(2)),
                            .RemeDesc = If(reader.IsDBNull(3), "", reader.GetString(3)),
                            .RemePrice = If(reader.IsDBNull(4), "", reader.GetDecimal(4)),
                            .RemeStatus = If(reader.IsDBNull(5), "", reader.GetString(5)),
                            .RemeModDate = If(reader.IsDBNull(6), "", reader.GetDateTime(6))
                             })
                        End While

                        reader.Close()
                        conn.Close()
                    Catch ex As Exception

                    End Try
                End Using
            End Using
            Return restoMenusList
        End Function

        Public Async Function FindAllRestoMenuslAsync() As Task(Of List(Of RestoMenu)) Implements IRestoMenuRepository.FindAllRestoMenuslAsync
            Dim restoMenusList As New List(Of RestoMenu)
            Dim sql As String = "select reme_faci_id,reme_id,reme_name,reme_description,reme_price,reme_status,reme_modified_date from Resto.resto_menus " &
                                "order by reme_id desc;"

            Using conn As New SqlConnection With {.ConnectionString = _context.GetConnectionString}

                Using cmd As New SqlCommand With {.Connection = conn, .CommandText = sql}


                    Try
                        conn.Open()
                        Dim reader = Await cmd.ExecuteReaderAsync

                        While reader.Read()

                            restoMenusList.Add(New RestoMenu() With {
                            .RemeFaciId = If(reader.IsDBNull(0), 0, reader.GetInt32(0)),
                            .RemeId = If(reader.IsDBNull(1), 0, reader.GetInt32(1)),
                            .RemeName = If(reader.IsDBNull(2), "", reader.GetString(2)),
                            .RemeDesc = If(reader.IsDBNull(3), "", reader.GetString(3)),
                            .RemePrice = If(reader.IsDBNull(4), "", reader.GetDecimal(4)),
                            .RemeStatus = If(reader.IsDBNull(5), "", reader.GetString(5)),
                            .RemeModDate = If(reader.IsDBNull(6), "", reader.GetDateTime(6))
                             })
                        End While

                        reader.Close()
                        conn.Close()
                    Catch ex As Exception

                    End Try
                End Using
            End Using
            Return restoMenusList
        End Function

        Public Function FindRestoMenusById(id As Integer) As RestoMenu Implements IRestoMenuRepository.FindRestoMenusById
            Dim restoMenu As New RestoMenu With {.RemeId = id}
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

        Public Function UpdateRestoMenuslById(remeId As Integer, remeName As String, remeDesc As String, remePrice As Decimal, remeStatus As String, remeModDate As Date, Optional showCommand As Boolean = False) As Boolean Implements IRestoMenuRepository.UpdateRestoMenuslById
            Dim restoMenu As New RestoMenu With {.RemeId = remeId}
            Dim stmt As String = "UPDATE Resto.resto_menus " &
                                   "set " &
                                   "
                                  
                                    reme_name = @reme_name,
                                    reme_description = @reme_desc,
                                    reme_price = @reme_price,
                                    reme_status = @reme_status,
                                    reme_modified_date = @reme_mod " &
                                   "Where reme_id = @reme_id"
            Using conn As New SqlConnection With {.ConnectionString = _context.GetConnectionString}
                Using cmd As New SqlCommand With {.Connection = conn, .CommandText = stmt}

                    cmd.Parameters.AddWithValue("@reme_id", remeId)
                    cmd.Parameters.AddWithValue("@reme_name", remeName)
                    cmd.Parameters.AddWithValue("@reme_desc", remeDesc)
                    cmd.Parameters.AddWithValue("@reme_price", remePrice)
                    cmd.Parameters.AddWithValue("@reme_status", remeStatus)
                    cmd.Parameters.AddWithValue("@reme_mod", remeModDate)

                    If showCommand Then
                        Console.WriteLine(cmd.CommandText)
                    End If

                    Try
                        conn.Open()
                        cmd.ExecuteNonQuery()

                        conn.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try

                End Using
            End Using
            Return True


        End Function

        Public Function UpdateRestoMenusBySp(id As Integer, value As String, Optional showCommand As Boolean = False) As Boolean Implements IRestoMenuRepository.UpdateRestoMenusBySp
            Throw New NotImplementedException()
        End Function
    End Class

End Namespace

