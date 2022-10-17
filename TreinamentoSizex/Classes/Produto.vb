Public Class Produto
    ' #### MARCADORES ####
    'PRIVATE - Restrito somente a classe que está declarado
    'PROTECTED - Ele é restrito a classe que está declarado e as classes filhas da que está declarado (HERANÇA)
    'FRIEND - Público ao projeto que está inserido e restrito a outros projetos
    'PUBLIC - Publico a todos os projetos'
    Public Property Codigo As Integer
    Public Property Nome As String
    Public Property DataCadastro As Date
    Public Property Estoque As Boolean
    Public Property Grupo As String
    Public Property TipoProduto As String
    Public Property Custo As Double
    Public Property Margem As Double
    Public Property Preco As Double
    Public Property Inativo As Boolean

End Class
