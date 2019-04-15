Public Class clsPersona
    'Creando los atributos o variables
    Private _id, _edad, _numHijos As Integer
    Private _cedula, _apellido, _nombre, _genero, _nivelAcademico As String
    Private _SUELDOFIJO As Double
    Private _valorHora As Double
    Private _totalDescuento As Double
    Private _totalIngresos As Double
    Private _totalEgresos As Double
    Private _totalPagar As Double
    'constructores-inicializando
    Public Sub New()
        _id = 0
        _edad = 0
        _numHijos = 0
        _cedula = ""
        _apellido = ""
        _nombre = ""
        _genero = ""
        _nivelAcademico = ""
        _SUELDOFIJO = 0
        _valorHora = 0
        _totalDescuento = 0
        _totalPagar = 0
        _totalIngresos = 0
        _totalEgresos = 0
    End Sub

    Public Sub New(id As Integer, edad As Integer, numHijo As Integer, cedula As String, apellido As String, nombre As String, genero As String, nivAcademico As String, sueldoFijo As Double, valorHora As Double, totalDescuento As Double, totalPagar As Double, totalIngresos As Double, totalEgresos As Double)
        _id = id
        _edad = edad
        _numHijos = numHijo
        _cedula = cedula
        _apellido = apellido
        _nombre = nombre
        _genero = genero
        _nivelAcademico = nivAcademico
        _SUELDOFIJO = sueldoFijo
        _valorHora = valorHora
        _totalDescuento = totalDescuento
        _totalPagar = totalPagar
        _totalIngresos = totalIngresos
        _totalEgresos = totalEgresos
    End Sub

    'creando property GET AND SET

    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property
    Public Property edad() As Integer
        Get
            Return _edad
        End Get
        Set(ByVal value As Integer)
            _edad = value
        End Set
    End Property

    Public Property numHijos() As Integer
        Get
            Return _numHijos
        End Get
        Set(ByVal value As Integer)
            _numHijos = value
        End Set
    End Property
    Public Property cedula() As String
        Get
            Return _cedula
        End Get
        Set(ByVal value As String)
            _cedula = value
        End Set
    End Property
    Public Property apellido() As String
        Get
            Return _apellido
        End Get
        Set(ByVal value As String)
            _apellido = value
        End Set
    End Property

    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Public Property genero() As String
        Get
            Return _genero
        End Get
        Set(ByVal value As String)
            _genero = value
        End Set
    End Property
    Public Property nivelAcademico() As String
        Get
            Return _nivelAcademico
        End Get
        Set(ByVal value As String)
            _nivelAcademico = value
        End Set
    End Property
    Public Property sueldoFijo() As Double
        Get
            Return _SUELDOFIJO
        End Get
        Set(ByVal value As Double)
            _SUELDOFIJO = value
        End Set
    End Property
    Public Property valorHora() As Double
        Get
            Return _valorHora
        End Get
        Set(ByVal value As Double)
            _valorHora = value
        End Set
    End Property
    Public Property totalDescuento() As Double
        Get
            Return _totalDescuento
        End Get
        Set(ByVal value As Double)
            _totalDescuento = value
        End Set
    End Property
    Public Property totalIngresos() As Double
        Get
            Return _totalIngresos
        End Get
        Set(ByVal value As Double)
            _totalIngresos = value
        End Set
    End Property
    Public Property totalEgresos() As Double
        Get
            Return _totalEgresos
        End Get
        Set(ByVal value As Double)
            _totalEgresos = value
        End Set
    End Property
    Public Property totalPagar() As Double
        Get
            Return _totalPagar
        End Get
        Set(ByVal value As Double)
            _totalPagar = value
        End Set
    End Property

End Class
