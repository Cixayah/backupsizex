Public Class wdCadProdutos

    Dim objProduto As Produto
    Dim srcProdutos As CollectionViewSource
    Dim lstProdutos As List(Of Produto)

#Region "Métodos - SUB - FUNCTION"
    Private Sub LimpaCampos()
        If lstProdutos.Count > 0 Then
            CodTxt.Text = lstProdutos.Select(Function(p) p.Codigo).Max
        Else
            CodTxt.Text = 1
        End If
        lstProdutos.Where(Function(p) p.TipoProduto = "ACABADO")
        DescricaoTxt.Text = ""
        SimRdb.IsChecked = True
        GrupoTxt.Text = ""
        CustoTxt.Text = "0,00"
        MargemTxt.Text = "0,00"
        PrecoTxt.Text = "0,00"
        TipoCmb.SelectedIndex = -1
        InativoChk.IsChecked = False
        DataTxt.Text = Now.Date

    End Sub
    Private Function GravaProduto(Optional ByRef retorno As String = "") As Boolean

        retorno = "1-Validando campos"
        If IsNumeric(CodTxt.Text) = False Then
            MsgBox("Código do produto não informado, verifique!", MsgBoxStyle.Information, "Validação")
            CodTxt.Focus()
            Return False
        ElseIf CInt(CodTxt.Text) = 0 Then
            MsgBox("Código do produto não informado, verifique!", MsgBoxStyle.Information, "Validação")
            CodTxt.Focus()
            Return False
        ElseIf DescricaoTxt.Text = "" Then
            MsgBox("Descrição do produto não informado, verifique!", MsgBoxStyle.Information, "Validação")
            DescricaoTxt.Focus()
            Return False
        ElseIf Not IsDate(DataTxt.Text) Then
            Return False
        ElseIf TipoCmb.SelectedIndex < 0 Then
            MsgBox("Tipo de produto não informado, verifique!", MsgBoxStyle.Information, "Validação")
        ElseIf IsNumeric(PrecoTxt.Text) = False Then
            MsgBox("Preço do produto não informado, verifique!", MsgBoxStyle.Information, "Validação")
            PrecoTxt.Focus()
            Return False
        ElseIf CDbl(PrecoTxt.Text) = 0 Then
            MsgBox("Preço do produto não informado, verifique!", MsgBoxStyle.Information, "Validação")
            PrecoTxt.Focus()
            Return False
        End If

        retorno = "2-Inserindo objeto"
        If objProduto Is Nothing Then
            objProduto = New Produto
            lstProdutos.Add(objProduto)
        End If

        retorno = "3-Gravando campos cliente"

        objProduto.DataCadastro = DataTxt.Text
        objProduto.Inativo = InativoChk.IsChecked
        objProduto.Nome = UCase(DescricaoTxt.Text)
        objProduto.Codigo = CInt(CodTxt.Text)
        objProduto.Estoque = SimRdb.IsChecked
        objProduto.Grupo = UCase(GrupoTxt.Text)
        objProduto.Margem = CDbl(MargemTxt.Text)
        objProduto.Custo = CDbl(CustoTxt.Text)
        objProduto.Preco = CDbl(PrecoTxt.Text)
        objProduto.TipoProduto = TipoCmb.Text

        retorno = "4-Concluida gravação"

        Return True
    End Function
#End Region

    Private Sub SairBtn_Click(sender As Object, e As RoutedEventArgs) Handles SairBtn.Click
        Me.Close()

    End Sub

    Private Sub SalvarBtn_Click(sender As Object, e As RoutedEventArgs) Handles SalvarBtn.Click


        If GravaProduto() = False Then
            Exit Sub
        End If
        srcProdutos.Source = lstProdutos.ToList

        MsgBox("Registro salvo com sucesso!", MsgBoxStyle.Information, "Parabéns !")
        LimpaCampos()

        DescricaoTxt.Focus()
    End Sub

    Private Sub NovoBtn_Click(sender As Object, e As RoutedEventArgs) Handles NovoBtn.Click
        LimpaCampos()
    End Sub

    Private Sub ExcluirBtn_Click(sender As Object, e As RoutedEventArgs) Handles ExcluirBtn.Click
        LimpaCampos()
    End Sub

    Private Sub wdCadProdutos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.Key
            Case Key.F2
                NovoBtn_Click(Nothing, Nothing)
            Case Key.F3
                SalvarBtn_Click(Nothing, Nothing)
            Case Key.F4
                ExcluirBtn_Click(Nothing, Nothing)
            Case Key.Escape
                SairBtn_Click(Nothing, Nothing)
        End Select
    End Sub

    Private Sub wdCadProdutos_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        srcProdutos = CType(Me.FindResource("ProdutosViewSource"), CollectionViewSource)
        lstProdutos = New List(Of Produto)
        LimpaCampos()
        CodTxt.Focus()
    End Sub

    Private Sub ProdutoDataGrid_MouseDoubleClick(sender As Object, e As MouseButtonEventArgs) Handles ProdutoDataGrid.MouseDoubleClick
        If sender.selecteditem IsNot Nothing Then
            objProduto = sender.selectedintem
            DataTxt.Text = objProduto.DataCadastro
            InativoChk.IsChecked = objProduto.Inativo
            DescricaoTxt.Text = objProduto.Nome
            CodTxt.Text = objProduto.Codigo
            If objProduto.Estoque = True Then
                SimRdb.IsChecked = True
            Else
                NaoRdb.IsChecked = True
            End If
            GrupoTxt.Text = objProduto.Grupo
            MargemTxt.Text = objProduto.Margem
            CustoTxt.Text = objProduto.Custo
            PrecoTxt.Text = objProduto.Preco
            TipoCmb.Text = objProduto.TipoProduto
        End If
    End Sub


End Class
