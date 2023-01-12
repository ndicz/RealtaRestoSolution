Imports RealtaVbNetApi.Repository

Namespace Base
    Public Interface IRepositoryManager

        ReadOnly Property RestoOrderMenuDetail As IRestoOrderMenuDetailRepository

        ReadOnly Property RestoMenus As IRestoMenuRepository

        ReadOnly Property RestoOrderMenu As IRestoOrderMenuRepository

        ReadOnly Property RestoMenuPhotos As IRestoMenuPhotosRepository

    End Interface

End Namespace

