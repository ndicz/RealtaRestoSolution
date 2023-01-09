Imports System.Data
Imports System.Data.SqlClient
Imports RealtaVbNetApi.Context
Imports RealtaVbNetApi.Model

Namespace Repository
    Public Class RestoOrderMenuDetailRepository

        Implements IRestoOrderMenuDetailRepository

        Private ReadOnly _context As IRepositoryContext

        Public Sub New()
        End Sub

        Public Sub New(context As IRepositoryContext)
            _context = context
        End Sub

        Public Function CreateRestoOrderDetail(RestoOrderMenuDetail As RestoOrderMenuDetail) As RestoOrderMenuDetail Implements IRestoOrderMenuDetailRepository.CreateRestoOrderDetail
            Dim newOrderDetail As New RestoOrderMenuDetail()

            'Dim stmt As String = "INSERT INTO Resto.order_menu_detail (omde_id,orme_price,orme_qty,orme_subtotal,orme_discount,omde_orme_id,omde_reme_id from Resto.order_menu_detail) values (@omde_id,@orme_price,@orme_qty,@orme_subtotal,@orme_discount,@omde_orme_id,@omde_reme_id) "

            Dim stmtIdentity As String = "INSERT INTO Resto.order_menu_detail (orme_price,orme_qty,orme_subtotal,orme_discount,omde_orme_id,omde_reme_id) values (@orme_price,@orme_qty,@orme_subtotal,@orme_discount,@omde_orme_id,@omde_reme_id) " &
                                         "Select cast(scope_identity() as int)"


            Using conn As New SqlConnection With {.ConnectionString = _context.GetConnectionString}
                Using cmd As New SqlCommand With {.Connection = conn, .CommandText = stmtIdentity}


                    cmd.Parameters.AddWithValue("@orme_price", RestoOrderMenuDetail.OrmePrice)
                    cmd.Parameters.AddWithValue("@orme_qty", RestoOrderMenuDetail.OrmeQyt)
                    cmd.Parameters.AddWithValue("@orme_subtotal", RestoOrderMenuDetail.OrmeSubtotal)
                    cmd.Parameters.AddWithValue("@orme_discount", RestoOrderMenuDetail.OrmeDiscount)
                    cmd.Parameters.AddWithValue("@omde_orme_id", RestoOrderMenuDetail.OmdeOrmeId)
                    cmd.Parameters.AddWithValue("@omde_reme_id", RestoOrderMenuDetail.OmdeRemeId)


                    Try
                        conn.Open()
                        'ExecuteScalar return 1 row & get first column
                        Dim omde_id As Int32 = Convert.ToInt32(cmd.ExecuteScalar())
                        newOrderDetail = FindRestoOrderDetailById(omde_id)

                        conn.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try

                End Using
            End Using
            Return newOrderDetail

        End Function

        Public Function DeleteRestoOrderDetail(id As Integer) As Integer Implements IRestoOrderMenuDetailRepository.DeleteRestoOrderDetail
            Throw New NotImplementedException()
        End Function

        Public Function FindAllRestoOrderDetail() As List(Of RestoOrderMenuDetail) Implements IRestoOrderMenuDetailRepository.FindAllRestoOrderDetail
            Dim restoOrderDetailList As New List(Of RestoOrderMenuDetail)

            Dim sql As String = "SELECT omde_id,orme_price,orme_qty,orme_subtotal,orme_discount,omde_orme_id,omde_reme_id from Resto.order_menu_detail " &
                                "Order by omde_id desc;"

            Using conn As New SqlConnection With {.ConnectionString = _context.GetConnectionString}

                Using cmd As New SqlCommand With {.Connection = conn, .CommandText = sql}

                    Try
                        conn.Open()
                        Dim reader = cmd.ExecuteReader()

                        While reader.Read()
                            restoOrderDetailList.Add(New RestoOrderMenuDetail() With {
                            .OmdeId = If(reader.IsDBNull(0), "", reader.GetInt32(0)),
                            .OrmePrice = If(reader.IsDBNull(1), 0, reader.GetDecimal(1)),
                            .OrmeQyt = If(reader.IsDBNull(2), 0, reader.GetInt16(2)),
                            .OrmeSubtotal = If(reader.IsDBNull(3), 0, reader.GetDecimal(3)),
                            .OrmeDiscount = If(reader.IsDBNull(4), 0, reader.GetDecimal(4)),
                            .OmdeOrmeId = If(reader.IsDBNull(5), 0, reader.GetInt32(5)),
                            .OmdeRemeId = If(reader.IsDBNull(6), 0, reader.GetInt32(6))
                            })
                        End While

                        reader.Close()
                        conn.Close()

                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End Using
            End Using
            Return restoOrderDetailList
        End Function

        Public Function FindAllRestoOrderDetailAsync() As Task(Of List(Of RestoOrderMenuDetail)) Implements IRestoOrderMenuDetailRepository.FindAllRestoOrderDetailAsync


        End Function

        Public Function FindRestoOrderDetailById(id As Integer) As RestoOrderMenuDetail Implements IRestoOrderMenuDetailRepository.FindRestoOrderDetailById

            Dim restoOrderDetail As New RestoOrderMenuDetail With {.OmdeId = id}

            Dim stmt As String = "Select omde_id,orme_price,orme_qty,orme_subtotal,orme_discount,omde_orme_id,omde_reme_id from Resto.order_menu_detail " &
                                "where omde_id = @omde_Id;"

            Using conn As New SqlConnection With {.ConnectionString = _context.GetConnectionString}

                Using cmd As New SqlCommand With {.Connection = conn, .CommandText = stmt}

                    cmd.Parameters.AddWithValue("@omde_id", id)

                    Try
                        conn.Open()
                        Dim reader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            reader.Read()

                            restoOrderDetail.OrmePrice = If(reader.IsDBNull(1), 0, reader.GetDecimal(1))
                            restoOrderDetail.OrmeQyt = If(reader.IsDBNull(2), 0, reader.GetInt16(2))
                            restoOrderDetail.OrmeSubtotal = If(reader.IsDBNull(3), 0, reader.GetDecimal(3))
                            restoOrderDetail.OrmeDiscount = If(reader.IsDBNull(4), 0, reader.GetDecimal(4))
                            restoOrderDetail.OmdeOrmeId = If(reader.IsDBNull(5), 0, reader.GetInt32(5))
                            restoOrderDetail.OmdeRemeId = If(reader.IsDBNull(6), 0, reader.GetInt32(6))
                        End If

                        reader.Close()
                        conn.Close()
                    Catch ex As Exception

                    End Try
                End Using
            End Using
            Return restoOrderDetail
        End Function
        Public Function UpdateRestoOrderDetailById(id As Integer, value As String, Optional showCommand As Boolean = False) As Boolean Implements IRestoOrderMenuDetailRepository.UpdateRestoOrderDetailById
            Throw New NotImplementedException()
        End Function

        Public Function UpdateRestoOrderDetailBySp(id As Integer, value As String, Optional showCommand As Boolean = False) As Boolean Implements IRestoOrderMenuDetailRepository.UpdateRestoOrderDetailBySp
            Throw New NotImplementedException()
        End Function
    End Class

End Namespace
