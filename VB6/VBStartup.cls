VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "VBStartup"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True

Public Sub Startup(Factory As IDotNetObjectFactory)
    Dim DotNetObj As Rrs_VB6DebuggerMarshalling_Com.IDotNetObject
    Dim AdoObject As Rrs_Ado_Com.IAdoObject
    Set DotNetObj = Factory.NewDotNetObject
    DotNetObj.Celebrate
    Set AdoObject = Factory.NewAdoObject
    AdoObject.Connect adParamInput
End Sub
