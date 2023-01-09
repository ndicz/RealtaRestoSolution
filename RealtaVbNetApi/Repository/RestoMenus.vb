Imports RealtaVbNetApi.Context

Namespace Repository
    Public Class RestoMenus

        Implements IRestoMenus


        Private ReadOnly _context As IRepositoryContext
        Private repositoryContext As IRepositoryContext

        Public Sub New(repositoryContext As IRepositoryContext)
            Me.repositoryContext = repositoryContext
        End Sub

        Public Function CreateRestoMenus(region As RestoMenus) As RestoMenus Implements IRestoMenus.CreateRestoMenus
            Throw New NotImplementedException()
        End Function

        Public Function DeleteRestoMenus(id As Integer) As Integer Implements IRestoMenus.DeleteRestoMenus
            Throw New NotImplementedException()
        End Function

        Public Function FindAllRestoMenus() As List(Of RestoMenus) Implements IRestoMenus.FindAllRestoMenus
            Throw New NotImplementedException()
        End Function

        Public Function FindAllRestoMenuslAsync() As Task(Of List(Of RestoMenus)) Implements IRestoMenus.FindAllRestoMenuslAsync
            Throw New NotImplementedException()
        End Function

        Public Function FindRestoMenusById(id As Integer) As RestoMenus Implements IRestoMenus.FindRestoMenusById
            Throw New NotImplementedException()
        End Function

        Public Function UpdateRestoMenuslById(id As Integer, value As String, Optional showCommand As Boolean = False) As Boolean Implements IRestoMenus.UpdateRestoMenuslById
            Throw New NotImplementedException()
        End Function

        Public Function UpdateRestoMenusBySp(id As Integer, value As String, Optional showCommand As Boolean = False) As Boolean Implements IRestoMenus.UpdateRestoMenusBySp
            Throw New NotImplementedException()
        End Function
    End Class


End Namespace

