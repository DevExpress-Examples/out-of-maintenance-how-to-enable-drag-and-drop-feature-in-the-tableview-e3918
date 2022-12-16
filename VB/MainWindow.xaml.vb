Imports System.Windows
Imports System.Collections.ObjectModel

Namespace How_to_Table_View_Drag_and_Drop

    Public Partial Class MainWindow
        Inherits Window

        Public Class Employee

            Public Property ID As Integer

            Public Property Name As String

            Public Property Position As String

            Public Property Department As String

            Public Overrides Function ToString() As String
                Return Name
            End Function
        End Class

        Public NotInheritable Class Stuff

            Public Shared Function GetStuff() As ObservableCollection(Of Employee)
                Dim stuff As ObservableCollection(Of Employee) = New ObservableCollection(Of Employee)()
                stuff.Add(New Employee() With {.ID = 1, .Name = "Gregory S. Price", .Department = "", .Position = "President"})
                stuff.Add(New Employee() With {.ID = 2, .Name = "Irma R. Marshall", .Department = "Marketing", .Position = "Vice President"})
                stuff.Add(New Employee() With {.ID = 3, .Name = "John C. Powell", .Department = "Operations", .Position = "Vice President"})
                stuff.Add(New Employee() With {.ID = 4, .Name = "Christian P. Laclair", .Department = "Production", .Position = "Vice President"})
                stuff.Add(New Employee() With {.ID = 5, .Name = "Karen J. Kelly", .Department = "Finance", .Position = "Vice President"})
                stuff.Add(New Employee() With {.ID = 6, .Name = "Brian C. Cowling", .Department = "Marketing", .Position = "Manager"})
                stuff.Add(New Employee() With {.ID = 7, .Name = "Thomas C. Dawson", .Department = "Marketing", .Position = "Manager"})
                stuff.Add(New Employee() With {.ID = 8, .Name = "Angel M. Wilson", .Department = "Marketing", .Position = "Manager"})
                stuff.Add(New Employee() With {.ID = 9, .Name = "Bryan R. Henderson", .Department = "Marketing", .Position = "Manager"})
                stuff.Add(New Employee() With {.ID = 10, .Name = "Harold S. Brandes", .Department = "Operations", .Position = "Manager"})
                stuff.Add(New Employee() With {.ID = 11, .Name = "Michael S. Blevins", .Department = "Operations", .Position = "Manager"})
                stuff.Add(New Employee() With {.ID = 12, .Name = "Jan K. Sisk", .Department = "Operations", .Position = "Manager"})
                stuff.Add(New Employee() With {.ID = 13, .Name = "Sidney L. Holder", .Department = "Operations", .Position = "Manager"})
                stuff.Add(New Employee() With {.ID = 14, .Name = "James L. Kelsey", .Department = "Production", .Position = "Manager"})
                stuff.Add(New Employee() With {.ID = 15, .Name = "Howard M. Carpenter", .Department = "Production", .Position = "Manager"})
                stuff.Add(New Employee() With {.ID = 16, .Name = "Jennifer T. Tapia", .Department = "Production", .Position = "Manager"})
                stuff.Add(New Employee() With {.ID = 17, .Name = "Judith P. Underhill", .Department = "Finance", .Position = "Manager"})
                stuff.Add(New Employee() With {.ID = 18, .Name = "Russell E. Belton", .Department = "Finance", .Position = "Manager"})
                Return stuff
            End Function
        End Class

        Public Sub New()
            Me.InitializeComponent()
            Me.gridControl.ItemsSource = Stuff.GetStuff()
        End Sub
    End Class
End Namespace
