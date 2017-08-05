Imports System.Runtime.InteropServices

Public NotInheritable Class TaskbarProgress
    Private Sub New()
    End Sub
    Public Enum TaskbarStates
        NoProgress = 0
        Indeterminate = &H1
        Normal = &H2
        [Error] = &H4
        Paused = &H8
    End Enum

    <ComImport>
    <Guid("ea1afb91-9e28-4b86-90e9-9e9f8a5eefaf")>
    <InterfaceType(ComInterfaceType.InterfaceIsIUnknown)>
    Private Interface ITaskbarList3
        ' ITaskbarList
        <PreserveSig>
        Sub HrInit()
        <PreserveSig>
        Sub AddTab(hwnd As IntPtr)
        <PreserveSig>
        Sub DeleteTab(hwnd As IntPtr)
        <PreserveSig>
        Sub ActivateTab(hwnd As IntPtr)
        <PreserveSig>
        Sub SetActiveAlt(hwnd As IntPtr)

        ' ITaskbarList2
        <PreserveSig>
        Sub MarkFullscreenWindow(hwnd As IntPtr, <MarshalAs(UnmanagedType.Bool)> fFullscreen As Boolean)

        ' ITaskbarList3
        <PreserveSig>
        Sub SetProgressValue(hwnd As IntPtr, ullCompleted As UInt64, ullTotal As UInt64)
        <PreserveSig>
        Sub SetProgressState(hwnd As IntPtr, state As TaskbarStates)
    End Interface

    <ComImport>
    <Guid("56fdf344-fd6d-11d0-958a-006097c9a090")>
    <ClassInterface(ClassInterfaceType.None)>
    Private Class TaskbarInstance
    End Class

    Private Shared theTaskbarInstance As ITaskbarList3 = DirectCast(New TaskbarInstance(), ITaskbarList3)
    Private Shared taskbarSupported As Boolean = Environment.OSVersion.Version >= New Version(6, 1)

    Public Shared Sub SetState(windowHandle As IntPtr, taskbarState As TaskbarStates)
        If taskbarSupported Then
            theTaskbarInstance.SetProgressState(windowHandle, taskbarState)
        End If
    End Sub

    Public Shared Sub SetValue(windowHandle As IntPtr, progressValue As Double, progressMax As Double)
        If taskbarSupported Then
            theTaskbarInstance.SetProgressValue(windowHandle, CULng(progressValue), CULng(progressMax))
        End If
    End Sub
End Class

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================