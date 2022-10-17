Public Class ucCadVeiculos

    Private Sub ucCadVeiculos_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Dim lista As New List(Of String)
        lista.Add("DIESEL")
        lista.Add("ETANOL")
        lista.Add("FLEX")
        lista.Add("GASOLINA")

        CombusTxt.ItemsSource = lista.ToList
    End Sub
End Class
