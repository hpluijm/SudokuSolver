﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.0.1.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property _blnCandidates() As Boolean
            Get
                Return CType(Me("_blnCandidates"),Boolean)
            End Get
            Set
                Me("_blnCandidates") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("DodgerBlue")>  _
        Public Property _bgColour() As String
            Get
                Return CType(Me("_bgColour"),String)
            End Get
            Set
                Me("_bgColour") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("SteelBlue")>  _
        Public Property _borderColour() As String
            Get
                Return CType(Me("_borderColour"),String)
            End Get
            Set
                Me("_borderColour") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("DimGray")>  _
        Public Property _solveColour() As String
            Get
                Return CType(Me("_solveColour"),String)
            End Get
            Set
                Me("_solveColour") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Black")>  _
        Public Property _clueColour() As String
            Get
                Return CType(Me("_clueColour"),String)
            End Get
            Set
                Me("_clueColour") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("DodgerBlue")>  _
        Public Property _userColour() As String
            Get
                Return CType(Me("_userColour"),String)
            End Get
            Set
                Me("_userColour") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("7.2")>  _
        Public Property _CandidateFontSize() As Double
            Get
                Return CType(Me("_CandidateFontSize"),Double)
            End Get
            Set
                Me("_CandidateFontSize") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Verdana")>  _
        Public Property _CandidateFont() As String
            Get
                Return CType(Me("_CandidateFont"),String)
            End Get
            Set
                Me("_CandidateFont") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Tahoma")>  _
        Public Property _SolvedFont() As String
            Get
                Return CType(Me("_SolvedFont"),String)
            End Get
            Set
                Me("_SolvedFont") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("20")>  _
        Public Property _SolvedFontSize() As Double
            Get
                Return CType(Me("_SolvedFontSize"),Double)
            End Get
            Set
                Me("_SolvedFontSize") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1:True:Naked Single,1:True:Hidden Single,1:True:Locked Candidates,2:True:Naked Pa"& _ 
            "ir,2:True:Naked Triple,2:True:Naked Quad,3:True:Hidden Pair,3:True:Hidden Triple"& _ 
            ",3:True:Hidden Quad,3:True:X-Wing,3:True:Swordfish,3:True:Jellyfish,4:True:Colou"& _ 
            "r Wrap,4:True:Colour Trap,4:True:XY Wing,4:True:XYZ Wing,4:True:Brute Force")>  _
        Public Property _EnabledSolvers() As String
            Get
                Return CType(Me("_EnabledSolvers"),String)
            End Get
            Set
                Me("_EnabledSolvers") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property _PlaySounds() As Boolean
            Get
                Return CType(Me("_PlaySounds"),Boolean)
            End Get
            Set
                Me("_PlaySounds") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("DarkBlue")>  _
        Public Property _nakedColour() As String
            Get
                Return CType(Me("_nakedColour"),String)
            End Get
            Set
                Me("_nakedColour") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property _ShowNS() As Boolean
            Get
                Return CType(Me("_ShowNS"),Boolean)
            End Get
            Set
                Me("_ShowNS") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1:True:Naked Single,1:True:Hidden Single,1:True:Locked Candidates,2:True:Naked Pa"& _ 
            "ir,2:True:Naked Triple,2:True:Naked Quad,3:True:Hidden Pair,3:True:Hidden Triple"& _ 
            ",3:True:Hidden Quad,3:True:X-Wing,3:True:Swordfish,3:True:Jellyfish,4:True:Colou"& _ 
            "r Wrap,4:True:Colour Trap,4:True:XY Wing,4:True:XYZ Wing,4:True:Brute Force")>  _
        Public Property _defaultSolvers() As String
            Get
                Return CType(Me("_defaultSolvers"),String)
            End Get
            Set
                Me("_defaultSolvers") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Green")>  _
        Public Property _pColour() As String
            Get
                Return CType(Me("_pColour"),String)
            End Get
            Set
                Me("_pColour") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Blue")>  _
        Public Property _nColour() As String
            Get
                Return CType(Me("_nColour"),String)
            End Get
            Set
                Me("_nColour") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Green")>  _
        Public Property _cColour() As String
            Get
                Return CType(Me("_cColour"),String)
            End Get
            Set
                Me("_cColour") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Red")>  _
        Public Property _rColour() As String
            Get
                Return CType(Me("_rColour"),String)
            End Get
            Set
                Me("_rColour") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property _blnManualInputSuggest() As Boolean
            Get
                Return CType(Me("_blnManualInputSuggest"),Boolean)
            End Get
            Set
                Me("_blnManualInputSuggest") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("15")>  _
        Public Property _GenClassicDifficulty() As Integer
            Get
                Return CType(Me("_GenClassicDifficulty"),Integer)
            End Get
            Set
                Me("_GenClassicDifficulty") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("15")>  _
        Public Property _GenSamuraiDifficulty() As Integer
            Get
                Return CType(Me("_GenSamuraiDifficulty"),Integer)
            End Get
            Set
                Me("_GenSamuraiDifficulty") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("31")>  _
        Public Property _GenClassicSymmetry() As String
            Get
                Return CType(Me("_GenClassicSymmetry"),String)
            End Get
            Set
                Me("_GenClassicSymmetry") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("31")>  _
        Public Property _GenSamuraiSymmetry() As String
            Get
                Return CType(Me("_GenSamuraiSymmetry"),String)
            End Get
            Set
                Me("_GenSamuraiSymmetry") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("10")>  _
        Public Property _intMaxGenerate() As Integer
            Get
                Return CType(Me("_intMaxGenerate"),Integer)
            End Get
            Set
                Me("_intMaxGenerate") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("3")>  _
        Public Property _GeneratePriority() As Integer
            Get
                Return CType(Me("_GeneratePriority"),Integer)
            End Get
            Set
                Me("_GeneratePriority") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property _blnGeneratePuzzleSaveSolution() As Boolean
            Get
                Return CType(Me("_blnGeneratePuzzleSaveSolution"),Boolean)
            End Get
            Set
                Me("_blnGeneratePuzzleSaveSolution") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property _intTipoftheDay() As Integer
            Get
                Return CType(Me("_intTipoftheDay"),Integer)
            End Get
            Set
                Me("_intTipoftheDay") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property _blnShowTips() As Boolean
            Get
                Return CType(Me("_blnShowTips"),Boolean)
            End Get
            Set
                Me("_blnShowTips") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1:True:Naked Single,1:True:Hidden Single,1:True:Locked Candidates,2:True:Naked Pa"& _ 
            "ir,2:True:Naked Triple,2:True:Naked Quad,3:True:Hidden Pair,3:True:Hidden Triple"& _ 
            ",3:True:Hidden Quad,4:True:Brute Force")>  _
        Public Property _UniqueSolvers() As String
            Get
                Return CType(Me("_UniqueSolvers"),String)
            End Get
            Set
                Me("_UniqueSolvers") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.SudokuSolver.My.MySettings
            Get
                Return Global.SudokuSolver.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
