Imports System.Data.SqlClient
Imports RealtaVbNetApi.Context
Imports RealtaVbNetApi.Model

Namespace Repository
    Public Class RestoOrderMenuRepository

        Implements IRestoOrderMenuRepository


        Private ReadOnly _context As IRepositoryContext

        Public Sub New(context As IRepositoryContext)
            _context = context
        End Sub

        Public Function CreateRestoOrderMenus(ordermenu As RestoOrderMenu) As RestoOrderMenu Implements IRestoOrderMenuRepository.CreateRestoOrderMenus
            Dim newRestoOrder As New RestoOrderMenu
            Dim stmtidentity As String = "INSERT INTO Resto.order_menus  " &
                                         "(orme_order_number, orme_order_date, orme_total_item, orme_total_discount, orme_total_amount, orme_pay_type, orme_cardnumber, orme_is_paid, orme_modified_date, orme_user_id) " &
                                         "Values (@orme_order_number,@orme_order_date, @orme_total_item, @orme_total_discount, @orme_total_amount, @orme_pay_type, @orme_cardnumber, @orme_is_paid, @orme_modified_date, @orme_user_id); " &
                                         "Select cast(scope_identity() as int);"

            Using conn As New SqlConnection With {.ConnectionString = _context.GetConnectionString}
                Using cmd As New SqlCommand With {.Connection = conn, .CommandText = stmtidentity}

                    cmd.Parameters.AddWithValue("@orme_order_number", ordermenu.OrmeOrNum)
                    cmd.Parameters.AddWithValue("@orme_order_date", ordermenu.OrmeOrDate)
                    cmd.Parameters.AddWithValue("@orme_total_item", ordermenu.OrmeTotItem)
                    cmd.Parameters.AddWithValue("@orme_total_discount", ordermenu.OrmeTotDIsc)
                    cmd.Parameters.AddWithValue("@orme_total_amount", ordermenu.OrmeTotAmo)
                    cmd.Parameters.AddWithValue("@orme_pay_type", ordermenu.OrmePayType)
                    cmd.Parameters.AddWithValue("@orme_cardnumber", ordermenu.OrmeCard)
                    cmd.Parameters.AddWithValue("@orme_is_paid", ordermenu.OrmeIsPaid)
                    cmd.Parameters.AddWithValue("@orme_modified_date", ordermenu.OrmeModDate)
                    cmd.Parameters.AddWithValue("@orme_user_id", ordermenu.OrmeUserId)

                    Try
                        conn.Open()
                        'ExecuteScalar return 1 row & get first column
                        Dim omde_id = cmd.ExecuteScalar()
                        newRestoOrder = FindRestoOrderMenusById(omde_id)

                        conn.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try

                End Using
            End Using
            Return newRestoOrder
        End Function

        Public Function DeleteRestoOrderMenus(id As Integer) As Integer Implements IRestoOrderMenuRepository.DeleteRestoOrderMenus
            Throw New NotImplementedException()
        End Function

        Public Function FindAllRestoOrderMenus() As List(Of RestoOrderMenu) Implements IRestoOrderMenuRepository.FindAllRestoOrderMenus
            Throw New NotImplementedException()
        End Function

        Public Function FindAllRestoOrderMenuslAsync() As Task(Of List(Of RestoOrderMenu)) Implements IRestoOrderMenuRepository.FindAllRestoOrderMenuslAsync
            Throw New NotImplementedException()
        End Function

        Public Function FindRestoOrderMenusById(id As Integer) As RestoOrderMenu Implements IRestoOrderMenuRepository.FindRestoOrderMenusById
            Dim restoOrder As New RestoOrderMenu With {.OrmeID = id}
            Dim stmt As String = "Select orme_id, orme_order_number, orme_order_date, orme_total_item, orme_total_discount, orme_total_amount, orme_pay_type, orme_cardnumber, orme_is_paid, orme_modified_date, orme_user_id from Resto.order_menus " &
                                "where orme_id = @orme_id;"

            Using conn As New SqlConnection With {.ConnectionString = _context.GetConnectionString}

                Using cmd As New SqlCommand With {.Connection = conn, .CommandText = stmt}

                    cmd.Parameters.AddWithValue("@orme_id", id)
                    Try
                        conn.Open()
                        Dim reader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            reader.Read()


                            restoOrder.OrmeID = If(reader.IsDBNull(0), 0, reader.GetInt32(0))
                            restoOrder.OrmeOrNum = If(reader.IsDBNull(1), "", reader.GetString(1))
                            restoOrder.OrmeOrDate = If(reader.IsDBNull(2), "", reader.GetDateTime(2))
                            restoOrder.OrmeTotItem = If(reader.IsDBNull(3), 0, reader.GetInt16(3))
                            restoOrder.OrmeTotDIsc = If(reader.IsDBNull(4), 0, reader.GetDecimal(4))
                            restoOrder.OrmeTotAmo = If(reader.IsDBNull(5), 0, reader.GetDecimal(5))
                            restoOrder.OrmePayType = If(reader.IsDBNull(6), "", reader.GetString(6))
                            restoOrder.OrmeCard = If(reader.IsDBNull(7), "", reader.GetString(7))
                            restoOrder.OrmeIsPaid = If(reader.IsDBNull(8), "", reader.GetString(8))
                            restoOrder.OrmeModDate = If(reader.IsDBNull(9), "", reader.GetDateTime(9))
                            restoOrder.OrmeUserId = If(reader.IsDBNull(10), 0, reader.GetInt32(10))

                        End If

                        reader.Close()
                        conn.Close()
                    Catch ex As Exception

                    End Try
                End Using
            End Using
            Return restoOrder
        End Function

        Public Function UpdateRestoOrderMenuslById(ormeID As Integer, ormeOrNum As String, ormeOrDate As Date, ormeTotItem As Integer, ormeTotDIsc As Decimal, ormeTotAmo As Decimal, ormePayType As String, ormeCard As String, ormeIsPaid As Char, ormeModDate As Date, ormeUserId As Integer, Optional showCommand As Boolean = False) As Boolean Implements IRestoOrderMenuRepository.UpdateRestoOrderMenuslById
            Throw New NotImplementedException()
        End Function

        Public Function UpdateRestoOrderMenusBySp(ormeID As Integer, ormeOrNum As String, ormeOrDate As Date, ormeTotItem As Integer, ormeTotDIsc As Decimal, ormeTotAmo As Decimal, ormePayType As String, ormeCard As String, ormeIsPaid As Char, ormeModDate As Date, ormeUserId As Integer, Optional showCommand As Boolean = False) As Boolean Implements IRestoOrderMenuRepository.UpdateRestoOrderMenusBySp
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace
