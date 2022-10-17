Public Class Cliente
    Public Property Cpf As String
    Public Property Rg As String
    Public Property Nome As String
    Public Property DataCadastro As Date
    Public Property Inativo As Boolean
    Public Property Endereco As String
    Public Property Cidade As String
    Public Property Complemento As String
    Public Property Bairro As String
    Public Property Numero As String
    Public Property UfCmb As String
    Public Property Usuario As String
    Public Property DataGravacao As DateTime

    Public Property Contatos As List(Of ClienteContatos)
End Class
