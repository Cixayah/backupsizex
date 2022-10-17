Class MainWindow

    Private Sub ProdutoMnu_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles ProdutoMnu.MouseLeftButtonDown
        Dim wd As New wdCadProdutos
        wd.ShowDialog()
    End Sub

    Private Sub ClienteMnu_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles ClienteMnu.MouseLeftButtonDown
        Dim wd As New wdCadClientes("C")
        wd.ShowDialog()
    End Sub

    Private Sub VeiculoMnu_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles VeiculoMnu.MouseLeftButtonDown
        Dim uc As New ucCadVeiculos
        Dim tb As New TabItem
        tb.Content = uc
        tb.Header = "Veículos"
        MenuTb.Items.Add(tb)
    End Sub

    Private Sub FornecedorMnu_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles FornecedorMnu.MouseLeftButtonDown
        Dim wd As New wdCadClientes("F")
        wd.ShowDialog()
    End Sub
End Class
