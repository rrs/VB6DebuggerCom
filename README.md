# VB6DebuggerCom
Test Project Exploring ActiveX DLL and VB6 Debugger

* VS IDE switch the build configuration to NET48.
* Build
* VB6 IDE Build to ./bin (you maybe need to re add TLB refs)
* cmd as admin
* regsvr32 bin/VBDebuggerMarshalling.dll
* VS IDE may need to re add reference to VBDebuggerMarshalling
* Switch to Debug
* Build
